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
        return collection switch
        {
            Collections.Accounts => typeof(Account),
            Collections.AgreementsToTermsAndConditions => typeof(AgreementToTermsAndConditions),
            Collections.AirNetworksProvinces => typeof(AirNetworksProvince),
            Collections.Audios => typeof(Audio),
            Collections.AutoProvisionReferences => typeof(AutoProvisionReference),
            Collections.BlackListPhoneNumbers => typeof(BlackListPhoneNumber),
            Collections.Calls => typeof(Call),
            Collections.CallerIdMasks => typeof(CallerIdMask),
            Collections.CallFlowLogics => typeof(CallFlowLogic),
            Collections.CloudServices => typeof(CloudService),
            Collections.Contacts => typeof(Contact),
            Collections.CustomerInfos => typeof(CustomerInfo),
            Collections.Extensions => typeof(Extension),
            Collections.FaxEmailInfos => typeof(FaxEmailInfo),
            Collections.FaxesIncoming => typeof(FaxIncoming),
            Collections.FaxOutgoingGroups => typeof(FaxOutgoingGroup),
            Collections.Voicemails => typeof(Voicemail),
            Collections.Identities => typeof(Identity),
            // Collections.IPs => typeof(IP),
            Collections.LineKeyGroups => typeof(LineKeyGroup),
            Collections.LogWebServiceRequests => typeof(LogWebServiceRequest),
            Collections.MusicOnHoldGroups => typeof(MusicOnHoldGroup),
            Collections.Phones => typeof(Phone),
            Collections.PhoneConfigurations => typeof(PhoneConfiguration),
            Collections.PowerDialerGroups => typeof(PowerDialerGroup),
            Collections.SMS => typeof(SMS),
            Collections.TrunkOriginations => typeof(TrunkOrigination),
            Collections.TrunkTerminations => typeof(TrunkTermination),
            Collections.TrunkTerminationGroups => typeof(TrunkTerminationGroup),
            Collections.VoipNumbers => typeof(VoipNumber),
            Collections.VoipProviders => typeof(VoipProvider),
            Collections.WebHooks => typeof(WebHook),
            Collections.UnauthorizedTokens => typeof(UnauthorizedToken),
            Collections.CloudFiles => typeof(CloudFile),
            Collections.Tags => typeof(Tag),
            _ => throw new Exception($"Missing collection type: {collection}"),// should never hit this point because this is tested in SouceCode Unit tests
        };
    }
}
