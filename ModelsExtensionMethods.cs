using System.Collections.Concurrent;

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
            Collections.Users => typeof(User),
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
            Collections.ApiKeys => typeof(ApiKey),
            Collections.AiCallTranscriptions => typeof(AiCallTranscription),
            _ => throw new Exception($"Missing collection type: {collection}"),// should never hit this point because this is tested in SouceCode Unit tests
        };
    }

    // used for faster results
    private static ConcurrentDictionary<Type, Collections> _getCollectionUsedByTypeCache = new();

    /// <summary>
    ///     For example if the type is Phone it will return Phones collection
    ///     If the type is CloudServicePbx it will return the collection CloudServices
    /// </summary>
    public static Collections GetCollectionUsedByType(this Type type)
    {
        // if its on cache
        if (_getCollectionUsedByTypeCache.TryGetValue(type, out var c))
            return c;

        if (typeof(Account).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.Accounts;
            return Collections.Accounts;
        }
        if (typeof(AgreementToTermsAndConditions).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.AgreementsToTermsAndConditions;
            return Collections.AgreementsToTermsAndConditions;
        }
        if (typeof(AirNetworksProvince).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.AirNetworksProvinces;
            return Collections.AirNetworksProvinces;
        }
        if (typeof(Audio).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.Audios;
            return Collections.Audios;
        }
        if (typeof(AutoProvisionReference).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.AutoProvisionReferences;
            return Collections.AutoProvisionReferences;
        }
        if (typeof(BlackListPhoneNumber).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.BlackListPhoneNumbers;
            return Collections.BlackListPhoneNumbers;
        }
        if (typeof(Call).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.Calls;
            return Collections.Calls;
        }
        if (typeof(CallerIdMask).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.CallerIdMasks;
            return Collections.CallerIdMasks;
        }
        if (typeof(CallFlowLogic).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.CallFlowLogics;
            return Collections.CallFlowLogics;
        }
        if (typeof(CloudService).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.CloudServices;
            return Collections.CloudServices;
        }
        if (typeof(Contact).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.Contacts;
            return Collections.Contacts;
        }
        if (typeof(CustomerInfo).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.CustomerInfos;
            return Collections.CustomerInfos;
        }
        if (typeof(Extension).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.Extensions;
            return Collections.Extensions;
        }
        if (typeof(FaxEmailInfo).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.FaxEmailInfos;
            return Collections.FaxEmailInfos;
        }
        if (typeof(FaxIncoming).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.FaxesIncoming;
            return Collections.FaxesIncoming;
        }
        if (typeof(FaxOutgoingGroup).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.FaxOutgoingGroups;
            return Collections.FaxOutgoingGroups;
        }
        if (typeof(Voicemail).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.Voicemails;
            return Collections.Voicemails;
        }
        if (typeof(User).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.Users;
            return Collections.Users;
        }
        if (typeof(LineKeyGroup).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.LineKeyGroups;
            return Collections.LineKeyGroups;
        }
        if (typeof(LogWebServiceRequest).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.LogWebServiceRequests;
            return Collections.LogWebServiceRequests;
        }
        if (typeof(MusicOnHoldGroup).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.MusicOnHoldGroups;
            return Collections.MusicOnHoldGroups;
        }
        if (typeof(Phone).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.Phones;
            return Collections.Phones;
        }
        if (typeof(PhoneConfiguration).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.PhoneConfigurations;
            return Collections.PhoneConfigurations;
        }
        if (typeof(PowerDialerGroup).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.PowerDialerGroups;
            return Collections.PowerDialerGroups;
        }
        if (typeof(SMS).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.SMS;
            return Collections.SMS;
        }
        if (typeof(TrunkOrigination).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.TrunkOriginations;
            return Collections.TrunkOriginations;
        }
        if (typeof(TrunkTermination).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.TrunkTerminations;
            return Collections.TrunkTerminations;
        }
        if (typeof(TrunkTerminationGroup).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.TrunkTerminationGroups;
            return Collections.TrunkTerminationGroups;
        }
        if (typeof(VoipNumber).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.VoipNumbers;
            return Collections.VoipNumbers;
        }
        if (typeof(VoipProvider).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.VoipProviders;
            return Collections.VoipProviders;
        }
        if (typeof(WebHook).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.WebHooks;
            return Collections.WebHooks;
        }
        if (typeof(UnauthorizedToken).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.UnauthorizedTokens;
            return Collections.UnauthorizedTokens;
        }
        if (typeof(CloudFile).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.CloudFiles;
            return Collections.CloudFiles;
        }
        if (typeof(Tag).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.Tags;
            return Collections.Tags;
        }
        if (typeof(ApiKey).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.ApiKeys;
            return Collections.ApiKeys;
        }
        if (typeof(AiCallTranscription).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.AiCallTranscriptions;
            return Collections.AiCallTranscriptions;
        }
        throw new Exception("Invalid Type");
    }
}
