namespace Ublux.Communications.Models;

/// <summary>
///     Child calls and parent calls must contain this
/// </summary>
public partial interface ICall
{
    /// <summary>
    ///     Date when call was created
    /// </summary>
    [AllowUpdate(false)]
    public DateTime DateCreated { get; set; }

    /// <summary>
    ///     DateEnded - DateCreated will let you know the duration of call
    /// </summary>
    [AllowUpdate(false)]
    public DateTime? DateEnded { get; set; }
}

