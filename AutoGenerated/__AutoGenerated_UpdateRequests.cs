/* THIS FILE IS AUTO GENERATED. DO NOT DELETE/MODIFY */
/* Contain properties with AllowUpdate=True */

#pragma warning disable CA1822 // Mark members as static
#pragma warning disable IDE0060 // Remove unused parameter

namespace Ublux.Communications.Models.Documents;


/// <summary>
/// Ublux Account
/// </summary><summary>
/// Ublux Account
/// </summary>
public class AccountUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
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
/// Store when user agreed to UBLUX terms and conditions for legal reasons.
/// </summary>
public class AgreementToTermsAndConditionsUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnAgreementToTermsAndConditions(AgreementToTermsAndConditions agreementToTermsAndConditions)
    {
    }

}

/// <summary>
/// When a customer purchases a Phone Number from AirNetworks Provider from Spain he needs to feel the province and population info
/// </summary>
public class AirNetworksProvinceUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
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
public class AudioUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
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
        if(this.FriendlyName!=null)
            audio.FriendlyName = this.FriendlyName;
        if(this.Description!=null)
            audio.Description = this.Description;
    }

}

/// <summary>
/// Id is the mac address of a phone. It should point to an ip phone
/// </summary>
public class AutoProvisionReferenceUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
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
public class BlackListPhoneNumberUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
    /// <summary>
    /// The phone number that will be blocked
    /// </summary>
    public String? PhoneNumber { get; set; }
    /// <summary>
    /// Friendly name of this rule
    /// </summary>
    public String? FriendlyName { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnBlackListPhoneNumber(BlackListPhoneNumber blackListPhoneNumber)
    {
        if(this.PhoneNumber!=null)
            blackListPhoneNumber.PhoneNumber = this.PhoneNumber;
        if(this.FriendlyName!=null)
            blackListPhoneNumber.FriendlyName = this.FriendlyName;
    }

}

/// <summary>
/// Phone numbers that will be blocked
/// </summary><summary>
/// Phone numbers that will be blocked
/// </summary>
public class CallerIdMaskUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
    /// <summary>
    /// Name of this caller id mask
    /// </summary>
    public String? FriendlyName { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnCallerIdMask(CallerIdMask callerIdMask)
    {
        if(this.FriendlyName!=null)
            callerIdMask.FriendlyName = this.FriendlyName;
    }

}

/// <summary>
/// Virtual receptionist
/// </summary><summary>
/// Virtual receptionist
/// </summary>
public class CallFlowUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
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
    public String? XmlTree { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnCallFlow(CallFlow callFlow)
    {
        if(this.FriendlyName!=null)
            callFlow.FriendlyName = this.FriendlyName;
        if(this.Description!=null)
            callFlow.Description = this.Description;
        if(this.XmlTree!=null)
            callFlow.XmlTree = this.XmlTree;
    }

}

/// <summary>
/// Incoming phone call that executed an IVR
/// </summary>
public class CallIncomingToCallFlowUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnCallIncomingToCallFlow(CallIncomingToCallFlow callIncomingToCallFlow)
    {
    }

}

/// <summary>
/// Incoming phone call from PSTN to an extension
/// </summary>
public class CallIncomingToExtensionUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnCallIncomingToExtension(CallIncomingToExtension callIncomingToExtension)
    {
    }

}

/// <summary>
/// Call made to an extension
/// </summary>
public class CallOutgoingToExtensionUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnCallOutgoingToExtension(CallOutgoingToExtension callOutgoingToExtension)
    {
    }

}

/// <summary>
/// Call made to cell phone or land line
/// </summary><summary>
/// Call made to cell phone or land line
/// </summary>
public class CallOutgoingToPSTNUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnCallOutgoingToPSTN(CallOutgoingToPSTN callOutgoingToPSTN)
    {
    }

}

/// <summary>
/// PBX cloud service where phones connect
/// </summary>
public class CloudServicePbxUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnCloudServicePbx(CloudServicePbx cloudServicePbx)
    {
    }

}

/// <summary>
/// Web app where web-phone lives
/// </summary>
public class CloudServiceWebAppUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnCloudServiceWebApp(CloudServiceWebApp cloudServiceWebApp)
    {
    }

}

/// <summary>
/// Server where ublux website lives
/// </summary>
public class CloudServiceWebHostUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnCloudServiceWebHost(CloudServiceWebHost cloudServiceWebHost)
    {
    }

}

/// <summary>
/// Ublux API cloud service
/// </summary>
public class CloudServiceWebServiceUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnCloudServiceWebService(CloudServiceWebService cloudServiceWebService)
    {
    }

}

/// <summary>
/// Contact
/// </summary><summary>
/// Contact
/// </summary>
public class ContactUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
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
    public String? JobTittle { get; set; }
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
        if(this.ContactNumbers!=null)
            contact.ContactNumbers = this.ContactNumbers;
        if(this.ContactEmails!=null)
            contact.ContactEmails = this.ContactEmails;
        if(this.FirstName!=null)
            contact.FirstName = this.FirstName;
        if(this.LastName!=null)
            contact.LastName = this.LastName;
        if(this.JobTittle!=null)
            contact.JobTittle = this.JobTittle;
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
/// </summary>
public class CustomerInfoUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
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
        if(this.MailingAddress!=null)
            customerInfo.MailingAddress = this.MailingAddress;
        if(this.FullName!=null)
            customerInfo.FullName = this.FullName;
    }

}

/// <summary>
/// Executes a custom IVR when calling this extension
/// </summary>
public class ExtensionCallFlowUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
    /// <summary>
    /// Id of call flow to execute
    /// </summary>
    public String? IdCallFlow { get; set; }
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
    /// Extension number
    /// </summary>
    public String? Number { get; set; }
    /// <summary>
    /// Inject extension name to caller id
    /// </summary>
    public Boolean? InjectExtensionNameToCallerId { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnExtensionCallFlow(ExtensionCallFlow extensionCallFlow)
    {
        if(this.IdCallFlow!=null)
            extensionCallFlow.IdCallFlow = this.IdCallFlow;
        if(this.CallFlowLabel!=null)
            extensionCallFlow.CallFlowLabel = this.CallFlowLabel;
        if(this.TimeZone!=null)
            extensionCallFlow.TimeZone = this.TimeZone;
        if(this.IdMusicOnHoldGroup!=null)
            extensionCallFlow.IdMusicOnHoldGroup = this.IdMusicOnHoldGroup;
        if(this.Number!=null)
            extensionCallFlow.Number = this.Number;
        if(this.InjectExtensionNameToCallerId!=null)
            extensionCallFlow.InjectExtensionNameToCallerId = this.InjectExtensionNameToCallerId.Value;
    }

}

/// <summary>
/// Parties that dial this extension will be connected
/// </summary>
public class ExtensionConferenceUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
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
        if(this.Number!=null)
            extensionConference.Number = this.Number;
        if(this.InjectExtensionNameToCallerId!=null)
            extensionConference.InjectExtensionNameToCallerId = this.InjectExtensionNameToCallerId.Value;
    }

}

/// <summary>
/// Basic extension
/// </summary>
public class ExtensionDialUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
    /// <summary>
    /// Lines to call and ring. Minimum of one line is required
    /// </summary>
    public List<System.String>? IdsLines { get; set; }
    /// <summary>
    /// EventAction to execute if call is not answered
    /// </summary>
    public EventAction? EventActionToExecuteIfCallIsNotAnswered { get; set; }
    /// <summary>
    /// Send email notification if call is not answered
    /// </summary>
    public SendEmailNotificationIfCallIsNotAnswered? SendEmailNotificationIfCallIsNotAnswered { get; set; }
    /// <summary>
    /// Number of seconds each line will ring
    /// </summary>
    public Int32? RingTimeInSeconds { get; set; }
    /// <summary>
    /// Music on hold to use
    /// </summary>
    public String? IdMusicOnHoldGroup { get; set; }
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
        if(this.EventActionToExecuteIfCallIsNotAnswered!=null)
            extensionDial.EventActionToExecuteIfCallIsNotAnswered = this.EventActionToExecuteIfCallIsNotAnswered;
        if(this.SendEmailNotificationIfCallIsNotAnswered!=null)
            extensionDial.SendEmailNotificationIfCallIsNotAnswered = this.SendEmailNotificationIfCallIsNotAnswered;
        if(this.RingTimeInSeconds!=null)
            extensionDial.RingTimeInSeconds = this.RingTimeInSeconds.Value;
        if(this.IdMusicOnHoldGroup!=null)
            extensionDial.IdMusicOnHoldGroup = this.IdMusicOnHoldGroup;
        if(this.Number!=null)
            extensionDial.Number = this.Number;
        if(this.InjectExtensionNameToCallerId!=null)
            extensionDial.InjectExtensionNameToCallerId = this.InjectExtensionNameToCallerId.Value;
    }

}

/// <summary>
/// Extension where people that call will be placed on a sequence awaiting their turn to be attended
/// </summary>
public class ExtensionQueueUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
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
    public SendEmailNotificationIfCallIsNotAnswered? SendEmailNotificationIfCallIsNotAnswered { get; set; }
    /// <summary>
    /// Send email notification if call takes to long to be answered
    /// </summary>
    public SendEmailNotificationIfCallTakesToLongToBeAnswered? SendEmailNotificationIfCallTakesToLongToBeAnswered { get; set; }
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
    public Boolean? PlayPositionAnnouncements { get; set; }
    /// <summary>
    /// Number of seconds to wait in between rings. Default value if null is 20 seconds
    /// </summary>
    public Int32? RetryFrequency { get; set; }
    /// <summary>
    /// Music on hold to use
    /// </summary>
    public String? IdMusicOnHoldGroup { get; set; }
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
        if(this.SendEmailNotificationIfCallIsNotAnswered!=null)
            extensionQueue.SendEmailNotificationIfCallIsNotAnswered = this.SendEmailNotificationIfCallIsNotAnswered;
        if(this.SendEmailNotificationIfCallTakesToLongToBeAnswered!=null)
            extensionQueue.SendEmailNotificationIfCallTakesToLongToBeAnswered = this.SendEmailNotificationIfCallTakesToLongToBeAnswered;
        if(this.RingTimeInSeconds!=null)
            extensionQueue.RingTimeInSeconds = this.RingTimeInSeconds.Value;
        if(this.RingInUse!=null)
            extensionQueue.RingInUse = this.RingInUse.Value;
        if(this.QueueTimeoutInMinutes!=null)
            extensionQueue.QueueTimeoutInMinutes = this.QueueTimeoutInMinutes.Value;
        if(this.PlayPositionAnnouncements!=null)
            extensionQueue.PlayPositionAnnouncements = this.PlayPositionAnnouncements.Value;
        if(this.RetryFrequency!=null)
            extensionQueue.RetryFrequency = this.RetryFrequency.Value;
        if(this.IdMusicOnHoldGroup!=null)
            extensionQueue.IdMusicOnHoldGroup = this.IdMusicOnHoldGroup;
        if(this.Number!=null)
            extensionQueue.Number = this.Number;
        if(this.InjectExtensionNameToCallerId!=null)
            extensionQueue.InjectExtensionNameToCallerId = this.InjectExtensionNameToCallerId.Value;
    }

}

/// <summary>
/// Calling this extension will enable to store a voicemail and be sent via email
/// </summary>
public class ExtensionVoicemailUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
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
    public List<System.String>? Email { get; set; }
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
        if(this.Email!=null)
            extensionVoicemail.Email = this.Email;
        if(this.TextToSpeech!=null)
            extensionVoicemail.TextToSpeech = this.TextToSpeech;
        if(this.TextToSpeechVoiceId!=null)
            extensionVoicemail.TextToSpeechVoiceId = this.TextToSpeechVoiceId;
        if(this.IdMusicOnHoldGroup!=null)
            extensionVoicemail.IdMusicOnHoldGroup = this.IdMusicOnHoldGroup;
        if(this.Number!=null)
            extensionVoicemail.Number = this.Number;
        if(this.InjectExtensionNameToCallerId!=null)
            extensionVoicemail.InjectExtensionNameToCallerId = this.InjectExtensionNameToCallerId.Value;
    }

}

/// <summary>
/// Ublux sends and receives faxes via email. This class enables to know the relationship between an email and a fax.
/// For example email foo@gmail.com will send faxes through VoipFax with id XXXX-XXXX
/// </summary><summary>
/// Ublux sends and receives faxes via email. This class enables to know the relationship between an email and a fax.
/// For example email foo@gmail.com will send faxes through VoipFax with id XXXX-XXXX
/// </summary>
public class FaxEmailInfoUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnFaxEmailInfo(FaxEmailInfo faxEmailInfo)
    {
    }

}

/// <summary>
/// Incoming fax
/// </summary><summary>
/// Incoming fax
/// </summary>
public class FaxIncomingUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnFaxIncoming(FaxIncoming faxIncoming)
    {
    }

}

/// <summary>
/// Group of faxes sent as a group via email
/// </summary><summary>
/// Group of faxes sent as a group via email
/// </summary>
public class FaxOutgoingGroupUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnFaxOutgoingGroup(FaxOutgoingGroup faxOutgoingGroup)
    {
    }

}

/// <summary>
/// Someone that has access to consume Ublux Web Api. It can be a PBX, WA, or UbluxUser
/// </summary><summary>
/// Someone that has access to consume Ublux Web Api. It can be a PBX, WA, or UbluxUser
/// </summary>
public class IdentityUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
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
    public void SetValuesOnIdentity(Identity identity)
    {
        if(this.UbluxRoles!=null)
            identity.UbluxRoles = this.UbluxRoles;
        if(this.AllowConnectingFromIpRegex!=null)
            identity.AllowConnectingFromIpRegex = this.AllowConnectingFromIpRegex;
        if(this.PreventConnectingIfIpChanges!=null)
            identity.PreventConnectingIfIpChanges = this.PreventConnectingIfIpChanges.Value;
    }

}

/// <summary>
/// Ip address
/// </summary><summary>
/// Ip address
/// </summary>
public class IPUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnIP(IP iP)
    {
    }

}

/// <summary>
/// Group of line keys
/// </summary><summary>
/// Group of line keys
/// </summary>
public class LineKeyGroupUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
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
public class LogWebServiceRequestUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
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
public class MusicOnHoldGroupUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
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
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnMusicOnHoldGroup(MusicOnHoldGroup musicOnHoldGroup)
    {
        if(this.IdsAudios!=null)
            musicOnHoldGroup.IdsAudios = this.IdsAudios;
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
public class PhoneUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
    /// <summary>
    /// This specifies to what PBX it will be connected to
    /// </summary>
    public String? IdCloudServicePbx { get; set; }
    /// <summary>
    /// Configuration phone will use
    /// </summary>
    public String? IdPhoneConfiguration { get; set; }
    /// <summary>
    /// Descriptive name of phone
    /// </summary>
    public String? FriendlyName { get; set; }
    /// <summary>
    /// Username and password to login to web-app
    /// </summary>
    public String? IdIdentityWebApp { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnPhone(Phone phone)
    {
        if(this.IdCloudServicePbx!=null)
            phone.IdCloudServicePbx = this.IdCloudServicePbx;
        if(this.IdPhoneConfiguration!=null)
            phone.IdPhoneConfiguration = this.IdPhoneConfiguration;
        if(this.FriendlyName!=null)
            phone.FriendlyName = this.FriendlyName;
        if(this.IdIdentityWebApp!=null)
            phone.IdIdentityWebApp = this.IdIdentityWebApp;
    }

}

/// <summary>
/// Configuration of a phone
/// </summary><summary>
/// Configuration of a phone
/// </summary>
public class PhoneConfigurationUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
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
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnPhoneConfiguration(PhoneConfiguration phoneConfiguration)
    {
        if(this.IdLineKeyGroup!=null)
            phoneConfiguration.IdLineKeyGroup = this.IdLineKeyGroup;
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
public class PowerDialerGroupUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
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
public class SMSUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnSMS(SMS sMS)
    {
    }

}

/// <summary>
/// This type of trunk origination forwards the call to our pbx. Twilio uses this type of Trunk origination
/// </summary>
public class TrunkOriginationForwardUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnTrunkOriginationForward(TrunkOriginationForward trunkOriginationForward)
    {
    }

}

/// <summary>
/// This type of trunk origination we must register with provider in order to receive phone calls
/// </summary>
public class TrunkOriginationRegisterUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnTrunkOriginationRegister(TrunkOriginationRegister trunkOriginationRegister)
    {
    }

}

/// <summary>
/// Trunk used to receive phone calls
/// </summary>
public class TrunkTerminationUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnTrunkTermination(TrunkTermination trunkTermination)
    {
    }

}

/// <summary>
/// Group of trunk terminations ordered by priority
/// </summary>
public class TrunkTerminationGroupUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
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
public class UnauthorizedTokenUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnUnauthorizedToken(UnauthorizedToken unauthorizedToken)
    {
    }

}

/// <summary>
/// Extensions may forward an existing voicemail to another extension
/// </summary>
public class VoicemailUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnVoicemail(Voicemail voicemail)
    {
    }

}

/// <summary>
/// Voicemail that was forwarded from one extension to another
/// </summary>
public class VoicemailForwardedUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnVoicemailForwarded(VoicemailForwarded voicemailForwarded)
    {
    }

}

/// <summary>
/// Incoming phone number available for purchase
/// </summary>
public class VoipNumberAvailableForPurchaseUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
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
        if(this.InjectFriendlyNameToCallerId!=null)
            voipNumberAvailableForPurchase.InjectFriendlyNameToCallerId = this.InjectFriendlyNameToCallerId.Value;
        if(this.RecordIncomingCalls!=null)
            voipNumberAvailableForPurchase.RecordIncomingCalls = this.RecordIncomingCalls.Value;
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
public class VoipNumberFaxUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
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
        if(this.InjectFriendlyNameToCallerId!=null)
            voipNumberFax.InjectFriendlyNameToCallerId = this.InjectFriendlyNameToCallerId.Value;
        if(this.RecordIncomingCalls!=null)
            voipNumberFax.RecordIncomingCalls = this.RecordIncomingCalls.Value;
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
public class VoipNumberPhoneUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
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
        if(this.InjectFriendlyNameToCallerId!=null)
            voipNumberPhone.InjectFriendlyNameToCallerId = this.InjectFriendlyNameToCallerId.Value;
        if(this.RecordIncomingCalls!=null)
            voipNumberPhone.RecordIncomingCalls = this.RecordIncomingCalls.Value;
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
/// </summary>
public class VoipProviderUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
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
public class WebHookUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
    /// <summary>
    /// Points to enum and not database!
    /// </summary>
    public WebHookEvent? WebHookEvent { get; set; }
    /// <summary>
    /// Url where event will be sent
    /// </summary>
    public String? Url { get; set; }
    /// <summary>
    /// Custom headers to inject on request. Example: x-token:1234,user:user1
    /// </summary>
    public List<System.String>? Headers { get; set; }
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnWebHook(WebHook webHook)
    {
        if(this.WebHookEvent!=null)
            webHook.WebHookEvent = this.WebHookEvent.Value;
        if(this.Url!=null)
            webHook.Url = this.Url;
        if(this.Headers!=null)
            webHook.Headers = this.Headers;
    }

}

/// <summary>
/// It is part of a phone. Lines are needed in order to make and receive phone calls.
/// </summary><summary>
/// It is part of a phone. Lines are needed in order to make and receive phone calls.
/// </summary>
public class LineUpdateRequest : IUbluxDocumentId
{
    /// <inheritdoc />
    public string Id { get; set; } = String.Empty;
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
    /// <summary> Set values on actual document </summary>
    public void SetValuesOnLine(Line line)
    {
        if(this.CallerIdNumber!=null)
            line.CallerIdNumber = this.CallerIdNumber;
        if(this.RecordExternalCalls!=null)
            line.RecordExternalCalls = this.RecordExternalCalls.Value;
        if(this.RecordInternalCalls!=null)
            line.RecordInternalCalls = this.RecordInternalCalls.Value;
    }

}
#pragma warning restore CA1822 // Mark members as static
#pragma warning restore IDE0060 // Remove unused parameter
