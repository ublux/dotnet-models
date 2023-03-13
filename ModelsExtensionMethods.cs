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
            //Collections.FaxEmailInfos => typeof(FaxEmailInfo),
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
            //Collections.UnauthorizedTokens => typeof(UnauthorizedToken),
            Collections.StoredFileReferences => typeof(StoredFileReference),
            Collections.Tags => typeof(Tag),
            Collections.ApiKeys => typeof(ApiKey),
            Collections.AiCallTranscriptions => typeof(AiCallTranscription),
            Collections.Emails => typeof(Email),
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
        throw new Exception("Invalid Type");
    }

    /// <summary>
    ///     For example if we pass the id Ph.90 this will know it uses the Phones collection because of the prefix
    /// </summary>
    public static Collections GetCollectionUsedById(this ReadOnlySpan<char> id)
    {
        int dotIndex = id.IndexOf(RedisConstants.DelimeterId);
        if (dotIndex < 0)
        {
            if (Debugger.IsAttached) Debugger.Break();
            throw new Exception("Invalid ID" + "[_Guid_]");
        }

        var str = id[..dotIndex].ToString();
        // var str = Microsoft.Toolkit.HighPerformance.Buffers.StringPool.Shared.GetOrAdd(id[..dotIndex]);
        if (_collectionMap.TryGetValue(str, out var v) == false)
        {
            if (Debugger.IsAttached) Debugger.Break();
            throw new Exception("Ensure CollectionMap dictionary contains all mappings. " + "[_Guid_]");
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
        { CallerIdMask.DocumentPrefix, Collections.CallerIdMasks },
        { CallFlowLogic.DocumentPrefix, Collections.CallFlowLogics },
        { CloudServicePbx.DocumentPrefix, Collections.CloudServices },
        { CloudServiceWebApp.DocumentPrefix, Collections.CloudServices },
        { CloudServiceWebHost.DocumentPrefix, Collections.CloudServices },
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
        { LineKeyGroup.DocumentPrefix, Collections.LineKeyGroups },
        { LogWebServiceRequest.DocumentPrefix, Collections.LogWebServiceRequests },
        { MusicOnHoldGroup.DocumentPrefix, Collections.MusicOnHoldGroups },
        { Phone.DocumentPrefix, Collections.Phones },
        { PhoneConfiguration.DocumentPrefix, Collections.PhoneConfigurations },
        { PowerDialerGroup.DocumentPrefix, Collections.PowerDialerGroups },
        { SMS.DocumentPrefix, Collections.SMS },
        { TrunkOriginationForward.DocumentPrefix, Collections.TrunkOriginations },
        { TrunkOriginationRegister.DocumentPrefix, Collections.TrunkOriginations },
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
        { Email.DocumentPrefix, Collections.Emails }
    };

    /// <summary>
    ///     Collections used on pbx. for example collection ApiKey is not used on PBX
    /// </summary>
    private static readonly HashSet<Collections> collectionsUsedByPBX = new()
    {
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
                //Collections.LineKeyGroups,
                // Collections.LogWebServiceRequests,
                Collections.MusicOnHoldGroups,
                Collections.Phones,
                //Collections.PhoneConfigurations,
                // Collections.PowerDialerGroups,
                // Collections.SMS,
                Collections.TrunkOriginations,
                Collections.TrunkTerminations,
                Collections.TrunkTerminationGroups,
                Collections.VoipNumbers,
                // Collections.VoipProviders,
                Collections.WebHooks,
                // Collections.StoredFileReferences,
                // Collections.Tags,
                // Collections.ApiKeys,
                // Collections.AiCallTranscriptions,
                Collections.Emails,
    };

    /// <summary>
    ///     Is collection used by pbx
    /// </summary>
    public static bool IsCollectionUsedByPBX(this Collections collection)
    {
        return collectionsUsedByPBX.Contains(collection);
    }


    #region GetExtensionsUsedByLine ordered by priority

    /// <summary>
    ///     Get extensions used by line ordered by prioroty
    /// </summary>
    public static IEnumerable<Extension> GetExtensionsUsedByLine(this IEnumerable<Extension> extensions, string idLine)
    {
        return extensions
            .Order(new ExtensionPriorityComparer(idLine))
            .TakeWhile(x => IsExtensionUsedByLine(x, idLine, out _));
    }
    private class ExtensionPriorityComparer : IComparer<Extension>
    {
        private readonly string idLine;

        public ExtensionPriorityComparer(string idLine)
        {
            this.idLine = idLine;
        }

        public int Compare(Extension? x, Extension? y)
        {
            // less than 0.     x is less than y
            // 0.     x == y
            // more than 0.     x is greater than y

            var isXUsed = IsExtensionUsedByLine(x, idLine, out var weightX);
            var isYUsed = IsExtensionUsedByLine(y, idLine, out var weightY);

            if (isXUsed == false && isYUsed == false)
                return 0;
            if (isXUsed == true && isYUsed == false)
                return -1;
            if (isXUsed == false && isYUsed == true)
                return 1;

            // at this point we know line is being used by both extensions. so complare the weights
            if (weightX < weightY) return -1;
            if (weightX == weightY) return 0;
            return 1;
        }
    }

    // Weight. The lower the higher the priority
    private static bool IsExtensionUsedByLine(Extension? e, string idLine, out int weight)
    {
        if (e is null)
        {
            weight = 0;
            return false;
        }

        if (e is ExtensionDial dial)
        {
            weight = dial.IdsLines.Count * 2;
            return dial.IdsLines.Contains(idLine);
        }
        if (e is ExtensionQueue queue)
        {
            weight = (queue.IdsLines.Count * 2) + 1;
            return queue.IdsLines.Contains(idLine);
        }
        if (e is ExtensionVoicemail vm)
        {
            weight = (vm.IdsLinesThatCanListenToVoicemail.Count * 2) + 4;
            return vm.IdsLinesThatCanListenToVoicemail.Contains(idLine);
        }
        weight = 0;
        return false;
    }

    #endregion
}
