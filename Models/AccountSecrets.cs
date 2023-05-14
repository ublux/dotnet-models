using System.Security.Cryptography;

namespace Ublux.Communications.Models;

/// <summary>
///     Account secrets
/// </summary>
public class AccountSecrets
{
    /// <summary>
    ///     9 digit number that a customer must dial in order to link his phone to a new account. 
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationIsRequired]
    [UbluxValidationStringRange(5, 50)]
    public required string PinPhone { get; set; }

    /// <summary>
    ///     If you dial *7 and you enter this pin you will be able to ChanSpy "spy" on a extension
    ///     9 digits now to make it more secure
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    [UbluxValidationIsRequired]
    [UbluxValidationStringRange(9, 50)]
    public required string PinSpy { get; set; }

    /// <summary>
    ///     Helps generate new random Pin for phone and spy
    /// </summary>
    public static AccountSecrets GenerateRandom()
    {
        static int GenerateRandomInt(int minValue, int maxValueNoneInclusive)
        {
            if (minValue > maxValueNoneInclusive)
                throw new Exception("VBZI-C19R");

            // range of possible values
            UInt32 range = (UInt32)(maxValueNoneInclusive - minValue);
            Span<byte> randBytes = stackalloc byte[4];
            // It is cryptographic safe. Do not use Ransom.Shared!
            using RandomNumberGenerator rng = RandomNumberGenerator.Create();
            rng.GetBytes(randBytes);
            UInt32 randomUnsignedInt = BitConverter.ToUInt32(randBytes);
            UInt32 randomIntInRange = randomUnsignedInt % range;
            return (int)(minValue + randomIntInRange);
        }

        return new AccountSecrets()
        {
            PinPhone = GenerateRandomInt(100000000, 999999999).ToString(),
            PinSpy = GenerateRandomInt(100000000, 999999999).ToString()
        };
    }
}
