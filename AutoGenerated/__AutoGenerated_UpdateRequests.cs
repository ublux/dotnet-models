/* THIS FILE IS AUTO GENERATED. DO NOT DELETE/MODIFY */
/* Contain properties with AllowUpdate=True */

// ReSharper disable RedundantNameQualifier
#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable CS8601 // Possible null reference assignment.
#pragma warning disable CS8629 // Nullable value type may be null.

namespace Ublux.Communications.Models.Documents;


/// <summary>
/// Someone that has access to consume Ublux Web Api. It can be a PBX, WA, or UbluxUser
/// </summary><summary>
/// Only users can have api keys. Everyone else should have a JWT
/// </summary>
public class ApiKeyUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Key = service/role such as Phone. The phone role probably will have access to the PhoneController service
    /// Value = Permissions it has on that role. Maybe it can only read data from that service but it cannot update, create or modify.
    /// </summary>
    public List<Ublux.Communications.Enums.UbluxRole>? UbluxRoles { get; set; }
    /// <summary>
    /// If null it will never expire. Else it will have an expiration
    /// </summary>
    public DateTime? DateExpire { get; set; }
    /// <summary>
    /// Description or notes of API key
    /// </summary>
    public String? Description { get; set; }
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnApiKey(ApiKey apiKey, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(UbluxRoles)}""", StringComparison.OrdinalIgnoreCase))
            apiKey.UbluxRoles = UbluxRoles;
        if(jsonRaw.Contains($@"""{nameof(DateExpire)}""", StringComparison.OrdinalIgnoreCase))
            apiKey.DateExpire = DateExpire.Value;
        if(jsonRaw.Contains($@"""{nameof(Description)}""", StringComparison.OrdinalIgnoreCase))
            apiKey.Description = Description;
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            apiKey.IdsTags = IdsTags;
    }

}

/// <summary>
/// Ublux Account
/// </summary><summary>
/// Ublux Account
/// </summary>
public class AccountUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Address
    /// </summary>
    public MailingAddress? MailingAddress { get; set; }
    /// <summary>
    /// Account secrets
    /// </summary>
    public AccountSecrets? AccountSecrets { get; set; }
    /// <summary>
    /// Primary language of account
    /// </summary>
    public Language? Language { get; set; }
    /// <summary>
    /// Primary country of account
    /// </summary>
    public CountryIsoCode? Country { get; set; }
    /// <summary>
    /// Name of company
    /// </summary>
    public String? CompanyName { get; set; }
    /// <summary>
    /// If CountriesThatCanCallLocally does not contain country then ublux will attempt to find country on this list and mark call as international
    /// </summary>
    public List<Ublux.Communications.Enums.CountryIsoCode>? CountriesThatCanCallInternationally { get; set; }
    /// <summary>
    /// Sector
    /// </summary>
    public Industry? Industry { get; set; }
    /// <summary>
    /// This is the case for customers that have two VOIP providers and when doing autoprovision we will reserve this index when doing autoprovision.
    /// </summary>
    public Int32? ReserveSipAccountIndex { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnAccount(Account account, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(MailingAddress)}""", StringComparison.OrdinalIgnoreCase))
            account.MailingAddress = MailingAddress;
        if(jsonRaw.Contains($@"""{nameof(AccountSecrets)}""", StringComparison.OrdinalIgnoreCase))
            account.AccountSecrets = AccountSecrets;
        if(jsonRaw.Contains($@"""{nameof(Language)}""", StringComparison.OrdinalIgnoreCase))
            account.Language = Language.Value;
        if(jsonRaw.Contains($@"""{nameof(Country)}""", StringComparison.OrdinalIgnoreCase))
            account.Country = Country.Value;
        if(jsonRaw.Contains($@"""{nameof(CompanyName)}""", StringComparison.OrdinalIgnoreCase))
            account.CompanyName = CompanyName;
        if(jsonRaw.Contains($@"""{nameof(CountriesThatCanCallInternationally)}""", StringComparison.OrdinalIgnoreCase))
            account.CountriesThatCanCallInternationally = CountriesThatCanCallInternationally;
        if(jsonRaw.Contains($@"""{nameof(Industry)}""", StringComparison.OrdinalIgnoreCase))
            account.Industry = Industry.Value;
        if(jsonRaw.Contains($@"""{nameof(ReserveSipAccountIndex)}""", StringComparison.OrdinalIgnoreCase))
            account.ReserveSipAccountIndex = ReserveSipAccountIndex.Value;
    }

}

/// <summary>
/// Email address. Two users may use the same email address
/// </summary>
public class EmailUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnEmail(Email email, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            email.IdsTags = IdsTags;
    }

}

/// <summary>
/// Store when user agreed to UBLUX terms and conditions for legal reasons.
/// </summary>
public class AgreementToTermsAndConditionsUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnAgreementToTermsAndConditions(AgreementToTermsAndConditions agreementToTermsAndConditions, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            agreementToTermsAndConditions.IdsTags = IdsTags;
    }

}

/// <summary>
/// When a customer purchases a Phone Number from AirNetworks Provider from Spain he needs to feel the province and population info
/// </summary>
public class AirNetworksProvinceUpdateRequest // : IUbluxDocumentId
{
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnAirNetworksProvince(AirNetworksProvince airNetworksProvince, string jsonRaw)
    {
    }

}

/// <summary>
/// Mp3 or Wav audio file. Previously called Audio Greeting
/// </summary><summary>
/// Mp3 or Wav audio file. Previously called Audio Greeting
/// </summary>
public class AudioUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Name of audio
    /// </summary>
    public String? FriendlyName { get; set; }
    /// <summary>
    /// Description of audio
    /// </summary>
    public String? Description { get; set; }
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnAudio(Audio audio, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            audio.FriendlyName = FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(Description)}""", StringComparison.OrdinalIgnoreCase))
            audio.Description = Description;
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            audio.IdsTags = IdsTags;
    }

}

/// <summary>
/// Id is the mac address of a phone. It should point to an ip phone
/// </summary>
public class AutoProvisionReferenceUpdateRequest // : IUbluxDocumentId
{
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnAutoProvisionReference(AutoProvisionReference autoProvisionReference, string jsonRaw)
    {
    }

}

/// <summary>
/// Phone numbers that will be blocked
/// </summary><summary>
/// Phone numbers that will be blocked
/// </summary>
public class BlackListPhoneNumberUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Optional audio to play if call is blocked
    /// </summary>
    public String? IdAudioToPlayIfCallIsBlocked { get; set; }
    /// <summary>
    /// The phone number that will be blocked
    /// </summary>
    public String? Number { get; set; }
    /// <summary>
    /// Friendly name of this rule
    /// </summary>
    public String? FriendlyName { get; set; }
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnBlackListPhoneNumber(BlackListPhoneNumber blackListPhoneNumber, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(IdAudioToPlayIfCallIsBlocked)}""", StringComparison.OrdinalIgnoreCase))
            blackListPhoneNumber.IdAudioToPlayIfCallIsBlocked = IdAudioToPlayIfCallIsBlocked;
        if(jsonRaw.Contains($@"""{nameof(Number)}""", StringComparison.OrdinalIgnoreCase))
            blackListPhoneNumber.Number = Number;
        if(jsonRaw.Contains($@"""{nameof(FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            blackListPhoneNumber.FriendlyName = FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            blackListPhoneNumber.IdsTags = IdsTags;
    }

}

/// <summary>
/// Phone numbers that will be blocked
/// </summary><summary>
/// Phone numbers that will be blocked
/// </summary>
public class CallerIdMaskUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Name of this caller id mask
    /// </summary>
    public String? FriendlyName { get; set; }
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnCallerIdMask(CallerIdMask callerIdMask, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            callerIdMask.FriendlyName = FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            callerIdMask.IdsTags = IdsTags;
    }

}

/// <summary>
/// Virtual receptionist
/// </summary><summary>
/// Virtual receptionist
/// </summary>
public class CallFlowLogicUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Name of virtual receptionist
    /// </summary>
    public String? FriendlyName { get; set; }
    /// <summary>
    /// Description of virtual receptionist
    /// </summary>
    public String? Description { get; set; }
    /// <summary>
    /// XML containing the call flow rules
    /// </summary>
    public FlowNode? Tree { get; set; }
    /// <summary>
    /// Special bookmarks on tree. This will be separate trees to share common logic
    /// </summary>
    public List<Ublux.Communications.Models.FlowNodes.NodeBookmark>? Bookmarks { get; set; }
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnCallFlowLogic(CallFlowLogic callFlowLogic, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            callFlowLogic.FriendlyName = FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(Description)}""", StringComparison.OrdinalIgnoreCase))
            callFlowLogic.Description = Description;
        if(jsonRaw.Contains($@"""{nameof(Tree)}""", StringComparison.OrdinalIgnoreCase))
            callFlowLogic.Tree = Tree;
        if(jsonRaw.Contains($@"""{nameof(Bookmarks)}""", StringComparison.OrdinalIgnoreCase))
            callFlowLogic.Bookmarks = Bookmarks;
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            callFlowLogic.IdsTags = IdsTags;
    }

}

/// <summary>
/// Incoming phone call that executed an IVR
/// </summary>
public class CallIncomingToCallFlowLogicUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Result of a call
    /// </summary>
    public CallResult? CallResult { get; set; }
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnCallIncomingToCallFlowLogic(CallIncomingToCallFlowLogic callIncomingToCallFlowLogic, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(CallResult)}""", StringComparison.OrdinalIgnoreCase))
            callIncomingToCallFlowLogic.CallResult = CallResult.Value;
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            callIncomingToCallFlowLogic.IdsTags = IdsTags;
    }

}

/// <summary>
/// Incoming phone call from PSTN to an extension
/// </summary>
public class CallIncomingToExtensionUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Result of a call
    /// </summary>
    public CallResult? CallResult { get; set; }
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnCallIncomingToExtension(CallIncomingToExtension callIncomingToExtension, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(CallResult)}""", StringComparison.OrdinalIgnoreCase))
            callIncomingToExtension.CallResult = CallResult.Value;
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            callIncomingToExtension.IdsTags = IdsTags;
    }

}

/// <summary>
/// Call made to an extension
/// </summary>
public class CallOutgoingToExtensionUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Result of a call
    /// </summary>
    public CallResult? CallResult { get; set; }
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnCallOutgoingToExtension(CallOutgoingToExtension callOutgoingToExtension, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(CallResult)}""", StringComparison.OrdinalIgnoreCase))
            callOutgoingToExtension.CallResult = CallResult.Value;
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            callOutgoingToExtension.IdsTags = IdsTags;
    }

}

/// <summary>
/// Call made to cell phone or land line
/// </summary><summary>
/// Call made to cell phone or land line
/// </summary>
public class CallOutgoingToPSTNUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Result of a call
    /// </summary>
    public CallResult? CallResult { get; set; }
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnCallOutgoingToPSTN(CallOutgoingToPSTN callOutgoingToPSTN, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(CallResult)}""", StringComparison.OrdinalIgnoreCase))
            callOutgoingToPSTN.CallResult = CallResult.Value;
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            callOutgoingToPSTN.IdsTags = IdsTags;
    }

}

/// <summary>
/// PBX cloud service where phones connect
/// </summary>
public class CloudServicePbxUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// If true we will not monitor pbx in order to update its soft dns in case it is not healthy
    /// </summary>
    public Boolean? DisableMonitoring { get; set; }
    /// <summary>
    /// If used as gateway then by what account
    /// </summary>
    public String? IdAccountGateway { get; set; }
    /// <summary>
    /// We need instance id in order to reboot cloud service for example. Example: i-0655b45b8134e6425
    /// </summary>
    public String? ProviderInstanceId { get; set; }
    /// <summary>
    /// Region is needed to connect to EC2 instance when using AWS for example: USEast1 or EUWest3 for europe paris
    /// </summary>
    public String? ProviderRegion { get; set; }
    /// <summary>
    /// Example AWS for amazon web services
    /// </summary>
    public CloudServiceProviderType? ProviderType { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnCloudServicePbx(CloudServicePbx cloudServicePbx, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(DisableMonitoring)}""", StringComparison.OrdinalIgnoreCase))
            cloudServicePbx.DisableMonitoring = DisableMonitoring.Value;
        if(jsonRaw.Contains($@"""{nameof(IdAccountGateway)}""", StringComparison.OrdinalIgnoreCase))
            cloudServicePbx.IdAccountGateway = IdAccountGateway;
        if(jsonRaw.Contains($@"""{nameof(ProviderInstanceId)}""", StringComparison.OrdinalIgnoreCase))
            cloudServicePbx.ProviderInstanceId = ProviderInstanceId;
        if(jsonRaw.Contains($@"""{nameof(ProviderRegion)}""", StringComparison.OrdinalIgnoreCase))
            cloudServicePbx.ProviderRegion = ProviderRegion;
        if(jsonRaw.Contains($@"""{nameof(ProviderType)}""", StringComparison.OrdinalIgnoreCase))
            cloudServicePbx.ProviderType = ProviderType.Value;
    }

}

/// <summary>
/// Transcription Cloud service
/// </summary>
public class CloudServiceTranscriptionUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// We need instance id in order to reboot cloud service for example. Example: i-0655b45b8134e6425
    /// </summary>
    public String? ProviderInstanceId { get; set; }
    /// <summary>
    /// Region is needed to connect to EC2 instance when using AWS for example: USEast1 or EUWest3 for europe paris
    /// </summary>
    public String? ProviderRegion { get; set; }
    /// <summary>
    /// Example AWS for amazon web services
    /// </summary>
    public CloudServiceProviderType? ProviderType { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnCloudServiceTranscription(CloudServiceTranscription cloudServiceTranscription, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(ProviderInstanceId)}""", StringComparison.OrdinalIgnoreCase))
            cloudServiceTranscription.ProviderInstanceId = ProviderInstanceId;
        if(jsonRaw.Contains($@"""{nameof(ProviderRegion)}""", StringComparison.OrdinalIgnoreCase))
            cloudServiceTranscription.ProviderRegion = ProviderRegion;
        if(jsonRaw.Contains($@"""{nameof(ProviderType)}""", StringComparison.OrdinalIgnoreCase))
            cloudServiceTranscription.ProviderType = ProviderType.Value;
    }

}

/// <summary>
/// Web app where web-phone lives
/// </summary>
public class CloudServiceWebAppUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// In case web-app fails point it to another one
    /// </summary>
    public String? IdCloudServiceWebAppFailover { get; set; }
    /// <summary>
    /// We need instance id in order to reboot cloud service for example. Example: i-0655b45b8134e6425
    /// </summary>
    public String? ProviderInstanceId { get; set; }
    /// <summary>
    /// Region is needed to connect to EC2 instance when using AWS for example: USEast1 or EUWest3 for europe paris
    /// </summary>
    public String? ProviderRegion { get; set; }
    /// <summary>
    /// Example AWS for amazon web services
    /// </summary>
    public CloudServiceProviderType? ProviderType { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnCloudServiceWebApp(CloudServiceWebApp cloudServiceWebApp, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(IdCloudServiceWebAppFailover)}""", StringComparison.OrdinalIgnoreCase))
            cloudServiceWebApp.IdCloudServiceWebAppFailover = IdCloudServiceWebAppFailover;
        if(jsonRaw.Contains($@"""{nameof(ProviderInstanceId)}""", StringComparison.OrdinalIgnoreCase))
            cloudServiceWebApp.ProviderInstanceId = ProviderInstanceId;
        if(jsonRaw.Contains($@"""{nameof(ProviderRegion)}""", StringComparison.OrdinalIgnoreCase))
            cloudServiceWebApp.ProviderRegion = ProviderRegion;
        if(jsonRaw.Contains($@"""{nameof(ProviderType)}""", StringComparison.OrdinalIgnoreCase))
            cloudServiceWebApp.ProviderType = ProviderType.Value;
    }

}

/// <summary>
/// Server where ublux website lives
/// </summary>
public class CloudServiceWebHostUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// We need instance id in order to reboot cloud service for example. Example: i-0655b45b8134e6425
    /// </summary>
    public String? ProviderInstanceId { get; set; }
    /// <summary>
    /// Region is needed to connect to EC2 instance when using AWS for example: USEast1 or EUWest3 for europe paris
    /// </summary>
    public String? ProviderRegion { get; set; }
    /// <summary>
    /// Example AWS for amazon web services
    /// </summary>
    public CloudServiceProviderType? ProviderType { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnCloudServiceWebHost(CloudServiceWebHost cloudServiceWebHost, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(ProviderInstanceId)}""", StringComparison.OrdinalIgnoreCase))
            cloudServiceWebHost.ProviderInstanceId = ProviderInstanceId;
        if(jsonRaw.Contains($@"""{nameof(ProviderRegion)}""", StringComparison.OrdinalIgnoreCase))
            cloudServiceWebHost.ProviderRegion = ProviderRegion;
        if(jsonRaw.Contains($@"""{nameof(ProviderType)}""", StringComparison.OrdinalIgnoreCase))
            cloudServiceWebHost.ProviderType = ProviderType.Value;
    }

}

/// <summary>
/// Contact
/// </summary>
public class ContactUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Phone numbers of contact
    /// Key = phone number
    /// Value = type (example = work)
    /// </summary>
    public List<Ublux.Communications.Models.ContactNumber>? ContactNumbers { get; set; }
    /// <summary>
    /// Email addresses of contact
    /// </summary>
    public List<Ublux.Communications.Models.ContactEmail>? ContactEmails { get; set; }
    /// <summary>
    /// Mailing Addresses of contact
    /// </summary>
    public List<Ublux.Communications.Models.MailingAddress>? MailingAddresses { get; set; }
    /// <summary>
    /// Contact first name
    /// </summary>
    public String? FirstName { get; set; }
    /// <summary>
    /// Contact last name
    /// </summary>
    public String? LastName { get; set; }
    /// <summary>
    /// Contact job tittle
    /// </summary>
    public String? JobTitle { get; set; }
    /// <summary></summary>
    public String? Company { get; set; }
    /// <summary>
    /// Contact Notes
    /// </summary>
    public String? Notes { get; set; }
    /// <summary>
    /// Customer custom data
    /// </summary>
    public List<Ublux.Communications.Models.Variable>? Variables { get; set; }
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnContact(Contact contact, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(ContactNumbers)}""", StringComparison.OrdinalIgnoreCase))
            contact.ContactNumbers = ContactNumbers;
        if(jsonRaw.Contains($@"""{nameof(ContactEmails)}""", StringComparison.OrdinalIgnoreCase))
            contact.ContactEmails = ContactEmails;
        if(jsonRaw.Contains($@"""{nameof(MailingAddresses)}""", StringComparison.OrdinalIgnoreCase))
            contact.MailingAddresses = MailingAddresses;
        if(jsonRaw.Contains($@"""{nameof(FirstName)}""", StringComparison.OrdinalIgnoreCase))
            contact.FirstName = FirstName;
        if(jsonRaw.Contains($@"""{nameof(LastName)}""", StringComparison.OrdinalIgnoreCase))
            contact.LastName = LastName;
        if(jsonRaw.Contains($@"""{nameof(JobTitle)}""", StringComparison.OrdinalIgnoreCase))
            contact.JobTitle = JobTitle;
        if(jsonRaw.Contains($@"""{nameof(Company)}""", StringComparison.OrdinalIgnoreCase))
            contact.Company = Company;
        if(jsonRaw.Contains($@"""{nameof(Notes)}""", StringComparison.OrdinalIgnoreCase))
            contact.Notes = Notes;
        if(jsonRaw.Contains($@"""{nameof(Variables)}""", StringComparison.OrdinalIgnoreCase))
            contact.Variables = Variables;
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            contact.IdsTags = IdsTags;
    }

}

/// <summary>
/// Needed because some providers like the one from Spain require customers info in order to purchase VoipNumber
/// </summary>
public class CustomerInfoUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Address where this phone number is intended to be used
    /// </summary>
    public MailingAddress? MailingAddress { get; set; }
    /// <summary>
    /// Full legal name
    /// </summary>
    public String? FullName { get; set; }
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnCustomerInfo(CustomerInfo customerInfo, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(MailingAddress)}""", StringComparison.OrdinalIgnoreCase))
            customerInfo.MailingAddress = MailingAddress;
        if(jsonRaw.Contains($@"""{nameof(FullName)}""", StringComparison.OrdinalIgnoreCase))
            customerInfo.FullName = FullName;
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            customerInfo.IdsTags = IdsTags;
    }

}

/// <summary>
/// Executes a custom IVR when calling this extension
/// </summary>
public class ExtensionCallFlowLogicUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Id of call flow to execute
    /// </summary>
    public String? IdCallFlowLogic { get; set; }
    /// <summary>
    /// Optional label to jump to on the call flow?
    /// </summary>
    public String? CallFlowLabel { get; set; }
    /// <summary>
    /// Execute call flow with this timezone.
    /// This is important if you have the IfBusinessHours node in the call flow for example.
    /// </summary>
    public String? TimeZone { get; set; }
    /// <summary>
    /// Music on hold to use
    /// </summary>
    public String? IdMusicOnHoldGroup { get; set; }
    /// <summary>
    /// Audio to play before calling extension. It is common to play an audio that says that the call is being recorded for example.
    /// </summary>
    public String? IdAudioToPlayBeforeCallingExtension { get; set; }
    /// <summary>
    /// Extension friendly name
    /// </summary>
    public String? FriendlyName { get; set; }
    /// <summary>
    /// Extension number
    /// </summary>
    public String? Number { get; set; }
    /// <summary>
    /// Inject extension name to caller id
    /// </summary>
    public Boolean? InjectExtensionNameToCallerId { get; set; }
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnExtensionCallFlowLogic(ExtensionCallFlowLogic extensionCallFlowLogic, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(IdCallFlowLogic)}""", StringComparison.OrdinalIgnoreCase))
            extensionCallFlowLogic.IdCallFlowLogic = IdCallFlowLogic;
        if(jsonRaw.Contains($@"""{nameof(CallFlowLabel)}""", StringComparison.OrdinalIgnoreCase))
            extensionCallFlowLogic.CallFlowLabel = CallFlowLabel;
        if(jsonRaw.Contains($@"""{nameof(TimeZone)}""", StringComparison.OrdinalIgnoreCase))
            extensionCallFlowLogic.TimeZone = TimeZone;
        if(jsonRaw.Contains($@"""{nameof(IdMusicOnHoldGroup)}""", StringComparison.OrdinalIgnoreCase))
            extensionCallFlowLogic.IdMusicOnHoldGroup = IdMusicOnHoldGroup;
        if(jsonRaw.Contains($@"""{nameof(IdAudioToPlayBeforeCallingExtension)}""", StringComparison.OrdinalIgnoreCase))
            extensionCallFlowLogic.IdAudioToPlayBeforeCallingExtension = IdAudioToPlayBeforeCallingExtension;
        if(jsonRaw.Contains($@"""{nameof(FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            extensionCallFlowLogic.FriendlyName = FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(Number)}""", StringComparison.OrdinalIgnoreCase))
            extensionCallFlowLogic.Number = Number;
        if(jsonRaw.Contains($@"""{nameof(InjectExtensionNameToCallerId)}""", StringComparison.OrdinalIgnoreCase))
            extensionCallFlowLogic.InjectExtensionNameToCallerId = InjectExtensionNameToCallerId.Value;
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            extensionCallFlowLogic.IdsTags = IdsTags;
    }

}

/// <summary>
/// Parties that dial this extension will be connected
/// </summary>
public class ExtensionConferenceUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Optional audio to hear when the first participant enters the conference
    /// </summary>
    public List<System.String>? IdsAudiosWhenOneParticipant { get; set; }
    /// <summary>
    /// Announce to everyone on the conference when a new participant enters the conference
    /// </summary>
    public Boolean? AnnounceParticipants { get; set; }
    /// <summary>
    /// Optional pin may be required to avoid unauthorized access to the conference
    /// Pin is of type string because value could be 0000 and that would translate to 0 as an integer
    /// </summary>
    public String? Pin { get; set; }
    /// <summary>
    /// Music on hold to use
    /// </summary>
    public String? IdMusicOnHoldGroup { get; set; }
    /// <summary>
    /// Audio to play before calling extension. It is common to play an audio that says that the call is being recorded for example.
    /// </summary>
    public String? IdAudioToPlayBeforeCallingExtension { get; set; }
    /// <summary>
    /// Extension friendly name
    /// </summary>
    public String? FriendlyName { get; set; }
    /// <summary>
    /// Extension number
    /// </summary>
    public String? Number { get; set; }
    /// <summary>
    /// Inject extension name to caller id
    /// </summary>
    public Boolean? InjectExtensionNameToCallerId { get; set; }
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnExtensionConference(ExtensionConference extensionConference, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(IdsAudiosWhenOneParticipant)}""", StringComparison.OrdinalIgnoreCase))
            extensionConference.IdsAudiosWhenOneParticipant = IdsAudiosWhenOneParticipant;
        if(jsonRaw.Contains($@"""{nameof(AnnounceParticipants)}""", StringComparison.OrdinalIgnoreCase))
            extensionConference.AnnounceParticipants = AnnounceParticipants.Value;
        if(jsonRaw.Contains($@"""{nameof(Pin)}""", StringComparison.OrdinalIgnoreCase))
            extensionConference.Pin = Pin;
        if(jsonRaw.Contains($@"""{nameof(IdMusicOnHoldGroup)}""", StringComparison.OrdinalIgnoreCase))
            extensionConference.IdMusicOnHoldGroup = IdMusicOnHoldGroup;
        if(jsonRaw.Contains($@"""{nameof(IdAudioToPlayBeforeCallingExtension)}""", StringComparison.OrdinalIgnoreCase))
            extensionConference.IdAudioToPlayBeforeCallingExtension = IdAudioToPlayBeforeCallingExtension;
        if(jsonRaw.Contains($@"""{nameof(FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            extensionConference.FriendlyName = FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(Number)}""", StringComparison.OrdinalIgnoreCase))
            extensionConference.Number = Number;
        if(jsonRaw.Contains($@"""{nameof(InjectExtensionNameToCallerId)}""", StringComparison.OrdinalIgnoreCase))
            extensionConference.InjectExtensionNameToCallerId = InjectExtensionNameToCallerId.Value;
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            extensionConference.IdsTags = IdsTags;
    }

}

/// <summary>
/// Basic extension
/// </summary>
public class ExtensionDialUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Phones to call and ring. Minimum of one line is required
    /// </summary>
    public List<System.String>? IdsPhones { get; set; }
    /// <summary>
    /// EventAction to execute if call is not answered
    /// </summary>
    public EventAction? EventActionToExecuteIfNotAnswered { get; set; }
    /// <summary>
    /// Send email notification if call is not answered
    /// </summary>
    public SendEmailNotificationIfNotAnswered? SendEmailNotificationIfNotAnswered { get; set; }
    /// <summary>
    /// Handicap to ensure all phones take an equal number of calls
    /// </summary>
    public Handicap? Handicap { get; set; }
    /// <summary>
    /// Only one feature can be turned on
    /// </summary>
    public AiExtensionFeatures? AiFeatures { get; set; }
    /// <summary>
    /// Number of seconds each line will ring
    /// </summary>
    public Int32? RingTimeInSeconds { get; set; }
    /// <summary>
    /// Music on hold to use
    /// </summary>
    public String? IdMusicOnHoldGroup { get; set; }
    /// <summary>
    /// Audio to play before calling extension. It is common to play an audio that says that the call is being recorded for example.
    /// </summary>
    public String? IdAudioToPlayBeforeCallingExtension { get; set; }
    /// <summary>
    /// Extension friendly name
    /// </summary>
    public String? FriendlyName { get; set; }
    /// <summary>
    /// Extension number
    /// </summary>
    public String? Number { get; set; }
    /// <summary>
    /// Inject extension name to caller id
    /// </summary>
    public Boolean? InjectExtensionNameToCallerId { get; set; }
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnExtensionDial(ExtensionDial extensionDial, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(IdsPhones)}""", StringComparison.OrdinalIgnoreCase))
            extensionDial.IdsPhones = IdsPhones;
        if(jsonRaw.Contains($@"""{nameof(EventActionToExecuteIfNotAnswered)}""", StringComparison.OrdinalIgnoreCase))
            extensionDial.EventActionToExecuteIfNotAnswered = EventActionToExecuteIfNotAnswered;
        if(jsonRaw.Contains($@"""{nameof(SendEmailNotificationIfNotAnswered)}""", StringComparison.OrdinalIgnoreCase))
            extensionDial.SendEmailNotificationIfNotAnswered = SendEmailNotificationIfNotAnswered;
        if(jsonRaw.Contains($@"""{nameof(Handicap)}""", StringComparison.OrdinalIgnoreCase))
            extensionDial.Handicap = Handicap;
        if(jsonRaw.Contains($@"""{nameof(AiFeatures)}""", StringComparison.OrdinalIgnoreCase))
            extensionDial.AiFeatures = AiFeatures;
        if(jsonRaw.Contains($@"""{nameof(RingTimeInSeconds)}""", StringComparison.OrdinalIgnoreCase))
            extensionDial.RingTimeInSeconds = RingTimeInSeconds.Value;
        if(jsonRaw.Contains($@"""{nameof(IdMusicOnHoldGroup)}""", StringComparison.OrdinalIgnoreCase))
            extensionDial.IdMusicOnHoldGroup = IdMusicOnHoldGroup;
        if(jsonRaw.Contains($@"""{nameof(IdAudioToPlayBeforeCallingExtension)}""", StringComparison.OrdinalIgnoreCase))
            extensionDial.IdAudioToPlayBeforeCallingExtension = IdAudioToPlayBeforeCallingExtension;
        if(jsonRaw.Contains($@"""{nameof(FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            extensionDial.FriendlyName = FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(Number)}""", StringComparison.OrdinalIgnoreCase))
            extensionDial.Number = Number;
        if(jsonRaw.Contains($@"""{nameof(InjectExtensionNameToCallerId)}""", StringComparison.OrdinalIgnoreCase))
            extensionDial.InjectExtensionNameToCallerId = InjectExtensionNameToCallerId.Value;
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            extensionDial.IdsTags = IdsTags;
    }

}

/// <summary>
/// Determines how will a call be AI processed. What questions will be asked to the AI engine
/// </summary>
public class AiCallAnalysisInputUpdateRequest // : IUbluxDocumentId
{
    /// <summary></summary>
    public String? FriendlyName { get; set; }
    /// <summary></summary>
    public String? Description { get; set; }
    /// <summary>
    /// List of queries to ask AI engine about a call
    /// </summary>
    public List<Ublux.Communications.Models.AiCallAnalysisQuery>? Queries { get; set; }
    /// <summary>
    /// Send email
    /// </summary>
    public AiCallSendEmail? SendEmail { get; set; }
    /// <summary>
    /// Engine to use. If null Ublux will use the default engine
    /// </summary>
    public String? Engine { get; set; }
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnAiCallAnalysisInput(AiCallAnalysisInput aiCallAnalysisInput, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            aiCallAnalysisInput.FriendlyName = FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(Description)}""", StringComparison.OrdinalIgnoreCase))
            aiCallAnalysisInput.Description = Description;
        if(jsonRaw.Contains($@"""{nameof(Queries)}""", StringComparison.OrdinalIgnoreCase))
            aiCallAnalysisInput.Queries = Queries;
        if(jsonRaw.Contains($@"""{nameof(SendEmail)}""", StringComparison.OrdinalIgnoreCase))
            aiCallAnalysisInput.SendEmail = SendEmail;
        if(jsonRaw.Contains($@"""{nameof(Engine)}""", StringComparison.OrdinalIgnoreCase))
            aiCallAnalysisInput.Engine = Engine;
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            aiCallAnalysisInput.IdsTags = IdsTags;
    }

}

/// <summary>
/// Extension where people that call will be placed on a sequence awaiting their turn to be attended
/// </summary>
public class ExtensionQueueUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Audios to play meanwhile caller is waiting to be attended
    /// </summary>
    public List<System.String>? IdsAudios { get; set; }
    /// <summary>
    /// Send email notification if call takes to long to be answered
    /// </summary>
    public SendEmailNotificationIfItTakesToLongToBeAnswered? SendEmailNotificationIfItTakesToLongToBeAnswered { get; set; }
    /// <summary>
    /// If line is busy do you still want it to ring it?
    /// </summary>
    public Boolean? RingInUse { get; set; }
    /// <summary>
    /// Maximum amount of minutes a user can be waiting on the queue.
    /// </summary>
    public Int32? QueueTimeoutInMinutes { get; set; }
    /// <summary>
    /// Play position announcements. For example say things like you are now position 2 in queue. There are 2 calls ahead of you.
    /// </summary>
    public Boolean? AnnouncePosition { get; set; }
    /// <summary>
    /// Play thinks like. Currently wait time is 2 minutes
    /// </summary>
    public Boolean? AnnounceHoldTime { get; set; }
    /// <summary>
    /// How often to announce stuff?
    /// </summary>
    public Int32? AnnounceFrequency { get; set; }
    /// <summary>
    /// Number of seconds to wait in between rings. Default value if null is 20 seconds
    /// </summary>
    public Int32? RetryFrequency { get; set; }
    /// <summary>
    /// Strategy to ring queue. Default is RingAll
    /// </summary>
    public QueueRingStrategy? RingStrategy { get; set; }
    /// <summary>
    /// Phones to call and ring. Minimum of one line is required
    /// </summary>
    public List<System.String>? IdsPhones { get; set; }
    /// <summary>
    /// EventAction to execute if call is not answered
    /// </summary>
    public EventAction? EventActionToExecuteIfNotAnswered { get; set; }
    /// <summary>
    /// Send email notification if call is not answered
    /// </summary>
    public SendEmailNotificationIfNotAnswered? SendEmailNotificationIfNotAnswered { get; set; }
    /// <summary>
    /// Handicap to ensure all phones take an equal number of calls
    /// </summary>
    public Handicap? Handicap { get; set; }
    /// <summary>
    /// Only one feature can be turned on
    /// </summary>
    public AiExtensionFeatures? AiFeatures { get; set; }
    /// <summary>
    /// Number of seconds each line will ring
    /// </summary>
    public Int32? RingTimeInSeconds { get; set; }
    /// <summary>
    /// Music on hold to use
    /// </summary>
    public String? IdMusicOnHoldGroup { get; set; }
    /// <summary>
    /// Audio to play before calling extension. It is common to play an audio that says that the call is being recorded for example.
    /// </summary>
    public String? IdAudioToPlayBeforeCallingExtension { get; set; }
    /// <summary>
    /// Extension friendly name
    /// </summary>
    public String? FriendlyName { get; set; }
    /// <summary>
    /// Extension number
    /// </summary>
    public String? Number { get; set; }
    /// <summary>
    /// Inject extension name to caller id
    /// </summary>
    public Boolean? InjectExtensionNameToCallerId { get; set; }
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnExtensionQueue(ExtensionQueue extensionQueue, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(IdsAudios)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.IdsAudios = IdsAudios;
        if(jsonRaw.Contains($@"""{nameof(SendEmailNotificationIfItTakesToLongToBeAnswered)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.SendEmailNotificationIfItTakesToLongToBeAnswered = SendEmailNotificationIfItTakesToLongToBeAnswered;
        if(jsonRaw.Contains($@"""{nameof(RingInUse)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.RingInUse = RingInUse.Value;
        if(jsonRaw.Contains($@"""{nameof(QueueTimeoutInMinutes)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.QueueTimeoutInMinutes = QueueTimeoutInMinutes.Value;
        if(jsonRaw.Contains($@"""{nameof(AnnouncePosition)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.AnnouncePosition = AnnouncePosition.Value;
        if(jsonRaw.Contains($@"""{nameof(AnnounceHoldTime)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.AnnounceHoldTime = AnnounceHoldTime.Value;
        if(jsonRaw.Contains($@"""{nameof(AnnounceFrequency)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.AnnounceFrequency = AnnounceFrequency.Value;
        if(jsonRaw.Contains($@"""{nameof(RetryFrequency)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.RetryFrequency = RetryFrequency.Value;
        if(jsonRaw.Contains($@"""{nameof(RingStrategy)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.RingStrategy = RingStrategy.Value;
        if(jsonRaw.Contains($@"""{nameof(IdsPhones)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.IdsPhones = IdsPhones;
        if(jsonRaw.Contains($@"""{nameof(EventActionToExecuteIfNotAnswered)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.EventActionToExecuteIfNotAnswered = EventActionToExecuteIfNotAnswered;
        if(jsonRaw.Contains($@"""{nameof(SendEmailNotificationIfNotAnswered)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.SendEmailNotificationIfNotAnswered = SendEmailNotificationIfNotAnswered;
        if(jsonRaw.Contains($@"""{nameof(Handicap)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.Handicap = Handicap;
        if(jsonRaw.Contains($@"""{nameof(AiFeatures)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.AiFeatures = AiFeatures;
        if(jsonRaw.Contains($@"""{nameof(RingTimeInSeconds)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.RingTimeInSeconds = RingTimeInSeconds.Value;
        if(jsonRaw.Contains($@"""{nameof(IdMusicOnHoldGroup)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.IdMusicOnHoldGroup = IdMusicOnHoldGroup;
        if(jsonRaw.Contains($@"""{nameof(IdAudioToPlayBeforeCallingExtension)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.IdAudioToPlayBeforeCallingExtension = IdAudioToPlayBeforeCallingExtension;
        if(jsonRaw.Contains($@"""{nameof(FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.FriendlyName = FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(Number)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.Number = Number;
        if(jsonRaw.Contains($@"""{nameof(InjectExtensionNameToCallerId)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.InjectExtensionNameToCallerId = InjectExtensionNameToCallerId.Value;
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.IdsTags = IdsTags;
    }

}

/// <summary>
/// Calling this extension will enable to store a voicemail and be sent via email
/// </summary>
public class ExtensionVoicemailUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Optional audio to play before leaving voicemail
    /// </summary>
    public String? IdAudio { get; set; }
    /// <summary>
    /// Phones that can listen to this voicemail on their phones. It is also possible to listen to voicemails through phones and not just email.
    /// </summary>
    public List<System.String>? IdsPhonesThatCanListenToVoicemail { get; set; }
    /// <summary>
    /// Emails where to send the voicemail
    /// </summary>
    public String? IdEmail { get; set; }
    /// <summary>
    /// This text will be converted to audio and be played before leaving voicemail
    /// </summary>
    public String? TextToSpeech { get; set; }
    /// <summary>
    /// If using tts (text to speech) then what voice id to use with amazon? Joana?
    /// </summary>
    public String? TextToSpeechVoiceId { get; set; }
    /// <summary>
    /// Music on hold to use
    /// </summary>
    public String? IdMusicOnHoldGroup { get; set; }
    /// <summary>
    /// Audio to play before calling extension. It is common to play an audio that says that the call is being recorded for example.
    /// </summary>
    public String? IdAudioToPlayBeforeCallingExtension { get; set; }
    /// <summary>
    /// Extension friendly name
    /// </summary>
    public String? FriendlyName { get; set; }
    /// <summary>
    /// Extension number
    /// </summary>
    public String? Number { get; set; }
    /// <summary>
    /// Inject extension name to caller id
    /// </summary>
    public Boolean? InjectExtensionNameToCallerId { get; set; }
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnExtensionVoicemail(ExtensionVoicemail extensionVoicemail, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(IdAudio)}""", StringComparison.OrdinalIgnoreCase))
            extensionVoicemail.IdAudio = IdAudio;
        if(jsonRaw.Contains($@"""{nameof(IdsPhonesThatCanListenToVoicemail)}""", StringComparison.OrdinalIgnoreCase))
            extensionVoicemail.IdsPhonesThatCanListenToVoicemail = IdsPhonesThatCanListenToVoicemail;
        if(jsonRaw.Contains($@"""{nameof(IdEmail)}""", StringComparison.OrdinalIgnoreCase))
            extensionVoicemail.IdEmail = IdEmail;
        if(jsonRaw.Contains($@"""{nameof(TextToSpeech)}""", StringComparison.OrdinalIgnoreCase))
            extensionVoicemail.TextToSpeech = TextToSpeech;
        if(jsonRaw.Contains($@"""{nameof(TextToSpeechVoiceId)}""", StringComparison.OrdinalIgnoreCase))
            extensionVoicemail.TextToSpeechVoiceId = TextToSpeechVoiceId;
        if(jsonRaw.Contains($@"""{nameof(IdMusicOnHoldGroup)}""", StringComparison.OrdinalIgnoreCase))
            extensionVoicemail.IdMusicOnHoldGroup = IdMusicOnHoldGroup;
        if(jsonRaw.Contains($@"""{nameof(IdAudioToPlayBeforeCallingExtension)}""", StringComparison.OrdinalIgnoreCase))
            extensionVoicemail.IdAudioToPlayBeforeCallingExtension = IdAudioToPlayBeforeCallingExtension;
        if(jsonRaw.Contains($@"""{nameof(FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            extensionVoicemail.FriendlyName = FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(Number)}""", StringComparison.OrdinalIgnoreCase))
            extensionVoicemail.Number = Number;
        if(jsonRaw.Contains($@"""{nameof(InjectExtensionNameToCallerId)}""", StringComparison.OrdinalIgnoreCase))
            extensionVoicemail.InjectExtensionNameToCallerId = InjectExtensionNameToCallerId.Value;
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            extensionVoicemail.IdsTags = IdsTags;
    }

}

/// <summary>
/// Incoming fax
/// </summary>
public class FaxIncomingUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnFaxIncoming(FaxIncoming faxIncoming, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            faxIncoming.IdsTags = IdsTags;
    }

}

/// <summary>
/// Group of faxes sent as a group via email
/// </summary>
public class FaxOutgoingGroupUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnFaxOutgoingGroup(FaxOutgoingGroup faxOutgoingGroup, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            faxOutgoingGroup.IdsTags = IdsTags;
    }

}

/// <summary>
/// Someone that has access to consume Ublux Web Api. It can be a PBX, WA, or Admin.
/// If its a PBX user for example it must point to account tbd 27
/// </summary>
public class UserUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Key = service/role such as Phone. The phone role probably will have access to the PhoneController service
    /// Value = Permissions it has on that role. Maybe it can only read data from that service but it cannot update, create or modify.
    /// </summary>
    public List<Ublux.Communications.Enums.UbluxRole>? UbluxRoles { get; set; }
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnUser(User user, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(UbluxRoles)}""", StringComparison.OrdinalIgnoreCase))
            user.UbluxRoles = UbluxRoles;
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            user.IdsTags = IdsTags;
    }

}

/// <summary>
/// Group of line keys
/// </summary>
public class SpeedDialGroupUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Group of speed dial keys. Must have at least one
    /// </summary>
    public List<Ublux.Communications.Models.SpeedDial>? SpeedDials { get; set; }
    /// <summary>
    /// Friendly name of line key group
    /// </summary>
    public String? FriendlyName { get; set; }
    /// <summary>
    /// Description of line key group
    /// </summary>
    public String? Description { get; set; }
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnSpeedDialGroup(SpeedDialGroup speedDialGroup, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(SpeedDials)}""", StringComparison.OrdinalIgnoreCase))
            speedDialGroup.SpeedDials = SpeedDials;
        if(jsonRaw.Contains($@"""{nameof(FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            speedDialGroup.FriendlyName = FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(Description)}""", StringComparison.OrdinalIgnoreCase))
            speedDialGroup.Description = Description;
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            speedDialGroup.IdsTags = IdsTags;
    }

}

/// <summary>
/// All request sent to ublux will be stored.
/// </summary><summary>
/// All request sent to ublux will be stored.
/// </summary>
public class LogApiRequestUpdateRequest // : IUbluxDocumentId
{
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnLogApiRequest(LogApiRequest logApiRequest, string jsonRaw)
    {
    }

}

/// <summary>
/// Multiple audios to be used as music on hold
/// </summary>
public class MusicOnHoldGroupUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Audios to play meanwhile on hold
    /// </summary>
    public List<System.String>? IdsAudios { get; set; }
    /// <summary>
    /// Name of music on hold group
    /// </summary>
    public String? FriendlyName { get; set; }
    /// <summary>
    /// Description of music on hold group
    /// </summary>
    public String? Description { get; set; }
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnMusicOnHoldGroup(MusicOnHoldGroup musicOnHoldGroup, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(IdsAudios)}""", StringComparison.OrdinalIgnoreCase))
            musicOnHoldGroup.IdsAudios = IdsAudios;
        if(jsonRaw.Contains($@"""{nameof(FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            musicOnHoldGroup.FriendlyName = FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(Description)}""", StringComparison.OrdinalIgnoreCase))
            musicOnHoldGroup.Description = Description;
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            musicOnHoldGroup.IdsTags = IdsTags;
    }

}

/// <summary>
/// Previously called IpPhone. Represents a phone in UBLUX
/// </summary><summary>
/// Previously called IpPhone. Represents a phone in UBLUX
/// </summary>
public class PhoneUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// This specifies to what PBX it will be connected to
    /// </summary>
    public String? IdCloudServicePbx { get; set; }
    /// <summary>
    /// Configuration phone will use
    /// </summary>
    public String? IdPhoneConfiguration { get; set; }
    /// <summary>
    /// Username and password to login to web-app. Two phones cannot point to the same user.
    /// </summary>
    public String? IdUser { get; set; }
    /// <summary>
    /// Caller id number that will be used to place outbound calls
    /// </summary>
    public List<System.String>? CallerIdNumbers { get; set; }
    /// <summary>
    /// Specifies what caller id to use.  CallerIdIndex cannot be greater than the number of callerIdNumbers.
    /// </summary>
    public Int32? CallerIdIndex { get; set; }
    /// <summary>
    /// Record, transcribe or AI analyse external calls to PSTN.
    /// This are only for outgoing calls!
    /// Please note that if you transcribe the call will be recorded. If you AI analyze the call it will be transcribed.
    /// </summary>
    public CallProcessingType? ProcessingTypeExternal { get; set; }
    /// <summary>
    /// Record, transcribe or AI analyse internal calls between extensions.
    /// This are only for outgoing calls!
    /// Please note that if you transcribe the call will be recorded. If you AI analyze the call it will be transcribed.
    /// </summary>
    public CallProcessingType? ProcessingTypeInternal { get; set; }
    /// <summary>
    /// What input to pass to AI engine. If null it should use a default input that is part of constants.
    /// </summary>
    public String? IdAiCallAnalysisInput { get; set; }
    /// <summary>
    /// Language to use when playing messages
    /// </summary>
    public Language? Language { get; set; }
    /// <summary>
    /// Descriptive name of phone
    /// </summary>
    public String? FriendlyName { get; set; }
    /// <summary>
    /// Type of phone. If its of type web and user (username and password) must exist in order for phone to connect.
    /// </summary>
    public PhoneType? PhoneType { get; set; }
    /// <summary>
    /// Disable encryption in case device does not support it
    /// </summary>
    public Boolean? DisableEncryption { get; set; }
    /// <summary>
    /// TimeZone of this phone
    /// </summary>
    public String? TimeZone { get; set; }
    /// <summary>
    /// This is needed for yealink cordless phones for example. Phones on the same group name will be sent as a group when autoprovisioning.
    /// Can only set if phone is disconnected.
    /// </summary>
    public String? GroupName { get; set; }
    /// <summary>
    /// Send email if phone disconnects to these emails
    /// </summary>
    public List<System.String>? OnDisconnectedNotifyIdsEmails { get; set; }
    /// <summary>
    /// Send email if phone connects to these emails
    /// </summary>
    public List<System.String>? OnConnectedNotifyIdsEmails { get; set; }
    /// <summary>
    /// Send email if phone connects to these emails
    /// </summary>
    public PhoneAdvanceSettings? AdvanceSettings { get; set; }
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnPhone(Phone phone, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(IdCloudServicePbx)}""", StringComparison.OrdinalIgnoreCase))
            phone.IdCloudServicePbx = IdCloudServicePbx;
        if(jsonRaw.Contains($@"""{nameof(IdPhoneConfiguration)}""", StringComparison.OrdinalIgnoreCase))
            phone.IdPhoneConfiguration = IdPhoneConfiguration;
        if(jsonRaw.Contains($@"""{nameof(IdUser)}""", StringComparison.OrdinalIgnoreCase))
            phone.IdUser = IdUser;
        if(jsonRaw.Contains($@"""{nameof(CallerIdNumbers)}""", StringComparison.OrdinalIgnoreCase))
            phone.CallerIdNumbers = CallerIdNumbers;
        if(jsonRaw.Contains($@"""{nameof(CallerIdIndex)}""", StringComparison.OrdinalIgnoreCase))
            phone.CallerIdIndex = CallerIdIndex.Value;
        if(jsonRaw.Contains($@"""{nameof(ProcessingTypeExternal)}""", StringComparison.OrdinalIgnoreCase))
            phone.ProcessingTypeExternal = ProcessingTypeExternal.Value;
        if(jsonRaw.Contains($@"""{nameof(ProcessingTypeInternal)}""", StringComparison.OrdinalIgnoreCase))
            phone.ProcessingTypeInternal = ProcessingTypeInternal.Value;
        if(jsonRaw.Contains($@"""{nameof(IdAiCallAnalysisInput)}""", StringComparison.OrdinalIgnoreCase))
            phone.IdAiCallAnalysisInput = IdAiCallAnalysisInput;
        if(jsonRaw.Contains($@"""{nameof(Language)}""", StringComparison.OrdinalIgnoreCase))
            phone.Language = Language.Value;
        if(jsonRaw.Contains($@"""{nameof(FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            phone.FriendlyName = FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(PhoneType)}""", StringComparison.OrdinalIgnoreCase))
            phone.PhoneType = PhoneType.Value;
        if(jsonRaw.Contains($@"""{nameof(DisableEncryption)}""", StringComparison.OrdinalIgnoreCase))
            phone.DisableEncryption = DisableEncryption.Value;
        if(jsonRaw.Contains($@"""{nameof(TimeZone)}""", StringComparison.OrdinalIgnoreCase))
            phone.TimeZone = TimeZone;
        if(jsonRaw.Contains($@"""{nameof(GroupName)}""", StringComparison.OrdinalIgnoreCase))
            phone.GroupName = GroupName;
        if(jsonRaw.Contains($@"""{nameof(OnDisconnectedNotifyIdsEmails)}""", StringComparison.OrdinalIgnoreCase))
            phone.OnDisconnectedNotifyIdsEmails = OnDisconnectedNotifyIdsEmails;
        if(jsonRaw.Contains($@"""{nameof(OnConnectedNotifyIdsEmails)}""", StringComparison.OrdinalIgnoreCase))
            phone.OnConnectedNotifyIdsEmails = OnConnectedNotifyIdsEmails;
        if(jsonRaw.Contains($@"""{nameof(AdvanceSettings)}""", StringComparison.OrdinalIgnoreCase))
            phone.AdvanceSettings = AdvanceSettings;
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            phone.IdsTags = IdsTags;
    }

}

/// <summary>
/// Configuration of a phone
/// </summary>
public class PhoneConfigurationUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Phone keys to use
    /// </summary>
    public String? IdSpeedDialGroup { get; set; }
    /// <summary>
    /// Phone configuration name
    /// </summary>
    public String? FriendlyName { get; set; }
    /// <summary>
    /// Phone configuration description
    /// </summary>
    public String? Description { get; set; }
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnPhoneConfiguration(PhoneConfiguration phoneConfiguration, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(IdSpeedDialGroup)}""", StringComparison.OrdinalIgnoreCase))
            phoneConfiguration.IdSpeedDialGroup = IdSpeedDialGroup;
        if(jsonRaw.Contains($@"""{nameof(FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            phoneConfiguration.FriendlyName = FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(Description)}""", StringComparison.OrdinalIgnoreCase))
            phoneConfiguration.Description = Description;
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            phoneConfiguration.IdsTags = IdsTags;
    }

}

/// <summary>
/// Group used to call multiple parties
/// </summary>
public class PowerDialerGroupUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Agents that will be using power dialer
    /// </summary>
    public List<System.String>? IdPhonesAgents { get; set; }
    /// <summary>
    /// Friendly name of power dialer group
    /// </summary>
    public String? FriendlyName { get; set; }
    /// <summary>
    /// Description of power dialer group
    /// </summary>
    public String? Description { get; set; }
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnPowerDialerGroup(PowerDialerGroup powerDialerGroup, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(IdPhonesAgents)}""", StringComparison.OrdinalIgnoreCase))
            powerDialerGroup.IdPhonesAgents = IdPhonesAgents;
        if(jsonRaw.Contains($@"""{nameof(FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            powerDialerGroup.FriendlyName = FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(Description)}""", StringComparison.OrdinalIgnoreCase))
            powerDialerGroup.Description = Description;
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            powerDialerGroup.IdsTags = IdsTags;
    }

}

/// <summary>
/// SMS message
/// </summary>
public class SMSUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnSMS(SMS sMS, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            sMS.IdsTags = IdsTags;
    }

}

/// <summary>
/// Trunk used to receive phone calls
/// </summary>
public class TrunkTerminationUpdateRequest // : IUbluxDocumentId
{
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnTrunkTermination(TrunkTermination trunkTermination, string jsonRaw)
    {
    }

}

/// <summary>
/// Group of trunk terminations ordered by priority
/// </summary>
public class TrunkTerminationGroupUpdateRequest // : IUbluxDocumentId
{
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnTrunkTerminationGroup(TrunkTerminationGroup trunkTerminationGroup, string jsonRaw)
    {
    }

}

/// <summary>
/// Extensions may forward an existing voicemail to another extension
/// </summary>
public class VoicemailUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnVoicemail(Voicemail voicemail, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            voicemail.IdsTags = IdsTags;
    }

}

/// <summary>
/// Voicemail that was forwarded from one extension to another. There are times when people want to send their voicemail from one another.
/// </summary>
public class VoicemailForwardedUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnVoicemailForwarded(VoicemailForwarded voicemailForwarded, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            voicemailForwarded.IdsTags = IdsTags;
    }

}

/// <summary>
/// Incoming phone number available for purchase
/// </summary>
public class VoipNumberAvailableForPurchaseUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Music on hold to use for outgoing calls to PSTN only
    /// </summary>
    public String? IdMusicOnHoldGroup { get; set; }
    /// <summary>
    /// This is only for external incoming calls
    /// If the friendly name of this VoipNumber is "Spanish Support" then "Spanish Support"
    /// will be injected to the caller id allowing the agent to know that she has to answer in Spanish for example
    /// </summary>
    public Boolean? InjectFriendlyNameToCallerId { get; set; }
    /// <summary>
    /// Record, transcribe or AI analyse call.
    /// This is only for incoming calls made to this number.
    /// Please note that if you transcribe the call will be recorded. If you AI analyze the call it will be transcribed.
    /// </summary>
    public CallProcessingType? ProcessingType { get; set; }
    /// <summary>
    /// What input to pass to AI engine in case UseAiForIncomingCalls=true. If null it should use a default input that is part of constants.
    /// For this to work ProcessingType should equal AiAnalyze
    /// </summary>
    public String? IdAiCallAnalysisInput { get; set; }
    /// <summary>
    /// Incoming phone number friendly name
    /// </summary>
    public String? FriendlyName { get; set; }
    /// <summary>
    /// Incoming phone number description
    /// </summary>
    public String? Description { get; set; }
    /// <summary>
    /// Example: EN, SP, etc..
    /// </summary>
    public Language? Language { get; set; }
    /// <summary>
    /// TimeZone of this phone number
    /// </summary>
    public String? TimeZone { get; set; }
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnVoipNumberAvailableForPurchase(VoipNumberAvailableForPurchase voipNumberAvailableForPurchase, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(IdMusicOnHoldGroup)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberAvailableForPurchase.IdMusicOnHoldGroup = IdMusicOnHoldGroup;
        if(jsonRaw.Contains($@"""{nameof(InjectFriendlyNameToCallerId)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberAvailableForPurchase.InjectFriendlyNameToCallerId = InjectFriendlyNameToCallerId.Value;
        if(jsonRaw.Contains($@"""{nameof(ProcessingType)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberAvailableForPurchase.ProcessingType = ProcessingType.Value;
        if(jsonRaw.Contains($@"""{nameof(IdAiCallAnalysisInput)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberAvailableForPurchase.IdAiCallAnalysisInput = IdAiCallAnalysisInput;
        if(jsonRaw.Contains($@"""{nameof(FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberAvailableForPurchase.FriendlyName = FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(Description)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberAvailableForPurchase.Description = Description;
        if(jsonRaw.Contains($@"""{nameof(Language)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberAvailableForPurchase.Language = Language.Value;
        if(jsonRaw.Contains($@"""{nameof(TimeZone)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberAvailableForPurchase.TimeZone = TimeZone;
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberAvailableForPurchase.IdsTags = IdsTags;
    }

}

/// <summary>
/// Incoming phone number configured to receive faxes
/// </summary>
public class VoipNumberFaxUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// key = id of logic OR id of extension.
    /// value = day of week when it executes
    /// </summary>
    public List<Ublux.Communications.Models.RulePhone>? RulesPhone { get; set; }
    /// <summary>
    /// Incoming SMS will be sent to these email addresses
    /// </summary>
    public List<Ublux.Communications.Models.RuleSms>? RulesSms { get; set; }
    /// <summary>
    /// Incoming Faxes will be sent to this email addresses
    /// </summary>
    public List<Ublux.Communications.Models.RuleFax>? RulesFax { get; set; }
    /// <summary>
    /// Music on hold to use for outgoing calls to PSTN only
    /// </summary>
    public String? IdMusicOnHoldGroup { get; set; }
    /// <summary>
    /// This is only for external incoming calls
    /// If the friendly name of this VoipNumber is "Spanish Support" then "Spanish Support"
    /// will be injected to the caller id allowing the agent to know that she has to answer in Spanish for example
    /// </summary>
    public Boolean? InjectFriendlyNameToCallerId { get; set; }
    /// <summary>
    /// Record, transcribe or AI analyse call.
    /// This is only for incoming calls made to this number.
    /// Please note that if you transcribe the call will be recorded. If you AI analyze the call it will be transcribed.
    /// </summary>
    public CallProcessingType? ProcessingType { get; set; }
    /// <summary>
    /// What input to pass to AI engine in case UseAiForIncomingCalls=true. If null it should use a default input that is part of constants.
    /// For this to work ProcessingType should equal AiAnalyze
    /// </summary>
    public String? IdAiCallAnalysisInput { get; set; }
    /// <summary>
    /// Incoming phone number friendly name
    /// </summary>
    public String? FriendlyName { get; set; }
    /// <summary>
    /// Incoming phone number description
    /// </summary>
    public String? Description { get; set; }
    /// <summary>
    /// Example: EN, SP, etc..
    /// </summary>
    public Language? Language { get; set; }
    /// <summary>
    /// TimeZone of this phone number
    /// </summary>
    public String? TimeZone { get; set; }
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnVoipNumberFax(VoipNumberFax voipNumberFax, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(RulesPhone)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberFax.RulesPhone = RulesPhone;
        if(jsonRaw.Contains($@"""{nameof(RulesSms)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberFax.RulesSms = RulesSms;
        if(jsonRaw.Contains($@"""{nameof(RulesFax)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberFax.RulesFax = RulesFax;
        if(jsonRaw.Contains($@"""{nameof(IdMusicOnHoldGroup)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberFax.IdMusicOnHoldGroup = IdMusicOnHoldGroup;
        if(jsonRaw.Contains($@"""{nameof(InjectFriendlyNameToCallerId)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberFax.InjectFriendlyNameToCallerId = InjectFriendlyNameToCallerId.Value;
        if(jsonRaw.Contains($@"""{nameof(ProcessingType)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberFax.ProcessingType = ProcessingType.Value;
        if(jsonRaw.Contains($@"""{nameof(IdAiCallAnalysisInput)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberFax.IdAiCallAnalysisInput = IdAiCallAnalysisInput;
        if(jsonRaw.Contains($@"""{nameof(FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberFax.FriendlyName = FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(Description)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberFax.Description = Description;
        if(jsonRaw.Contains($@"""{nameof(Language)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberFax.Language = Language.Value;
        if(jsonRaw.Contains($@"""{nameof(TimeZone)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberFax.TimeZone = TimeZone;
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberFax.IdsTags = IdsTags;
    }

}

/// <summary>
/// Incoming phone number configured to receive phone calls
/// </summary>
public class VoipNumberPhoneUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// key = id of logic OR id of extension.
    /// value = day of week when it executes
    /// </summary>
    public List<Ublux.Communications.Models.RulePhone>? RulesPhone { get; set; }
    /// <summary>
    /// Incoming SMS will be sent to these email addresses
    /// </summary>
    public List<Ublux.Communications.Models.RuleSms>? RulesSms { get; set; }
    /// <summary>
    /// Incoming Faxes will be sent to this email addresses
    /// </summary>
    public List<Ublux.Communications.Models.RuleFax>? RulesFax { get; set; }
    /// <summary>
    /// If there are 3 consecutive missed calls for a specific phone number then maybe that number is not working and we want to send an email.
    /// </summary>
    public RuleConsecutiveMissedCalls? RuleConsecutiveMissedCalls { get; set; }
    /// <summary>
    /// Music on hold to use for outgoing calls to PSTN only
    /// </summary>
    public String? IdMusicOnHoldGroup { get; set; }
    /// <summary>
    /// This is only for external incoming calls
    /// If the friendly name of this VoipNumber is "Spanish Support" then "Spanish Support"
    /// will be injected to the caller id allowing the agent to know that she has to answer in Spanish for example
    /// </summary>
    public Boolean? InjectFriendlyNameToCallerId { get; set; }
    /// <summary>
    /// Record, transcribe or AI analyse call.
    /// This is only for incoming calls made to this number.
    /// Please note that if you transcribe the call will be recorded. If you AI analyze the call it will be transcribed.
    /// </summary>
    public CallProcessingType? ProcessingType { get; set; }
    /// <summary>
    /// What input to pass to AI engine in case UseAiForIncomingCalls=true. If null it should use a default input that is part of constants.
    /// For this to work ProcessingType should equal AiAnalyze
    /// </summary>
    public String? IdAiCallAnalysisInput { get; set; }
    /// <summary>
    /// Incoming phone number friendly name
    /// </summary>
    public String? FriendlyName { get; set; }
    /// <summary>
    /// Incoming phone number description
    /// </summary>
    public String? Description { get; set; }
    /// <summary>
    /// Example: EN, SP, etc..
    /// </summary>
    public Language? Language { get; set; }
    /// <summary>
    /// TimeZone of this phone number
    /// </summary>
    public String? TimeZone { get; set; }
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnVoipNumberPhone(VoipNumberPhone voipNumberPhone, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(RulesPhone)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberPhone.RulesPhone = RulesPhone;
        if(jsonRaw.Contains($@"""{nameof(RulesSms)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberPhone.RulesSms = RulesSms;
        if(jsonRaw.Contains($@"""{nameof(RulesFax)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberPhone.RulesFax = RulesFax;
        if(jsonRaw.Contains($@"""{nameof(RuleConsecutiveMissedCalls)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberPhone.RuleConsecutiveMissedCalls = RuleConsecutiveMissedCalls;
        if(jsonRaw.Contains($@"""{nameof(IdMusicOnHoldGroup)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberPhone.IdMusicOnHoldGroup = IdMusicOnHoldGroup;
        if(jsonRaw.Contains($@"""{nameof(InjectFriendlyNameToCallerId)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberPhone.InjectFriendlyNameToCallerId = InjectFriendlyNameToCallerId.Value;
        if(jsonRaw.Contains($@"""{nameof(ProcessingType)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberPhone.ProcessingType = ProcessingType.Value;
        if(jsonRaw.Contains($@"""{nameof(IdAiCallAnalysisInput)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberPhone.IdAiCallAnalysisInput = IdAiCallAnalysisInput;
        if(jsonRaw.Contains($@"""{nameof(FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberPhone.FriendlyName = FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(Description)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberPhone.Description = Description;
        if(jsonRaw.Contains($@"""{nameof(Language)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberPhone.Language = Language.Value;
        if(jsonRaw.Contains($@"""{nameof(TimeZone)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberPhone.TimeZone = TimeZone;
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberPhone.IdsTags = IdsTags;
    }

}

/// <summary>
/// VOIP provider. Some providers have an API that enable us to automate things.
/// Examples of voip providers are Twilio, Marcatel, Airnetworks etc...
/// </summary>
public class VoipProviderUpdateRequest // : IUbluxDocumentId
{
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnVoipProvider(VoipProvider voipProvider, string jsonRaw)
    {
    }

}

/// <summary>
/// Web callback that will be fired when a custom event of interest occurs.
/// </summary>
public class WebHookUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Points to enum and not database!
    /// </summary>
    public EventTriggerType? EventTriggerType { get; set; }
    /// <summary>
    /// Friendly name of webhook
    /// </summary>
    public String? FriendlyName { get; set; }
    /// <summary>
    /// Url where event will be sent
    /// TODO: place index on this field. Index is needed because when zapier deletes/unsubscribes it passes this url
    /// </summary>
    public String? Url { get; set; }
    /// <summary>
    /// Custom headers to inject on request. Example: x-token:1234,user:user1
    /// </summary>
    public List<System.String>? Headers { get; set; }
    /// <summary>
    /// Description of webhook
    /// </summary>
    public String? Description { get; set; }
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnWebHook(WebHook webHook, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(EventTriggerType)}""", StringComparison.OrdinalIgnoreCase))
            webHook.EventTriggerType = EventTriggerType.Value;
        if(jsonRaw.Contains($@"""{nameof(FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            webHook.FriendlyName = FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(Url)}""", StringComparison.OrdinalIgnoreCase))
            webHook.Url = Url;
        if(jsonRaw.Contains($@"""{nameof(Headers)}""", StringComparison.OrdinalIgnoreCase))
            webHook.Headers = Headers;
        if(jsonRaw.Contains($@"""{nameof(Description)}""", StringComparison.OrdinalIgnoreCase))
            webHook.Description = Description;
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            webHook.IdsTags = IdsTags;
    }

}

/// <summary>
/// File stored on the cloud
/// Thanks to this collection we can keep track of all StoredFiles
/// </summary>
public class StoredFileReferenceUpdateRequest // : IUbluxDocumentId
{
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnStoredFileReference(StoredFileReference storedFileReference, string jsonRaw)
    {
    }

}

/// <summary>
/// Category
/// </summary>
public class TagUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Name of tag
    /// </summary>
    public String? FriendlyName { get; set; }
    /// <summary>
    /// Color of tag
    /// </summary>
    public TagColor? TagColor { get; set; }
    /// <summary>
    /// Description of tag
    /// </summary>
    public String? Description { get; set; }
    /// <summary>
    /// Used to place an extra layer of filtering.
    /// </summary>
    public UserType? UserType { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnTag(Tag tag, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            tag.FriendlyName = FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(TagColor)}""", StringComparison.OrdinalIgnoreCase))
            tag.TagColor = TagColor.Value;
        if(jsonRaw.Contains($@"""{nameof(Description)}""", StringComparison.OrdinalIgnoreCase))
            tag.Description = Description;
        if(jsonRaw.Contains($@"""{nameof(UserType)}""", StringComparison.OrdinalIgnoreCase))
            tag.UserType = UserType.Value;
    }

}

/// <summary>
/// AI transcription of a phone call. This is the conversion from audio to text only.
/// </summary>
public class AiCallTranscriptionUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnAiCallTranscription(AiCallTranscription aiCallTranscription, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            aiCallTranscription.IdsTags = IdsTags;
    }

}

/// <summary>
/// Call made to cell phone or land line
/// </summary>
public class CallOutgoingToPowerDialerUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Result of a call
    /// </summary>
    public CallResult? CallResult { get; set; }
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnCallOutgoingToPowerDialer(CallOutgoingToPowerDialer callOutgoingToPowerDialer, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(CallResult)}""", StringComparison.OrdinalIgnoreCase))
            callOutgoingToPowerDialer.CallResult = CallResult.Value;
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            callOutgoingToPowerDialer.IdsTags = IdsTags;
    }

}

/// <summary>
/// Peer to call on power dialer group
/// </summary>
public class PowerDialerContactUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Error message
    /// </summary>
    public String? ErrorMessage { get; set; }
    /// <summary>
    /// If powerdialer fails it attempts to call again. If it reaches 3 attempts and fails it will stop
    /// </summary>
    public Int32? NumberOfAttempts { get; set; }
    /// <summary>
    /// Name of the contact in order to know who are we calling
    /// </summary>
    public String? ContactName { get; set; }
    /// <summary>
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnPowerDialerContact(PowerDialerContact powerDialerContact, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(ErrorMessage)}""", StringComparison.OrdinalIgnoreCase))
            powerDialerContact.ErrorMessage = ErrorMessage;
        if(jsonRaw.Contains($@"""{nameof(NumberOfAttempts)}""", StringComparison.OrdinalIgnoreCase))
            powerDialerContact.NumberOfAttempts = NumberOfAttempts.Value;
        if(jsonRaw.Contains($@"""{nameof(ContactName)}""", StringComparison.OrdinalIgnoreCase))
            powerDialerContact.ContactName = ContactName;
        if(jsonRaw.Contains($@"""{nameof(IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            powerDialerContact.IdsTags = IdsTags;
    }

}
