using System.Collections.Concurrent;

namespace Ublux.Communications.Models;

/// <summary>
///     Extension methods for collections
/// </summary>
public static class ModelsExtensionMethods
{
    /// <summary>
    ///     Convert the first letter to lowercase
    /// </summary>
    public static string? FirstCharToLowerCase(this string? str)
    {
        if (!string.IsNullOrEmpty(str) && char.IsUpper(str[0]))
            return str.Length == 1 ? char.ToLower(str[0]).ToString() : char.ToLower(str[0]) + str[1..];

        return str;
    }

    /// <summary>
    ///     helper function that reverses a string
    /// </summary>
    public static string ReverseString(this string s)
    {
        var charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

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
            //Collections.FaxEmailInfos => typeof(FaxEmailInfo),
            Collections.FaxesIncoming => typeof(FaxIncoming),
            Collections.FaxOutgoingGroups => typeof(FaxOutgoingGroup),
            Collections.Voicemails => typeof(Voicemail),
            Collections.Users => typeof(User),
            // Collections.IPs => typeof(IP),
            Collections.SpeedDialGroups => typeof(SpeedDialGroup),
            Collections.LogApiRequests => typeof(LogApiRequest),
            Collections.MusicOnHoldGroups => typeof(MusicOnHoldGroup),
            Collections.Phones => typeof(Phone),
            Collections.PhoneConfigurations => typeof(PhoneConfiguration),
            Collections.PowerDialerGroups => typeof(PowerDialerGroup),
            Collections.PowerDialerContacts => typeof(PowerDialerContact),
            Collections.SMS => typeof(SMS),
            //Collections.TrunkOriginations => typeof(TrunkOrigination),
            Collections.TrunkTerminations => typeof(TrunkTermination),
            Collections.TrunkTerminationGroups => typeof(TrunkTerminationGroup),
            Collections.VoipNumbers => typeof(VoipNumber),
            Collections.VoipProviders => typeof(VoipProvider),
            Collections.WebHooks => typeof(WebHook),
            //Collections.UnauthorizedTokens => typeof(UnauthorizedToken),
            Collections.StoredFileReferences => typeof(StoredFileReference),
            Collections.Tags => typeof(Tag),
            Collections.ApiKeys => typeof(ApiKey),
            Collections.AiCallTranscriptions => typeof(AiCallTranscription),
            Collections.Emails => typeof(Email),
            Collections.AiCallAnalysisInputs => typeof(AiCallAnalysisInput),
            _ => throw new Exception($"Missing collection type: {collection}"),// should never hit this point because this is tested in SouceCode Unit tests
        };
    }

    // used for faster results
    private static readonly ConcurrentDictionary<Type, Collections> _getCollectionUsedByTypeCache = new();

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
        //if (typeof(FaxEmailInfo).IsAssignableFrom(type))
        //{
        //    // store on cache so next time it is faster
        //    _getCollectionUsedByTypeCache[type] = Collections.FaxEmailInfos;
        //    return Collections.FaxEmailInfos;
        //}
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
        if (typeof(SpeedDialGroup).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.SpeedDialGroups;
            return Collections.SpeedDialGroups;
        }
        if (typeof(LogApiRequest).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.LogApiRequests;
            return Collections.LogApiRequests;
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
        if (typeof(PowerDialerContact).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.PowerDialerContacts;
            return Collections.PowerDialerContacts;
        }
        if (typeof(SMS).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.SMS;
            return Collections.SMS;
        }
        //if (typeof(TrunkOrigination).IsAssignableFrom(type))
        //{
        //    // store on cache so next time it is faster
        //    _getCollectionUsedByTypeCache[type] = Collections.TrunkOriginations;
        //    return Collections.TrunkOriginations;
        //}
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
        //if (typeof(UnauthorizedToken).IsAssignableFrom(type))
        //{
        //    // store on cache so next time it is faster
        //    _getCollectionUsedByTypeCache[type] = Collections.UnauthorizedTokens;
        //    return Collections.UnauthorizedTokens;
        //}
        if (typeof(StoredFileReference).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.StoredFileReferences;
            return Collections.StoredFileReferences;
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
        if (typeof(Email).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.Emails;
            return Collections.Emails;
        }
        if (typeof(AiCallAnalysisInput).IsAssignableFrom(type))
        {
            // store on cache so next time it is faster
            _getCollectionUsedByTypeCache[type] = Collections.AiCallAnalysisInputs;
            return Collections.AiCallAnalysisInputs;
        }
        throw new Exception("Invalid Type");
    }

    /// <summary>
    ///     For example if we pass the id Ph.90 this will know it uses the Phones collection because of the prefix
    /// </summary>
    public static Collections GetCollectionUsedById(this ReadOnlySpan<char> id)
    {
        int dotIndex = id.IndexOf(RedisConstants.DelimiterId);
        if (dotIndex < 0)
        {
            if (Debugger.IsAttached) Debugger.Break();
            throw new Exception("Invalid ID" + "326E-9A79");
        }

        var str = id[..dotIndex].ToString();
        // var str = Microsoft.Toolkit.HighPerformance.Buffers.StringPool.Shared.GetOrAdd(id[..dotIndex]);
        if (_collectionMap.TryGetValue(str, out var v) == false)
        {
            if (Debugger.IsAttached) Debugger.Break();
            throw new Exception("Ensure CollectionMap dictionary contains all mappings. " + "C5AB-4D32");
        }
        return v;
    }
    private static readonly Dictionary<string, Collections> _collectionMap = new()
    {
        { Account.DocumentPrefix, Collections.Accounts },
        { AgreementToTermsAndConditions.DocumentPrefix, Collections.AgreementsToTermsAndConditions },
        { AirNetworksProvince.DocumentPrefix, Collections.AirNetworksProvinces },
        { Audio.DocumentPrefix, Collections.Audios },
        { AutoProvisionReference.DocumentPrefix, Collections.AutoProvisionReferences },
        { BlackListPhoneNumber.DocumentPrefix, Collections.BlackListPhoneNumbers },
        { CallIncomingToCallFlowLogic.DocumentPrefix, Collections.Calls },
        { CallIncomingToExtension.DocumentPrefix, Collections.Calls },
        { CallOutgoingToExtension.DocumentPrefix, Collections.Calls },
        { CallOutgoingToPSTN.DocumentPrefix, Collections.Calls },
        { CallOutgoingToPowerDialer.DocumentPrefix, Collections.Calls },
        { CallerIdMask.DocumentPrefix, Collections.CallerIdMasks },
        { CallFlowLogic.DocumentPrefix, Collections.CallFlowLogics },
        { CloudServicePbx.DocumentPrefix, Collections.CloudServices },
        { CloudServiceWebApp.DocumentPrefix, Collections.CloudServices },
        { CloudServiceWebHost.DocumentPrefix, Collections.CloudServices },
        { CloudServiceTranscription.DocumentPrefix, Collections.CloudServices },
        { Contact.DocumentPrefix, Collections.Contacts },
        { CustomerInfo.DocumentPrefix, Collections.CustomerInfos },
        { ExtensionDial.DocumentPrefix, Collections.Extensions },
        { ExtensionQueue.DocumentPrefix, Collections.Extensions },
        { ExtensionVoicemail.DocumentPrefix, Collections.Extensions },
        { ExtensionCallFlowLogic.DocumentPrefix, Collections.Extensions },
        { ExtensionConference.DocumentPrefix, Collections.Extensions },
        { FaxIncoming.DocumentPrefix, Collections.FaxesIncoming },
        { FaxOutgoingGroup.DocumentPrefix, Collections.FaxOutgoingGroups },
        { VoicemailForwarded.DocumentPrefix, Collections.Voicemails },
        { Voicemail.DocumentPrefix, Collections.Voicemails },
        { User.DocumentPrefix, Collections.Users },
        { SpeedDialGroup.DocumentPrefix, Collections.SpeedDialGroups },
        { LogApiRequest.DocumentPrefix, Collections.LogApiRequests },
        { MusicOnHoldGroup.DocumentPrefix, Collections.MusicOnHoldGroups },
        { Phone.DocumentPrefix, Collections.Phones },
        { PhoneConfiguration.DocumentPrefix, Collections.PhoneConfigurations },
        { PowerDialerGroup.DocumentPrefix, Collections.PowerDialerGroups },
        { PowerDialerContact.DocumentPrefix, Collections.PowerDialerContacts },
        { SMS.DocumentPrefix, Collections.SMS },
        //{ TrunkOriginationForward.DocumentPrefix, Collections.TrunkOriginations },
        { TrunkTerminationGroup.DocumentPrefix, Collections.TrunkTerminationGroups },
        { TrunkTermination.DocumentPrefix, Collections.TrunkTerminations },
        { VoipNumberPhone.DocumentPrefix, Collections.VoipNumbers },
        { VoipNumberFax.DocumentPrefix, Collections.VoipNumbers },
        { VoipNumberAvailableForPurchase.DocumentPrefix, Collections.VoipNumbers },
        { VoipProvider.DocumentPrefix, Collections.VoipProviders },
        { WebHook.DocumentPrefix, Collections.WebHooks },
        { StoredFileReference.DocumentPrefix, Collections.StoredFileReferences },
        { Tag.DocumentPrefix, Collections.Tags },
        { ApiKey.DocumentPrefix, Collections.ApiKeys },
        { AiCallTranscription.DocumentPrefix, Collections.AiCallTranscriptions },
        { Email.DocumentPrefix, Collections.Emails },
        { AiCallAnalysisInput.DocumentPrefix, Collections.AiCallAnalysisInputs }
    };

    /// <summary>
    ///     Collections used on pbx. for example collection ApiKey is not used on PBX
    /// </summary>
    private static readonly HashSet<Collections> collectionsUsedByPBX =
    [
        Collections.Accounts,
        // Collections.AgreementsToTermsAndConditions,
        // Collections.AirNetworksProvinces,
        Collections.Audios,
        // Collections.AutoProvisionReferences,
        Collections.BlackListPhoneNumbers,
        // Collections.Calls,
        // Collections.CallerIdMasks,
        Collections.CallFlowLogics,
        Collections.CloudServices,
        Collections.Contacts,
        // Collections.CustomerInfos,
        Collections.Extensions,
        // Collections.FaxesIncoming,
        // Collections.FaxOutgoingGroups,
        // Collections.Voicemails,
        // Collections.Users,
        //Collections.SpeedDialGroups,
        // Collections.LogApiRequests,
        Collections.MusicOnHoldGroups,
        Collections.Phones,
        //Collections.PhoneConfigurations,
        // Collections.PowerDialerGroups,
        // Collections.PowerDialerContacts,
        // Collections.SMS,
        //Collections.TrunkOriginations,
        Collections.TrunkTerminations,
        Collections.TrunkTerminationGroups,
        Collections.VoipNumbers,
        // Collections.VoipProviders,
        Collections.WebHooks,
        // Collections.StoredFileReferences,
        // Collections.Tags,
        // Collections.ApiKeys,
        // Collections.AiCallTranscriptions,
        Collections.Emails
    ];
    
    /// <summary>
    ///     Collections used on pbx. for example collection ApiKey is not used on PBX
    /// </summary>
    private static readonly HashSet<Collections> collectionsUsedByWa =
    [
        Collections.Accounts,
        // Collections.AgreementsToTermsAndConditions,
        // Collections.AirNetworksProvinces,
        Collections.Audios,
        // Collections.AutoProvisionReferences,
        Collections.BlackListPhoneNumbers,
        Collections.Calls,
        Collections.CallerIdMasks,
        Collections.CallFlowLogics,
        Collections.CloudServices,
        Collections.Contacts,
        Collections.CustomerInfos,
        Collections.Extensions,
        Collections.FaxesIncoming,
        Collections.FaxOutgoingGroups,
        Collections.Voicemails,
        Collections.Users,
        Collections.SpeedDialGroups,
        // Collections.LogApiRequests,
        Collections.MusicOnHoldGroups,
        Collections.Phones,
        Collections.PhoneConfigurations,
        Collections.PowerDialerGroups,
        Collections.PowerDialerContacts,
        Collections.SMS,
        //Collections.TrunkOriginations,
        //Collections.TrunkTerminations,
        //Collections.TrunkTerminationGroups,
        Collections.VoipNumbers,
        // Collections.VoipProviders,
        Collections.WebHooks,
        // Collections.StoredFileReferences,
        Collections.Tags,
        Collections.ApiKeys,
        Collections.AiCallTranscriptions,
        Collections.Emails,        
    ];

    /// <summary>
    ///     Is collection used by pbx
    /// </summary>
    public static bool IsCollectionUsedByPBX(this Collections collection)
    {
        return collectionsUsedByPBX.Contains(collection);
    }

    /// <summary>
    ///     Is collection used by web app
    /// </summary>
    public static bool IsCollectionUsedByWebApp(this Collections collection)
    {
        return collectionsUsedByWa.Contains(collection);
    }
    
    #region GetExtensionsUsedByPhone ordered by priority

    
    

    /// <summary>
    ///     Is an extension used by a phone
    /// </summary>
    /// <param name="e"></param>
    /// <param name="idPhone"></param>
    /// <returns></returns>
    public static bool IsExtensionUsedByPhone(Extension? e, string idPhone)
    {
        if (e is null)
        {
            return false;
        }

        // this has to go before
        if (e is ExtensionQueue queue)
        {
            return queue.IdsPhones.Contains(idPhone);
        }
        
        if (e is ExtensionDial dial)
        {
            return dial.IdsPhones.Contains(idPhone);
        }
        
        if (e is ExtensionVoicemail vm)
        {
            return vm.IdsPhonesThatCanListenToVoicemail.Contains(idPhone);
        }
        
        return false;
    }

    #endregion
}
