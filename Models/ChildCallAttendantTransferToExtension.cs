namespace Ublux.Communications.Domain.Models
{
    /// <summary>
    ///     Call is attended transferred to extension
    /// </summary>
    [BsonIgnoreExtraElements]
    public class ChildCallAttendantTransferToExtension : ChildCall
    {
        /// <summary>
        ///     Id extension to whom it was transferred
        /// </summary>
        public string IdExtension { get; set; } = string.Empty;

        /// <summary>
        ///     AttendantTransferToExtension
        /// </summary>
        [Required]
        public override ChildCallType ChildCallType { get; } = ChildCallType.AttendantTransferToExtension;
    }
}