#if UBLUX_BACKEND 
/* FILE AUTOGENERATED DO NOT MODIFY OR DELETE */ 
/* File contains id generator methods to ensure all ids are generated correctly */ 


namespace Ublux.Communications.Models.Documents {

    public partial class Account {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "Ac";

        /// <summary> Custom: prefix and account number </summary>
        public static BuiltId BuildId(string accountNumber) => new($"{DocumentPrefix}.{uint.Parse(accountNumber)}");
        /// <summary> Custom: overload </summary>
        public static BuiltId BuildId(uint accountNumber) => new($"{DocumentPrefix}.{accountNumber}");
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

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
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
        public const string DocumentPrefix = "CITCF";

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

        /// <summary> Custom: Prefix followed by id. Example: PBX.UST, PBX.US1, WS.1 </summary>
        public static BuiltId BuildId(string instanceId) => new($"{DocumentPrefix}.{instanceId.ToUpper()}");
    }
    public partial class CloudServiceWebApp {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "CSWA";

        /// <summary> Custom: Prefix followed by id. Example: PBX.UST, PBX.US1, WS.1 </summary>
        public static BuiltId BuildId(string instanceId) => new($"{DocumentPrefix}.{instanceId.ToUpper()}");
    }
    public partial class CloudServiceWebHost {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "CSWH";

        /// <summary> Custom: Prefix followed by id. Example: PBX.UST, PBX.US1, WS.1 </summary>
        public static BuiltId BuildId(string instanceId) => new($"{DocumentPrefix}.{instanceId.ToUpper()}");
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
        public const string DocumentPrefix = "ECF";

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
    public partial class ExtensionQueue {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "EQ";

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class ExtensionVoicemail {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "EV";

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class FaxEmailInfo {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "FEI";

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
    public partial class Identity {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "Id";

        /// <summary> Custom: prefix and the amail address. Example Id.antonio@ublux.com, or Id.PBX.UST </summary>
        public static BuiltId BuildId(string emailOrCloudServiceName) => new($"{DocumentPrefix}.{emailOrCloudServiceName}");
    }
    public partial class IP {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "IP";

        /// <summary> Custom: Prefix follwed by ip address. Example IP.1.1.1.1 </summary>
        public static BuiltId BuildId(string ipAddress) => new($"{DocumentPrefix}.{ipAddress}");
    }
    public partial class LineKeyGroup {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "LKG";

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class LogWebServiceRequest {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "LWSR";

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

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
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
    public partial class TrunkOriginationForward {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "TOF";

        /// <summary> Custom: Prefix follwed by trunk name. Example TT.CanalPark.Production.Twilio </summary>
        public static BuiltId BuildId(string trunkName) => new($"{DocumentPrefix}.{trunkName}");
    }
    public partial class TrunkOriginationRegister {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "TOR";

        /// <summary> Custom: Prefix follwed by trunk name. Example TT.CanalPark.Production.Twilio </summary>
        public static BuiltId BuildId(string trunkName) => new($"{DocumentPrefix}.{trunkName}");
    }
    public partial class TrunkTermination {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "TT";

        /// <summary> Custom: Prefix follwed by trunk name. Example TT.CanalPark.Production.Twilio </summary>
        public static BuiltId BuildId(string trunkName) => new($"{DocumentPrefix}.{trunkName}");
    }
    public partial class TrunkTerminationGroup {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "TTG";

        /// <summary> Custom: Prefix follwed by trunk termination group name. Example TTG.CanalPark.Production </summary>
        public static BuiltId BuildId(string groupName) => new($"{DocumentPrefix}.{groupName}");
    }
    public partial class UnauthorizedToken {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "UT";

        /// <summary> Custom: prefix and last 16 characters of JWT </summary>
        public static BuiltId BuildId(string jwt) => new($"{DocumentPrefix}.{jwt[^16..]}");
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
        public static BuiltId BuildId(string phoneNumber) => new($"{DocumentPrefix}.{new String(phoneNumber.Where(Char.IsDigit).ToArray())[^8..]}");
    }
    public partial class VoipNumberPhone {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "VNP";

        /// <summary> Custom: id of account only </summary>
        public static BuiltId BuildId(string phoneNumber) => new($"{DocumentPrefix}.{new String(phoneNumber.Where(Char.IsDigit).ToArray())[^8..]}");
    }
    public partial class VoipProvider {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "VP";

        /// <summary> Custom: Prefix follwed by provider name </summary>
        public static BuiltId BuildId(string providerName) => new($"{DocumentPrefix}.{providerName}");
    }
    public partial class WebHook {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "WH";

        /// <summary> Build Id </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance) => new($"{DocumentPrefix}.{instance.Id}.{instance.IdGlobalAutoIncrement()}");
    }
    public partial class CloudFile {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "CF";

        /// <summary> Prefix followed by stored file id Example DF.SF.1232 </summary>
        public static BuiltId BuildId(StoredFile storedFile) => new($"{DocumentPrefix}.{storedFile.Id}");
        /// <summary> Overload </summary>
        public static BuiltId BuildId(string storedFileId) => new($"{DocumentPrefix}.{storedFileId}");
    }
}



namespace Ublux.Communications.Models.SubDocuments {

    public partial class FaxOutgoing {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "FO";

        /// <summary> Custom: prefix.faxNumber.parentFaxGroup. Example FO.0.FOG.100 </summary>
        public static BuiltId BuildId(int faxNumber, FaxOutgoingGroup parent) => new($"{DocumentPrefix}.{faxNumber}.{parent.Id}");
    }
    public partial class Line {
        /// <summary> Id prefix </summary>
        public const string DocumentPrefix = "Li";

        /// <summary> Custom: prefix.lineNumber.parentPhoneId. Example Li.1.Po.100 </summary>
        public static BuiltId BuildId(RunningApplicationInstance instance, Phone parent) => new($"{DocumentPrefix}.{instance.IdGlobalAutoIncrement()}.{parent.Id}");
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

        /// <summary> Example SF.Ac.1/Audios/JFKEYIERJKHDKJHDSF.wav </summary>
        public static BuiltId BuildId(string idAcc, StorageFolderName folderName, string fileExtension) => new($"{DocumentPrefix}.{idAcc}/{folderName}/{RunningApplicationInstance.ToBase62(BitConverter.ToUInt64(Guid.NewGuid().ToByteArray()))}{RunningApplicationInstance.ToBase62(BitConverter.ToUInt64(Guid.NewGuid().ToByteArray())/2)}.{fileExtension.ToLower()}");
        
        /// <summary> oveload </summary>
        public static BuiltId BuildId(string idAcc, StorageFolderName folderName) => new($"{DocumentPrefix}.{idAcc}/{folderName}/{RunningApplicationInstance.ToBase62(BitConverter.ToUInt64(Guid.NewGuid().ToByteArray()))}{RunningApplicationInstance.ToBase62(BitConverter.ToUInt64(Guid.NewGuid().ToByteArray())/2)}");
        /// <summary> oveload </summary>
        public static BuiltId BuildId(BuiltId builtId, string fileExtension) => new($"{builtId.Id}.{fileExtension}");
    }
}


#endif
