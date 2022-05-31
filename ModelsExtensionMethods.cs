namespace Ublux.Communications.Models;

/// <summary>
///     Extension methods for collections
/// </summary>
public static class ModelsExtensionMethods
{
    /// <summary>
    ///     Get type of model used by collection
    /// </summary>
    public static Type GetTypeUsedByCollection(this Collections collection)
    {
        switch (collection)
        {
            case Collections.Accounts: return typeof(Account);
            case Collections.AgreementsToTermsAndConditions: return typeof(AgreementToTermsAndConditions);
            case Collections.AirNetworksProvinces: return typeof(AirNetworksProvince);
            case Collections.Audios: return typeof(Audio);
            case Collections.AutoProvisionReferences: return typeof(AutoProvisionReference);
            case Collections.BlackListPhoneNumbers: return typeof(BlackListPhoneNumber);
            case Collections.Calls: return typeof(Call);
            case Collections.CallerIdMasks: return typeof(CallerIdMask);
            case Collections.CallFlows: return typeof(CallFlow);
            case Collections.CloudServices: return typeof(CloudService);
            case Collections.Contacts: return typeof(Contact);
            case Collections.CustomerInfos: return typeof(CustomerInfo);
            case Collections.Extensions: return typeof(Extension);
            case Collections.FaxEmailInfos: return typeof(FaxEmailInfo);
            case Collections.FaxesIncoming: return typeof(FaxIncoming);
            case Collections.FaxOutgoingGroups: return typeof(FaxOutgoingGroup);
            case Collections.Voicemails: return typeof(Voicemail);
            case Collections.Identities: return typeof(Identity);
            case Collections.IPs: return typeof(IP);
            case Collections.LineKeyGroups: return typeof(LineKeyGroup);
            case Collections.LogWebServiceRequests: return typeof(LogWebServiceRequest);
            case Collections.MusicOnHoldGroups: return typeof(MusicOnHoldGroup);
            case Collections.Phones: return typeof(Phone);
            case Collections.PhoneConfigurations: return typeof(PhoneConfiguration);
            case Collections.PowerDialerGroups: return typeof(PowerDialerGroup);
            case Collections.SMS: return typeof(SMS);
            case Collections.TrunkOriginations: return typeof(TrunkOrigination);
            case Collections.TrunkTerminations: return typeof(TrunkTermination);
            case Collections.TrunkTerminationGroups: return typeof(TrunkTerminationGroup);
            case Collections.VoipNumbers: return typeof(VoipNumber);
            case Collections.VoipProviders: return typeof(VoipProvider);
            case Collections.WebHooks: return typeof(WebHook);
            case Collections.UnauthorizedTokens: return typeof(UnauthorizedToken);
            default:
                // should never hit this point because this is tested in SouceCode Unit tests
                throw new Exception("Missing collection type");
        }
    }
}
