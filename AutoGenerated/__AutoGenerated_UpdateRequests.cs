/* THIS FILE IS AUTO GENERATED. DO NOT DELETE/MODIFY */
/* Contain properties with AllowUpdate=True */

#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter

namespace Ublux.Communications.Models.Documents;


/// <summary>
/// Someone that has access to consume Ublux Web Api. It can be a PBX, WA, or UbluxUser
/// </summary><summary>
/// Only users can have api keys. Everyone else should have a JWT
/// </summary>
public class ApiKeyUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary>
    /// Key = service/role such as Phone. The phone role probably will have access to the PhoneController service
    /// Value = Permissions it has on that role. Maybe it can only read data from that service but it cannot update, create or modify.
    /// </summary>
    public List<Ublux.Communications.Enums.UbluxRole>? UbluxRoles { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnApiKey(ApiKey apiKey)
    {
        if(this.IdsTags!=null)
            apiKey.IdsTags = this.IdsTags;
        if(this.UbluxRoles!=null)
            apiKey.UbluxRoles = this.UbluxRoles;
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
    /// Customizable settings
    /// </summary>
    public AccountSettings? AccountSettings { get; set; }
    /// <summary>
    /// Name of company
    /// </summary>
    public String? CompanyName { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnAccount(Account account)
    {
        if(this.MailingAddress!=null)
            account.MailingAddress = this.MailingAddress;
        if(this.AccountSecrets!=null)
            account.AccountSecrets = this.AccountSecrets;
        if(this.AccountSettings!=null)
            account.AccountSettings = this.AccountSettings;
        if(this.CompanyName!=null)
            account.CompanyName = this.CompanyName;
    }

}

/// <summary>
/// Contact
/// </summary><summary>
/// Ublux Account
/// </summary>
public class EmailUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnEmail(Email email)
    {
        if(this.IdsTags!=null)
            email.IdsTags = this.IdsTags;
    }

}

/// <summary>
/// Store when user agreed to UBLUX terms and conditions for legal reasons.
/// </summary>
public class AgreementToTermsAndConditionsUpdateRequest // : IUbluxDocumentId
{
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnAgreementToTermsAndConditions(AgreementToTermsAndConditions agreementToTermsAndConditions)
    {
    }

}

/// <summary>
/// When a customer purchases a Phone Number from AirNetworks Provider from Spain he needs to feel the province and population info
/// </summary>
public class AirNetworksProvinceUpdateRequest // : IUbluxDocumentId
{
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnAirNetworksProvince(AirNetworksProvince airNetworksProvince)
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
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary>
    /// Name of audio
    /// </summary>
    public String? FriendlyName { get; set; }
    /// <summary>
    /// Description of audio
    /// </summary>
    public String? Description { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnAudio(Audio audio)
    {
        if(this.IdsTags!=null)
            audio.IdsTags = this.IdsTags;
        if(this.FriendlyName!=null)
            audio.FriendlyName = this.FriendlyName;
        if(this.Description!=null)
            audio.Description = this.Description;
    }

}

/// <summary>
/// Id is the mac address of a phone. It should point to an ip phone
/// </summary>
public class AutoProvisionReferenceUpdateRequest // : IUbluxDocumentId
{
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnAutoProvisionReference(AutoProvisionReference autoProvisionReference)
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
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary>
    /// The phone number that will be blocked
    /// </summary>
    public String? Number { get; set; }
    /// <summary>
    /// Friendly name of this rule
    /// </summary>
    public String? FriendlyName { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnBlackListPhoneNumber(BlackListPhoneNumber blackListPhoneNumber)
    {
        if(this.IdAudioToPlayIfCallIsBlocked!=null)
            blackListPhoneNumber.IdAudioToPlayIfCallIsBlocked = this.IdAudioToPlayIfCallIsBlocked;
        if(this.IdsTags!=null)
            blackListPhoneNumber.IdsTags = this.IdsTags;
        if(this.Number!=null)
            blackListPhoneNumber.Number = this.Number;
        if(this.FriendlyName!=null)
            blackListPhoneNumber.FriendlyName = this.FriendlyName;
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
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnCallerIdMask(CallerIdMask callerIdMask)
    {
        if(this.FriendlyName!=null)
            callerIdMask.FriendlyName = this.FriendlyName;
        if(this.IdsTags!=null)
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
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
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
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnCallFlowLogic(CallFlowLogic callFlowLogic)
    {
        if(this.IdsTags!=null)
            callFlowLogic.IdsTags = this.IdsTags;
        if(this.FriendlyName!=null)
            callFlowLogic.FriendlyName = this.FriendlyName;
        if(this.Description!=null)
            callFlowLogic.Description = this.Description;
        if(this.Tree!=null)
            callFlowLogic.Tree = this.Tree;
    }

}

/// <summary>
/// Incoming phone call that executed an IVR
/// </summary>
public class CallIncomingToCallFlowLogicUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary>
    /// Result of a call
    /// </summary>
    public CallResult? CallResult { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnCallIncomingToCallFlowLogic(CallIncomingToCallFlowLogic callIncomingToCallFlowLogic)
    {
        if(this.IdsTags!=null)
            callIncomingToCallFlowLogic.IdsTags = this.IdsTags;
        if(this.CallResult!=null)
            callIncomingToCallFlowLogic.CallResult = this.CallResult.Value;
    }

}

/// <summary>
/// Incoming phone call from PSTN to an extension
/// </summary>
public class CallIncomingToExtensionUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary>
    /// Result of a call
    /// </summary>
    public CallResult? CallResult { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnCallIncomingToExtension(CallIncomingToExtension callIncomingToExtension)
    {
        if(this.IdsTags!=null)
            callIncomingToExtension.IdsTags = this.IdsTags;
        if(this.CallResult!=null)
            callIncomingToExtension.CallResult = this.CallResult.Value;
    }

}

/// <summary>
/// Call made to an extension
/// </summary>
public class CallOutgoingToExtensionUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary>
    /// Result of a call
    /// </summary>
    public CallResult? CallResult { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnCallOutgoingToExtension(CallOutgoingToExtension callOutgoingToExtension)
    {
        if(this.IdsTags!=null)
            callOutgoingToExtension.IdsTags = this.IdsTags;
        if(this.CallResult!=null)
            callOutgoingToExtension.CallResult = this.CallResult.Value;
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
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary>
    /// Result of a call
    /// </summary>
    public CallResult? CallResult { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnCallOutgoingToPSTN(CallOutgoingToPSTN callOutgoingToPSTN)
    {
        if(this.IdsTags!=null)
            callOutgoingToPSTN.IdsTags = this.IdsTags;
        if(this.CallResult!=null)
            callOutgoingToPSTN.CallResult = this.CallResult.Value;
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
    public void SetValuesOnCloudServicePbx(CloudServicePbx cloudServicePbx)
    {
        if(this.DisableMonitoring!=null)
            cloudServicePbx.DisableMonitoring = this.DisableMonitoring.Value;
        if(this.ProviderInstanceId!=null)
            cloudServicePbx.ProviderInstanceId = this.ProviderInstanceId;
        if(this.ProviderRegion!=null)
            cloudServicePbx.ProviderRegion = this.ProviderRegion;
        if(this.ProviderType!=null)
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
    public void SetValuesOnCloudServiceWebApp(CloudServiceWebApp cloudServiceWebApp)
    {
        if(this.IdCloudServiceWebAppFailover!=null)
            cloudServiceWebApp.IdCloudServiceWebAppFailover = this.IdCloudServiceWebAppFailover;
        if(this.ProviderInstanceId!=null)
            cloudServiceWebApp.ProviderInstanceId = this.ProviderInstanceId;
        if(this.ProviderRegion!=null)
            cloudServiceWebApp.ProviderRegion = this.ProviderRegion;
        if(this.ProviderType!=null)
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
    public void SetValuesOnCloudServiceWebHost(CloudServiceWebHost cloudServiceWebHost)
    {
        if(this.ProviderInstanceId!=null)
            cloudServiceWebHost.ProviderInstanceId = this.ProviderInstanceId;
        if(this.ProviderRegion!=null)
            cloudServiceWebHost.ProviderRegion = this.ProviderRegion;
        if(this.ProviderType!=null)
            cloudServiceWebHost.ProviderType = this.ProviderType.Value;
    }

}

/// <summary>
/// Contact
/// </summary><summary>
/// Contact
/// </summary>
public class ContactUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
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
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnContact(Contact contact)
    {
        if(this.IdsTags!=null)
            contact.IdsTags = this.IdsTags;
        if(this.ContactNumbers!=null)
            contact.ContactNumbers = this.ContactNumbers;
        if(this.ContactEmails!=null)
            contact.ContactEmails = this.ContactEmails;
        if(this.MailingAddresses!=null)
            contact.MailingAddresses = this.MailingAddresses;
        if(this.FirstName!=null)
            contact.FirstName = this.FirstName;
        if(this.LastName!=null)
            contact.LastName = this.LastName;
        if(this.JobTitle!=null)
            contact.JobTitle = this.JobTitle;
        if(this.Company!=null)
            contact.Company = this.Company;
        if(this.Notes!=null)
            contact.Notes = this.Notes;
        if(this.Variables!=null)
            contact.Variables = this.Variables;
    }

}

/// <summary>
/// Needed because some providers like the one from Spain require customers info in order to purchase VoipNumber
/// </summary><summary>
/// Needed because some providers like the one from Spain require customers info in order to purchase VoipNumber
/// </summary>
public class CustomerInfoUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary>
    /// Address where this phone number is intended to be used
    /// </summary>
    public MailingAddress? MailingAddress { get; set; }
    /// <summary>
    /// Full legal name
    /// </summary>
    public String? FullName { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnCustomerInfo(CustomerInfo customerInfo)
    {
        if(this.IdsTags!=null)
            customerInfo.IdsTags = this.IdsTags;
        if(this.MailingAddress!=null)
            customerInfo.MailingAddress = this.MailingAddress;
        if(this.FullName!=null)
            customerInfo.FullName = this.FullName;
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
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
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
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnExtensionCallFlowLogic(ExtensionCallFlowLogic extensionCallFlowLogic)
    {
        if(this.IdCallFlowLogic!=null)
            extensionCallFlowLogic.IdCallFlowLogic = this.IdCallFlowLogic;
        if(this.CallFlowLabel!=null)
            extensionCallFlowLogic.CallFlowLabel = this.CallFlowLabel;
        if(this.TimeZone!=null)
            extensionCallFlowLogic.TimeZone = this.TimeZone;
        if(this.IdMusicOnHoldGroup!=null)
            extensionCallFlowLogic.IdMusicOnHoldGroup = this.IdMusicOnHoldGroup;
        if(this.IdsTags!=null)
            extensionCallFlowLogic.IdsTags = this.IdsTags;
        if(this.FriendlyName!=null)
            extensionCallFlowLogic.FriendlyName = this.FriendlyName;
        if(this.Number!=null)
            extensionCallFlowLogic.Number = this.Number;
        if(this.InjectExtensionNameToCallerId!=null)
            extensionCallFlowLogic.InjectExtensionNameToCallerId = this.InjectExtensionNameToCallerId.Value;
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
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
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
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnExtensionConference(ExtensionConference extensionConference)
    {
        if(this.IdsAudiosWhenOneParticipant!=null)
            extensionConference.IdsAudiosWhenOneParticipant = this.IdsAudiosWhenOneParticipant;
        if(this.AnnounceParticipants!=null)
            extensionConference.AnnounceParticipants = this.AnnounceParticipants.Value;
        if(this.Pin!=null)
            extensionConference.Pin = this.Pin;
        if(this.IdMusicOnHoldGroup!=null)
            extensionConference.IdMusicOnHoldGroup = this.IdMusicOnHoldGroup;
        if(this.IdsTags!=null)
            extensionConference.IdsTags = this.IdsTags;
        if(this.FriendlyName!=null)
            extensionConference.FriendlyName = this.FriendlyName;
        if(this.Number!=null)
            extensionConference.Number = this.Number;
        if(this.InjectExtensionNameToCallerId!=null)
            extensionConference.InjectExtensionNameToCallerId = this.InjectExtensionNameToCallerId.Value;
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
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
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
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnExtensionDial(ExtensionDial extensionDial)
    {
        if(this.IdsLines!=null)
            extensionDial.IdsLines = this.IdsLines;
        if(this.EventActionToExecuteIfNotAnswered!=null)
            extensionDial.EventActionToExecuteIfNotAnswered = this.EventActionToExecuteIfNotAnswered;
        if(this.SendEmailNotificationIfNotAnswered!=null)
            extensionDial.SendEmailNotificationIfNotAnswered = this.SendEmailNotificationIfNotAnswered;
        if(this.RingTimeInSeconds!=null)
            extensionDial.RingTimeInSeconds = this.RingTimeInSeconds.Value;
        if(this.IdMusicOnHoldGroup!=null)
            extensionDial.IdMusicOnHoldGroup = this.IdMusicOnHoldGroup;
        if(this.IdsTags!=null)
            extensionDial.IdsTags = this.IdsTags;
        if(this.FriendlyName!=null)
            extensionDial.FriendlyName = this.FriendlyName;
        if(this.Number!=null)
            extensionDial.Number = this.Number;
        if(this.InjectExtensionNameToCallerId!=null)
            extensionDial.InjectExtensionNameToCallerId = this.InjectExtensionNameToCallerId.Value;
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
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
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
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnExtensionQueue(ExtensionQueue extensionQueue)
    {
        if(this.IdsLines!=null)
            extensionQueue.IdsLines = this.IdsLines;
        if(this.IdExtensionIfTimeout!=null)
            extensionQueue.IdExtensionIfTimeout = this.IdExtensionIfTimeout;
        if(this.IdsAudios!=null)
            extensionQueue.IdsAudios = this.IdsAudios;
        if(this.SendEmailNotificationIfNotAnswered!=null)
            extensionQueue.SendEmailNotificationIfNotAnswered = this.SendEmailNotificationIfNotAnswered;
        if(this.SendEmailNotificationIfItTakesToLongToBeAnswered!=null)
            extensionQueue.SendEmailNotificationIfItTakesToLongToBeAnswered = this.SendEmailNotificationIfItTakesToLongToBeAnswered;
        if(this.RingTimeInSeconds!=null)
            extensionQueue.RingTimeInSeconds = this.RingTimeInSeconds.Value;
        if(this.RingInUse!=null)
            extensionQueue.RingInUse = this.RingInUse.Value;
        if(this.QueueTimeoutInMinutes!=null)
            extensionQueue.QueueTimeoutInMinutes = this.QueueTimeoutInMinutes.Value;
        if(this.AnnouncePosition!=null)
            extensionQueue.AnnouncePosition = this.AnnouncePosition.Value;
        if(this.AnnounceHoldTime!=null)
            extensionQueue.AnnounceHoldTime = this.AnnounceHoldTime.Value;
        if(this.AnnounceFrequency!=null)
            extensionQueue.AnnounceFrequency = this.AnnounceFrequency.Value;
        if(this.RetryFrequency!=null)
            extensionQueue.RetryFrequency = this.RetryFrequency.Value;
        if(this.RingStrategy!=null)
            extensionQueue.RingStrategy = this.RingStrategy.Value;
        if(this.IdMusicOnHoldGroup!=null)
            extensionQueue.IdMusicOnHoldGroup = this.IdMusicOnHoldGroup;
        if(this.IdsTags!=null)
            extensionQueue.IdsTags = this.IdsTags;
        if(this.FriendlyName!=null)
            extensionQueue.FriendlyName = this.FriendlyName;
        if(this.Number!=null)
            extensionQueue.Number = this.Number;
        if(this.InjectExtensionNameToCallerId!=null)
            extensionQueue.InjectExtensionNameToCallerId = this.InjectExtensionNameToCallerId.Value;
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
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
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
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnExtensionVoicemail(ExtensionVoicemail extensionVoicemail)
    {
        if(this.IdAudio!=null)
            extensionVoicemail.IdAudio = this.IdAudio;
        if(this.IdsLinesThatCanListenToVoicemail!=null)
            extensionVoicemail.IdsLinesThatCanListenToVoicemail = this.IdsLinesThatCanListenToVoicemail;
        if(this.IdEmail!=null)
            extensionVoicemail.IdEmail = this.IdEmail;
        if(this.TextToSpeech!=null)
            extensionVoicemail.TextToSpeech = this.TextToSpeech;
        if(this.TextToSpeechVoiceId!=null)
            extensionVoicemail.TextToSpeechVoiceId = this.TextToSpeechVoiceId;
        if(this.IdMusicOnHoldGroup!=null)
            extensionVoicemail.IdMusicOnHoldGroup = this.IdMusicOnHoldGroup;
        if(this.IdsTags!=null)
            extensionVoicemail.IdsTags = this.IdsTags;
        if(this.FriendlyName!=null)
            extensionVoicemail.FriendlyName = this.FriendlyName;
        if(this.Number!=null)
            extensionVoicemail.Number = this.Number;
        if(this.InjectExtensionNameToCallerId!=null)
            extensionVoicemail.InjectExtensionNameToCallerId = this.InjectExtensionNameToCallerId.Value;
    }

}

/// <summary>
/// Incoming fax
/// </summary><summary>
/// Incoming fax
/// </summary>
public class FaxIncomingUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnFaxIncoming(FaxIncoming faxIncoming)
    {
        if(this.IdsTags!=null)
            faxIncoming.IdsTags = this.IdsTags;
    }

}

/// <summary>
/// Group of faxes sent as a group via email
/// </summary><summary>
/// Group of faxes sent as a group via email
/// </summary>
public class FaxOutgoingGroupUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnFaxOutgoingGroup(FaxOutgoingGroup faxOutgoingGroup)
    {
        if(this.IdsTags!=null)
            faxOutgoingGroup.IdsTags = this.IdsTags;
    }

}

/// <summary>
/// Someone that has access to consume Ublux Web Api. It can be a PBX, WA, or UbluxUser
/// </summary><summary>
/// Someone that has access to consume Ublux Web Api. It can be a PBX, WA, or UbluxUser
/// </summary>
public class UserUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary>
    /// Key = service/role such as Phone. The phone role probably will have access to the PhoneController service
    /// Value = Permissions it has on that role. Maybe it can only read data from that service but it cannot update, create or modify.
    /// </summary>
    public List<Ublux.Communications.Enums.UbluxRole>? UbluxRoles { get; set; }
    /// <summary>
    /// Only allow connections from this regex. Default is "*"
    /// </summary>
    public String? AllowConnectingFromIpRegex { get; set; }
    /// <summary>
    /// Only allow authentication if ip address stays the same.
    /// If IpAddressLastAuthenticated is null then this will be allowed.
    /// </summary>
    public Boolean? PreventConnectingIfIpChanges { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnUser(User user)
    {
        if(this.IdsTags!=null)
            user.IdsTags = this.IdsTags;
        if(this.UbluxRoles!=null)
            user.UbluxRoles = this.UbluxRoles;
        if(this.AllowConnectingFromIpRegex!=null)
            user.AllowConnectingFromIpRegex = this.AllowConnectingFromIpRegex;
        if(this.PreventConnectingIfIpChanges!=null)
            user.PreventConnectingIfIpChanges = this.PreventConnectingIfIpChanges.Value;
    }

}

/// <summary>
/// Group of line keys
/// </summary><summary>
/// Group of line keys
/// </summary>
public class LineKeyGroupUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
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
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnLineKeyGroup(LineKeyGroup lineKeyGroup)
    {
        if(this.IdsTags!=null)
            lineKeyGroup.IdsTags = this.IdsTags;
        if(this.LineKeys!=null)
            lineKeyGroup.LineKeys = this.LineKeys;
        if(this.FriendlyName!=null)
            lineKeyGroup.FriendlyName = this.FriendlyName;
        if(this.Description!=null)
            lineKeyGroup.Description = this.Description;
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
    public void SetValuesOnLogWebServiceRequest(LogWebServiceRequest logWebServiceRequest)
    {
    }

}

/// <summary>
/// Multiple audios to be used as music on hold
/// </summary><summary>
/// Multiple audios to be used as music on hold
/// </summary>
public class MusicOnHoldGroupUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Audios to play meanwhile on hold
    /// </summary>
    public List<System.String>? IdsAudios { get; set; }
    /// <summary>
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary>
    /// Name of music on hold group
    /// </summary>
    public String? FriendlyName { get; set; }
    /// <summary>
    /// Description of music on hold group
    /// </summary>
    public String? Description { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnMusicOnHoldGroup(MusicOnHoldGroup musicOnHoldGroup)
    {
        if(this.IdsAudios!=null)
            musicOnHoldGroup.IdsAudios = this.IdsAudios;
        if(this.IdsTags!=null)
            musicOnHoldGroup.IdsTags = this.IdsTags;
        if(this.FriendlyName!=null)
            musicOnHoldGroup.FriendlyName = this.FriendlyName;
        if(this.Description!=null)
            musicOnHoldGroup.Description = this.Description;
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
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
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
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnPhone(Phone phone)
    {
        if(this.IdsTags!=null)
            phone.IdsTags = this.IdsTags;
        if(this.IdCloudServicePbx!=null)
            phone.IdCloudServicePbx = this.IdCloudServicePbx;
        if(this.IdPhoneConfiguration!=null)
            phone.IdPhoneConfiguration = this.IdPhoneConfiguration;
        if(this.IdUser!=null)
            phone.IdUser = this.IdUser;
        if(this.Lines!=null)
            phone.Lines = this.Lines;
        if(this.FriendlyName!=null)
            phone.FriendlyName = this.FriendlyName;
        if(this.PhoneType!=null)
            phone.PhoneType = this.PhoneType.Value;
        if(this.DisableEncryption!=null)
            phone.DisableEncryption = this.DisableEncryption.Value;
    }

}

/// <summary>
/// Configuration of a phone
/// </summary><summary>
/// Configuration of a phone
/// </summary>
public class PhoneConfigurationUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Line keys to use
    /// </summary>
    public String? IdLineKeyGroup { get; set; }
    /// <summary>
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary>
    /// Phone configuration name
    /// </summary>
    public String? FrienlyName { get; set; }
    /// <summary>
    /// Phone configuration description
    /// </summary>
    public String? Description { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnPhoneConfiguration(PhoneConfiguration phoneConfiguration)
    {
        if(this.IdLineKeyGroup!=null)
            phoneConfiguration.IdLineKeyGroup = this.IdLineKeyGroup;
        if(this.IdsTags!=null)
            phoneConfiguration.IdsTags = this.IdsTags;
        if(this.FrienlyName!=null)
            phoneConfiguration.FrienlyName = this.FrienlyName;
        if(this.Description!=null)
            phoneConfiguration.Description = this.Description;
    }

}

/// <summary>
/// Group used to call multiple parties
/// </summary><summary>
/// Group used to call multiple parties
/// </summary>
public class PowerDialerGroupUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary>
    /// Friendly name of power dialer group
    /// </summary>
    public String? FriendlyName { get; set; }
    /// <summary>
    /// Description of power dialer group
    /// </summary>
    public String? Description { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnPowerDialerGroup(PowerDialerGroup powerDialerGroup)
    {
        if(this.IdsTags!=null)
            powerDialerGroup.IdsTags = this.IdsTags;
        if(this.FriendlyName!=null)
            powerDialerGroup.FriendlyName = this.FriendlyName;
        if(this.Description!=null)
            powerDialerGroup.Description = this.Description;
    }

}

/// <summary>
/// SMS message
/// </summary><summary>
/// SMS message
/// </summary>
public class SMSUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnSMS(SMS sMS)
    {
        if(this.IdsTags!=null)
            sMS.IdsTags = this.IdsTags;
    }

}

/// <summary>
/// This type of trunk origination forwards the call to our pbx. Twilio uses this type of Trunk origination
/// </summary>
public class TrunkOriginationForwardUpdateRequest // : IUbluxDocumentId
{
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnTrunkOriginationForward(TrunkOriginationForward trunkOriginationForward)
    {
    }

}

/// <summary>
/// This type of trunk origination we must register with provider in order to receive phone calls. Netbox solutions uses this type of trunk
/// </summary>
public class TrunkOriginationRegisterUpdateRequest // : IUbluxDocumentId
{
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnTrunkOriginationRegister(TrunkOriginationRegister trunkOriginationRegister)
    {
    }

}

/// <summary>
/// Trunk used to receive phone calls
/// </summary>
public class TrunkTerminationUpdateRequest // : IUbluxDocumentId
{
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnTrunkTermination(TrunkTermination trunkTermination)
    {
    }

}

/// <summary>
/// Group of trunk terminations ordered by priority
/// </summary>
public class TrunkTerminationGroupUpdateRequest // : IUbluxDocumentId
{
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnTrunkTerminationGroup(TrunkTerminationGroup trunkTerminationGroup)
    {
    }

}

/// <summary>
/// Tokens that are not authorized. Perhaps a token has been stolen
/// </summary><summary>
/// Tokens that are not authorized. Perhaps a token has been stolen
/// </summary>
public class UnauthorizedTokenUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnUnauthorizedToken(UnauthorizedToken unauthorizedToken)
    {
        if(this.IdsTags!=null)
            unauthorizedToken.IdsTags = this.IdsTags;
    }

}

/// <summary>
/// Extensions may forward an existing voicemail to another extension
/// </summary>
public class VoicemailUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnVoicemail(Voicemail voicemail)
    {
        if(this.IdsTags!=null)
            voicemail.IdsTags = this.IdsTags;
    }

}

/// <summary>
/// Voicemail that was forwarded from one extension to another
/// </summary>
public class VoicemailForwardedUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnVoicemailForwarded(VoicemailForwarded voicemailForwarded)
    {
        if(this.IdsTags!=null)
            voicemailForwarded.IdsTags = this.IdsTags;
    }

}

/// <summary>
/// Incoming phone number available for purchase
/// </summary>
public class VoipNumberAvailableForPurchaseUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
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
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnVoipNumberAvailableForPurchase(VoipNumberAvailableForPurchase voipNumberAvailableForPurchase)
    {
        if(this.IdsTags!=null)
            voipNumberAvailableForPurchase.IdsTags = this.IdsTags;
        if(this.IdMusicOnHoldGroup!=null)
            voipNumberAvailableForPurchase.IdMusicOnHoldGroup = this.IdMusicOnHoldGroup;
        if(this.InjectFriendlyNameToCallerId!=null)
            voipNumberAvailableForPurchase.InjectFriendlyNameToCallerId = this.InjectFriendlyNameToCallerId.Value;
        if(this.RecordIncomingCalls!=null)
            voipNumberAvailableForPurchase.RecordIncomingCalls = this.RecordIncomingCalls.Value;
        if(this.UseAiForIncomingCalls!=null)
            voipNumberAvailableForPurchase.UseAiForIncomingCalls = this.UseAiForIncomingCalls.Value;
        if(this.FriendlyName!=null)
            voipNumberAvailableForPurchase.FriendlyName = this.FriendlyName;
        if(this.Description!=null)
            voipNumberAvailableForPurchase.Description = this.Description;
        if(this.Language!=null)
            voipNumberAvailableForPurchase.Language = this.Language.Value;
        if(this.TimeZone!=null)
            voipNumberAvailableForPurchase.TimeZone = this.TimeZone;
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
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
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
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnVoipNumberFax(VoipNumberFax voipNumberFax)
    {
        if(this.RulesPhone!=null)
            voipNumberFax.RulesPhone = this.RulesPhone;
        if(this.RulesSms!=null)
            voipNumberFax.RulesSms = this.RulesSms;
        if(this.RulesFax!=null)
            voipNumberFax.RulesFax = this.RulesFax;
        if(this.IdsTags!=null)
            voipNumberFax.IdsTags = this.IdsTags;
        if(this.IdMusicOnHoldGroup!=null)
            voipNumberFax.IdMusicOnHoldGroup = this.IdMusicOnHoldGroup;
        if(this.InjectFriendlyNameToCallerId!=null)
            voipNumberFax.InjectFriendlyNameToCallerId = this.InjectFriendlyNameToCallerId.Value;
        if(this.RecordIncomingCalls!=null)
            voipNumberFax.RecordIncomingCalls = this.RecordIncomingCalls.Value;
        if(this.UseAiForIncomingCalls!=null)
            voipNumberFax.UseAiForIncomingCalls = this.UseAiForIncomingCalls.Value;
        if(this.FriendlyName!=null)
            voipNumberFax.FriendlyName = this.FriendlyName;
        if(this.Description!=null)
            voipNumberFax.Description = this.Description;
        if(this.Language!=null)
            voipNumberFax.Language = this.Language.Value;
        if(this.TimeZone!=null)
            voipNumberFax.TimeZone = this.TimeZone;
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
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
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
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnVoipNumberPhone(VoipNumberPhone voipNumberPhone)
    {
        if(this.RulesPhone!=null)
            voipNumberPhone.RulesPhone = this.RulesPhone;
        if(this.RulesSms!=null)
            voipNumberPhone.RulesSms = this.RulesSms;
        if(this.RulesFax!=null)
            voipNumberPhone.RulesFax = this.RulesFax;
        if(this.IdsTags!=null)
            voipNumberPhone.IdsTags = this.IdsTags;
        if(this.IdMusicOnHoldGroup!=null)
            voipNumberPhone.IdMusicOnHoldGroup = this.IdMusicOnHoldGroup;
        if(this.InjectFriendlyNameToCallerId!=null)
            voipNumberPhone.InjectFriendlyNameToCallerId = this.InjectFriendlyNameToCallerId.Value;
        if(this.RecordIncomingCalls!=null)
            voipNumberPhone.RecordIncomingCalls = this.RecordIncomingCalls.Value;
        if(this.UseAiForIncomingCalls!=null)
            voipNumberPhone.UseAiForIncomingCalls = this.UseAiForIncomingCalls.Value;
        if(this.FriendlyName!=null)
            voipNumberPhone.FriendlyName = this.FriendlyName;
        if(this.Description!=null)
            voipNumberPhone.Description = this.Description;
        if(this.Language!=null)
            voipNumberPhone.Language = this.Language.Value;
        if(this.TimeZone!=null)
            voipNumberPhone.TimeZone = this.TimeZone;
    }

}

/// <summary>
/// VOIP provider. Some providers have an API that enable us to automate things.
/// Examples of voip providers are Twilio, Marcatel, Airnetworks etc...
/// </summary>
public class VoipProviderUpdateRequest // : IUbluxDocumentId
{
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnVoipProvider(VoipProvider voipProvider)
    {
    }

}

/// <summary>
/// Web callback that will be fired when a custom event of interest occurs.
/// </summary><summary>
/// Web callback that will be fired when a custom event of interest occurs.
/// </summary>
public class WebHookUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
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
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnWebHook(WebHook webHook)
    {
        if(this.IdsTags!=null)
            webHook.IdsTags = this.IdsTags;
        if(this.EventTrigger!=null)
            webHook.EventTrigger = this.EventTrigger.Value;
        if(this.Url!=null)
            webHook.Url = this.Url;
        if(this.Headers!=null)
            webHook.Headers = this.Headers;
    }

}

/// <summary>
/// File stored on the cloud
/// This collection should not be stored on redis and be created with TTL of one month
/// </summary>
public class CloudFileUpdateRequest // : IUbluxDocumentId
{
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnCloudFile(CloudFile cloudFile)
    {
    }

}

/// <summary>
/// Category
/// </summary><summary>
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
    public void SetValuesOnTag(Tag tag)
    {
        if(this.FriendlyName!=null)
            tag.FriendlyName = this.FriendlyName;
        if(this.TagColor!=null)
            tag.TagColor = this.TagColor.Value;
    }

}

/// <summary>
/// Phone numbers that will be blocked
/// </summary><summary>
/// Phone numbers that will be blocked
/// </summary>
public class AiCallTranscriptionUpdateRequest // : IUbluxDocumentId
{
    /// <summary>
    /// Ids of tags
    /// </summary>
    public List<System.String>? IdsTags { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnAiCallTranscription(AiCallTranscription aiCallTranscription)
    {
        if(this.IdsTags!=null)
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
    public void SetValuesOnLine(Line line)
    {
        if(this.FriendlyName!=null)
            line.FriendlyName = this.FriendlyName;
        if(this.CallerIdNumber!=null)
            line.CallerIdNumber = this.CallerIdNumber;
        if(this.RecordExternalCalls!=null)
            line.RecordExternalCalls = this.RecordExternalCalls.Value;
        if(this.RecordInternalCalls!=null)
            line.RecordInternalCalls = this.RecordInternalCalls.Value;
        if(this.UseAiForExternalCalls!=null)
            line.UseAiForExternalCalls = this.UseAiForExternalCalls.Value;
        if(this.UseAiForOutgoingCallsToExtensions!=null)
            line.UseAiForOutgoingCallsToExtensions = this.UseAiForOutgoingCallsToExtensions.Value;
        if(this.Language!=null)
            line.Language = this.Language.Value;
    }

}
#pragma warning restore CA1822 // Mark members as static
#pragma warning restore IDE0060 // Remove unused parameter
