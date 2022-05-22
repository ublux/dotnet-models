#if UBLUX_BACKEND

namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Contact
/// </summary>
public partial class Contact : UbluxDocument, IReferncesAccount
{
    /// <inheritdoc/>
    [IgnoreDataMember]
    [References(typeof(Account))]
    [AllowUpdate(false)]
    [IsRequired]
    public string IdAccount { get; set; } = String.Empty;

    /// <summary>
    ///     Because we sync contacts their ids must be as small as possible.
    ///     We convert ths counter to base62. For example contact 10,000 will have id Xa for example
    /// </summary>
    private static int _idContactGenerationCounter;

    /// <summary>
    ///     Because we sync contacts their ids must be as small as possible.
    ///     We convert ths counter to base62. For example contact 10,000 will have id Xa for example
    /// </summary>
    public static int GetNextContactGenerationCounter()
    {
        return Interlocked.Increment(ref _idContactGenerationCounter);
    }

    /// <summary>
    ///     Set only once
    /// </summary>    
    public static void SetContactGenerationCounter(int value)
    {
        _idContactGenerationCounter = value;
    }
}

#endif