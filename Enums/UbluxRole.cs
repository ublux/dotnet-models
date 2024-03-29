﻿namespace Ublux.Communications.Enums;

// If value ends in 0 it means it has CRUD
// if value ends in 1 it means it is readonly
// if value ends in 2 it means it can update/read
// if value ends in 3 it means it can delete/read
// if value ends in 4 it means it can create/read

/// <summary>
///     A ublux user has this roles. They are sorted in order of priority
/// </summary>
public enum UbluxRole
{
    /// <summary> Default with no role </summary>
    none = 0,

    #region Low priority (auto generated at Generator_UserControllers.cs last line)

    /// <summary> Has access to the audios endpoint with full permissions </summary>
    audios = 10,
    /// <summary> Has access to the audios endpoint with only read permissions </summary>
    audios_readonly,
    /// <summary> Has access to the audios endpoint with only read/update permissions </summary>
    audios_update,
    /// <summary> Has access to the audios endpoint with only read/delete permissions </summary>
    audios_delete,
    /// <summary> Has access to the audios endpoint with only read/create permissions </summary>
    audios_create,

    /// <summary> Has access to the blacklistphonenumbers endpoint with full permissions </summary>
    blacklistphonenumbers = 20,
    /// <summary> Has access to the blacklistphonenumbers endpoint with only read permissions </summary>
    blacklistphonenumbers_readonly,
    /// <summary> Has access to the blacklistphonenumbers endpoint with only read/update permissions </summary>
    blacklistphonenumbers_update,
    /// <summary> Has access to the blacklistphonenumbers endpoint with only read/delete permissions </summary>
    blacklistphonenumbers_delete,
    /// <summary> Has access to the blacklistphonenumbers endpoint with only read/create permissions </summary>
    blacklistphonenumbers_create,

    /// <summary> Has access to the calls endpoint with full permissions </summary>
    calls = 30,
    /// <summary> Has access to the calls endpoint with only read permissions </summary>
    calls_readonly,
    /// <summary> Has access to the calls endpoint with only read/update permissions </summary>
    calls_update,
    /// <summary> Has access to the calls endpoint with only read/delete permissions </summary>
    calls_delete,
    /// <summary> Has access to the calls endpoint with only read/create permissions </summary>
    calls_create,

    /// <summary> Has access to the calleridmasks endpoint with full permissions </summary>
    calleridmasks = 40,
    /// <summary> Has access to the calleridmasks endpoint with only read permissions </summary>
    calleridmasks_readonly,
    /// <summary> Has access to the calleridmasks endpoint with only read/update permissions </summary>
    calleridmasks_update,
    /// <summary> Has access to the calleridmasks endpoint with only read/delete permissions </summary>
    calleridmasks_delete,
    /// <summary> Has access to the calleridmasks endpoint with only read/create permissions </summary>
    calleridmasks_create,

    /// <summary> Has access to the callflowlogics endpoint with full permissions </summary>
    callflowlogics = 50,
    /// <summary> Has access to the callflowlogics endpoint with only read permissions </summary>
    callflowlogics_readonly,
    /// <summary> Has access to the callflowlogics endpoint with only read/update permissions </summary>
    callflowlogics_update,
    /// <summary> Has access to the callflowlogics endpoint with only read/delete permissions </summary>
    callflowlogics_delete,
    /// <summary> Has access to the callflowlogics endpoint with only read/create permissions </summary>
    callflowlogics_create,

    /// <summary> Has access to the callincomings endpoint with full permissions </summary>
    callincomings = 60,
    /// <summary> Has access to the callincomings endpoint with only read permissions </summary>
    callincomings_readonly,
    /// <summary> Has access to the callincomings endpoint with only read/update permissions </summary>
    callincomings_update,
    /// <summary> Has access to the callincomings endpoint with only read/delete permissions </summary>
    callincomings_delete,
    /// <summary> Has access to the callincomings endpoint with only read/create permissions </summary>
    callincomings_create,

    /// <summary> Has access to the callincomingtocallflowlogics endpoint with full permissions </summary>
    callincomingtocallflowlogics = 70,
    /// <summary> Has access to the callincomingtocallflowlogics endpoint with only read permissions </summary>
    callincomingtocallflowlogics_readonly,
    /// <summary> Has access to the callincomingtocallflowlogics endpoint with only read/update permissions </summary>
    callincomingtocallflowlogics_update,
    /// <summary> Has access to the callincomingtocallflowlogics endpoint with only read/delete permissions </summary>
    callincomingtocallflowlogics_delete,
    /// <summary> Has access to the callincomingtocallflowlogics endpoint with only read/create permissions </summary>
    callincomingtocallflowlogics_create,

    /// <summary> Has access to the callincomingtoextensions endpoint with full permissions </summary>
    callincomingtoextensions = 80,
    /// <summary> Has access to the callincomingtoextensions endpoint with only read permissions </summary>
    callincomingtoextensions_readonly,
    /// <summary> Has access to the callincomingtoextensions endpoint with only read/update permissions </summary>
    callincomingtoextensions_update,
    /// <summary> Has access to the callincomingtoextensions endpoint with only read/delete permissions </summary>
    callincomingtoextensions_delete,
    /// <summary> Has access to the callincomingtoextensions endpoint with only read/create permissions </summary>
    callincomingtoextensions_create,

    /// <summary> Has access to the calloutgoings endpoint with full permissions </summary>
    calloutgoings = 90,
    /// <summary> Has access to the calloutgoings endpoint with only read permissions </summary>
    calloutgoings_readonly,
    /// <summary> Has access to the calloutgoings endpoint with only read/update permissions </summary>
    calloutgoings_update,
    /// <summary> Has access to the calloutgoings endpoint with only read/delete permissions </summary>
    calloutgoings_delete,
    /// <summary> Has access to the calloutgoings endpoint with only read/create permissions </summary>
    calloutgoings_create,

    /// <summary> Has access to the calloutgoingtoextensions endpoint with full permissions </summary>
    calloutgoingtoextensions = 100,
    /// <summary> Has access to the calloutgoingtoextensions endpoint with only read permissions </summary>
    calloutgoingtoextensions_readonly,
    /// <summary> Has access to the calloutgoingtoextensions endpoint with only read/update permissions </summary>
    calloutgoingtoextensions_update,
    /// <summary> Has access to the calloutgoingtoextensions endpoint with only read/delete permissions </summary>
    calloutgoingtoextensions_delete,
    /// <summary> Has access to the calloutgoingtoextensions endpoint with only read/create permissions </summary>
    calloutgoingtoextensions_create,

    /// <summary> Has access to the calloutgoingtopstns endpoint with full permissions </summary>
    calloutgoingtopstns = 110,
    /// <summary> Has access to the calloutgoingtopstns endpoint with only read permissions </summary>
    calloutgoingtopstns_readonly,
    /// <summary> Has access to the calloutgoingtopstns endpoint with only read/update permissions </summary>
    calloutgoingtopstns_update,
    /// <summary> Has access to the calloutgoingtopstns endpoint with only read/delete permissions </summary>
    calloutgoingtopstns_delete,
    /// <summary> Has access to the calloutgoingtopstns endpoint with only read/create permissions </summary>
    calloutgoingtopstns_create,

    /// <summary> Has access to the contacts endpoint with full permissions </summary>
    contacts = 120,
    /// <summary> Has access to the contacts endpoint with only read permissions </summary>
    contacts_readonly,
    /// <summary> Has access to the contacts endpoint with only read/update permissions </summary>
    contacts_update,
    /// <summary> Has access to the contacts endpoint with only read/delete permissions </summary>
    contacts_delete,
    /// <summary> Has access to the contacts endpoint with only read/create permissions </summary>
    contacts_create,

    /// <summary> Has access to the customerinfos endpoint with full permissions </summary>
    customerinfos = 130,
    /// <summary> Has access to the customerinfos endpoint with only read permissions </summary>
    customerinfos_readonly,
    /// <summary> Has access to the customerinfos endpoint with only read/update permissions </summary>
    customerinfos_update,
    /// <summary> Has access to the customerinfos endpoint with only read/delete permissions </summary>
    customerinfos_delete,
    /// <summary> Has access to the customerinfos endpoint with only read/create permissions </summary>
    customerinfos_create,

    /// <summary> Has access to the extensions endpoint with full permissions </summary>
    extensions = 140,
    /// <summary> Has access to the extensions endpoint with only read permissions </summary>
    extensions_readonly,
    /// <summary> Has access to the extensions endpoint with only read/update permissions </summary>
    extensions_update,
    /// <summary> Has access to the extensions endpoint with only read/delete permissions </summary>
    extensions_delete,
    /// <summary> Has access to the extensions endpoint with only read/create permissions </summary>
    extensions_create,

    /// <summary> Has access to the extensioncallflowlogics endpoint with full permissions </summary>
    extensioncallflowlogics = 150,
    /// <summary> Has access to the extensioncallflowlogics endpoint with only read permissions </summary>
    extensioncallflowlogics_readonly,
    /// <summary> Has access to the extensioncallflowlogics endpoint with only read/update permissions </summary>
    extensioncallflowlogics_update,
    /// <summary> Has access to the extensioncallflowlogics endpoint with only read/delete permissions </summary>
    extensioncallflowlogics_delete,
    /// <summary> Has access to the extensioncallflowlogics endpoint with only read/create permissions </summary>
    extensioncallflowlogics_create,

    /// <summary> Has access to the extensionconferences endpoint with full permissions </summary>
    extensionconferences = 160,
    /// <summary> Has access to the extensionconferences endpoint with only read permissions </summary>
    extensionconferences_readonly,
    /// <summary> Has access to the extensionconferences endpoint with only read/update permissions </summary>
    extensionconferences_update,
    /// <summary> Has access to the extensionconferences endpoint with only read/delete permissions </summary>
    extensionconferences_delete,
    /// <summary> Has access to the extensionconferences endpoint with only read/create permissions </summary>
    extensionconferences_create,

    /// <summary> Has access to the extensiondials endpoint with full permissions </summary>
    extensiondials = 170,
    /// <summary> Has access to the extensiondials endpoint with only read permissions </summary>
    extensiondials_readonly,
    /// <summary> Has access to the extensiondials endpoint with only read/update permissions </summary>
    extensiondials_update,
    /// <summary> Has access to the extensiondials endpoint with only read/delete permissions </summary>
    extensiondials_delete,
    /// <summary> Has access to the extensiondials endpoint with only read/create permissions </summary>
    extensiondials_create,

    /// <summary> Has access to the extensionqueues endpoint with full permissions </summary>
    extensionqueues = 180,
    /// <summary> Has access to the extensionqueues endpoint with only read permissions </summary>
    extensionqueues_readonly,
    /// <summary> Has access to the extensionqueues endpoint with only read/update permissions </summary>
    extensionqueues_update,
    /// <summary> Has access to the extensionqueues endpoint with only read/delete permissions </summary>
    extensionqueues_delete,
    /// <summary> Has access to the extensionqueues endpoint with only read/create permissions </summary>
    extensionqueues_create,

    /// <summary> Has access to the extensionvoicemails endpoint with full permissions </summary>
    extensionvoicemails = 190,
    /// <summary> Has access to the extensionvoicemails endpoint with only read permissions </summary>
    extensionvoicemails_readonly,
    /// <summary> Has access to the extensionvoicemails endpoint with only read/update permissions </summary>
    extensionvoicemails_update,
    /// <summary> Has access to the extensionvoicemails endpoint with only read/delete permissions </summary>
    extensionvoicemails_delete,
    /// <summary> Has access to the extensionvoicemails endpoint with only read/create permissions </summary>
    extensionvoicemails_create,

    /// <summary> Has access to the emails endpoint with full permissions </summary>
    emails = 200,
    /// <summary> Has access to the emails endpoint with only read permissions </summary>
    emails_readonly,
    /// <summary> Has access to the emails endpoint with only read/update permissions </summary>
    emails_update,
    /// <summary> Has access to the emails endpoint with only read/delete permissions </summary>
    emails_delete,
    /// <summary> Has access to the emails endpoint with only read/create permissions </summary>
    emails_create,

    /// <summary> Has access to the faxincomings endpoint with full permissions </summary>
    faxincomings = 210,
    /// <summary> Has access to the faxincomings endpoint with only read permissions </summary>
    faxincomings_readonly,
    /// <summary> Has access to the faxincomings endpoint with only read/update permissions </summary>
    faxincomings_update,
    /// <summary> Has access to the faxincomings endpoint with only read/delete permissions </summary>
    faxincomings_delete,
    /// <summary> Has access to the faxincomings endpoint with only read/create permissions </summary>
    faxincomings_create,

    /// <summary> Has access to the faxoutgoinggroups endpoint with full permissions </summary>
    faxoutgoinggroups = 220,
    /// <summary> Has access to the faxoutgoinggroups endpoint with only read permissions </summary>
    faxoutgoinggroups_readonly,
    /// <summary> Has access to the faxoutgoinggroups endpoint with only read/update permissions </summary>
    faxoutgoinggroups_update,
    /// <summary> Has access to the faxoutgoinggroups endpoint with only read/delete permissions </summary>
    faxoutgoinggroups_delete,
    /// <summary> Has access to the faxoutgoinggroups endpoint with only read/create permissions </summary>
    faxoutgoinggroups_create,

    /// <summary> Has access to the users endpoint with full permissions </summary>
    users = 230,
    /// <summary> Has access to the users endpoint with only read permissions </summary>
    users_readonly,
    /// <summary> Has access to the users endpoint with only read/update permissions </summary>
    users_update,
    /// <summary> Has access to the users endpoint with only read/delete permissions </summary>
    users_delete,
    /// <summary> Has access to the users endpoint with only read/create permissions </summary>
    users_create,

    /// <summary> Has access to the speeddialgroups endpoint with full permissions </summary>
    speeddialgroups = 240,
    /// <summary> Has access to the speeddialgroups endpoint with only read permissions </summary>
    speeddialgroups_readonly,
    /// <summary> Has access to the speeddialgroups endpoint with only read/update permissions </summary>
    speeddialgroups_update,
    /// <summary> Has access to the speeddialgroups endpoint with only read/delete permissions </summary>
    speeddialgroups_delete,
    /// <summary> Has access to the speeddialgroups endpoint with only read/create permissions </summary>
    speeddialgroups_create,

    /// <summary> Has access to the musiconholdgroups endpoint with full permissions </summary>
    musiconholdgroups = 250,
    /// <summary> Has access to the musiconholdgroups endpoint with only read permissions </summary>
    musiconholdgroups_readonly,
    /// <summary> Has access to the musiconholdgroups endpoint with only read/update permissions </summary>
    musiconholdgroups_update,
    /// <summary> Has access to the musiconholdgroups endpoint with only read/delete permissions </summary>
    musiconholdgroups_delete,
    /// <summary> Has access to the musiconholdgroups endpoint with only read/create permissions </summary>
    musiconholdgroups_create,

    /// <summary> Has access to the phones endpoint with full permissions </summary>
    phones = 260,
    /// <summary> Has access to the phones endpoint with only read permissions </summary>
    phones_readonly,
    /// <summary> Has access to the phones endpoint with only read/update permissions </summary>
    phones_update,
    /// <summary> Has access to the phones endpoint with only read/delete permissions </summary>
    phones_delete,
    /// <summary> Has access to the phones endpoint with only read/create permissions </summary>
    phones_create,

    /// <summary> Has access to the phoneconfigurations endpoint with full permissions </summary>
    phoneconfigurations = 270,
    /// <summary> Has access to the phoneconfigurations endpoint with only read permissions </summary>
    phoneconfigurations_readonly,
    /// <summary> Has access to the phoneconfigurations endpoint with only read/update permissions </summary>
    phoneconfigurations_update,
    /// <summary> Has access to the phoneconfigurations endpoint with only read/delete permissions </summary>
    phoneconfigurations_delete,
    /// <summary> Has access to the phoneconfigurations endpoint with only read/create permissions </summary>
    phoneconfigurations_create,

    /// <summary> Has access to the powerdialergroups endpoint with full permissions </summary>
    powerdialergroups = 280,
    /// <summary> Has access to the powerdialergroups endpoint with only read permissions </summary>
    powerdialergroups_readonly,
    /// <summary> Has access to the powerdialergroups endpoint with only read/update permissions </summary>
    powerdialergroups_update,
    /// <summary> Has access to the powerdialergroups endpoint with only read/delete permissions </summary>
    powerdialergroups_delete,
    /// <summary> Has access to the powerdialergroups endpoint with only read/create permissions </summary>
    powerdialergroups_create,

    /// <summary> Has access to the powerdialercontacts endpoint with full permissions </summary>
    powerdialercontacts = 290,
    /// <summary> Has access to the powerdialercontacts endpoint with only read permissions </summary>
    powerdialercontacts_readonly,
    /// <summary> Has access to the powerdialercontacts endpoint with only read/update permissions </summary>
    powerdialercontacts_update,
    /// <summary> Has access to the powerdialercontacts endpoint with only read/delete permissions </summary>
    powerdialercontacts_delete,
    /// <summary> Has access to the powerdialercontacts endpoint with only read/create permissions </summary>
    powerdialercontacts_create,

    /// <summary> Has access to the sms endpoint with full permissions </summary>
    sms = 300,
    /// <summary> Has access to the sms endpoint with only read permissions </summary>
    sms_readonly,
    /// <summary> Has access to the sms endpoint with only read/update permissions </summary>
    sms_update,
    /// <summary> Has access to the sms endpoint with only read/delete permissions </summary>
    sms_delete,
    /// <summary> Has access to the sms endpoint with only read/create permissions </summary>
    sms_create,

    /// <summary> Has access to the voicemails endpoint with full permissions </summary>
    voicemails = 310,
    /// <summary> Has access to the voicemails endpoint with only read permissions </summary>
    voicemails_readonly,
    /// <summary> Has access to the voicemails endpoint with only read/update permissions </summary>
    voicemails_update,
    /// <summary> Has access to the voicemails endpoint with only read/delete permissions </summary>
    voicemails_delete,
    /// <summary> Has access to the voicemails endpoint with only read/create permissions </summary>
    voicemails_create,

    /// <summary> Has access to the voipnumbers endpoint with full permissions </summary>
    voipnumbers = 320,
    /// <summary> Has access to the voipnumbers endpoint with only read permissions </summary>
    voipnumbers_readonly,
    /// <summary> Has access to the voipnumbers endpoint with only read/update permissions </summary>
    voipnumbers_update,
    /// <summary> Has access to the voipnumbers endpoint with only read/delete permissions </summary>
    voipnumbers_delete,
    /// <summary> Has access to the voipnumbers endpoint with only read/create permissions </summary>
    voipnumbers_create,

    /// <summary> Has access to the voipnumberavailableforpurchases endpoint with full permissions </summary>
    voipnumberavailableforpurchases = 330,
    /// <summary> Has access to the voipnumberavailableforpurchases endpoint with only read permissions </summary>
    voipnumberavailableforpurchases_readonly,
    /// <summary> Has access to the voipnumberavailableforpurchases endpoint with only read/update permissions </summary>
    voipnumberavailableforpurchases_update,
    /// <summary> Has access to the voipnumberavailableforpurchases endpoint with only read/delete permissions </summary>
    voipnumberavailableforpurchases_delete,
    /// <summary> Has access to the voipnumberavailableforpurchases endpoint with only read/create permissions </summary>
    voipnumberavailableforpurchases_create,

    /// <summary> Has access to the voipnumberfaxs endpoint with full permissions </summary>
    voipnumberfaxs = 340,
    /// <summary> Has access to the voipnumberfaxs endpoint with only read permissions </summary>
    voipnumberfaxs_readonly,
    /// <summary> Has access to the voipnumberfaxs endpoint with only read/update permissions </summary>
    voipnumberfaxs_update,
    /// <summary> Has access to the voipnumberfaxs endpoint with only read/delete permissions </summary>
    voipnumberfaxs_delete,
    /// <summary> Has access to the voipnumberfaxs endpoint with only read/create permissions </summary>
    voipnumberfaxs_create,

    /// <summary> Has access to the voipnumberphones endpoint with full permissions </summary>
    voipnumberphones = 350,
    /// <summary> Has access to the voipnumberphones endpoint with only read permissions </summary>
    voipnumberphones_readonly,
    /// <summary> Has access to the voipnumberphones endpoint with only read/update permissions </summary>
    voipnumberphones_update,
    /// <summary> Has access to the voipnumberphones endpoint with only read/delete permissions </summary>
    voipnumberphones_delete,
    /// <summary> Has access to the voipnumberphones endpoint with only read/create permissions </summary>
    voipnumberphones_create,

    /// <summary> Has access to the webhooks endpoint with full permissions </summary>
    webhooks = 360,
    /// <summary> Has access to the webhooks endpoint with only read permissions </summary>
    webhooks_readonly,
    /// <summary> Has access to the webhooks endpoint with only read/update permissions </summary>
    webhooks_update,
    /// <summary> Has access to the webhooks endpoint with only read/delete permissions </summary>
    webhooks_delete,
    /// <summary> Has access to the webhooks endpoint with only read/create permissions </summary>
    webhooks_create,

    /// <summary> Has access to the tags endpoint with full permissions </summary>
    tags = 370,
    /// <summary> Has access to the tags endpoint with only read permissions </summary>
    tags_readonly,
    /// <summary> Has access to the tags endpoint with only read/update permissions </summary>
    tags_update,
    /// <summary> Has access to the tags endpoint with only read/delete permissions </summary>
    tags_delete,
    /// <summary> Has access to the tags endpoint with only read/create permissions </summary>
    tags_create,

    /// <summary> Has access to the apikeys endpoint with full permissions </summary>
    apikeys = 380,
    /// <summary> Has access to the apikeys endpoint with only read permissions </summary>
    apikeys_readonly,
    /// <summary> Has access to the apikeys endpoint with only read/update permissions </summary>
    apikeys_update,
    /// <summary> Has access to the apikeys endpoint with only read/delete permissions </summary>
    apikeys_delete,
    /// <summary> Has access to the apikeys endpoint with only read/create permissions </summary>
    apikeys_create,

    /// <summary> Has access to the aicalltranscriptions endpoint with full permissions </summary>
    aicalltranscriptions = 390,
    /// <summary> Has access to the aicalltranscriptions endpoint with only read permissions </summary>
    aicalltranscriptions_readonly,
    /// <summary> Has access to the aicalltranscriptions endpoint with only read/update permissions </summary>
    aicalltranscriptions_update,
    /// <summary> Has access to the aicalltranscriptions endpoint with only read/delete permissions </summary>
    aicalltranscriptions_delete,
    /// <summary> Has access to the aicalltranscriptions endpoint with only read/create permissions </summary>
    aicalltranscriptions_create,

    /// <summary> Has access to the aicallanalysisinputs endpoint with full permissions </summary>
    aicallanalysisinputs = 400,
    /// <summary> Has access to the aicallanalysisinputs endpoint with only read permissions </summary>
    aicallanalysisinputs_readonly,
    /// <summary> Has access to the aicallanalysisinputs endpoint with only read/update permissions </summary>
    aicallanalysisinputs_update,
    /// <summary> Has access to the aicallanalysisinputs endpoint with only read/delete permissions </summary>
    aicallanalysisinputs_delete,
    /// <summary> Has access to the aicallanalysisinputs endpoint with only read/create permissions </summary>
    aicallanalysisinputs_create,

    #endregion

    #region Medium Priority

    /// <summary>
    ///     Can execute all endpoints the default user can execute
    /// </summary>
    admin = 1000,
    /// <summary> user with only read permissions </summary>
    admin_readonly,
    /// <summary> user with only read/update permissions </summary>
    admin_update,
    /// <summary> user with only read/delete permissions </summary>
    admin_delete,
    /// <summary> user with only read/create permissions </summary>
    admin_create,

    /// <summary>
    ///     Can execute support services. For example it can reboot a PBX. Can also execute user role
    /// </summary>
    support = 1010,
    /// <summary> support with only read permissions </summary>
    support_readonly,
    /// <summary> support with only read/update permissions </summary>
    support_update,
    /// <summary> support with only read/delete permissions </summary>
    support_delete,
    /// <summary> support with only read/create permissions </summary>
    support_create,

    #endregion

    #region Protected High Priority

    /// <summary>
    ///     Web hosting. This is where ublux static website is hosted.
    /// </summary>
    wh = 1000000,

    /// <summary>
    ///     US-1, US-2, etc...
    /// </summary>
    pbx = 2000000,

    /// <summary>
    ///     WebApp. This is where chat and web-phone runs
    /// </summary>
    wa = 3000000,

    /// <summary>
    ///     We have this because a API can talk to another API
    /// </summary>
    api = 4000000,

    ///// <summary>
    /////     This is the master service that determines a user what API will use to consume the API
    ///// </summary>
    //MS,   

    #endregion

    #region ROOT

    /// <summary>
    ///     Avoid using this role. has access to everything
    /// </summary>
    root = 1000000000,

    #endregion
}
