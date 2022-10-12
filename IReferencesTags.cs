namespace Ublux.Communications.Models;

/// <summary>
///     Has categories or tags.
/// </summary>
public interface IReferencesTags
{
    /// <summary>
    ///     Everything that references an account may have tags. List of id tags
    /// </summary>
    public List<string> Tags { get; set; }
}
