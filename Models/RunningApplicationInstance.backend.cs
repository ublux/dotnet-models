﻿#if UBLUX_BACKEND
namespace Ublux.Communications.Models;

/// <summary>
///     Used to be statis. Made it a singleton in order to be able to construct unit tests.
///     Instance that is currently running. Every instance should have a different id
///     Could service instance. Before we used to have this id on a file. Now it is part of IoC container in order to make unit tests better
/// </summary>
public class RunningApplicationInstance
{
    /// <summary>
    ///     Example US-T. This will always be in uppercase
    /// </summary>
    public required string Id { get => id; set => id = value.ToUpper(); }
    private string id = "";

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
            Id = (type + "." + Guid.NewGuid().ToString()[..4]).ToUpper(),
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

    #region IdGlobal

    /// <summary>
    ///     Used to generate ids. Placed in here because autogenerated-code makes used of this
    /// </summary>
    private ulong _idGlobalCounter;
   

    /// <summary>
    ///     Increments counter and gets current id
    /// </summary>    
    public string IdGlobalAutoIncrement()
    {
        return ToBase62(Interlocked.Increment(ref _idGlobalCounter));
    }

    /// <summary>
    ///     Get IdGlobal current value
    /// </summary>    
    public ulong IdGlobalCurrentValue()
    {
        return Interlocked.Read(ref _idGlobalCounter);
    }

    /// <summary>
    ///     This is not thread safe. call this method before initializing database.
    /// </summary>
    [Obsolete("Only set once. Having an incorrect counter will result in duplicate ids")]
    public void IdGlobalSetValue(ulong v)
    {
        _idGlobalCounter = v;
    }

    #endregion

    #region Base62

    // add: `-=[];',./~!@#$%^&*()_+{}|:<>?
    // to make it base92
    private const string charsString = @"0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    static readonly char[] base62Chars = charsString.ToCharArray();
    static readonly ulong base62CharsLength = (ulong)base62Chars.Length;

    /// <summary>
    ///     Convert from base62 string. 0=0 1=1 Z=61 10=62
    /// </summary>
    public static ulong FromBase62(string input)
    {
        ulong r = 0;
        int ctr = 0;

        for (var i = input.Length; i > 0; i--)
        {
            // 0 = 48
            // A = 65
            // a = 97
            var currChar = input[i - 1];
            var val = (ulong)charsString.IndexOf(currChar);

            if (ctr == 0)
                r = val;
            else
            {
                ulong tmp = base62CharsLength;
                for (int k = 1; k < ctr; k++)
                    tmp *= base62CharsLength;

                r += (val * tmp);
            }

            ctr++;
        }

        return r;
    }

    /// <summary>
    /// 0 = 0
    /// ...
    /// 9 = 9
    /// 10 = a
    /// 35 = Z
    /// </summary>
    public static string ToBase62(ulong input)
    {
        Span<char> result = stackalloc char[11];
        //char[] result = new char[6];

        //List<char> result = new List<char>();
        // max of 10 iterations because ulong.maxValue to base 62 is 10 characters long
        for (int i = 10; ; i--)
        {
            ulong reminder = input % base62CharsLength;
            input /= base62CharsLength;
            result[i] = base62Chars[reminder];

            if (input == 0)
                return new string(result[i..]);
        }
    }

    #endregion
}
#endif