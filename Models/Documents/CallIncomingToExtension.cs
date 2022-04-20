﻿namespace Ublux.Communications.Domain.Models.Documents; // ReSharper disable ConditionIsAlwaysTrueOrFalse

/// <summary>
///     Incoming phone call from PSTN to an extension
/// </summary>
public partial class CallIncomingToExtension : CallIncoming
{
    #region Properties

    #region References

    /// <summary>
    ///     Extension being called
    /// </summary>
    [References(typeof(Extension))]
    [AllowUpdate(false)]
        [IsRequired]
    public string IdExtension { get; set; } = String.Empty;

    /// <summary>
    ///     Id of line that answered
    /// </summary>
    [References(typeof(Line))]
    [AllowUpdate(false)]
        public string? IdLineThatAnswered { get; set; }

    /// <summary>
    ///     Lines that rang
    /// </summary>
    [References(typeof(Line))]
    [AllowUpdate(false)]
        public List<string> IdsLinesThatRing
    {
        get => _IdsLinesThatRing;
        set { if (value is null) _IdsLinesThatRing.Clear(); else _IdsLinesThatRing = value; }
    }
    List<string> _IdsLinesThatRing = new();

    /// <summary>
    ///     Id of lines that did not ring
    /// </summary>
    [References(typeof(Line))]
    [AllowUpdate(false)]
        public List<string> IdsLinesThatDidNotRing
    {
        get => _IdsLinesThatDidNotRing;
        set { if (value is null) _IdsLinesThatDidNotRing.Clear(); else _IdsLinesThatDidNotRing = value; }
    }
    List<string> _IdsLinesThatDidNotRing = new();

    #endregion

    /// <summary>
    ///     Extension number that was called
    /// </summary>
    [AllowUpdate(false)]
        [IsRequired]
    public string ExtensionNumber { get; set; } = String.Empty;

    /// <summary>
    ///     Name of extension
    /// </summary>
    [AllowUpdate(false)]
        [IsRequired]
    public string ExtensionFriendlyName { get; set; } = String.Empty;

    #endregion




    /// <summary>
    ///     Type of call
    /// </summary>
    [AllowUpdate(false)]
        public override CallType CallType => CallType.IncomingToExtension;



    ///// <inheritdoc/>
    //public override I To()
    //{
    //    throw new NotImplementedException();
    //}

   
}
































