#if UBLUX_BACKEND
namespace Ublux.Communications.Models;

/// <summary>
///     Used to be statis. Made it a singleton in order to be able to construct unit tests.
///     Instance that is currently running. Every instance should have a different id
///     Could service instance. Before we used to have this id on a file. Now it is part of IoC container in order to make unit tests better
/// </summary>
public class RunningApplicationInstance
{
    /// <summary>
    ///     Example US-T
    /// </summary>
    public required string Id { get; set; }

    /// <summary>
    ///     Type of Cloud service
    /// </summary>
    public CloudServiceType CloudServiceType { get; set; }

    /// <summary>
    ///     Application will end with this exit code
    /// </summary>
    public int ExitCode { get; set; }

    /// <summary>
    ///     Generate a random Instance. Used for unit tests 
    /// </summary>
    public static RunningApplicationInstance GenerateRandom(CloudServiceType type)
    {
        return new RunningApplicationInstance()
        {
            Id = (type + "-" + Guid.NewGuid().ToString()[..4]).ToUpper(),
            CloudServiceType = type
        };
    }

    #region NumberOfOperationsExecuting

    /// <summary>
    ///     Number of important tasks running
    ///     When stopping application gracefully we wait for this counter to equal 0. 
    ///     That way we are sure we did not terminated application in the middle of something
    /// </summary>
    public long NumberOfOperationsExecuting
    {
        get => Interlocked.Read(ref _numberOfOperationsExecuting);
        // set => numberOfOperationsExecuting = value; 
    }
    private long _numberOfOperationsExecuting;

    /// <summary>
    ///     Increment number of operations executing
    /// </summary>
    public long IncrementNumberOfOperationsExecuting()
    {
        return Interlocked.Increment(ref _numberOfOperationsExecuting);
    }
    /// <summary>
    ///     Decrement number of operations executing
    /// </summary>
    public long DecrementNumberOfOperationsExecuting()
    {
        return Interlocked.Decrement(ref _numberOfOperationsExecuting);
    }

    /// <summary>
    ///     Executes an operation that will not allow application to terminate until this operation is done
    ///     returns exception if there is an error
    /// </summary>
    public async Task<Exception?> ExecuteImportantOperationAsync(Func<Task> func)
    {
        IncrementNumberOfOperationsExecuting();

        try
        {
            await func();
            return null;
        }
        catch (Exception ex)
        {
            if (Debugger.IsAttached)
                Debugger.Break();
            
            return ex;
        }
        finally
        {
            DecrementNumberOfOperationsExecuting();
        }
    }

    /// <summary>
    ///     Returns false if timeout. true otherwise
    /// </summary>
    public async Task<bool> WaitUntilThereAreNoMoreOperationsRunningAsync(int timeoutInSeconds = 60)
    {
        // because we wait 500ms instead of 1s per iteration
        timeoutInSeconds *= 2;

        while (NumberOfOperationsExecuting > 0)
        {
            await Task.Delay(500);
            timeoutInSeconds--;

            if (timeoutInSeconds < 1)
                return false;
        }

        return true;
    }

    #endregion

    /// <summary>
    ///     Problems with cloud service
    /// </summary>
    public HashSet<CloudServiceFlag> Flags { get; set; } = new();
}
#endif