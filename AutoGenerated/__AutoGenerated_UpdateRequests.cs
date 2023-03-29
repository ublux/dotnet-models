/* THIS FILE IS AUTO GENERATED. DO NOT DELETE/MODIFY */
/* Contain properties with AllowUpdate=True */

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
        if(jsonRaw.Contains($@"""{nameof(this.UbluxRoles)}""", StringComparison.OrdinalIgnoreCase))
            apiKey.UbluxRoles = this.UbluxRoles;
        if(jsonRaw.Contains($@"""{nameof(this.DateExpire)}""", StringComparison.OrdinalIgnoreCase))
            apiKey.DateExpire = this.DateExpire.Value;
        if(jsonRaw.Contains($@"""{nameof(this.Description)}""", StringComparison.OrdinalIgnoreCase))
            apiKey.Description = this.Description;
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            apiKey.IdsTags = this.IdsTags;
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
    /// Name of company
    /// </summary>
    public String? CompanyName { get; set; }
    /// <summary>
    /// Sector
    /// </summary>
    public Industry? Industry { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnAccount(Account account, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(this.MailingAddress)}""", StringComparison.OrdinalIgnoreCase))
            account.MailingAddress = this.MailingAddress;
        if(jsonRaw.Contains($@"""{nameof(this.AccountSecrets)}""", StringComparison.OrdinalIgnoreCase))
            account.AccountSecrets = this.AccountSecrets;
        if(jsonRaw.Contains($@"""{nameof(this.CompanyName)}""", StringComparison.OrdinalIgnoreCase))
            account.CompanyName = this.CompanyName;
        if(jsonRaw.Contains($@"""{nameof(this.Industry)}""", StringComparison.OrdinalIgnoreCase))
            account.Industry = this.Industry.Value;
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
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            email.IdsTags = this.IdsTags;
    }

}

/// <summary>
/// Store when user agreed to UBLUX terms and conditions for legal reasons.
/// </summary>
public class AgreementToTermsAndConditionsUpdateRequest // : IUbluxDocumentId
{
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnAgreementToTermsAndConditions(AgreementToTermsAndConditions agreementToTermsAndConditions, string jsonRaw)
    {
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
        if(jsonRaw.Contains($@"""{nameof(this.FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            audio.FriendlyName = this.FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(this.Description)}""", StringComparison.OrdinalIgnoreCase))
            audio.Description = this.Description;
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            audio.IdsTags = this.IdsTags;
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
        if(jsonRaw.Contains($@"""{nameof(this.IdAudioToPlayIfCallIsBlocked)}""", StringComparison.OrdinalIgnoreCase))
            blackListPhoneNumber.IdAudioToPlayIfCallIsBlocked = this.IdAudioToPlayIfCallIsBlocked;
        if(jsonRaw.Contains($@"""{nameof(this.Number)}""", StringComparison.OrdinalIgnoreCase))
            blackListPhoneNumber.Number = this.Number;
        if(jsonRaw.Contains($@"""{nameof(this.FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            blackListPhoneNumber.FriendlyName = this.FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            blackListPhoneNumber.IdsTags = this.IdsTags;
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
        if(jsonRaw.Contains($@"""{nameof(this.FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            callerIdMask.FriendlyName = this.FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            callerIdMask.IdsTags = this.IdsTags;
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
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnCallFlowLogic(CallFlowLogic callFlowLogic, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(this.FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            callFlowLogic.FriendlyName = this.FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(this.Description)}""", StringComparison.OrdinalIgnoreCase))
            callFlowLogic.Description = this.Description;
        if(jsonRaw.Contains($@"""{nameof(this.Tree)}""", StringComparison.OrdinalIgnoreCase))
            callFlowLogic.Tree = this.Tree;
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            callFlowLogic.IdsTags = this.IdsTags;
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
        if(jsonRaw.Contains($@"""{nameof(this.CallResult)}""", StringComparison.OrdinalIgnoreCase))
            callIncomingToCallFlowLogic.CallResult = this.CallResult.Value;
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            callIncomingToCallFlowLogic.IdsTags = this.IdsTags;
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
        if(jsonRaw.Contains($@"""{nameof(this.CallResult)}""", StringComparison.OrdinalIgnoreCase))
            callIncomingToExtension.CallResult = this.CallResult.Value;
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            callIncomingToExtension.IdsTags = this.IdsTags;
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
        if(jsonRaw.Contains($@"""{nameof(this.CallResult)}""", StringComparison.OrdinalIgnoreCase))
            callOutgoingToExtension.CallResult = this.CallResult.Value;
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            callOutgoingToExtension.IdsTags = this.IdsTags;
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
        if(jsonRaw.Contains($@"""{nameof(this.CallResult)}""", StringComparison.OrdinalIgnoreCase))
            callOutgoingToPSTN.CallResult = this.CallResult.Value;
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            callOutgoingToPSTN.IdsTags = this.IdsTags;
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
        if(jsonRaw.Contains($@"""{nameof(this.DisableMonitoring)}""", StringComparison.OrdinalIgnoreCase))
            cloudServicePbx.DisableMonitoring = this.DisableMonitoring.Value;
        if(jsonRaw.Contains($@"""{nameof(this.ProviderInstanceId)}""", StringComparison.OrdinalIgnoreCase))
            cloudServicePbx.ProviderInstanceId = this.ProviderInstanceId;
        if(jsonRaw.Contains($@"""{nameof(this.ProviderRegion)}""", StringComparison.OrdinalIgnoreCase))
            cloudServicePbx.ProviderRegion = this.ProviderRegion;
        if(jsonRaw.Contains($@"""{nameof(this.ProviderType)}""", StringComparison.OrdinalIgnoreCase))
            cloudServicePbx.ProviderType = this.ProviderType.Value;
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
        if(jsonRaw.Contains($@"""{nameof(this.IdCloudServiceWebAppFailover)}""", StringComparison.OrdinalIgnoreCase))
            cloudServiceWebApp.IdCloudServiceWebAppFailover = this.IdCloudServiceWebAppFailover;
        if(jsonRaw.Contains($@"""{nameof(this.ProviderInstanceId)}""", StringComparison.OrdinalIgnoreCase))
            cloudServiceWebApp.ProviderInstanceId = this.ProviderInstanceId;
        if(jsonRaw.Contains($@"""{nameof(this.ProviderRegion)}""", StringComparison.OrdinalIgnoreCase))
            cloudServiceWebApp.ProviderRegion = this.ProviderRegion;
        if(jsonRaw.Contains($@"""{nameof(this.ProviderType)}""", StringComparison.OrdinalIgnoreCase))
            cloudServiceWebApp.ProviderType = this.ProviderType.Value;
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
        if(jsonRaw.Contains($@"""{nameof(this.ProviderInstanceId)}""", StringComparison.OrdinalIgnoreCase))
            cloudServiceWebHost.ProviderInstanceId = this.ProviderInstanceId;
        if(jsonRaw.Contains($@"""{nameof(this.ProviderRegion)}""", StringComparison.OrdinalIgnoreCase))
            cloudServiceWebHost.ProviderRegion = this.ProviderRegion;
        if(jsonRaw.Contains($@"""{nameof(this.ProviderType)}""", StringComparison.OrdinalIgnoreCase))
            cloudServiceWebHost.ProviderType = this.ProviderType.Value;
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
        if(jsonRaw.Contains($@"""{nameof(this.ContactNumbers)}""", StringComparison.OrdinalIgnoreCase))
            contact.ContactNumbers = this.ContactNumbers;
        if(jsonRaw.Contains($@"""{nameof(this.ContactEmails)}""", StringComparison.OrdinalIgnoreCase))
            contact.ContactEmails = this.ContactEmails;
        if(jsonRaw.Contains($@"""{nameof(this.MailingAddresses)}""", StringComparison.OrdinalIgnoreCase))
            contact.MailingAddresses = this.MailingAddresses;
        if(jsonRaw.Contains($@"""{nameof(this.FirstName)}""", StringComparison.OrdinalIgnoreCase))
            contact.FirstName = this.FirstName;
        if(jsonRaw.Contains($@"""{nameof(this.LastName)}""", StringComparison.OrdinalIgnoreCase))
            contact.LastName = this.LastName;
        if(jsonRaw.Contains($@"""{nameof(this.JobTitle)}""", StringComparison.OrdinalIgnoreCase))
            contact.JobTitle = this.JobTitle;
        if(jsonRaw.Contains($@"""{nameof(this.Company)}""", StringComparison.OrdinalIgnoreCase))
            contact.Company = this.Company;
        if(jsonRaw.Contains($@"""{nameof(this.Notes)}""", StringComparison.OrdinalIgnoreCase))
            contact.Notes = this.Notes;
        if(jsonRaw.Contains($@"""{nameof(this.Variables)}""", StringComparison.OrdinalIgnoreCase))
            contact.Variables = this.Variables;
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            contact.IdsTags = this.IdsTags;
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
        if(jsonRaw.Contains($@"""{nameof(this.MailingAddress)}""", StringComparison.OrdinalIgnoreCase))
            customerInfo.MailingAddress = this.MailingAddress;
        if(jsonRaw.Contains($@"""{nameof(this.FullName)}""", StringComparison.OrdinalIgnoreCase))
            customerInfo.FullName = this.FullName;
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            customerInfo.IdsTags = this.IdsTags;
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
        if(jsonRaw.Contains($@"""{nameof(this.IdCallFlowLogic)}""", StringComparison.OrdinalIgnoreCase))
            extensionCallFlowLogic.IdCallFlowLogic = this.IdCallFlowLogic;
        if(jsonRaw.Contains($@"""{nameof(this.CallFlowLabel)}""", StringComparison.OrdinalIgnoreCase))
            extensionCallFlowLogic.CallFlowLabel = this.CallFlowLabel;
        if(jsonRaw.Contains($@"""{nameof(this.TimeZone)}""", StringComparison.OrdinalIgnoreCase))
            extensionCallFlowLogic.TimeZone = this.TimeZone;
        if(jsonRaw.Contains($@"""{nameof(this.IdMusicOnHoldGroup)}""", StringComparison.OrdinalIgnoreCase))
            extensionCallFlowLogic.IdMusicOnHoldGroup = this.IdMusicOnHoldGroup;
        if(jsonRaw.Contains($@"""{nameof(this.FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            extensionCallFlowLogic.FriendlyName = this.FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(this.Number)}""", StringComparison.OrdinalIgnoreCase))
            extensionCallFlowLogic.Number = this.Number;
        if(jsonRaw.Contains($@"""{nameof(this.InjectExtensionNameToCallerId)}""", StringComparison.OrdinalIgnoreCase))
            extensionCallFlowLogic.InjectExtensionNameToCallerId = this.InjectExtensionNameToCallerId.Value;
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            extensionCallFlowLogic.IdsTags = this.IdsTags;
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
        if(jsonRaw.Contains($@"""{nameof(this.IdsAudiosWhenOneParticipant)}""", StringComparison.OrdinalIgnoreCase))
            extensionConference.IdsAudiosWhenOneParticipant = this.IdsAudiosWhenOneParticipant;
        if(jsonRaw.Contains($@"""{nameof(this.AnnounceParticipants)}""", StringComparison.OrdinalIgnoreCase))
            extensionConference.AnnounceParticipants = this.AnnounceParticipants.Value;
        if(jsonRaw.Contains($@"""{nameof(this.Pin)}""", StringComparison.OrdinalIgnoreCase))
            extensionConference.Pin = this.Pin;
        if(jsonRaw.Contains($@"""{nameof(this.IdMusicOnHoldGroup)}""", StringComparison.OrdinalIgnoreCase))
            extensionConference.IdMusicOnHoldGroup = this.IdMusicOnHoldGroup;
        if(jsonRaw.Contains($@"""{nameof(this.FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            extensionConference.FriendlyName = this.FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(this.Number)}""", StringComparison.OrdinalIgnoreCase))
            extensionConference.Number = this.Number;
        if(jsonRaw.Contains($@"""{nameof(this.InjectExtensionNameToCallerId)}""", StringComparison.OrdinalIgnoreCase))
            extensionConference.InjectExtensionNameToCallerId = this.InjectExtensionNameToCallerId.Value;
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            extensionConference.IdsTags = this.IdsTags;
    }

}

/// <summary>
/// Basic extension
/// </summary>
public class ExtensionDialUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Lines to call and ring. Minimum of one line is required
    /// </summary>
    public List<System.String>? IdsLines { get; set; }
    /// <summary>
    /// EventAction to execute if call is not answered
    /// </summary>
    public EventAction? EventActionToExecuteIfNotAnswered { get; set; }
    /// <summary>
    /// Send email notification if call is not answered
    /// </summary>
    public SendEmailNotificationIfNotAnswered? SendEmailNotificationIfNotAnswered { get; set; }
    /// <summary>
    /// Number of seconds each line will ring
    /// </summary>
    public Int32? RingTimeInSeconds { get; set; }
    /// <summary>
    /// Music on hold to use
    /// </summary>
    public String? IdMusicOnHoldGroup { get; set; }
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
        if(jsonRaw.Contains($@"""{nameof(this.IdsLines)}""", StringComparison.OrdinalIgnoreCase))
            extensionDial.IdsLines = this.IdsLines;
        if(jsonRaw.Contains($@"""{nameof(this.EventActionToExecuteIfNotAnswered)}""", StringComparison.OrdinalIgnoreCase))
            extensionDial.EventActionToExecuteIfNotAnswered = this.EventActionToExecuteIfNotAnswered;
        if(jsonRaw.Contains($@"""{nameof(this.SendEmailNotificationIfNotAnswered)}""", StringComparison.OrdinalIgnoreCase))
            extensionDial.SendEmailNotificationIfNotAnswered = this.SendEmailNotificationIfNotAnswered;
        if(jsonRaw.Contains($@"""{nameof(this.RingTimeInSeconds)}""", StringComparison.OrdinalIgnoreCase))
            extensionDial.RingTimeInSeconds = this.RingTimeInSeconds.Value;
        if(jsonRaw.Contains($@"""{nameof(this.IdMusicOnHoldGroup)}""", StringComparison.OrdinalIgnoreCase))
            extensionDial.IdMusicOnHoldGroup = this.IdMusicOnHoldGroup;
        if(jsonRaw.Contains($@"""{nameof(this.FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            extensionDial.FriendlyName = this.FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(this.Number)}""", StringComparison.OrdinalIgnoreCase))
            extensionDial.Number = this.Number;
        if(jsonRaw.Contains($@"""{nameof(this.InjectExtensionNameToCallerId)}""", StringComparison.OrdinalIgnoreCase))
            extensionDial.InjectExtensionNameToCallerId = this.InjectExtensionNameToCallerId.Value;
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            extensionDial.IdsTags = this.IdsTags;
    }

}

/// <summary>
/// Extension where people that call will be placed on a sequence awaiting their turn to be attended
/// </summary>
public class ExtensionQueueUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Lines to ring
    /// </summary>
    public List<System.String>? IdsLines { get; set; }
    /// <summary>
    /// If there is a timeout to what extension we will forward the call?
    /// </summary>
    public String? IdExtensionIfTimeout { get; set; }
    /// <summary>
    /// Audios to play meanwhile caller is waiting to be attended
    /// </summary>
    public List<System.String>? IdsAudios { get; set; }
    /// <summary>
    /// Send email notification if call is not answered
    /// </summary>
    public SendEmailNotificationIfNotAnswered? SendEmailNotificationIfNotAnswered { get; set; }
    /// <summary>
    /// Send email notification if call takes to long to be answered
    /// </summary>
    public SendEmailNotificationIfItTakesToLongToBeAnswered? SendEmailNotificationIfItTakesToLongToBeAnswered { get; set; }
    /// <summary>
    /// Time that lines will ring in seconds until answered
    /// </summary>
    public Int32? RingTimeInSeconds { get; set; }
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
    /// Music on hold to use
    /// </summary>
    public String? IdMusicOnHoldGroup { get; set; }
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
        if(jsonRaw.Contains($@"""{nameof(this.IdsLines)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.IdsLines = this.IdsLines;
        if(jsonRaw.Contains($@"""{nameof(this.IdExtensionIfTimeout)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.IdExtensionIfTimeout = this.IdExtensionIfTimeout;
        if(jsonRaw.Contains($@"""{nameof(this.IdsAudios)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.IdsAudios = this.IdsAudios;
        if(jsonRaw.Contains($@"""{nameof(this.SendEmailNotificationIfNotAnswered)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.SendEmailNotificationIfNotAnswered = this.SendEmailNotificationIfNotAnswered;
        if(jsonRaw.Contains($@"""{nameof(this.SendEmailNotificationIfItTakesToLongToBeAnswered)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.SendEmailNotificationIfItTakesToLongToBeAnswered = this.SendEmailNotificationIfItTakesToLongToBeAnswered;
        if(jsonRaw.Contains($@"""{nameof(this.RingTimeInSeconds)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.RingTimeInSeconds = this.RingTimeInSeconds.Value;
        if(jsonRaw.Contains($@"""{nameof(this.RingInUse)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.RingInUse = this.RingInUse.Value;
        if(jsonRaw.Contains($@"""{nameof(this.QueueTimeoutInMinutes)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.QueueTimeoutInMinutes = this.QueueTimeoutInMinutes.Value;
        if(jsonRaw.Contains($@"""{nameof(this.AnnouncePosition)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.AnnouncePosition = this.AnnouncePosition.Value;
        if(jsonRaw.Contains($@"""{nameof(this.AnnounceHoldTime)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.AnnounceHoldTime = this.AnnounceHoldTime.Value;
        if(jsonRaw.Contains($@"""{nameof(this.AnnounceFrequency)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.AnnounceFrequency = this.AnnounceFrequency.Value;
        if(jsonRaw.Contains($@"""{nameof(this.RetryFrequency)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.RetryFrequency = this.RetryFrequency.Value;
        if(jsonRaw.Contains($@"""{nameof(this.RingStrategy)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.RingStrategy = this.RingStrategy.Value;
        if(jsonRaw.Contains($@"""{nameof(this.IdMusicOnHoldGroup)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.IdMusicOnHoldGroup = this.IdMusicOnHoldGroup;
        if(jsonRaw.Contains($@"""{nameof(this.FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.FriendlyName = this.FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(this.Number)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.Number = this.Number;
        if(jsonRaw.Contains($@"""{nameof(this.InjectExtensionNameToCallerId)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.InjectExtensionNameToCallerId = this.InjectExtensionNameToCallerId.Value;
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            extensionQueue.IdsTags = this.IdsTags;
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
    /// Lines that can listen to this voicemail on their phones. It is also possible to listen to voicemails through phones and not just email.
    /// </summary>
    public List<System.String>? IdsLinesThatCanListenToVoicemail { get; set; }
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
        if(jsonRaw.Contains($@"""{nameof(this.IdAudio)}""", StringComparison.OrdinalIgnoreCase))
            extensionVoicemail.IdAudio = this.IdAudio;
        if(jsonRaw.Contains($@"""{nameof(this.IdsLinesThatCanListenToVoicemail)}""", StringComparison.OrdinalIgnoreCase))
            extensionVoicemail.IdsLinesThatCanListenToVoicemail = this.IdsLinesThatCanListenToVoicemail;
        if(jsonRaw.Contains($@"""{nameof(this.IdEmail)}""", StringComparison.OrdinalIgnoreCase))
            extensionVoicemail.IdEmail = this.IdEmail;
        if(jsonRaw.Contains($@"""{nameof(this.TextToSpeech)}""", StringComparison.OrdinalIgnoreCase))
            extensionVoicemail.TextToSpeech = this.TextToSpeech;
        if(jsonRaw.Contains($@"""{nameof(this.TextToSpeechVoiceId)}""", StringComparison.OrdinalIgnoreCase))
            extensionVoicemail.TextToSpeechVoiceId = this.TextToSpeechVoiceId;
        if(jsonRaw.Contains($@"""{nameof(this.IdMusicOnHoldGroup)}""", StringComparison.OrdinalIgnoreCase))
            extensionVoicemail.IdMusicOnHoldGroup = this.IdMusicOnHoldGroup;
        if(jsonRaw.Contains($@"""{nameof(this.FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            extensionVoicemail.FriendlyName = this.FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(this.Number)}""", StringComparison.OrdinalIgnoreCase))
            extensionVoicemail.Number = this.Number;
        if(jsonRaw.Contains($@"""{nameof(this.InjectExtensionNameToCallerId)}""", StringComparison.OrdinalIgnoreCase))
            extensionVoicemail.InjectExtensionNameToCallerId = this.InjectExtensionNameToCallerId.Value;
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            extensionVoicemail.IdsTags = this.IdsTags;
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
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            faxIncoming.IdsTags = this.IdsTags;
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
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            faxOutgoingGroup.IdsTags = this.IdsTags;
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
        if(jsonRaw.Contains($@"""{nameof(this.UbluxRoles)}""", StringComparison.OrdinalIgnoreCase))
            user.UbluxRoles = this.UbluxRoles;
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            user.IdsTags = this.IdsTags;
    }

}

/// <summary>
/// Group of line keys
/// </summary>
public class LineKeyGroupUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Group of speed dial keys. Must have at least one
    /// </summary>
    public List<Ublux.Communications.Models.LineKey>? LineKeys { get; set; }
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
    public void SetValuesOnLineKeyGroup(LineKeyGroup lineKeyGroup, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(this.LineKeys)}""", StringComparison.OrdinalIgnoreCase))
            lineKeyGroup.LineKeys = this.LineKeys;
        if(jsonRaw.Contains($@"""{nameof(this.FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            lineKeyGroup.FriendlyName = this.FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(this.Description)}""", StringComparison.OrdinalIgnoreCase))
            lineKeyGroup.Description = this.Description;
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            lineKeyGroup.IdsTags = this.IdsTags;
    }

}

/// <summary>
/// All request sent to ublux will be stored.
/// </summary><summary>
/// All request sent to ublux will be stored.
/// </summary>
public class LogWebServiceRequestUpdateRequest // : IUbluxDocumentId
{
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnLogWebServiceRequest(LogWebServiceRequest logWebServiceRequest, string jsonRaw)
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
        if(jsonRaw.Contains($@"""{nameof(this.IdsAudios)}""", StringComparison.OrdinalIgnoreCase))
            musicOnHoldGroup.IdsAudios = this.IdsAudios;
        if(jsonRaw.Contains($@"""{nameof(this.FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            musicOnHoldGroup.FriendlyName = this.FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(this.Description)}""", StringComparison.OrdinalIgnoreCase))
            musicOnHoldGroup.Description = this.Description;
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            musicOnHoldGroup.IdsTags = this.IdsTags;
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
    /// Username and password to login to web-app
    /// </summary>
    public String? IdUser { get; set; }
    /// <summary>
    /// Phone lines. Should never be null
    /// </summary>
    public List<Ublux.Communications.Models.SubDocuments.Line>? Lines { get; set; }
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
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnPhone(Phone phone, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(this.IdCloudServicePbx)}""", StringComparison.OrdinalIgnoreCase))
            phone.IdCloudServicePbx = this.IdCloudServicePbx;
        if(jsonRaw.Contains($@"""{nameof(this.IdPhoneConfiguration)}""", StringComparison.OrdinalIgnoreCase))
            phone.IdPhoneConfiguration = this.IdPhoneConfiguration;
        if(jsonRaw.Contains($@"""{nameof(this.IdUser)}""", StringComparison.OrdinalIgnoreCase))
            phone.IdUser = this.IdUser;
        if(jsonRaw.Contains($@"""{nameof(this.Lines)}""", StringComparison.OrdinalIgnoreCase))
            phone.Lines = this.Lines;
        if(jsonRaw.Contains($@"""{nameof(this.FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            phone.FriendlyName = this.FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(this.PhoneType)}""", StringComparison.OrdinalIgnoreCase))
            phone.PhoneType = this.PhoneType.Value;
        if(jsonRaw.Contains($@"""{nameof(this.DisableEncryption)}""", StringComparison.OrdinalIgnoreCase))
            phone.DisableEncryption = this.DisableEncryption.Value;
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            phone.IdsTags = this.IdsTags;
    }

}

/// <summary>
/// Configuration of a phone
/// </summary>
public class PhoneConfigurationUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Line keys to use
    /// </summary>
    public String? IdLineKeyGroup { get; set; }
    /// <summary>
    /// Phone configuration name
    /// </summary>
    public String? FrienlyName { get; set; }
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
        if(jsonRaw.Contains($@"""{nameof(this.IdLineKeyGroup)}""", StringComparison.OrdinalIgnoreCase))
            phoneConfiguration.IdLineKeyGroup = this.IdLineKeyGroup;
        if(jsonRaw.Contains($@"""{nameof(this.FrienlyName)}""", StringComparison.OrdinalIgnoreCase))
            phoneConfiguration.FrienlyName = this.FrienlyName;
        if(jsonRaw.Contains($@"""{nameof(this.Description)}""", StringComparison.OrdinalIgnoreCase))
            phoneConfiguration.Description = this.Description;
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            phoneConfiguration.IdsTags = this.IdsTags;
    }

}

/// <summary>
/// Group used to call multiple parties
/// </summary>
public class PowerDialerGroupUpdateRequest // : IUbluxDocumentId
{
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
        if(jsonRaw.Contains($@"""{nameof(this.FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            powerDialerGroup.FriendlyName = this.FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(this.Description)}""", StringComparison.OrdinalIgnoreCase))
            powerDialerGroup.Description = this.Description;
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            powerDialerGroup.IdsTags = this.IdsTags;
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
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            sMS.IdsTags = this.IdsTags;
    }

}

/// <summary>
/// This type of trunk origination forwards the call to our pbx. Twilio uses this type of Trunk origination
/// </summary>
public class TrunkOriginationForwardUpdateRequest // : IUbluxDocumentId
{
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnTrunkOriginationForward(TrunkOriginationForward trunkOriginationForward, string jsonRaw)
    {
    }

}

/// <summary>
/// This type of trunk origination we must register with provider in order to receive phone calls. Netbox solutions uses this type of trunk
/// </summary>
public class TrunkOriginationRegisterUpdateRequest // : IUbluxDocumentId
{
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnTrunkOriginationRegister(TrunkOriginationRegister trunkOriginationRegister, string jsonRaw)
    {
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
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            voicemail.IdsTags = this.IdsTags;
    }

}

/// <summary>
/// Voicemail that was forwarded from one extension to another
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
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            voicemailForwarded.IdsTags = this.IdsTags;
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
    /// Record incoming phone calls received by this phone number?
    /// </summary>
    public Boolean? RecordIncomingCalls { get; set; }
    /// <summary>
    /// Users will be charged extra for AI transcriptions. If this is true call will be recorded in order to do AI work
    /// </summary>
    public Boolean? UseAiForIncomingCalls { get; set; }
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
        if(jsonRaw.Contains($@"""{nameof(this.IdMusicOnHoldGroup)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberAvailableForPurchase.IdMusicOnHoldGroup = this.IdMusicOnHoldGroup;
        if(jsonRaw.Contains($@"""{nameof(this.InjectFriendlyNameToCallerId)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberAvailableForPurchase.InjectFriendlyNameToCallerId = this.InjectFriendlyNameToCallerId.Value;
        if(jsonRaw.Contains($@"""{nameof(this.RecordIncomingCalls)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberAvailableForPurchase.RecordIncomingCalls = this.RecordIncomingCalls.Value;
        if(jsonRaw.Contains($@"""{nameof(this.UseAiForIncomingCalls)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberAvailableForPurchase.UseAiForIncomingCalls = this.UseAiForIncomingCalls.Value;
        if(jsonRaw.Contains($@"""{nameof(this.FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberAvailableForPurchase.FriendlyName = this.FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(this.Description)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberAvailableForPurchase.Description = this.Description;
        if(jsonRaw.Contains($@"""{nameof(this.Language)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberAvailableForPurchase.Language = this.Language.Value;
        if(jsonRaw.Contains($@"""{nameof(this.TimeZone)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberAvailableForPurchase.TimeZone = this.TimeZone;
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberAvailableForPurchase.IdsTags = this.IdsTags;
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
    /// Record incoming phone calls received by this phone number?
    /// </summary>
    public Boolean? RecordIncomingCalls { get; set; }
    /// <summary>
    /// Users will be charged extra for AI transcriptions. If this is true call will be recorded in order to do AI work
    /// </summary>
    public Boolean? UseAiForIncomingCalls { get; set; }
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
        if(jsonRaw.Contains($@"""{nameof(this.RulesPhone)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberFax.RulesPhone = this.RulesPhone;
        if(jsonRaw.Contains($@"""{nameof(this.RulesSms)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberFax.RulesSms = this.RulesSms;
        if(jsonRaw.Contains($@"""{nameof(this.RulesFax)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberFax.RulesFax = this.RulesFax;
        if(jsonRaw.Contains($@"""{nameof(this.IdMusicOnHoldGroup)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberFax.IdMusicOnHoldGroup = this.IdMusicOnHoldGroup;
        if(jsonRaw.Contains($@"""{nameof(this.InjectFriendlyNameToCallerId)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberFax.InjectFriendlyNameToCallerId = this.InjectFriendlyNameToCallerId.Value;
        if(jsonRaw.Contains($@"""{nameof(this.RecordIncomingCalls)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberFax.RecordIncomingCalls = this.RecordIncomingCalls.Value;
        if(jsonRaw.Contains($@"""{nameof(this.UseAiForIncomingCalls)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberFax.UseAiForIncomingCalls = this.UseAiForIncomingCalls.Value;
        if(jsonRaw.Contains($@"""{nameof(this.FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberFax.FriendlyName = this.FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(this.Description)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberFax.Description = this.Description;
        if(jsonRaw.Contains($@"""{nameof(this.Language)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberFax.Language = this.Language.Value;
        if(jsonRaw.Contains($@"""{nameof(this.TimeZone)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberFax.TimeZone = this.TimeZone;
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberFax.IdsTags = this.IdsTags;
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
    /// Record incoming phone calls received by this phone number?
    /// </summary>
    public Boolean? RecordIncomingCalls { get; set; }
    /// <summary>
    /// Users will be charged extra for AI transcriptions. If this is true call will be recorded in order to do AI work
    /// </summary>
    public Boolean? UseAiForIncomingCalls { get; set; }
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
        if(jsonRaw.Contains($@"""{nameof(this.RulesPhone)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberPhone.RulesPhone = this.RulesPhone;
        if(jsonRaw.Contains($@"""{nameof(this.RulesSms)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberPhone.RulesSms = this.RulesSms;
        if(jsonRaw.Contains($@"""{nameof(this.RulesFax)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberPhone.RulesFax = this.RulesFax;
        if(jsonRaw.Contains($@"""{nameof(this.IdMusicOnHoldGroup)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberPhone.IdMusicOnHoldGroup = this.IdMusicOnHoldGroup;
        if(jsonRaw.Contains($@"""{nameof(this.InjectFriendlyNameToCallerId)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberPhone.InjectFriendlyNameToCallerId = this.InjectFriendlyNameToCallerId.Value;
        if(jsonRaw.Contains($@"""{nameof(this.RecordIncomingCalls)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberPhone.RecordIncomingCalls = this.RecordIncomingCalls.Value;
        if(jsonRaw.Contains($@"""{nameof(this.UseAiForIncomingCalls)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberPhone.UseAiForIncomingCalls = this.UseAiForIncomingCalls.Value;
        if(jsonRaw.Contains($@"""{nameof(this.FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberPhone.FriendlyName = this.FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(this.Description)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberPhone.Description = this.Description;
        if(jsonRaw.Contains($@"""{nameof(this.Language)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberPhone.Language = this.Language.Value;
        if(jsonRaw.Contains($@"""{nameof(this.TimeZone)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberPhone.TimeZone = this.TimeZone;
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            voipNumberPhone.IdsTags = this.IdsTags;
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
    public EventTrigger? EventTrigger { get; set; }
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
    /// It is nullable because there are cases where it makes no sense to point to an account.
    /// For example a CloudService user will point to no account
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnWebHook(WebHook webHook, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(this.EventTrigger)}""", StringComparison.OrdinalIgnoreCase))
            webHook.EventTrigger = this.EventTrigger.Value;
        if(jsonRaw.Contains($@"""{nameof(this.Url)}""", StringComparison.OrdinalIgnoreCase))
            webHook.Url = this.Url;
        if(jsonRaw.Contains($@"""{nameof(this.Headers)}""", StringComparison.OrdinalIgnoreCase))
            webHook.Headers = this.Headers;
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            webHook.IdsTags = this.IdsTags;
    }

}

/// <summary>
/// File stored on the cloud
/// This collection should not be stored on redis and be created with TTL
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
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnTag(Tag tag, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(this.FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            tag.FriendlyName = this.FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(this.TagColor)}""", StringComparison.OrdinalIgnoreCase))
            tag.TagColor = this.TagColor.Value;
    }

}

/// <summary>
/// AI transcription of a phone call
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
        if(jsonRaw.Contains($@"""{nameof(this.IdsTags)}""", StringComparison.OrdinalIgnoreCase))
            aiCallTranscription.IdsTags = this.IdsTags;
    }

}

/// <summary>
/// It is part of a phone. Lines are needed in order to make and receive phone calls.
/// </summary><summary>
/// It is part of a phone. Lines are needed in order to make and receive phone calls.
/// </summary>
public class LineUpdateRequest // : IUbluxDocumentId
{
    /// <summary></summary>
    public String? FriendlyName { get; set; }
    /// <summary>
    /// Caller id number that will be used to place outbound calls
    /// </summary>
    public String? CallerIdNumber { get; set; }
    /// <summary>
    /// Record outbound calls to PSTN?
    /// </summary>
    public Boolean? RecordExternalCalls { get; set; }
    /// <summary>
    /// Record calls to other extensions?
    /// </summary>
    public Boolean? RecordInternalCalls { get; set; }
    /// <summary>
    /// Users will be charged extra for AI transcriptions. If this is true external calls to PSTN will be recorded.
    /// </summary>
    public Boolean? UseAiForExternalCalls { get; set; }
    /// <summary>
    /// Users will be charged extra for AI transcriptions. If this is true internal calls to extensions will be recorded.
    /// </summary>
    public Boolean? UseAiForOutgoingCallsToExtensions { get; set; }
    /// <summary>
    /// Langage to use when playing messages
    /// </summary>
    public Language? Language { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnLine(Line line, string jsonRaw)
    {
        if(jsonRaw.Contains($@"""{nameof(this.FriendlyName)}""", StringComparison.OrdinalIgnoreCase))
            line.FriendlyName = this.FriendlyName;
        if(jsonRaw.Contains($@"""{nameof(this.CallerIdNumber)}""", StringComparison.OrdinalIgnoreCase))
            line.CallerIdNumber = this.CallerIdNumber;
        if(jsonRaw.Contains($@"""{nameof(this.RecordExternalCalls)}""", StringComparison.OrdinalIgnoreCase))
            line.RecordExternalCalls = this.RecordExternalCalls.Value;
        if(jsonRaw.Contains($@"""{nameof(this.RecordInternalCalls)}""", StringComparison.OrdinalIgnoreCase))
            line.RecordInternalCalls = this.RecordInternalCalls.Value;
        if(jsonRaw.Contains($@"""{nameof(this.UseAiForExternalCalls)}""", StringComparison.OrdinalIgnoreCase))
            line.UseAiForExternalCalls = this.UseAiForExternalCalls.Value;
        if(jsonRaw.Contains($@"""{nameof(this.UseAiForOutgoingCallsToExtensions)}""", StringComparison.OrdinalIgnoreCase))
            line.UseAiForOutgoingCallsToExtensions = this.UseAiForOutgoingCallsToExtensions.Value;
        if(jsonRaw.Contains($@"""{nameof(this.Language)}""", StringComparison.OrdinalIgnoreCase))
            line.Language = this.Language.Value;
    }

}
