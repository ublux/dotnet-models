#if UBLUX_BACKEND 
/* FILE AUTOGENERATED DO NOT MODIFY OR DELETE */ 
/* File contains id generator methods to ensure all ids are generated correctly */ 


namespace Ublux.Communications.Models.Documents {

    public partial class ApiKey {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "AK";

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class Account {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "Ac";

        /// <summary> Custom: prefix and account number </summary>
        public static BuiltId BuildId(string accountNumber) => new($"{DocumentPrefix}.{uint.Parse(accountNumber)}");
        /// <summary> Custom: overload </summary>
        public static BuiltId BuildId(uint accountNumber) => new($"{DocumentPrefix}.{accountNumber}");
    }
    public partial class Email {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "Em";

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class AgreementToTermsAndConditions {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "ATTAC";

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class AirNetworksProvince {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "ANP";

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class Audio {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "Au";

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class AutoProvisionReference {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "APR";

        /// <summary> Id is the mac address without : and in lowercase </summary>
        public static BuiltId BuildId(string macAddress) => new($"{DocumentPrefix}.{macAddress.Replace(":", "").ToLower()}");
    }
    public partial class BlackListPhoneNumber {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "BLPN";

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class CallerIdMask {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "CIM";

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class CallFlowLogic {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "CFL";

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class CallIncomingToCallFlowLogic {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "CITCFL";

        /// <summary> Custom: prefix.instance.channel-uid. Example COTE.PBXUS1.1232123.2 </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance,  string channelUid) => new($"{DocumentPrefix}.{instance.Id}.{channelUid}");
    }
    public partial class CallIncomingToExtension {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "CITE";

        /// <summary> Custom: prefix.instance.channel-uid. Example COTE.PBXUS1.1232123.2 </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance,  string channelUid) => new($"{DocumentPrefix}.{instance.Id}.{channelUid}");
    }
    public partial class CallOutgoingToExtension {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "COTE";

        /// <summary> Custom: prefix.instance.channel-uid. Example COTE.PBXUS1.1232123.2 </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance,  string channelUid) => new($"{DocumentPrefix}.{instance.Id}.{channelUid}");
    }
    public partial class CallOutgoingToPSTN {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "COTPSTN";

        /// <summary> Custom: prefix.instance.channel-uid. Example COTE.PBXUS1.1232123.2 </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance,  string channelUid) => new($"{DocumentPrefix}.{instance.Id}.{channelUid}");
    }
    public partial class CloudServicePbx {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "CSP";

        /// <summary> Custom: Prefix followed by id. Example: CSP.US-1  CSWA.US-1 </summary>
        public static BuiltId BuildId(CountryIsoCode country, int number) => new($"{DocumentPrefix}.{country}-{number}");
        /// <summary> Build test cloud service: Example: CSP.US-T  CSWA.US-T </summary>
        public static BuiltId BuildIdTest(CountryIsoCode country) => new($"{DocumentPrefix}.{country}-T");
    }
    public partial class CloudServiceWebApp {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "CSWA";

        /// <summary> Custom: Prefix followed by id. Example: CSP.US-1  CSWA.US-1 </summary>
        public static BuiltId BuildId(CountryIsoCode country, int number) => new($"{DocumentPrefix}.{country}-{number}");
        /// <summary> Build test cloud service: Example: CSP.US-T  CSWA.US-T </summary>
        public static BuiltId BuildIdTest(CountryIsoCode country) => new($"{DocumentPrefix}.{country}-T");
    }
    public partial class CloudServiceWebHost {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "CSWH";

        /// <summary> Custom: Prefix followed by id. Example: CSP.US-1  CSWA.US-1 </summary>
        public static BuiltId BuildId(CountryIsoCode country, int number) => new($"{DocumentPrefix}.{country}-{number}");
        /// <summary> Build test cloud service: Example: CSP.US-T  CSWA.US-T </summary>
        public static BuiltId BuildIdTest(CountryIsoCode country) => new($"{DocumentPrefix}.{country}-T");
    }
    public partial class Contact {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "Co";

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class CustomerInfo {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "CI";

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class ExtensionCallFlowLogic {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "ECFL";

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class ExtensionConference {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "EC";

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class ExtensionDial {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "ED";

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class AiCallAnalysisInput {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "ACAI";

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class ExtensionQueue {
        /// <summary> Id prefix </summary>
        public new const string DocumentPrefix = "EQ";

        /// <summary> Build Id </summary>
        public new static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class ExtensionVoicemail {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "EV";

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class FaxIncoming {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "FI";

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class FaxOutgoingGroup {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "FOG";

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class User {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "Us";

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class SpeedDialGroup {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "SDG";

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class LogApiRequest {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "LAR";

        /// <summary> Custom: prefix and trace id </summary>
        public static BuiltId BuildId(string traceId) => new($"{DocumentPrefix}.{traceId}");
    }
    public partial class MusicOnHoldGroup {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "MOHG";

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class Phone {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "Ph";

        /// <summary> Ph | IdAccount | Instance | Counter  </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance, string idAccount) => new($"{DocumentPrefix}.{idAccount}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class PhoneConfiguration {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "PC";

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class PowerDialerGroup {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "PDG";

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class SMS {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "SMS";

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class TrunkTermination {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "TT";

        /// <summary> Custom: Prefix follwed by trunk name. Example TT.Twilio-Victor-All </summary>
        public static BuiltId BuildId(VoipCompany voipCompany, UbluxPartner ubluxPartner, CountryIsoCode countryIsoCode, int number) => new($"{DocumentPrefix}.{voipCompany}-{ubluxPartner}-{countryIsoCode}-{number}");
    }
    public partial class TrunkTerminationGroup {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "TTG";

        /// <summary> Custom: Example: TTG.Victor-ES </summary>
        public static BuiltId BuildId(UbluxPartner ubluxPartner, CountryIsoCode countryIsoCode) => new($"{DocumentPrefix}.{ubluxPartner}-{countryIsoCode}");
    }
    public partial class Voicemail {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "Vo";

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class VoicemailForwarded {
        /// <summary> Id prefix </summary>
        public new const string DocumentPrefix = "VF";

        /// <summary> Build Id </summary>
        public new static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class VoipNumberAvailableForPurchase {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "VNAFP";

        /// <summary> Custom: id of account only </summary>
        public static BuiltId BuildId(string phoneNumber) => new($"{DocumentPrefix}.{new String(phoneNumber.Where(Char.IsDigit).ToArray())[^8..]}");
    }
    public partial class VoipNumberFax {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "VNF";

        /// <summary> Custom: id of account only </summary>
        public static BuiltId BuildId(string phoneNumber, string idAccount) => new($"{DocumentPrefix}.{idAccount}.{new String(phoneNumber.Where(Char.IsDigit).ToArray())[^8..]}");
    }
    public partial class VoipNumberPhone {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "VNP";

        /// <summary> Custom: id of account only </summary>
        public static BuiltId BuildId(string phoneNumber, string idAccount) => new($"{DocumentPrefix}.{idAccount}.{new String(phoneNumber.Where(Char.IsDigit).ToArray())[^8..]}");
    }
    public partial class VoipProvider {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "VP";

        /// <summary> Custom: Example: VP.Twilio-Victor-US </summary>
        public static BuiltId BuildId(VoipCompany voipCompany, UbluxPartner ubluxPartner, CountryIsoCode countryIsoCode) => new($"{DocumentPrefix}.{voipCompany}-{ubluxPartner}-{countryIsoCode}");
    }
    public partial class WebHook {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "WH";

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class StoredFileReference {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "SFR";

        /// <summary> Prefix followed by stored file id Example DF.SF.1232 </summary>
        public static BuiltId BuildId(StoredFile storedFile) => new($"{DocumentPrefix}.{storedFile.Id}");
        /// <summary> Overload </summary>
        public static BuiltId BuildId(string storedFileId) => new($"{DocumentPrefix}.{storedFileId}");
    }
    public partial class Tag {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "Ta";

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class AiCallTranscription {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "ACT";

        /// <summary> Prefix + IdCall </summary>
        public static BuiltId BuildId(string idCall) => new($"{DocumentPrefix}.{idCall}");
    }
    public partial class CallOutgoingToPowerDialer {
        /// <summary> Id prefix </summary>
        public new const string DocumentPrefix = "COTPD";

        /// <summary> Custom: prefix.instance.channel-uid. Example COTE.PBXUS1.1232123.2 </summary>
        public new static BuiltId BuildId(RunningApplicationInstance instance,  string channelUid) => new($"{DocumentPrefix}.{instance.Id}.{channelUid}");
    }
}



namespace Ublux.Communications.Models.SubDocuments {

    public partial class FaxOutgoing {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "FO";

        /// <summary> Custom: prefix.faxNumber.parentFaxGroup. Example FO.0.FOG.100 </summary>
        public static BuiltId BuildId(int faxNumber, FaxOutgoingGroup parent) => new($"{DocumentPrefix}.{faxNumber}.{parent.Id}");
    }
    public partial class Recording {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "Re";

        /// <summary> Custom: prefix.instance.channel-uid. Example COTE.PBXUS1.1232123.2 </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance,  string channelUid) => new($"{DocumentPrefix}.{instance.Id}.{channelUid}");
    }
    public partial class StoredFile {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "SF";

        /// <summary> Example: SF | IdAcc | IdDocument | end. Example: SF.Ac.1.COTPSTN.PBX-US-1.1677268873.0-mix.wav</summary>
        public static BuiltId BuildId(string idAcc, string idDocument, string end) => new($"{DocumentPrefix}.{idAcc}.{idDocument}.{end}");
    }
}


#endif
