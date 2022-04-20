namespace Ublux.Communications.Models
{
    /// <summary>
    ///     Call is attended transferred to land-line or cell-phone
    /// </summary>
    [BsonIgnoreExtraElements]
        public class ChildCallAttendantTransferToPSTN : ChildCall
    {
        /// <summary>
        ///     Phone number where call was transferred to
        /// </summary>
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;

        /// <summary>
        ///     AttendantTransferToPSTN
        /// </summary>
        [Required]
        public override ChildCallType ChildCallType { get; } = ChildCallType.AttendantTransferToPSTN;
    }
}
