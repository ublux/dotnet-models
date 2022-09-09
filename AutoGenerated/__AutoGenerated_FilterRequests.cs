/* THIS FILE IS AUTO GENERATED. DO NOT DELETE/MODIFY */
/* Contain filters in order to search for documents */


namespace Ublux.Communications.Models.Documents;

/// <summary> Enables searching for Accounts </summary>
public class AccountFilterRequest 
{
    /// <summary> IdsCloudServicePbxs equals </summary>
    [JsonProperty("idsCloudServicePbxs_eq")]
    public string? IdsCloudServicePbxs_EQ { get; set; }
    /// <summary> IdsCloudServicePbxs contains </summary>
    [JsonProperty("idsCloudServicePbxs_con")]
    public string? IdsCloudServicePbxs_CON { get; set; }
    /// <summary> IdsCloudServicePbxs regex </summary>
    [JsonProperty("idsCloudServicePbxs_reg")]
    public string? IdsCloudServicePbxs_REG { get; set; }

    /// <summary> MailingAddress.RecipientName equals </summary>
    [JsonProperty("mailingAddress_recipientName_eq")]
    public string? MailingAddress_RecipientName_EQ { get; set; }
    /// <summary> MailingAddress.RecipientName contains </summary>
    [JsonProperty("mailingAddress_recipientName_con")]
    public string? MailingAddress_RecipientName_CON { get; set; }
    /// <summary> MailingAddress.RecipientName regex </summary>
    [JsonProperty("mailingAddress_recipientName_reg")]
    public string? MailingAddress_RecipientName_REG { get; set; }

    /// <summary> MailingAddress.BusinessName equals </summary>
    [JsonProperty("mailingAddress_businessName_eq")]
    public string? MailingAddress_BusinessName_EQ { get; set; }
    /// <summary> MailingAddress.BusinessName contains </summary>
    [JsonProperty("mailingAddress_businessName_con")]
    public string? MailingAddress_BusinessName_CON { get; set; }
    /// <summary> MailingAddress.BusinessName regex </summary>
    [JsonProperty("mailingAddress_businessName_reg")]
    public string? MailingAddress_BusinessName_REG { get; set; }

    /// <summary> MailingAddress.StreetAddress equals </summary>
    [JsonProperty("mailingAddress_streetAddress_eq")]
    public string? MailingAddress_StreetAddress_EQ { get; set; }
    /// <summary> MailingAddress.StreetAddress contains </summary>
    [JsonProperty("mailingAddress_streetAddress_con")]
    public string? MailingAddress_StreetAddress_CON { get; set; }
    /// <summary> MailingAddress.StreetAddress regex </summary>
    [JsonProperty("mailingAddress_streetAddress_reg")]
    public string? MailingAddress_StreetAddress_REG { get; set; }

    /// <summary> MailingAddress.ApparmentOrSuiteNumber equals </summary>
    [JsonProperty("mailingAddress_apparmentOrSuiteNumber_eq")]
    public string? MailingAddress_ApparmentOrSuiteNumber_EQ { get; set; }
    /// <summary> MailingAddress.ApparmentOrSuiteNumber contains </summary>
    [JsonProperty("mailingAddress_apparmentOrSuiteNumber_con")]
    public string? MailingAddress_ApparmentOrSuiteNumber_CON { get; set; }
    /// <summary> MailingAddress.ApparmentOrSuiteNumber regex </summary>
    [JsonProperty("mailingAddress_apparmentOrSuiteNumber_reg")]
    public string? MailingAddress_ApparmentOrSuiteNumber_REG { get; set; }

    /// <summary> MailingAddress.City equals </summary>
    [JsonProperty("mailingAddress_city_eq")]
    public string? MailingAddress_City_EQ { get; set; }
    /// <summary> MailingAddress.City contains </summary>
    [JsonProperty("mailingAddress_city_con")]
    public string? MailingAddress_City_CON { get; set; }
    /// <summary> MailingAddress.City regex </summary>
    [JsonProperty("mailingAddress_city_reg")]
    public string? MailingAddress_City_REG { get; set; }

    /// <summary> MailingAddress.State equals </summary>
    [JsonProperty("mailingAddress_state_eq")]
    public string? MailingAddress_State_EQ { get; set; }
    /// <summary> MailingAddress.State contains </summary>
    [JsonProperty("mailingAddress_state_con")]
    public string? MailingAddress_State_CON { get; set; }
    /// <summary> MailingAddress.State regex </summary>
    [JsonProperty("mailingAddress_state_reg")]
    public string? MailingAddress_State_REG { get; set; }

    /// <summary> MailingAddress.ZipCode equals </summary>
    [JsonProperty("mailingAddress_zipCode_eq")]
    public string? MailingAddress_ZipCode_EQ { get; set; }
    /// <summary> MailingAddress.ZipCode contains </summary>
    [JsonProperty("mailingAddress_zipCode_con")]
    public string? MailingAddress_ZipCode_CON { get; set; }
    /// <summary> MailingAddress.ZipCode regex </summary>
    [JsonProperty("mailingAddress_zipCode_reg")]
    public string? MailingAddress_ZipCode_REG { get; set; }

    /// <summary> MailingAddress.Country equals </summary>
    [JsonProperty("mailingAddress_country_eq")]
    public CountryIsoCode? MailingAddress_Country_EQ { get; set; }


    /// <summary> AccountSecrets.PinPhone equals </summary>
    [JsonProperty("accountSecrets_pinPhone_eq")]
    public string? AccountSecrets_PinPhone_EQ { get; set; }
    /// <summary> AccountSecrets.PinPhone contains </summary>
    [JsonProperty("accountSecrets_pinPhone_con")]
    public string? AccountSecrets_PinPhone_CON { get; set; }
    /// <summary> AccountSecrets.PinPhone regex </summary>
    [JsonProperty("accountSecrets_pinPhone_reg")]
    public string? AccountSecrets_PinPhone_REG { get; set; }

    /// <summary> AccountSecrets.PinSpy equals </summary>
    [JsonProperty("accountSecrets_pinSpy_eq")]
    public string? AccountSecrets_PinSpy_EQ { get; set; }
    /// <summary> AccountSecrets.PinSpy contains </summary>
    [JsonProperty("accountSecrets_pinSpy_con")]
    public string? AccountSecrets_PinSpy_CON { get; set; }
    /// <summary> AccountSecrets.PinSpy regex </summary>
    [JsonProperty("accountSecrets_pinSpy_reg")]
    public string? AccountSecrets_PinSpy_REG { get; set; }


    /// <summary> AccountSettings.TurnOnRecordingOfExternalCallsWhenCreatingLine equals </summary>
    [JsonProperty("accountSettings_turnOnRecordingOfExternalCallsWhenCreatingLine_eq")]
    public bool? AccountSettings_TurnOnRecordingOfExternalCallsWhenCreatingLine_EQ { get; set; }

    /// <summary> AccountSettings.TurnOnRecordingOfInternalCallsWhenCreatingLine equals </summary>
    [JsonProperty("accountSettings_turnOnRecordingOfInternalCallsWhenCreatingLine_eq")]
    public bool? AccountSettings_TurnOnRecordingOfInternalCallsWhenCreatingLine_EQ { get; set; }

    /// <summary> AccountSettings.ContactCallerIdTemplate equals </summary>
    [JsonProperty("accountSettings_contactCallerIdTemplate_eq")]
    public string? AccountSettings_ContactCallerIdTemplate_EQ { get; set; }
    /// <summary> AccountSettings.ContactCallerIdTemplate contains </summary>
    [JsonProperty("accountSettings_contactCallerIdTemplate_con")]
    public string? AccountSettings_ContactCallerIdTemplate_CON { get; set; }
    /// <summary> AccountSettings.ContactCallerIdTemplate regex </summary>
    [JsonProperty("accountSettings_contactCallerIdTemplate_reg")]
    public string? AccountSettings_ContactCallerIdTemplate_REG { get; set; }


    /// <summary> CompanyName equals </summary>
    [JsonProperty("companyName_eq")]
    public string? CompanyName_EQ { get; set; }
    /// <summary> CompanyName contains </summary>
    [JsonProperty("companyName_con")]
    public string? CompanyName_CON { get; set; }
    /// <summary> CompanyName regex </summary>
    [JsonProperty("companyName_reg")]
    public string? CompanyName_REG { get; set; }

    /// <summary> HasGrantedSupportAccess equals </summary>
    [JsonProperty("hasGrantedSupportAccess_eq")]
    public bool? HasGrantedSupportAccess_EQ { get; set; }

    /// <summary> CountriesThatCanCallLocally contains </summary>
    [JsonProperty("countriesThatCanCallLocally_con")]
    public CountryIsoCode? CountriesThatCanCallLocally_CON { get; set; }

    /// <summary> CountriesThatCanCallInternationally contains </summary>
    [JsonProperty("countriesThatCanCallInternationally_con")]
    public CountryIsoCode? CountriesThatCanCallInternationally_CON { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for AgreementToTermsAndConditionss </summary>
public class AgreementToTermsAndConditionsFilterRequest 
{
    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for AirNetworksProvinces </summary>
public class AirNetworksProvinceFilterRequest 
{
    /// <summary> Name equals </summary>
    [JsonProperty("name_eq")]
    public string? Name_EQ { get; set; }
    /// <summary> Name contains </summary>
    [JsonProperty("name_con")]
    public string? Name_CON { get; set; }
    /// <summary> Name regex </summary>
    [JsonProperty("name_reg")]
    public string? Name_REG { get; set; }

    /// <summary> Populations equals </summary>
    [JsonProperty("populations_eq")]
    public string? Populations_EQ { get; set; }
    /// <summary> Populations contains </summary>
    [JsonProperty("populations_con")]
    public string? Populations_CON { get; set; }
    /// <summary> Populations regex </summary>
    [JsonProperty("populations_reg")]
    public string? Populations_REG { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for Audios </summary>
public class AudioFilterRequest 
{
    /// <summary> AudioMp3.InstanceId equals </summary>
    [JsonProperty("audioMp3_instanceId_eq")]
    public string? AudioMp3_InstanceId_EQ { get; set; }
    /// <summary> AudioMp3.InstanceId contains </summary>
    [JsonProperty("audioMp3_instanceId_con")]
    public string? AudioMp3_InstanceId_CON { get; set; }
    /// <summary> AudioMp3.InstanceId regex </summary>
    [JsonProperty("audioMp3_instanceId_reg")]
    public string? AudioMp3_InstanceId_REG { get; set; }

    /// <summary> AudioMp3.FileSizeInBytes equals </summary>
    [JsonProperty("audioMp3_fileSizeInBytes_eq")]
    public System.Int32? AudioMp3_FileSizeInBytes_EQ { get; set; }
    /// <summary> AudioMp3.FileSizeInBytes less than or equal to </summary>
    [JsonProperty("audioMp3_fileSizeInBytes_lte")]
    public System.Int32? AudioMp3_FileSizeInBytes_LTE { get; set; }
    /// <summary> AudioMp3.FileSizeInBytes greater than or equal to </summary>
    [JsonProperty("audioMp3_fileSizeInBytes_gte")]
    public System.Int32? AudioMp3_FileSizeInBytes_GTE { get; set; }

    /// <summary> AudioMp3.Md5Hash equals </summary>
    [JsonProperty("audioMp3_md5Hash_eq")]
    public string? AudioMp3_Md5Hash_EQ { get; set; }
    /// <summary> AudioMp3.Md5Hash contains </summary>
    [JsonProperty("audioMp3_md5Hash_con")]
    public string? AudioMp3_Md5Hash_CON { get; set; }
    /// <summary> AudioMp3.Md5Hash regex </summary>
    [JsonProperty("audioMp3_md5Hash_reg")]
    public string? AudioMp3_Md5Hash_REG { get; set; }

    /// <summary> AudioMp3.Url equals </summary>
    [JsonProperty("audioMp3_url_eq")]
    public string? AudioMp3_Url_EQ { get; set; }
    /// <summary> AudioMp3.Url contains </summary>
    [JsonProperty("audioMp3_url_con")]
    public string? AudioMp3_Url_CON { get; set; }
    /// <summary> AudioMp3.Url regex </summary>
    [JsonProperty("audioMp3_url_reg")]
    public string? AudioMp3_Url_REG { get; set; }

    /// <summary> AudioMp3.Id equals </summary>
    [JsonProperty("audioMp3_id_eq")]
    public string? AudioMp3_Id_EQ { get; set; }
    /// <summary> AudioMp3.Id contains </summary>
    [JsonProperty("audioMp3_id_con")]
    public string? AudioMp3_Id_CON { get; set; }
    /// <summary> AudioMp3.Id regex </summary>
    [JsonProperty("audioMp3_id_reg")]
    public string? AudioMp3_Id_REG { get; set; }


    /// <summary> AudioWav.InstanceId equals </summary>
    [JsonProperty("audioWav_instanceId_eq")]
    public string? AudioWav_InstanceId_EQ { get; set; }
    /// <summary> AudioWav.InstanceId contains </summary>
    [JsonProperty("audioWav_instanceId_con")]
    public string? AudioWav_InstanceId_CON { get; set; }
    /// <summary> AudioWav.InstanceId regex </summary>
    [JsonProperty("audioWav_instanceId_reg")]
    public string? AudioWav_InstanceId_REG { get; set; }

    /// <summary> AudioWav.FileSizeInBytes equals </summary>
    [JsonProperty("audioWav_fileSizeInBytes_eq")]
    public System.Int32? AudioWav_FileSizeInBytes_EQ { get; set; }
    /// <summary> AudioWav.FileSizeInBytes less than or equal to </summary>
    [JsonProperty("audioWav_fileSizeInBytes_lte")]
    public System.Int32? AudioWav_FileSizeInBytes_LTE { get; set; }
    /// <summary> AudioWav.FileSizeInBytes greater than or equal to </summary>
    [JsonProperty("audioWav_fileSizeInBytes_gte")]
    public System.Int32? AudioWav_FileSizeInBytes_GTE { get; set; }

    /// <summary> AudioWav.Md5Hash equals </summary>
    [JsonProperty("audioWav_md5Hash_eq")]
    public string? AudioWav_Md5Hash_EQ { get; set; }
    /// <summary> AudioWav.Md5Hash contains </summary>
    [JsonProperty("audioWav_md5Hash_con")]
    public string? AudioWav_Md5Hash_CON { get; set; }
    /// <summary> AudioWav.Md5Hash regex </summary>
    [JsonProperty("audioWav_md5Hash_reg")]
    public string? AudioWav_Md5Hash_REG { get; set; }

    /// <summary> AudioWav.Url equals </summary>
    [JsonProperty("audioWav_url_eq")]
    public string? AudioWav_Url_EQ { get; set; }
    /// <summary> AudioWav.Url contains </summary>
    [JsonProperty("audioWav_url_con")]
    public string? AudioWav_Url_CON { get; set; }
    /// <summary> AudioWav.Url regex </summary>
    [JsonProperty("audioWav_url_reg")]
    public string? AudioWav_Url_REG { get; set; }

    /// <summary> AudioWav.Id equals </summary>
    [JsonProperty("audioWav_id_eq")]
    public string? AudioWav_Id_EQ { get; set; }
    /// <summary> AudioWav.Id contains </summary>
    [JsonProperty("audioWav_id_con")]
    public string? AudioWav_Id_CON { get; set; }
    /// <summary> AudioWav.Id regex </summary>
    [JsonProperty("audioWav_id_reg")]
    public string? AudioWav_Id_REG { get; set; }


    /// <summary> FriendlyName equals </summary>
    [JsonProperty("friendlyName_eq")]
    public string? FriendlyName_EQ { get; set; }
    /// <summary> FriendlyName contains </summary>
    [JsonProperty("friendlyName_con")]
    public string? FriendlyName_CON { get; set; }
    /// <summary> FriendlyName regex </summary>
    [JsonProperty("friendlyName_reg")]
    public string? FriendlyName_REG { get; set; }

    /// <summary> DurationInSeconds equals </summary>
    [JsonProperty("durationInSeconds_eq")]
    public System.Int32? DurationInSeconds_EQ { get; set; }
    /// <summary> DurationInSeconds less than or equal to </summary>
    [JsonProperty("durationInSeconds_lte")]
    public System.Int32? DurationInSeconds_LTE { get; set; }
    /// <summary> DurationInSeconds greater than or equal to </summary>
    [JsonProperty("durationInSeconds_gte")]
    public System.Int32? DurationInSeconds_GTE { get; set; }

    /// <summary> Description equals </summary>
    [JsonProperty("description_eq")]
    public string? Description_EQ { get; set; }
    /// <summary> Description contains </summary>
    [JsonProperty("description_con")]
    public string? Description_CON { get; set; }
    /// <summary> Description regex </summary>
    [JsonProperty("description_reg")]
    public string? Description_REG { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for AutoProvisionReferences </summary>
public class AutoProvisionReferenceFilterRequest 
{
    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for BlackListPhoneNumbers </summary>
public class BlackListPhoneNumberFilterRequest 
{
    /// <summary> SearchIndex equals </summary>
    [JsonProperty("searchIndex_eq")]
    public string? SearchIndex_EQ { get; set; }
    /// <summary> SearchIndex contains </summary>
    [JsonProperty("searchIndex_con")]
    public string? SearchIndex_CON { get; set; }
    /// <summary> SearchIndex regex </summary>
    [JsonProperty("searchIndex_reg")]
    public string? SearchIndex_REG { get; set; }

    /// <summary> IdAudioToPlayIfCallIsBlocked equals </summary>
    [JsonProperty("idAudioToPlayIfCallIsBlocked_eq")]
    public string? IdAudioToPlayIfCallIsBlocked_EQ { get; set; }
    /// <summary> IdAudioToPlayIfCallIsBlocked contains </summary>
    [JsonProperty("idAudioToPlayIfCallIsBlocked_con")]
    public string? IdAudioToPlayIfCallIsBlocked_CON { get; set; }
    /// <summary> IdAudioToPlayIfCallIsBlocked regex </summary>
    [JsonProperty("idAudioToPlayIfCallIsBlocked_reg")]
    public string? IdAudioToPlayIfCallIsBlocked_REG { get; set; }

    /// <summary> Number equals </summary>
    [JsonProperty("number_eq")]
    public string? Number_EQ { get; set; }
    /// <summary> Number contains </summary>
    [JsonProperty("number_con")]
    public string? Number_CON { get; set; }
    /// <summary> Number regex </summary>
    [JsonProperty("number_reg")]
    public string? Number_REG { get; set; }

    /// <summary> FriendlyName equals </summary>
    [JsonProperty("friendlyName_eq")]
    public string? FriendlyName_EQ { get; set; }
    /// <summary> FriendlyName contains </summary>
    [JsonProperty("friendlyName_con")]
    public string? FriendlyName_CON { get; set; }
    /// <summary> FriendlyName regex </summary>
    [JsonProperty("friendlyName_reg")]
    public string? FriendlyName_REG { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for CallerIdMasks </summary>
public class CallerIdMaskFilterRequest 
{
    /// <summary> PhoneNumber equals </summary>
    [JsonProperty("phoneNumber_eq")]
    public string? PhoneNumber_EQ { get; set; }
    /// <summary> PhoneNumber contains </summary>
    [JsonProperty("phoneNumber_con")]
    public string? PhoneNumber_CON { get; set; }
    /// <summary> PhoneNumber regex </summary>
    [JsonProperty("phoneNumber_reg")]
    public string? PhoneNumber_REG { get; set; }

    /// <summary> FriendlyName equals </summary>
    [JsonProperty("friendlyName_eq")]
    public string? FriendlyName_EQ { get; set; }
    /// <summary> FriendlyName contains </summary>
    [JsonProperty("friendlyName_con")]
    public string? FriendlyName_CON { get; set; }
    /// <summary> FriendlyName regex </summary>
    [JsonProperty("friendlyName_reg")]
    public string? FriendlyName_REG { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for CallFlowLogics </summary>
public class CallFlowLogicFilterRequest 
{
    /// <summary> FriendlyName equals </summary>
    [JsonProperty("friendlyName_eq")]
    public string? FriendlyName_EQ { get; set; }
    /// <summary> FriendlyName contains </summary>
    [JsonProperty("friendlyName_con")]
    public string? FriendlyName_CON { get; set; }
    /// <summary> FriendlyName regex </summary>
    [JsonProperty("friendlyName_reg")]
    public string? FriendlyName_REG { get; set; }

    /// <summary> Description equals </summary>
    [JsonProperty("description_eq")]
    public string? Description_EQ { get; set; }
    /// <summary> Description contains </summary>
    [JsonProperty("description_con")]
    public string? Description_CON { get; set; }
    /// <summary> Description regex </summary>
    [JsonProperty("description_reg")]
    public string? Description_REG { get; set; }

    /// <summary> XmlTree equals </summary>
    [JsonProperty("xmlTree_eq")]
    public string? XmlTree_EQ { get; set; }
    /// <summary> XmlTree contains </summary>
    [JsonProperty("xmlTree_con")]
    public string? XmlTree_CON { get; set; }
    /// <summary> XmlTree regex </summary>
    [JsonProperty("xmlTree_reg")]
    public string? XmlTree_REG { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for CallIncomingToCallFlowLogics </summary>
public class CallIncomingToCallFlowLogicFilterRequest 
{
    /// <summary> IdCallFlowLogic equals </summary>
    [JsonProperty("idCallFlowLogic_eq")]
    public string? IdCallFlowLogic_EQ { get; set; }
    /// <summary> IdCallFlowLogic contains </summary>
    [JsonProperty("idCallFlowLogic_con")]
    public string? IdCallFlowLogic_CON { get; set; }
    /// <summary> IdCallFlowLogic regex </summary>
    [JsonProperty("idCallFlowLogic_reg")]
    public string? IdCallFlowLogic_REG { get; set; }

    /// <summary> CallType equals </summary>
    [JsonProperty("callType_eq")]
    public CallType? CallType_EQ { get; set; }

    /// <summary> Contact.IdIdentityUser equals </summary>
    [JsonProperty("contact_idIdentityUser_eq")]
    public string? Contact_IdIdentityUser_EQ { get; set; }
    /// <summary> Contact.IdIdentityUser contains </summary>
    [JsonProperty("contact_idIdentityUser_con")]
    public string? Contact_IdIdentityUser_CON { get; set; }
    /// <summary> Contact.IdIdentityUser regex </summary>
    [JsonProperty("contact_idIdentityUser_reg")]
    public string? Contact_IdIdentityUser_REG { get; set; }

    /// <summary> Contact.ContactNumbers.SearchIndex equals </summary>
    [JsonProperty("contact_contactNumbers_searchIndex_eq")]
    public string? Contact_ContactNumbers_SearchIndex_EQ { get; set; }
    /// <summary> Contact.ContactNumbers.SearchIndex contains </summary>
    [JsonProperty("contact_contactNumbers_searchIndex_con")]
    public string? Contact_ContactNumbers_SearchIndex_CON { get; set; }
    /// <summary> Contact.ContactNumbers.SearchIndex regex </summary>
    [JsonProperty("contact_contactNumbers_searchIndex_reg")]
    public string? Contact_ContactNumbers_SearchIndex_REG { get; set; }

    /// <summary> Contact.ContactNumbers.Number equals </summary>
    [JsonProperty("contact_contactNumbers_number_eq")]
    public string? Contact_ContactNumbers_Number_EQ { get; set; }
    /// <summary> Contact.ContactNumbers.Number contains </summary>
    [JsonProperty("contact_contactNumbers_number_con")]
    public string? Contact_ContactNumbers_Number_CON { get; set; }
    /// <summary> Contact.ContactNumbers.Number regex </summary>
    [JsonProperty("contact_contactNumbers_number_reg")]
    public string? Contact_ContactNumbers_Number_REG { get; set; }

    /// <summary> Contact.ContactNumbers.NumberInternationalFormat equals </summary>
    [JsonProperty("contact_contactNumbers_numberInternationalFormat_eq")]
    public string? Contact_ContactNumbers_NumberInternationalFormat_EQ { get; set; }
    /// <summary> Contact.ContactNumbers.NumberInternationalFormat contains </summary>
    [JsonProperty("contact_contactNumbers_numberInternationalFormat_con")]
    public string? Contact_ContactNumbers_NumberInternationalFormat_CON { get; set; }
    /// <summary> Contact.ContactNumbers.NumberInternationalFormat regex </summary>
    [JsonProperty("contact_contactNumbers_numberInternationalFormat_reg")]
    public string? Contact_ContactNumbers_NumberInternationalFormat_REG { get; set; }

    /// <summary> Contact.ContactNumbers.Label equals </summary>
    [JsonProperty("contact_contactNumbers_label_eq")]
    public LabelNumber? Contact_ContactNumbers_Label_EQ { get; set; }


    /// <summary> Contact.ContactEmails.SearchIndex equals </summary>
    [JsonProperty("contact_contactEmails_searchIndex_eq")]
    public string? Contact_ContactEmails_SearchIndex_EQ { get; set; }
    /// <summary> Contact.ContactEmails.SearchIndex contains </summary>
    [JsonProperty("contact_contactEmails_searchIndex_con")]
    public string? Contact_ContactEmails_SearchIndex_CON { get; set; }
    /// <summary> Contact.ContactEmails.SearchIndex regex </summary>
    [JsonProperty("contact_contactEmails_searchIndex_reg")]
    public string? Contact_ContactEmails_SearchIndex_REG { get; set; }

    /// <summary> Contact.ContactEmails.Email equals </summary>
    [JsonProperty("contact_contactEmails_email_eq")]
    public string? Contact_ContactEmails_Email_EQ { get; set; }
    /// <summary> Contact.ContactEmails.Email contains </summary>
    [JsonProperty("contact_contactEmails_email_con")]
    public string? Contact_ContactEmails_Email_CON { get; set; }
    /// <summary> Contact.ContactEmails.Email regex </summary>
    [JsonProperty("contact_contactEmails_email_reg")]
    public string? Contact_ContactEmails_Email_REG { get; set; }

    /// <summary> Contact.ContactEmails.Label equals </summary>
    [JsonProperty("contact_contactEmails_label_eq")]
    public LabelEmailType? Contact_ContactEmails_Label_EQ { get; set; }


    /// <summary> Contact.FirstName equals </summary>
    [JsonProperty("contact_firstName_eq")]
    public string? Contact_FirstName_EQ { get; set; }
    /// <summary> Contact.FirstName contains </summary>
    [JsonProperty("contact_firstName_con")]
    public string? Contact_FirstName_CON { get; set; }
    /// <summary> Contact.FirstName regex </summary>
    [JsonProperty("contact_firstName_reg")]
    public string? Contact_FirstName_REG { get; set; }

    /// <summary> Contact.LastName equals </summary>
    [JsonProperty("contact_lastName_eq")]
    public string? Contact_LastName_EQ { get; set; }
    /// <summary> Contact.LastName contains </summary>
    [JsonProperty("contact_lastName_con")]
    public string? Contact_LastName_CON { get; set; }
    /// <summary> Contact.LastName regex </summary>
    [JsonProperty("contact_lastName_reg")]
    public string? Contact_LastName_REG { get; set; }

    /// <summary> Contact.JobTittle equals </summary>
    [JsonProperty("contact_jobTittle_eq")]
    public string? Contact_JobTittle_EQ { get; set; }
    /// <summary> Contact.JobTittle contains </summary>
    [JsonProperty("contact_jobTittle_con")]
    public string? Contact_JobTittle_CON { get; set; }
    /// <summary> Contact.JobTittle regex </summary>
    [JsonProperty("contact_jobTittle_reg")]
    public string? Contact_JobTittle_REG { get; set; }

    /// <summary> Contact.Company equals </summary>
    [JsonProperty("contact_company_eq")]
    public string? Contact_Company_EQ { get; set; }
    /// <summary> Contact.Company contains </summary>
    [JsonProperty("contact_company_con")]
    public string? Contact_Company_CON { get; set; }
    /// <summary> Contact.Company regex </summary>
    [JsonProperty("contact_company_reg")]
    public string? Contact_Company_REG { get; set; }

    /// <summary> Contact.Hash equals </summary>
    [JsonProperty("contact_hash_eq")]
    public string? Contact_Hash_EQ { get; set; }
    /// <summary> Contact.Hash contains </summary>
    [JsonProperty("contact_hash_con")]
    public string? Contact_Hash_CON { get; set; }
    /// <summary> Contact.Hash regex </summary>
    [JsonProperty("contact_hash_reg")]
    public string? Contact_Hash_REG { get; set; }

    /// <summary> Contact.Notes equals </summary>
    [JsonProperty("contact_notes_eq")]
    public string? Contact_Notes_EQ { get; set; }
    /// <summary> Contact.Notes contains </summary>
    [JsonProperty("contact_notes_con")]
    public string? Contact_Notes_CON { get; set; }
    /// <summary> Contact.Notes regex </summary>
    [JsonProperty("contact_notes_reg")]
    public string? Contact_Notes_REG { get; set; }

    /// <summary> Contact.Variables.Name equals </summary>
    [JsonProperty("contact_variables_name_eq")]
    public string? Contact_Variables_Name_EQ { get; set; }
    /// <summary> Contact.Variables.Name contains </summary>
    [JsonProperty("contact_variables_name_con")]
    public string? Contact_Variables_Name_CON { get; set; }
    /// <summary> Contact.Variables.Name regex </summary>
    [JsonProperty("contact_variables_name_reg")]
    public string? Contact_Variables_Name_REG { get; set; }

    /// <summary> Contact.Variables.JsonValue equals </summary>
    [JsonProperty("contact_variables_jsonValue_eq")]
    public string? Contact_Variables_JsonValue_EQ { get; set; }
    /// <summary> Contact.Variables.JsonValue contains </summary>
    [JsonProperty("contact_variables_jsonValue_con")]
    public string? Contact_Variables_JsonValue_CON { get; set; }
    /// <summary> Contact.Variables.JsonValue regex </summary>
    [JsonProperty("contact_variables_jsonValue_reg")]
    public string? Contact_Variables_JsonValue_REG { get; set; }


    /// <summary> Contact.Id equals </summary>
    [JsonProperty("contact_id_eq")]
    public string? Contact_Id_EQ { get; set; }
    /// <summary> Contact.Id contains </summary>
    [JsonProperty("contact_id_con")]
    public string? Contact_Id_CON { get; set; }
    /// <summary> Contact.Id regex </summary>
    [JsonProperty("contact_id_reg")]
    public string? Contact_Id_REG { get; set; }

    /// <summary> Contact.DateCreated equals </summary>
    [JsonProperty("contact_dateCreated_eq")]
    public DateTime? Contact_DateCreated_EQ { get; set; }
    /// <summary> Contact.DateCreated less than or equal to </summary>
    [JsonProperty("contact_dateCreated_lte")]
    public DateTime? Contact_DateCreated_LTE { get; set; }
    /// <summary> Contact.DateCreated greater than or equal to </summary>
    [JsonProperty("contact_dateCreated_gte")]
    public DateTime? Contact_DateCreated_GTE { get; set; }

    /// <summary> Contact.DateUpdated equals </summary>
    [JsonProperty("contact_dateUpdated_eq")]
    public DateTime? Contact_DateUpdated_EQ { get; set; }
    /// <summary> Contact.DateUpdated less than or equal to </summary>
    [JsonProperty("contact_dateUpdated_lte")]
    public DateTime? Contact_DateUpdated_LTE { get; set; }
    /// <summary> Contact.DateUpdated greater than or equal to </summary>
    [JsonProperty("contact_dateUpdated_gte")]
    public DateTime? Contact_DateUpdated_GTE { get; set; }


    /// <summary> IdVoipNumberPhone equals </summary>
    [JsonProperty("idVoipNumberPhone_eq")]
    public string? IdVoipNumberPhone_EQ { get; set; }
    /// <summary> IdVoipNumberPhone contains </summary>
    [JsonProperty("idVoipNumberPhone_con")]
    public string? IdVoipNumberPhone_CON { get; set; }
    /// <summary> IdVoipNumberPhone regex </summary>
    [JsonProperty("idVoipNumberPhone_reg")]
    public string? IdVoipNumberPhone_REG { get; set; }

    /// <summary> FromInternationalFormat equals </summary>
    [JsonProperty("fromInternationalFormat_eq")]
    public string? FromInternationalFormat_EQ { get; set; }
    /// <summary> FromInternationalFormat contains </summary>
    [JsonProperty("fromInternationalFormat_con")]
    public string? FromInternationalFormat_CON { get; set; }
    /// <summary> FromInternationalFormat regex </summary>
    [JsonProperty("fromInternationalFormat_reg")]
    public string? FromInternationalFormat_REG { get; set; }

    /// <summary> IdVoicemail equals </summary>
    [JsonProperty("idVoicemail_eq")]
    public string? IdVoicemail_EQ { get; set; }
    /// <summary> IdVoicemail contains </summary>
    [JsonProperty("idVoicemail_con")]
    public string? IdVoicemail_CON { get; set; }
    /// <summary> IdVoicemail regex </summary>
    [JsonProperty("idVoicemail_reg")]
    public string? IdVoicemail_REG { get; set; }

    /// <summary> IdCallThatTerminatedThisCallDoToAttendantTransfer equals </summary>
    [JsonProperty("idCallThatTerminatedThisCallDoToAttendantTransfer_eq")]
    public string? IdCallThatTerminatedThisCallDoToAttendantTransfer_EQ { get; set; }
    /// <summary> IdCallThatTerminatedThisCallDoToAttendantTransfer contains </summary>
    [JsonProperty("idCallThatTerminatedThisCallDoToAttendantTransfer_con")]
    public string? IdCallThatTerminatedThisCallDoToAttendantTransfer_CON { get; set; }
    /// <summary> IdCallThatTerminatedThisCallDoToAttendantTransfer regex </summary>
    [JsonProperty("idCallThatTerminatedThisCallDoToAttendantTransfer_reg")]
    public string? IdCallThatTerminatedThisCallDoToAttendantTransfer_REG { get; set; }

    /// <summary> ChannelVariables.Language equals </summary>
    [JsonProperty("channelVariables_language_eq")]
    public Language? ChannelVariables_Language_EQ { get; set; }

    /// <summary> ChannelVariables.IdMusicOnHold equals </summary>
    [JsonProperty("channelVariables_idMusicOnHold_eq")]
    public string? ChannelVariables_IdMusicOnHold_EQ { get; set; }
    /// <summary> ChannelVariables.IdMusicOnHold contains </summary>
    [JsonProperty("channelVariables_idMusicOnHold_con")]
    public string? ChannelVariables_IdMusicOnHold_CON { get; set; }
    /// <summary> ChannelVariables.IdMusicOnHold regex </summary>
    [JsonProperty("channelVariables_idMusicOnHold_reg")]
    public string? ChannelVariables_IdMusicOnHold_REG { get; set; }

    /// <summary> ChannelVariables.CallerIdName equals </summary>
    [JsonProperty("channelVariables_callerIdName_eq")]
    public string? ChannelVariables_CallerIdName_EQ { get; set; }
    /// <summary> ChannelVariables.CallerIdName contains </summary>
    [JsonProperty("channelVariables_callerIdName_con")]
    public string? ChannelVariables_CallerIdName_CON { get; set; }
    /// <summary> ChannelVariables.CallerIdName regex </summary>
    [JsonProperty("channelVariables_callerIdName_reg")]
    public string? ChannelVariables_CallerIdName_REG { get; set; }

    /// <summary> ChannelVariables.CallerIdNumber equals </summary>
    [JsonProperty("channelVariables_callerIdNumber_eq")]
    public string? ChannelVariables_CallerIdNumber_EQ { get; set; }
    /// <summary> ChannelVariables.CallerIdNumber contains </summary>
    [JsonProperty("channelVariables_callerIdNumber_con")]
    public string? ChannelVariables_CallerIdNumber_CON { get; set; }
    /// <summary> ChannelVariables.CallerIdNumber regex </summary>
    [JsonProperty("channelVariables_callerIdNumber_reg")]
    public string? ChannelVariables_CallerIdNumber_REG { get; set; }


    /// <summary> ChildCalls.ChildCallType equals </summary>
    [JsonProperty("childCalls_childCallType_eq")]
    public ChildCallType? ChildCalls_ChildCallType_EQ { get; set; }

    /// <summary> ChildCalls.DialStatus equals </summary>
    [JsonProperty("childCalls_dialStatus_eq")]
    public string? ChildCalls_DialStatus_EQ { get; set; }
    /// <summary> ChildCalls.DialStatus contains </summary>
    [JsonProperty("childCalls_dialStatus_con")]
    public string? ChildCalls_DialStatus_CON { get; set; }
    /// <summary> ChildCalls.DialStatus regex </summary>
    [JsonProperty("childCalls_dialStatus_reg")]
    public string? ChildCalls_DialStatus_REG { get; set; }

    /// <summary> ChildCalls.DateCreated equals </summary>
    [JsonProperty("childCalls_dateCreated_eq")]
    public DateTime? ChildCalls_DateCreated_EQ { get; set; }
    /// <summary> ChildCalls.DateCreated less than or equal to </summary>
    [JsonProperty("childCalls_dateCreated_lte")]
    public DateTime? ChildCalls_DateCreated_LTE { get; set; }
    /// <summary> ChildCalls.DateCreated greater than or equal to </summary>
    [JsonProperty("childCalls_dateCreated_gte")]
    public DateTime? ChildCalls_DateCreated_GTE { get; set; }

    /// <summary> ChildCalls.DateEnded equals </summary>
    [JsonProperty("childCalls_dateEnded_eq")]
    public DateTime? ChildCalls_DateEnded_EQ { get; set; }
    /// <summary> ChildCalls.DateEnded less than or equal to </summary>
    [JsonProperty("childCalls_dateEnded_lte")]
    public DateTime? ChildCalls_DateEnded_LTE { get; set; }
    /// <summary> ChildCalls.DateEnded greater than or equal to </summary>
    [JsonProperty("childCalls_dateEnded_gte")]
    public DateTime? ChildCalls_DateEnded_GTE { get; set; }

    /// <summary> ChildCalls.SecondsItTookToAnswer equals </summary>
    [JsonProperty("childCalls_secondsItTookToAnswer_eq")]
    public System.Int32? ChildCalls_SecondsItTookToAnswer_EQ { get; set; }
    /// <summary> ChildCalls.SecondsItTookToAnswer less than or equal to </summary>
    [JsonProperty("childCalls_secondsItTookToAnswer_lte")]
    public System.Int32? ChildCalls_SecondsItTookToAnswer_LTE { get; set; }
    /// <summary> ChildCalls.SecondsItTookToAnswer greater than or equal to </summary>
    [JsonProperty("childCalls_secondsItTookToAnswer_gte")]
    public System.Int32? ChildCalls_SecondsItTookToAnswer_GTE { get; set; }


    /// <summary> DialStatus equals </summary>
    [JsonProperty("dialStatus_eq")]
    public string? DialStatus_EQ { get; set; }
    /// <summary> DialStatus contains </summary>
    [JsonProperty("dialStatus_con")]
    public string? DialStatus_CON { get; set; }
    /// <summary> DialStatus regex </summary>
    [JsonProperty("dialStatus_reg")]
    public string? DialStatus_REG { get; set; }

    /// <summary> SecondsItTookToAnswer equals </summary>
    [JsonProperty("secondsItTookToAnswer_eq")]
    public System.Int32? SecondsItTookToAnswer_EQ { get; set; }
    /// <summary> SecondsItTookToAnswer less than or equal to </summary>
    [JsonProperty("secondsItTookToAnswer_lte")]
    public System.Int32? SecondsItTookToAnswer_LTE { get; set; }
    /// <summary> SecondsItTookToAnswer greater than or equal to </summary>
    [JsonProperty("secondsItTookToAnswer_gte")]
    public System.Int32? SecondsItTookToAnswer_GTE { get; set; }

    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenPlacedOnHold equals </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenPlacedOnHold_eq")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenPlacedOnHold_EQ { get; set; }
    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenPlacedOnHold less than or equal to </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenPlacedOnHold_lte")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenPlacedOnHold_LTE { get; set; }
    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenPlacedOnHold greater than or equal to </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenPlacedOnHold_gte")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenPlacedOnHold_GTE { get; set; }

    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenRemovedFromHold equals </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenRemovedFromHold_eq")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenRemovedFromHold_EQ { get; set; }
    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenRemovedFromHold less than or equal to </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenRemovedFromHold_lte")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenRemovedFromHold_LTE { get; set; }
    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenRemovedFromHold greater than or equal to </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenRemovedFromHold_gte")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenRemovedFromHold_GTE { get; set; }


    /// <summary> From equals </summary>
    [JsonProperty("from_eq")]
    public string? From_EQ { get; set; }
    /// <summary> From contains </summary>
    [JsonProperty("from_con")]
    public string? From_CON { get; set; }
    /// <summary> From regex </summary>
    [JsonProperty("from_reg")]
    public string? From_REG { get; set; }

    /// <summary> FromCountry equals </summary>
    [JsonProperty("fromCountry_eq")]
    public CountryIsoCode? FromCountry_EQ { get; set; }

    /// <summary> To equals </summary>
    [JsonProperty("to_eq")]
    public string? To_EQ { get; set; }
    /// <summary> To contains </summary>
    [JsonProperty("to_con")]
    public string? To_CON { get; set; }
    /// <summary> To regex </summary>
    [JsonProperty("to_reg")]
    public string? To_REG { get; set; }

    /// <summary> ToCountry equals </summary>
    [JsonProperty("toCountry_eq")]
    public CountryIsoCode? ToCountry_EQ { get; set; }

    /// <summary> Recording.ErrorMessage equals </summary>
    [JsonProperty("recording_errorMessage_eq")]
    public string? Recording_ErrorMessage_EQ { get; set; }
    /// <summary> Recording.ErrorMessage contains </summary>
    [JsonProperty("recording_errorMessage_con")]
    public string? Recording_ErrorMessage_CON { get; set; }
    /// <summary> Recording.ErrorMessage regex </summary>
    [JsonProperty("recording_errorMessage_reg")]
    public string? Recording_ErrorMessage_REG { get; set; }

    /// <summary> Recording.RecordingMp3.InstanceId equals </summary>
    [JsonProperty("recording_recordingMp3_instanceId_eq")]
    public string? Recording_RecordingMp3_InstanceId_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.InstanceId contains </summary>
    [JsonProperty("recording_recordingMp3_instanceId_con")]
    public string? Recording_RecordingMp3_InstanceId_CON { get; set; }
    /// <summary> Recording.RecordingMp3.InstanceId regex </summary>
    [JsonProperty("recording_recordingMp3_instanceId_reg")]
    public string? Recording_RecordingMp3_InstanceId_REG { get; set; }

    /// <summary> Recording.RecordingMp3.FileSizeInBytes equals </summary>
    [JsonProperty("recording_recordingMp3_fileSizeInBytes_eq")]
    public System.Int32? Recording_RecordingMp3_FileSizeInBytes_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.FileSizeInBytes less than or equal to </summary>
    [JsonProperty("recording_recordingMp3_fileSizeInBytes_lte")]
    public System.Int32? Recording_RecordingMp3_FileSizeInBytes_LTE { get; set; }
    /// <summary> Recording.RecordingMp3.FileSizeInBytes greater than or equal to </summary>
    [JsonProperty("recording_recordingMp3_fileSizeInBytes_gte")]
    public System.Int32? Recording_RecordingMp3_FileSizeInBytes_GTE { get; set; }

    /// <summary> Recording.RecordingMp3.Md5Hash equals </summary>
    [JsonProperty("recording_recordingMp3_md5Hash_eq")]
    public string? Recording_RecordingMp3_Md5Hash_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.Md5Hash contains </summary>
    [JsonProperty("recording_recordingMp3_md5Hash_con")]
    public string? Recording_RecordingMp3_Md5Hash_CON { get; set; }
    /// <summary> Recording.RecordingMp3.Md5Hash regex </summary>
    [JsonProperty("recording_recordingMp3_md5Hash_reg")]
    public string? Recording_RecordingMp3_Md5Hash_REG { get; set; }

    /// <summary> Recording.RecordingMp3.Url equals </summary>
    [JsonProperty("recording_recordingMp3_url_eq")]
    public string? Recording_RecordingMp3_Url_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.Url contains </summary>
    [JsonProperty("recording_recordingMp3_url_con")]
    public string? Recording_RecordingMp3_Url_CON { get; set; }
    /// <summary> Recording.RecordingMp3.Url regex </summary>
    [JsonProperty("recording_recordingMp3_url_reg")]
    public string? Recording_RecordingMp3_Url_REG { get; set; }

    /// <summary> Recording.RecordingMp3.Id equals </summary>
    [JsonProperty("recording_recordingMp3_id_eq")]
    public string? Recording_RecordingMp3_Id_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.Id contains </summary>
    [JsonProperty("recording_recordingMp3_id_con")]
    public string? Recording_RecordingMp3_Id_CON { get; set; }
    /// <summary> Recording.RecordingMp3.Id regex </summary>
    [JsonProperty("recording_recordingMp3_id_reg")]
    public string? Recording_RecordingMp3_Id_REG { get; set; }


    /// <summary> Recording.RecordingDurationInSeconds equals </summary>
    [JsonProperty("recording_recordingDurationInSeconds_eq")]
    public System.Int32? Recording_RecordingDurationInSeconds_EQ { get; set; }
    /// <summary> Recording.RecordingDurationInSeconds less than or equal to </summary>
    [JsonProperty("recording_recordingDurationInSeconds_lte")]
    public System.Int32? Recording_RecordingDurationInSeconds_LTE { get; set; }
    /// <summary> Recording.RecordingDurationInSeconds greater than or equal to </summary>
    [JsonProperty("recording_recordingDurationInSeconds_gte")]
    public System.Int32? Recording_RecordingDurationInSeconds_GTE { get; set; }

    /// <summary> Recording.Id equals </summary>
    [JsonProperty("recording_id_eq")]
    public string? Recording_Id_EQ { get; set; }
    /// <summary> Recording.Id contains </summary>
    [JsonProperty("recording_id_con")]
    public string? Recording_Id_CON { get; set; }
    /// <summary> Recording.Id regex </summary>
    [JsonProperty("recording_id_reg")]
    public string? Recording_Id_REG { get; set; }


    /// <summary> DisabledVideo equals </summary>
    [JsonProperty("disabledVideo_eq")]
    public bool? DisabledVideo_EQ { get; set; }

    /// <summary> DigitsSent equals </summary>
    [JsonProperty("digitsSent_eq")]
    public string? DigitsSent_EQ { get; set; }
    /// <summary> DigitsSent contains </summary>
    [JsonProperty("digitsSent_con")]
    public string? DigitsSent_CON { get; set; }
    /// <summary> DigitsSent regex </summary>
    [JsonProperty("digitsSent_reg")]
    public string? DigitsSent_REG { get; set; }

    /// <summary> IsInternational equals </summary>
    [JsonProperty("isInternational_eq")]
    public bool? IsInternational_EQ { get; set; }

    /// <summary> DateEnded equals </summary>
    [JsonProperty("dateEnded_eq")]
    public DateTime? DateEnded_EQ { get; set; }
    /// <summary> DateEnded less than or equal to </summary>
    [JsonProperty("dateEnded_lte")]
    public DateTime? DateEnded_LTE { get; set; }
    /// <summary> DateEnded greater than or equal to </summary>
    [JsonProperty("dateEnded_gte")]
    public DateTime? DateEnded_GTE { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for CallIncomingToExtensions </summary>
public class CallIncomingToExtensionFilterRequest 
{
    /// <summary> Extension.IdMusicOnHoldGroup equals </summary>
    [JsonProperty("extension_idMusicOnHoldGroup_eq")]
    public string? Extension_IdMusicOnHoldGroup_EQ { get; set; }
    /// <summary> Extension.IdMusicOnHoldGroup contains </summary>
    [JsonProperty("extension_idMusicOnHoldGroup_con")]
    public string? Extension_IdMusicOnHoldGroup_CON { get; set; }
    /// <summary> Extension.IdMusicOnHoldGroup regex </summary>
    [JsonProperty("extension_idMusicOnHoldGroup_reg")]
    public string? Extension_IdMusicOnHoldGroup_REG { get; set; }

    /// <summary> Extension.ExtensionType equals </summary>
    [JsonProperty("extension_extensionType_eq")]
    public ExtensionType? Extension_ExtensionType_EQ { get; set; }

    /// <summary> Extension.FriendlyName equals </summary>
    [JsonProperty("extension_friendlyName_eq")]
    public string? Extension_FriendlyName_EQ { get; set; }
    /// <summary> Extension.FriendlyName contains </summary>
    [JsonProperty("extension_friendlyName_con")]
    public string? Extension_FriendlyName_CON { get; set; }
    /// <summary> Extension.FriendlyName regex </summary>
    [JsonProperty("extension_friendlyName_reg")]
    public string? Extension_FriendlyName_REG { get; set; }

    /// <summary> Extension.Number equals </summary>
    [JsonProperty("extension_number_eq")]
    public string? Extension_Number_EQ { get; set; }
    /// <summary> Extension.Number contains </summary>
    [JsonProperty("extension_number_con")]
    public string? Extension_Number_CON { get; set; }
    /// <summary> Extension.Number regex </summary>
    [JsonProperty("extension_number_reg")]
    public string? Extension_Number_REG { get; set; }

    /// <summary> Extension.InjectExtensionNameToCallerId equals </summary>
    [JsonProperty("extension_injectExtensionNameToCallerId_eq")]
    public bool? Extension_InjectExtensionNameToCallerId_EQ { get; set; }

    /// <summary> Extension.Id equals </summary>
    [JsonProperty("extension_id_eq")]
    public string? Extension_Id_EQ { get; set; }
    /// <summary> Extension.Id contains </summary>
    [JsonProperty("extension_id_con")]
    public string? Extension_Id_CON { get; set; }
    /// <summary> Extension.Id regex </summary>
    [JsonProperty("extension_id_reg")]
    public string? Extension_Id_REG { get; set; }

    /// <summary> Extension.DateCreated equals </summary>
    [JsonProperty("extension_dateCreated_eq")]
    public DateTime? Extension_DateCreated_EQ { get; set; }
    /// <summary> Extension.DateCreated less than or equal to </summary>
    [JsonProperty("extension_dateCreated_lte")]
    public DateTime? Extension_DateCreated_LTE { get; set; }
    /// <summary> Extension.DateCreated greater than or equal to </summary>
    [JsonProperty("extension_dateCreated_gte")]
    public DateTime? Extension_DateCreated_GTE { get; set; }

    /// <summary> Extension.DateUpdated equals </summary>
    [JsonProperty("extension_dateUpdated_eq")]
    public DateTime? Extension_DateUpdated_EQ { get; set; }
    /// <summary> Extension.DateUpdated less than or equal to </summary>
    [JsonProperty("extension_dateUpdated_lte")]
    public DateTime? Extension_DateUpdated_LTE { get; set; }
    /// <summary> Extension.DateUpdated greater than or equal to </summary>
    [JsonProperty("extension_dateUpdated_gte")]
    public DateTime? Extension_DateUpdated_GTE { get; set; }


    /// <summary> LineThatAnswered.FriendlyName equals </summary>
    [JsonProperty("lineThatAnswered_friendlyName_eq")]
    public string? LineThatAnswered_FriendlyName_EQ { get; set; }
    /// <summary> LineThatAnswered.FriendlyName contains </summary>
    [JsonProperty("lineThatAnswered_friendlyName_con")]
    public string? LineThatAnswered_FriendlyName_CON { get; set; }
    /// <summary> LineThatAnswered.FriendlyName regex </summary>
    [JsonProperty("lineThatAnswered_friendlyName_reg")]
    public string? LineThatAnswered_FriendlyName_REG { get; set; }

    /// <summary> LineThatAnswered.LineConnectionStatus.IpWAN equals </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_ipWAN_eq")]
    public string? LineThatAnswered_LineConnectionStatus_IpWAN_EQ { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.IpWAN contains </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_ipWAN_con")]
    public string? LineThatAnswered_LineConnectionStatus_IpWAN_CON { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.IpWAN regex </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_ipWAN_reg")]
    public string? LineThatAnswered_LineConnectionStatus_IpWAN_REG { get; set; }

    /// <summary> LineThatAnswered.LineConnectionStatus.PortWAN equals </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_portWAN_eq")]
    public System.Int32? LineThatAnswered_LineConnectionStatus_PortWAN_EQ { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.PortWAN less than or equal to </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_portWAN_lte")]
    public System.Int32? LineThatAnswered_LineConnectionStatus_PortWAN_LTE { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.PortWAN greater than or equal to </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_portWAN_gte")]
    public System.Int32? LineThatAnswered_LineConnectionStatus_PortWAN_GTE { get; set; }

    /// <summary> LineThatAnswered.LineConnectionStatus.IpLAN equals </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_ipLAN_eq")]
    public string? LineThatAnswered_LineConnectionStatus_IpLAN_EQ { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.IpLAN contains </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_ipLAN_con")]
    public string? LineThatAnswered_LineConnectionStatus_IpLAN_CON { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.IpLAN regex </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_ipLAN_reg")]
    public string? LineThatAnswered_LineConnectionStatus_IpLAN_REG { get; set; }

    /// <summary> LineThatAnswered.LineConnectionStatus.PortLAN equals </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_portLAN_eq")]
    public System.Int32? LineThatAnswered_LineConnectionStatus_PortLAN_EQ { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.PortLAN less than or equal to </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_portLAN_lte")]
    public System.Int32? LineThatAnswered_LineConnectionStatus_PortLAN_LTE { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.PortLAN greater than or equal to </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_portLAN_gte")]
    public System.Int32? LineThatAnswered_LineConnectionStatus_PortLAN_GTE { get; set; }

    /// <summary> LineThatAnswered.LineConnectionStatus.UserAgent equals </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_userAgent_eq")]
    public string? LineThatAnswered_LineConnectionStatus_UserAgent_EQ { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.UserAgent contains </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_userAgent_con")]
    public string? LineThatAnswered_LineConnectionStatus_UserAgent_CON { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.UserAgent regex </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_userAgent_reg")]
    public string? LineThatAnswered_LineConnectionStatus_UserAgent_REG { get; set; }

    /// <summary> LineThatAnswered.LineConnectionStatus.IsConnected equals </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_isConnected_eq")]
    public bool? LineThatAnswered_LineConnectionStatus_IsConnected_EQ { get; set; }

    /// <summary> LineThatAnswered.LineConnectionStatus.DisconnectedReason equals </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_disconnectedReason_eq")]
    public string? LineThatAnswered_LineConnectionStatus_DisconnectedReason_EQ { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.DisconnectedReason contains </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_disconnectedReason_con")]
    public string? LineThatAnswered_LineConnectionStatus_DisconnectedReason_CON { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.DisconnectedReason regex </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_disconnectedReason_reg")]
    public string? LineThatAnswered_LineConnectionStatus_DisconnectedReason_REG { get; set; }

    /// <summary> LineThatAnswered.LineConnectionStatus.DateConnected equals </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_dateConnected_eq")]
    public DateTime? LineThatAnswered_LineConnectionStatus_DateConnected_EQ { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.DateConnected less than or equal to </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_dateConnected_lte")]
    public DateTime? LineThatAnswered_LineConnectionStatus_DateConnected_LTE { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.DateConnected greater than or equal to </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_dateConnected_gte")]
    public DateTime? LineThatAnswered_LineConnectionStatus_DateConnected_GTE { get; set; }

    /// <summary> LineThatAnswered.LineConnectionStatus.DateDisconnected equals </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_dateDisconnected_eq")]
    public DateTime? LineThatAnswered_LineConnectionStatus_DateDisconnected_EQ { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.DateDisconnected less than or equal to </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_dateDisconnected_lte")]
    public DateTime? LineThatAnswered_LineConnectionStatus_DateDisconnected_LTE { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.DateDisconnected greater than or equal to </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_dateDisconnected_gte")]
    public DateTime? LineThatAnswered_LineConnectionStatus_DateDisconnected_GTE { get; set; }


    /// <summary> LineThatAnswered.CallerIdNumber equals </summary>
    [JsonProperty("lineThatAnswered_callerIdNumber_eq")]
    public string? LineThatAnswered_CallerIdNumber_EQ { get; set; }
    /// <summary> LineThatAnswered.CallerIdNumber contains </summary>
    [JsonProperty("lineThatAnswered_callerIdNumber_con")]
    public string? LineThatAnswered_CallerIdNumber_CON { get; set; }
    /// <summary> LineThatAnswered.CallerIdNumber regex </summary>
    [JsonProperty("lineThatAnswered_callerIdNumber_reg")]
    public string? LineThatAnswered_CallerIdNumber_REG { get; set; }

    /// <summary> LineThatAnswered.RecordExternalCalls equals </summary>
    [JsonProperty("lineThatAnswered_recordExternalCalls_eq")]
    public bool? LineThatAnswered_RecordExternalCalls_EQ { get; set; }

    /// <summary> LineThatAnswered.RecordInternalCalls equals </summary>
    [JsonProperty("lineThatAnswered_recordInternalCalls_eq")]
    public bool? LineThatAnswered_RecordInternalCalls_EQ { get; set; }

    /// <summary> LineThatAnswered.Language equals </summary>
    [JsonProperty("lineThatAnswered_language_eq")]
    public Language? LineThatAnswered_Language_EQ { get; set; }

    /// <summary> LineThatAnswered.Id equals </summary>
    [JsonProperty("lineThatAnswered_id_eq")]
    public string? LineThatAnswered_Id_EQ { get; set; }
    /// <summary> LineThatAnswered.Id contains </summary>
    [JsonProperty("lineThatAnswered_id_con")]
    public string? LineThatAnswered_Id_CON { get; set; }
    /// <summary> LineThatAnswered.Id regex </summary>
    [JsonProperty("lineThatAnswered_id_reg")]
    public string? LineThatAnswered_Id_REG { get; set; }


    /// <summary> LinesThatRing.FriendlyName equals </summary>
    [JsonProperty("linesThatRing_friendlyName_eq")]
    public string? LinesThatRing_FriendlyName_EQ { get; set; }
    /// <summary> LinesThatRing.FriendlyName contains </summary>
    [JsonProperty("linesThatRing_friendlyName_con")]
    public string? LinesThatRing_FriendlyName_CON { get; set; }
    /// <summary> LinesThatRing.FriendlyName regex </summary>
    [JsonProperty("linesThatRing_friendlyName_reg")]
    public string? LinesThatRing_FriendlyName_REG { get; set; }

    /// <summary> LinesThatRing.LineConnectionStatus.IpWAN equals </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_ipWAN_eq")]
    public string? LinesThatRing_LineConnectionStatus_IpWAN_EQ { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.IpWAN contains </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_ipWAN_con")]
    public string? LinesThatRing_LineConnectionStatus_IpWAN_CON { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.IpWAN regex </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_ipWAN_reg")]
    public string? LinesThatRing_LineConnectionStatus_IpWAN_REG { get; set; }

    /// <summary> LinesThatRing.LineConnectionStatus.PortWAN equals </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_portWAN_eq")]
    public System.Int32? LinesThatRing_LineConnectionStatus_PortWAN_EQ { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.PortWAN less than or equal to </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_portWAN_lte")]
    public System.Int32? LinesThatRing_LineConnectionStatus_PortWAN_LTE { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.PortWAN greater than or equal to </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_portWAN_gte")]
    public System.Int32? LinesThatRing_LineConnectionStatus_PortWAN_GTE { get; set; }

    /// <summary> LinesThatRing.LineConnectionStatus.IpLAN equals </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_ipLAN_eq")]
    public string? LinesThatRing_LineConnectionStatus_IpLAN_EQ { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.IpLAN contains </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_ipLAN_con")]
    public string? LinesThatRing_LineConnectionStatus_IpLAN_CON { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.IpLAN regex </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_ipLAN_reg")]
    public string? LinesThatRing_LineConnectionStatus_IpLAN_REG { get; set; }

    /// <summary> LinesThatRing.LineConnectionStatus.PortLAN equals </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_portLAN_eq")]
    public System.Int32? LinesThatRing_LineConnectionStatus_PortLAN_EQ { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.PortLAN less than or equal to </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_portLAN_lte")]
    public System.Int32? LinesThatRing_LineConnectionStatus_PortLAN_LTE { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.PortLAN greater than or equal to </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_portLAN_gte")]
    public System.Int32? LinesThatRing_LineConnectionStatus_PortLAN_GTE { get; set; }

    /// <summary> LinesThatRing.LineConnectionStatus.UserAgent equals </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_userAgent_eq")]
    public string? LinesThatRing_LineConnectionStatus_UserAgent_EQ { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.UserAgent contains </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_userAgent_con")]
    public string? LinesThatRing_LineConnectionStatus_UserAgent_CON { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.UserAgent regex </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_userAgent_reg")]
    public string? LinesThatRing_LineConnectionStatus_UserAgent_REG { get; set; }

    /// <summary> LinesThatRing.LineConnectionStatus.IsConnected equals </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_isConnected_eq")]
    public bool? LinesThatRing_LineConnectionStatus_IsConnected_EQ { get; set; }

    /// <summary> LinesThatRing.LineConnectionStatus.DisconnectedReason equals </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_disconnectedReason_eq")]
    public string? LinesThatRing_LineConnectionStatus_DisconnectedReason_EQ { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.DisconnectedReason contains </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_disconnectedReason_con")]
    public string? LinesThatRing_LineConnectionStatus_DisconnectedReason_CON { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.DisconnectedReason regex </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_disconnectedReason_reg")]
    public string? LinesThatRing_LineConnectionStatus_DisconnectedReason_REG { get; set; }

    /// <summary> LinesThatRing.LineConnectionStatus.DateConnected equals </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_dateConnected_eq")]
    public DateTime? LinesThatRing_LineConnectionStatus_DateConnected_EQ { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.DateConnected less than or equal to </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_dateConnected_lte")]
    public DateTime? LinesThatRing_LineConnectionStatus_DateConnected_LTE { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.DateConnected greater than or equal to </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_dateConnected_gte")]
    public DateTime? LinesThatRing_LineConnectionStatus_DateConnected_GTE { get; set; }

    /// <summary> LinesThatRing.LineConnectionStatus.DateDisconnected equals </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_dateDisconnected_eq")]
    public DateTime? LinesThatRing_LineConnectionStatus_DateDisconnected_EQ { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.DateDisconnected less than or equal to </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_dateDisconnected_lte")]
    public DateTime? LinesThatRing_LineConnectionStatus_DateDisconnected_LTE { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.DateDisconnected greater than or equal to </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_dateDisconnected_gte")]
    public DateTime? LinesThatRing_LineConnectionStatus_DateDisconnected_GTE { get; set; }


    /// <summary> LinesThatRing.CallerIdNumber equals </summary>
    [JsonProperty("linesThatRing_callerIdNumber_eq")]
    public string? LinesThatRing_CallerIdNumber_EQ { get; set; }
    /// <summary> LinesThatRing.CallerIdNumber contains </summary>
    [JsonProperty("linesThatRing_callerIdNumber_con")]
    public string? LinesThatRing_CallerIdNumber_CON { get; set; }
    /// <summary> LinesThatRing.CallerIdNumber regex </summary>
    [JsonProperty("linesThatRing_callerIdNumber_reg")]
    public string? LinesThatRing_CallerIdNumber_REG { get; set; }

    /// <summary> LinesThatRing.RecordExternalCalls equals </summary>
    [JsonProperty("linesThatRing_recordExternalCalls_eq")]
    public bool? LinesThatRing_RecordExternalCalls_EQ { get; set; }

    /// <summary> LinesThatRing.RecordInternalCalls equals </summary>
    [JsonProperty("linesThatRing_recordInternalCalls_eq")]
    public bool? LinesThatRing_RecordInternalCalls_EQ { get; set; }

    /// <summary> LinesThatRing.Language equals </summary>
    [JsonProperty("linesThatRing_language_eq")]
    public Language? LinesThatRing_Language_EQ { get; set; }

    /// <summary> LinesThatRing.Id equals </summary>
    [JsonProperty("linesThatRing_id_eq")]
    public string? LinesThatRing_Id_EQ { get; set; }
    /// <summary> LinesThatRing.Id contains </summary>
    [JsonProperty("linesThatRing_id_con")]
    public string? LinesThatRing_Id_CON { get; set; }
    /// <summary> LinesThatRing.Id regex </summary>
    [JsonProperty("linesThatRing_id_reg")]
    public string? LinesThatRing_Id_REG { get; set; }


    /// <summary> LinesThatDidNotRing.FriendlyName equals </summary>
    [JsonProperty("linesThatDidNotRing_friendlyName_eq")]
    public string? LinesThatDidNotRing_FriendlyName_EQ { get; set; }
    /// <summary> LinesThatDidNotRing.FriendlyName contains </summary>
    [JsonProperty("linesThatDidNotRing_friendlyName_con")]
    public string? LinesThatDidNotRing_FriendlyName_CON { get; set; }
    /// <summary> LinesThatDidNotRing.FriendlyName regex </summary>
    [JsonProperty("linesThatDidNotRing_friendlyName_reg")]
    public string? LinesThatDidNotRing_FriendlyName_REG { get; set; }

    /// <summary> LinesThatDidNotRing.LineConnectionStatus.IpWAN equals </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_ipWAN_eq")]
    public string? LinesThatDidNotRing_LineConnectionStatus_IpWAN_EQ { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.IpWAN contains </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_ipWAN_con")]
    public string? LinesThatDidNotRing_LineConnectionStatus_IpWAN_CON { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.IpWAN regex </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_ipWAN_reg")]
    public string? LinesThatDidNotRing_LineConnectionStatus_IpWAN_REG { get; set; }

    /// <summary> LinesThatDidNotRing.LineConnectionStatus.PortWAN equals </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_portWAN_eq")]
    public System.Int32? LinesThatDidNotRing_LineConnectionStatus_PortWAN_EQ { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.PortWAN less than or equal to </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_portWAN_lte")]
    public System.Int32? LinesThatDidNotRing_LineConnectionStatus_PortWAN_LTE { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.PortWAN greater than or equal to </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_portWAN_gte")]
    public System.Int32? LinesThatDidNotRing_LineConnectionStatus_PortWAN_GTE { get; set; }

    /// <summary> LinesThatDidNotRing.LineConnectionStatus.IpLAN equals </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_ipLAN_eq")]
    public string? LinesThatDidNotRing_LineConnectionStatus_IpLAN_EQ { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.IpLAN contains </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_ipLAN_con")]
    public string? LinesThatDidNotRing_LineConnectionStatus_IpLAN_CON { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.IpLAN regex </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_ipLAN_reg")]
    public string? LinesThatDidNotRing_LineConnectionStatus_IpLAN_REG { get; set; }

    /// <summary> LinesThatDidNotRing.LineConnectionStatus.PortLAN equals </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_portLAN_eq")]
    public System.Int32? LinesThatDidNotRing_LineConnectionStatus_PortLAN_EQ { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.PortLAN less than or equal to </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_portLAN_lte")]
    public System.Int32? LinesThatDidNotRing_LineConnectionStatus_PortLAN_LTE { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.PortLAN greater than or equal to </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_portLAN_gte")]
    public System.Int32? LinesThatDidNotRing_LineConnectionStatus_PortLAN_GTE { get; set; }

    /// <summary> LinesThatDidNotRing.LineConnectionStatus.UserAgent equals </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_userAgent_eq")]
    public string? LinesThatDidNotRing_LineConnectionStatus_UserAgent_EQ { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.UserAgent contains </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_userAgent_con")]
    public string? LinesThatDidNotRing_LineConnectionStatus_UserAgent_CON { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.UserAgent regex </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_userAgent_reg")]
    public string? LinesThatDidNotRing_LineConnectionStatus_UserAgent_REG { get; set; }

    /// <summary> LinesThatDidNotRing.LineConnectionStatus.IsConnected equals </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_isConnected_eq")]
    public bool? LinesThatDidNotRing_LineConnectionStatus_IsConnected_EQ { get; set; }

    /// <summary> LinesThatDidNotRing.LineConnectionStatus.DisconnectedReason equals </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_disconnectedReason_eq")]
    public string? LinesThatDidNotRing_LineConnectionStatus_DisconnectedReason_EQ { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.DisconnectedReason contains </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_disconnectedReason_con")]
    public string? LinesThatDidNotRing_LineConnectionStatus_DisconnectedReason_CON { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.DisconnectedReason regex </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_disconnectedReason_reg")]
    public string? LinesThatDidNotRing_LineConnectionStatus_DisconnectedReason_REG { get; set; }

    /// <summary> LinesThatDidNotRing.LineConnectionStatus.DateConnected equals </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_dateConnected_eq")]
    public DateTime? LinesThatDidNotRing_LineConnectionStatus_DateConnected_EQ { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.DateConnected less than or equal to </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_dateConnected_lte")]
    public DateTime? LinesThatDidNotRing_LineConnectionStatus_DateConnected_LTE { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.DateConnected greater than or equal to </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_dateConnected_gte")]
    public DateTime? LinesThatDidNotRing_LineConnectionStatus_DateConnected_GTE { get; set; }

    /// <summary> LinesThatDidNotRing.LineConnectionStatus.DateDisconnected equals </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_dateDisconnected_eq")]
    public DateTime? LinesThatDidNotRing_LineConnectionStatus_DateDisconnected_EQ { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.DateDisconnected less than or equal to </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_dateDisconnected_lte")]
    public DateTime? LinesThatDidNotRing_LineConnectionStatus_DateDisconnected_LTE { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.DateDisconnected greater than or equal to </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_dateDisconnected_gte")]
    public DateTime? LinesThatDidNotRing_LineConnectionStatus_DateDisconnected_GTE { get; set; }


    /// <summary> LinesThatDidNotRing.CallerIdNumber equals </summary>
    [JsonProperty("linesThatDidNotRing_callerIdNumber_eq")]
    public string? LinesThatDidNotRing_CallerIdNumber_EQ { get; set; }
    /// <summary> LinesThatDidNotRing.CallerIdNumber contains </summary>
    [JsonProperty("linesThatDidNotRing_callerIdNumber_con")]
    public string? LinesThatDidNotRing_CallerIdNumber_CON { get; set; }
    /// <summary> LinesThatDidNotRing.CallerIdNumber regex </summary>
    [JsonProperty("linesThatDidNotRing_callerIdNumber_reg")]
    public string? LinesThatDidNotRing_CallerIdNumber_REG { get; set; }

    /// <summary> LinesThatDidNotRing.RecordExternalCalls equals </summary>
    [JsonProperty("linesThatDidNotRing_recordExternalCalls_eq")]
    public bool? LinesThatDidNotRing_RecordExternalCalls_EQ { get; set; }

    /// <summary> LinesThatDidNotRing.RecordInternalCalls equals </summary>
    [JsonProperty("linesThatDidNotRing_recordInternalCalls_eq")]
    public bool? LinesThatDidNotRing_RecordInternalCalls_EQ { get; set; }

    /// <summary> LinesThatDidNotRing.Language equals </summary>
    [JsonProperty("linesThatDidNotRing_language_eq")]
    public Language? LinesThatDidNotRing_Language_EQ { get; set; }

    /// <summary> LinesThatDidNotRing.Id equals </summary>
    [JsonProperty("linesThatDidNotRing_id_eq")]
    public string? LinesThatDidNotRing_Id_EQ { get; set; }
    /// <summary> LinesThatDidNotRing.Id contains </summary>
    [JsonProperty("linesThatDidNotRing_id_con")]
    public string? LinesThatDidNotRing_Id_CON { get; set; }
    /// <summary> LinesThatDidNotRing.Id regex </summary>
    [JsonProperty("linesThatDidNotRing_id_reg")]
    public string? LinesThatDidNotRing_Id_REG { get; set; }


    /// <summary> CallType equals </summary>
    [JsonProperty("callType_eq")]
    public CallType? CallType_EQ { get; set; }

    /// <summary> Contact.IdIdentityUser equals </summary>
    [JsonProperty("contact_idIdentityUser_eq")]
    public string? Contact_IdIdentityUser_EQ { get; set; }
    /// <summary> Contact.IdIdentityUser contains </summary>
    [JsonProperty("contact_idIdentityUser_con")]
    public string? Contact_IdIdentityUser_CON { get; set; }
    /// <summary> Contact.IdIdentityUser regex </summary>
    [JsonProperty("contact_idIdentityUser_reg")]
    public string? Contact_IdIdentityUser_REG { get; set; }

    /// <summary> Contact.ContactNumbers.SearchIndex equals </summary>
    [JsonProperty("contact_contactNumbers_searchIndex_eq")]
    public string? Contact_ContactNumbers_SearchIndex_EQ { get; set; }
    /// <summary> Contact.ContactNumbers.SearchIndex contains </summary>
    [JsonProperty("contact_contactNumbers_searchIndex_con")]
    public string? Contact_ContactNumbers_SearchIndex_CON { get; set; }
    /// <summary> Contact.ContactNumbers.SearchIndex regex </summary>
    [JsonProperty("contact_contactNumbers_searchIndex_reg")]
    public string? Contact_ContactNumbers_SearchIndex_REG { get; set; }

    /// <summary> Contact.ContactNumbers.Number equals </summary>
    [JsonProperty("contact_contactNumbers_number_eq")]
    public string? Contact_ContactNumbers_Number_EQ { get; set; }
    /// <summary> Contact.ContactNumbers.Number contains </summary>
    [JsonProperty("contact_contactNumbers_number_con")]
    public string? Contact_ContactNumbers_Number_CON { get; set; }
    /// <summary> Contact.ContactNumbers.Number regex </summary>
    [JsonProperty("contact_contactNumbers_number_reg")]
    public string? Contact_ContactNumbers_Number_REG { get; set; }

    /// <summary> Contact.ContactNumbers.NumberInternationalFormat equals </summary>
    [JsonProperty("contact_contactNumbers_numberInternationalFormat_eq")]
    public string? Contact_ContactNumbers_NumberInternationalFormat_EQ { get; set; }
    /// <summary> Contact.ContactNumbers.NumberInternationalFormat contains </summary>
    [JsonProperty("contact_contactNumbers_numberInternationalFormat_con")]
    public string? Contact_ContactNumbers_NumberInternationalFormat_CON { get; set; }
    /// <summary> Contact.ContactNumbers.NumberInternationalFormat regex </summary>
    [JsonProperty("contact_contactNumbers_numberInternationalFormat_reg")]
    public string? Contact_ContactNumbers_NumberInternationalFormat_REG { get; set; }

    /// <summary> Contact.ContactNumbers.Label equals </summary>
    [JsonProperty("contact_contactNumbers_label_eq")]
    public LabelNumber? Contact_ContactNumbers_Label_EQ { get; set; }


    /// <summary> Contact.ContactEmails.SearchIndex equals </summary>
    [JsonProperty("contact_contactEmails_searchIndex_eq")]
    public string? Contact_ContactEmails_SearchIndex_EQ { get; set; }
    /// <summary> Contact.ContactEmails.SearchIndex contains </summary>
    [JsonProperty("contact_contactEmails_searchIndex_con")]
    public string? Contact_ContactEmails_SearchIndex_CON { get; set; }
    /// <summary> Contact.ContactEmails.SearchIndex regex </summary>
    [JsonProperty("contact_contactEmails_searchIndex_reg")]
    public string? Contact_ContactEmails_SearchIndex_REG { get; set; }

    /// <summary> Contact.ContactEmails.Email equals </summary>
    [JsonProperty("contact_contactEmails_email_eq")]
    public string? Contact_ContactEmails_Email_EQ { get; set; }
    /// <summary> Contact.ContactEmails.Email contains </summary>
    [JsonProperty("contact_contactEmails_email_con")]
    public string? Contact_ContactEmails_Email_CON { get; set; }
    /// <summary> Contact.ContactEmails.Email regex </summary>
    [JsonProperty("contact_contactEmails_email_reg")]
    public string? Contact_ContactEmails_Email_REG { get; set; }

    /// <summary> Contact.ContactEmails.Label equals </summary>
    [JsonProperty("contact_contactEmails_label_eq")]
    public LabelEmailType? Contact_ContactEmails_Label_EQ { get; set; }


    /// <summary> Contact.FirstName equals </summary>
    [JsonProperty("contact_firstName_eq")]
    public string? Contact_FirstName_EQ { get; set; }
    /// <summary> Contact.FirstName contains </summary>
    [JsonProperty("contact_firstName_con")]
    public string? Contact_FirstName_CON { get; set; }
    /// <summary> Contact.FirstName regex </summary>
    [JsonProperty("contact_firstName_reg")]
    public string? Contact_FirstName_REG { get; set; }

    /// <summary> Contact.LastName equals </summary>
    [JsonProperty("contact_lastName_eq")]
    public string? Contact_LastName_EQ { get; set; }
    /// <summary> Contact.LastName contains </summary>
    [JsonProperty("contact_lastName_con")]
    public string? Contact_LastName_CON { get; set; }
    /// <summary> Contact.LastName regex </summary>
    [JsonProperty("contact_lastName_reg")]
    public string? Contact_LastName_REG { get; set; }

    /// <summary> Contact.JobTittle equals </summary>
    [JsonProperty("contact_jobTittle_eq")]
    public string? Contact_JobTittle_EQ { get; set; }
    /// <summary> Contact.JobTittle contains </summary>
    [JsonProperty("contact_jobTittle_con")]
    public string? Contact_JobTittle_CON { get; set; }
    /// <summary> Contact.JobTittle regex </summary>
    [JsonProperty("contact_jobTittle_reg")]
    public string? Contact_JobTittle_REG { get; set; }

    /// <summary> Contact.Company equals </summary>
    [JsonProperty("contact_company_eq")]
    public string? Contact_Company_EQ { get; set; }
    /// <summary> Contact.Company contains </summary>
    [JsonProperty("contact_company_con")]
    public string? Contact_Company_CON { get; set; }
    /// <summary> Contact.Company regex </summary>
    [JsonProperty("contact_company_reg")]
    public string? Contact_Company_REG { get; set; }

    /// <summary> Contact.Hash equals </summary>
    [JsonProperty("contact_hash_eq")]
    public string? Contact_Hash_EQ { get; set; }
    /// <summary> Contact.Hash contains </summary>
    [JsonProperty("contact_hash_con")]
    public string? Contact_Hash_CON { get; set; }
    /// <summary> Contact.Hash regex </summary>
    [JsonProperty("contact_hash_reg")]
    public string? Contact_Hash_REG { get; set; }

    /// <summary> Contact.Notes equals </summary>
    [JsonProperty("contact_notes_eq")]
    public string? Contact_Notes_EQ { get; set; }
    /// <summary> Contact.Notes contains </summary>
    [JsonProperty("contact_notes_con")]
    public string? Contact_Notes_CON { get; set; }
    /// <summary> Contact.Notes regex </summary>
    [JsonProperty("contact_notes_reg")]
    public string? Contact_Notes_REG { get; set; }

    /// <summary> Contact.Variables.Name equals </summary>
    [JsonProperty("contact_variables_name_eq")]
    public string? Contact_Variables_Name_EQ { get; set; }
    /// <summary> Contact.Variables.Name contains </summary>
    [JsonProperty("contact_variables_name_con")]
    public string? Contact_Variables_Name_CON { get; set; }
    /// <summary> Contact.Variables.Name regex </summary>
    [JsonProperty("contact_variables_name_reg")]
    public string? Contact_Variables_Name_REG { get; set; }

    /// <summary> Contact.Variables.JsonValue equals </summary>
    [JsonProperty("contact_variables_jsonValue_eq")]
    public string? Contact_Variables_JsonValue_EQ { get; set; }
    /// <summary> Contact.Variables.JsonValue contains </summary>
    [JsonProperty("contact_variables_jsonValue_con")]
    public string? Contact_Variables_JsonValue_CON { get; set; }
    /// <summary> Contact.Variables.JsonValue regex </summary>
    [JsonProperty("contact_variables_jsonValue_reg")]
    public string? Contact_Variables_JsonValue_REG { get; set; }


    /// <summary> Contact.Id equals </summary>
    [JsonProperty("contact_id_eq")]
    public string? Contact_Id_EQ { get; set; }
    /// <summary> Contact.Id contains </summary>
    [JsonProperty("contact_id_con")]
    public string? Contact_Id_CON { get; set; }
    /// <summary> Contact.Id regex </summary>
    [JsonProperty("contact_id_reg")]
    public string? Contact_Id_REG { get; set; }

    /// <summary> Contact.DateCreated equals </summary>
    [JsonProperty("contact_dateCreated_eq")]
    public DateTime? Contact_DateCreated_EQ { get; set; }
    /// <summary> Contact.DateCreated less than or equal to </summary>
    [JsonProperty("contact_dateCreated_lte")]
    public DateTime? Contact_DateCreated_LTE { get; set; }
    /// <summary> Contact.DateCreated greater than or equal to </summary>
    [JsonProperty("contact_dateCreated_gte")]
    public DateTime? Contact_DateCreated_GTE { get; set; }

    /// <summary> Contact.DateUpdated equals </summary>
    [JsonProperty("contact_dateUpdated_eq")]
    public DateTime? Contact_DateUpdated_EQ { get; set; }
    /// <summary> Contact.DateUpdated less than or equal to </summary>
    [JsonProperty("contact_dateUpdated_lte")]
    public DateTime? Contact_DateUpdated_LTE { get; set; }
    /// <summary> Contact.DateUpdated greater than or equal to </summary>
    [JsonProperty("contact_dateUpdated_gte")]
    public DateTime? Contact_DateUpdated_GTE { get; set; }


    /// <summary> IdVoipNumberPhone equals </summary>
    [JsonProperty("idVoipNumberPhone_eq")]
    public string? IdVoipNumberPhone_EQ { get; set; }
    /// <summary> IdVoipNumberPhone contains </summary>
    [JsonProperty("idVoipNumberPhone_con")]
    public string? IdVoipNumberPhone_CON { get; set; }
    /// <summary> IdVoipNumberPhone regex </summary>
    [JsonProperty("idVoipNumberPhone_reg")]
    public string? IdVoipNumberPhone_REG { get; set; }

    /// <summary> FromInternationalFormat equals </summary>
    [JsonProperty("fromInternationalFormat_eq")]
    public string? FromInternationalFormat_EQ { get; set; }
    /// <summary> FromInternationalFormat contains </summary>
    [JsonProperty("fromInternationalFormat_con")]
    public string? FromInternationalFormat_CON { get; set; }
    /// <summary> FromInternationalFormat regex </summary>
    [JsonProperty("fromInternationalFormat_reg")]
    public string? FromInternationalFormat_REG { get; set; }

    /// <summary> IdVoicemail equals </summary>
    [JsonProperty("idVoicemail_eq")]
    public string? IdVoicemail_EQ { get; set; }
    /// <summary> IdVoicemail contains </summary>
    [JsonProperty("idVoicemail_con")]
    public string? IdVoicemail_CON { get; set; }
    /// <summary> IdVoicemail regex </summary>
    [JsonProperty("idVoicemail_reg")]
    public string? IdVoicemail_REG { get; set; }

    /// <summary> IdCallThatTerminatedThisCallDoToAttendantTransfer equals </summary>
    [JsonProperty("idCallThatTerminatedThisCallDoToAttendantTransfer_eq")]
    public string? IdCallThatTerminatedThisCallDoToAttendantTransfer_EQ { get; set; }
    /// <summary> IdCallThatTerminatedThisCallDoToAttendantTransfer contains </summary>
    [JsonProperty("idCallThatTerminatedThisCallDoToAttendantTransfer_con")]
    public string? IdCallThatTerminatedThisCallDoToAttendantTransfer_CON { get; set; }
    /// <summary> IdCallThatTerminatedThisCallDoToAttendantTransfer regex </summary>
    [JsonProperty("idCallThatTerminatedThisCallDoToAttendantTransfer_reg")]
    public string? IdCallThatTerminatedThisCallDoToAttendantTransfer_REG { get; set; }

    /// <summary> ChannelVariables.Language equals </summary>
    [JsonProperty("channelVariables_language_eq")]
    public Language? ChannelVariables_Language_EQ { get; set; }

    /// <summary> ChannelVariables.IdMusicOnHold equals </summary>
    [JsonProperty("channelVariables_idMusicOnHold_eq")]
    public string? ChannelVariables_IdMusicOnHold_EQ { get; set; }
    /// <summary> ChannelVariables.IdMusicOnHold contains </summary>
    [JsonProperty("channelVariables_idMusicOnHold_con")]
    public string? ChannelVariables_IdMusicOnHold_CON { get; set; }
    /// <summary> ChannelVariables.IdMusicOnHold regex </summary>
    [JsonProperty("channelVariables_idMusicOnHold_reg")]
    public string? ChannelVariables_IdMusicOnHold_REG { get; set; }

    /// <summary> ChannelVariables.CallerIdName equals </summary>
    [JsonProperty("channelVariables_callerIdName_eq")]
    public string? ChannelVariables_CallerIdName_EQ { get; set; }
    /// <summary> ChannelVariables.CallerIdName contains </summary>
    [JsonProperty("channelVariables_callerIdName_con")]
    public string? ChannelVariables_CallerIdName_CON { get; set; }
    /// <summary> ChannelVariables.CallerIdName regex </summary>
    [JsonProperty("channelVariables_callerIdName_reg")]
    public string? ChannelVariables_CallerIdName_REG { get; set; }

    /// <summary> ChannelVariables.CallerIdNumber equals </summary>
    [JsonProperty("channelVariables_callerIdNumber_eq")]
    public string? ChannelVariables_CallerIdNumber_EQ { get; set; }
    /// <summary> ChannelVariables.CallerIdNumber contains </summary>
    [JsonProperty("channelVariables_callerIdNumber_con")]
    public string? ChannelVariables_CallerIdNumber_CON { get; set; }
    /// <summary> ChannelVariables.CallerIdNumber regex </summary>
    [JsonProperty("channelVariables_callerIdNumber_reg")]
    public string? ChannelVariables_CallerIdNumber_REG { get; set; }


    /// <summary> ChildCalls.ChildCallType equals </summary>
    [JsonProperty("childCalls_childCallType_eq")]
    public ChildCallType? ChildCalls_ChildCallType_EQ { get; set; }

    /// <summary> ChildCalls.DialStatus equals </summary>
    [JsonProperty("childCalls_dialStatus_eq")]
    public string? ChildCalls_DialStatus_EQ { get; set; }
    /// <summary> ChildCalls.DialStatus contains </summary>
    [JsonProperty("childCalls_dialStatus_con")]
    public string? ChildCalls_DialStatus_CON { get; set; }
    /// <summary> ChildCalls.DialStatus regex </summary>
    [JsonProperty("childCalls_dialStatus_reg")]
    public string? ChildCalls_DialStatus_REG { get; set; }

    /// <summary> ChildCalls.DateCreated equals </summary>
    [JsonProperty("childCalls_dateCreated_eq")]
    public DateTime? ChildCalls_DateCreated_EQ { get; set; }
    /// <summary> ChildCalls.DateCreated less than or equal to </summary>
    [JsonProperty("childCalls_dateCreated_lte")]
    public DateTime? ChildCalls_DateCreated_LTE { get; set; }
    /// <summary> ChildCalls.DateCreated greater than or equal to </summary>
    [JsonProperty("childCalls_dateCreated_gte")]
    public DateTime? ChildCalls_DateCreated_GTE { get; set; }

    /// <summary> ChildCalls.DateEnded equals </summary>
    [JsonProperty("childCalls_dateEnded_eq")]
    public DateTime? ChildCalls_DateEnded_EQ { get; set; }
    /// <summary> ChildCalls.DateEnded less than or equal to </summary>
    [JsonProperty("childCalls_dateEnded_lte")]
    public DateTime? ChildCalls_DateEnded_LTE { get; set; }
    /// <summary> ChildCalls.DateEnded greater than or equal to </summary>
    [JsonProperty("childCalls_dateEnded_gte")]
    public DateTime? ChildCalls_DateEnded_GTE { get; set; }

    /// <summary> ChildCalls.SecondsItTookToAnswer equals </summary>
    [JsonProperty("childCalls_secondsItTookToAnswer_eq")]
    public System.Int32? ChildCalls_SecondsItTookToAnswer_EQ { get; set; }
    /// <summary> ChildCalls.SecondsItTookToAnswer less than or equal to </summary>
    [JsonProperty("childCalls_secondsItTookToAnswer_lte")]
    public System.Int32? ChildCalls_SecondsItTookToAnswer_LTE { get; set; }
    /// <summary> ChildCalls.SecondsItTookToAnswer greater than or equal to </summary>
    [JsonProperty("childCalls_secondsItTookToAnswer_gte")]
    public System.Int32? ChildCalls_SecondsItTookToAnswer_GTE { get; set; }


    /// <summary> DialStatus equals </summary>
    [JsonProperty("dialStatus_eq")]
    public string? DialStatus_EQ { get; set; }
    /// <summary> DialStatus contains </summary>
    [JsonProperty("dialStatus_con")]
    public string? DialStatus_CON { get; set; }
    /// <summary> DialStatus regex </summary>
    [JsonProperty("dialStatus_reg")]
    public string? DialStatus_REG { get; set; }

    /// <summary> SecondsItTookToAnswer equals </summary>
    [JsonProperty("secondsItTookToAnswer_eq")]
    public System.Int32? SecondsItTookToAnswer_EQ { get; set; }
    /// <summary> SecondsItTookToAnswer less than or equal to </summary>
    [JsonProperty("secondsItTookToAnswer_lte")]
    public System.Int32? SecondsItTookToAnswer_LTE { get; set; }
    /// <summary> SecondsItTookToAnswer greater than or equal to </summary>
    [JsonProperty("secondsItTookToAnswer_gte")]
    public System.Int32? SecondsItTookToAnswer_GTE { get; set; }

    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenPlacedOnHold equals </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenPlacedOnHold_eq")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenPlacedOnHold_EQ { get; set; }
    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenPlacedOnHold less than or equal to </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenPlacedOnHold_lte")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenPlacedOnHold_LTE { get; set; }
    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenPlacedOnHold greater than or equal to </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenPlacedOnHold_gte")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenPlacedOnHold_GTE { get; set; }

    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenRemovedFromHold equals </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenRemovedFromHold_eq")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenRemovedFromHold_EQ { get; set; }
    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenRemovedFromHold less than or equal to </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenRemovedFromHold_lte")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenRemovedFromHold_LTE { get; set; }
    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenRemovedFromHold greater than or equal to </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenRemovedFromHold_gte")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenRemovedFromHold_GTE { get; set; }


    /// <summary> From equals </summary>
    [JsonProperty("from_eq")]
    public string? From_EQ { get; set; }
    /// <summary> From contains </summary>
    [JsonProperty("from_con")]
    public string? From_CON { get; set; }
    /// <summary> From regex </summary>
    [JsonProperty("from_reg")]
    public string? From_REG { get; set; }

    /// <summary> FromCountry equals </summary>
    [JsonProperty("fromCountry_eq")]
    public CountryIsoCode? FromCountry_EQ { get; set; }

    /// <summary> To equals </summary>
    [JsonProperty("to_eq")]
    public string? To_EQ { get; set; }
    /// <summary> To contains </summary>
    [JsonProperty("to_con")]
    public string? To_CON { get; set; }
    /// <summary> To regex </summary>
    [JsonProperty("to_reg")]
    public string? To_REG { get; set; }

    /// <summary> ToCountry equals </summary>
    [JsonProperty("toCountry_eq")]
    public CountryIsoCode? ToCountry_EQ { get; set; }

    /// <summary> Recording.ErrorMessage equals </summary>
    [JsonProperty("recording_errorMessage_eq")]
    public string? Recording_ErrorMessage_EQ { get; set; }
    /// <summary> Recording.ErrorMessage contains </summary>
    [JsonProperty("recording_errorMessage_con")]
    public string? Recording_ErrorMessage_CON { get; set; }
    /// <summary> Recording.ErrorMessage regex </summary>
    [JsonProperty("recording_errorMessage_reg")]
    public string? Recording_ErrorMessage_REG { get; set; }

    /// <summary> Recording.RecordingMp3.InstanceId equals </summary>
    [JsonProperty("recording_recordingMp3_instanceId_eq")]
    public string? Recording_RecordingMp3_InstanceId_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.InstanceId contains </summary>
    [JsonProperty("recording_recordingMp3_instanceId_con")]
    public string? Recording_RecordingMp3_InstanceId_CON { get; set; }
    /// <summary> Recording.RecordingMp3.InstanceId regex </summary>
    [JsonProperty("recording_recordingMp3_instanceId_reg")]
    public string? Recording_RecordingMp3_InstanceId_REG { get; set; }

    /// <summary> Recording.RecordingMp3.FileSizeInBytes equals </summary>
    [JsonProperty("recording_recordingMp3_fileSizeInBytes_eq")]
    public System.Int32? Recording_RecordingMp3_FileSizeInBytes_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.FileSizeInBytes less than or equal to </summary>
    [JsonProperty("recording_recordingMp3_fileSizeInBytes_lte")]
    public System.Int32? Recording_RecordingMp3_FileSizeInBytes_LTE { get; set; }
    /// <summary> Recording.RecordingMp3.FileSizeInBytes greater than or equal to </summary>
    [JsonProperty("recording_recordingMp3_fileSizeInBytes_gte")]
    public System.Int32? Recording_RecordingMp3_FileSizeInBytes_GTE { get; set; }

    /// <summary> Recording.RecordingMp3.Md5Hash equals </summary>
    [JsonProperty("recording_recordingMp3_md5Hash_eq")]
    public string? Recording_RecordingMp3_Md5Hash_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.Md5Hash contains </summary>
    [JsonProperty("recording_recordingMp3_md5Hash_con")]
    public string? Recording_RecordingMp3_Md5Hash_CON { get; set; }
    /// <summary> Recording.RecordingMp3.Md5Hash regex </summary>
    [JsonProperty("recording_recordingMp3_md5Hash_reg")]
    public string? Recording_RecordingMp3_Md5Hash_REG { get; set; }

    /// <summary> Recording.RecordingMp3.Url equals </summary>
    [JsonProperty("recording_recordingMp3_url_eq")]
    public string? Recording_RecordingMp3_Url_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.Url contains </summary>
    [JsonProperty("recording_recordingMp3_url_con")]
    public string? Recording_RecordingMp3_Url_CON { get; set; }
    /// <summary> Recording.RecordingMp3.Url regex </summary>
    [JsonProperty("recording_recordingMp3_url_reg")]
    public string? Recording_RecordingMp3_Url_REG { get; set; }

    /// <summary> Recording.RecordingMp3.Id equals </summary>
    [JsonProperty("recording_recordingMp3_id_eq")]
    public string? Recording_RecordingMp3_Id_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.Id contains </summary>
    [JsonProperty("recording_recordingMp3_id_con")]
    public string? Recording_RecordingMp3_Id_CON { get; set; }
    /// <summary> Recording.RecordingMp3.Id regex </summary>
    [JsonProperty("recording_recordingMp3_id_reg")]
    public string? Recording_RecordingMp3_Id_REG { get; set; }


    /// <summary> Recording.RecordingDurationInSeconds equals </summary>
    [JsonProperty("recording_recordingDurationInSeconds_eq")]
    public System.Int32? Recording_RecordingDurationInSeconds_EQ { get; set; }
    /// <summary> Recording.RecordingDurationInSeconds less than or equal to </summary>
    [JsonProperty("recording_recordingDurationInSeconds_lte")]
    public System.Int32? Recording_RecordingDurationInSeconds_LTE { get; set; }
    /// <summary> Recording.RecordingDurationInSeconds greater than or equal to </summary>
    [JsonProperty("recording_recordingDurationInSeconds_gte")]
    public System.Int32? Recording_RecordingDurationInSeconds_GTE { get; set; }

    /// <summary> Recording.Id equals </summary>
    [JsonProperty("recording_id_eq")]
    public string? Recording_Id_EQ { get; set; }
    /// <summary> Recording.Id contains </summary>
    [JsonProperty("recording_id_con")]
    public string? Recording_Id_CON { get; set; }
    /// <summary> Recording.Id regex </summary>
    [JsonProperty("recording_id_reg")]
    public string? Recording_Id_REG { get; set; }


    /// <summary> DisabledVideo equals </summary>
    [JsonProperty("disabledVideo_eq")]
    public bool? DisabledVideo_EQ { get; set; }

    /// <summary> DigitsSent equals </summary>
    [JsonProperty("digitsSent_eq")]
    public string? DigitsSent_EQ { get; set; }
    /// <summary> DigitsSent contains </summary>
    [JsonProperty("digitsSent_con")]
    public string? DigitsSent_CON { get; set; }
    /// <summary> DigitsSent regex </summary>
    [JsonProperty("digitsSent_reg")]
    public string? DigitsSent_REG { get; set; }

    /// <summary> IsInternational equals </summary>
    [JsonProperty("isInternational_eq")]
    public bool? IsInternational_EQ { get; set; }

    /// <summary> DateEnded equals </summary>
    [JsonProperty("dateEnded_eq")]
    public DateTime? DateEnded_EQ { get; set; }
    /// <summary> DateEnded less than or equal to </summary>
    [JsonProperty("dateEnded_lte")]
    public DateTime? DateEnded_LTE { get; set; }
    /// <summary> DateEnded greater than or equal to </summary>
    [JsonProperty("dateEnded_gte")]
    public DateTime? DateEnded_GTE { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for CallOutgoingToExtensions </summary>
public class CallOutgoingToExtensionFilterRequest 
{
    /// <summary> Extension.IdMusicOnHoldGroup equals </summary>
    [JsonProperty("extension_idMusicOnHoldGroup_eq")]
    public string? Extension_IdMusicOnHoldGroup_EQ { get; set; }
    /// <summary> Extension.IdMusicOnHoldGroup contains </summary>
    [JsonProperty("extension_idMusicOnHoldGroup_con")]
    public string? Extension_IdMusicOnHoldGroup_CON { get; set; }
    /// <summary> Extension.IdMusicOnHoldGroup regex </summary>
    [JsonProperty("extension_idMusicOnHoldGroup_reg")]
    public string? Extension_IdMusicOnHoldGroup_REG { get; set; }

    /// <summary> Extension.ExtensionType equals </summary>
    [JsonProperty("extension_extensionType_eq")]
    public ExtensionType? Extension_ExtensionType_EQ { get; set; }

    /// <summary> Extension.FriendlyName equals </summary>
    [JsonProperty("extension_friendlyName_eq")]
    public string? Extension_FriendlyName_EQ { get; set; }
    /// <summary> Extension.FriendlyName contains </summary>
    [JsonProperty("extension_friendlyName_con")]
    public string? Extension_FriendlyName_CON { get; set; }
    /// <summary> Extension.FriendlyName regex </summary>
    [JsonProperty("extension_friendlyName_reg")]
    public string? Extension_FriendlyName_REG { get; set; }

    /// <summary> Extension.Number equals </summary>
    [JsonProperty("extension_number_eq")]
    public string? Extension_Number_EQ { get; set; }
    /// <summary> Extension.Number contains </summary>
    [JsonProperty("extension_number_con")]
    public string? Extension_Number_CON { get; set; }
    /// <summary> Extension.Number regex </summary>
    [JsonProperty("extension_number_reg")]
    public string? Extension_Number_REG { get; set; }

    /// <summary> Extension.InjectExtensionNameToCallerId equals </summary>
    [JsonProperty("extension_injectExtensionNameToCallerId_eq")]
    public bool? Extension_InjectExtensionNameToCallerId_EQ { get; set; }

    /// <summary> Extension.Id equals </summary>
    [JsonProperty("extension_id_eq")]
    public string? Extension_Id_EQ { get; set; }
    /// <summary> Extension.Id contains </summary>
    [JsonProperty("extension_id_con")]
    public string? Extension_Id_CON { get; set; }
    /// <summary> Extension.Id regex </summary>
    [JsonProperty("extension_id_reg")]
    public string? Extension_Id_REG { get; set; }

    /// <summary> Extension.DateCreated equals </summary>
    [JsonProperty("extension_dateCreated_eq")]
    public DateTime? Extension_DateCreated_EQ { get; set; }
    /// <summary> Extension.DateCreated less than or equal to </summary>
    [JsonProperty("extension_dateCreated_lte")]
    public DateTime? Extension_DateCreated_LTE { get; set; }
    /// <summary> Extension.DateCreated greater than or equal to </summary>
    [JsonProperty("extension_dateCreated_gte")]
    public DateTime? Extension_DateCreated_GTE { get; set; }

    /// <summary> Extension.DateUpdated equals </summary>
    [JsonProperty("extension_dateUpdated_eq")]
    public DateTime? Extension_DateUpdated_EQ { get; set; }
    /// <summary> Extension.DateUpdated less than or equal to </summary>
    [JsonProperty("extension_dateUpdated_lte")]
    public DateTime? Extension_DateUpdated_LTE { get; set; }
    /// <summary> Extension.DateUpdated greater than or equal to </summary>
    [JsonProperty("extension_dateUpdated_gte")]
    public DateTime? Extension_DateUpdated_GTE { get; set; }


    /// <summary> LineThatAnswered.FriendlyName equals </summary>
    [JsonProperty("lineThatAnswered_friendlyName_eq")]
    public string? LineThatAnswered_FriendlyName_EQ { get; set; }
    /// <summary> LineThatAnswered.FriendlyName contains </summary>
    [JsonProperty("lineThatAnswered_friendlyName_con")]
    public string? LineThatAnswered_FriendlyName_CON { get; set; }
    /// <summary> LineThatAnswered.FriendlyName regex </summary>
    [JsonProperty("lineThatAnswered_friendlyName_reg")]
    public string? LineThatAnswered_FriendlyName_REG { get; set; }

    /// <summary> LineThatAnswered.LineConnectionStatus.IpWAN equals </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_ipWAN_eq")]
    public string? LineThatAnswered_LineConnectionStatus_IpWAN_EQ { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.IpWAN contains </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_ipWAN_con")]
    public string? LineThatAnswered_LineConnectionStatus_IpWAN_CON { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.IpWAN regex </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_ipWAN_reg")]
    public string? LineThatAnswered_LineConnectionStatus_IpWAN_REG { get; set; }

    /// <summary> LineThatAnswered.LineConnectionStatus.PortWAN equals </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_portWAN_eq")]
    public System.Int32? LineThatAnswered_LineConnectionStatus_PortWAN_EQ { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.PortWAN less than or equal to </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_portWAN_lte")]
    public System.Int32? LineThatAnswered_LineConnectionStatus_PortWAN_LTE { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.PortWAN greater than or equal to </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_portWAN_gte")]
    public System.Int32? LineThatAnswered_LineConnectionStatus_PortWAN_GTE { get; set; }

    /// <summary> LineThatAnswered.LineConnectionStatus.IpLAN equals </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_ipLAN_eq")]
    public string? LineThatAnswered_LineConnectionStatus_IpLAN_EQ { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.IpLAN contains </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_ipLAN_con")]
    public string? LineThatAnswered_LineConnectionStatus_IpLAN_CON { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.IpLAN regex </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_ipLAN_reg")]
    public string? LineThatAnswered_LineConnectionStatus_IpLAN_REG { get; set; }

    /// <summary> LineThatAnswered.LineConnectionStatus.PortLAN equals </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_portLAN_eq")]
    public System.Int32? LineThatAnswered_LineConnectionStatus_PortLAN_EQ { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.PortLAN less than or equal to </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_portLAN_lte")]
    public System.Int32? LineThatAnswered_LineConnectionStatus_PortLAN_LTE { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.PortLAN greater than or equal to </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_portLAN_gte")]
    public System.Int32? LineThatAnswered_LineConnectionStatus_PortLAN_GTE { get; set; }

    /// <summary> LineThatAnswered.LineConnectionStatus.UserAgent equals </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_userAgent_eq")]
    public string? LineThatAnswered_LineConnectionStatus_UserAgent_EQ { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.UserAgent contains </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_userAgent_con")]
    public string? LineThatAnswered_LineConnectionStatus_UserAgent_CON { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.UserAgent regex </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_userAgent_reg")]
    public string? LineThatAnswered_LineConnectionStatus_UserAgent_REG { get; set; }

    /// <summary> LineThatAnswered.LineConnectionStatus.IsConnected equals </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_isConnected_eq")]
    public bool? LineThatAnswered_LineConnectionStatus_IsConnected_EQ { get; set; }

    /// <summary> LineThatAnswered.LineConnectionStatus.DisconnectedReason equals </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_disconnectedReason_eq")]
    public string? LineThatAnswered_LineConnectionStatus_DisconnectedReason_EQ { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.DisconnectedReason contains </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_disconnectedReason_con")]
    public string? LineThatAnswered_LineConnectionStatus_DisconnectedReason_CON { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.DisconnectedReason regex </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_disconnectedReason_reg")]
    public string? LineThatAnswered_LineConnectionStatus_DisconnectedReason_REG { get; set; }

    /// <summary> LineThatAnswered.LineConnectionStatus.DateConnected equals </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_dateConnected_eq")]
    public DateTime? LineThatAnswered_LineConnectionStatus_DateConnected_EQ { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.DateConnected less than or equal to </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_dateConnected_lte")]
    public DateTime? LineThatAnswered_LineConnectionStatus_DateConnected_LTE { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.DateConnected greater than or equal to </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_dateConnected_gte")]
    public DateTime? LineThatAnswered_LineConnectionStatus_DateConnected_GTE { get; set; }

    /// <summary> LineThatAnswered.LineConnectionStatus.DateDisconnected equals </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_dateDisconnected_eq")]
    public DateTime? LineThatAnswered_LineConnectionStatus_DateDisconnected_EQ { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.DateDisconnected less than or equal to </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_dateDisconnected_lte")]
    public DateTime? LineThatAnswered_LineConnectionStatus_DateDisconnected_LTE { get; set; }
    /// <summary> LineThatAnswered.LineConnectionStatus.DateDisconnected greater than or equal to </summary>
    [JsonProperty("lineThatAnswered_lineConnectionStatus_dateDisconnected_gte")]
    public DateTime? LineThatAnswered_LineConnectionStatus_DateDisconnected_GTE { get; set; }


    /// <summary> LineThatAnswered.CallerIdNumber equals </summary>
    [JsonProperty("lineThatAnswered_callerIdNumber_eq")]
    public string? LineThatAnswered_CallerIdNumber_EQ { get; set; }
    /// <summary> LineThatAnswered.CallerIdNumber contains </summary>
    [JsonProperty("lineThatAnswered_callerIdNumber_con")]
    public string? LineThatAnswered_CallerIdNumber_CON { get; set; }
    /// <summary> LineThatAnswered.CallerIdNumber regex </summary>
    [JsonProperty("lineThatAnswered_callerIdNumber_reg")]
    public string? LineThatAnswered_CallerIdNumber_REG { get; set; }

    /// <summary> LineThatAnswered.RecordExternalCalls equals </summary>
    [JsonProperty("lineThatAnswered_recordExternalCalls_eq")]
    public bool? LineThatAnswered_RecordExternalCalls_EQ { get; set; }

    /// <summary> LineThatAnswered.RecordInternalCalls equals </summary>
    [JsonProperty("lineThatAnswered_recordInternalCalls_eq")]
    public bool? LineThatAnswered_RecordInternalCalls_EQ { get; set; }

    /// <summary> LineThatAnswered.Language equals </summary>
    [JsonProperty("lineThatAnswered_language_eq")]
    public Language? LineThatAnswered_Language_EQ { get; set; }

    /// <summary> LineThatAnswered.Id equals </summary>
    [JsonProperty("lineThatAnswered_id_eq")]
    public string? LineThatAnswered_Id_EQ { get; set; }
    /// <summary> LineThatAnswered.Id contains </summary>
    [JsonProperty("lineThatAnswered_id_con")]
    public string? LineThatAnswered_Id_CON { get; set; }
    /// <summary> LineThatAnswered.Id regex </summary>
    [JsonProperty("lineThatAnswered_id_reg")]
    public string? LineThatAnswered_Id_REG { get; set; }


    /// <summary> LinesThatRing.FriendlyName equals </summary>
    [JsonProperty("linesThatRing_friendlyName_eq")]
    public string? LinesThatRing_FriendlyName_EQ { get; set; }
    /// <summary> LinesThatRing.FriendlyName contains </summary>
    [JsonProperty("linesThatRing_friendlyName_con")]
    public string? LinesThatRing_FriendlyName_CON { get; set; }
    /// <summary> LinesThatRing.FriendlyName regex </summary>
    [JsonProperty("linesThatRing_friendlyName_reg")]
    public string? LinesThatRing_FriendlyName_REG { get; set; }

    /// <summary> LinesThatRing.LineConnectionStatus.IpWAN equals </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_ipWAN_eq")]
    public string? LinesThatRing_LineConnectionStatus_IpWAN_EQ { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.IpWAN contains </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_ipWAN_con")]
    public string? LinesThatRing_LineConnectionStatus_IpWAN_CON { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.IpWAN regex </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_ipWAN_reg")]
    public string? LinesThatRing_LineConnectionStatus_IpWAN_REG { get; set; }

    /// <summary> LinesThatRing.LineConnectionStatus.PortWAN equals </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_portWAN_eq")]
    public System.Int32? LinesThatRing_LineConnectionStatus_PortWAN_EQ { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.PortWAN less than or equal to </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_portWAN_lte")]
    public System.Int32? LinesThatRing_LineConnectionStatus_PortWAN_LTE { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.PortWAN greater than or equal to </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_portWAN_gte")]
    public System.Int32? LinesThatRing_LineConnectionStatus_PortWAN_GTE { get; set; }

    /// <summary> LinesThatRing.LineConnectionStatus.IpLAN equals </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_ipLAN_eq")]
    public string? LinesThatRing_LineConnectionStatus_IpLAN_EQ { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.IpLAN contains </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_ipLAN_con")]
    public string? LinesThatRing_LineConnectionStatus_IpLAN_CON { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.IpLAN regex </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_ipLAN_reg")]
    public string? LinesThatRing_LineConnectionStatus_IpLAN_REG { get; set; }

    /// <summary> LinesThatRing.LineConnectionStatus.PortLAN equals </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_portLAN_eq")]
    public System.Int32? LinesThatRing_LineConnectionStatus_PortLAN_EQ { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.PortLAN less than or equal to </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_portLAN_lte")]
    public System.Int32? LinesThatRing_LineConnectionStatus_PortLAN_LTE { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.PortLAN greater than or equal to </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_portLAN_gte")]
    public System.Int32? LinesThatRing_LineConnectionStatus_PortLAN_GTE { get; set; }

    /// <summary> LinesThatRing.LineConnectionStatus.UserAgent equals </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_userAgent_eq")]
    public string? LinesThatRing_LineConnectionStatus_UserAgent_EQ { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.UserAgent contains </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_userAgent_con")]
    public string? LinesThatRing_LineConnectionStatus_UserAgent_CON { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.UserAgent regex </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_userAgent_reg")]
    public string? LinesThatRing_LineConnectionStatus_UserAgent_REG { get; set; }

    /// <summary> LinesThatRing.LineConnectionStatus.IsConnected equals </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_isConnected_eq")]
    public bool? LinesThatRing_LineConnectionStatus_IsConnected_EQ { get; set; }

    /// <summary> LinesThatRing.LineConnectionStatus.DisconnectedReason equals </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_disconnectedReason_eq")]
    public string? LinesThatRing_LineConnectionStatus_DisconnectedReason_EQ { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.DisconnectedReason contains </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_disconnectedReason_con")]
    public string? LinesThatRing_LineConnectionStatus_DisconnectedReason_CON { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.DisconnectedReason regex </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_disconnectedReason_reg")]
    public string? LinesThatRing_LineConnectionStatus_DisconnectedReason_REG { get; set; }

    /// <summary> LinesThatRing.LineConnectionStatus.DateConnected equals </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_dateConnected_eq")]
    public DateTime? LinesThatRing_LineConnectionStatus_DateConnected_EQ { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.DateConnected less than or equal to </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_dateConnected_lte")]
    public DateTime? LinesThatRing_LineConnectionStatus_DateConnected_LTE { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.DateConnected greater than or equal to </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_dateConnected_gte")]
    public DateTime? LinesThatRing_LineConnectionStatus_DateConnected_GTE { get; set; }

    /// <summary> LinesThatRing.LineConnectionStatus.DateDisconnected equals </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_dateDisconnected_eq")]
    public DateTime? LinesThatRing_LineConnectionStatus_DateDisconnected_EQ { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.DateDisconnected less than or equal to </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_dateDisconnected_lte")]
    public DateTime? LinesThatRing_LineConnectionStatus_DateDisconnected_LTE { get; set; }
    /// <summary> LinesThatRing.LineConnectionStatus.DateDisconnected greater than or equal to </summary>
    [JsonProperty("linesThatRing_lineConnectionStatus_dateDisconnected_gte")]
    public DateTime? LinesThatRing_LineConnectionStatus_DateDisconnected_GTE { get; set; }


    /// <summary> LinesThatRing.CallerIdNumber equals </summary>
    [JsonProperty("linesThatRing_callerIdNumber_eq")]
    public string? LinesThatRing_CallerIdNumber_EQ { get; set; }
    /// <summary> LinesThatRing.CallerIdNumber contains </summary>
    [JsonProperty("linesThatRing_callerIdNumber_con")]
    public string? LinesThatRing_CallerIdNumber_CON { get; set; }
    /// <summary> LinesThatRing.CallerIdNumber regex </summary>
    [JsonProperty("linesThatRing_callerIdNumber_reg")]
    public string? LinesThatRing_CallerIdNumber_REG { get; set; }

    /// <summary> LinesThatRing.RecordExternalCalls equals </summary>
    [JsonProperty("linesThatRing_recordExternalCalls_eq")]
    public bool? LinesThatRing_RecordExternalCalls_EQ { get; set; }

    /// <summary> LinesThatRing.RecordInternalCalls equals </summary>
    [JsonProperty("linesThatRing_recordInternalCalls_eq")]
    public bool? LinesThatRing_RecordInternalCalls_EQ { get; set; }

    /// <summary> LinesThatRing.Language equals </summary>
    [JsonProperty("linesThatRing_language_eq")]
    public Language? LinesThatRing_Language_EQ { get; set; }

    /// <summary> LinesThatRing.Id equals </summary>
    [JsonProperty("linesThatRing_id_eq")]
    public string? LinesThatRing_Id_EQ { get; set; }
    /// <summary> LinesThatRing.Id contains </summary>
    [JsonProperty("linesThatRing_id_con")]
    public string? LinesThatRing_Id_CON { get; set; }
    /// <summary> LinesThatRing.Id regex </summary>
    [JsonProperty("linesThatRing_id_reg")]
    public string? LinesThatRing_Id_REG { get; set; }


    /// <summary> LinesThatDidNotRing.FriendlyName equals </summary>
    [JsonProperty("linesThatDidNotRing_friendlyName_eq")]
    public string? LinesThatDidNotRing_FriendlyName_EQ { get; set; }
    /// <summary> LinesThatDidNotRing.FriendlyName contains </summary>
    [JsonProperty("linesThatDidNotRing_friendlyName_con")]
    public string? LinesThatDidNotRing_FriendlyName_CON { get; set; }
    /// <summary> LinesThatDidNotRing.FriendlyName regex </summary>
    [JsonProperty("linesThatDidNotRing_friendlyName_reg")]
    public string? LinesThatDidNotRing_FriendlyName_REG { get; set; }

    /// <summary> LinesThatDidNotRing.LineConnectionStatus.IpWAN equals </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_ipWAN_eq")]
    public string? LinesThatDidNotRing_LineConnectionStatus_IpWAN_EQ { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.IpWAN contains </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_ipWAN_con")]
    public string? LinesThatDidNotRing_LineConnectionStatus_IpWAN_CON { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.IpWAN regex </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_ipWAN_reg")]
    public string? LinesThatDidNotRing_LineConnectionStatus_IpWAN_REG { get; set; }

    /// <summary> LinesThatDidNotRing.LineConnectionStatus.PortWAN equals </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_portWAN_eq")]
    public System.Int32? LinesThatDidNotRing_LineConnectionStatus_PortWAN_EQ { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.PortWAN less than or equal to </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_portWAN_lte")]
    public System.Int32? LinesThatDidNotRing_LineConnectionStatus_PortWAN_LTE { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.PortWAN greater than or equal to </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_portWAN_gte")]
    public System.Int32? LinesThatDidNotRing_LineConnectionStatus_PortWAN_GTE { get; set; }

    /// <summary> LinesThatDidNotRing.LineConnectionStatus.IpLAN equals </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_ipLAN_eq")]
    public string? LinesThatDidNotRing_LineConnectionStatus_IpLAN_EQ { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.IpLAN contains </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_ipLAN_con")]
    public string? LinesThatDidNotRing_LineConnectionStatus_IpLAN_CON { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.IpLAN regex </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_ipLAN_reg")]
    public string? LinesThatDidNotRing_LineConnectionStatus_IpLAN_REG { get; set; }

    /// <summary> LinesThatDidNotRing.LineConnectionStatus.PortLAN equals </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_portLAN_eq")]
    public System.Int32? LinesThatDidNotRing_LineConnectionStatus_PortLAN_EQ { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.PortLAN less than or equal to </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_portLAN_lte")]
    public System.Int32? LinesThatDidNotRing_LineConnectionStatus_PortLAN_LTE { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.PortLAN greater than or equal to </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_portLAN_gte")]
    public System.Int32? LinesThatDidNotRing_LineConnectionStatus_PortLAN_GTE { get; set; }

    /// <summary> LinesThatDidNotRing.LineConnectionStatus.UserAgent equals </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_userAgent_eq")]
    public string? LinesThatDidNotRing_LineConnectionStatus_UserAgent_EQ { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.UserAgent contains </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_userAgent_con")]
    public string? LinesThatDidNotRing_LineConnectionStatus_UserAgent_CON { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.UserAgent regex </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_userAgent_reg")]
    public string? LinesThatDidNotRing_LineConnectionStatus_UserAgent_REG { get; set; }

    /// <summary> LinesThatDidNotRing.LineConnectionStatus.IsConnected equals </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_isConnected_eq")]
    public bool? LinesThatDidNotRing_LineConnectionStatus_IsConnected_EQ { get; set; }

    /// <summary> LinesThatDidNotRing.LineConnectionStatus.DisconnectedReason equals </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_disconnectedReason_eq")]
    public string? LinesThatDidNotRing_LineConnectionStatus_DisconnectedReason_EQ { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.DisconnectedReason contains </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_disconnectedReason_con")]
    public string? LinesThatDidNotRing_LineConnectionStatus_DisconnectedReason_CON { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.DisconnectedReason regex </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_disconnectedReason_reg")]
    public string? LinesThatDidNotRing_LineConnectionStatus_DisconnectedReason_REG { get; set; }

    /// <summary> LinesThatDidNotRing.LineConnectionStatus.DateConnected equals </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_dateConnected_eq")]
    public DateTime? LinesThatDidNotRing_LineConnectionStatus_DateConnected_EQ { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.DateConnected less than or equal to </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_dateConnected_lte")]
    public DateTime? LinesThatDidNotRing_LineConnectionStatus_DateConnected_LTE { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.DateConnected greater than or equal to </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_dateConnected_gte")]
    public DateTime? LinesThatDidNotRing_LineConnectionStatus_DateConnected_GTE { get; set; }

    /// <summary> LinesThatDidNotRing.LineConnectionStatus.DateDisconnected equals </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_dateDisconnected_eq")]
    public DateTime? LinesThatDidNotRing_LineConnectionStatus_DateDisconnected_EQ { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.DateDisconnected less than or equal to </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_dateDisconnected_lte")]
    public DateTime? LinesThatDidNotRing_LineConnectionStatus_DateDisconnected_LTE { get; set; }
    /// <summary> LinesThatDidNotRing.LineConnectionStatus.DateDisconnected greater than or equal to </summary>
    [JsonProperty("linesThatDidNotRing_lineConnectionStatus_dateDisconnected_gte")]
    public DateTime? LinesThatDidNotRing_LineConnectionStatus_DateDisconnected_GTE { get; set; }


    /// <summary> LinesThatDidNotRing.CallerIdNumber equals </summary>
    [JsonProperty("linesThatDidNotRing_callerIdNumber_eq")]
    public string? LinesThatDidNotRing_CallerIdNumber_EQ { get; set; }
    /// <summary> LinesThatDidNotRing.CallerIdNumber contains </summary>
    [JsonProperty("linesThatDidNotRing_callerIdNumber_con")]
    public string? LinesThatDidNotRing_CallerIdNumber_CON { get; set; }
    /// <summary> LinesThatDidNotRing.CallerIdNumber regex </summary>
    [JsonProperty("linesThatDidNotRing_callerIdNumber_reg")]
    public string? LinesThatDidNotRing_CallerIdNumber_REG { get; set; }

    /// <summary> LinesThatDidNotRing.RecordExternalCalls equals </summary>
    [JsonProperty("linesThatDidNotRing_recordExternalCalls_eq")]
    public bool? LinesThatDidNotRing_RecordExternalCalls_EQ { get; set; }

    /// <summary> LinesThatDidNotRing.RecordInternalCalls equals </summary>
    [JsonProperty("linesThatDidNotRing_recordInternalCalls_eq")]
    public bool? LinesThatDidNotRing_RecordInternalCalls_EQ { get; set; }

    /// <summary> LinesThatDidNotRing.Language equals </summary>
    [JsonProperty("linesThatDidNotRing_language_eq")]
    public Language? LinesThatDidNotRing_Language_EQ { get; set; }

    /// <summary> LinesThatDidNotRing.Id equals </summary>
    [JsonProperty("linesThatDidNotRing_id_eq")]
    public string? LinesThatDidNotRing_Id_EQ { get; set; }
    /// <summary> LinesThatDidNotRing.Id contains </summary>
    [JsonProperty("linesThatDidNotRing_id_con")]
    public string? LinesThatDidNotRing_Id_CON { get; set; }
    /// <summary> LinesThatDidNotRing.Id regex </summary>
    [JsonProperty("linesThatDidNotRing_id_reg")]
    public string? LinesThatDidNotRing_Id_REG { get; set; }


    /// <summary> CallType equals </summary>
    [JsonProperty("callType_eq")]
    public CallType? CallType_EQ { get; set; }

    /// <summary> Contact.IdIdentityUser equals </summary>
    [JsonProperty("contact_idIdentityUser_eq")]
    public string? Contact_IdIdentityUser_EQ { get; set; }
    /// <summary> Contact.IdIdentityUser contains </summary>
    [JsonProperty("contact_idIdentityUser_con")]
    public string? Contact_IdIdentityUser_CON { get; set; }
    /// <summary> Contact.IdIdentityUser regex </summary>
    [JsonProperty("contact_idIdentityUser_reg")]
    public string? Contact_IdIdentityUser_REG { get; set; }

    /// <summary> Contact.ContactNumbers.SearchIndex equals </summary>
    [JsonProperty("contact_contactNumbers_searchIndex_eq")]
    public string? Contact_ContactNumbers_SearchIndex_EQ { get; set; }
    /// <summary> Contact.ContactNumbers.SearchIndex contains </summary>
    [JsonProperty("contact_contactNumbers_searchIndex_con")]
    public string? Contact_ContactNumbers_SearchIndex_CON { get; set; }
    /// <summary> Contact.ContactNumbers.SearchIndex regex </summary>
    [JsonProperty("contact_contactNumbers_searchIndex_reg")]
    public string? Contact_ContactNumbers_SearchIndex_REG { get; set; }

    /// <summary> Contact.ContactNumbers.Number equals </summary>
    [JsonProperty("contact_contactNumbers_number_eq")]
    public string? Contact_ContactNumbers_Number_EQ { get; set; }
    /// <summary> Contact.ContactNumbers.Number contains </summary>
    [JsonProperty("contact_contactNumbers_number_con")]
    public string? Contact_ContactNumbers_Number_CON { get; set; }
    /// <summary> Contact.ContactNumbers.Number regex </summary>
    [JsonProperty("contact_contactNumbers_number_reg")]
    public string? Contact_ContactNumbers_Number_REG { get; set; }

    /// <summary> Contact.ContactNumbers.NumberInternationalFormat equals </summary>
    [JsonProperty("contact_contactNumbers_numberInternationalFormat_eq")]
    public string? Contact_ContactNumbers_NumberInternationalFormat_EQ { get; set; }
    /// <summary> Contact.ContactNumbers.NumberInternationalFormat contains </summary>
    [JsonProperty("contact_contactNumbers_numberInternationalFormat_con")]
    public string? Contact_ContactNumbers_NumberInternationalFormat_CON { get; set; }
    /// <summary> Contact.ContactNumbers.NumberInternationalFormat regex </summary>
    [JsonProperty("contact_contactNumbers_numberInternationalFormat_reg")]
    public string? Contact_ContactNumbers_NumberInternationalFormat_REG { get; set; }

    /// <summary> Contact.ContactNumbers.Label equals </summary>
    [JsonProperty("contact_contactNumbers_label_eq")]
    public LabelNumber? Contact_ContactNumbers_Label_EQ { get; set; }


    /// <summary> Contact.ContactEmails.SearchIndex equals </summary>
    [JsonProperty("contact_contactEmails_searchIndex_eq")]
    public string? Contact_ContactEmails_SearchIndex_EQ { get; set; }
    /// <summary> Contact.ContactEmails.SearchIndex contains </summary>
    [JsonProperty("contact_contactEmails_searchIndex_con")]
    public string? Contact_ContactEmails_SearchIndex_CON { get; set; }
    /// <summary> Contact.ContactEmails.SearchIndex regex </summary>
    [JsonProperty("contact_contactEmails_searchIndex_reg")]
    public string? Contact_ContactEmails_SearchIndex_REG { get; set; }

    /// <summary> Contact.ContactEmails.Email equals </summary>
    [JsonProperty("contact_contactEmails_email_eq")]
    public string? Contact_ContactEmails_Email_EQ { get; set; }
    /// <summary> Contact.ContactEmails.Email contains </summary>
    [JsonProperty("contact_contactEmails_email_con")]
    public string? Contact_ContactEmails_Email_CON { get; set; }
    /// <summary> Contact.ContactEmails.Email regex </summary>
    [JsonProperty("contact_contactEmails_email_reg")]
    public string? Contact_ContactEmails_Email_REG { get; set; }

    /// <summary> Contact.ContactEmails.Label equals </summary>
    [JsonProperty("contact_contactEmails_label_eq")]
    public LabelEmailType? Contact_ContactEmails_Label_EQ { get; set; }


    /// <summary> Contact.FirstName equals </summary>
    [JsonProperty("contact_firstName_eq")]
    public string? Contact_FirstName_EQ { get; set; }
    /// <summary> Contact.FirstName contains </summary>
    [JsonProperty("contact_firstName_con")]
    public string? Contact_FirstName_CON { get; set; }
    /// <summary> Contact.FirstName regex </summary>
    [JsonProperty("contact_firstName_reg")]
    public string? Contact_FirstName_REG { get; set; }

    /// <summary> Contact.LastName equals </summary>
    [JsonProperty("contact_lastName_eq")]
    public string? Contact_LastName_EQ { get; set; }
    /// <summary> Contact.LastName contains </summary>
    [JsonProperty("contact_lastName_con")]
    public string? Contact_LastName_CON { get; set; }
    /// <summary> Contact.LastName regex </summary>
    [JsonProperty("contact_lastName_reg")]
    public string? Contact_LastName_REG { get; set; }

    /// <summary> Contact.JobTittle equals </summary>
    [JsonProperty("contact_jobTittle_eq")]
    public string? Contact_JobTittle_EQ { get; set; }
    /// <summary> Contact.JobTittle contains </summary>
    [JsonProperty("contact_jobTittle_con")]
    public string? Contact_JobTittle_CON { get; set; }
    /// <summary> Contact.JobTittle regex </summary>
    [JsonProperty("contact_jobTittle_reg")]
    public string? Contact_JobTittle_REG { get; set; }

    /// <summary> Contact.Company equals </summary>
    [JsonProperty("contact_company_eq")]
    public string? Contact_Company_EQ { get; set; }
    /// <summary> Contact.Company contains </summary>
    [JsonProperty("contact_company_con")]
    public string? Contact_Company_CON { get; set; }
    /// <summary> Contact.Company regex </summary>
    [JsonProperty("contact_company_reg")]
    public string? Contact_Company_REG { get; set; }

    /// <summary> Contact.Hash equals </summary>
    [JsonProperty("contact_hash_eq")]
    public string? Contact_Hash_EQ { get; set; }
    /// <summary> Contact.Hash contains </summary>
    [JsonProperty("contact_hash_con")]
    public string? Contact_Hash_CON { get; set; }
    /// <summary> Contact.Hash regex </summary>
    [JsonProperty("contact_hash_reg")]
    public string? Contact_Hash_REG { get; set; }

    /// <summary> Contact.Notes equals </summary>
    [JsonProperty("contact_notes_eq")]
    public string? Contact_Notes_EQ { get; set; }
    /// <summary> Contact.Notes contains </summary>
    [JsonProperty("contact_notes_con")]
    public string? Contact_Notes_CON { get; set; }
    /// <summary> Contact.Notes regex </summary>
    [JsonProperty("contact_notes_reg")]
    public string? Contact_Notes_REG { get; set; }

    /// <summary> Contact.Variables.Name equals </summary>
    [JsonProperty("contact_variables_name_eq")]
    public string? Contact_Variables_Name_EQ { get; set; }
    /// <summary> Contact.Variables.Name contains </summary>
    [JsonProperty("contact_variables_name_con")]
    public string? Contact_Variables_Name_CON { get; set; }
    /// <summary> Contact.Variables.Name regex </summary>
    [JsonProperty("contact_variables_name_reg")]
    public string? Contact_Variables_Name_REG { get; set; }

    /// <summary> Contact.Variables.JsonValue equals </summary>
    [JsonProperty("contact_variables_jsonValue_eq")]
    public string? Contact_Variables_JsonValue_EQ { get; set; }
    /// <summary> Contact.Variables.JsonValue contains </summary>
    [JsonProperty("contact_variables_jsonValue_con")]
    public string? Contact_Variables_JsonValue_CON { get; set; }
    /// <summary> Contact.Variables.JsonValue regex </summary>
    [JsonProperty("contact_variables_jsonValue_reg")]
    public string? Contact_Variables_JsonValue_REG { get; set; }


    /// <summary> Contact.Id equals </summary>
    [JsonProperty("contact_id_eq")]
    public string? Contact_Id_EQ { get; set; }
    /// <summary> Contact.Id contains </summary>
    [JsonProperty("contact_id_con")]
    public string? Contact_Id_CON { get; set; }
    /// <summary> Contact.Id regex </summary>
    [JsonProperty("contact_id_reg")]
    public string? Contact_Id_REG { get; set; }

    /// <summary> Contact.DateCreated equals </summary>
    [JsonProperty("contact_dateCreated_eq")]
    public DateTime? Contact_DateCreated_EQ { get; set; }
    /// <summary> Contact.DateCreated less than or equal to </summary>
    [JsonProperty("contact_dateCreated_lte")]
    public DateTime? Contact_DateCreated_LTE { get; set; }
    /// <summary> Contact.DateCreated greater than or equal to </summary>
    [JsonProperty("contact_dateCreated_gte")]
    public DateTime? Contact_DateCreated_GTE { get; set; }

    /// <summary> Contact.DateUpdated equals </summary>
    [JsonProperty("contact_dateUpdated_eq")]
    public DateTime? Contact_DateUpdated_EQ { get; set; }
    /// <summary> Contact.DateUpdated less than or equal to </summary>
    [JsonProperty("contact_dateUpdated_lte")]
    public DateTime? Contact_DateUpdated_LTE { get; set; }
    /// <summary> Contact.DateUpdated greater than or equal to </summary>
    [JsonProperty("contact_dateUpdated_gte")]
    public DateTime? Contact_DateUpdated_GTE { get; set; }


    /// <summary> LineThatInitiatedCall.FriendlyName equals </summary>
    [JsonProperty("lineThatInitiatedCall_friendlyName_eq")]
    public string? LineThatInitiatedCall_FriendlyName_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.FriendlyName contains </summary>
    [JsonProperty("lineThatInitiatedCall_friendlyName_con")]
    public string? LineThatInitiatedCall_FriendlyName_CON { get; set; }
    /// <summary> LineThatInitiatedCall.FriendlyName regex </summary>
    [JsonProperty("lineThatInitiatedCall_friendlyName_reg")]
    public string? LineThatInitiatedCall_FriendlyName_REG { get; set; }

    /// <summary> LineThatInitiatedCall.LineConnectionStatus.IpWAN equals </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_ipWAN_eq")]
    public string? LineThatInitiatedCall_LineConnectionStatus_IpWAN_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.IpWAN contains </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_ipWAN_con")]
    public string? LineThatInitiatedCall_LineConnectionStatus_IpWAN_CON { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.IpWAN regex </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_ipWAN_reg")]
    public string? LineThatInitiatedCall_LineConnectionStatus_IpWAN_REG { get; set; }

    /// <summary> LineThatInitiatedCall.LineConnectionStatus.PortWAN equals </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_portWAN_eq")]
    public System.Int32? LineThatInitiatedCall_LineConnectionStatus_PortWAN_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.PortWAN less than or equal to </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_portWAN_lte")]
    public System.Int32? LineThatInitiatedCall_LineConnectionStatus_PortWAN_LTE { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.PortWAN greater than or equal to </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_portWAN_gte")]
    public System.Int32? LineThatInitiatedCall_LineConnectionStatus_PortWAN_GTE { get; set; }

    /// <summary> LineThatInitiatedCall.LineConnectionStatus.IpLAN equals </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_ipLAN_eq")]
    public string? LineThatInitiatedCall_LineConnectionStatus_IpLAN_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.IpLAN contains </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_ipLAN_con")]
    public string? LineThatInitiatedCall_LineConnectionStatus_IpLAN_CON { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.IpLAN regex </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_ipLAN_reg")]
    public string? LineThatInitiatedCall_LineConnectionStatus_IpLAN_REG { get; set; }

    /// <summary> LineThatInitiatedCall.LineConnectionStatus.PortLAN equals </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_portLAN_eq")]
    public System.Int32? LineThatInitiatedCall_LineConnectionStatus_PortLAN_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.PortLAN less than or equal to </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_portLAN_lte")]
    public System.Int32? LineThatInitiatedCall_LineConnectionStatus_PortLAN_LTE { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.PortLAN greater than or equal to </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_portLAN_gte")]
    public System.Int32? LineThatInitiatedCall_LineConnectionStatus_PortLAN_GTE { get; set; }

    /// <summary> LineThatInitiatedCall.LineConnectionStatus.UserAgent equals </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_userAgent_eq")]
    public string? LineThatInitiatedCall_LineConnectionStatus_UserAgent_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.UserAgent contains </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_userAgent_con")]
    public string? LineThatInitiatedCall_LineConnectionStatus_UserAgent_CON { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.UserAgent regex </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_userAgent_reg")]
    public string? LineThatInitiatedCall_LineConnectionStatus_UserAgent_REG { get; set; }

    /// <summary> LineThatInitiatedCall.LineConnectionStatus.IsConnected equals </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_isConnected_eq")]
    public bool? LineThatInitiatedCall_LineConnectionStatus_IsConnected_EQ { get; set; }

    /// <summary> LineThatInitiatedCall.LineConnectionStatus.DisconnectedReason equals </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_disconnectedReason_eq")]
    public string? LineThatInitiatedCall_LineConnectionStatus_DisconnectedReason_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.DisconnectedReason contains </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_disconnectedReason_con")]
    public string? LineThatInitiatedCall_LineConnectionStatus_DisconnectedReason_CON { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.DisconnectedReason regex </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_disconnectedReason_reg")]
    public string? LineThatInitiatedCall_LineConnectionStatus_DisconnectedReason_REG { get; set; }

    /// <summary> LineThatInitiatedCall.LineConnectionStatus.DateConnected equals </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_dateConnected_eq")]
    public DateTime? LineThatInitiatedCall_LineConnectionStatus_DateConnected_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.DateConnected less than or equal to </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_dateConnected_lte")]
    public DateTime? LineThatInitiatedCall_LineConnectionStatus_DateConnected_LTE { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.DateConnected greater than or equal to </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_dateConnected_gte")]
    public DateTime? LineThatInitiatedCall_LineConnectionStatus_DateConnected_GTE { get; set; }

    /// <summary> LineThatInitiatedCall.LineConnectionStatus.DateDisconnected equals </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_dateDisconnected_eq")]
    public DateTime? LineThatInitiatedCall_LineConnectionStatus_DateDisconnected_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.DateDisconnected less than or equal to </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_dateDisconnected_lte")]
    public DateTime? LineThatInitiatedCall_LineConnectionStatus_DateDisconnected_LTE { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.DateDisconnected greater than or equal to </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_dateDisconnected_gte")]
    public DateTime? LineThatInitiatedCall_LineConnectionStatus_DateDisconnected_GTE { get; set; }


    /// <summary> LineThatInitiatedCall.CallerIdNumber equals </summary>
    [JsonProperty("lineThatInitiatedCall_callerIdNumber_eq")]
    public string? LineThatInitiatedCall_CallerIdNumber_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.CallerIdNumber contains </summary>
    [JsonProperty("lineThatInitiatedCall_callerIdNumber_con")]
    public string? LineThatInitiatedCall_CallerIdNumber_CON { get; set; }
    /// <summary> LineThatInitiatedCall.CallerIdNumber regex </summary>
    [JsonProperty("lineThatInitiatedCall_callerIdNumber_reg")]
    public string? LineThatInitiatedCall_CallerIdNumber_REG { get; set; }

    /// <summary> LineThatInitiatedCall.RecordExternalCalls equals </summary>
    [JsonProperty("lineThatInitiatedCall_recordExternalCalls_eq")]
    public bool? LineThatInitiatedCall_RecordExternalCalls_EQ { get; set; }

    /// <summary> LineThatInitiatedCall.RecordInternalCalls equals </summary>
    [JsonProperty("lineThatInitiatedCall_recordInternalCalls_eq")]
    public bool? LineThatInitiatedCall_RecordInternalCalls_EQ { get; set; }

    /// <summary> LineThatInitiatedCall.Language equals </summary>
    [JsonProperty("lineThatInitiatedCall_language_eq")]
    public Language? LineThatInitiatedCall_Language_EQ { get; set; }

    /// <summary> LineThatInitiatedCall.Id equals </summary>
    [JsonProperty("lineThatInitiatedCall_id_eq")]
    public string? LineThatInitiatedCall_Id_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.Id contains </summary>
    [JsonProperty("lineThatInitiatedCall_id_con")]
    public string? LineThatInitiatedCall_Id_CON { get; set; }
    /// <summary> LineThatInitiatedCall.Id regex </summary>
    [JsonProperty("lineThatInitiatedCall_id_reg")]
    public string? LineThatInitiatedCall_Id_REG { get; set; }


    /// <summary> IdVoicemail equals </summary>
    [JsonProperty("idVoicemail_eq")]
    public string? IdVoicemail_EQ { get; set; }
    /// <summary> IdVoicemail contains </summary>
    [JsonProperty("idVoicemail_con")]
    public string? IdVoicemail_CON { get; set; }
    /// <summary> IdVoicemail regex </summary>
    [JsonProperty("idVoicemail_reg")]
    public string? IdVoicemail_REG { get; set; }

    /// <summary> IdCallThatTerminatedThisCallDoToAttendantTransfer equals </summary>
    [JsonProperty("idCallThatTerminatedThisCallDoToAttendantTransfer_eq")]
    public string? IdCallThatTerminatedThisCallDoToAttendantTransfer_EQ { get; set; }
    /// <summary> IdCallThatTerminatedThisCallDoToAttendantTransfer contains </summary>
    [JsonProperty("idCallThatTerminatedThisCallDoToAttendantTransfer_con")]
    public string? IdCallThatTerminatedThisCallDoToAttendantTransfer_CON { get; set; }
    /// <summary> IdCallThatTerminatedThisCallDoToAttendantTransfer regex </summary>
    [JsonProperty("idCallThatTerminatedThisCallDoToAttendantTransfer_reg")]
    public string? IdCallThatTerminatedThisCallDoToAttendantTransfer_REG { get; set; }

    /// <summary> ChannelVariables.Language equals </summary>
    [JsonProperty("channelVariables_language_eq")]
    public Language? ChannelVariables_Language_EQ { get; set; }

    /// <summary> ChannelVariables.IdMusicOnHold equals </summary>
    [JsonProperty("channelVariables_idMusicOnHold_eq")]
    public string? ChannelVariables_IdMusicOnHold_EQ { get; set; }
    /// <summary> ChannelVariables.IdMusicOnHold contains </summary>
    [JsonProperty("channelVariables_idMusicOnHold_con")]
    public string? ChannelVariables_IdMusicOnHold_CON { get; set; }
    /// <summary> ChannelVariables.IdMusicOnHold regex </summary>
    [JsonProperty("channelVariables_idMusicOnHold_reg")]
    public string? ChannelVariables_IdMusicOnHold_REG { get; set; }

    /// <summary> ChannelVariables.CallerIdName equals </summary>
    [JsonProperty("channelVariables_callerIdName_eq")]
    public string? ChannelVariables_CallerIdName_EQ { get; set; }
    /// <summary> ChannelVariables.CallerIdName contains </summary>
    [JsonProperty("channelVariables_callerIdName_con")]
    public string? ChannelVariables_CallerIdName_CON { get; set; }
    /// <summary> ChannelVariables.CallerIdName regex </summary>
    [JsonProperty("channelVariables_callerIdName_reg")]
    public string? ChannelVariables_CallerIdName_REG { get; set; }

    /// <summary> ChannelVariables.CallerIdNumber equals </summary>
    [JsonProperty("channelVariables_callerIdNumber_eq")]
    public string? ChannelVariables_CallerIdNumber_EQ { get; set; }
    /// <summary> ChannelVariables.CallerIdNumber contains </summary>
    [JsonProperty("channelVariables_callerIdNumber_con")]
    public string? ChannelVariables_CallerIdNumber_CON { get; set; }
    /// <summary> ChannelVariables.CallerIdNumber regex </summary>
    [JsonProperty("channelVariables_callerIdNumber_reg")]
    public string? ChannelVariables_CallerIdNumber_REG { get; set; }


    /// <summary> ChildCalls.ChildCallType equals </summary>
    [JsonProperty("childCalls_childCallType_eq")]
    public ChildCallType? ChildCalls_ChildCallType_EQ { get; set; }

    /// <summary> ChildCalls.DialStatus equals </summary>
    [JsonProperty("childCalls_dialStatus_eq")]
    public string? ChildCalls_DialStatus_EQ { get; set; }
    /// <summary> ChildCalls.DialStatus contains </summary>
    [JsonProperty("childCalls_dialStatus_con")]
    public string? ChildCalls_DialStatus_CON { get; set; }
    /// <summary> ChildCalls.DialStatus regex </summary>
    [JsonProperty("childCalls_dialStatus_reg")]
    public string? ChildCalls_DialStatus_REG { get; set; }

    /// <summary> ChildCalls.DateCreated equals </summary>
    [JsonProperty("childCalls_dateCreated_eq")]
    public DateTime? ChildCalls_DateCreated_EQ { get; set; }
    /// <summary> ChildCalls.DateCreated less than or equal to </summary>
    [JsonProperty("childCalls_dateCreated_lte")]
    public DateTime? ChildCalls_DateCreated_LTE { get; set; }
    /// <summary> ChildCalls.DateCreated greater than or equal to </summary>
    [JsonProperty("childCalls_dateCreated_gte")]
    public DateTime? ChildCalls_DateCreated_GTE { get; set; }

    /// <summary> ChildCalls.DateEnded equals </summary>
    [JsonProperty("childCalls_dateEnded_eq")]
    public DateTime? ChildCalls_DateEnded_EQ { get; set; }
    /// <summary> ChildCalls.DateEnded less than or equal to </summary>
    [JsonProperty("childCalls_dateEnded_lte")]
    public DateTime? ChildCalls_DateEnded_LTE { get; set; }
    /// <summary> ChildCalls.DateEnded greater than or equal to </summary>
    [JsonProperty("childCalls_dateEnded_gte")]
    public DateTime? ChildCalls_DateEnded_GTE { get; set; }

    /// <summary> ChildCalls.SecondsItTookToAnswer equals </summary>
    [JsonProperty("childCalls_secondsItTookToAnswer_eq")]
    public System.Int32? ChildCalls_SecondsItTookToAnswer_EQ { get; set; }
    /// <summary> ChildCalls.SecondsItTookToAnswer less than or equal to </summary>
    [JsonProperty("childCalls_secondsItTookToAnswer_lte")]
    public System.Int32? ChildCalls_SecondsItTookToAnswer_LTE { get; set; }
    /// <summary> ChildCalls.SecondsItTookToAnswer greater than or equal to </summary>
    [JsonProperty("childCalls_secondsItTookToAnswer_gte")]
    public System.Int32? ChildCalls_SecondsItTookToAnswer_GTE { get; set; }


    /// <summary> DialStatus equals </summary>
    [JsonProperty("dialStatus_eq")]
    public string? DialStatus_EQ { get; set; }
    /// <summary> DialStatus contains </summary>
    [JsonProperty("dialStatus_con")]
    public string? DialStatus_CON { get; set; }
    /// <summary> DialStatus regex </summary>
    [JsonProperty("dialStatus_reg")]
    public string? DialStatus_REG { get; set; }

    /// <summary> SecondsItTookToAnswer equals </summary>
    [JsonProperty("secondsItTookToAnswer_eq")]
    public System.Int32? SecondsItTookToAnswer_EQ { get; set; }
    /// <summary> SecondsItTookToAnswer less than or equal to </summary>
    [JsonProperty("secondsItTookToAnswer_lte")]
    public System.Int32? SecondsItTookToAnswer_LTE { get; set; }
    /// <summary> SecondsItTookToAnswer greater than or equal to </summary>
    [JsonProperty("secondsItTookToAnswer_gte")]
    public System.Int32? SecondsItTookToAnswer_GTE { get; set; }

    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenPlacedOnHold equals </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenPlacedOnHold_eq")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenPlacedOnHold_EQ { get; set; }
    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenPlacedOnHold less than or equal to </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenPlacedOnHold_lte")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenPlacedOnHold_LTE { get; set; }
    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenPlacedOnHold greater than or equal to </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenPlacedOnHold_gte")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenPlacedOnHold_GTE { get; set; }

    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenRemovedFromHold equals </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenRemovedFromHold_eq")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenRemovedFromHold_EQ { get; set; }
    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenRemovedFromHold less than or equal to </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenRemovedFromHold_lte")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenRemovedFromHold_LTE { get; set; }
    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenRemovedFromHold greater than or equal to </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenRemovedFromHold_gte")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenRemovedFromHold_GTE { get; set; }


    /// <summary> From equals </summary>
    [JsonProperty("from_eq")]
    public string? From_EQ { get; set; }
    /// <summary> From contains </summary>
    [JsonProperty("from_con")]
    public string? From_CON { get; set; }
    /// <summary> From regex </summary>
    [JsonProperty("from_reg")]
    public string? From_REG { get; set; }

    /// <summary> FromCountry equals </summary>
    [JsonProperty("fromCountry_eq")]
    public CountryIsoCode? FromCountry_EQ { get; set; }

    /// <summary> To equals </summary>
    [JsonProperty("to_eq")]
    public string? To_EQ { get; set; }
    /// <summary> To contains </summary>
    [JsonProperty("to_con")]
    public string? To_CON { get; set; }
    /// <summary> To regex </summary>
    [JsonProperty("to_reg")]
    public string? To_REG { get; set; }

    /// <summary> ToCountry equals </summary>
    [JsonProperty("toCountry_eq")]
    public CountryIsoCode? ToCountry_EQ { get; set; }

    /// <summary> Recording.ErrorMessage equals </summary>
    [JsonProperty("recording_errorMessage_eq")]
    public string? Recording_ErrorMessage_EQ { get; set; }
    /// <summary> Recording.ErrorMessage contains </summary>
    [JsonProperty("recording_errorMessage_con")]
    public string? Recording_ErrorMessage_CON { get; set; }
    /// <summary> Recording.ErrorMessage regex </summary>
    [JsonProperty("recording_errorMessage_reg")]
    public string? Recording_ErrorMessage_REG { get; set; }

    /// <summary> Recording.RecordingMp3.InstanceId equals </summary>
    [JsonProperty("recording_recordingMp3_instanceId_eq")]
    public string? Recording_RecordingMp3_InstanceId_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.InstanceId contains </summary>
    [JsonProperty("recording_recordingMp3_instanceId_con")]
    public string? Recording_RecordingMp3_InstanceId_CON { get; set; }
    /// <summary> Recording.RecordingMp3.InstanceId regex </summary>
    [JsonProperty("recording_recordingMp3_instanceId_reg")]
    public string? Recording_RecordingMp3_InstanceId_REG { get; set; }

    /// <summary> Recording.RecordingMp3.FileSizeInBytes equals </summary>
    [JsonProperty("recording_recordingMp3_fileSizeInBytes_eq")]
    public System.Int32? Recording_RecordingMp3_FileSizeInBytes_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.FileSizeInBytes less than or equal to </summary>
    [JsonProperty("recording_recordingMp3_fileSizeInBytes_lte")]
    public System.Int32? Recording_RecordingMp3_FileSizeInBytes_LTE { get; set; }
    /// <summary> Recording.RecordingMp3.FileSizeInBytes greater than or equal to </summary>
    [JsonProperty("recording_recordingMp3_fileSizeInBytes_gte")]
    public System.Int32? Recording_RecordingMp3_FileSizeInBytes_GTE { get; set; }

    /// <summary> Recording.RecordingMp3.Md5Hash equals </summary>
    [JsonProperty("recording_recordingMp3_md5Hash_eq")]
    public string? Recording_RecordingMp3_Md5Hash_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.Md5Hash contains </summary>
    [JsonProperty("recording_recordingMp3_md5Hash_con")]
    public string? Recording_RecordingMp3_Md5Hash_CON { get; set; }
    /// <summary> Recording.RecordingMp3.Md5Hash regex </summary>
    [JsonProperty("recording_recordingMp3_md5Hash_reg")]
    public string? Recording_RecordingMp3_Md5Hash_REG { get; set; }

    /// <summary> Recording.RecordingMp3.Url equals </summary>
    [JsonProperty("recording_recordingMp3_url_eq")]
    public string? Recording_RecordingMp3_Url_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.Url contains </summary>
    [JsonProperty("recording_recordingMp3_url_con")]
    public string? Recording_RecordingMp3_Url_CON { get; set; }
    /// <summary> Recording.RecordingMp3.Url regex </summary>
    [JsonProperty("recording_recordingMp3_url_reg")]
    public string? Recording_RecordingMp3_Url_REG { get; set; }

    /// <summary> Recording.RecordingMp3.Id equals </summary>
    [JsonProperty("recording_recordingMp3_id_eq")]
    public string? Recording_RecordingMp3_Id_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.Id contains </summary>
    [JsonProperty("recording_recordingMp3_id_con")]
    public string? Recording_RecordingMp3_Id_CON { get; set; }
    /// <summary> Recording.RecordingMp3.Id regex </summary>
    [JsonProperty("recording_recordingMp3_id_reg")]
    public string? Recording_RecordingMp3_Id_REG { get; set; }


    /// <summary> Recording.RecordingDurationInSeconds equals </summary>
    [JsonProperty("recording_recordingDurationInSeconds_eq")]
    public System.Int32? Recording_RecordingDurationInSeconds_EQ { get; set; }
    /// <summary> Recording.RecordingDurationInSeconds less than or equal to </summary>
    [JsonProperty("recording_recordingDurationInSeconds_lte")]
    public System.Int32? Recording_RecordingDurationInSeconds_LTE { get; set; }
    /// <summary> Recording.RecordingDurationInSeconds greater than or equal to </summary>
    [JsonProperty("recording_recordingDurationInSeconds_gte")]
    public System.Int32? Recording_RecordingDurationInSeconds_GTE { get; set; }

    /// <summary> Recording.Id equals </summary>
    [JsonProperty("recording_id_eq")]
    public string? Recording_Id_EQ { get; set; }
    /// <summary> Recording.Id contains </summary>
    [JsonProperty("recording_id_con")]
    public string? Recording_Id_CON { get; set; }
    /// <summary> Recording.Id regex </summary>
    [JsonProperty("recording_id_reg")]
    public string? Recording_Id_REG { get; set; }


    /// <summary> DisabledVideo equals </summary>
    [JsonProperty("disabledVideo_eq")]
    public bool? DisabledVideo_EQ { get; set; }

    /// <summary> DigitsSent equals </summary>
    [JsonProperty("digitsSent_eq")]
    public string? DigitsSent_EQ { get; set; }
    /// <summary> DigitsSent contains </summary>
    [JsonProperty("digitsSent_con")]
    public string? DigitsSent_CON { get; set; }
    /// <summary> DigitsSent regex </summary>
    [JsonProperty("digitsSent_reg")]
    public string? DigitsSent_REG { get; set; }

    /// <summary> IsInternational equals </summary>
    [JsonProperty("isInternational_eq")]
    public bool? IsInternational_EQ { get; set; }

    /// <summary> DateEnded equals </summary>
    [JsonProperty("dateEnded_eq")]
    public DateTime? DateEnded_EQ { get; set; }
    /// <summary> DateEnded less than or equal to </summary>
    [JsonProperty("dateEnded_lte")]
    public DateTime? DateEnded_LTE { get; set; }
    /// <summary> DateEnded greater than or equal to </summary>
    [JsonProperty("dateEnded_gte")]
    public DateTime? DateEnded_GTE { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for CallOutgoingToPSTNs </summary>
public class CallOutgoingToPSTNFilterRequest 
{
    /// <summary> CallType equals </summary>
    [JsonProperty("callType_eq")]
    public CallType? CallType_EQ { get; set; }

    /// <summary> Country equals </summary>
    [JsonProperty("country_eq")]
    public CountryIsoCode? Country_EQ { get; set; }

    /// <summary> ToInternationalFormat equals </summary>
    [JsonProperty("toInternationalFormat_eq")]
    public string? ToInternationalFormat_EQ { get; set; }
    /// <summary> ToInternationalFormat contains </summary>
    [JsonProperty("toInternationalFormat_con")]
    public string? ToInternationalFormat_CON { get; set; }
    /// <summary> ToInternationalFormat regex </summary>
    [JsonProperty("toInternationalFormat_reg")]
    public string? ToInternationalFormat_REG { get; set; }

    /// <summary> Contact.IdIdentityUser equals </summary>
    [JsonProperty("contact_idIdentityUser_eq")]
    public string? Contact_IdIdentityUser_EQ { get; set; }
    /// <summary> Contact.IdIdentityUser contains </summary>
    [JsonProperty("contact_idIdentityUser_con")]
    public string? Contact_IdIdentityUser_CON { get; set; }
    /// <summary> Contact.IdIdentityUser regex </summary>
    [JsonProperty("contact_idIdentityUser_reg")]
    public string? Contact_IdIdentityUser_REG { get; set; }

    /// <summary> Contact.ContactNumbers.SearchIndex equals </summary>
    [JsonProperty("contact_contactNumbers_searchIndex_eq")]
    public string? Contact_ContactNumbers_SearchIndex_EQ { get; set; }
    /// <summary> Contact.ContactNumbers.SearchIndex contains </summary>
    [JsonProperty("contact_contactNumbers_searchIndex_con")]
    public string? Contact_ContactNumbers_SearchIndex_CON { get; set; }
    /// <summary> Contact.ContactNumbers.SearchIndex regex </summary>
    [JsonProperty("contact_contactNumbers_searchIndex_reg")]
    public string? Contact_ContactNumbers_SearchIndex_REG { get; set; }

    /// <summary> Contact.ContactNumbers.Number equals </summary>
    [JsonProperty("contact_contactNumbers_number_eq")]
    public string? Contact_ContactNumbers_Number_EQ { get; set; }
    /// <summary> Contact.ContactNumbers.Number contains </summary>
    [JsonProperty("contact_contactNumbers_number_con")]
    public string? Contact_ContactNumbers_Number_CON { get; set; }
    /// <summary> Contact.ContactNumbers.Number regex </summary>
    [JsonProperty("contact_contactNumbers_number_reg")]
    public string? Contact_ContactNumbers_Number_REG { get; set; }

    /// <summary> Contact.ContactNumbers.NumberInternationalFormat equals </summary>
    [JsonProperty("contact_contactNumbers_numberInternationalFormat_eq")]
    public string? Contact_ContactNumbers_NumberInternationalFormat_EQ { get; set; }
    /// <summary> Contact.ContactNumbers.NumberInternationalFormat contains </summary>
    [JsonProperty("contact_contactNumbers_numberInternationalFormat_con")]
    public string? Contact_ContactNumbers_NumberInternationalFormat_CON { get; set; }
    /// <summary> Contact.ContactNumbers.NumberInternationalFormat regex </summary>
    [JsonProperty("contact_contactNumbers_numberInternationalFormat_reg")]
    public string? Contact_ContactNumbers_NumberInternationalFormat_REG { get; set; }

    /// <summary> Contact.ContactNumbers.Label equals </summary>
    [JsonProperty("contact_contactNumbers_label_eq")]
    public LabelNumber? Contact_ContactNumbers_Label_EQ { get; set; }


    /// <summary> Contact.ContactEmails.SearchIndex equals </summary>
    [JsonProperty("contact_contactEmails_searchIndex_eq")]
    public string? Contact_ContactEmails_SearchIndex_EQ { get; set; }
    /// <summary> Contact.ContactEmails.SearchIndex contains </summary>
    [JsonProperty("contact_contactEmails_searchIndex_con")]
    public string? Contact_ContactEmails_SearchIndex_CON { get; set; }
    /// <summary> Contact.ContactEmails.SearchIndex regex </summary>
    [JsonProperty("contact_contactEmails_searchIndex_reg")]
    public string? Contact_ContactEmails_SearchIndex_REG { get; set; }

    /// <summary> Contact.ContactEmails.Email equals </summary>
    [JsonProperty("contact_contactEmails_email_eq")]
    public string? Contact_ContactEmails_Email_EQ { get; set; }
    /// <summary> Contact.ContactEmails.Email contains </summary>
    [JsonProperty("contact_contactEmails_email_con")]
    public string? Contact_ContactEmails_Email_CON { get; set; }
    /// <summary> Contact.ContactEmails.Email regex </summary>
    [JsonProperty("contact_contactEmails_email_reg")]
    public string? Contact_ContactEmails_Email_REG { get; set; }

    /// <summary> Contact.ContactEmails.Label equals </summary>
    [JsonProperty("contact_contactEmails_label_eq")]
    public LabelEmailType? Contact_ContactEmails_Label_EQ { get; set; }


    /// <summary> Contact.FirstName equals </summary>
    [JsonProperty("contact_firstName_eq")]
    public string? Contact_FirstName_EQ { get; set; }
    /// <summary> Contact.FirstName contains </summary>
    [JsonProperty("contact_firstName_con")]
    public string? Contact_FirstName_CON { get; set; }
    /// <summary> Contact.FirstName regex </summary>
    [JsonProperty("contact_firstName_reg")]
    public string? Contact_FirstName_REG { get; set; }

    /// <summary> Contact.LastName equals </summary>
    [JsonProperty("contact_lastName_eq")]
    public string? Contact_LastName_EQ { get; set; }
    /// <summary> Contact.LastName contains </summary>
    [JsonProperty("contact_lastName_con")]
    public string? Contact_LastName_CON { get; set; }
    /// <summary> Contact.LastName regex </summary>
    [JsonProperty("contact_lastName_reg")]
    public string? Contact_LastName_REG { get; set; }

    /// <summary> Contact.JobTittle equals </summary>
    [JsonProperty("contact_jobTittle_eq")]
    public string? Contact_JobTittle_EQ { get; set; }
    /// <summary> Contact.JobTittle contains </summary>
    [JsonProperty("contact_jobTittle_con")]
    public string? Contact_JobTittle_CON { get; set; }
    /// <summary> Contact.JobTittle regex </summary>
    [JsonProperty("contact_jobTittle_reg")]
    public string? Contact_JobTittle_REG { get; set; }

    /// <summary> Contact.Company equals </summary>
    [JsonProperty("contact_company_eq")]
    public string? Contact_Company_EQ { get; set; }
    /// <summary> Contact.Company contains </summary>
    [JsonProperty("contact_company_con")]
    public string? Contact_Company_CON { get; set; }
    /// <summary> Contact.Company regex </summary>
    [JsonProperty("contact_company_reg")]
    public string? Contact_Company_REG { get; set; }

    /// <summary> Contact.Hash equals </summary>
    [JsonProperty("contact_hash_eq")]
    public string? Contact_Hash_EQ { get; set; }
    /// <summary> Contact.Hash contains </summary>
    [JsonProperty("contact_hash_con")]
    public string? Contact_Hash_CON { get; set; }
    /// <summary> Contact.Hash regex </summary>
    [JsonProperty("contact_hash_reg")]
    public string? Contact_Hash_REG { get; set; }

    /// <summary> Contact.Notes equals </summary>
    [JsonProperty("contact_notes_eq")]
    public string? Contact_Notes_EQ { get; set; }
    /// <summary> Contact.Notes contains </summary>
    [JsonProperty("contact_notes_con")]
    public string? Contact_Notes_CON { get; set; }
    /// <summary> Contact.Notes regex </summary>
    [JsonProperty("contact_notes_reg")]
    public string? Contact_Notes_REG { get; set; }

    /// <summary> Contact.Variables.Name equals </summary>
    [JsonProperty("contact_variables_name_eq")]
    public string? Contact_Variables_Name_EQ { get; set; }
    /// <summary> Contact.Variables.Name contains </summary>
    [JsonProperty("contact_variables_name_con")]
    public string? Contact_Variables_Name_CON { get; set; }
    /// <summary> Contact.Variables.Name regex </summary>
    [JsonProperty("contact_variables_name_reg")]
    public string? Contact_Variables_Name_REG { get; set; }

    /// <summary> Contact.Variables.JsonValue equals </summary>
    [JsonProperty("contact_variables_jsonValue_eq")]
    public string? Contact_Variables_JsonValue_EQ { get; set; }
    /// <summary> Contact.Variables.JsonValue contains </summary>
    [JsonProperty("contact_variables_jsonValue_con")]
    public string? Contact_Variables_JsonValue_CON { get; set; }
    /// <summary> Contact.Variables.JsonValue regex </summary>
    [JsonProperty("contact_variables_jsonValue_reg")]
    public string? Contact_Variables_JsonValue_REG { get; set; }


    /// <summary> Contact.Id equals </summary>
    [JsonProperty("contact_id_eq")]
    public string? Contact_Id_EQ { get; set; }
    /// <summary> Contact.Id contains </summary>
    [JsonProperty("contact_id_con")]
    public string? Contact_Id_CON { get; set; }
    /// <summary> Contact.Id regex </summary>
    [JsonProperty("contact_id_reg")]
    public string? Contact_Id_REG { get; set; }

    /// <summary> Contact.DateCreated equals </summary>
    [JsonProperty("contact_dateCreated_eq")]
    public DateTime? Contact_DateCreated_EQ { get; set; }
    /// <summary> Contact.DateCreated less than or equal to </summary>
    [JsonProperty("contact_dateCreated_lte")]
    public DateTime? Contact_DateCreated_LTE { get; set; }
    /// <summary> Contact.DateCreated greater than or equal to </summary>
    [JsonProperty("contact_dateCreated_gte")]
    public DateTime? Contact_DateCreated_GTE { get; set; }

    /// <summary> Contact.DateUpdated equals </summary>
    [JsonProperty("contact_dateUpdated_eq")]
    public DateTime? Contact_DateUpdated_EQ { get; set; }
    /// <summary> Contact.DateUpdated less than or equal to </summary>
    [JsonProperty("contact_dateUpdated_lte")]
    public DateTime? Contact_DateUpdated_LTE { get; set; }
    /// <summary> Contact.DateUpdated greater than or equal to </summary>
    [JsonProperty("contact_dateUpdated_gte")]
    public DateTime? Contact_DateUpdated_GTE { get; set; }


    /// <summary> LineThatInitiatedCall.FriendlyName equals </summary>
    [JsonProperty("lineThatInitiatedCall_friendlyName_eq")]
    public string? LineThatInitiatedCall_FriendlyName_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.FriendlyName contains </summary>
    [JsonProperty("lineThatInitiatedCall_friendlyName_con")]
    public string? LineThatInitiatedCall_FriendlyName_CON { get; set; }
    /// <summary> LineThatInitiatedCall.FriendlyName regex </summary>
    [JsonProperty("lineThatInitiatedCall_friendlyName_reg")]
    public string? LineThatInitiatedCall_FriendlyName_REG { get; set; }

    /// <summary> LineThatInitiatedCall.LineConnectionStatus.IpWAN equals </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_ipWAN_eq")]
    public string? LineThatInitiatedCall_LineConnectionStatus_IpWAN_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.IpWAN contains </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_ipWAN_con")]
    public string? LineThatInitiatedCall_LineConnectionStatus_IpWAN_CON { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.IpWAN regex </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_ipWAN_reg")]
    public string? LineThatInitiatedCall_LineConnectionStatus_IpWAN_REG { get; set; }

    /// <summary> LineThatInitiatedCall.LineConnectionStatus.PortWAN equals </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_portWAN_eq")]
    public System.Int32? LineThatInitiatedCall_LineConnectionStatus_PortWAN_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.PortWAN less than or equal to </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_portWAN_lte")]
    public System.Int32? LineThatInitiatedCall_LineConnectionStatus_PortWAN_LTE { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.PortWAN greater than or equal to </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_portWAN_gte")]
    public System.Int32? LineThatInitiatedCall_LineConnectionStatus_PortWAN_GTE { get; set; }

    /// <summary> LineThatInitiatedCall.LineConnectionStatus.IpLAN equals </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_ipLAN_eq")]
    public string? LineThatInitiatedCall_LineConnectionStatus_IpLAN_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.IpLAN contains </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_ipLAN_con")]
    public string? LineThatInitiatedCall_LineConnectionStatus_IpLAN_CON { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.IpLAN regex </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_ipLAN_reg")]
    public string? LineThatInitiatedCall_LineConnectionStatus_IpLAN_REG { get; set; }

    /// <summary> LineThatInitiatedCall.LineConnectionStatus.PortLAN equals </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_portLAN_eq")]
    public System.Int32? LineThatInitiatedCall_LineConnectionStatus_PortLAN_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.PortLAN less than or equal to </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_portLAN_lte")]
    public System.Int32? LineThatInitiatedCall_LineConnectionStatus_PortLAN_LTE { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.PortLAN greater than or equal to </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_portLAN_gte")]
    public System.Int32? LineThatInitiatedCall_LineConnectionStatus_PortLAN_GTE { get; set; }

    /// <summary> LineThatInitiatedCall.LineConnectionStatus.UserAgent equals </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_userAgent_eq")]
    public string? LineThatInitiatedCall_LineConnectionStatus_UserAgent_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.UserAgent contains </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_userAgent_con")]
    public string? LineThatInitiatedCall_LineConnectionStatus_UserAgent_CON { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.UserAgent regex </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_userAgent_reg")]
    public string? LineThatInitiatedCall_LineConnectionStatus_UserAgent_REG { get; set; }

    /// <summary> LineThatInitiatedCall.LineConnectionStatus.IsConnected equals </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_isConnected_eq")]
    public bool? LineThatInitiatedCall_LineConnectionStatus_IsConnected_EQ { get; set; }

    /// <summary> LineThatInitiatedCall.LineConnectionStatus.DisconnectedReason equals </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_disconnectedReason_eq")]
    public string? LineThatInitiatedCall_LineConnectionStatus_DisconnectedReason_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.DisconnectedReason contains </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_disconnectedReason_con")]
    public string? LineThatInitiatedCall_LineConnectionStatus_DisconnectedReason_CON { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.DisconnectedReason regex </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_disconnectedReason_reg")]
    public string? LineThatInitiatedCall_LineConnectionStatus_DisconnectedReason_REG { get; set; }

    /// <summary> LineThatInitiatedCall.LineConnectionStatus.DateConnected equals </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_dateConnected_eq")]
    public DateTime? LineThatInitiatedCall_LineConnectionStatus_DateConnected_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.DateConnected less than or equal to </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_dateConnected_lte")]
    public DateTime? LineThatInitiatedCall_LineConnectionStatus_DateConnected_LTE { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.DateConnected greater than or equal to </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_dateConnected_gte")]
    public DateTime? LineThatInitiatedCall_LineConnectionStatus_DateConnected_GTE { get; set; }

    /// <summary> LineThatInitiatedCall.LineConnectionStatus.DateDisconnected equals </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_dateDisconnected_eq")]
    public DateTime? LineThatInitiatedCall_LineConnectionStatus_DateDisconnected_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.DateDisconnected less than or equal to </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_dateDisconnected_lte")]
    public DateTime? LineThatInitiatedCall_LineConnectionStatus_DateDisconnected_LTE { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.DateDisconnected greater than or equal to </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_dateDisconnected_gte")]
    public DateTime? LineThatInitiatedCall_LineConnectionStatus_DateDisconnected_GTE { get; set; }


    /// <summary> LineThatInitiatedCall.CallerIdNumber equals </summary>
    [JsonProperty("lineThatInitiatedCall_callerIdNumber_eq")]
    public string? LineThatInitiatedCall_CallerIdNumber_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.CallerIdNumber contains </summary>
    [JsonProperty("lineThatInitiatedCall_callerIdNumber_con")]
    public string? LineThatInitiatedCall_CallerIdNumber_CON { get; set; }
    /// <summary> LineThatInitiatedCall.CallerIdNumber regex </summary>
    [JsonProperty("lineThatInitiatedCall_callerIdNumber_reg")]
    public string? LineThatInitiatedCall_CallerIdNumber_REG { get; set; }

    /// <summary> LineThatInitiatedCall.RecordExternalCalls equals </summary>
    [JsonProperty("lineThatInitiatedCall_recordExternalCalls_eq")]
    public bool? LineThatInitiatedCall_RecordExternalCalls_EQ { get; set; }

    /// <summary> LineThatInitiatedCall.RecordInternalCalls equals </summary>
    [JsonProperty("lineThatInitiatedCall_recordInternalCalls_eq")]
    public bool? LineThatInitiatedCall_RecordInternalCalls_EQ { get; set; }

    /// <summary> LineThatInitiatedCall.Language equals </summary>
    [JsonProperty("lineThatInitiatedCall_language_eq")]
    public Language? LineThatInitiatedCall_Language_EQ { get; set; }

    /// <summary> LineThatInitiatedCall.Id equals </summary>
    [JsonProperty("lineThatInitiatedCall_id_eq")]
    public string? LineThatInitiatedCall_Id_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.Id contains </summary>
    [JsonProperty("lineThatInitiatedCall_id_con")]
    public string? LineThatInitiatedCall_Id_CON { get; set; }
    /// <summary> LineThatInitiatedCall.Id regex </summary>
    [JsonProperty("lineThatInitiatedCall_id_reg")]
    public string? LineThatInitiatedCall_Id_REG { get; set; }


    /// <summary> IdVoicemail equals </summary>
    [JsonProperty("idVoicemail_eq")]
    public string? IdVoicemail_EQ { get; set; }
    /// <summary> IdVoicemail contains </summary>
    [JsonProperty("idVoicemail_con")]
    public string? IdVoicemail_CON { get; set; }
    /// <summary> IdVoicemail regex </summary>
    [JsonProperty("idVoicemail_reg")]
    public string? IdVoicemail_REG { get; set; }

    /// <summary> IdCallThatTerminatedThisCallDoToAttendantTransfer equals </summary>
    [JsonProperty("idCallThatTerminatedThisCallDoToAttendantTransfer_eq")]
    public string? IdCallThatTerminatedThisCallDoToAttendantTransfer_EQ { get; set; }
    /// <summary> IdCallThatTerminatedThisCallDoToAttendantTransfer contains </summary>
    [JsonProperty("idCallThatTerminatedThisCallDoToAttendantTransfer_con")]
    public string? IdCallThatTerminatedThisCallDoToAttendantTransfer_CON { get; set; }
    /// <summary> IdCallThatTerminatedThisCallDoToAttendantTransfer regex </summary>
    [JsonProperty("idCallThatTerminatedThisCallDoToAttendantTransfer_reg")]
    public string? IdCallThatTerminatedThisCallDoToAttendantTransfer_REG { get; set; }

    /// <summary> ChannelVariables.Language equals </summary>
    [JsonProperty("channelVariables_language_eq")]
    public Language? ChannelVariables_Language_EQ { get; set; }

    /// <summary> ChannelVariables.IdMusicOnHold equals </summary>
    [JsonProperty("channelVariables_idMusicOnHold_eq")]
    public string? ChannelVariables_IdMusicOnHold_EQ { get; set; }
    /// <summary> ChannelVariables.IdMusicOnHold contains </summary>
    [JsonProperty("channelVariables_idMusicOnHold_con")]
    public string? ChannelVariables_IdMusicOnHold_CON { get; set; }
    /// <summary> ChannelVariables.IdMusicOnHold regex </summary>
    [JsonProperty("channelVariables_idMusicOnHold_reg")]
    public string? ChannelVariables_IdMusicOnHold_REG { get; set; }

    /// <summary> ChannelVariables.CallerIdName equals </summary>
    [JsonProperty("channelVariables_callerIdName_eq")]
    public string? ChannelVariables_CallerIdName_EQ { get; set; }
    /// <summary> ChannelVariables.CallerIdName contains </summary>
    [JsonProperty("channelVariables_callerIdName_con")]
    public string? ChannelVariables_CallerIdName_CON { get; set; }
    /// <summary> ChannelVariables.CallerIdName regex </summary>
    [JsonProperty("channelVariables_callerIdName_reg")]
    public string? ChannelVariables_CallerIdName_REG { get; set; }

    /// <summary> ChannelVariables.CallerIdNumber equals </summary>
    [JsonProperty("channelVariables_callerIdNumber_eq")]
    public string? ChannelVariables_CallerIdNumber_EQ { get; set; }
    /// <summary> ChannelVariables.CallerIdNumber contains </summary>
    [JsonProperty("channelVariables_callerIdNumber_con")]
    public string? ChannelVariables_CallerIdNumber_CON { get; set; }
    /// <summary> ChannelVariables.CallerIdNumber regex </summary>
    [JsonProperty("channelVariables_callerIdNumber_reg")]
    public string? ChannelVariables_CallerIdNumber_REG { get; set; }


    /// <summary> ChildCalls.ChildCallType equals </summary>
    [JsonProperty("childCalls_childCallType_eq")]
    public ChildCallType? ChildCalls_ChildCallType_EQ { get; set; }

    /// <summary> ChildCalls.DialStatus equals </summary>
    [JsonProperty("childCalls_dialStatus_eq")]
    public string? ChildCalls_DialStatus_EQ { get; set; }
    /// <summary> ChildCalls.DialStatus contains </summary>
    [JsonProperty("childCalls_dialStatus_con")]
    public string? ChildCalls_DialStatus_CON { get; set; }
    /// <summary> ChildCalls.DialStatus regex </summary>
    [JsonProperty("childCalls_dialStatus_reg")]
    public string? ChildCalls_DialStatus_REG { get; set; }

    /// <summary> ChildCalls.DateCreated equals </summary>
    [JsonProperty("childCalls_dateCreated_eq")]
    public DateTime? ChildCalls_DateCreated_EQ { get; set; }
    /// <summary> ChildCalls.DateCreated less than or equal to </summary>
    [JsonProperty("childCalls_dateCreated_lte")]
    public DateTime? ChildCalls_DateCreated_LTE { get; set; }
    /// <summary> ChildCalls.DateCreated greater than or equal to </summary>
    [JsonProperty("childCalls_dateCreated_gte")]
    public DateTime? ChildCalls_DateCreated_GTE { get; set; }

    /// <summary> ChildCalls.DateEnded equals </summary>
    [JsonProperty("childCalls_dateEnded_eq")]
    public DateTime? ChildCalls_DateEnded_EQ { get; set; }
    /// <summary> ChildCalls.DateEnded less than or equal to </summary>
    [JsonProperty("childCalls_dateEnded_lte")]
    public DateTime? ChildCalls_DateEnded_LTE { get; set; }
    /// <summary> ChildCalls.DateEnded greater than or equal to </summary>
    [JsonProperty("childCalls_dateEnded_gte")]
    public DateTime? ChildCalls_DateEnded_GTE { get; set; }

    /// <summary> ChildCalls.SecondsItTookToAnswer equals </summary>
    [JsonProperty("childCalls_secondsItTookToAnswer_eq")]
    public System.Int32? ChildCalls_SecondsItTookToAnswer_EQ { get; set; }
    /// <summary> ChildCalls.SecondsItTookToAnswer less than or equal to </summary>
    [JsonProperty("childCalls_secondsItTookToAnswer_lte")]
    public System.Int32? ChildCalls_SecondsItTookToAnswer_LTE { get; set; }
    /// <summary> ChildCalls.SecondsItTookToAnswer greater than or equal to </summary>
    [JsonProperty("childCalls_secondsItTookToAnswer_gte")]
    public System.Int32? ChildCalls_SecondsItTookToAnswer_GTE { get; set; }


    /// <summary> DialStatus equals </summary>
    [JsonProperty("dialStatus_eq")]
    public string? DialStatus_EQ { get; set; }
    /// <summary> DialStatus contains </summary>
    [JsonProperty("dialStatus_con")]
    public string? DialStatus_CON { get; set; }
    /// <summary> DialStatus regex </summary>
    [JsonProperty("dialStatus_reg")]
    public string? DialStatus_REG { get; set; }

    /// <summary> SecondsItTookToAnswer equals </summary>
    [JsonProperty("secondsItTookToAnswer_eq")]
    public System.Int32? SecondsItTookToAnswer_EQ { get; set; }
    /// <summary> SecondsItTookToAnswer less than or equal to </summary>
    [JsonProperty("secondsItTookToAnswer_lte")]
    public System.Int32? SecondsItTookToAnswer_LTE { get; set; }
    /// <summary> SecondsItTookToAnswer greater than or equal to </summary>
    [JsonProperty("secondsItTookToAnswer_gte")]
    public System.Int32? SecondsItTookToAnswer_GTE { get; set; }

    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenPlacedOnHold equals </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenPlacedOnHold_eq")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenPlacedOnHold_EQ { get; set; }
    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenPlacedOnHold less than or equal to </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenPlacedOnHold_lte")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenPlacedOnHold_LTE { get; set; }
    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenPlacedOnHold greater than or equal to </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenPlacedOnHold_gte")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenPlacedOnHold_GTE { get; set; }

    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenRemovedFromHold equals </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenRemovedFromHold_eq")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenRemovedFromHold_EQ { get; set; }
    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenRemovedFromHold less than or equal to </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenRemovedFromHold_lte")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenRemovedFromHold_LTE { get; set; }
    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenRemovedFromHold greater than or equal to </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenRemovedFromHold_gte")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenRemovedFromHold_GTE { get; set; }


    /// <summary> From equals </summary>
    [JsonProperty("from_eq")]
    public string? From_EQ { get; set; }
    /// <summary> From contains </summary>
    [JsonProperty("from_con")]
    public string? From_CON { get; set; }
    /// <summary> From regex </summary>
    [JsonProperty("from_reg")]
    public string? From_REG { get; set; }

    /// <summary> FromCountry equals </summary>
    [JsonProperty("fromCountry_eq")]
    public CountryIsoCode? FromCountry_EQ { get; set; }

    /// <summary> To equals </summary>
    [JsonProperty("to_eq")]
    public string? To_EQ { get; set; }
    /// <summary> To contains </summary>
    [JsonProperty("to_con")]
    public string? To_CON { get; set; }
    /// <summary> To regex </summary>
    [JsonProperty("to_reg")]
    public string? To_REG { get; set; }

    /// <summary> ToCountry equals </summary>
    [JsonProperty("toCountry_eq")]
    public CountryIsoCode? ToCountry_EQ { get; set; }

    /// <summary> Recording.ErrorMessage equals </summary>
    [JsonProperty("recording_errorMessage_eq")]
    public string? Recording_ErrorMessage_EQ { get; set; }
    /// <summary> Recording.ErrorMessage contains </summary>
    [JsonProperty("recording_errorMessage_con")]
    public string? Recording_ErrorMessage_CON { get; set; }
    /// <summary> Recording.ErrorMessage regex </summary>
    [JsonProperty("recording_errorMessage_reg")]
    public string? Recording_ErrorMessage_REG { get; set; }

    /// <summary> Recording.RecordingMp3.InstanceId equals </summary>
    [JsonProperty("recording_recordingMp3_instanceId_eq")]
    public string? Recording_RecordingMp3_InstanceId_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.InstanceId contains </summary>
    [JsonProperty("recording_recordingMp3_instanceId_con")]
    public string? Recording_RecordingMp3_InstanceId_CON { get; set; }
    /// <summary> Recording.RecordingMp3.InstanceId regex </summary>
    [JsonProperty("recording_recordingMp3_instanceId_reg")]
    public string? Recording_RecordingMp3_InstanceId_REG { get; set; }

    /// <summary> Recording.RecordingMp3.FileSizeInBytes equals </summary>
    [JsonProperty("recording_recordingMp3_fileSizeInBytes_eq")]
    public System.Int32? Recording_RecordingMp3_FileSizeInBytes_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.FileSizeInBytes less than or equal to </summary>
    [JsonProperty("recording_recordingMp3_fileSizeInBytes_lte")]
    public System.Int32? Recording_RecordingMp3_FileSizeInBytes_LTE { get; set; }
    /// <summary> Recording.RecordingMp3.FileSizeInBytes greater than or equal to </summary>
    [JsonProperty("recording_recordingMp3_fileSizeInBytes_gte")]
    public System.Int32? Recording_RecordingMp3_FileSizeInBytes_GTE { get; set; }

    /// <summary> Recording.RecordingMp3.Md5Hash equals </summary>
    [JsonProperty("recording_recordingMp3_md5Hash_eq")]
    public string? Recording_RecordingMp3_Md5Hash_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.Md5Hash contains </summary>
    [JsonProperty("recording_recordingMp3_md5Hash_con")]
    public string? Recording_RecordingMp3_Md5Hash_CON { get; set; }
    /// <summary> Recording.RecordingMp3.Md5Hash regex </summary>
    [JsonProperty("recording_recordingMp3_md5Hash_reg")]
    public string? Recording_RecordingMp3_Md5Hash_REG { get; set; }

    /// <summary> Recording.RecordingMp3.Url equals </summary>
    [JsonProperty("recording_recordingMp3_url_eq")]
    public string? Recording_RecordingMp3_Url_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.Url contains </summary>
    [JsonProperty("recording_recordingMp3_url_con")]
    public string? Recording_RecordingMp3_Url_CON { get; set; }
    /// <summary> Recording.RecordingMp3.Url regex </summary>
    [JsonProperty("recording_recordingMp3_url_reg")]
    public string? Recording_RecordingMp3_Url_REG { get; set; }

    /// <summary> Recording.RecordingMp3.Id equals </summary>
    [JsonProperty("recording_recordingMp3_id_eq")]
    public string? Recording_RecordingMp3_Id_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.Id contains </summary>
    [JsonProperty("recording_recordingMp3_id_con")]
    public string? Recording_RecordingMp3_Id_CON { get; set; }
    /// <summary> Recording.RecordingMp3.Id regex </summary>
    [JsonProperty("recording_recordingMp3_id_reg")]
    public string? Recording_RecordingMp3_Id_REG { get; set; }


    /// <summary> Recording.RecordingDurationInSeconds equals </summary>
    [JsonProperty("recording_recordingDurationInSeconds_eq")]
    public System.Int32? Recording_RecordingDurationInSeconds_EQ { get; set; }
    /// <summary> Recording.RecordingDurationInSeconds less than or equal to </summary>
    [JsonProperty("recording_recordingDurationInSeconds_lte")]
    public System.Int32? Recording_RecordingDurationInSeconds_LTE { get; set; }
    /// <summary> Recording.RecordingDurationInSeconds greater than or equal to </summary>
    [JsonProperty("recording_recordingDurationInSeconds_gte")]
    public System.Int32? Recording_RecordingDurationInSeconds_GTE { get; set; }

    /// <summary> Recording.Id equals </summary>
    [JsonProperty("recording_id_eq")]
    public string? Recording_Id_EQ { get; set; }
    /// <summary> Recording.Id contains </summary>
    [JsonProperty("recording_id_con")]
    public string? Recording_Id_CON { get; set; }
    /// <summary> Recording.Id regex </summary>
    [JsonProperty("recording_id_reg")]
    public string? Recording_Id_REG { get; set; }


    /// <summary> DisabledVideo equals </summary>
    [JsonProperty("disabledVideo_eq")]
    public bool? DisabledVideo_EQ { get; set; }

    /// <summary> DigitsSent equals </summary>
    [JsonProperty("digitsSent_eq")]
    public string? DigitsSent_EQ { get; set; }
    /// <summary> DigitsSent contains </summary>
    [JsonProperty("digitsSent_con")]
    public string? DigitsSent_CON { get; set; }
    /// <summary> DigitsSent regex </summary>
    [JsonProperty("digitsSent_reg")]
    public string? DigitsSent_REG { get; set; }

    /// <summary> IsInternational equals </summary>
    [JsonProperty("isInternational_eq")]
    public bool? IsInternational_EQ { get; set; }

    /// <summary> DateEnded equals </summary>
    [JsonProperty("dateEnded_eq")]
    public DateTime? DateEnded_EQ { get; set; }
    /// <summary> DateEnded less than or equal to </summary>
    [JsonProperty("dateEnded_lte")]
    public DateTime? DateEnded_LTE { get; set; }
    /// <summary> DateEnded greater than or equal to </summary>
    [JsonProperty("dateEnded_gte")]
    public DateTime? DateEnded_GTE { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for CloudServicePbxs </summary>
public class CloudServicePbxFilterRequest 
{
    /// <summary> CloudServiceType equals </summary>
    [JsonProperty("cloudServiceType_eq")]
    public CloudServiceType? CloudServiceType_EQ { get; set; }

    /// <summary> CountryIsoCode equals </summary>
    [JsonProperty("countryIsoCode_eq")]
    public CountryIsoCode? CountryIsoCode_EQ { get; set; }

    /// <summary> Localnet equals </summary>
    [JsonProperty("localnet_eq")]
    public string? Localnet_EQ { get; set; }
    /// <summary> Localnet contains </summary>
    [JsonProperty("localnet_con")]
    public string? Localnet_CON { get; set; }
    /// <summary> Localnet regex </summary>
    [JsonProperty("localnet_reg")]
    public string? Localnet_REG { get; set; }

    /// <summary> ExternalIp equals </summary>
    [JsonProperty("externalIp_eq")]
    public string? ExternalIp_EQ { get; set; }
    /// <summary> ExternalIp contains </summary>
    [JsonProperty("externalIp_con")]
    public string? ExternalIp_CON { get; set; }
    /// <summary> ExternalIp regex </summary>
    [JsonProperty("externalIp_reg")]
    public string? ExternalIp_REG { get; set; }

    /// <summary> IsFailover equals </summary>
    [JsonProperty("isFailover_eq")]
    public bool? IsFailover_EQ { get; set; }

    /// <summary> Nat equals </summary>
    [JsonProperty("nat_eq")]
    public bool? Nat_EQ { get; set; }

    /// <summary> IsHealthy equals </summary>
    [JsonProperty("isHealthy_eq")]
    public bool? IsHealthy_EQ { get; set; }

    /// <summary> InstanceId equals </summary>
    [JsonProperty("instanceId_eq")]
    public string? InstanceId_EQ { get; set; }
    /// <summary> InstanceId contains </summary>
    [JsonProperty("instanceId_con")]
    public string? InstanceId_CON { get; set; }
    /// <summary> InstanceId regex </summary>
    [JsonProperty("instanceId_reg")]
    public string? InstanceId_REG { get; set; }

    /// <summary> HttpListenPort equals </summary>
    [JsonProperty("httpListenPort_eq")]
    public System.Int32? HttpListenPort_EQ { get; set; }
    /// <summary> HttpListenPort less than or equal to </summary>
    [JsonProperty("httpListenPort_lte")]
    public System.Int32? HttpListenPort_LTE { get; set; }
    /// <summary> HttpListenPort greater than or equal to </summary>
    [JsonProperty("httpListenPort_gte")]
    public System.Int32? HttpListenPort_GTE { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for CloudServiceWebApps </summary>
public class CloudServiceWebAppFilterRequest 
{
    /// <summary> CloudServiceType equals </summary>
    [JsonProperty("cloudServiceType_eq")]
    public CloudServiceType? CloudServiceType_EQ { get; set; }

    /// <summary> CountryIsoCode equals </summary>
    [JsonProperty("countryIsoCode_eq")]
    public CountryIsoCode? CountryIsoCode_EQ { get; set; }

    /// <summary> Localnet equals </summary>
    [JsonProperty("localnet_eq")]
    public string? Localnet_EQ { get; set; }
    /// <summary> Localnet contains </summary>
    [JsonProperty("localnet_con")]
    public string? Localnet_CON { get; set; }
    /// <summary> Localnet regex </summary>
    [JsonProperty("localnet_reg")]
    public string? Localnet_REG { get; set; }

    /// <summary> ExternalIp equals </summary>
    [JsonProperty("externalIp_eq")]
    public string? ExternalIp_EQ { get; set; }
    /// <summary> ExternalIp contains </summary>
    [JsonProperty("externalIp_con")]
    public string? ExternalIp_CON { get; set; }
    /// <summary> ExternalIp regex </summary>
    [JsonProperty("externalIp_reg")]
    public string? ExternalIp_REG { get; set; }

    /// <summary> IsFailover equals </summary>
    [JsonProperty("isFailover_eq")]
    public bool? IsFailover_EQ { get; set; }

    /// <summary> Nat equals </summary>
    [JsonProperty("nat_eq")]
    public bool? Nat_EQ { get; set; }

    /// <summary> IsHealthy equals </summary>
    [JsonProperty("isHealthy_eq")]
    public bool? IsHealthy_EQ { get; set; }

    /// <summary> InstanceId equals </summary>
    [JsonProperty("instanceId_eq")]
    public string? InstanceId_EQ { get; set; }
    /// <summary> InstanceId contains </summary>
    [JsonProperty("instanceId_con")]
    public string? InstanceId_CON { get; set; }
    /// <summary> InstanceId regex </summary>
    [JsonProperty("instanceId_reg")]
    public string? InstanceId_REG { get; set; }

    /// <summary> HttpListenPort equals </summary>
    [JsonProperty("httpListenPort_eq")]
    public System.Int32? HttpListenPort_EQ { get; set; }
    /// <summary> HttpListenPort less than or equal to </summary>
    [JsonProperty("httpListenPort_lte")]
    public System.Int32? HttpListenPort_LTE { get; set; }
    /// <summary> HttpListenPort greater than or equal to </summary>
    [JsonProperty("httpListenPort_gte")]
    public System.Int32? HttpListenPort_GTE { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for CloudServiceWebHosts </summary>
public class CloudServiceWebHostFilterRequest 
{
    /// <summary> CloudServiceType equals </summary>
    [JsonProperty("cloudServiceType_eq")]
    public CloudServiceType? CloudServiceType_EQ { get; set; }

    /// <summary> CountryIsoCode equals </summary>
    [JsonProperty("countryIsoCode_eq")]
    public CountryIsoCode? CountryIsoCode_EQ { get; set; }

    /// <summary> Localnet equals </summary>
    [JsonProperty("localnet_eq")]
    public string? Localnet_EQ { get; set; }
    /// <summary> Localnet contains </summary>
    [JsonProperty("localnet_con")]
    public string? Localnet_CON { get; set; }
    /// <summary> Localnet regex </summary>
    [JsonProperty("localnet_reg")]
    public string? Localnet_REG { get; set; }

    /// <summary> ExternalIp equals </summary>
    [JsonProperty("externalIp_eq")]
    public string? ExternalIp_EQ { get; set; }
    /// <summary> ExternalIp contains </summary>
    [JsonProperty("externalIp_con")]
    public string? ExternalIp_CON { get; set; }
    /// <summary> ExternalIp regex </summary>
    [JsonProperty("externalIp_reg")]
    public string? ExternalIp_REG { get; set; }

    /// <summary> IsFailover equals </summary>
    [JsonProperty("isFailover_eq")]
    public bool? IsFailover_EQ { get; set; }

    /// <summary> Nat equals </summary>
    [JsonProperty("nat_eq")]
    public bool? Nat_EQ { get; set; }

    /// <summary> IsHealthy equals </summary>
    [JsonProperty("isHealthy_eq")]
    public bool? IsHealthy_EQ { get; set; }

    /// <summary> InstanceId equals </summary>
    [JsonProperty("instanceId_eq")]
    public string? InstanceId_EQ { get; set; }
    /// <summary> InstanceId contains </summary>
    [JsonProperty("instanceId_con")]
    public string? InstanceId_CON { get; set; }
    /// <summary> InstanceId regex </summary>
    [JsonProperty("instanceId_reg")]
    public string? InstanceId_REG { get; set; }

    /// <summary> HttpListenPort equals </summary>
    [JsonProperty("httpListenPort_eq")]
    public System.Int32? HttpListenPort_EQ { get; set; }
    /// <summary> HttpListenPort less than or equal to </summary>
    [JsonProperty("httpListenPort_lte")]
    public System.Int32? HttpListenPort_LTE { get; set; }
    /// <summary> HttpListenPort greater than or equal to </summary>
    [JsonProperty("httpListenPort_gte")]
    public System.Int32? HttpListenPort_GTE { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for Contacts </summary>
public class ContactFilterRequest 
{
    /// <summary> IdIdentityUser equals </summary>
    [JsonProperty("idIdentityUser_eq")]
    public string? IdIdentityUser_EQ { get; set; }
    /// <summary> IdIdentityUser contains </summary>
    [JsonProperty("idIdentityUser_con")]
    public string? IdIdentityUser_CON { get; set; }
    /// <summary> IdIdentityUser regex </summary>
    [JsonProperty("idIdentityUser_reg")]
    public string? IdIdentityUser_REG { get; set; }

    /// <summary> ContactNumbers.SearchIndex equals </summary>
    [JsonProperty("contactNumbers_searchIndex_eq")]
    public string? ContactNumbers_SearchIndex_EQ { get; set; }
    /// <summary> ContactNumbers.SearchIndex contains </summary>
    [JsonProperty("contactNumbers_searchIndex_con")]
    public string? ContactNumbers_SearchIndex_CON { get; set; }
    /// <summary> ContactNumbers.SearchIndex regex </summary>
    [JsonProperty("contactNumbers_searchIndex_reg")]
    public string? ContactNumbers_SearchIndex_REG { get; set; }

    /// <summary> ContactNumbers.Number equals </summary>
    [JsonProperty("contactNumbers_number_eq")]
    public string? ContactNumbers_Number_EQ { get; set; }
    /// <summary> ContactNumbers.Number contains </summary>
    [JsonProperty("contactNumbers_number_con")]
    public string? ContactNumbers_Number_CON { get; set; }
    /// <summary> ContactNumbers.Number regex </summary>
    [JsonProperty("contactNumbers_number_reg")]
    public string? ContactNumbers_Number_REG { get; set; }

    /// <summary> ContactNumbers.NumberInternationalFormat equals </summary>
    [JsonProperty("contactNumbers_numberInternationalFormat_eq")]
    public string? ContactNumbers_NumberInternationalFormat_EQ { get; set; }
    /// <summary> ContactNumbers.NumberInternationalFormat contains </summary>
    [JsonProperty("contactNumbers_numberInternationalFormat_con")]
    public string? ContactNumbers_NumberInternationalFormat_CON { get; set; }
    /// <summary> ContactNumbers.NumberInternationalFormat regex </summary>
    [JsonProperty("contactNumbers_numberInternationalFormat_reg")]
    public string? ContactNumbers_NumberInternationalFormat_REG { get; set; }

    /// <summary> ContactNumbers.Label equals </summary>
    [JsonProperty("contactNumbers_label_eq")]
    public LabelNumber? ContactNumbers_Label_EQ { get; set; }


    /// <summary> ContactEmails.SearchIndex equals </summary>
    [JsonProperty("contactEmails_searchIndex_eq")]
    public string? ContactEmails_SearchIndex_EQ { get; set; }
    /// <summary> ContactEmails.SearchIndex contains </summary>
    [JsonProperty("contactEmails_searchIndex_con")]
    public string? ContactEmails_SearchIndex_CON { get; set; }
    /// <summary> ContactEmails.SearchIndex regex </summary>
    [JsonProperty("contactEmails_searchIndex_reg")]
    public string? ContactEmails_SearchIndex_REG { get; set; }

    /// <summary> ContactEmails.Email equals </summary>
    [JsonProperty("contactEmails_email_eq")]
    public string? ContactEmails_Email_EQ { get; set; }
    /// <summary> ContactEmails.Email contains </summary>
    [JsonProperty("contactEmails_email_con")]
    public string? ContactEmails_Email_CON { get; set; }
    /// <summary> ContactEmails.Email regex </summary>
    [JsonProperty("contactEmails_email_reg")]
    public string? ContactEmails_Email_REG { get; set; }

    /// <summary> ContactEmails.Label equals </summary>
    [JsonProperty("contactEmails_label_eq")]
    public LabelEmailType? ContactEmails_Label_EQ { get; set; }


    /// <summary> FirstName equals </summary>
    [JsonProperty("firstName_eq")]
    public string? FirstName_EQ { get; set; }
    /// <summary> FirstName contains </summary>
    [JsonProperty("firstName_con")]
    public string? FirstName_CON { get; set; }
    /// <summary> FirstName regex </summary>
    [JsonProperty("firstName_reg")]
    public string? FirstName_REG { get; set; }

    /// <summary> LastName equals </summary>
    [JsonProperty("lastName_eq")]
    public string? LastName_EQ { get; set; }
    /// <summary> LastName contains </summary>
    [JsonProperty("lastName_con")]
    public string? LastName_CON { get; set; }
    /// <summary> LastName regex </summary>
    [JsonProperty("lastName_reg")]
    public string? LastName_REG { get; set; }

    /// <summary> JobTittle equals </summary>
    [JsonProperty("jobTittle_eq")]
    public string? JobTittle_EQ { get; set; }
    /// <summary> JobTittle contains </summary>
    [JsonProperty("jobTittle_con")]
    public string? JobTittle_CON { get; set; }
    /// <summary> JobTittle regex </summary>
    [JsonProperty("jobTittle_reg")]
    public string? JobTittle_REG { get; set; }

    /// <summary> Company equals </summary>
    [JsonProperty("company_eq")]
    public string? Company_EQ { get; set; }
    /// <summary> Company contains </summary>
    [JsonProperty("company_con")]
    public string? Company_CON { get; set; }
    /// <summary> Company regex </summary>
    [JsonProperty("company_reg")]
    public string? Company_REG { get; set; }

    /// <summary> Hash equals </summary>
    [JsonProperty("hash_eq")]
    public string? Hash_EQ { get; set; }
    /// <summary> Hash contains </summary>
    [JsonProperty("hash_con")]
    public string? Hash_CON { get; set; }
    /// <summary> Hash regex </summary>
    [JsonProperty("hash_reg")]
    public string? Hash_REG { get; set; }

    /// <summary> Notes equals </summary>
    [JsonProperty("notes_eq")]
    public string? Notes_EQ { get; set; }
    /// <summary> Notes contains </summary>
    [JsonProperty("notes_con")]
    public string? Notes_CON { get; set; }
    /// <summary> Notes regex </summary>
    [JsonProperty("notes_reg")]
    public string? Notes_REG { get; set; }

    /// <summary> Variables.Name equals </summary>
    [JsonProperty("variables_name_eq")]
    public string? Variables_Name_EQ { get; set; }
    /// <summary> Variables.Name contains </summary>
    [JsonProperty("variables_name_con")]
    public string? Variables_Name_CON { get; set; }
    /// <summary> Variables.Name regex </summary>
    [JsonProperty("variables_name_reg")]
    public string? Variables_Name_REG { get; set; }

    /// <summary> Variables.JsonValue equals </summary>
    [JsonProperty("variables_jsonValue_eq")]
    public string? Variables_JsonValue_EQ { get; set; }
    /// <summary> Variables.JsonValue contains </summary>
    [JsonProperty("variables_jsonValue_con")]
    public string? Variables_JsonValue_CON { get; set; }
    /// <summary> Variables.JsonValue regex </summary>
    [JsonProperty("variables_jsonValue_reg")]
    public string? Variables_JsonValue_REG { get; set; }


    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for CustomerInfos </summary>
public class CustomerInfoFilterRequest 
{
    /// <summary> MailingAddress.RecipientName equals </summary>
    [JsonProperty("mailingAddress_recipientName_eq")]
    public string? MailingAddress_RecipientName_EQ { get; set; }
    /// <summary> MailingAddress.RecipientName contains </summary>
    [JsonProperty("mailingAddress_recipientName_con")]
    public string? MailingAddress_RecipientName_CON { get; set; }
    /// <summary> MailingAddress.RecipientName regex </summary>
    [JsonProperty("mailingAddress_recipientName_reg")]
    public string? MailingAddress_RecipientName_REG { get; set; }

    /// <summary> MailingAddress.BusinessName equals </summary>
    [JsonProperty("mailingAddress_businessName_eq")]
    public string? MailingAddress_BusinessName_EQ { get; set; }
    /// <summary> MailingAddress.BusinessName contains </summary>
    [JsonProperty("mailingAddress_businessName_con")]
    public string? MailingAddress_BusinessName_CON { get; set; }
    /// <summary> MailingAddress.BusinessName regex </summary>
    [JsonProperty("mailingAddress_businessName_reg")]
    public string? MailingAddress_BusinessName_REG { get; set; }

    /// <summary> MailingAddress.StreetAddress equals </summary>
    [JsonProperty("mailingAddress_streetAddress_eq")]
    public string? MailingAddress_StreetAddress_EQ { get; set; }
    /// <summary> MailingAddress.StreetAddress contains </summary>
    [JsonProperty("mailingAddress_streetAddress_con")]
    public string? MailingAddress_StreetAddress_CON { get; set; }
    /// <summary> MailingAddress.StreetAddress regex </summary>
    [JsonProperty("mailingAddress_streetAddress_reg")]
    public string? MailingAddress_StreetAddress_REG { get; set; }

    /// <summary> MailingAddress.ApparmentOrSuiteNumber equals </summary>
    [JsonProperty("mailingAddress_apparmentOrSuiteNumber_eq")]
    public string? MailingAddress_ApparmentOrSuiteNumber_EQ { get; set; }
    /// <summary> MailingAddress.ApparmentOrSuiteNumber contains </summary>
    [JsonProperty("mailingAddress_apparmentOrSuiteNumber_con")]
    public string? MailingAddress_ApparmentOrSuiteNumber_CON { get; set; }
    /// <summary> MailingAddress.ApparmentOrSuiteNumber regex </summary>
    [JsonProperty("mailingAddress_apparmentOrSuiteNumber_reg")]
    public string? MailingAddress_ApparmentOrSuiteNumber_REG { get; set; }

    /// <summary> MailingAddress.City equals </summary>
    [JsonProperty("mailingAddress_city_eq")]
    public string? MailingAddress_City_EQ { get; set; }
    /// <summary> MailingAddress.City contains </summary>
    [JsonProperty("mailingAddress_city_con")]
    public string? MailingAddress_City_CON { get; set; }
    /// <summary> MailingAddress.City regex </summary>
    [JsonProperty("mailingAddress_city_reg")]
    public string? MailingAddress_City_REG { get; set; }

    /// <summary> MailingAddress.State equals </summary>
    [JsonProperty("mailingAddress_state_eq")]
    public string? MailingAddress_State_EQ { get; set; }
    /// <summary> MailingAddress.State contains </summary>
    [JsonProperty("mailingAddress_state_con")]
    public string? MailingAddress_State_CON { get; set; }
    /// <summary> MailingAddress.State regex </summary>
    [JsonProperty("mailingAddress_state_reg")]
    public string? MailingAddress_State_REG { get; set; }

    /// <summary> MailingAddress.ZipCode equals </summary>
    [JsonProperty("mailingAddress_zipCode_eq")]
    public string? MailingAddress_ZipCode_EQ { get; set; }
    /// <summary> MailingAddress.ZipCode contains </summary>
    [JsonProperty("mailingAddress_zipCode_con")]
    public string? MailingAddress_ZipCode_CON { get; set; }
    /// <summary> MailingAddress.ZipCode regex </summary>
    [JsonProperty("mailingAddress_zipCode_reg")]
    public string? MailingAddress_ZipCode_REG { get; set; }

    /// <summary> MailingAddress.Country equals </summary>
    [JsonProperty("mailingAddress_country_eq")]
    public CountryIsoCode? MailingAddress_Country_EQ { get; set; }


    /// <summary> AirNetworksCustomerInfo.IdNumber equals </summary>
    [JsonProperty("airNetworksCustomerInfo_idNumber_eq")]
    public string? AirNetworksCustomerInfo_IdNumber_EQ { get; set; }
    /// <summary> AirNetworksCustomerInfo.IdNumber contains </summary>
    [JsonProperty("airNetworksCustomerInfo_idNumber_con")]
    public string? AirNetworksCustomerInfo_IdNumber_CON { get; set; }
    /// <summary> AirNetworksCustomerInfo.IdNumber regex </summary>
    [JsonProperty("airNetworksCustomerInfo_idNumber_reg")]
    public string? AirNetworksCustomerInfo_IdNumber_REG { get; set; }

    /// <summary> AirNetworksCustomerInfo.IdType equals </summary>
    [JsonProperty("airNetworksCustomerInfo_idType_eq")]
    public string? AirNetworksCustomerInfo_IdType_EQ { get; set; }
    /// <summary> AirNetworksCustomerInfo.IdType contains </summary>
    [JsonProperty("airNetworksCustomerInfo_idType_con")]
    public string? AirNetworksCustomerInfo_IdType_CON { get; set; }
    /// <summary> AirNetworksCustomerInfo.IdType regex </summary>
    [JsonProperty("airNetworksCustomerInfo_idType_reg")]
    public string? AirNetworksCustomerInfo_IdType_REG { get; set; }

    /// <summary> AirNetworksCustomerInfo.Province equals </summary>
    [JsonProperty("airNetworksCustomerInfo_province_eq")]
    public string? AirNetworksCustomerInfo_Province_EQ { get; set; }
    /// <summary> AirNetworksCustomerInfo.Province contains </summary>
    [JsonProperty("airNetworksCustomerInfo_province_con")]
    public string? AirNetworksCustomerInfo_Province_CON { get; set; }
    /// <summary> AirNetworksCustomerInfo.Province regex </summary>
    [JsonProperty("airNetworksCustomerInfo_province_reg")]
    public string? AirNetworksCustomerInfo_Province_REG { get; set; }

    /// <summary> AirNetworksCustomerInfo.IdAirNetworksProvince equals </summary>
    [JsonProperty("airNetworksCustomerInfo_idAirNetworksProvince_eq")]
    public string? AirNetworksCustomerInfo_IdAirNetworksProvince_EQ { get; set; }
    /// <summary> AirNetworksCustomerInfo.IdAirNetworksProvince contains </summary>
    [JsonProperty("airNetworksCustomerInfo_idAirNetworksProvince_con")]
    public string? AirNetworksCustomerInfo_IdAirNetworksProvince_CON { get; set; }
    /// <summary> AirNetworksCustomerInfo.IdAirNetworksProvince regex </summary>
    [JsonProperty("airNetworksCustomerInfo_idAirNetworksProvince_reg")]
    public string? AirNetworksCustomerInfo_IdAirNetworksProvince_REG { get; set; }

    /// <summary> AirNetworksCustomerInfo.Population equals </summary>
    [JsonProperty("airNetworksCustomerInfo_population_eq")]
    public string? AirNetworksCustomerInfo_Population_EQ { get; set; }
    /// <summary> AirNetworksCustomerInfo.Population contains </summary>
    [JsonProperty("airNetworksCustomerInfo_population_con")]
    public string? AirNetworksCustomerInfo_Population_CON { get; set; }
    /// <summary> AirNetworksCustomerInfo.Population regex </summary>
    [JsonProperty("airNetworksCustomerInfo_population_reg")]
    public string? AirNetworksCustomerInfo_Population_REG { get; set; }


    /// <summary> FullName equals </summary>
    [JsonProperty("fullName_eq")]
    public string? FullName_EQ { get; set; }
    /// <summary> FullName contains </summary>
    [JsonProperty("fullName_con")]
    public string? FullName_CON { get; set; }
    /// <summary> FullName regex </summary>
    [JsonProperty("fullName_reg")]
    public string? FullName_REG { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for ExtensionCallFlowLogics </summary>
public class ExtensionCallFlowLogicFilterRequest 
{
    /// <summary> IdCallFlowLogic equals </summary>
    [JsonProperty("idCallFlowLogic_eq")]
    public string? IdCallFlowLogic_EQ { get; set; }
    /// <summary> IdCallFlowLogic contains </summary>
    [JsonProperty("idCallFlowLogic_con")]
    public string? IdCallFlowLogic_CON { get; set; }
    /// <summary> IdCallFlowLogic regex </summary>
    [JsonProperty("idCallFlowLogic_reg")]
    public string? IdCallFlowLogic_REG { get; set; }

    /// <summary> CallFlowLabel equals </summary>
    [JsonProperty("callFlowLabel_eq")]
    public string? CallFlowLabel_EQ { get; set; }
    /// <summary> CallFlowLabel contains </summary>
    [JsonProperty("callFlowLabel_con")]
    public string? CallFlowLabel_CON { get; set; }
    /// <summary> CallFlowLabel regex </summary>
    [JsonProperty("callFlowLabel_reg")]
    public string? CallFlowLabel_REG { get; set; }

    /// <summary> TimeZone equals </summary>
    [JsonProperty("timeZone_eq")]
    public string? TimeZone_EQ { get; set; }
    /// <summary> TimeZone contains </summary>
    [JsonProperty("timeZone_con")]
    public string? TimeZone_CON { get; set; }
    /// <summary> TimeZone regex </summary>
    [JsonProperty("timeZone_reg")]
    public string? TimeZone_REG { get; set; }

    /// <summary> ExtensionType equals </summary>
    [JsonProperty("extensionType_eq")]
    public ExtensionType? ExtensionType_EQ { get; set; }

    /// <summary> IdMusicOnHoldGroup equals </summary>
    [JsonProperty("idMusicOnHoldGroup_eq")]
    public string? IdMusicOnHoldGroup_EQ { get; set; }
    /// <summary> IdMusicOnHoldGroup contains </summary>
    [JsonProperty("idMusicOnHoldGroup_con")]
    public string? IdMusicOnHoldGroup_CON { get; set; }
    /// <summary> IdMusicOnHoldGroup regex </summary>
    [JsonProperty("idMusicOnHoldGroup_reg")]
    public string? IdMusicOnHoldGroup_REG { get; set; }

    /// <summary> FriendlyName equals </summary>
    [JsonProperty("friendlyName_eq")]
    public string? FriendlyName_EQ { get; set; }
    /// <summary> FriendlyName contains </summary>
    [JsonProperty("friendlyName_con")]
    public string? FriendlyName_CON { get; set; }
    /// <summary> FriendlyName regex </summary>
    [JsonProperty("friendlyName_reg")]
    public string? FriendlyName_REG { get; set; }

    /// <summary> Number equals </summary>
    [JsonProperty("number_eq")]
    public string? Number_EQ { get; set; }
    /// <summary> Number contains </summary>
    [JsonProperty("number_con")]
    public string? Number_CON { get; set; }
    /// <summary> Number regex </summary>
    [JsonProperty("number_reg")]
    public string? Number_REG { get; set; }

    /// <summary> InjectExtensionNameToCallerId equals </summary>
    [JsonProperty("injectExtensionNameToCallerId_eq")]
    public bool? InjectExtensionNameToCallerId_EQ { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for ExtensionConferences </summary>
public class ExtensionConferenceFilterRequest 
{
    /// <summary> IdsAudiosWhenOneParticipant equals </summary>
    [JsonProperty("idsAudiosWhenOneParticipant_eq")]
    public string? IdsAudiosWhenOneParticipant_EQ { get; set; }
    /// <summary> IdsAudiosWhenOneParticipant contains </summary>
    [JsonProperty("idsAudiosWhenOneParticipant_con")]
    public string? IdsAudiosWhenOneParticipant_CON { get; set; }
    /// <summary> IdsAudiosWhenOneParticipant regex </summary>
    [JsonProperty("idsAudiosWhenOneParticipant_reg")]
    public string? IdsAudiosWhenOneParticipant_REG { get; set; }

    /// <summary> AnnounceParticipants equals </summary>
    [JsonProperty("announceParticipants_eq")]
    public bool? AnnounceParticipants_EQ { get; set; }

    /// <summary> Pin equals </summary>
    [JsonProperty("pin_eq")]
    public string? Pin_EQ { get; set; }
    /// <summary> Pin contains </summary>
    [JsonProperty("pin_con")]
    public string? Pin_CON { get; set; }
    /// <summary> Pin regex </summary>
    [JsonProperty("pin_reg")]
    public string? Pin_REG { get; set; }

    /// <summary> ExtensionType equals </summary>
    [JsonProperty("extensionType_eq")]
    public ExtensionType? ExtensionType_EQ { get; set; }

    /// <summary> IdMusicOnHoldGroup equals </summary>
    [JsonProperty("idMusicOnHoldGroup_eq")]
    public string? IdMusicOnHoldGroup_EQ { get; set; }
    /// <summary> IdMusicOnHoldGroup contains </summary>
    [JsonProperty("idMusicOnHoldGroup_con")]
    public string? IdMusicOnHoldGroup_CON { get; set; }
    /// <summary> IdMusicOnHoldGroup regex </summary>
    [JsonProperty("idMusicOnHoldGroup_reg")]
    public string? IdMusicOnHoldGroup_REG { get; set; }

    /// <summary> FriendlyName equals </summary>
    [JsonProperty("friendlyName_eq")]
    public string? FriendlyName_EQ { get; set; }
    /// <summary> FriendlyName contains </summary>
    [JsonProperty("friendlyName_con")]
    public string? FriendlyName_CON { get; set; }
    /// <summary> FriendlyName regex </summary>
    [JsonProperty("friendlyName_reg")]
    public string? FriendlyName_REG { get; set; }

    /// <summary> Number equals </summary>
    [JsonProperty("number_eq")]
    public string? Number_EQ { get; set; }
    /// <summary> Number contains </summary>
    [JsonProperty("number_con")]
    public string? Number_CON { get; set; }
    /// <summary> Number regex </summary>
    [JsonProperty("number_reg")]
    public string? Number_REG { get; set; }

    /// <summary> InjectExtensionNameToCallerId equals </summary>
    [JsonProperty("injectExtensionNameToCallerId_eq")]
    public bool? InjectExtensionNameToCallerId_EQ { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for ExtensionDials </summary>
public class ExtensionDialFilterRequest 
{
    /// <summary> IdsLines equals </summary>
    [JsonProperty("idsLines_eq")]
    public string? IdsLines_EQ { get; set; }
    /// <summary> IdsLines contains </summary>
    [JsonProperty("idsLines_con")]
    public string? IdsLines_CON { get; set; }
    /// <summary> IdsLines regex </summary>
    [JsonProperty("idsLines_reg")]
    public string? IdsLines_REG { get; set; }

    /// <summary> EventActionToExecuteIfCallIsNotAnswered.EventActionType equals </summary>
    [JsonProperty("eventActionToExecuteIfCallIsNotAnswered_eventActionType_eq")]
    public EventActionType? EventActionToExecuteIfCallIsNotAnswered_EventActionType_EQ { get; set; }


    /// <summary> SendEmailNotificationIfCallIsNotAnswered.Emails equals </summary>
    [JsonProperty("sendEmailNotificationIfCallIsNotAnswered_emails_eq")]
    public string? SendEmailNotificationIfCallIsNotAnswered_Emails_EQ { get; set; }
    /// <summary> SendEmailNotificationIfCallIsNotAnswered.Emails contains </summary>
    [JsonProperty("sendEmailNotificationIfCallIsNotAnswered_emails_con")]
    public string? SendEmailNotificationIfCallIsNotAnswered_Emails_CON { get; set; }
    /// <summary> SendEmailNotificationIfCallIsNotAnswered.Emails regex </summary>
    [JsonProperty("sendEmailNotificationIfCallIsNotAnswered_emails_reg")]
    public string? SendEmailNotificationIfCallIsNotAnswered_Emails_REG { get; set; }

    /// <summary> SendEmailNotificationIfCallIsNotAnswered.PreventSendingNotificationIfCallLastsLessThanNSeconds equals </summary>
    [JsonProperty("sendEmailNotificationIfCallIsNotAnswered_preventSendingNotificationIfCallLastsLessThanNSeconds_eq")]
    public System.Int32? SendEmailNotificationIfCallIsNotAnswered_PreventSendingNotificationIfCallLastsLessThanNSeconds_EQ { get; set; }
    /// <summary> SendEmailNotificationIfCallIsNotAnswered.PreventSendingNotificationIfCallLastsLessThanNSeconds less than or equal to </summary>
    [JsonProperty("sendEmailNotificationIfCallIsNotAnswered_preventSendingNotificationIfCallLastsLessThanNSeconds_lte")]
    public System.Int32? SendEmailNotificationIfCallIsNotAnswered_PreventSendingNotificationIfCallLastsLessThanNSeconds_LTE { get; set; }
    /// <summary> SendEmailNotificationIfCallIsNotAnswered.PreventSendingNotificationIfCallLastsLessThanNSeconds greater than or equal to </summary>
    [JsonProperty("sendEmailNotificationIfCallIsNotAnswered_preventSendingNotificationIfCallLastsLessThanNSeconds_gte")]
    public System.Int32? SendEmailNotificationIfCallIsNotAnswered_PreventSendingNotificationIfCallLastsLessThanNSeconds_GTE { get; set; }


    /// <summary> RingTimeInSeconds equals </summary>
    [JsonProperty("ringTimeInSeconds_eq")]
    public System.Int32? RingTimeInSeconds_EQ { get; set; }
    /// <summary> RingTimeInSeconds less than or equal to </summary>
    [JsonProperty("ringTimeInSeconds_lte")]
    public System.Int32? RingTimeInSeconds_LTE { get; set; }
    /// <summary> RingTimeInSeconds greater than or equal to </summary>
    [JsonProperty("ringTimeInSeconds_gte")]
    public System.Int32? RingTimeInSeconds_GTE { get; set; }

    /// <summary> ExtensionType equals </summary>
    [JsonProperty("extensionType_eq")]
    public ExtensionType? ExtensionType_EQ { get; set; }

    /// <summary> IdMusicOnHoldGroup equals </summary>
    [JsonProperty("idMusicOnHoldGroup_eq")]
    public string? IdMusicOnHoldGroup_EQ { get; set; }
    /// <summary> IdMusicOnHoldGroup contains </summary>
    [JsonProperty("idMusicOnHoldGroup_con")]
    public string? IdMusicOnHoldGroup_CON { get; set; }
    /// <summary> IdMusicOnHoldGroup regex </summary>
    [JsonProperty("idMusicOnHoldGroup_reg")]
    public string? IdMusicOnHoldGroup_REG { get; set; }

    /// <summary> FriendlyName equals </summary>
    [JsonProperty("friendlyName_eq")]
    public string? FriendlyName_EQ { get; set; }
    /// <summary> FriendlyName contains </summary>
    [JsonProperty("friendlyName_con")]
    public string? FriendlyName_CON { get; set; }
    /// <summary> FriendlyName regex </summary>
    [JsonProperty("friendlyName_reg")]
    public string? FriendlyName_REG { get; set; }

    /// <summary> Number equals </summary>
    [JsonProperty("number_eq")]
    public string? Number_EQ { get; set; }
    /// <summary> Number contains </summary>
    [JsonProperty("number_con")]
    public string? Number_CON { get; set; }
    /// <summary> Number regex </summary>
    [JsonProperty("number_reg")]
    public string? Number_REG { get; set; }

    /// <summary> InjectExtensionNameToCallerId equals </summary>
    [JsonProperty("injectExtensionNameToCallerId_eq")]
    public bool? InjectExtensionNameToCallerId_EQ { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for ExtensionQueues </summary>
public class ExtensionQueueFilterRequest 
{
    /// <summary> IdsLines equals </summary>
    [JsonProperty("idsLines_eq")]
    public string? IdsLines_EQ { get; set; }
    /// <summary> IdsLines contains </summary>
    [JsonProperty("idsLines_con")]
    public string? IdsLines_CON { get; set; }
    /// <summary> IdsLines regex </summary>
    [JsonProperty("idsLines_reg")]
    public string? IdsLines_REG { get; set; }

    /// <summary> IdExtensionIfTimeout equals </summary>
    [JsonProperty("idExtensionIfTimeout_eq")]
    public string? IdExtensionIfTimeout_EQ { get; set; }
    /// <summary> IdExtensionIfTimeout contains </summary>
    [JsonProperty("idExtensionIfTimeout_con")]
    public string? IdExtensionIfTimeout_CON { get; set; }
    /// <summary> IdExtensionIfTimeout regex </summary>
    [JsonProperty("idExtensionIfTimeout_reg")]
    public string? IdExtensionIfTimeout_REG { get; set; }

    /// <summary> IdsAudios equals </summary>
    [JsonProperty("idsAudios_eq")]
    public string? IdsAudios_EQ { get; set; }
    /// <summary> IdsAudios contains </summary>
    [JsonProperty("idsAudios_con")]
    public string? IdsAudios_CON { get; set; }
    /// <summary> IdsAudios regex </summary>
    [JsonProperty("idsAudios_reg")]
    public string? IdsAudios_REG { get; set; }

    /// <summary> SendEmailNotificationIfCallIsNotAnswered.Emails equals </summary>
    [JsonProperty("sendEmailNotificationIfCallIsNotAnswered_emails_eq")]
    public string? SendEmailNotificationIfCallIsNotAnswered_Emails_EQ { get; set; }
    /// <summary> SendEmailNotificationIfCallIsNotAnswered.Emails contains </summary>
    [JsonProperty("sendEmailNotificationIfCallIsNotAnswered_emails_con")]
    public string? SendEmailNotificationIfCallIsNotAnswered_Emails_CON { get; set; }
    /// <summary> SendEmailNotificationIfCallIsNotAnswered.Emails regex </summary>
    [JsonProperty("sendEmailNotificationIfCallIsNotAnswered_emails_reg")]
    public string? SendEmailNotificationIfCallIsNotAnswered_Emails_REG { get; set; }

    /// <summary> SendEmailNotificationIfCallIsNotAnswered.PreventSendingNotificationIfCallLastsLessThanNSeconds equals </summary>
    [JsonProperty("sendEmailNotificationIfCallIsNotAnswered_preventSendingNotificationIfCallLastsLessThanNSeconds_eq")]
    public System.Int32? SendEmailNotificationIfCallIsNotAnswered_PreventSendingNotificationIfCallLastsLessThanNSeconds_EQ { get; set; }
    /// <summary> SendEmailNotificationIfCallIsNotAnswered.PreventSendingNotificationIfCallLastsLessThanNSeconds less than or equal to </summary>
    [JsonProperty("sendEmailNotificationIfCallIsNotAnswered_preventSendingNotificationIfCallLastsLessThanNSeconds_lte")]
    public System.Int32? SendEmailNotificationIfCallIsNotAnswered_PreventSendingNotificationIfCallLastsLessThanNSeconds_LTE { get; set; }
    /// <summary> SendEmailNotificationIfCallIsNotAnswered.PreventSendingNotificationIfCallLastsLessThanNSeconds greater than or equal to </summary>
    [JsonProperty("sendEmailNotificationIfCallIsNotAnswered_preventSendingNotificationIfCallLastsLessThanNSeconds_gte")]
    public System.Int32? SendEmailNotificationIfCallIsNotAnswered_PreventSendingNotificationIfCallLastsLessThanNSeconds_GTE { get; set; }


    /// <summary> SendEmailNotificationIfCallTakesToLongToBeAnswered.TimeInSeconds equals </summary>
    [JsonProperty("sendEmailNotificationIfCallTakesToLongToBeAnswered_timeInSeconds_eq")]
    public System.Int32? SendEmailNotificationIfCallTakesToLongToBeAnswered_TimeInSeconds_EQ { get; set; }
    /// <summary> SendEmailNotificationIfCallTakesToLongToBeAnswered.TimeInSeconds less than or equal to </summary>
    [JsonProperty("sendEmailNotificationIfCallTakesToLongToBeAnswered_timeInSeconds_lte")]
    public System.Int32? SendEmailNotificationIfCallTakesToLongToBeAnswered_TimeInSeconds_LTE { get; set; }
    /// <summary> SendEmailNotificationIfCallTakesToLongToBeAnswered.TimeInSeconds greater than or equal to </summary>
    [JsonProperty("sendEmailNotificationIfCallTakesToLongToBeAnswered_timeInSeconds_gte")]
    public System.Int32? SendEmailNotificationIfCallTakesToLongToBeAnswered_TimeInSeconds_GTE { get; set; }

    /// <summary> SendEmailNotificationIfCallTakesToLongToBeAnswered.Email equals </summary>
    [JsonProperty("sendEmailNotificationIfCallTakesToLongToBeAnswered_email_eq")]
    public string? SendEmailNotificationIfCallTakesToLongToBeAnswered_Email_EQ { get; set; }
    /// <summary> SendEmailNotificationIfCallTakesToLongToBeAnswered.Email contains </summary>
    [JsonProperty("sendEmailNotificationIfCallTakesToLongToBeAnswered_email_con")]
    public string? SendEmailNotificationIfCallTakesToLongToBeAnswered_Email_CON { get; set; }
    /// <summary> SendEmailNotificationIfCallTakesToLongToBeAnswered.Email regex </summary>
    [JsonProperty("sendEmailNotificationIfCallTakesToLongToBeAnswered_email_reg")]
    public string? SendEmailNotificationIfCallTakesToLongToBeAnswered_Email_REG { get; set; }


    /// <summary> RingTimeInSeconds equals </summary>
    [JsonProperty("ringTimeInSeconds_eq")]
    public System.Int32? RingTimeInSeconds_EQ { get; set; }
    /// <summary> RingTimeInSeconds less than or equal to </summary>
    [JsonProperty("ringTimeInSeconds_lte")]
    public System.Int32? RingTimeInSeconds_LTE { get; set; }
    /// <summary> RingTimeInSeconds greater than or equal to </summary>
    [JsonProperty("ringTimeInSeconds_gte")]
    public System.Int32? RingTimeInSeconds_GTE { get; set; }

    /// <summary> RingInUse equals </summary>
    [JsonProperty("ringInUse_eq")]
    public bool? RingInUse_EQ { get; set; }

    /// <summary> QueueTimeoutInMinutes equals </summary>
    [JsonProperty("queueTimeoutInMinutes_eq")]
    public System.Int32? QueueTimeoutInMinutes_EQ { get; set; }
    /// <summary> QueueTimeoutInMinutes less than or equal to </summary>
    [JsonProperty("queueTimeoutInMinutes_lte")]
    public System.Int32? QueueTimeoutInMinutes_LTE { get; set; }
    /// <summary> QueueTimeoutInMinutes greater than or equal to </summary>
    [JsonProperty("queueTimeoutInMinutes_gte")]
    public System.Int32? QueueTimeoutInMinutes_GTE { get; set; }

    /// <summary> PlayPositionAnnouncements equals </summary>
    [JsonProperty("playPositionAnnouncements_eq")]
    public bool? PlayPositionAnnouncements_EQ { get; set; }

    /// <summary> RetryFrequency equals </summary>
    [JsonProperty("retryFrequency_eq")]
    public System.Int32? RetryFrequency_EQ { get; set; }
    /// <summary> RetryFrequency less than or equal to </summary>
    [JsonProperty("retryFrequency_lte")]
    public System.Int32? RetryFrequency_LTE { get; set; }
    /// <summary> RetryFrequency greater than or equal to </summary>
    [JsonProperty("retryFrequency_gte")]
    public System.Int32? RetryFrequency_GTE { get; set; }

    /// <summary> RingStrategy equals </summary>
    [JsonProperty("ringStrategy_eq")]
    public QueueRingStrategy? RingStrategy_EQ { get; set; }

    /// <summary> ExtensionType equals </summary>
    [JsonProperty("extensionType_eq")]
    public ExtensionType? ExtensionType_EQ { get; set; }

    /// <summary> IdMusicOnHoldGroup equals </summary>
    [JsonProperty("idMusicOnHoldGroup_eq")]
    public string? IdMusicOnHoldGroup_EQ { get; set; }
    /// <summary> IdMusicOnHoldGroup contains </summary>
    [JsonProperty("idMusicOnHoldGroup_con")]
    public string? IdMusicOnHoldGroup_CON { get; set; }
    /// <summary> IdMusicOnHoldGroup regex </summary>
    [JsonProperty("idMusicOnHoldGroup_reg")]
    public string? IdMusicOnHoldGroup_REG { get; set; }

    /// <summary> FriendlyName equals </summary>
    [JsonProperty("friendlyName_eq")]
    public string? FriendlyName_EQ { get; set; }
    /// <summary> FriendlyName contains </summary>
    [JsonProperty("friendlyName_con")]
    public string? FriendlyName_CON { get; set; }
    /// <summary> FriendlyName regex </summary>
    [JsonProperty("friendlyName_reg")]
    public string? FriendlyName_REG { get; set; }

    /// <summary> Number equals </summary>
    [JsonProperty("number_eq")]
    public string? Number_EQ { get; set; }
    /// <summary> Number contains </summary>
    [JsonProperty("number_con")]
    public string? Number_CON { get; set; }
    /// <summary> Number regex </summary>
    [JsonProperty("number_reg")]
    public string? Number_REG { get; set; }

    /// <summary> InjectExtensionNameToCallerId equals </summary>
    [JsonProperty("injectExtensionNameToCallerId_eq")]
    public bool? InjectExtensionNameToCallerId_EQ { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for ExtensionVoicemails </summary>
public class ExtensionVoicemailFilterRequest 
{
    /// <summary> IdAudio equals </summary>
    [JsonProperty("idAudio_eq")]
    public string? IdAudio_EQ { get; set; }
    /// <summary> IdAudio contains </summary>
    [JsonProperty("idAudio_con")]
    public string? IdAudio_CON { get; set; }
    /// <summary> IdAudio regex </summary>
    [JsonProperty("idAudio_reg")]
    public string? IdAudio_REG { get; set; }

    /// <summary> IdsLinesThatCanListenToVoicemail equals </summary>
    [JsonProperty("idsLinesThatCanListenToVoicemail_eq")]
    public string? IdsLinesThatCanListenToVoicemail_EQ { get; set; }
    /// <summary> IdsLinesThatCanListenToVoicemail contains </summary>
    [JsonProperty("idsLinesThatCanListenToVoicemail_con")]
    public string? IdsLinesThatCanListenToVoicemail_CON { get; set; }
    /// <summary> IdsLinesThatCanListenToVoicemail regex </summary>
    [JsonProperty("idsLinesThatCanListenToVoicemail_reg")]
    public string? IdsLinesThatCanListenToVoicemail_REG { get; set; }

    /// <summary> Email equals </summary>
    [JsonProperty("email_eq")]
    public string? Email_EQ { get; set; }
    /// <summary> Email contains </summary>
    [JsonProperty("email_con")]
    public string? Email_CON { get; set; }
    /// <summary> Email regex </summary>
    [JsonProperty("email_reg")]
    public string? Email_REG { get; set; }

    /// <summary> TextToSpeech equals </summary>
    [JsonProperty("textToSpeech_eq")]
    public string? TextToSpeech_EQ { get; set; }
    /// <summary> TextToSpeech contains </summary>
    [JsonProperty("textToSpeech_con")]
    public string? TextToSpeech_CON { get; set; }
    /// <summary> TextToSpeech regex </summary>
    [JsonProperty("textToSpeech_reg")]
    public string? TextToSpeech_REG { get; set; }

    /// <summary> TextToSpeechVoiceId equals </summary>
    [JsonProperty("textToSpeechVoiceId_eq")]
    public string? TextToSpeechVoiceId_EQ { get; set; }
    /// <summary> TextToSpeechVoiceId contains </summary>
    [JsonProperty("textToSpeechVoiceId_con")]
    public string? TextToSpeechVoiceId_CON { get; set; }
    /// <summary> TextToSpeechVoiceId regex </summary>
    [JsonProperty("textToSpeechVoiceId_reg")]
    public string? TextToSpeechVoiceId_REG { get; set; }

    /// <summary> ExtensionType equals </summary>
    [JsonProperty("extensionType_eq")]
    public ExtensionType? ExtensionType_EQ { get; set; }

    /// <summary> IdMusicOnHoldGroup equals </summary>
    [JsonProperty("idMusicOnHoldGroup_eq")]
    public string? IdMusicOnHoldGroup_EQ { get; set; }
    /// <summary> IdMusicOnHoldGroup contains </summary>
    [JsonProperty("idMusicOnHoldGroup_con")]
    public string? IdMusicOnHoldGroup_CON { get; set; }
    /// <summary> IdMusicOnHoldGroup regex </summary>
    [JsonProperty("idMusicOnHoldGroup_reg")]
    public string? IdMusicOnHoldGroup_REG { get; set; }

    /// <summary> FriendlyName equals </summary>
    [JsonProperty("friendlyName_eq")]
    public string? FriendlyName_EQ { get; set; }
    /// <summary> FriendlyName contains </summary>
    [JsonProperty("friendlyName_con")]
    public string? FriendlyName_CON { get; set; }
    /// <summary> FriendlyName regex </summary>
    [JsonProperty("friendlyName_reg")]
    public string? FriendlyName_REG { get; set; }

    /// <summary> Number equals </summary>
    [JsonProperty("number_eq")]
    public string? Number_EQ { get; set; }
    /// <summary> Number contains </summary>
    [JsonProperty("number_con")]
    public string? Number_CON { get; set; }
    /// <summary> Number regex </summary>
    [JsonProperty("number_reg")]
    public string? Number_REG { get; set; }

    /// <summary> InjectExtensionNameToCallerId equals </summary>
    [JsonProperty("injectExtensionNameToCallerId_eq")]
    public bool? InjectExtensionNameToCallerId_EQ { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for FaxEmailInfos </summary>
public class FaxEmailInfoFilterRequest 
{
    /// <summary> LineThatValidatedEmail.FriendlyName equals </summary>
    [JsonProperty("lineThatValidatedEmail_friendlyName_eq")]
    public string? LineThatValidatedEmail_FriendlyName_EQ { get; set; }
    /// <summary> LineThatValidatedEmail.FriendlyName contains </summary>
    [JsonProperty("lineThatValidatedEmail_friendlyName_con")]
    public string? LineThatValidatedEmail_FriendlyName_CON { get; set; }
    /// <summary> LineThatValidatedEmail.FriendlyName regex </summary>
    [JsonProperty("lineThatValidatedEmail_friendlyName_reg")]
    public string? LineThatValidatedEmail_FriendlyName_REG { get; set; }

    /// <summary> LineThatValidatedEmail.LineConnectionStatus.IpWAN equals </summary>
    [JsonProperty("lineThatValidatedEmail_lineConnectionStatus_ipWAN_eq")]
    public string? LineThatValidatedEmail_LineConnectionStatus_IpWAN_EQ { get; set; }
    /// <summary> LineThatValidatedEmail.LineConnectionStatus.IpWAN contains </summary>
    [JsonProperty("lineThatValidatedEmail_lineConnectionStatus_ipWAN_con")]
    public string? LineThatValidatedEmail_LineConnectionStatus_IpWAN_CON { get; set; }
    /// <summary> LineThatValidatedEmail.LineConnectionStatus.IpWAN regex </summary>
    [JsonProperty("lineThatValidatedEmail_lineConnectionStatus_ipWAN_reg")]
    public string? LineThatValidatedEmail_LineConnectionStatus_IpWAN_REG { get; set; }

    /// <summary> LineThatValidatedEmail.LineConnectionStatus.PortWAN equals </summary>
    [JsonProperty("lineThatValidatedEmail_lineConnectionStatus_portWAN_eq")]
    public System.Int32? LineThatValidatedEmail_LineConnectionStatus_PortWAN_EQ { get; set; }
    /// <summary> LineThatValidatedEmail.LineConnectionStatus.PortWAN less than or equal to </summary>
    [JsonProperty("lineThatValidatedEmail_lineConnectionStatus_portWAN_lte")]
    public System.Int32? LineThatValidatedEmail_LineConnectionStatus_PortWAN_LTE { get; set; }
    /// <summary> LineThatValidatedEmail.LineConnectionStatus.PortWAN greater than or equal to </summary>
    [JsonProperty("lineThatValidatedEmail_lineConnectionStatus_portWAN_gte")]
    public System.Int32? LineThatValidatedEmail_LineConnectionStatus_PortWAN_GTE { get; set; }

    /// <summary> LineThatValidatedEmail.LineConnectionStatus.IpLAN equals </summary>
    [JsonProperty("lineThatValidatedEmail_lineConnectionStatus_ipLAN_eq")]
    public string? LineThatValidatedEmail_LineConnectionStatus_IpLAN_EQ { get; set; }
    /// <summary> LineThatValidatedEmail.LineConnectionStatus.IpLAN contains </summary>
    [JsonProperty("lineThatValidatedEmail_lineConnectionStatus_ipLAN_con")]
    public string? LineThatValidatedEmail_LineConnectionStatus_IpLAN_CON { get; set; }
    /// <summary> LineThatValidatedEmail.LineConnectionStatus.IpLAN regex </summary>
    [JsonProperty("lineThatValidatedEmail_lineConnectionStatus_ipLAN_reg")]
    public string? LineThatValidatedEmail_LineConnectionStatus_IpLAN_REG { get; set; }

    /// <summary> LineThatValidatedEmail.LineConnectionStatus.PortLAN equals </summary>
    [JsonProperty("lineThatValidatedEmail_lineConnectionStatus_portLAN_eq")]
    public System.Int32? LineThatValidatedEmail_LineConnectionStatus_PortLAN_EQ { get; set; }
    /// <summary> LineThatValidatedEmail.LineConnectionStatus.PortLAN less than or equal to </summary>
    [JsonProperty("lineThatValidatedEmail_lineConnectionStatus_portLAN_lte")]
    public System.Int32? LineThatValidatedEmail_LineConnectionStatus_PortLAN_LTE { get; set; }
    /// <summary> LineThatValidatedEmail.LineConnectionStatus.PortLAN greater than or equal to </summary>
    [JsonProperty("lineThatValidatedEmail_lineConnectionStatus_portLAN_gte")]
    public System.Int32? LineThatValidatedEmail_LineConnectionStatus_PortLAN_GTE { get; set; }

    /// <summary> LineThatValidatedEmail.LineConnectionStatus.UserAgent equals </summary>
    [JsonProperty("lineThatValidatedEmail_lineConnectionStatus_userAgent_eq")]
    public string? LineThatValidatedEmail_LineConnectionStatus_UserAgent_EQ { get; set; }
    /// <summary> LineThatValidatedEmail.LineConnectionStatus.UserAgent contains </summary>
    [JsonProperty("lineThatValidatedEmail_lineConnectionStatus_userAgent_con")]
    public string? LineThatValidatedEmail_LineConnectionStatus_UserAgent_CON { get; set; }
    /// <summary> LineThatValidatedEmail.LineConnectionStatus.UserAgent regex </summary>
    [JsonProperty("lineThatValidatedEmail_lineConnectionStatus_userAgent_reg")]
    public string? LineThatValidatedEmail_LineConnectionStatus_UserAgent_REG { get; set; }

    /// <summary> LineThatValidatedEmail.LineConnectionStatus.IsConnected equals </summary>
    [JsonProperty("lineThatValidatedEmail_lineConnectionStatus_isConnected_eq")]
    public bool? LineThatValidatedEmail_LineConnectionStatus_IsConnected_EQ { get; set; }

    /// <summary> LineThatValidatedEmail.LineConnectionStatus.DisconnectedReason equals </summary>
    [JsonProperty("lineThatValidatedEmail_lineConnectionStatus_disconnectedReason_eq")]
    public string? LineThatValidatedEmail_LineConnectionStatus_DisconnectedReason_EQ { get; set; }
    /// <summary> LineThatValidatedEmail.LineConnectionStatus.DisconnectedReason contains </summary>
    [JsonProperty("lineThatValidatedEmail_lineConnectionStatus_disconnectedReason_con")]
    public string? LineThatValidatedEmail_LineConnectionStatus_DisconnectedReason_CON { get; set; }
    /// <summary> LineThatValidatedEmail.LineConnectionStatus.DisconnectedReason regex </summary>
    [JsonProperty("lineThatValidatedEmail_lineConnectionStatus_disconnectedReason_reg")]
    public string? LineThatValidatedEmail_LineConnectionStatus_DisconnectedReason_REG { get; set; }

    /// <summary> LineThatValidatedEmail.LineConnectionStatus.DateConnected equals </summary>
    [JsonProperty("lineThatValidatedEmail_lineConnectionStatus_dateConnected_eq")]
    public DateTime? LineThatValidatedEmail_LineConnectionStatus_DateConnected_EQ { get; set; }
    /// <summary> LineThatValidatedEmail.LineConnectionStatus.DateConnected less than or equal to </summary>
    [JsonProperty("lineThatValidatedEmail_lineConnectionStatus_dateConnected_lte")]
    public DateTime? LineThatValidatedEmail_LineConnectionStatus_DateConnected_LTE { get; set; }
    /// <summary> LineThatValidatedEmail.LineConnectionStatus.DateConnected greater than or equal to </summary>
    [JsonProperty("lineThatValidatedEmail_lineConnectionStatus_dateConnected_gte")]
    public DateTime? LineThatValidatedEmail_LineConnectionStatus_DateConnected_GTE { get; set; }

    /// <summary> LineThatValidatedEmail.LineConnectionStatus.DateDisconnected equals </summary>
    [JsonProperty("lineThatValidatedEmail_lineConnectionStatus_dateDisconnected_eq")]
    public DateTime? LineThatValidatedEmail_LineConnectionStatus_DateDisconnected_EQ { get; set; }
    /// <summary> LineThatValidatedEmail.LineConnectionStatus.DateDisconnected less than or equal to </summary>
    [JsonProperty("lineThatValidatedEmail_lineConnectionStatus_dateDisconnected_lte")]
    public DateTime? LineThatValidatedEmail_LineConnectionStatus_DateDisconnected_LTE { get; set; }
    /// <summary> LineThatValidatedEmail.LineConnectionStatus.DateDisconnected greater than or equal to </summary>
    [JsonProperty("lineThatValidatedEmail_lineConnectionStatus_dateDisconnected_gte")]
    public DateTime? LineThatValidatedEmail_LineConnectionStatus_DateDisconnected_GTE { get; set; }


    /// <summary> LineThatValidatedEmail.CallerIdNumber equals </summary>
    [JsonProperty("lineThatValidatedEmail_callerIdNumber_eq")]
    public string? LineThatValidatedEmail_CallerIdNumber_EQ { get; set; }
    /// <summary> LineThatValidatedEmail.CallerIdNumber contains </summary>
    [JsonProperty("lineThatValidatedEmail_callerIdNumber_con")]
    public string? LineThatValidatedEmail_CallerIdNumber_CON { get; set; }
    /// <summary> LineThatValidatedEmail.CallerIdNumber regex </summary>
    [JsonProperty("lineThatValidatedEmail_callerIdNumber_reg")]
    public string? LineThatValidatedEmail_CallerIdNumber_REG { get; set; }

    /// <summary> LineThatValidatedEmail.RecordExternalCalls equals </summary>
    [JsonProperty("lineThatValidatedEmail_recordExternalCalls_eq")]
    public bool? LineThatValidatedEmail_RecordExternalCalls_EQ { get; set; }

    /// <summary> LineThatValidatedEmail.RecordInternalCalls equals </summary>
    [JsonProperty("lineThatValidatedEmail_recordInternalCalls_eq")]
    public bool? LineThatValidatedEmail_RecordInternalCalls_EQ { get; set; }

    /// <summary> LineThatValidatedEmail.Language equals </summary>
    [JsonProperty("lineThatValidatedEmail_language_eq")]
    public Language? LineThatValidatedEmail_Language_EQ { get; set; }

    /// <summary> LineThatValidatedEmail.Id equals </summary>
    [JsonProperty("lineThatValidatedEmail_id_eq")]
    public string? LineThatValidatedEmail_Id_EQ { get; set; }
    /// <summary> LineThatValidatedEmail.Id contains </summary>
    [JsonProperty("lineThatValidatedEmail_id_con")]
    public string? LineThatValidatedEmail_Id_CON { get; set; }
    /// <summary> LineThatValidatedEmail.Id regex </summary>
    [JsonProperty("lineThatValidatedEmail_id_reg")]
    public string? LineThatValidatedEmail_Id_REG { get; set; }


    /// <summary> NumberOfEmailsReceived equals </summary>
    [JsonProperty("numberOfEmailsReceived_eq")]
    public System.Int32? NumberOfEmailsReceived_EQ { get; set; }
    /// <summary> NumberOfEmailsReceived less than or equal to </summary>
    [JsonProperty("numberOfEmailsReceived_lte")]
    public System.Int32? NumberOfEmailsReceived_LTE { get; set; }
    /// <summary> NumberOfEmailsReceived greater than or equal to </summary>
    [JsonProperty("numberOfEmailsReceived_gte")]
    public System.Int32? NumberOfEmailsReceived_GTE { get; set; }

    /// <summary> ReplyStatus equals </summary>
    [JsonProperty("replyStatus_eq")]
    public LinkFaxToEmailStatus? ReplyStatus_EQ { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for FaxIncomings </summary>
public class FaxIncomingFilterRequest 
{
    /// <summary> IdVoipNumberFax equals </summary>
    [JsonProperty("idVoipNumberFax_eq")]
    public string? IdVoipNumberFax_EQ { get; set; }
    /// <summary> IdVoipNumberFax contains </summary>
    [JsonProperty("idVoipNumberFax_con")]
    public string? IdVoipNumberFax_CON { get; set; }
    /// <summary> IdVoipNumberFax regex </summary>
    [JsonProperty("idVoipNumberFax_reg")]
    public string? IdVoipNumberFax_REG { get; set; }

    /// <summary> Pdf.InstanceId equals </summary>
    [JsonProperty("pdf_instanceId_eq")]
    public string? Pdf_InstanceId_EQ { get; set; }
    /// <summary> Pdf.InstanceId contains </summary>
    [JsonProperty("pdf_instanceId_con")]
    public string? Pdf_InstanceId_CON { get; set; }
    /// <summary> Pdf.InstanceId regex </summary>
    [JsonProperty("pdf_instanceId_reg")]
    public string? Pdf_InstanceId_REG { get; set; }

    /// <summary> Pdf.FileSizeInBytes equals </summary>
    [JsonProperty("pdf_fileSizeInBytes_eq")]
    public System.Int32? Pdf_FileSizeInBytes_EQ { get; set; }
    /// <summary> Pdf.FileSizeInBytes less than or equal to </summary>
    [JsonProperty("pdf_fileSizeInBytes_lte")]
    public System.Int32? Pdf_FileSizeInBytes_LTE { get; set; }
    /// <summary> Pdf.FileSizeInBytes greater than or equal to </summary>
    [JsonProperty("pdf_fileSizeInBytes_gte")]
    public System.Int32? Pdf_FileSizeInBytes_GTE { get; set; }

    /// <summary> Pdf.Md5Hash equals </summary>
    [JsonProperty("pdf_md5Hash_eq")]
    public string? Pdf_Md5Hash_EQ { get; set; }
    /// <summary> Pdf.Md5Hash contains </summary>
    [JsonProperty("pdf_md5Hash_con")]
    public string? Pdf_Md5Hash_CON { get; set; }
    /// <summary> Pdf.Md5Hash regex </summary>
    [JsonProperty("pdf_md5Hash_reg")]
    public string? Pdf_Md5Hash_REG { get; set; }

    /// <summary> Pdf.Url equals </summary>
    [JsonProperty("pdf_url_eq")]
    public string? Pdf_Url_EQ { get; set; }
    /// <summary> Pdf.Url contains </summary>
    [JsonProperty("pdf_url_con")]
    public string? Pdf_Url_CON { get; set; }
    /// <summary> Pdf.Url regex </summary>
    [JsonProperty("pdf_url_reg")]
    public string? Pdf_Url_REG { get; set; }

    /// <summary> Pdf.Id equals </summary>
    [JsonProperty("pdf_id_eq")]
    public string? Pdf_Id_EQ { get; set; }
    /// <summary> Pdf.Id contains </summary>
    [JsonProperty("pdf_id_con")]
    public string? Pdf_Id_CON { get; set; }
    /// <summary> Pdf.Id regex </summary>
    [JsonProperty("pdf_id_reg")]
    public string? Pdf_Id_REG { get; set; }


    /// <summary> NumPages equals </summary>
    [JsonProperty("numPages_eq")]
    public System.Int32? NumPages_EQ { get; set; }
    /// <summary> NumPages less than or equal to </summary>
    [JsonProperty("numPages_lte")]
    public System.Int32? NumPages_LTE { get; set; }
    /// <summary> NumPages greater than or equal to </summary>
    [JsonProperty("numPages_gte")]
    public System.Int32? NumPages_GTE { get; set; }

    /// <summary> FaxStatus equals </summary>
    [JsonProperty("faxStatus_eq")]
    public string? FaxStatus_EQ { get; set; }
    /// <summary> FaxStatus contains </summary>
    [JsonProperty("faxStatus_con")]
    public string? FaxStatus_CON { get; set; }
    /// <summary> FaxStatus regex </summary>
    [JsonProperty("faxStatus_reg")]
    public string? FaxStatus_REG { get; set; }

    /// <summary> From equals </summary>
    [JsonProperty("from_eq")]
    public string? From_EQ { get; set; }
    /// <summary> From contains </summary>
    [JsonProperty("from_con")]
    public string? From_CON { get; set; }
    /// <summary> From regex </summary>
    [JsonProperty("from_reg")]
    public string? From_REG { get; set; }

    /// <summary> To equals </summary>
    [JsonProperty("to_eq")]
    public string? To_EQ { get; set; }
    /// <summary> To contains </summary>
    [JsonProperty("to_con")]
    public string? To_CON { get; set; }
    /// <summary> To regex </summary>
    [JsonProperty("to_reg")]
    public string? To_REG { get; set; }

    /// <summary> ErrorMessage equals </summary>
    [JsonProperty("errorMessage_eq")]
    public string? ErrorMessage_EQ { get; set; }
    /// <summary> ErrorMessage contains </summary>
    [JsonProperty("errorMessage_con")]
    public string? ErrorMessage_CON { get; set; }
    /// <summary> ErrorMessage regex </summary>
    [JsonProperty("errorMessage_reg")]
    public string? ErrorMessage_REG { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for FaxOutgoingGroups </summary>
public class FaxOutgoingGroupFilterRequest 
{
    /// <summary> IdVoipNumberFax equals </summary>
    [JsonProperty("idVoipNumberFax_eq")]
    public string? IdVoipNumberFax_EQ { get; set; }
    /// <summary> IdVoipNumberFax contains </summary>
    [JsonProperty("idVoipNumberFax_con")]
    public string? IdVoipNumberFax_CON { get; set; }
    /// <summary> IdVoipNumberFax regex </summary>
    [JsonProperty("idVoipNumberFax_reg")]
    public string? IdVoipNumberFax_REG { get; set; }

    /// <summary> FaxesOutgoing.NumberOfPages equals </summary>
    [JsonProperty("faxesOutgoing_numberOfPages_eq")]
    public System.Int32? FaxesOutgoing_NumberOfPages_EQ { get; set; }
    /// <summary> FaxesOutgoing.NumberOfPages less than or equal to </summary>
    [JsonProperty("faxesOutgoing_numberOfPages_lte")]
    public System.Int32? FaxesOutgoing_NumberOfPages_LTE { get; set; }
    /// <summary> FaxesOutgoing.NumberOfPages greater than or equal to </summary>
    [JsonProperty("faxesOutgoing_numberOfPages_gte")]
    public System.Int32? FaxesOutgoing_NumberOfPages_GTE { get; set; }

    /// <summary> FaxesOutgoing.FaxStatus equals </summary>
    [JsonProperty("faxesOutgoing_faxStatus_eq")]
    public string? FaxesOutgoing_FaxStatus_EQ { get; set; }
    /// <summary> FaxesOutgoing.FaxStatus contains </summary>
    [JsonProperty("faxesOutgoing_faxStatus_con")]
    public string? FaxesOutgoing_FaxStatus_CON { get; set; }
    /// <summary> FaxesOutgoing.FaxStatus regex </summary>
    [JsonProperty("faxesOutgoing_faxStatus_reg")]
    public string? FaxesOutgoing_FaxStatus_REG { get; set; }

    /// <summary> FaxesOutgoing.To equals </summary>
    [JsonProperty("faxesOutgoing_to_eq")]
    public string? FaxesOutgoing_To_EQ { get; set; }
    /// <summary> FaxesOutgoing.To contains </summary>
    [JsonProperty("faxesOutgoing_to_con")]
    public string? FaxesOutgoing_To_CON { get; set; }
    /// <summary> FaxesOutgoing.To regex </summary>
    [JsonProperty("faxesOutgoing_to_reg")]
    public string? FaxesOutgoing_To_REG { get; set; }

    /// <summary> FaxesOutgoing.ErrorMessage equals </summary>
    [JsonProperty("faxesOutgoing_errorMessage_eq")]
    public string? FaxesOutgoing_ErrorMessage_EQ { get; set; }
    /// <summary> FaxesOutgoing.ErrorMessage contains </summary>
    [JsonProperty("faxesOutgoing_errorMessage_con")]
    public string? FaxesOutgoing_ErrorMessage_CON { get; set; }
    /// <summary> FaxesOutgoing.ErrorMessage regex </summary>
    [JsonProperty("faxesOutgoing_errorMessage_reg")]
    public string? FaxesOutgoing_ErrorMessage_REG { get; set; }

    /// <summary> FaxesOutgoing.Pdf.InstanceId equals </summary>
    [JsonProperty("faxesOutgoing_pdf_instanceId_eq")]
    public string? FaxesOutgoing_Pdf_InstanceId_EQ { get; set; }
    /// <summary> FaxesOutgoing.Pdf.InstanceId contains </summary>
    [JsonProperty("faxesOutgoing_pdf_instanceId_con")]
    public string? FaxesOutgoing_Pdf_InstanceId_CON { get; set; }
    /// <summary> FaxesOutgoing.Pdf.InstanceId regex </summary>
    [JsonProperty("faxesOutgoing_pdf_instanceId_reg")]
    public string? FaxesOutgoing_Pdf_InstanceId_REG { get; set; }

    /// <summary> FaxesOutgoing.Pdf.FileSizeInBytes equals </summary>
    [JsonProperty("faxesOutgoing_pdf_fileSizeInBytes_eq")]
    public System.Int32? FaxesOutgoing_Pdf_FileSizeInBytes_EQ { get; set; }
    /// <summary> FaxesOutgoing.Pdf.FileSizeInBytes less than or equal to </summary>
    [JsonProperty("faxesOutgoing_pdf_fileSizeInBytes_lte")]
    public System.Int32? FaxesOutgoing_Pdf_FileSizeInBytes_LTE { get; set; }
    /// <summary> FaxesOutgoing.Pdf.FileSizeInBytes greater than or equal to </summary>
    [JsonProperty("faxesOutgoing_pdf_fileSizeInBytes_gte")]
    public System.Int32? FaxesOutgoing_Pdf_FileSizeInBytes_GTE { get; set; }

    /// <summary> FaxesOutgoing.Pdf.Md5Hash equals </summary>
    [JsonProperty("faxesOutgoing_pdf_md5Hash_eq")]
    public string? FaxesOutgoing_Pdf_Md5Hash_EQ { get; set; }
    /// <summary> FaxesOutgoing.Pdf.Md5Hash contains </summary>
    [JsonProperty("faxesOutgoing_pdf_md5Hash_con")]
    public string? FaxesOutgoing_Pdf_Md5Hash_CON { get; set; }
    /// <summary> FaxesOutgoing.Pdf.Md5Hash regex </summary>
    [JsonProperty("faxesOutgoing_pdf_md5Hash_reg")]
    public string? FaxesOutgoing_Pdf_Md5Hash_REG { get; set; }

    /// <summary> FaxesOutgoing.Pdf.Url equals </summary>
    [JsonProperty("faxesOutgoing_pdf_url_eq")]
    public string? FaxesOutgoing_Pdf_Url_EQ { get; set; }
    /// <summary> FaxesOutgoing.Pdf.Url contains </summary>
    [JsonProperty("faxesOutgoing_pdf_url_con")]
    public string? FaxesOutgoing_Pdf_Url_CON { get; set; }
    /// <summary> FaxesOutgoing.Pdf.Url regex </summary>
    [JsonProperty("faxesOutgoing_pdf_url_reg")]
    public string? FaxesOutgoing_Pdf_Url_REG { get; set; }

    /// <summary> FaxesOutgoing.Pdf.Id equals </summary>
    [JsonProperty("faxesOutgoing_pdf_id_eq")]
    public string? FaxesOutgoing_Pdf_Id_EQ { get; set; }
    /// <summary> FaxesOutgoing.Pdf.Id contains </summary>
    [JsonProperty("faxesOutgoing_pdf_id_con")]
    public string? FaxesOutgoing_Pdf_Id_CON { get; set; }
    /// <summary> FaxesOutgoing.Pdf.Id regex </summary>
    [JsonProperty("faxesOutgoing_pdf_id_reg")]
    public string? FaxesOutgoing_Pdf_Id_REG { get; set; }


    /// <summary> FaxesOutgoing.NumberOfPagesSent equals </summary>
    [JsonProperty("faxesOutgoing_numberOfPagesSent_eq")]
    public System.Int32? FaxesOutgoing_NumberOfPagesSent_EQ { get; set; }
    /// <summary> FaxesOutgoing.NumberOfPagesSent less than or equal to </summary>
    [JsonProperty("faxesOutgoing_numberOfPagesSent_lte")]
    public System.Int32? FaxesOutgoing_NumberOfPagesSent_LTE { get; set; }
    /// <summary> FaxesOutgoing.NumberOfPagesSent greater than or equal to </summary>
    [JsonProperty("faxesOutgoing_numberOfPagesSent_gte")]
    public System.Int32? FaxesOutgoing_NumberOfPagesSent_GTE { get; set; }

    /// <summary> FaxesOutgoing.IsPortrait equals </summary>
    [JsonProperty("faxesOutgoing_isPortrait_eq")]
    public bool? FaxesOutgoing_IsPortrait_EQ { get; set; }

    /// <summary> FaxesOutgoing.Name equals </summary>
    [JsonProperty("faxesOutgoing_name_eq")]
    public string? FaxesOutgoing_Name_EQ { get; set; }
    /// <summary> FaxesOutgoing.Name contains </summary>
    [JsonProperty("faxesOutgoing_name_con")]
    public string? FaxesOutgoing_Name_CON { get; set; }
    /// <summary> FaxesOutgoing.Name regex </summary>
    [JsonProperty("faxesOutgoing_name_reg")]
    public string? FaxesOutgoing_Name_REG { get; set; }

    /// <summary> FaxesOutgoing.NumberOfAttempts equals </summary>
    [JsonProperty("faxesOutgoing_numberOfAttempts_eq")]
    public System.Int32? FaxesOutgoing_NumberOfAttempts_EQ { get; set; }
    /// <summary> FaxesOutgoing.NumberOfAttempts less than or equal to </summary>
    [JsonProperty("faxesOutgoing_numberOfAttempts_lte")]
    public System.Int32? FaxesOutgoing_NumberOfAttempts_LTE { get; set; }
    /// <summary> FaxesOutgoing.NumberOfAttempts greater than or equal to </summary>
    [JsonProperty("faxesOutgoing_numberOfAttempts_gte")]
    public System.Int32? FaxesOutgoing_NumberOfAttempts_GTE { get; set; }

    /// <summary> FaxesOutgoing.Id equals </summary>
    [JsonProperty("faxesOutgoing_id_eq")]
    public string? FaxesOutgoing_Id_EQ { get; set; }
    /// <summary> FaxesOutgoing.Id contains </summary>
    [JsonProperty("faxesOutgoing_id_con")]
    public string? FaxesOutgoing_Id_CON { get; set; }
    /// <summary> FaxesOutgoing.Id regex </summary>
    [JsonProperty("faxesOutgoing_id_reg")]
    public string? FaxesOutgoing_Id_REG { get; set; }


    /// <summary> FaxEmail.Id equals </summary>
    [JsonProperty("faxEmail_id_eq")]
    public string? FaxEmail_Id_EQ { get; set; }
    /// <summary> FaxEmail.Id contains </summary>
    [JsonProperty("faxEmail_id_con")]
    public string? FaxEmail_Id_CON { get; set; }
    /// <summary> FaxEmail.Id regex </summary>
    [JsonProperty("faxEmail_id_reg")]
    public string? FaxEmail_Id_REG { get; set; }

    /// <summary> FaxEmail.MessageID equals </summary>
    [JsonProperty("faxEmail_messageID_eq")]
    public string? FaxEmail_MessageID_EQ { get; set; }
    /// <summary> FaxEmail.MessageID contains </summary>
    [JsonProperty("faxEmail_messageID_con")]
    public string? FaxEmail_MessageID_CON { get; set; }
    /// <summary> FaxEmail.MessageID regex </summary>
    [JsonProperty("faxEmail_messageID_reg")]
    public string? FaxEmail_MessageID_REG { get; set; }

    /// <summary> FaxEmail.ThreadId equals </summary>
    [JsonProperty("faxEmail_threadId_eq")]
    public string? FaxEmail_ThreadId_EQ { get; set; }
    /// <summary> FaxEmail.ThreadId contains </summary>
    [JsonProperty("faxEmail_threadId_con")]
    public string? FaxEmail_ThreadId_CON { get; set; }
    /// <summary> FaxEmail.ThreadId regex </summary>
    [JsonProperty("faxEmail_threadId_reg")]
    public string? FaxEmail_ThreadId_REG { get; set; }

    /// <summary> FaxEmail.Subject equals </summary>
    [JsonProperty("faxEmail_subject_eq")]
    public string? FaxEmail_Subject_EQ { get; set; }
    /// <summary> FaxEmail.Subject contains </summary>
    [JsonProperty("faxEmail_subject_con")]
    public string? FaxEmail_Subject_CON { get; set; }
    /// <summary> FaxEmail.Subject regex </summary>
    [JsonProperty("faxEmail_subject_reg")]
    public string? FaxEmail_Subject_REG { get; set; }

    /// <summary> FaxEmail.From equals </summary>
    [JsonProperty("faxEmail_from_eq")]
    public string? FaxEmail_From_EQ { get; set; }
    /// <summary> FaxEmail.From contains </summary>
    [JsonProperty("faxEmail_from_con")]
    public string? FaxEmail_From_CON { get; set; }
    /// <summary> FaxEmail.From regex </summary>
    [JsonProperty("faxEmail_from_reg")]
    public string? FaxEmail_From_REG { get; set; }


    /// <summary> From equals </summary>
    [JsonProperty("from_eq")]
    public string? From_EQ { get; set; }
    /// <summary> From contains </summary>
    [JsonProperty("from_con")]
    public string? From_CON { get; set; }
    /// <summary> From regex </summary>
    [JsonProperty("from_reg")]
    public string? From_REG { get; set; }

    /// <summary> SendConfirmationToEmails equals </summary>
    [JsonProperty("sendConfirmationToEmails_eq")]
    public string? SendConfirmationToEmails_EQ { get; set; }
    /// <summary> SendConfirmationToEmails contains </summary>
    [JsonProperty("sendConfirmationToEmails_con")]
    public string? SendConfirmationToEmails_CON { get; set; }
    /// <summary> SendConfirmationToEmails regex </summary>
    [JsonProperty("sendConfirmationToEmails_reg")]
    public string? SendConfirmationToEmails_REG { get; set; }

    /// <summary> ContainsError equals </summary>
    [JsonProperty("containsError_eq")]
    public bool? ContainsError_EQ { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for Identitys </summary>
public class IdentityFilterRequest 
{
    /// <summary> UbluxRoles contains </summary>
    [JsonProperty("ubluxRoles_con")]
    public UbluxRole? UbluxRoles_CON { get; set; }

    /// <summary> Username equals </summary>
    [JsonProperty("username_eq")]
    public string? Username_EQ { get; set; }
    /// <summary> Username contains </summary>
    [JsonProperty("username_con")]
    public string? Username_CON { get; set; }
    /// <summary> Username regex </summary>
    [JsonProperty("username_reg")]
    public string? Username_REG { get; set; }

    /// <summary> Password equals </summary>
    [JsonProperty("password_eq")]
    public string? Password_EQ { get; set; }
    /// <summary> Password contains </summary>
    [JsonProperty("password_con")]
    public string? Password_CON { get; set; }
    /// <summary> Password regex </summary>
    [JsonProperty("password_reg")]
    public string? Password_REG { get; set; }

    /// <summary> IdentityType equals </summary>
    [JsonProperty("identityType_eq")]
    public IdentityType? IdentityType_EQ { get; set; }

    /// <summary> AllowConnectingFromIpRegex equals </summary>
    [JsonProperty("allowConnectingFromIpRegex_eq")]
    public string? AllowConnectingFromIpRegex_EQ { get; set; }
    /// <summary> AllowConnectingFromIpRegex contains </summary>
    [JsonProperty("allowConnectingFromIpRegex_con")]
    public string? AllowConnectingFromIpRegex_CON { get; set; }
    /// <summary> AllowConnectingFromIpRegex regex </summary>
    [JsonProperty("allowConnectingFromIpRegex_reg")]
    public string? AllowConnectingFromIpRegex_REG { get; set; }

    /// <summary> PreventConnectingIfIpChanges equals </summary>
    [JsonProperty("preventConnectingIfIpChanges_eq")]
    public bool? PreventConnectingIfIpChanges_EQ { get; set; }

    /// <summary> IpAddressWhereAuthenticated equals </summary>
    [JsonProperty("ipAddressWhereAuthenticated_eq")]
    public string? IpAddressWhereAuthenticated_EQ { get; set; }
    /// <summary> IpAddressWhereAuthenticated contains </summary>
    [JsonProperty("ipAddressWhereAuthenticated_con")]
    public string? IpAddressWhereAuthenticated_CON { get; set; }
    /// <summary> IpAddressWhereAuthenticated regex </summary>
    [JsonProperty("ipAddressWhereAuthenticated_reg")]
    public string? IpAddressWhereAuthenticated_REG { get; set; }

    /// <summary> DateAuthenticated equals </summary>
    [JsonProperty("dateAuthenticated_eq")]
    public DateTime? DateAuthenticated_EQ { get; set; }
    /// <summary> DateAuthenticated less than or equal to </summary>
    [JsonProperty("dateAuthenticated_lte")]
    public DateTime? DateAuthenticated_LTE { get; set; }
    /// <summary> DateAuthenticated greater than or equal to </summary>
    [JsonProperty("dateAuthenticated_gte")]
    public DateTime? DateAuthenticated_GTE { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for IPs </summary>
public class IPFilterRequest 
{
    /// <summary> IsBlack equals </summary>
    [JsonProperty("isBlack_eq")]
    public bool? IsBlack_EQ { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for LineKeyGroups </summary>
public class LineKeyGroupFilterRequest 
{
    /// <summary> LineKeys.LineKeyType equals </summary>
    [JsonProperty("lineKeys_lineKeyType_eq")]
    public LineKeyType? LineKeys_LineKeyType_EQ { get; set; }

    /// <summary> LineKeys.Value equals </summary>
    [JsonProperty("lineKeys_value_eq")]
    public string? LineKeys_Value_EQ { get; set; }
    /// <summary> LineKeys.Value contains </summary>
    [JsonProperty("lineKeys_value_con")]
    public string? LineKeys_Value_CON { get; set; }
    /// <summary> LineKeys.Value regex </summary>
    [JsonProperty("lineKeys_value_reg")]
    public string? LineKeys_Value_REG { get; set; }

    /// <summary> LineKeys.Label equals </summary>
    [JsonProperty("lineKeys_label_eq")]
    public string? LineKeys_Label_EQ { get; set; }
    /// <summary> LineKeys.Label contains </summary>
    [JsonProperty("lineKeys_label_con")]
    public string? LineKeys_Label_CON { get; set; }
    /// <summary> LineKeys.Label regex </summary>
    [JsonProperty("lineKeys_label_reg")]
    public string? LineKeys_Label_REG { get; set; }

    /// <summary> LineKeys.IdExtension equals </summary>
    [JsonProperty("lineKeys_idExtension_eq")]
    public string? LineKeys_IdExtension_EQ { get; set; }
    /// <summary> LineKeys.IdExtension contains </summary>
    [JsonProperty("lineKeys_idExtension_con")]
    public string? LineKeys_IdExtension_CON { get; set; }
    /// <summary> LineKeys.IdExtension regex </summary>
    [JsonProperty("lineKeys_idExtension_reg")]
    public string? LineKeys_IdExtension_REG { get; set; }

    /// <summary> LineKeys.LineKeyIndex equals </summary>
    [JsonProperty("lineKeys_lineKeyIndex_eq")]
    public System.Int32? LineKeys_LineKeyIndex_EQ { get; set; }
    /// <summary> LineKeys.LineKeyIndex less than or equal to </summary>
    [JsonProperty("lineKeys_lineKeyIndex_lte")]
    public System.Int32? LineKeys_LineKeyIndex_LTE { get; set; }
    /// <summary> LineKeys.LineKeyIndex greater than or equal to </summary>
    [JsonProperty("lineKeys_lineKeyIndex_gte")]
    public System.Int32? LineKeys_LineKeyIndex_GTE { get; set; }


    /// <summary> FriendlyName equals </summary>
    [JsonProperty("friendlyName_eq")]
    public string? FriendlyName_EQ { get; set; }
    /// <summary> FriendlyName contains </summary>
    [JsonProperty("friendlyName_con")]
    public string? FriendlyName_CON { get; set; }
    /// <summary> FriendlyName regex </summary>
    [JsonProperty("friendlyName_reg")]
    public string? FriendlyName_REG { get; set; }

    /// <summary> Description equals </summary>
    [JsonProperty("description_eq")]
    public string? Description_EQ { get; set; }
    /// <summary> Description contains </summary>
    [JsonProperty("description_con")]
    public string? Description_CON { get; set; }
    /// <summary> Description regex </summary>
    [JsonProperty("description_reg")]
    public string? Description_REG { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for LogWebServiceRequests </summary>
public class LogWebServiceRequestFilterRequest 
{
    /// <summary> UbluxSession.IdIdentity equals </summary>
    [JsonProperty("ubluxSession_idIdentity_eq")]
    public string? UbluxSession_IdIdentity_EQ { get; set; }
    /// <summary> UbluxSession.IdIdentity contains </summary>
    [JsonProperty("ubluxSession_idIdentity_con")]
    public string? UbluxSession_IdIdentity_CON { get; set; }
    /// <summary> UbluxSession.IdIdentity regex </summary>
    [JsonProperty("ubluxSession_idIdentity_reg")]
    public string? UbluxSession_IdIdentity_REG { get; set; }

    /// <summary> UbluxSession.IdentityType equals </summary>
    [JsonProperty("ubluxSession_identityType_eq")]
    public IdentityType? UbluxSession_IdentityType_EQ { get; set; }

    /// <summary> UbluxSession.IdAccount equals </summary>
    [JsonProperty("ubluxSession_idAccount_eq")]
    public string? UbluxSession_IdAccount_EQ { get; set; }
    /// <summary> UbluxSession.IdAccount contains </summary>
    [JsonProperty("ubluxSession_idAccount_con")]
    public string? UbluxSession_IdAccount_CON { get; set; }
    /// <summary> UbluxSession.IdAccount regex </summary>
    [JsonProperty("ubluxSession_idAccount_reg")]
    public string? UbluxSession_IdAccount_REG { get; set; }

    /// <summary> UbluxSession.UbluxRoles contains </summary>
    [JsonProperty("ubluxSession_ubluxRoles_con")]
    public UbluxRole? UbluxSession_UbluxRoles_CON { get; set; }

    /// <summary> UbluxSession.ExpirationDate equals </summary>
    [JsonProperty("ubluxSession_expirationDate_eq")]
    public DateTime? UbluxSession_ExpirationDate_EQ { get; set; }
    /// <summary> UbluxSession.ExpirationDate less than or equal to </summary>
    [JsonProperty("ubluxSession_expirationDate_lte")]
    public DateTime? UbluxSession_ExpirationDate_LTE { get; set; }
    /// <summary> UbluxSession.ExpirationDate greater than or equal to </summary>
    [JsonProperty("ubluxSession_expirationDate_gte")]
    public DateTime? UbluxSession_ExpirationDate_GTE { get; set; }


    /// <summary> ConcurrentRequests equals </summary>
    [JsonProperty("concurrentRequests_eq")]
    public System.Int32? ConcurrentRequests_EQ { get; set; }
    /// <summary> ConcurrentRequests less than or equal to </summary>
    [JsonProperty("concurrentRequests_lte")]
    public System.Int32? ConcurrentRequests_LTE { get; set; }
    /// <summary> ConcurrentRequests greater than or equal to </summary>
    [JsonProperty("concurrentRequests_gte")]
    public System.Int32? ConcurrentRequests_GTE { get; set; }

    /// <summary> Charge equals </summary>
    [JsonProperty("charge_eq")]
    public System.UInt32? Charge_EQ { get; set; }
    /// <summary> Charge less than or equal to </summary>
    [JsonProperty("charge_lte")]
    public System.UInt32? Charge_LTE { get; set; }
    /// <summary> Charge greater than or equal to </summary>
    [JsonProperty("charge_gte")]
    public System.UInt32? Charge_GTE { get; set; }

    /// <summary> CurrentPenalty equals </summary>
    [JsonProperty("currentPenalty_eq")]
    public System.Int64? CurrentPenalty_EQ { get; set; }
    /// <summary> CurrentPenalty less than or equal to </summary>
    [JsonProperty("currentPenalty_lte")]
    public System.Int64? CurrentPenalty_LTE { get; set; }
    /// <summary> CurrentPenalty greater than or equal to </summary>
    [JsonProperty("currentPenalty_gte")]
    public System.Int64? CurrentPenalty_GTE { get; set; }

    /// <summary> TotalPenalty equals </summary>
    [JsonProperty("totalPenalty_eq")]
    public System.Int64? TotalPenalty_EQ { get; set; }
    /// <summary> TotalPenalty less than or equal to </summary>
    [JsonProperty("totalPenalty_lte")]
    public System.Int64? TotalPenalty_LTE { get; set; }
    /// <summary> TotalPenalty greater than or equal to </summary>
    [JsonProperty("totalPenalty_gte")]
    public System.Int64? TotalPenalty_GTE { get; set; }

    /// <summary> HttpMethod equals </summary>
    [JsonProperty("httpMethod_eq")]
    public string? HttpMethod_EQ { get; set; }
    /// <summary> HttpMethod contains </summary>
    [JsonProperty("httpMethod_con")]
    public string? HttpMethod_CON { get; set; }
    /// <summary> HttpMethod regex </summary>
    [JsonProperty("httpMethod_reg")]
    public string? HttpMethod_REG { get; set; }

    /// <summary> UserAgent equals </summary>
    [JsonProperty("userAgent_eq")]
    public string? UserAgent_EQ { get; set; }
    /// <summary> UserAgent contains </summary>
    [JsonProperty("userAgent_con")]
    public string? UserAgent_CON { get; set; }
    /// <summary> UserAgent regex </summary>
    [JsonProperty("userAgent_reg")]
    public string? UserAgent_REG { get; set; }

    /// <summary> Ip equals </summary>
    [JsonProperty("ip_eq")]
    public string? Ip_EQ { get; set; }
    /// <summary> Ip contains </summary>
    [JsonProperty("ip_con")]
    public string? Ip_CON { get; set; }
    /// <summary> Ip regex </summary>
    [JsonProperty("ip_reg")]
    public string? Ip_REG { get; set; }

    /// <summary> RequestUrl equals </summary>
    [JsonProperty("requestUrl_eq")]
    public string? RequestUrl_EQ { get; set; }
    /// <summary> RequestUrl contains </summary>
    [JsonProperty("requestUrl_con")]
    public string? RequestUrl_CON { get; set; }
    /// <summary> RequestUrl regex </summary>
    [JsonProperty("requestUrl_reg")]
    public string? RequestUrl_REG { get; set; }

    /// <summary> SaveQueryString equals </summary>
    [JsonProperty("saveQueryString_eq")]
    public bool? SaveQueryString_EQ { get; set; }

    /// <summary> QueryString equals </summary>
    [JsonProperty("queryString_eq")]
    public string? QueryString_EQ { get; set; }
    /// <summary> QueryString contains </summary>
    [JsonProperty("queryString_con")]
    public string? QueryString_CON { get; set; }
    /// <summary> QueryString regex </summary>
    [JsonProperty("queryString_reg")]
    public string? QueryString_REG { get; set; }

    /// <summary> RequestBody equals </summary>
    [JsonProperty("requestBody_eq")]
    public string? RequestBody_EQ { get; set; }
    /// <summary> RequestBody contains </summary>
    [JsonProperty("requestBody_con")]
    public string? RequestBody_CON { get; set; }
    /// <summary> RequestBody regex </summary>
    [JsonProperty("requestBody_reg")]
    public string? RequestBody_REG { get; set; }

    /// <summary> ResponseBody equals </summary>
    [JsonProperty("responseBody_eq")]
    public string? ResponseBody_EQ { get; set; }
    /// <summary> ResponseBody contains </summary>
    [JsonProperty("responseBody_con")]
    public string? ResponseBody_CON { get; set; }
    /// <summary> ResponseBody regex </summary>
    [JsonProperty("responseBody_reg")]
    public string? ResponseBody_REG { get; set; }

    /// <summary> HttpResponseStatusCode equals </summary>
    [JsonProperty("httpResponseStatusCode_eq")]
    public HttpResponseStatusCode? HttpResponseStatusCode_EQ { get; set; }

    /// <summary> ResponseTime equals </summary>
    [JsonProperty("responseTime_eq")]
    public System.Int32? ResponseTime_EQ { get; set; }
    /// <summary> ResponseTime less than or equal to </summary>
    [JsonProperty("responseTime_lte")]
    public System.Int32? ResponseTime_LTE { get; set; }
    /// <summary> ResponseTime greater than or equal to </summary>
    [JsonProperty("responseTime_gte")]
    public System.Int32? ResponseTime_GTE { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for MusicOnHoldGroups </summary>
public class MusicOnHoldGroupFilterRequest 
{
    /// <summary> IdsAudios equals </summary>
    [JsonProperty("idsAudios_eq")]
    public string? IdsAudios_EQ { get; set; }
    /// <summary> IdsAudios contains </summary>
    [JsonProperty("idsAudios_con")]
    public string? IdsAudios_CON { get; set; }
    /// <summary> IdsAudios regex </summary>
    [JsonProperty("idsAudios_reg")]
    public string? IdsAudios_REG { get; set; }

    /// <summary> FriendlyName equals </summary>
    [JsonProperty("friendlyName_eq")]
    public string? FriendlyName_EQ { get; set; }
    /// <summary> FriendlyName contains </summary>
    [JsonProperty("friendlyName_con")]
    public string? FriendlyName_CON { get; set; }
    /// <summary> FriendlyName regex </summary>
    [JsonProperty("friendlyName_reg")]
    public string? FriendlyName_REG { get; set; }

    /// <summary> Description equals </summary>
    [JsonProperty("description_eq")]
    public string? Description_EQ { get; set; }
    /// <summary> Description contains </summary>
    [JsonProperty("description_con")]
    public string? Description_CON { get; set; }
    /// <summary> Description regex </summary>
    [JsonProperty("description_reg")]
    public string? Description_REG { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for Phones </summary>
public class PhoneFilterRequest 
{
    /// <summary> IdCloudServicePbx equals </summary>
    [JsonProperty("idCloudServicePbx_eq")]
    public string? IdCloudServicePbx_EQ { get; set; }
    /// <summary> IdCloudServicePbx contains </summary>
    [JsonProperty("idCloudServicePbx_con")]
    public string? IdCloudServicePbx_CON { get; set; }
    /// <summary> IdCloudServicePbx regex </summary>
    [JsonProperty("idCloudServicePbx_reg")]
    public string? IdCloudServicePbx_REG { get; set; }

    /// <summary> IdPhoneConfiguration equals </summary>
    [JsonProperty("idPhoneConfiguration_eq")]
    public string? IdPhoneConfiguration_EQ { get; set; }
    /// <summary> IdPhoneConfiguration contains </summary>
    [JsonProperty("idPhoneConfiguration_con")]
    public string? IdPhoneConfiguration_CON { get; set; }
    /// <summary> IdPhoneConfiguration regex </summary>
    [JsonProperty("idPhoneConfiguration_reg")]
    public string? IdPhoneConfiguration_REG { get; set; }

    /// <summary> IdIdentity equals </summary>
    [JsonProperty("idIdentity_eq")]
    public string? IdIdentity_EQ { get; set; }
    /// <summary> IdIdentity contains </summary>
    [JsonProperty("idIdentity_con")]
    public string? IdIdentity_CON { get; set; }
    /// <summary> IdIdentity regex </summary>
    [JsonProperty("idIdentity_reg")]
    public string? IdIdentity_REG { get; set; }

    /// <summary> Lines.FriendlyName equals </summary>
    [JsonProperty("lines_friendlyName_eq")]
    public string? Lines_FriendlyName_EQ { get; set; }
    /// <summary> Lines.FriendlyName contains </summary>
    [JsonProperty("lines_friendlyName_con")]
    public string? Lines_FriendlyName_CON { get; set; }
    /// <summary> Lines.FriendlyName regex </summary>
    [JsonProperty("lines_friendlyName_reg")]
    public string? Lines_FriendlyName_REG { get; set; }

    /// <summary> Lines.LineConnectionStatus.IpWAN equals </summary>
    [JsonProperty("lines_lineConnectionStatus_ipWAN_eq")]
    public string? Lines_LineConnectionStatus_IpWAN_EQ { get; set; }
    /// <summary> Lines.LineConnectionStatus.IpWAN contains </summary>
    [JsonProperty("lines_lineConnectionStatus_ipWAN_con")]
    public string? Lines_LineConnectionStatus_IpWAN_CON { get; set; }
    /// <summary> Lines.LineConnectionStatus.IpWAN regex </summary>
    [JsonProperty("lines_lineConnectionStatus_ipWAN_reg")]
    public string? Lines_LineConnectionStatus_IpWAN_REG { get; set; }

    /// <summary> Lines.LineConnectionStatus.PortWAN equals </summary>
    [JsonProperty("lines_lineConnectionStatus_portWAN_eq")]
    public System.Int32? Lines_LineConnectionStatus_PortWAN_EQ { get; set; }
    /// <summary> Lines.LineConnectionStatus.PortWAN less than or equal to </summary>
    [JsonProperty("lines_lineConnectionStatus_portWAN_lte")]
    public System.Int32? Lines_LineConnectionStatus_PortWAN_LTE { get; set; }
    /// <summary> Lines.LineConnectionStatus.PortWAN greater than or equal to </summary>
    [JsonProperty("lines_lineConnectionStatus_portWAN_gte")]
    public System.Int32? Lines_LineConnectionStatus_PortWAN_GTE { get; set; }

    /// <summary> Lines.LineConnectionStatus.IpLAN equals </summary>
    [JsonProperty("lines_lineConnectionStatus_ipLAN_eq")]
    public string? Lines_LineConnectionStatus_IpLAN_EQ { get; set; }
    /// <summary> Lines.LineConnectionStatus.IpLAN contains </summary>
    [JsonProperty("lines_lineConnectionStatus_ipLAN_con")]
    public string? Lines_LineConnectionStatus_IpLAN_CON { get; set; }
    /// <summary> Lines.LineConnectionStatus.IpLAN regex </summary>
    [JsonProperty("lines_lineConnectionStatus_ipLAN_reg")]
    public string? Lines_LineConnectionStatus_IpLAN_REG { get; set; }

    /// <summary> Lines.LineConnectionStatus.PortLAN equals </summary>
    [JsonProperty("lines_lineConnectionStatus_portLAN_eq")]
    public System.Int32? Lines_LineConnectionStatus_PortLAN_EQ { get; set; }
    /// <summary> Lines.LineConnectionStatus.PortLAN less than or equal to </summary>
    [JsonProperty("lines_lineConnectionStatus_portLAN_lte")]
    public System.Int32? Lines_LineConnectionStatus_PortLAN_LTE { get; set; }
    /// <summary> Lines.LineConnectionStatus.PortLAN greater than or equal to </summary>
    [JsonProperty("lines_lineConnectionStatus_portLAN_gte")]
    public System.Int32? Lines_LineConnectionStatus_PortLAN_GTE { get; set; }

    /// <summary> Lines.LineConnectionStatus.UserAgent equals </summary>
    [JsonProperty("lines_lineConnectionStatus_userAgent_eq")]
    public string? Lines_LineConnectionStatus_UserAgent_EQ { get; set; }
    /// <summary> Lines.LineConnectionStatus.UserAgent contains </summary>
    [JsonProperty("lines_lineConnectionStatus_userAgent_con")]
    public string? Lines_LineConnectionStatus_UserAgent_CON { get; set; }
    /// <summary> Lines.LineConnectionStatus.UserAgent regex </summary>
    [JsonProperty("lines_lineConnectionStatus_userAgent_reg")]
    public string? Lines_LineConnectionStatus_UserAgent_REG { get; set; }

    /// <summary> Lines.LineConnectionStatus.IsConnected equals </summary>
    [JsonProperty("lines_lineConnectionStatus_isConnected_eq")]
    public bool? Lines_LineConnectionStatus_IsConnected_EQ { get; set; }

    /// <summary> Lines.LineConnectionStatus.DisconnectedReason equals </summary>
    [JsonProperty("lines_lineConnectionStatus_disconnectedReason_eq")]
    public string? Lines_LineConnectionStatus_DisconnectedReason_EQ { get; set; }
    /// <summary> Lines.LineConnectionStatus.DisconnectedReason contains </summary>
    [JsonProperty("lines_lineConnectionStatus_disconnectedReason_con")]
    public string? Lines_LineConnectionStatus_DisconnectedReason_CON { get; set; }
    /// <summary> Lines.LineConnectionStatus.DisconnectedReason regex </summary>
    [JsonProperty("lines_lineConnectionStatus_disconnectedReason_reg")]
    public string? Lines_LineConnectionStatus_DisconnectedReason_REG { get; set; }

    /// <summary> Lines.LineConnectionStatus.DateConnected equals </summary>
    [JsonProperty("lines_lineConnectionStatus_dateConnected_eq")]
    public DateTime? Lines_LineConnectionStatus_DateConnected_EQ { get; set; }
    /// <summary> Lines.LineConnectionStatus.DateConnected less than or equal to </summary>
    [JsonProperty("lines_lineConnectionStatus_dateConnected_lte")]
    public DateTime? Lines_LineConnectionStatus_DateConnected_LTE { get; set; }
    /// <summary> Lines.LineConnectionStatus.DateConnected greater than or equal to </summary>
    [JsonProperty("lines_lineConnectionStatus_dateConnected_gte")]
    public DateTime? Lines_LineConnectionStatus_DateConnected_GTE { get; set; }

    /// <summary> Lines.LineConnectionStatus.DateDisconnected equals </summary>
    [JsonProperty("lines_lineConnectionStatus_dateDisconnected_eq")]
    public DateTime? Lines_LineConnectionStatus_DateDisconnected_EQ { get; set; }
    /// <summary> Lines.LineConnectionStatus.DateDisconnected less than or equal to </summary>
    [JsonProperty("lines_lineConnectionStatus_dateDisconnected_lte")]
    public DateTime? Lines_LineConnectionStatus_DateDisconnected_LTE { get; set; }
    /// <summary> Lines.LineConnectionStatus.DateDisconnected greater than or equal to </summary>
    [JsonProperty("lines_lineConnectionStatus_dateDisconnected_gte")]
    public DateTime? Lines_LineConnectionStatus_DateDisconnected_GTE { get; set; }


    /// <summary> Lines.CallerIdNumber equals </summary>
    [JsonProperty("lines_callerIdNumber_eq")]
    public string? Lines_CallerIdNumber_EQ { get; set; }
    /// <summary> Lines.CallerIdNumber contains </summary>
    [JsonProperty("lines_callerIdNumber_con")]
    public string? Lines_CallerIdNumber_CON { get; set; }
    /// <summary> Lines.CallerIdNumber regex </summary>
    [JsonProperty("lines_callerIdNumber_reg")]
    public string? Lines_CallerIdNumber_REG { get; set; }

    /// <summary> Lines.RecordExternalCalls equals </summary>
    [JsonProperty("lines_recordExternalCalls_eq")]
    public bool? Lines_RecordExternalCalls_EQ { get; set; }

    /// <summary> Lines.RecordInternalCalls equals </summary>
    [JsonProperty("lines_recordInternalCalls_eq")]
    public bool? Lines_RecordInternalCalls_EQ { get; set; }

    /// <summary> Lines.Language equals </summary>
    [JsonProperty("lines_language_eq")]
    public Language? Lines_Language_EQ { get; set; }

    /// <summary> Lines.Id equals </summary>
    [JsonProperty("lines_id_eq")]
    public string? Lines_Id_EQ { get; set; }
    /// <summary> Lines.Id contains </summary>
    [JsonProperty("lines_id_con")]
    public string? Lines_Id_CON { get; set; }
    /// <summary> Lines.Id regex </summary>
    [JsonProperty("lines_id_reg")]
    public string? Lines_Id_REG { get; set; }


    /// <summary> FriendlyName equals </summary>
    [JsonProperty("friendlyName_eq")]
    public string? FriendlyName_EQ { get; set; }
    /// <summary> FriendlyName contains </summary>
    [JsonProperty("friendlyName_con")]
    public string? FriendlyName_CON { get; set; }
    /// <summary> FriendlyName regex </summary>
    [JsonProperty("friendlyName_reg")]
    public string? FriendlyName_REG { get; set; }

    /// <summary> PhoneType equals </summary>
    [JsonProperty("phoneType_eq")]
    public PhoneType? PhoneType_EQ { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for PhoneConfigurations </summary>
public class PhoneConfigurationFilterRequest 
{
    /// <summary> IdLineKeyGroup equals </summary>
    [JsonProperty("idLineKeyGroup_eq")]
    public string? IdLineKeyGroup_EQ { get; set; }
    /// <summary> IdLineKeyGroup contains </summary>
    [JsonProperty("idLineKeyGroup_con")]
    public string? IdLineKeyGroup_CON { get; set; }
    /// <summary> IdLineKeyGroup regex </summary>
    [JsonProperty("idLineKeyGroup_reg")]
    public string? IdLineKeyGroup_REG { get; set; }

    /// <summary> FrienlyName equals </summary>
    [JsonProperty("frienlyName_eq")]
    public string? FrienlyName_EQ { get; set; }
    /// <summary> FrienlyName contains </summary>
    [JsonProperty("frienlyName_con")]
    public string? FrienlyName_CON { get; set; }
    /// <summary> FrienlyName regex </summary>
    [JsonProperty("frienlyName_reg")]
    public string? FrienlyName_REG { get; set; }

    /// <summary> Description equals </summary>
    [JsonProperty("description_eq")]
    public string? Description_EQ { get; set; }
    /// <summary> Description contains </summary>
    [JsonProperty("description_con")]
    public string? Description_CON { get; set; }
    /// <summary> Description regex </summary>
    [JsonProperty("description_reg")]
    public string? Description_REG { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for PowerDialerGroups </summary>
public class PowerDialerGroupFilterRequest 
{
    /// <summary> IdVoipNumberPhone equals </summary>
    [JsonProperty("idVoipNumberPhone_eq")]
    public string? IdVoipNumberPhone_EQ { get; set; }
    /// <summary> IdVoipNumberPhone contains </summary>
    [JsonProperty("idVoipNumberPhone_con")]
    public string? IdVoipNumberPhone_CON { get; set; }
    /// <summary> IdVoipNumberPhone regex </summary>
    [JsonProperty("idVoipNumberPhone_reg")]
    public string? IdVoipNumberPhone_REG { get; set; }

    /// <summary> IdCallerIdMask equals </summary>
    [JsonProperty("idCallerIdMask_eq")]
    public string? IdCallerIdMask_EQ { get; set; }
    /// <summary> IdCallerIdMask contains </summary>
    [JsonProperty("idCallerIdMask_con")]
    public string? IdCallerIdMask_CON { get; set; }
    /// <summary> IdCallerIdMask regex </summary>
    [JsonProperty("idCallerIdMask_reg")]
    public string? IdCallerIdMask_REG { get; set; }

    /// <summary> IdCallFlowLogic equals </summary>
    [JsonProperty("idCallFlowLogic_eq")]
    public string? IdCallFlowLogic_EQ { get; set; }
    /// <summary> IdCallFlowLogic contains </summary>
    [JsonProperty("idCallFlowLogic_con")]
    public string? IdCallFlowLogic_CON { get; set; }
    /// <summary> IdCallFlowLogic regex </summary>
    [JsonProperty("idCallFlowLogic_reg")]
    public string? IdCallFlowLogic_REG { get; set; }

    /// <summary> IdExtension equals </summary>
    [JsonProperty("idExtension_eq")]
    public string? IdExtension_EQ { get; set; }
    /// <summary> IdExtension contains </summary>
    [JsonProperty("idExtension_con")]
    public string? IdExtension_CON { get; set; }
    /// <summary> IdExtension regex </summary>
    [JsonProperty("idExtension_reg")]
    public string? IdExtension_REG { get; set; }

    /// <summary> PowerDialers.PowerDialerType equals </summary>
    [JsonProperty("powerDialers_powerDialerType_eq")]
    public PowerDialerType? PowerDialers_PowerDialerType_EQ { get; set; }

    /// <summary> PowerDialers.PhoneNumber equals </summary>
    [JsonProperty("powerDialers_phoneNumber_eq")]
    public string? PowerDialers_PhoneNumber_EQ { get; set; }
    /// <summary> PowerDialers.PhoneNumber contains </summary>
    [JsonProperty("powerDialers_phoneNumber_con")]
    public string? PowerDialers_PhoneNumber_CON { get; set; }
    /// <summary> PowerDialers.PhoneNumber regex </summary>
    [JsonProperty("powerDialers_phoneNumber_reg")]
    public string? PowerDialers_PhoneNumber_REG { get; set; }

    /// <summary> PowerDialers.CountryIsoCode equals </summary>
    [JsonProperty("powerDialers_countryIsoCode_eq")]
    public CountryIsoCode? PowerDialers_CountryIsoCode_EQ { get; set; }

    /// <summary> PowerDialers.IdContact equals </summary>
    [JsonProperty("powerDialers_idContact_eq")]
    public string? PowerDialers_IdContact_EQ { get; set; }
    /// <summary> PowerDialers.IdContact contains </summary>
    [JsonProperty("powerDialers_idContact_con")]
    public string? PowerDialers_IdContact_CON { get; set; }
    /// <summary> PowerDialers.IdContact regex </summary>
    [JsonProperty("powerDialers_idContact_reg")]
    public string? PowerDialers_IdContact_REG { get; set; }

    /// <summary> PowerDialers.PowerDialerStatus equals </summary>
    [JsonProperty("powerDialers_powerDialerStatus_eq")]
    public PowerDialerStatus? PowerDialers_PowerDialerStatus_EQ { get; set; }

    /// <summary> PowerDialers.ErrorMessage equals </summary>
    [JsonProperty("powerDialers_errorMessage_eq")]
    public string? PowerDialers_ErrorMessage_EQ { get; set; }
    /// <summary> PowerDialers.ErrorMessage contains </summary>
    [JsonProperty("powerDialers_errorMessage_con")]
    public string? PowerDialers_ErrorMessage_CON { get; set; }
    /// <summary> PowerDialers.ErrorMessage regex </summary>
    [JsonProperty("powerDialers_errorMessage_reg")]
    public string? PowerDialers_ErrorMessage_REG { get; set; }

    /// <summary> PowerDialers.NumberOfAttempts equals </summary>
    [JsonProperty("powerDialers_numberOfAttempts_eq")]
    public System.Int32? PowerDialers_NumberOfAttempts_EQ { get; set; }
    /// <summary> PowerDialers.NumberOfAttempts less than or equal to </summary>
    [JsonProperty("powerDialers_numberOfAttempts_lte")]
    public System.Int32? PowerDialers_NumberOfAttempts_LTE { get; set; }
    /// <summary> PowerDialers.NumberOfAttempts greater than or equal to </summary>
    [JsonProperty("powerDialers_numberOfAttempts_gte")]
    public System.Int32? PowerDialers_NumberOfAttempts_GTE { get; set; }

    /// <summary> PowerDialers.ContactName equals </summary>
    [JsonProperty("powerDialers_contactName_eq")]
    public string? PowerDialers_ContactName_EQ { get; set; }
    /// <summary> PowerDialers.ContactName contains </summary>
    [JsonProperty("powerDialers_contactName_con")]
    public string? PowerDialers_ContactName_CON { get; set; }
    /// <summary> PowerDialers.ContactName regex </summary>
    [JsonProperty("powerDialers_contactName_reg")]
    public string? PowerDialers_ContactName_REG { get; set; }


    /// <summary> FriendlyName equals </summary>
    [JsonProperty("friendlyName_eq")]
    public string? FriendlyName_EQ { get; set; }
    /// <summary> FriendlyName contains </summary>
    [JsonProperty("friendlyName_con")]
    public string? FriendlyName_CON { get; set; }
    /// <summary> FriendlyName regex </summary>
    [JsonProperty("friendlyName_reg")]
    public string? FriendlyName_REG { get; set; }

    /// <summary> Description equals </summary>
    [JsonProperty("description_eq")]
    public string? Description_EQ { get; set; }
    /// <summary> Description contains </summary>
    [JsonProperty("description_con")]
    public string? Description_CON { get; set; }
    /// <summary> Description regex </summary>
    [JsonProperty("description_reg")]
    public string? Description_REG { get; set; }

    /// <summary> PowerDialerGroupStatus equals </summary>
    [JsonProperty("powerDialerGroupStatus_eq")]
    public PowerDialerGroupStatus? PowerDialerGroupStatus_EQ { get; set; }

    /// <summary> ErrorMessage equals </summary>
    [JsonProperty("errorMessage_eq")]
    public string? ErrorMessage_EQ { get; set; }
    /// <summary> ErrorMessage contains </summary>
    [JsonProperty("errorMessage_con")]
    public string? ErrorMessage_CON { get; set; }
    /// <summary> ErrorMessage regex </summary>
    [JsonProperty("errorMessage_reg")]
    public string? ErrorMessage_REG { get; set; }

    /// <summary> PowerDialerExecutingRecordIndex equals </summary>
    [JsonProperty("powerDialerExecutingRecordIndex_eq")]
    public System.Int32? PowerDialerExecutingRecordIndex_EQ { get; set; }
    /// <summary> PowerDialerExecutingRecordIndex less than or equal to </summary>
    [JsonProperty("powerDialerExecutingRecordIndex_lte")]
    public System.Int32? PowerDialerExecutingRecordIndex_LTE { get; set; }
    /// <summary> PowerDialerExecutingRecordIndex greater than or equal to </summary>
    [JsonProperty("powerDialerExecutingRecordIndex_gte")]
    public System.Int32? PowerDialerExecutingRecordIndex_GTE { get; set; }

    /// <summary> NumberOfConcurrentCalls equals </summary>
    [JsonProperty("numberOfConcurrentCalls_eq")]
    public System.Int32? NumberOfConcurrentCalls_EQ { get; set; }
    /// <summary> NumberOfConcurrentCalls less than or equal to </summary>
    [JsonProperty("numberOfConcurrentCalls_lte")]
    public System.Int32? NumberOfConcurrentCalls_LTE { get; set; }
    /// <summary> NumberOfConcurrentCalls greater than or equal to </summary>
    [JsonProperty("numberOfConcurrentCalls_gte")]
    public System.Int32? NumberOfConcurrentCalls_GTE { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for SMSs </summary>
public class SMSFilterRequest 
{
    /// <summary> IdVoipNumber equals </summary>
    [JsonProperty("idVoipNumber_eq")]
    public string? IdVoipNumber_EQ { get; set; }
    /// <summary> IdVoipNumber contains </summary>
    [JsonProperty("idVoipNumber_con")]
    public string? IdVoipNumber_CON { get; set; }
    /// <summary> IdVoipNumber regex </summary>
    [JsonProperty("idVoipNumber_reg")]
    public string? IdVoipNumber_REG { get; set; }

    /// <summary> Contact.IdIdentityUser equals </summary>
    [JsonProperty("contact_idIdentityUser_eq")]
    public string? Contact_IdIdentityUser_EQ { get; set; }
    /// <summary> Contact.IdIdentityUser contains </summary>
    [JsonProperty("contact_idIdentityUser_con")]
    public string? Contact_IdIdentityUser_CON { get; set; }
    /// <summary> Contact.IdIdentityUser regex </summary>
    [JsonProperty("contact_idIdentityUser_reg")]
    public string? Contact_IdIdentityUser_REG { get; set; }

    /// <summary> Contact.ContactNumbers.SearchIndex equals </summary>
    [JsonProperty("contact_contactNumbers_searchIndex_eq")]
    public string? Contact_ContactNumbers_SearchIndex_EQ { get; set; }
    /// <summary> Contact.ContactNumbers.SearchIndex contains </summary>
    [JsonProperty("contact_contactNumbers_searchIndex_con")]
    public string? Contact_ContactNumbers_SearchIndex_CON { get; set; }
    /// <summary> Contact.ContactNumbers.SearchIndex regex </summary>
    [JsonProperty("contact_contactNumbers_searchIndex_reg")]
    public string? Contact_ContactNumbers_SearchIndex_REG { get; set; }

    /// <summary> Contact.ContactNumbers.Number equals </summary>
    [JsonProperty("contact_contactNumbers_number_eq")]
    public string? Contact_ContactNumbers_Number_EQ { get; set; }
    /// <summary> Contact.ContactNumbers.Number contains </summary>
    [JsonProperty("contact_contactNumbers_number_con")]
    public string? Contact_ContactNumbers_Number_CON { get; set; }
    /// <summary> Contact.ContactNumbers.Number regex </summary>
    [JsonProperty("contact_contactNumbers_number_reg")]
    public string? Contact_ContactNumbers_Number_REG { get; set; }

    /// <summary> Contact.ContactNumbers.NumberInternationalFormat equals </summary>
    [JsonProperty("contact_contactNumbers_numberInternationalFormat_eq")]
    public string? Contact_ContactNumbers_NumberInternationalFormat_EQ { get; set; }
    /// <summary> Contact.ContactNumbers.NumberInternationalFormat contains </summary>
    [JsonProperty("contact_contactNumbers_numberInternationalFormat_con")]
    public string? Contact_ContactNumbers_NumberInternationalFormat_CON { get; set; }
    /// <summary> Contact.ContactNumbers.NumberInternationalFormat regex </summary>
    [JsonProperty("contact_contactNumbers_numberInternationalFormat_reg")]
    public string? Contact_ContactNumbers_NumberInternationalFormat_REG { get; set; }

    /// <summary> Contact.ContactNumbers.Label equals </summary>
    [JsonProperty("contact_contactNumbers_label_eq")]
    public LabelNumber? Contact_ContactNumbers_Label_EQ { get; set; }


    /// <summary> Contact.ContactEmails.SearchIndex equals </summary>
    [JsonProperty("contact_contactEmails_searchIndex_eq")]
    public string? Contact_ContactEmails_SearchIndex_EQ { get; set; }
    /// <summary> Contact.ContactEmails.SearchIndex contains </summary>
    [JsonProperty("contact_contactEmails_searchIndex_con")]
    public string? Contact_ContactEmails_SearchIndex_CON { get; set; }
    /// <summary> Contact.ContactEmails.SearchIndex regex </summary>
    [JsonProperty("contact_contactEmails_searchIndex_reg")]
    public string? Contact_ContactEmails_SearchIndex_REG { get; set; }

    /// <summary> Contact.ContactEmails.Email equals </summary>
    [JsonProperty("contact_contactEmails_email_eq")]
    public string? Contact_ContactEmails_Email_EQ { get; set; }
    /// <summary> Contact.ContactEmails.Email contains </summary>
    [JsonProperty("contact_contactEmails_email_con")]
    public string? Contact_ContactEmails_Email_CON { get; set; }
    /// <summary> Contact.ContactEmails.Email regex </summary>
    [JsonProperty("contact_contactEmails_email_reg")]
    public string? Contact_ContactEmails_Email_REG { get; set; }

    /// <summary> Contact.ContactEmails.Label equals </summary>
    [JsonProperty("contact_contactEmails_label_eq")]
    public LabelEmailType? Contact_ContactEmails_Label_EQ { get; set; }


    /// <summary> Contact.FirstName equals </summary>
    [JsonProperty("contact_firstName_eq")]
    public string? Contact_FirstName_EQ { get; set; }
    /// <summary> Contact.FirstName contains </summary>
    [JsonProperty("contact_firstName_con")]
    public string? Contact_FirstName_CON { get; set; }
    /// <summary> Contact.FirstName regex </summary>
    [JsonProperty("contact_firstName_reg")]
    public string? Contact_FirstName_REG { get; set; }

    /// <summary> Contact.LastName equals </summary>
    [JsonProperty("contact_lastName_eq")]
    public string? Contact_LastName_EQ { get; set; }
    /// <summary> Contact.LastName contains </summary>
    [JsonProperty("contact_lastName_con")]
    public string? Contact_LastName_CON { get; set; }
    /// <summary> Contact.LastName regex </summary>
    [JsonProperty("contact_lastName_reg")]
    public string? Contact_LastName_REG { get; set; }

    /// <summary> Contact.JobTittle equals </summary>
    [JsonProperty("contact_jobTittle_eq")]
    public string? Contact_JobTittle_EQ { get; set; }
    /// <summary> Contact.JobTittle contains </summary>
    [JsonProperty("contact_jobTittle_con")]
    public string? Contact_JobTittle_CON { get; set; }
    /// <summary> Contact.JobTittle regex </summary>
    [JsonProperty("contact_jobTittle_reg")]
    public string? Contact_JobTittle_REG { get; set; }

    /// <summary> Contact.Company equals </summary>
    [JsonProperty("contact_company_eq")]
    public string? Contact_Company_EQ { get; set; }
    /// <summary> Contact.Company contains </summary>
    [JsonProperty("contact_company_con")]
    public string? Contact_Company_CON { get; set; }
    /// <summary> Contact.Company regex </summary>
    [JsonProperty("contact_company_reg")]
    public string? Contact_Company_REG { get; set; }

    /// <summary> Contact.Hash equals </summary>
    [JsonProperty("contact_hash_eq")]
    public string? Contact_Hash_EQ { get; set; }
    /// <summary> Contact.Hash contains </summary>
    [JsonProperty("contact_hash_con")]
    public string? Contact_Hash_CON { get; set; }
    /// <summary> Contact.Hash regex </summary>
    [JsonProperty("contact_hash_reg")]
    public string? Contact_Hash_REG { get; set; }

    /// <summary> Contact.Notes equals </summary>
    [JsonProperty("contact_notes_eq")]
    public string? Contact_Notes_EQ { get; set; }
    /// <summary> Contact.Notes contains </summary>
    [JsonProperty("contact_notes_con")]
    public string? Contact_Notes_CON { get; set; }
    /// <summary> Contact.Notes regex </summary>
    [JsonProperty("contact_notes_reg")]
    public string? Contact_Notes_REG { get; set; }

    /// <summary> Contact.Variables.Name equals </summary>
    [JsonProperty("contact_variables_name_eq")]
    public string? Contact_Variables_Name_EQ { get; set; }
    /// <summary> Contact.Variables.Name contains </summary>
    [JsonProperty("contact_variables_name_con")]
    public string? Contact_Variables_Name_CON { get; set; }
    /// <summary> Contact.Variables.Name regex </summary>
    [JsonProperty("contact_variables_name_reg")]
    public string? Contact_Variables_Name_REG { get; set; }

    /// <summary> Contact.Variables.JsonValue equals </summary>
    [JsonProperty("contact_variables_jsonValue_eq")]
    public string? Contact_Variables_JsonValue_EQ { get; set; }
    /// <summary> Contact.Variables.JsonValue contains </summary>
    [JsonProperty("contact_variables_jsonValue_con")]
    public string? Contact_Variables_JsonValue_CON { get; set; }
    /// <summary> Contact.Variables.JsonValue regex </summary>
    [JsonProperty("contact_variables_jsonValue_reg")]
    public string? Contact_Variables_JsonValue_REG { get; set; }


    /// <summary> Contact.Id equals </summary>
    [JsonProperty("contact_id_eq")]
    public string? Contact_Id_EQ { get; set; }
    /// <summary> Contact.Id contains </summary>
    [JsonProperty("contact_id_con")]
    public string? Contact_Id_CON { get; set; }
    /// <summary> Contact.Id regex </summary>
    [JsonProperty("contact_id_reg")]
    public string? Contact_Id_REG { get; set; }

    /// <summary> Contact.DateCreated equals </summary>
    [JsonProperty("contact_dateCreated_eq")]
    public DateTime? Contact_DateCreated_EQ { get; set; }
    /// <summary> Contact.DateCreated less than or equal to </summary>
    [JsonProperty("contact_dateCreated_lte")]
    public DateTime? Contact_DateCreated_LTE { get; set; }
    /// <summary> Contact.DateCreated greater than or equal to </summary>
    [JsonProperty("contact_dateCreated_gte")]
    public DateTime? Contact_DateCreated_GTE { get; set; }

    /// <summary> Contact.DateUpdated equals </summary>
    [JsonProperty("contact_dateUpdated_eq")]
    public DateTime? Contact_DateUpdated_EQ { get; set; }
    /// <summary> Contact.DateUpdated less than or equal to </summary>
    [JsonProperty("contact_dateUpdated_lte")]
    public DateTime? Contact_DateUpdated_LTE { get; set; }
    /// <summary> Contact.DateUpdated greater than or equal to </summary>
    [JsonProperty("contact_dateUpdated_gte")]
    public DateTime? Contact_DateUpdated_GTE { get; set; }


    /// <summary> IsIncoming equals </summary>
    [JsonProperty("isIncoming_eq")]
    public bool? IsIncoming_EQ { get; set; }

    /// <summary> Body equals </summary>
    [JsonProperty("body_eq")]
    public string? Body_EQ { get; set; }
    /// <summary> Body contains </summary>
    [JsonProperty("body_con")]
    public string? Body_CON { get; set; }
    /// <summary> Body regex </summary>
    [JsonProperty("body_reg")]
    public string? Body_REG { get; set; }

    /// <summary> NumSegments equals </summary>
    [JsonProperty("numSegments_eq")]
    public System.Int32? NumSegments_EQ { get; set; }
    /// <summary> NumSegments less than or equal to </summary>
    [JsonProperty("numSegments_lte")]
    public System.Int32? NumSegments_LTE { get; set; }
    /// <summary> NumSegments greater than or equal to </summary>
    [JsonProperty("numSegments_gte")]
    public System.Int32? NumSegments_GTE { get; set; }

    /// <summary> Status equals </summary>
    [JsonProperty("status_eq")]
    public string? Status_EQ { get; set; }
    /// <summary> Status contains </summary>
    [JsonProperty("status_con")]
    public string? Status_CON { get; set; }
    /// <summary> Status regex </summary>
    [JsonProperty("status_reg")]
    public string? Status_REG { get; set; }

    /// <summary> From equals </summary>
    [JsonProperty("from_eq")]
    public string? From_EQ { get; set; }
    /// <summary> From contains </summary>
    [JsonProperty("from_con")]
    public string? From_CON { get; set; }
    /// <summary> From regex </summary>
    [JsonProperty("from_reg")]
    public string? From_REG { get; set; }

    /// <summary> To equals </summary>
    [JsonProperty("to_eq")]
    public string? To_EQ { get; set; }
    /// <summary> To contains </summary>
    [JsonProperty("to_con")]
    public string? To_CON { get; set; }
    /// <summary> To regex </summary>
    [JsonProperty("to_reg")]
    public string? To_REG { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for TrunkOriginationForwards </summary>
public class TrunkOriginationForwardFilterRequest 
{
    /// <summary> TrunkOriginationType equals </summary>
    [JsonProperty("trunkOriginationType_eq")]
    public TrunkOriginationType? TrunkOriginationType_EQ { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for TrunkOriginationRegisters </summary>
public class TrunkOriginationRegisterFilterRequest 
{
    /// <summary> TrunkOriginationType equals </summary>
    [JsonProperty("trunkOriginationType_eq")]
    public TrunkOriginationType? TrunkOriginationType_EQ { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for TrunkTerminations </summary>
public class TrunkTerminationFilterRequest 
{
    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for TrunkTerminationGroups </summary>
public class TrunkTerminationGroupFilterRequest 
{
    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for UnauthorizedTokens </summary>
public class UnauthorizedTokenFilterRequest 
{
    /// <summary> Jwt equals </summary>
    [JsonProperty("jwt_eq")]
    public string? Jwt_EQ { get; set; }
    /// <summary> Jwt contains </summary>
    [JsonProperty("jwt_con")]
    public string? Jwt_CON { get; set; }
    /// <summary> Jwt regex </summary>
    [JsonProperty("jwt_reg")]
    public string? Jwt_REG { get; set; }

    /// <summary> IdIdentity equals </summary>
    [JsonProperty("idIdentity_eq")]
    public string? IdIdentity_EQ { get; set; }
    /// <summary> IdIdentity contains </summary>
    [JsonProperty("idIdentity_con")]
    public string? IdIdentity_CON { get; set; }
    /// <summary> IdIdentity regex </summary>
    [JsonProperty("idIdentity_reg")]
    public string? IdIdentity_REG { get; set; }

    /// <summary> ExpirationDate equals </summary>
    [JsonProperty("expirationDate_eq")]
    public DateTime? ExpirationDate_EQ { get; set; }
    /// <summary> ExpirationDate less than or equal to </summary>
    [JsonProperty("expirationDate_lte")]
    public DateTime? ExpirationDate_LTE { get; set; }
    /// <summary> ExpirationDate greater than or equal to </summary>
    [JsonProperty("expirationDate_gte")]
    public DateTime? ExpirationDate_GTE { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for Voicemails </summary>
public class VoicemailFilterRequest 
{
    /// <summary> VoicemailType equals </summary>
    [JsonProperty("voicemailType_eq")]
    public VoicemailType? VoicemailType_EQ { get; set; }

    /// <summary> IdsLinesThatCanListenToVoicemail equals </summary>
    [JsonProperty("idsLinesThatCanListenToVoicemail_eq")]
    public string? IdsLinesThatCanListenToVoicemail_EQ { get; set; }
    /// <summary> IdsLinesThatCanListenToVoicemail contains </summary>
    [JsonProperty("idsLinesThatCanListenToVoicemail_con")]
    public string? IdsLinesThatCanListenToVoicemail_CON { get; set; }
    /// <summary> IdsLinesThatCanListenToVoicemail regex </summary>
    [JsonProperty("idsLinesThatCanListenToVoicemail_reg")]
    public string? IdsLinesThatCanListenToVoicemail_REG { get; set; }

    /// <summary> Email equals </summary>
    [JsonProperty("email_eq")]
    public string? Email_EQ { get; set; }
    /// <summary> Email contains </summary>
    [JsonProperty("email_con")]
    public string? Email_CON { get; set; }
    /// <summary> Email regex </summary>
    [JsonProperty("email_reg")]
    public string? Email_REG { get; set; }

    /// <summary> DurationInSeconds equals </summary>
    [JsonProperty("durationInSeconds_eq")]
    public System.Int32? DurationInSeconds_EQ { get; set; }
    /// <summary> DurationInSeconds less than or equal to </summary>
    [JsonProperty("durationInSeconds_lte")]
    public System.Int32? DurationInSeconds_LTE { get; set; }
    /// <summary> DurationInSeconds greater than or equal to </summary>
    [JsonProperty("durationInSeconds_gte")]
    public System.Int32? DurationInSeconds_GTE { get; set; }

    /// <summary> VoicemailWav.InstanceId equals </summary>
    [JsonProperty("voicemailWav_instanceId_eq")]
    public string? VoicemailWav_InstanceId_EQ { get; set; }
    /// <summary> VoicemailWav.InstanceId contains </summary>
    [JsonProperty("voicemailWav_instanceId_con")]
    public string? VoicemailWav_InstanceId_CON { get; set; }
    /// <summary> VoicemailWav.InstanceId regex </summary>
    [JsonProperty("voicemailWav_instanceId_reg")]
    public string? VoicemailWav_InstanceId_REG { get; set; }

    /// <summary> VoicemailWav.FileSizeInBytes equals </summary>
    [JsonProperty("voicemailWav_fileSizeInBytes_eq")]
    public System.Int32? VoicemailWav_FileSizeInBytes_EQ { get; set; }
    /// <summary> VoicemailWav.FileSizeInBytes less than or equal to </summary>
    [JsonProperty("voicemailWav_fileSizeInBytes_lte")]
    public System.Int32? VoicemailWav_FileSizeInBytes_LTE { get; set; }
    /// <summary> VoicemailWav.FileSizeInBytes greater than or equal to </summary>
    [JsonProperty("voicemailWav_fileSizeInBytes_gte")]
    public System.Int32? VoicemailWav_FileSizeInBytes_GTE { get; set; }

    /// <summary> VoicemailWav.Md5Hash equals </summary>
    [JsonProperty("voicemailWav_md5Hash_eq")]
    public string? VoicemailWav_Md5Hash_EQ { get; set; }
    /// <summary> VoicemailWav.Md5Hash contains </summary>
    [JsonProperty("voicemailWav_md5Hash_con")]
    public string? VoicemailWav_Md5Hash_CON { get; set; }
    /// <summary> VoicemailWav.Md5Hash regex </summary>
    [JsonProperty("voicemailWav_md5Hash_reg")]
    public string? VoicemailWav_Md5Hash_REG { get; set; }

    /// <summary> VoicemailWav.Url equals </summary>
    [JsonProperty("voicemailWav_url_eq")]
    public string? VoicemailWav_Url_EQ { get; set; }
    /// <summary> VoicemailWav.Url contains </summary>
    [JsonProperty("voicemailWav_url_con")]
    public string? VoicemailWav_Url_CON { get; set; }
    /// <summary> VoicemailWav.Url regex </summary>
    [JsonProperty("voicemailWav_url_reg")]
    public string? VoicemailWav_Url_REG { get; set; }

    /// <summary> VoicemailWav.Id equals </summary>
    [JsonProperty("voicemailWav_id_eq")]
    public string? VoicemailWav_Id_EQ { get; set; }
    /// <summary> VoicemailWav.Id contains </summary>
    [JsonProperty("voicemailWav_id_con")]
    public string? VoicemailWav_Id_CON { get; set; }
    /// <summary> VoicemailWav.Id regex </summary>
    [JsonProperty("voicemailWav_id_reg")]
    public string? VoicemailWav_Id_REG { get; set; }


    /// <summary> VoicemailMp3.InstanceId equals </summary>
    [JsonProperty("voicemailMp3_instanceId_eq")]
    public string? VoicemailMp3_InstanceId_EQ { get; set; }
    /// <summary> VoicemailMp3.InstanceId contains </summary>
    [JsonProperty("voicemailMp3_instanceId_con")]
    public string? VoicemailMp3_InstanceId_CON { get; set; }
    /// <summary> VoicemailMp3.InstanceId regex </summary>
    [JsonProperty("voicemailMp3_instanceId_reg")]
    public string? VoicemailMp3_InstanceId_REG { get; set; }

    /// <summary> VoicemailMp3.FileSizeInBytes equals </summary>
    [JsonProperty("voicemailMp3_fileSizeInBytes_eq")]
    public System.Int32? VoicemailMp3_FileSizeInBytes_EQ { get; set; }
    /// <summary> VoicemailMp3.FileSizeInBytes less than or equal to </summary>
    [JsonProperty("voicemailMp3_fileSizeInBytes_lte")]
    public System.Int32? VoicemailMp3_FileSizeInBytes_LTE { get; set; }
    /// <summary> VoicemailMp3.FileSizeInBytes greater than or equal to </summary>
    [JsonProperty("voicemailMp3_fileSizeInBytes_gte")]
    public System.Int32? VoicemailMp3_FileSizeInBytes_GTE { get; set; }

    /// <summary> VoicemailMp3.Md5Hash equals </summary>
    [JsonProperty("voicemailMp3_md5Hash_eq")]
    public string? VoicemailMp3_Md5Hash_EQ { get; set; }
    /// <summary> VoicemailMp3.Md5Hash contains </summary>
    [JsonProperty("voicemailMp3_md5Hash_con")]
    public string? VoicemailMp3_Md5Hash_CON { get; set; }
    /// <summary> VoicemailMp3.Md5Hash regex </summary>
    [JsonProperty("voicemailMp3_md5Hash_reg")]
    public string? VoicemailMp3_Md5Hash_REG { get; set; }

    /// <summary> VoicemailMp3.Url equals </summary>
    [JsonProperty("voicemailMp3_url_eq")]
    public string? VoicemailMp3_Url_EQ { get; set; }
    /// <summary> VoicemailMp3.Url contains </summary>
    [JsonProperty("voicemailMp3_url_con")]
    public string? VoicemailMp3_Url_CON { get; set; }
    /// <summary> VoicemailMp3.Url regex </summary>
    [JsonProperty("voicemailMp3_url_reg")]
    public string? VoicemailMp3_Url_REG { get; set; }

    /// <summary> VoicemailMp3.Id equals </summary>
    [JsonProperty("voicemailMp3_id_eq")]
    public string? VoicemailMp3_Id_EQ { get; set; }
    /// <summary> VoicemailMp3.Id contains </summary>
    [JsonProperty("voicemailMp3_id_con")]
    public string? VoicemailMp3_Id_CON { get; set; }
    /// <summary> VoicemailMp3.Id regex </summary>
    [JsonProperty("voicemailMp3_id_reg")]
    public string? VoicemailMp3_Id_REG { get; set; }


    /// <summary> ErrorMessage equals </summary>
    [JsonProperty("errorMessage_eq")]
    public string? ErrorMessage_EQ { get; set; }
    /// <summary> ErrorMessage contains </summary>
    [JsonProperty("errorMessage_con")]
    public string? ErrorMessage_CON { get; set; }
    /// <summary> ErrorMessage regex </summary>
    [JsonProperty("errorMessage_reg")]
    public string? ErrorMessage_REG { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for VoicemailForwardeds </summary>
public class VoicemailForwardedFilterRequest 
{
    /// <summary> VoicemailType equals </summary>
    [JsonProperty("voicemailType_eq")]
    public VoicemailType? VoicemailType_EQ { get; set; }

    /// <summary> LineThatForwardedVoicemail.FriendlyName equals </summary>
    [JsonProperty("lineThatForwardedVoicemail_friendlyName_eq")]
    public string? LineThatForwardedVoicemail_FriendlyName_EQ { get; set; }
    /// <summary> LineThatForwardedVoicemail.FriendlyName contains </summary>
    [JsonProperty("lineThatForwardedVoicemail_friendlyName_con")]
    public string? LineThatForwardedVoicemail_FriendlyName_CON { get; set; }
    /// <summary> LineThatForwardedVoicemail.FriendlyName regex </summary>
    [JsonProperty("lineThatForwardedVoicemail_friendlyName_reg")]
    public string? LineThatForwardedVoicemail_FriendlyName_REG { get; set; }

    /// <summary> LineThatForwardedVoicemail.LineConnectionStatus.IpWAN equals </summary>
    [JsonProperty("lineThatForwardedVoicemail_lineConnectionStatus_ipWAN_eq")]
    public string? LineThatForwardedVoicemail_LineConnectionStatus_IpWAN_EQ { get; set; }
    /// <summary> LineThatForwardedVoicemail.LineConnectionStatus.IpWAN contains </summary>
    [JsonProperty("lineThatForwardedVoicemail_lineConnectionStatus_ipWAN_con")]
    public string? LineThatForwardedVoicemail_LineConnectionStatus_IpWAN_CON { get; set; }
    /// <summary> LineThatForwardedVoicemail.LineConnectionStatus.IpWAN regex </summary>
    [JsonProperty("lineThatForwardedVoicemail_lineConnectionStatus_ipWAN_reg")]
    public string? LineThatForwardedVoicemail_LineConnectionStatus_IpWAN_REG { get; set; }

    /// <summary> LineThatForwardedVoicemail.LineConnectionStatus.PortWAN equals </summary>
    [JsonProperty("lineThatForwardedVoicemail_lineConnectionStatus_portWAN_eq")]
    public System.Int32? LineThatForwardedVoicemail_LineConnectionStatus_PortWAN_EQ { get; set; }
    /// <summary> LineThatForwardedVoicemail.LineConnectionStatus.PortWAN less than or equal to </summary>
    [JsonProperty("lineThatForwardedVoicemail_lineConnectionStatus_portWAN_lte")]
    public System.Int32? LineThatForwardedVoicemail_LineConnectionStatus_PortWAN_LTE { get; set; }
    /// <summary> LineThatForwardedVoicemail.LineConnectionStatus.PortWAN greater than or equal to </summary>
    [JsonProperty("lineThatForwardedVoicemail_lineConnectionStatus_portWAN_gte")]
    public System.Int32? LineThatForwardedVoicemail_LineConnectionStatus_PortWAN_GTE { get; set; }

    /// <summary> LineThatForwardedVoicemail.LineConnectionStatus.IpLAN equals </summary>
    [JsonProperty("lineThatForwardedVoicemail_lineConnectionStatus_ipLAN_eq")]
    public string? LineThatForwardedVoicemail_LineConnectionStatus_IpLAN_EQ { get; set; }
    /// <summary> LineThatForwardedVoicemail.LineConnectionStatus.IpLAN contains </summary>
    [JsonProperty("lineThatForwardedVoicemail_lineConnectionStatus_ipLAN_con")]
    public string? LineThatForwardedVoicemail_LineConnectionStatus_IpLAN_CON { get; set; }
    /// <summary> LineThatForwardedVoicemail.LineConnectionStatus.IpLAN regex </summary>
    [JsonProperty("lineThatForwardedVoicemail_lineConnectionStatus_ipLAN_reg")]
    public string? LineThatForwardedVoicemail_LineConnectionStatus_IpLAN_REG { get; set; }

    /// <summary> LineThatForwardedVoicemail.LineConnectionStatus.PortLAN equals </summary>
    [JsonProperty("lineThatForwardedVoicemail_lineConnectionStatus_portLAN_eq")]
    public System.Int32? LineThatForwardedVoicemail_LineConnectionStatus_PortLAN_EQ { get; set; }
    /// <summary> LineThatForwardedVoicemail.LineConnectionStatus.PortLAN less than or equal to </summary>
    [JsonProperty("lineThatForwardedVoicemail_lineConnectionStatus_portLAN_lte")]
    public System.Int32? LineThatForwardedVoicemail_LineConnectionStatus_PortLAN_LTE { get; set; }
    /// <summary> LineThatForwardedVoicemail.LineConnectionStatus.PortLAN greater than or equal to </summary>
    [JsonProperty("lineThatForwardedVoicemail_lineConnectionStatus_portLAN_gte")]
    public System.Int32? LineThatForwardedVoicemail_LineConnectionStatus_PortLAN_GTE { get; set; }

    /// <summary> LineThatForwardedVoicemail.LineConnectionStatus.UserAgent equals </summary>
    [JsonProperty("lineThatForwardedVoicemail_lineConnectionStatus_userAgent_eq")]
    public string? LineThatForwardedVoicemail_LineConnectionStatus_UserAgent_EQ { get; set; }
    /// <summary> LineThatForwardedVoicemail.LineConnectionStatus.UserAgent contains </summary>
    [JsonProperty("lineThatForwardedVoicemail_lineConnectionStatus_userAgent_con")]
    public string? LineThatForwardedVoicemail_LineConnectionStatus_UserAgent_CON { get; set; }
    /// <summary> LineThatForwardedVoicemail.LineConnectionStatus.UserAgent regex </summary>
    [JsonProperty("lineThatForwardedVoicemail_lineConnectionStatus_userAgent_reg")]
    public string? LineThatForwardedVoicemail_LineConnectionStatus_UserAgent_REG { get; set; }

    /// <summary> LineThatForwardedVoicemail.LineConnectionStatus.IsConnected equals </summary>
    [JsonProperty("lineThatForwardedVoicemail_lineConnectionStatus_isConnected_eq")]
    public bool? LineThatForwardedVoicemail_LineConnectionStatus_IsConnected_EQ { get; set; }

    /// <summary> LineThatForwardedVoicemail.LineConnectionStatus.DisconnectedReason equals </summary>
    [JsonProperty("lineThatForwardedVoicemail_lineConnectionStatus_disconnectedReason_eq")]
    public string? LineThatForwardedVoicemail_LineConnectionStatus_DisconnectedReason_EQ { get; set; }
    /// <summary> LineThatForwardedVoicemail.LineConnectionStatus.DisconnectedReason contains </summary>
    [JsonProperty("lineThatForwardedVoicemail_lineConnectionStatus_disconnectedReason_con")]
    public string? LineThatForwardedVoicemail_LineConnectionStatus_DisconnectedReason_CON { get; set; }
    /// <summary> LineThatForwardedVoicemail.LineConnectionStatus.DisconnectedReason regex </summary>
    [JsonProperty("lineThatForwardedVoicemail_lineConnectionStatus_disconnectedReason_reg")]
    public string? LineThatForwardedVoicemail_LineConnectionStatus_DisconnectedReason_REG { get; set; }

    /// <summary> LineThatForwardedVoicemail.LineConnectionStatus.DateConnected equals </summary>
    [JsonProperty("lineThatForwardedVoicemail_lineConnectionStatus_dateConnected_eq")]
    public DateTime? LineThatForwardedVoicemail_LineConnectionStatus_DateConnected_EQ { get; set; }
    /// <summary> LineThatForwardedVoicemail.LineConnectionStatus.DateConnected less than or equal to </summary>
    [JsonProperty("lineThatForwardedVoicemail_lineConnectionStatus_dateConnected_lte")]
    public DateTime? LineThatForwardedVoicemail_LineConnectionStatus_DateConnected_LTE { get; set; }
    /// <summary> LineThatForwardedVoicemail.LineConnectionStatus.DateConnected greater than or equal to </summary>
    [JsonProperty("lineThatForwardedVoicemail_lineConnectionStatus_dateConnected_gte")]
    public DateTime? LineThatForwardedVoicemail_LineConnectionStatus_DateConnected_GTE { get; set; }

    /// <summary> LineThatForwardedVoicemail.LineConnectionStatus.DateDisconnected equals </summary>
    [JsonProperty("lineThatForwardedVoicemail_lineConnectionStatus_dateDisconnected_eq")]
    public DateTime? LineThatForwardedVoicemail_LineConnectionStatus_DateDisconnected_EQ { get; set; }
    /// <summary> LineThatForwardedVoicemail.LineConnectionStatus.DateDisconnected less than or equal to </summary>
    [JsonProperty("lineThatForwardedVoicemail_lineConnectionStatus_dateDisconnected_lte")]
    public DateTime? LineThatForwardedVoicemail_LineConnectionStatus_DateDisconnected_LTE { get; set; }
    /// <summary> LineThatForwardedVoicemail.LineConnectionStatus.DateDisconnected greater than or equal to </summary>
    [JsonProperty("lineThatForwardedVoicemail_lineConnectionStatus_dateDisconnected_gte")]
    public DateTime? LineThatForwardedVoicemail_LineConnectionStatus_DateDisconnected_GTE { get; set; }


    /// <summary> LineThatForwardedVoicemail.CallerIdNumber equals </summary>
    [JsonProperty("lineThatForwardedVoicemail_callerIdNumber_eq")]
    public string? LineThatForwardedVoicemail_CallerIdNumber_EQ { get; set; }
    /// <summary> LineThatForwardedVoicemail.CallerIdNumber contains </summary>
    [JsonProperty("lineThatForwardedVoicemail_callerIdNumber_con")]
    public string? LineThatForwardedVoicemail_CallerIdNumber_CON { get; set; }
    /// <summary> LineThatForwardedVoicemail.CallerIdNumber regex </summary>
    [JsonProperty("lineThatForwardedVoicemail_callerIdNumber_reg")]
    public string? LineThatForwardedVoicemail_CallerIdNumber_REG { get; set; }

    /// <summary> LineThatForwardedVoicemail.RecordExternalCalls equals </summary>
    [JsonProperty("lineThatForwardedVoicemail_recordExternalCalls_eq")]
    public bool? LineThatForwardedVoicemail_RecordExternalCalls_EQ { get; set; }

    /// <summary> LineThatForwardedVoicemail.RecordInternalCalls equals </summary>
    [JsonProperty("lineThatForwardedVoicemail_recordInternalCalls_eq")]
    public bool? LineThatForwardedVoicemail_RecordInternalCalls_EQ { get; set; }

    /// <summary> LineThatForwardedVoicemail.Language equals </summary>
    [JsonProperty("lineThatForwardedVoicemail_language_eq")]
    public Language? LineThatForwardedVoicemail_Language_EQ { get; set; }

    /// <summary> LineThatForwardedVoicemail.Id equals </summary>
    [JsonProperty("lineThatForwardedVoicemail_id_eq")]
    public string? LineThatForwardedVoicemail_Id_EQ { get; set; }
    /// <summary> LineThatForwardedVoicemail.Id contains </summary>
    [JsonProperty("lineThatForwardedVoicemail_id_con")]
    public string? LineThatForwardedVoicemail_Id_CON { get; set; }
    /// <summary> LineThatForwardedVoicemail.Id regex </summary>
    [JsonProperty("lineThatForwardedVoicemail_id_reg")]
    public string? LineThatForwardedVoicemail_Id_REG { get; set; }


    /// <summary> ExtensionForwarded.IdMusicOnHoldGroup equals </summary>
    [JsonProperty("extensionForwarded_idMusicOnHoldGroup_eq")]
    public string? ExtensionForwarded_IdMusicOnHoldGroup_EQ { get; set; }
    /// <summary> ExtensionForwarded.IdMusicOnHoldGroup contains </summary>
    [JsonProperty("extensionForwarded_idMusicOnHoldGroup_con")]
    public string? ExtensionForwarded_IdMusicOnHoldGroup_CON { get; set; }
    /// <summary> ExtensionForwarded.IdMusicOnHoldGroup regex </summary>
    [JsonProperty("extensionForwarded_idMusicOnHoldGroup_reg")]
    public string? ExtensionForwarded_IdMusicOnHoldGroup_REG { get; set; }

    /// <summary> ExtensionForwarded.ExtensionType equals </summary>
    [JsonProperty("extensionForwarded_extensionType_eq")]
    public ExtensionType? ExtensionForwarded_ExtensionType_EQ { get; set; }

    /// <summary> ExtensionForwarded.FriendlyName equals </summary>
    [JsonProperty("extensionForwarded_friendlyName_eq")]
    public string? ExtensionForwarded_FriendlyName_EQ { get; set; }
    /// <summary> ExtensionForwarded.FriendlyName contains </summary>
    [JsonProperty("extensionForwarded_friendlyName_con")]
    public string? ExtensionForwarded_FriendlyName_CON { get; set; }
    /// <summary> ExtensionForwarded.FriendlyName regex </summary>
    [JsonProperty("extensionForwarded_friendlyName_reg")]
    public string? ExtensionForwarded_FriendlyName_REG { get; set; }

    /// <summary> ExtensionForwarded.Number equals </summary>
    [JsonProperty("extensionForwarded_number_eq")]
    public string? ExtensionForwarded_Number_EQ { get; set; }
    /// <summary> ExtensionForwarded.Number contains </summary>
    [JsonProperty("extensionForwarded_number_con")]
    public string? ExtensionForwarded_Number_CON { get; set; }
    /// <summary> ExtensionForwarded.Number regex </summary>
    [JsonProperty("extensionForwarded_number_reg")]
    public string? ExtensionForwarded_Number_REG { get; set; }

    /// <summary> ExtensionForwarded.InjectExtensionNameToCallerId equals </summary>
    [JsonProperty("extensionForwarded_injectExtensionNameToCallerId_eq")]
    public bool? ExtensionForwarded_InjectExtensionNameToCallerId_EQ { get; set; }

    /// <summary> ExtensionForwarded.Id equals </summary>
    [JsonProperty("extensionForwarded_id_eq")]
    public string? ExtensionForwarded_Id_EQ { get; set; }
    /// <summary> ExtensionForwarded.Id contains </summary>
    [JsonProperty("extensionForwarded_id_con")]
    public string? ExtensionForwarded_Id_CON { get; set; }
    /// <summary> ExtensionForwarded.Id regex </summary>
    [JsonProperty("extensionForwarded_id_reg")]
    public string? ExtensionForwarded_Id_REG { get; set; }

    /// <summary> ExtensionForwarded.DateCreated equals </summary>
    [JsonProperty("extensionForwarded_dateCreated_eq")]
    public DateTime? ExtensionForwarded_DateCreated_EQ { get; set; }
    /// <summary> ExtensionForwarded.DateCreated less than or equal to </summary>
    [JsonProperty("extensionForwarded_dateCreated_lte")]
    public DateTime? ExtensionForwarded_DateCreated_LTE { get; set; }
    /// <summary> ExtensionForwarded.DateCreated greater than or equal to </summary>
    [JsonProperty("extensionForwarded_dateCreated_gte")]
    public DateTime? ExtensionForwarded_DateCreated_GTE { get; set; }

    /// <summary> ExtensionForwarded.DateUpdated equals </summary>
    [JsonProperty("extensionForwarded_dateUpdated_eq")]
    public DateTime? ExtensionForwarded_DateUpdated_EQ { get; set; }
    /// <summary> ExtensionForwarded.DateUpdated less than or equal to </summary>
    [JsonProperty("extensionForwarded_dateUpdated_lte")]
    public DateTime? ExtensionForwarded_DateUpdated_LTE { get; set; }
    /// <summary> ExtensionForwarded.DateUpdated greater than or equal to </summary>
    [JsonProperty("extensionForwarded_dateUpdated_gte")]
    public DateTime? ExtensionForwarded_DateUpdated_GTE { get; set; }


    /// <summary> IdsLinesThatCanListenToVoicemail equals </summary>
    [JsonProperty("idsLinesThatCanListenToVoicemail_eq")]
    public string? IdsLinesThatCanListenToVoicemail_EQ { get; set; }
    /// <summary> IdsLinesThatCanListenToVoicemail contains </summary>
    [JsonProperty("idsLinesThatCanListenToVoicemail_con")]
    public string? IdsLinesThatCanListenToVoicemail_CON { get; set; }
    /// <summary> IdsLinesThatCanListenToVoicemail regex </summary>
    [JsonProperty("idsLinesThatCanListenToVoicemail_reg")]
    public string? IdsLinesThatCanListenToVoicemail_REG { get; set; }

    /// <summary> Email equals </summary>
    [JsonProperty("email_eq")]
    public string? Email_EQ { get; set; }
    /// <summary> Email contains </summary>
    [JsonProperty("email_con")]
    public string? Email_CON { get; set; }
    /// <summary> Email regex </summary>
    [JsonProperty("email_reg")]
    public string? Email_REG { get; set; }

    /// <summary> DurationInSeconds equals </summary>
    [JsonProperty("durationInSeconds_eq")]
    public System.Int32? DurationInSeconds_EQ { get; set; }
    /// <summary> DurationInSeconds less than or equal to </summary>
    [JsonProperty("durationInSeconds_lte")]
    public System.Int32? DurationInSeconds_LTE { get; set; }
    /// <summary> DurationInSeconds greater than or equal to </summary>
    [JsonProperty("durationInSeconds_gte")]
    public System.Int32? DurationInSeconds_GTE { get; set; }

    /// <summary> VoicemailWav.InstanceId equals </summary>
    [JsonProperty("voicemailWav_instanceId_eq")]
    public string? VoicemailWav_InstanceId_EQ { get; set; }
    /// <summary> VoicemailWav.InstanceId contains </summary>
    [JsonProperty("voicemailWav_instanceId_con")]
    public string? VoicemailWav_InstanceId_CON { get; set; }
    /// <summary> VoicemailWav.InstanceId regex </summary>
    [JsonProperty("voicemailWav_instanceId_reg")]
    public string? VoicemailWav_InstanceId_REG { get; set; }

    /// <summary> VoicemailWav.FileSizeInBytes equals </summary>
    [JsonProperty("voicemailWav_fileSizeInBytes_eq")]
    public System.Int32? VoicemailWav_FileSizeInBytes_EQ { get; set; }
    /// <summary> VoicemailWav.FileSizeInBytes less than or equal to </summary>
    [JsonProperty("voicemailWav_fileSizeInBytes_lte")]
    public System.Int32? VoicemailWav_FileSizeInBytes_LTE { get; set; }
    /// <summary> VoicemailWav.FileSizeInBytes greater than or equal to </summary>
    [JsonProperty("voicemailWav_fileSizeInBytes_gte")]
    public System.Int32? VoicemailWav_FileSizeInBytes_GTE { get; set; }

    /// <summary> VoicemailWav.Md5Hash equals </summary>
    [JsonProperty("voicemailWav_md5Hash_eq")]
    public string? VoicemailWav_Md5Hash_EQ { get; set; }
    /// <summary> VoicemailWav.Md5Hash contains </summary>
    [JsonProperty("voicemailWav_md5Hash_con")]
    public string? VoicemailWav_Md5Hash_CON { get; set; }
    /// <summary> VoicemailWav.Md5Hash regex </summary>
    [JsonProperty("voicemailWav_md5Hash_reg")]
    public string? VoicemailWav_Md5Hash_REG { get; set; }

    /// <summary> VoicemailWav.Url equals </summary>
    [JsonProperty("voicemailWav_url_eq")]
    public string? VoicemailWav_Url_EQ { get; set; }
    /// <summary> VoicemailWav.Url contains </summary>
    [JsonProperty("voicemailWav_url_con")]
    public string? VoicemailWav_Url_CON { get; set; }
    /// <summary> VoicemailWav.Url regex </summary>
    [JsonProperty("voicemailWav_url_reg")]
    public string? VoicemailWav_Url_REG { get; set; }

    /// <summary> VoicemailWav.Id equals </summary>
    [JsonProperty("voicemailWav_id_eq")]
    public string? VoicemailWav_Id_EQ { get; set; }
    /// <summary> VoicemailWav.Id contains </summary>
    [JsonProperty("voicemailWav_id_con")]
    public string? VoicemailWav_Id_CON { get; set; }
    /// <summary> VoicemailWav.Id regex </summary>
    [JsonProperty("voicemailWav_id_reg")]
    public string? VoicemailWav_Id_REG { get; set; }


    /// <summary> VoicemailMp3.InstanceId equals </summary>
    [JsonProperty("voicemailMp3_instanceId_eq")]
    public string? VoicemailMp3_InstanceId_EQ { get; set; }
    /// <summary> VoicemailMp3.InstanceId contains </summary>
    [JsonProperty("voicemailMp3_instanceId_con")]
    public string? VoicemailMp3_InstanceId_CON { get; set; }
    /// <summary> VoicemailMp3.InstanceId regex </summary>
    [JsonProperty("voicemailMp3_instanceId_reg")]
    public string? VoicemailMp3_InstanceId_REG { get; set; }

    /// <summary> VoicemailMp3.FileSizeInBytes equals </summary>
    [JsonProperty("voicemailMp3_fileSizeInBytes_eq")]
    public System.Int32? VoicemailMp3_FileSizeInBytes_EQ { get; set; }
    /// <summary> VoicemailMp3.FileSizeInBytes less than or equal to </summary>
    [JsonProperty("voicemailMp3_fileSizeInBytes_lte")]
    public System.Int32? VoicemailMp3_FileSizeInBytes_LTE { get; set; }
    /// <summary> VoicemailMp3.FileSizeInBytes greater than or equal to </summary>
    [JsonProperty("voicemailMp3_fileSizeInBytes_gte")]
    public System.Int32? VoicemailMp3_FileSizeInBytes_GTE { get; set; }

    /// <summary> VoicemailMp3.Md5Hash equals </summary>
    [JsonProperty("voicemailMp3_md5Hash_eq")]
    public string? VoicemailMp3_Md5Hash_EQ { get; set; }
    /// <summary> VoicemailMp3.Md5Hash contains </summary>
    [JsonProperty("voicemailMp3_md5Hash_con")]
    public string? VoicemailMp3_Md5Hash_CON { get; set; }
    /// <summary> VoicemailMp3.Md5Hash regex </summary>
    [JsonProperty("voicemailMp3_md5Hash_reg")]
    public string? VoicemailMp3_Md5Hash_REG { get; set; }

    /// <summary> VoicemailMp3.Url equals </summary>
    [JsonProperty("voicemailMp3_url_eq")]
    public string? VoicemailMp3_Url_EQ { get; set; }
    /// <summary> VoicemailMp3.Url contains </summary>
    [JsonProperty("voicemailMp3_url_con")]
    public string? VoicemailMp3_Url_CON { get; set; }
    /// <summary> VoicemailMp3.Url regex </summary>
    [JsonProperty("voicemailMp3_url_reg")]
    public string? VoicemailMp3_Url_REG { get; set; }

    /// <summary> VoicemailMp3.Id equals </summary>
    [JsonProperty("voicemailMp3_id_eq")]
    public string? VoicemailMp3_Id_EQ { get; set; }
    /// <summary> VoicemailMp3.Id contains </summary>
    [JsonProperty("voicemailMp3_id_con")]
    public string? VoicemailMp3_Id_CON { get; set; }
    /// <summary> VoicemailMp3.Id regex </summary>
    [JsonProperty("voicemailMp3_id_reg")]
    public string? VoicemailMp3_Id_REG { get; set; }


    /// <summary> ErrorMessage equals </summary>
    [JsonProperty("errorMessage_eq")]
    public string? ErrorMessage_EQ { get; set; }
    /// <summary> ErrorMessage contains </summary>
    [JsonProperty("errorMessage_con")]
    public string? ErrorMessage_CON { get; set; }
    /// <summary> ErrorMessage regex </summary>
    [JsonProperty("errorMessage_reg")]
    public string? ErrorMessage_REG { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for VoipNumberAvailableForPurchases </summary>
public class VoipNumberAvailableForPurchaseFilterRequest 
{
    /// <summary> RulesPhone.IdCallFlowLogic equals </summary>
    [JsonProperty("rulesPhone_idCallFlowLogic_eq")]
    public string? RulesPhone_IdCallFlowLogic_EQ { get; set; }
    /// <summary> RulesPhone.IdCallFlowLogic contains </summary>
    [JsonProperty("rulesPhone_idCallFlowLogic_con")]
    public string? RulesPhone_IdCallFlowLogic_CON { get; set; }
    /// <summary> RulesPhone.IdCallFlowLogic regex </summary>
    [JsonProperty("rulesPhone_idCallFlowLogic_reg")]
    public string? RulesPhone_IdCallFlowLogic_REG { get; set; }

    /// <summary> RulesPhone.IdExtension equals </summary>
    [JsonProperty("rulesPhone_idExtension_eq")]
    public string? RulesPhone_IdExtension_EQ { get; set; }
    /// <summary> RulesPhone.IdExtension contains </summary>
    [JsonProperty("rulesPhone_idExtension_con")]
    public string? RulesPhone_IdExtension_CON { get; set; }
    /// <summary> RulesPhone.IdExtension regex </summary>
    [JsonProperty("rulesPhone_idExtension_reg")]
    public string? RulesPhone_IdExtension_REG { get; set; }

    /// <summary> RulesPhone.DaysOfWeek contains </summary>
    [JsonProperty("rulesPhone_daysOfWeek_con")]
    public DayOfWeek? RulesPhone_DaysOfWeek_CON { get; set; }


    /// <summary> RulesSms.ForwardToEmailAddress equals </summary>
    [JsonProperty("rulesSms_forwardToEmailAddress_eq")]
    public string? RulesSms_ForwardToEmailAddress_EQ { get; set; }
    /// <summary> RulesSms.ForwardToEmailAddress contains </summary>
    [JsonProperty("rulesSms_forwardToEmailAddress_con")]
    public string? RulesSms_ForwardToEmailAddress_CON { get; set; }
    /// <summary> RulesSms.ForwardToEmailAddress regex </summary>
    [JsonProperty("rulesSms_forwardToEmailAddress_reg")]
    public string? RulesSms_ForwardToEmailAddress_REG { get; set; }


    /// <summary> RulesFax.ForwardToEmailAddress equals </summary>
    [JsonProperty("rulesFax_forwardToEmailAddress_eq")]
    public string? RulesFax_ForwardToEmailAddress_EQ { get; set; }
    /// <summary> RulesFax.ForwardToEmailAddress contains </summary>
    [JsonProperty("rulesFax_forwardToEmailAddress_con")]
    public string? RulesFax_ForwardToEmailAddress_CON { get; set; }
    /// <summary> RulesFax.ForwardToEmailAddress regex </summary>
    [JsonProperty("rulesFax_forwardToEmailAddress_reg")]
    public string? RulesFax_ForwardToEmailAddress_REG { get; set; }


    /// <summary> RequiresCustomerInfo equals </summary>
    [JsonProperty("requiresCustomerInfo_eq")]
    public bool? RequiresCustomerInfo_EQ { get; set; }

    /// <summary> PendingToBeConfigured equals </summary>
    [JsonProperty("pendingToBeConfigured_eq")]
    public bool? PendingToBeConfigured_EQ { get; set; }

    /// <summary> VoipNumberType equals </summary>
    [JsonProperty("voipNumberType_eq")]
    public VoipNumberType? VoipNumberType_EQ { get; set; }

    /// <summary> InjectFriendlyNameToCallerId equals </summary>
    [JsonProperty("injectFriendlyNameToCallerId_eq")]
    public bool? InjectFriendlyNameToCallerId_EQ { get; set; }

    /// <summary> RecordIncomingCalls equals </summary>
    [JsonProperty("recordIncomingCalls_eq")]
    public bool? RecordIncomingCalls_EQ { get; set; }

    /// <summary> Number equals </summary>
    [JsonProperty("number_eq")]
    public string? Number_EQ { get; set; }
    /// <summary> Number contains </summary>
    [JsonProperty("number_con")]
    public string? Number_CON { get; set; }
    /// <summary> Number regex </summary>
    [JsonProperty("number_reg")]
    public string? Number_REG { get; set; }

    /// <summary> FriendlyName equals </summary>
    [JsonProperty("friendlyName_eq")]
    public string? FriendlyName_EQ { get; set; }
    /// <summary> FriendlyName contains </summary>
    [JsonProperty("friendlyName_con")]
    public string? FriendlyName_CON { get; set; }
    /// <summary> FriendlyName regex </summary>
    [JsonProperty("friendlyName_reg")]
    public string? FriendlyName_REG { get; set; }

    /// <summary> Description equals </summary>
    [JsonProperty("description_eq")]
    public string? Description_EQ { get; set; }
    /// <summary> Description contains </summary>
    [JsonProperty("description_con")]
    public string? Description_CON { get; set; }
    /// <summary> Description regex </summary>
    [JsonProperty("description_reg")]
    public string? Description_REG { get; set; }

    /// <summary> Language equals </summary>
    [JsonProperty("language_eq")]
    public Language? Language_EQ { get; set; }

    /// <summary> City equals </summary>
    [JsonProperty("city_eq")]
    public string? City_EQ { get; set; }
    /// <summary> City contains </summary>
    [JsonProperty("city_con")]
    public string? City_CON { get; set; }
    /// <summary> City regex </summary>
    [JsonProperty("city_reg")]
    public string? City_REG { get; set; }

    /// <summary> State equals </summary>
    [JsonProperty("state_eq")]
    public string? State_EQ { get; set; }
    /// <summary> State contains </summary>
    [JsonProperty("state_con")]
    public string? State_CON { get; set; }
    /// <summary> State regex </summary>
    [JsonProperty("state_reg")]
    public string? State_REG { get; set; }

    /// <summary> CountryIsoCode equals </summary>
    [JsonProperty("countryIsoCode_eq")]
    public CountryIsoCode? CountryIsoCode_EQ { get; set; }

    /// <summary> IsSmsEnabled equals </summary>
    [JsonProperty("isSmsEnabled_eq")]
    public bool? IsSmsEnabled_EQ { get; set; }

    /// <summary> IsVoiceEnabled equals </summary>
    [JsonProperty("isVoiceEnabled_eq")]
    public bool? IsVoiceEnabled_EQ { get; set; }

    /// <summary> IsTollFree equals </summary>
    [JsonProperty("isTollFree_eq")]
    public bool? IsTollFree_EQ { get; set; }

    /// <summary> IsWhatsappEnabled equals </summary>
    [JsonProperty("isWhatsappEnabled_eq")]
    public bool? IsWhatsappEnabled_EQ { get; set; }

    /// <summary> TimeZone equals </summary>
    [JsonProperty("timeZone_eq")]
    public string? TimeZone_EQ { get; set; }
    /// <summary> TimeZone contains </summary>
    [JsonProperty("timeZone_con")]
    public string? TimeZone_CON { get; set; }
    /// <summary> TimeZone regex </summary>
    [JsonProperty("timeZone_reg")]
    public string? TimeZone_REG { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for VoipNumberFaxs </summary>
public class VoipNumberFaxFilterRequest 
{
    /// <summary> RulesPhone.IdCallFlowLogic equals </summary>
    [JsonProperty("rulesPhone_idCallFlowLogic_eq")]
    public string? RulesPhone_IdCallFlowLogic_EQ { get; set; }
    /// <summary> RulesPhone.IdCallFlowLogic contains </summary>
    [JsonProperty("rulesPhone_idCallFlowLogic_con")]
    public string? RulesPhone_IdCallFlowLogic_CON { get; set; }
    /// <summary> RulesPhone.IdCallFlowLogic regex </summary>
    [JsonProperty("rulesPhone_idCallFlowLogic_reg")]
    public string? RulesPhone_IdCallFlowLogic_REG { get; set; }

    /// <summary> RulesPhone.IdExtension equals </summary>
    [JsonProperty("rulesPhone_idExtension_eq")]
    public string? RulesPhone_IdExtension_EQ { get; set; }
    /// <summary> RulesPhone.IdExtension contains </summary>
    [JsonProperty("rulesPhone_idExtension_con")]
    public string? RulesPhone_IdExtension_CON { get; set; }
    /// <summary> RulesPhone.IdExtension regex </summary>
    [JsonProperty("rulesPhone_idExtension_reg")]
    public string? RulesPhone_IdExtension_REG { get; set; }

    /// <summary> RulesPhone.DaysOfWeek contains </summary>
    [JsonProperty("rulesPhone_daysOfWeek_con")]
    public DayOfWeek? RulesPhone_DaysOfWeek_CON { get; set; }


    /// <summary> RulesSms.ForwardToEmailAddress equals </summary>
    [JsonProperty("rulesSms_forwardToEmailAddress_eq")]
    public string? RulesSms_ForwardToEmailAddress_EQ { get; set; }
    /// <summary> RulesSms.ForwardToEmailAddress contains </summary>
    [JsonProperty("rulesSms_forwardToEmailAddress_con")]
    public string? RulesSms_ForwardToEmailAddress_CON { get; set; }
    /// <summary> RulesSms.ForwardToEmailAddress regex </summary>
    [JsonProperty("rulesSms_forwardToEmailAddress_reg")]
    public string? RulesSms_ForwardToEmailAddress_REG { get; set; }


    /// <summary> RulesFax.ForwardToEmailAddress equals </summary>
    [JsonProperty("rulesFax_forwardToEmailAddress_eq")]
    public string? RulesFax_ForwardToEmailAddress_EQ { get; set; }
    /// <summary> RulesFax.ForwardToEmailAddress contains </summary>
    [JsonProperty("rulesFax_forwardToEmailAddress_con")]
    public string? RulesFax_ForwardToEmailAddress_CON { get; set; }
    /// <summary> RulesFax.ForwardToEmailAddress regex </summary>
    [JsonProperty("rulesFax_forwardToEmailAddress_reg")]
    public string? RulesFax_ForwardToEmailAddress_REG { get; set; }


    /// <summary> VoipNumberType equals </summary>
    [JsonProperty("voipNumberType_eq")]
    public VoipNumberType? VoipNumberType_EQ { get; set; }

    /// <summary> InjectFriendlyNameToCallerId equals </summary>
    [JsonProperty("injectFriendlyNameToCallerId_eq")]
    public bool? InjectFriendlyNameToCallerId_EQ { get; set; }

    /// <summary> RecordIncomingCalls equals </summary>
    [JsonProperty("recordIncomingCalls_eq")]
    public bool? RecordIncomingCalls_EQ { get; set; }

    /// <summary> Number equals </summary>
    [JsonProperty("number_eq")]
    public string? Number_EQ { get; set; }
    /// <summary> Number contains </summary>
    [JsonProperty("number_con")]
    public string? Number_CON { get; set; }
    /// <summary> Number regex </summary>
    [JsonProperty("number_reg")]
    public string? Number_REG { get; set; }

    /// <summary> FriendlyName equals </summary>
    [JsonProperty("friendlyName_eq")]
    public string? FriendlyName_EQ { get; set; }
    /// <summary> FriendlyName contains </summary>
    [JsonProperty("friendlyName_con")]
    public string? FriendlyName_CON { get; set; }
    /// <summary> FriendlyName regex </summary>
    [JsonProperty("friendlyName_reg")]
    public string? FriendlyName_REG { get; set; }

    /// <summary> Description equals </summary>
    [JsonProperty("description_eq")]
    public string? Description_EQ { get; set; }
    /// <summary> Description contains </summary>
    [JsonProperty("description_con")]
    public string? Description_CON { get; set; }
    /// <summary> Description regex </summary>
    [JsonProperty("description_reg")]
    public string? Description_REG { get; set; }

    /// <summary> Language equals </summary>
    [JsonProperty("language_eq")]
    public Language? Language_EQ { get; set; }

    /// <summary> City equals </summary>
    [JsonProperty("city_eq")]
    public string? City_EQ { get; set; }
    /// <summary> City contains </summary>
    [JsonProperty("city_con")]
    public string? City_CON { get; set; }
    /// <summary> City regex </summary>
    [JsonProperty("city_reg")]
    public string? City_REG { get; set; }

    /// <summary> State equals </summary>
    [JsonProperty("state_eq")]
    public string? State_EQ { get; set; }
    /// <summary> State contains </summary>
    [JsonProperty("state_con")]
    public string? State_CON { get; set; }
    /// <summary> State regex </summary>
    [JsonProperty("state_reg")]
    public string? State_REG { get; set; }

    /// <summary> CountryIsoCode equals </summary>
    [JsonProperty("countryIsoCode_eq")]
    public CountryIsoCode? CountryIsoCode_EQ { get; set; }

    /// <summary> IsSmsEnabled equals </summary>
    [JsonProperty("isSmsEnabled_eq")]
    public bool? IsSmsEnabled_EQ { get; set; }

    /// <summary> IsVoiceEnabled equals </summary>
    [JsonProperty("isVoiceEnabled_eq")]
    public bool? IsVoiceEnabled_EQ { get; set; }

    /// <summary> IsTollFree equals </summary>
    [JsonProperty("isTollFree_eq")]
    public bool? IsTollFree_EQ { get; set; }

    /// <summary> IsWhatsappEnabled equals </summary>
    [JsonProperty("isWhatsappEnabled_eq")]
    public bool? IsWhatsappEnabled_EQ { get; set; }

    /// <summary> TimeZone equals </summary>
    [JsonProperty("timeZone_eq")]
    public string? TimeZone_EQ { get; set; }
    /// <summary> TimeZone contains </summary>
    [JsonProperty("timeZone_con")]
    public string? TimeZone_CON { get; set; }
    /// <summary> TimeZone regex </summary>
    [JsonProperty("timeZone_reg")]
    public string? TimeZone_REG { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for VoipNumberPhones </summary>
public class VoipNumberPhoneFilterRequest 
{
    /// <summary> RulesPhone.IdCallFlowLogic equals </summary>
    [JsonProperty("rulesPhone_idCallFlowLogic_eq")]
    public string? RulesPhone_IdCallFlowLogic_EQ { get; set; }
    /// <summary> RulesPhone.IdCallFlowLogic contains </summary>
    [JsonProperty("rulesPhone_idCallFlowLogic_con")]
    public string? RulesPhone_IdCallFlowLogic_CON { get; set; }
    /// <summary> RulesPhone.IdCallFlowLogic regex </summary>
    [JsonProperty("rulesPhone_idCallFlowLogic_reg")]
    public string? RulesPhone_IdCallFlowLogic_REG { get; set; }

    /// <summary> RulesPhone.IdExtension equals </summary>
    [JsonProperty("rulesPhone_idExtension_eq")]
    public string? RulesPhone_IdExtension_EQ { get; set; }
    /// <summary> RulesPhone.IdExtension contains </summary>
    [JsonProperty("rulesPhone_idExtension_con")]
    public string? RulesPhone_IdExtension_CON { get; set; }
    /// <summary> RulesPhone.IdExtension regex </summary>
    [JsonProperty("rulesPhone_idExtension_reg")]
    public string? RulesPhone_IdExtension_REG { get; set; }

    /// <summary> RulesPhone.DaysOfWeek contains </summary>
    [JsonProperty("rulesPhone_daysOfWeek_con")]
    public DayOfWeek? RulesPhone_DaysOfWeek_CON { get; set; }


    /// <summary> RulesSms.ForwardToEmailAddress equals </summary>
    [JsonProperty("rulesSms_forwardToEmailAddress_eq")]
    public string? RulesSms_ForwardToEmailAddress_EQ { get; set; }
    /// <summary> RulesSms.ForwardToEmailAddress contains </summary>
    [JsonProperty("rulesSms_forwardToEmailAddress_con")]
    public string? RulesSms_ForwardToEmailAddress_CON { get; set; }
    /// <summary> RulesSms.ForwardToEmailAddress regex </summary>
    [JsonProperty("rulesSms_forwardToEmailAddress_reg")]
    public string? RulesSms_ForwardToEmailAddress_REG { get; set; }


    /// <summary> RulesFax.ForwardToEmailAddress equals </summary>
    [JsonProperty("rulesFax_forwardToEmailAddress_eq")]
    public string? RulesFax_ForwardToEmailAddress_EQ { get; set; }
    /// <summary> RulesFax.ForwardToEmailAddress contains </summary>
    [JsonProperty("rulesFax_forwardToEmailAddress_con")]
    public string? RulesFax_ForwardToEmailAddress_CON { get; set; }
    /// <summary> RulesFax.ForwardToEmailAddress regex </summary>
    [JsonProperty("rulesFax_forwardToEmailAddress_reg")]
    public string? RulesFax_ForwardToEmailAddress_REG { get; set; }


    /// <summary> VoipNumberType equals </summary>
    [JsonProperty("voipNumberType_eq")]
    public VoipNumberType? VoipNumberType_EQ { get; set; }

    /// <summary> InjectFriendlyNameToCallerId equals </summary>
    [JsonProperty("injectFriendlyNameToCallerId_eq")]
    public bool? InjectFriendlyNameToCallerId_EQ { get; set; }

    /// <summary> RecordIncomingCalls equals </summary>
    [JsonProperty("recordIncomingCalls_eq")]
    public bool? RecordIncomingCalls_EQ { get; set; }

    /// <summary> Number equals </summary>
    [JsonProperty("number_eq")]
    public string? Number_EQ { get; set; }
    /// <summary> Number contains </summary>
    [JsonProperty("number_con")]
    public string? Number_CON { get; set; }
    /// <summary> Number regex </summary>
    [JsonProperty("number_reg")]
    public string? Number_REG { get; set; }

    /// <summary> FriendlyName equals </summary>
    [JsonProperty("friendlyName_eq")]
    public string? FriendlyName_EQ { get; set; }
    /// <summary> FriendlyName contains </summary>
    [JsonProperty("friendlyName_con")]
    public string? FriendlyName_CON { get; set; }
    /// <summary> FriendlyName regex </summary>
    [JsonProperty("friendlyName_reg")]
    public string? FriendlyName_REG { get; set; }

    /// <summary> Description equals </summary>
    [JsonProperty("description_eq")]
    public string? Description_EQ { get; set; }
    /// <summary> Description contains </summary>
    [JsonProperty("description_con")]
    public string? Description_CON { get; set; }
    /// <summary> Description regex </summary>
    [JsonProperty("description_reg")]
    public string? Description_REG { get; set; }

    /// <summary> Language equals </summary>
    [JsonProperty("language_eq")]
    public Language? Language_EQ { get; set; }

    /// <summary> City equals </summary>
    [JsonProperty("city_eq")]
    public string? City_EQ { get; set; }
    /// <summary> City contains </summary>
    [JsonProperty("city_con")]
    public string? City_CON { get; set; }
    /// <summary> City regex </summary>
    [JsonProperty("city_reg")]
    public string? City_REG { get; set; }

    /// <summary> State equals </summary>
    [JsonProperty("state_eq")]
    public string? State_EQ { get; set; }
    /// <summary> State contains </summary>
    [JsonProperty("state_con")]
    public string? State_CON { get; set; }
    /// <summary> State regex </summary>
    [JsonProperty("state_reg")]
    public string? State_REG { get; set; }

    /// <summary> CountryIsoCode equals </summary>
    [JsonProperty("countryIsoCode_eq")]
    public CountryIsoCode? CountryIsoCode_EQ { get; set; }

    /// <summary> IsSmsEnabled equals </summary>
    [JsonProperty("isSmsEnabled_eq")]
    public bool? IsSmsEnabled_EQ { get; set; }

    /// <summary> IsVoiceEnabled equals </summary>
    [JsonProperty("isVoiceEnabled_eq")]
    public bool? IsVoiceEnabled_EQ { get; set; }

    /// <summary> IsTollFree equals </summary>
    [JsonProperty("isTollFree_eq")]
    public bool? IsTollFree_EQ { get; set; }

    /// <summary> IsWhatsappEnabled equals </summary>
    [JsonProperty("isWhatsappEnabled_eq")]
    public bool? IsWhatsappEnabled_EQ { get; set; }

    /// <summary> TimeZone equals </summary>
    [JsonProperty("timeZone_eq")]
    public string? TimeZone_EQ { get; set; }
    /// <summary> TimeZone contains </summary>
    [JsonProperty("timeZone_con")]
    public string? TimeZone_CON { get; set; }
    /// <summary> TimeZone regex </summary>
    [JsonProperty("timeZone_reg")]
    public string? TimeZone_REG { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for VoipProviders </summary>
public class VoipProviderFilterRequest 
{
    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for WebHooks </summary>
public class WebHookFilterRequest 
{
    /// <summary> WebHookEvent equals </summary>
    [JsonProperty("webHookEvent_eq")]
    public WebHookEvent? WebHookEvent_EQ { get; set; }

    /// <summary> Url equals </summary>
    [JsonProperty("url_eq")]
    public string? Url_EQ { get; set; }
    /// <summary> Url contains </summary>
    [JsonProperty("url_con")]
    public string? Url_CON { get; set; }
    /// <summary> Url regex </summary>
    [JsonProperty("url_reg")]
    public string? Url_REG { get; set; }

    /// <summary> Headers equals </summary>
    [JsonProperty("headers_eq")]
    public string? Headers_EQ { get; set; }
    /// <summary> Headers contains </summary>
    [JsonProperty("headers_con")]
    public string? Headers_CON { get; set; }
    /// <summary> Headers regex </summary>
    [JsonProperty("headers_reg")]
    public string? Headers_REG { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for CloudFiles </summary>
public class CloudFileFilterRequest 
{
    /// <summary> IdDocument equals </summary>
    [JsonProperty("idDocument_eq")]
    public string? IdDocument_EQ { get; set; }
    /// <summary> IdDocument contains </summary>
    [JsonProperty("idDocument_con")]
    public string? IdDocument_CON { get; set; }
    /// <summary> IdDocument regex </summary>
    [JsonProperty("idDocument_reg")]
    public string? IdDocument_REG { get; set; }

    /// <summary> StoredFile.InstanceId equals </summary>
    [JsonProperty("storedFile_instanceId_eq")]
    public string? StoredFile_InstanceId_EQ { get; set; }
    /// <summary> StoredFile.InstanceId contains </summary>
    [JsonProperty("storedFile_instanceId_con")]
    public string? StoredFile_InstanceId_CON { get; set; }
    /// <summary> StoredFile.InstanceId regex </summary>
    [JsonProperty("storedFile_instanceId_reg")]
    public string? StoredFile_InstanceId_REG { get; set; }

    /// <summary> StoredFile.FileSizeInBytes equals </summary>
    [JsonProperty("storedFile_fileSizeInBytes_eq")]
    public System.Int32? StoredFile_FileSizeInBytes_EQ { get; set; }
    /// <summary> StoredFile.FileSizeInBytes less than or equal to </summary>
    [JsonProperty("storedFile_fileSizeInBytes_lte")]
    public System.Int32? StoredFile_FileSizeInBytes_LTE { get; set; }
    /// <summary> StoredFile.FileSizeInBytes greater than or equal to </summary>
    [JsonProperty("storedFile_fileSizeInBytes_gte")]
    public System.Int32? StoredFile_FileSizeInBytes_GTE { get; set; }

    /// <summary> StoredFile.Md5Hash equals </summary>
    [JsonProperty("storedFile_md5Hash_eq")]
    public string? StoredFile_Md5Hash_EQ { get; set; }
    /// <summary> StoredFile.Md5Hash contains </summary>
    [JsonProperty("storedFile_md5Hash_con")]
    public string? StoredFile_Md5Hash_CON { get; set; }
    /// <summary> StoredFile.Md5Hash regex </summary>
    [JsonProperty("storedFile_md5Hash_reg")]
    public string? StoredFile_Md5Hash_REG { get; set; }

    /// <summary> StoredFile.Url equals </summary>
    [JsonProperty("storedFile_url_eq")]
    public string? StoredFile_Url_EQ { get; set; }
    /// <summary> StoredFile.Url contains </summary>
    [JsonProperty("storedFile_url_con")]
    public string? StoredFile_Url_CON { get; set; }
    /// <summary> StoredFile.Url regex </summary>
    [JsonProperty("storedFile_url_reg")]
    public string? StoredFile_Url_REG { get; set; }

    /// <summary> StoredFile.Id equals </summary>
    [JsonProperty("storedFile_id_eq")]
    public string? StoredFile_Id_EQ { get; set; }
    /// <summary> StoredFile.Id contains </summary>
    [JsonProperty("storedFile_id_con")]
    public string? StoredFile_Id_CON { get; set; }
    /// <summary> StoredFile.Id regex </summary>
    [JsonProperty("storedFile_id_reg")]
    public string? StoredFile_Id_REG { get; set; }


    /// <summary> IsBackup equals </summary>
    [JsonProperty("isBackup_eq")]
    public bool? IsBackup_EQ { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for Calls </summary>
public class CallFilterRequest 
{
    /// <summary> IdVoicemail equals </summary>
    [JsonProperty("idVoicemail_eq")]
    public string? IdVoicemail_EQ { get; set; }
    /// <summary> IdVoicemail contains </summary>
    [JsonProperty("idVoicemail_con")]
    public string? IdVoicemail_CON { get; set; }
    /// <summary> IdVoicemail regex </summary>
    [JsonProperty("idVoicemail_reg")]
    public string? IdVoicemail_REG { get; set; }

    /// <summary> IdCallThatTerminatedThisCallDoToAttendantTransfer equals </summary>
    [JsonProperty("idCallThatTerminatedThisCallDoToAttendantTransfer_eq")]
    public string? IdCallThatTerminatedThisCallDoToAttendantTransfer_EQ { get; set; }
    /// <summary> IdCallThatTerminatedThisCallDoToAttendantTransfer contains </summary>
    [JsonProperty("idCallThatTerminatedThisCallDoToAttendantTransfer_con")]
    public string? IdCallThatTerminatedThisCallDoToAttendantTransfer_CON { get; set; }
    /// <summary> IdCallThatTerminatedThisCallDoToAttendantTransfer regex </summary>
    [JsonProperty("idCallThatTerminatedThisCallDoToAttendantTransfer_reg")]
    public string? IdCallThatTerminatedThisCallDoToAttendantTransfer_REG { get; set; }

    /// <summary> ChannelVariables.Language equals </summary>
    [JsonProperty("channelVariables_language_eq")]
    public Language? ChannelVariables_Language_EQ { get; set; }

    /// <summary> ChannelVariables.IdMusicOnHold equals </summary>
    [JsonProperty("channelVariables_idMusicOnHold_eq")]
    public string? ChannelVariables_IdMusicOnHold_EQ { get; set; }
    /// <summary> ChannelVariables.IdMusicOnHold contains </summary>
    [JsonProperty("channelVariables_idMusicOnHold_con")]
    public string? ChannelVariables_IdMusicOnHold_CON { get; set; }
    /// <summary> ChannelVariables.IdMusicOnHold regex </summary>
    [JsonProperty("channelVariables_idMusicOnHold_reg")]
    public string? ChannelVariables_IdMusicOnHold_REG { get; set; }

    /// <summary> ChannelVariables.CallerIdName equals </summary>
    [JsonProperty("channelVariables_callerIdName_eq")]
    public string? ChannelVariables_CallerIdName_EQ { get; set; }
    /// <summary> ChannelVariables.CallerIdName contains </summary>
    [JsonProperty("channelVariables_callerIdName_con")]
    public string? ChannelVariables_CallerIdName_CON { get; set; }
    /// <summary> ChannelVariables.CallerIdName regex </summary>
    [JsonProperty("channelVariables_callerIdName_reg")]
    public string? ChannelVariables_CallerIdName_REG { get; set; }

    /// <summary> ChannelVariables.CallerIdNumber equals </summary>
    [JsonProperty("channelVariables_callerIdNumber_eq")]
    public string? ChannelVariables_CallerIdNumber_EQ { get; set; }
    /// <summary> ChannelVariables.CallerIdNumber contains </summary>
    [JsonProperty("channelVariables_callerIdNumber_con")]
    public string? ChannelVariables_CallerIdNumber_CON { get; set; }
    /// <summary> ChannelVariables.CallerIdNumber regex </summary>
    [JsonProperty("channelVariables_callerIdNumber_reg")]
    public string? ChannelVariables_CallerIdNumber_REG { get; set; }


    /// <summary> ChildCalls.ChildCallType equals </summary>
    [JsonProperty("childCalls_childCallType_eq")]
    public ChildCallType? ChildCalls_ChildCallType_EQ { get; set; }

    /// <summary> ChildCalls.DialStatus equals </summary>
    [JsonProperty("childCalls_dialStatus_eq")]
    public string? ChildCalls_DialStatus_EQ { get; set; }
    /// <summary> ChildCalls.DialStatus contains </summary>
    [JsonProperty("childCalls_dialStatus_con")]
    public string? ChildCalls_DialStatus_CON { get; set; }
    /// <summary> ChildCalls.DialStatus regex </summary>
    [JsonProperty("childCalls_dialStatus_reg")]
    public string? ChildCalls_DialStatus_REG { get; set; }

    /// <summary> ChildCalls.DateCreated equals </summary>
    [JsonProperty("childCalls_dateCreated_eq")]
    public DateTime? ChildCalls_DateCreated_EQ { get; set; }
    /// <summary> ChildCalls.DateCreated less than or equal to </summary>
    [JsonProperty("childCalls_dateCreated_lte")]
    public DateTime? ChildCalls_DateCreated_LTE { get; set; }
    /// <summary> ChildCalls.DateCreated greater than or equal to </summary>
    [JsonProperty("childCalls_dateCreated_gte")]
    public DateTime? ChildCalls_DateCreated_GTE { get; set; }

    /// <summary> ChildCalls.DateEnded equals </summary>
    [JsonProperty("childCalls_dateEnded_eq")]
    public DateTime? ChildCalls_DateEnded_EQ { get; set; }
    /// <summary> ChildCalls.DateEnded less than or equal to </summary>
    [JsonProperty("childCalls_dateEnded_lte")]
    public DateTime? ChildCalls_DateEnded_LTE { get; set; }
    /// <summary> ChildCalls.DateEnded greater than or equal to </summary>
    [JsonProperty("childCalls_dateEnded_gte")]
    public DateTime? ChildCalls_DateEnded_GTE { get; set; }

    /// <summary> ChildCalls.SecondsItTookToAnswer equals </summary>
    [JsonProperty("childCalls_secondsItTookToAnswer_eq")]
    public System.Int32? ChildCalls_SecondsItTookToAnswer_EQ { get; set; }
    /// <summary> ChildCalls.SecondsItTookToAnswer less than or equal to </summary>
    [JsonProperty("childCalls_secondsItTookToAnswer_lte")]
    public System.Int32? ChildCalls_SecondsItTookToAnswer_LTE { get; set; }
    /// <summary> ChildCalls.SecondsItTookToAnswer greater than or equal to </summary>
    [JsonProperty("childCalls_secondsItTookToAnswer_gte")]
    public System.Int32? ChildCalls_SecondsItTookToAnswer_GTE { get; set; }


    /// <summary> Contact.IdIdentityUser equals </summary>
    [JsonProperty("contact_idIdentityUser_eq")]
    public string? Contact_IdIdentityUser_EQ { get; set; }
    /// <summary> Contact.IdIdentityUser contains </summary>
    [JsonProperty("contact_idIdentityUser_con")]
    public string? Contact_IdIdentityUser_CON { get; set; }
    /// <summary> Contact.IdIdentityUser regex </summary>
    [JsonProperty("contact_idIdentityUser_reg")]
    public string? Contact_IdIdentityUser_REG { get; set; }

    /// <summary> Contact.ContactNumbers.SearchIndex equals </summary>
    [JsonProperty("contact_contactNumbers_searchIndex_eq")]
    public string? Contact_ContactNumbers_SearchIndex_EQ { get; set; }
    /// <summary> Contact.ContactNumbers.SearchIndex contains </summary>
    [JsonProperty("contact_contactNumbers_searchIndex_con")]
    public string? Contact_ContactNumbers_SearchIndex_CON { get; set; }
    /// <summary> Contact.ContactNumbers.SearchIndex regex </summary>
    [JsonProperty("contact_contactNumbers_searchIndex_reg")]
    public string? Contact_ContactNumbers_SearchIndex_REG { get; set; }

    /// <summary> Contact.ContactNumbers.Number equals </summary>
    [JsonProperty("contact_contactNumbers_number_eq")]
    public string? Contact_ContactNumbers_Number_EQ { get; set; }
    /// <summary> Contact.ContactNumbers.Number contains </summary>
    [JsonProperty("contact_contactNumbers_number_con")]
    public string? Contact_ContactNumbers_Number_CON { get; set; }
    /// <summary> Contact.ContactNumbers.Number regex </summary>
    [JsonProperty("contact_contactNumbers_number_reg")]
    public string? Contact_ContactNumbers_Number_REG { get; set; }

    /// <summary> Contact.ContactNumbers.NumberInternationalFormat equals </summary>
    [JsonProperty("contact_contactNumbers_numberInternationalFormat_eq")]
    public string? Contact_ContactNumbers_NumberInternationalFormat_EQ { get; set; }
    /// <summary> Contact.ContactNumbers.NumberInternationalFormat contains </summary>
    [JsonProperty("contact_contactNumbers_numberInternationalFormat_con")]
    public string? Contact_ContactNumbers_NumberInternationalFormat_CON { get; set; }
    /// <summary> Contact.ContactNumbers.NumberInternationalFormat regex </summary>
    [JsonProperty("contact_contactNumbers_numberInternationalFormat_reg")]
    public string? Contact_ContactNumbers_NumberInternationalFormat_REG { get; set; }

    /// <summary> Contact.ContactNumbers.Label equals </summary>
    [JsonProperty("contact_contactNumbers_label_eq")]
    public LabelNumber? Contact_ContactNumbers_Label_EQ { get; set; }


    /// <summary> Contact.ContactEmails.SearchIndex equals </summary>
    [JsonProperty("contact_contactEmails_searchIndex_eq")]
    public string? Contact_ContactEmails_SearchIndex_EQ { get; set; }
    /// <summary> Contact.ContactEmails.SearchIndex contains </summary>
    [JsonProperty("contact_contactEmails_searchIndex_con")]
    public string? Contact_ContactEmails_SearchIndex_CON { get; set; }
    /// <summary> Contact.ContactEmails.SearchIndex regex </summary>
    [JsonProperty("contact_contactEmails_searchIndex_reg")]
    public string? Contact_ContactEmails_SearchIndex_REG { get; set; }

    /// <summary> Contact.ContactEmails.Email equals </summary>
    [JsonProperty("contact_contactEmails_email_eq")]
    public string? Contact_ContactEmails_Email_EQ { get; set; }
    /// <summary> Contact.ContactEmails.Email contains </summary>
    [JsonProperty("contact_contactEmails_email_con")]
    public string? Contact_ContactEmails_Email_CON { get; set; }
    /// <summary> Contact.ContactEmails.Email regex </summary>
    [JsonProperty("contact_contactEmails_email_reg")]
    public string? Contact_ContactEmails_Email_REG { get; set; }

    /// <summary> Contact.ContactEmails.Label equals </summary>
    [JsonProperty("contact_contactEmails_label_eq")]
    public LabelEmailType? Contact_ContactEmails_Label_EQ { get; set; }


    /// <summary> Contact.FirstName equals </summary>
    [JsonProperty("contact_firstName_eq")]
    public string? Contact_FirstName_EQ { get; set; }
    /// <summary> Contact.FirstName contains </summary>
    [JsonProperty("contact_firstName_con")]
    public string? Contact_FirstName_CON { get; set; }
    /// <summary> Contact.FirstName regex </summary>
    [JsonProperty("contact_firstName_reg")]
    public string? Contact_FirstName_REG { get; set; }

    /// <summary> Contact.LastName equals </summary>
    [JsonProperty("contact_lastName_eq")]
    public string? Contact_LastName_EQ { get; set; }
    /// <summary> Contact.LastName contains </summary>
    [JsonProperty("contact_lastName_con")]
    public string? Contact_LastName_CON { get; set; }
    /// <summary> Contact.LastName regex </summary>
    [JsonProperty("contact_lastName_reg")]
    public string? Contact_LastName_REG { get; set; }

    /// <summary> Contact.JobTittle equals </summary>
    [JsonProperty("contact_jobTittle_eq")]
    public string? Contact_JobTittle_EQ { get; set; }
    /// <summary> Contact.JobTittle contains </summary>
    [JsonProperty("contact_jobTittle_con")]
    public string? Contact_JobTittle_CON { get; set; }
    /// <summary> Contact.JobTittle regex </summary>
    [JsonProperty("contact_jobTittle_reg")]
    public string? Contact_JobTittle_REG { get; set; }

    /// <summary> Contact.Company equals </summary>
    [JsonProperty("contact_company_eq")]
    public string? Contact_Company_EQ { get; set; }
    /// <summary> Contact.Company contains </summary>
    [JsonProperty("contact_company_con")]
    public string? Contact_Company_CON { get; set; }
    /// <summary> Contact.Company regex </summary>
    [JsonProperty("contact_company_reg")]
    public string? Contact_Company_REG { get; set; }

    /// <summary> Contact.Hash equals </summary>
    [JsonProperty("contact_hash_eq")]
    public string? Contact_Hash_EQ { get; set; }
    /// <summary> Contact.Hash contains </summary>
    [JsonProperty("contact_hash_con")]
    public string? Contact_Hash_CON { get; set; }
    /// <summary> Contact.Hash regex </summary>
    [JsonProperty("contact_hash_reg")]
    public string? Contact_Hash_REG { get; set; }

    /// <summary> Contact.Notes equals </summary>
    [JsonProperty("contact_notes_eq")]
    public string? Contact_Notes_EQ { get; set; }
    /// <summary> Contact.Notes contains </summary>
    [JsonProperty("contact_notes_con")]
    public string? Contact_Notes_CON { get; set; }
    /// <summary> Contact.Notes regex </summary>
    [JsonProperty("contact_notes_reg")]
    public string? Contact_Notes_REG { get; set; }

    /// <summary> Contact.Variables.Name equals </summary>
    [JsonProperty("contact_variables_name_eq")]
    public string? Contact_Variables_Name_EQ { get; set; }
    /// <summary> Contact.Variables.Name contains </summary>
    [JsonProperty("contact_variables_name_con")]
    public string? Contact_Variables_Name_CON { get; set; }
    /// <summary> Contact.Variables.Name regex </summary>
    [JsonProperty("contact_variables_name_reg")]
    public string? Contact_Variables_Name_REG { get; set; }

    /// <summary> Contact.Variables.JsonValue equals </summary>
    [JsonProperty("contact_variables_jsonValue_eq")]
    public string? Contact_Variables_JsonValue_EQ { get; set; }
    /// <summary> Contact.Variables.JsonValue contains </summary>
    [JsonProperty("contact_variables_jsonValue_con")]
    public string? Contact_Variables_JsonValue_CON { get; set; }
    /// <summary> Contact.Variables.JsonValue regex </summary>
    [JsonProperty("contact_variables_jsonValue_reg")]
    public string? Contact_Variables_JsonValue_REG { get; set; }


    /// <summary> Contact.Id equals </summary>
    [JsonProperty("contact_id_eq")]
    public string? Contact_Id_EQ { get; set; }
    /// <summary> Contact.Id contains </summary>
    [JsonProperty("contact_id_con")]
    public string? Contact_Id_CON { get; set; }
    /// <summary> Contact.Id regex </summary>
    [JsonProperty("contact_id_reg")]
    public string? Contact_Id_REG { get; set; }

    /// <summary> Contact.DateCreated equals </summary>
    [JsonProperty("contact_dateCreated_eq")]
    public DateTime? Contact_DateCreated_EQ { get; set; }
    /// <summary> Contact.DateCreated less than or equal to </summary>
    [JsonProperty("contact_dateCreated_lte")]
    public DateTime? Contact_DateCreated_LTE { get; set; }
    /// <summary> Contact.DateCreated greater than or equal to </summary>
    [JsonProperty("contact_dateCreated_gte")]
    public DateTime? Contact_DateCreated_GTE { get; set; }

    /// <summary> Contact.DateUpdated equals </summary>
    [JsonProperty("contact_dateUpdated_eq")]
    public DateTime? Contact_DateUpdated_EQ { get; set; }
    /// <summary> Contact.DateUpdated less than or equal to </summary>
    [JsonProperty("contact_dateUpdated_lte")]
    public DateTime? Contact_DateUpdated_LTE { get; set; }
    /// <summary> Contact.DateUpdated greater than or equal to </summary>
    [JsonProperty("contact_dateUpdated_gte")]
    public DateTime? Contact_DateUpdated_GTE { get; set; }


    /// <summary> DialStatus equals </summary>
    [JsonProperty("dialStatus_eq")]
    public string? DialStatus_EQ { get; set; }
    /// <summary> DialStatus contains </summary>
    [JsonProperty("dialStatus_con")]
    public string? DialStatus_CON { get; set; }
    /// <summary> DialStatus regex </summary>
    [JsonProperty("dialStatus_reg")]
    public string? DialStatus_REG { get; set; }

    /// <summary> SecondsItTookToAnswer equals </summary>
    [JsonProperty("secondsItTookToAnswer_eq")]
    public System.Int32? SecondsItTookToAnswer_EQ { get; set; }
    /// <summary> SecondsItTookToAnswer less than or equal to </summary>
    [JsonProperty("secondsItTookToAnswer_lte")]
    public System.Int32? SecondsItTookToAnswer_LTE { get; set; }
    /// <summary> SecondsItTookToAnswer greater than or equal to </summary>
    [JsonProperty("secondsItTookToAnswer_gte")]
    public System.Int32? SecondsItTookToAnswer_GTE { get; set; }

    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenPlacedOnHold equals </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenPlacedOnHold_eq")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenPlacedOnHold_EQ { get; set; }
    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenPlacedOnHold less than or equal to </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenPlacedOnHold_lte")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenPlacedOnHold_LTE { get; set; }
    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenPlacedOnHold greater than or equal to </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenPlacedOnHold_gte")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenPlacedOnHold_GTE { get; set; }

    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenRemovedFromHold equals </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenRemovedFromHold_eq")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenRemovedFromHold_EQ { get; set; }
    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenRemovedFromHold less than or equal to </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenRemovedFromHold_lte")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenRemovedFromHold_LTE { get; set; }
    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenRemovedFromHold greater than or equal to </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenRemovedFromHold_gte")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenRemovedFromHold_GTE { get; set; }


    /// <summary> From equals </summary>
    [JsonProperty("from_eq")]
    public string? From_EQ { get; set; }
    /// <summary> From contains </summary>
    [JsonProperty("from_con")]
    public string? From_CON { get; set; }
    /// <summary> From regex </summary>
    [JsonProperty("from_reg")]
    public string? From_REG { get; set; }

    /// <summary> FromCountry equals </summary>
    [JsonProperty("fromCountry_eq")]
    public CountryIsoCode? FromCountry_EQ { get; set; }

    /// <summary> To equals </summary>
    [JsonProperty("to_eq")]
    public string? To_EQ { get; set; }
    /// <summary> To contains </summary>
    [JsonProperty("to_con")]
    public string? To_CON { get; set; }
    /// <summary> To regex </summary>
    [JsonProperty("to_reg")]
    public string? To_REG { get; set; }

    /// <summary> ToCountry equals </summary>
    [JsonProperty("toCountry_eq")]
    public CountryIsoCode? ToCountry_EQ { get; set; }

    /// <summary> CallType equals </summary>
    [JsonProperty("callType_eq")]
    public CallType? CallType_EQ { get; set; }

    /// <summary> Recording.ErrorMessage equals </summary>
    [JsonProperty("recording_errorMessage_eq")]
    public string? Recording_ErrorMessage_EQ { get; set; }
    /// <summary> Recording.ErrorMessage contains </summary>
    [JsonProperty("recording_errorMessage_con")]
    public string? Recording_ErrorMessage_CON { get; set; }
    /// <summary> Recording.ErrorMessage regex </summary>
    [JsonProperty("recording_errorMessage_reg")]
    public string? Recording_ErrorMessage_REG { get; set; }

    /// <summary> Recording.RecordingMp3.InstanceId equals </summary>
    [JsonProperty("recording_recordingMp3_instanceId_eq")]
    public string? Recording_RecordingMp3_InstanceId_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.InstanceId contains </summary>
    [JsonProperty("recording_recordingMp3_instanceId_con")]
    public string? Recording_RecordingMp3_InstanceId_CON { get; set; }
    /// <summary> Recording.RecordingMp3.InstanceId regex </summary>
    [JsonProperty("recording_recordingMp3_instanceId_reg")]
    public string? Recording_RecordingMp3_InstanceId_REG { get; set; }

    /// <summary> Recording.RecordingMp3.FileSizeInBytes equals </summary>
    [JsonProperty("recording_recordingMp3_fileSizeInBytes_eq")]
    public System.Int32? Recording_RecordingMp3_FileSizeInBytes_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.FileSizeInBytes less than or equal to </summary>
    [JsonProperty("recording_recordingMp3_fileSizeInBytes_lte")]
    public System.Int32? Recording_RecordingMp3_FileSizeInBytes_LTE { get; set; }
    /// <summary> Recording.RecordingMp3.FileSizeInBytes greater than or equal to </summary>
    [JsonProperty("recording_recordingMp3_fileSizeInBytes_gte")]
    public System.Int32? Recording_RecordingMp3_FileSizeInBytes_GTE { get; set; }

    /// <summary> Recording.RecordingMp3.Md5Hash equals </summary>
    [JsonProperty("recording_recordingMp3_md5Hash_eq")]
    public string? Recording_RecordingMp3_Md5Hash_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.Md5Hash contains </summary>
    [JsonProperty("recording_recordingMp3_md5Hash_con")]
    public string? Recording_RecordingMp3_Md5Hash_CON { get; set; }
    /// <summary> Recording.RecordingMp3.Md5Hash regex </summary>
    [JsonProperty("recording_recordingMp3_md5Hash_reg")]
    public string? Recording_RecordingMp3_Md5Hash_REG { get; set; }

    /// <summary> Recording.RecordingMp3.Url equals </summary>
    [JsonProperty("recording_recordingMp3_url_eq")]
    public string? Recording_RecordingMp3_Url_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.Url contains </summary>
    [JsonProperty("recording_recordingMp3_url_con")]
    public string? Recording_RecordingMp3_Url_CON { get; set; }
    /// <summary> Recording.RecordingMp3.Url regex </summary>
    [JsonProperty("recording_recordingMp3_url_reg")]
    public string? Recording_RecordingMp3_Url_REG { get; set; }

    /// <summary> Recording.RecordingMp3.Id equals </summary>
    [JsonProperty("recording_recordingMp3_id_eq")]
    public string? Recording_RecordingMp3_Id_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.Id contains </summary>
    [JsonProperty("recording_recordingMp3_id_con")]
    public string? Recording_RecordingMp3_Id_CON { get; set; }
    /// <summary> Recording.RecordingMp3.Id regex </summary>
    [JsonProperty("recording_recordingMp3_id_reg")]
    public string? Recording_RecordingMp3_Id_REG { get; set; }


    /// <summary> Recording.RecordingDurationInSeconds equals </summary>
    [JsonProperty("recording_recordingDurationInSeconds_eq")]
    public System.Int32? Recording_RecordingDurationInSeconds_EQ { get; set; }
    /// <summary> Recording.RecordingDurationInSeconds less than or equal to </summary>
    [JsonProperty("recording_recordingDurationInSeconds_lte")]
    public System.Int32? Recording_RecordingDurationInSeconds_LTE { get; set; }
    /// <summary> Recording.RecordingDurationInSeconds greater than or equal to </summary>
    [JsonProperty("recording_recordingDurationInSeconds_gte")]
    public System.Int32? Recording_RecordingDurationInSeconds_GTE { get; set; }

    /// <summary> Recording.Id equals </summary>
    [JsonProperty("recording_id_eq")]
    public string? Recording_Id_EQ { get; set; }
    /// <summary> Recording.Id contains </summary>
    [JsonProperty("recording_id_con")]
    public string? Recording_Id_CON { get; set; }
    /// <summary> Recording.Id regex </summary>
    [JsonProperty("recording_id_reg")]
    public string? Recording_Id_REG { get; set; }


    /// <summary> DisabledVideo equals </summary>
    [JsonProperty("disabledVideo_eq")]
    public bool? DisabledVideo_EQ { get; set; }

    /// <summary> DigitsSent equals </summary>
    [JsonProperty("digitsSent_eq")]
    public string? DigitsSent_EQ { get; set; }
    /// <summary> DigitsSent contains </summary>
    [JsonProperty("digitsSent_con")]
    public string? DigitsSent_CON { get; set; }
    /// <summary> DigitsSent regex </summary>
    [JsonProperty("digitsSent_reg")]
    public string? DigitsSent_REG { get; set; }

    /// <summary> IsInternational equals </summary>
    [JsonProperty("isInternational_eq")]
    public bool? IsInternational_EQ { get; set; }

    /// <summary> DateEnded equals </summary>
    [JsonProperty("dateEnded_eq")]
    public DateTime? DateEnded_EQ { get; set; }
    /// <summary> DateEnded less than or equal to </summary>
    [JsonProperty("dateEnded_lte")]
    public DateTime? DateEnded_LTE { get; set; }
    /// <summary> DateEnded greater than or equal to </summary>
    [JsonProperty("dateEnded_gte")]
    public DateTime? DateEnded_GTE { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for CallIncomings </summary>
public class CallIncomingFilterRequest 
{
    /// <summary> Contact.IdIdentityUser equals </summary>
    [JsonProperty("contact_idIdentityUser_eq")]
    public string? Contact_IdIdentityUser_EQ { get; set; }
    /// <summary> Contact.IdIdentityUser contains </summary>
    [JsonProperty("contact_idIdentityUser_con")]
    public string? Contact_IdIdentityUser_CON { get; set; }
    /// <summary> Contact.IdIdentityUser regex </summary>
    [JsonProperty("contact_idIdentityUser_reg")]
    public string? Contact_IdIdentityUser_REG { get; set; }

    /// <summary> Contact.ContactNumbers.SearchIndex equals </summary>
    [JsonProperty("contact_contactNumbers_searchIndex_eq")]
    public string? Contact_ContactNumbers_SearchIndex_EQ { get; set; }
    /// <summary> Contact.ContactNumbers.SearchIndex contains </summary>
    [JsonProperty("contact_contactNumbers_searchIndex_con")]
    public string? Contact_ContactNumbers_SearchIndex_CON { get; set; }
    /// <summary> Contact.ContactNumbers.SearchIndex regex </summary>
    [JsonProperty("contact_contactNumbers_searchIndex_reg")]
    public string? Contact_ContactNumbers_SearchIndex_REG { get; set; }

    /// <summary> Contact.ContactNumbers.Number equals </summary>
    [JsonProperty("contact_contactNumbers_number_eq")]
    public string? Contact_ContactNumbers_Number_EQ { get; set; }
    /// <summary> Contact.ContactNumbers.Number contains </summary>
    [JsonProperty("contact_contactNumbers_number_con")]
    public string? Contact_ContactNumbers_Number_CON { get; set; }
    /// <summary> Contact.ContactNumbers.Number regex </summary>
    [JsonProperty("contact_contactNumbers_number_reg")]
    public string? Contact_ContactNumbers_Number_REG { get; set; }

    /// <summary> Contact.ContactNumbers.NumberInternationalFormat equals </summary>
    [JsonProperty("contact_contactNumbers_numberInternationalFormat_eq")]
    public string? Contact_ContactNumbers_NumberInternationalFormat_EQ { get; set; }
    /// <summary> Contact.ContactNumbers.NumberInternationalFormat contains </summary>
    [JsonProperty("contact_contactNumbers_numberInternationalFormat_con")]
    public string? Contact_ContactNumbers_NumberInternationalFormat_CON { get; set; }
    /// <summary> Contact.ContactNumbers.NumberInternationalFormat regex </summary>
    [JsonProperty("contact_contactNumbers_numberInternationalFormat_reg")]
    public string? Contact_ContactNumbers_NumberInternationalFormat_REG { get; set; }

    /// <summary> Contact.ContactNumbers.Label equals </summary>
    [JsonProperty("contact_contactNumbers_label_eq")]
    public LabelNumber? Contact_ContactNumbers_Label_EQ { get; set; }


    /// <summary> Contact.ContactEmails.SearchIndex equals </summary>
    [JsonProperty("contact_contactEmails_searchIndex_eq")]
    public string? Contact_ContactEmails_SearchIndex_EQ { get; set; }
    /// <summary> Contact.ContactEmails.SearchIndex contains </summary>
    [JsonProperty("contact_contactEmails_searchIndex_con")]
    public string? Contact_ContactEmails_SearchIndex_CON { get; set; }
    /// <summary> Contact.ContactEmails.SearchIndex regex </summary>
    [JsonProperty("contact_contactEmails_searchIndex_reg")]
    public string? Contact_ContactEmails_SearchIndex_REG { get; set; }

    /// <summary> Contact.ContactEmails.Email equals </summary>
    [JsonProperty("contact_contactEmails_email_eq")]
    public string? Contact_ContactEmails_Email_EQ { get; set; }
    /// <summary> Contact.ContactEmails.Email contains </summary>
    [JsonProperty("contact_contactEmails_email_con")]
    public string? Contact_ContactEmails_Email_CON { get; set; }
    /// <summary> Contact.ContactEmails.Email regex </summary>
    [JsonProperty("contact_contactEmails_email_reg")]
    public string? Contact_ContactEmails_Email_REG { get; set; }

    /// <summary> Contact.ContactEmails.Label equals </summary>
    [JsonProperty("contact_contactEmails_label_eq")]
    public LabelEmailType? Contact_ContactEmails_Label_EQ { get; set; }


    /// <summary> Contact.FirstName equals </summary>
    [JsonProperty("contact_firstName_eq")]
    public string? Contact_FirstName_EQ { get; set; }
    /// <summary> Contact.FirstName contains </summary>
    [JsonProperty("contact_firstName_con")]
    public string? Contact_FirstName_CON { get; set; }
    /// <summary> Contact.FirstName regex </summary>
    [JsonProperty("contact_firstName_reg")]
    public string? Contact_FirstName_REG { get; set; }

    /// <summary> Contact.LastName equals </summary>
    [JsonProperty("contact_lastName_eq")]
    public string? Contact_LastName_EQ { get; set; }
    /// <summary> Contact.LastName contains </summary>
    [JsonProperty("contact_lastName_con")]
    public string? Contact_LastName_CON { get; set; }
    /// <summary> Contact.LastName regex </summary>
    [JsonProperty("contact_lastName_reg")]
    public string? Contact_LastName_REG { get; set; }

    /// <summary> Contact.JobTittle equals </summary>
    [JsonProperty("contact_jobTittle_eq")]
    public string? Contact_JobTittle_EQ { get; set; }
    /// <summary> Contact.JobTittle contains </summary>
    [JsonProperty("contact_jobTittle_con")]
    public string? Contact_JobTittle_CON { get; set; }
    /// <summary> Contact.JobTittle regex </summary>
    [JsonProperty("contact_jobTittle_reg")]
    public string? Contact_JobTittle_REG { get; set; }

    /// <summary> Contact.Company equals </summary>
    [JsonProperty("contact_company_eq")]
    public string? Contact_Company_EQ { get; set; }
    /// <summary> Contact.Company contains </summary>
    [JsonProperty("contact_company_con")]
    public string? Contact_Company_CON { get; set; }
    /// <summary> Contact.Company regex </summary>
    [JsonProperty("contact_company_reg")]
    public string? Contact_Company_REG { get; set; }

    /// <summary> Contact.Hash equals </summary>
    [JsonProperty("contact_hash_eq")]
    public string? Contact_Hash_EQ { get; set; }
    /// <summary> Contact.Hash contains </summary>
    [JsonProperty("contact_hash_con")]
    public string? Contact_Hash_CON { get; set; }
    /// <summary> Contact.Hash regex </summary>
    [JsonProperty("contact_hash_reg")]
    public string? Contact_Hash_REG { get; set; }

    /// <summary> Contact.Notes equals </summary>
    [JsonProperty("contact_notes_eq")]
    public string? Contact_Notes_EQ { get; set; }
    /// <summary> Contact.Notes contains </summary>
    [JsonProperty("contact_notes_con")]
    public string? Contact_Notes_CON { get; set; }
    /// <summary> Contact.Notes regex </summary>
    [JsonProperty("contact_notes_reg")]
    public string? Contact_Notes_REG { get; set; }

    /// <summary> Contact.Variables.Name equals </summary>
    [JsonProperty("contact_variables_name_eq")]
    public string? Contact_Variables_Name_EQ { get; set; }
    /// <summary> Contact.Variables.Name contains </summary>
    [JsonProperty("contact_variables_name_con")]
    public string? Contact_Variables_Name_CON { get; set; }
    /// <summary> Contact.Variables.Name regex </summary>
    [JsonProperty("contact_variables_name_reg")]
    public string? Contact_Variables_Name_REG { get; set; }

    /// <summary> Contact.Variables.JsonValue equals </summary>
    [JsonProperty("contact_variables_jsonValue_eq")]
    public string? Contact_Variables_JsonValue_EQ { get; set; }
    /// <summary> Contact.Variables.JsonValue contains </summary>
    [JsonProperty("contact_variables_jsonValue_con")]
    public string? Contact_Variables_JsonValue_CON { get; set; }
    /// <summary> Contact.Variables.JsonValue regex </summary>
    [JsonProperty("contact_variables_jsonValue_reg")]
    public string? Contact_Variables_JsonValue_REG { get; set; }


    /// <summary> Contact.Id equals </summary>
    [JsonProperty("contact_id_eq")]
    public string? Contact_Id_EQ { get; set; }
    /// <summary> Contact.Id contains </summary>
    [JsonProperty("contact_id_con")]
    public string? Contact_Id_CON { get; set; }
    /// <summary> Contact.Id regex </summary>
    [JsonProperty("contact_id_reg")]
    public string? Contact_Id_REG { get; set; }

    /// <summary> Contact.DateCreated equals </summary>
    [JsonProperty("contact_dateCreated_eq")]
    public DateTime? Contact_DateCreated_EQ { get; set; }
    /// <summary> Contact.DateCreated less than or equal to </summary>
    [JsonProperty("contact_dateCreated_lte")]
    public DateTime? Contact_DateCreated_LTE { get; set; }
    /// <summary> Contact.DateCreated greater than or equal to </summary>
    [JsonProperty("contact_dateCreated_gte")]
    public DateTime? Contact_DateCreated_GTE { get; set; }

    /// <summary> Contact.DateUpdated equals </summary>
    [JsonProperty("contact_dateUpdated_eq")]
    public DateTime? Contact_DateUpdated_EQ { get; set; }
    /// <summary> Contact.DateUpdated less than or equal to </summary>
    [JsonProperty("contact_dateUpdated_lte")]
    public DateTime? Contact_DateUpdated_LTE { get; set; }
    /// <summary> Contact.DateUpdated greater than or equal to </summary>
    [JsonProperty("contact_dateUpdated_gte")]
    public DateTime? Contact_DateUpdated_GTE { get; set; }


    /// <summary> IdVoipNumberPhone equals </summary>
    [JsonProperty("idVoipNumberPhone_eq")]
    public string? IdVoipNumberPhone_EQ { get; set; }
    /// <summary> IdVoipNumberPhone contains </summary>
    [JsonProperty("idVoipNumberPhone_con")]
    public string? IdVoipNumberPhone_CON { get; set; }
    /// <summary> IdVoipNumberPhone regex </summary>
    [JsonProperty("idVoipNumberPhone_reg")]
    public string? IdVoipNumberPhone_REG { get; set; }

    /// <summary> FromInternationalFormat equals </summary>
    [JsonProperty("fromInternationalFormat_eq")]
    public string? FromInternationalFormat_EQ { get; set; }
    /// <summary> FromInternationalFormat contains </summary>
    [JsonProperty("fromInternationalFormat_con")]
    public string? FromInternationalFormat_CON { get; set; }
    /// <summary> FromInternationalFormat regex </summary>
    [JsonProperty("fromInternationalFormat_reg")]
    public string? FromInternationalFormat_REG { get; set; }

    /// <summary> IdVoicemail equals </summary>
    [JsonProperty("idVoicemail_eq")]
    public string? IdVoicemail_EQ { get; set; }
    /// <summary> IdVoicemail contains </summary>
    [JsonProperty("idVoicemail_con")]
    public string? IdVoicemail_CON { get; set; }
    /// <summary> IdVoicemail regex </summary>
    [JsonProperty("idVoicemail_reg")]
    public string? IdVoicemail_REG { get; set; }

    /// <summary> IdCallThatTerminatedThisCallDoToAttendantTransfer equals </summary>
    [JsonProperty("idCallThatTerminatedThisCallDoToAttendantTransfer_eq")]
    public string? IdCallThatTerminatedThisCallDoToAttendantTransfer_EQ { get; set; }
    /// <summary> IdCallThatTerminatedThisCallDoToAttendantTransfer contains </summary>
    [JsonProperty("idCallThatTerminatedThisCallDoToAttendantTransfer_con")]
    public string? IdCallThatTerminatedThisCallDoToAttendantTransfer_CON { get; set; }
    /// <summary> IdCallThatTerminatedThisCallDoToAttendantTransfer regex </summary>
    [JsonProperty("idCallThatTerminatedThisCallDoToAttendantTransfer_reg")]
    public string? IdCallThatTerminatedThisCallDoToAttendantTransfer_REG { get; set; }

    /// <summary> ChannelVariables.Language equals </summary>
    [JsonProperty("channelVariables_language_eq")]
    public Language? ChannelVariables_Language_EQ { get; set; }

    /// <summary> ChannelVariables.IdMusicOnHold equals </summary>
    [JsonProperty("channelVariables_idMusicOnHold_eq")]
    public string? ChannelVariables_IdMusicOnHold_EQ { get; set; }
    /// <summary> ChannelVariables.IdMusicOnHold contains </summary>
    [JsonProperty("channelVariables_idMusicOnHold_con")]
    public string? ChannelVariables_IdMusicOnHold_CON { get; set; }
    /// <summary> ChannelVariables.IdMusicOnHold regex </summary>
    [JsonProperty("channelVariables_idMusicOnHold_reg")]
    public string? ChannelVariables_IdMusicOnHold_REG { get; set; }

    /// <summary> ChannelVariables.CallerIdName equals </summary>
    [JsonProperty("channelVariables_callerIdName_eq")]
    public string? ChannelVariables_CallerIdName_EQ { get; set; }
    /// <summary> ChannelVariables.CallerIdName contains </summary>
    [JsonProperty("channelVariables_callerIdName_con")]
    public string? ChannelVariables_CallerIdName_CON { get; set; }
    /// <summary> ChannelVariables.CallerIdName regex </summary>
    [JsonProperty("channelVariables_callerIdName_reg")]
    public string? ChannelVariables_CallerIdName_REG { get; set; }

    /// <summary> ChannelVariables.CallerIdNumber equals </summary>
    [JsonProperty("channelVariables_callerIdNumber_eq")]
    public string? ChannelVariables_CallerIdNumber_EQ { get; set; }
    /// <summary> ChannelVariables.CallerIdNumber contains </summary>
    [JsonProperty("channelVariables_callerIdNumber_con")]
    public string? ChannelVariables_CallerIdNumber_CON { get; set; }
    /// <summary> ChannelVariables.CallerIdNumber regex </summary>
    [JsonProperty("channelVariables_callerIdNumber_reg")]
    public string? ChannelVariables_CallerIdNumber_REG { get; set; }


    /// <summary> ChildCalls.ChildCallType equals </summary>
    [JsonProperty("childCalls_childCallType_eq")]
    public ChildCallType? ChildCalls_ChildCallType_EQ { get; set; }

    /// <summary> ChildCalls.DialStatus equals </summary>
    [JsonProperty("childCalls_dialStatus_eq")]
    public string? ChildCalls_DialStatus_EQ { get; set; }
    /// <summary> ChildCalls.DialStatus contains </summary>
    [JsonProperty("childCalls_dialStatus_con")]
    public string? ChildCalls_DialStatus_CON { get; set; }
    /// <summary> ChildCalls.DialStatus regex </summary>
    [JsonProperty("childCalls_dialStatus_reg")]
    public string? ChildCalls_DialStatus_REG { get; set; }

    /// <summary> ChildCalls.DateCreated equals </summary>
    [JsonProperty("childCalls_dateCreated_eq")]
    public DateTime? ChildCalls_DateCreated_EQ { get; set; }
    /// <summary> ChildCalls.DateCreated less than or equal to </summary>
    [JsonProperty("childCalls_dateCreated_lte")]
    public DateTime? ChildCalls_DateCreated_LTE { get; set; }
    /// <summary> ChildCalls.DateCreated greater than or equal to </summary>
    [JsonProperty("childCalls_dateCreated_gte")]
    public DateTime? ChildCalls_DateCreated_GTE { get; set; }

    /// <summary> ChildCalls.DateEnded equals </summary>
    [JsonProperty("childCalls_dateEnded_eq")]
    public DateTime? ChildCalls_DateEnded_EQ { get; set; }
    /// <summary> ChildCalls.DateEnded less than or equal to </summary>
    [JsonProperty("childCalls_dateEnded_lte")]
    public DateTime? ChildCalls_DateEnded_LTE { get; set; }
    /// <summary> ChildCalls.DateEnded greater than or equal to </summary>
    [JsonProperty("childCalls_dateEnded_gte")]
    public DateTime? ChildCalls_DateEnded_GTE { get; set; }

    /// <summary> ChildCalls.SecondsItTookToAnswer equals </summary>
    [JsonProperty("childCalls_secondsItTookToAnswer_eq")]
    public System.Int32? ChildCalls_SecondsItTookToAnswer_EQ { get; set; }
    /// <summary> ChildCalls.SecondsItTookToAnswer less than or equal to </summary>
    [JsonProperty("childCalls_secondsItTookToAnswer_lte")]
    public System.Int32? ChildCalls_SecondsItTookToAnswer_LTE { get; set; }
    /// <summary> ChildCalls.SecondsItTookToAnswer greater than or equal to </summary>
    [JsonProperty("childCalls_secondsItTookToAnswer_gte")]
    public System.Int32? ChildCalls_SecondsItTookToAnswer_GTE { get; set; }


    /// <summary> DialStatus equals </summary>
    [JsonProperty("dialStatus_eq")]
    public string? DialStatus_EQ { get; set; }
    /// <summary> DialStatus contains </summary>
    [JsonProperty("dialStatus_con")]
    public string? DialStatus_CON { get; set; }
    /// <summary> DialStatus regex </summary>
    [JsonProperty("dialStatus_reg")]
    public string? DialStatus_REG { get; set; }

    /// <summary> SecondsItTookToAnswer equals </summary>
    [JsonProperty("secondsItTookToAnswer_eq")]
    public System.Int32? SecondsItTookToAnswer_EQ { get; set; }
    /// <summary> SecondsItTookToAnswer less than or equal to </summary>
    [JsonProperty("secondsItTookToAnswer_lte")]
    public System.Int32? SecondsItTookToAnswer_LTE { get; set; }
    /// <summary> SecondsItTookToAnswer greater than or equal to </summary>
    [JsonProperty("secondsItTookToAnswer_gte")]
    public System.Int32? SecondsItTookToAnswer_GTE { get; set; }

    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenPlacedOnHold equals </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenPlacedOnHold_eq")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenPlacedOnHold_EQ { get; set; }
    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenPlacedOnHold less than or equal to </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenPlacedOnHold_lte")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenPlacedOnHold_LTE { get; set; }
    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenPlacedOnHold greater than or equal to </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenPlacedOnHold_gte")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenPlacedOnHold_GTE { get; set; }

    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenRemovedFromHold equals </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenRemovedFromHold_eq")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenRemovedFromHold_EQ { get; set; }
    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenRemovedFromHold less than or equal to </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenRemovedFromHold_lte")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenRemovedFromHold_LTE { get; set; }
    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenRemovedFromHold greater than or equal to </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenRemovedFromHold_gte")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenRemovedFromHold_GTE { get; set; }


    /// <summary> From equals </summary>
    [JsonProperty("from_eq")]
    public string? From_EQ { get; set; }
    /// <summary> From contains </summary>
    [JsonProperty("from_con")]
    public string? From_CON { get; set; }
    /// <summary> From regex </summary>
    [JsonProperty("from_reg")]
    public string? From_REG { get; set; }

    /// <summary> FromCountry equals </summary>
    [JsonProperty("fromCountry_eq")]
    public CountryIsoCode? FromCountry_EQ { get; set; }

    /// <summary> To equals </summary>
    [JsonProperty("to_eq")]
    public string? To_EQ { get; set; }
    /// <summary> To contains </summary>
    [JsonProperty("to_con")]
    public string? To_CON { get; set; }
    /// <summary> To regex </summary>
    [JsonProperty("to_reg")]
    public string? To_REG { get; set; }

    /// <summary> ToCountry equals </summary>
    [JsonProperty("toCountry_eq")]
    public CountryIsoCode? ToCountry_EQ { get; set; }

    /// <summary> CallType equals </summary>
    [JsonProperty("callType_eq")]
    public CallType? CallType_EQ { get; set; }

    /// <summary> Recording.ErrorMessage equals </summary>
    [JsonProperty("recording_errorMessage_eq")]
    public string? Recording_ErrorMessage_EQ { get; set; }
    /// <summary> Recording.ErrorMessage contains </summary>
    [JsonProperty("recording_errorMessage_con")]
    public string? Recording_ErrorMessage_CON { get; set; }
    /// <summary> Recording.ErrorMessage regex </summary>
    [JsonProperty("recording_errorMessage_reg")]
    public string? Recording_ErrorMessage_REG { get; set; }

    /// <summary> Recording.RecordingMp3.InstanceId equals </summary>
    [JsonProperty("recording_recordingMp3_instanceId_eq")]
    public string? Recording_RecordingMp3_InstanceId_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.InstanceId contains </summary>
    [JsonProperty("recording_recordingMp3_instanceId_con")]
    public string? Recording_RecordingMp3_InstanceId_CON { get; set; }
    /// <summary> Recording.RecordingMp3.InstanceId regex </summary>
    [JsonProperty("recording_recordingMp3_instanceId_reg")]
    public string? Recording_RecordingMp3_InstanceId_REG { get; set; }

    /// <summary> Recording.RecordingMp3.FileSizeInBytes equals </summary>
    [JsonProperty("recording_recordingMp3_fileSizeInBytes_eq")]
    public System.Int32? Recording_RecordingMp3_FileSizeInBytes_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.FileSizeInBytes less than or equal to </summary>
    [JsonProperty("recording_recordingMp3_fileSizeInBytes_lte")]
    public System.Int32? Recording_RecordingMp3_FileSizeInBytes_LTE { get; set; }
    /// <summary> Recording.RecordingMp3.FileSizeInBytes greater than or equal to </summary>
    [JsonProperty("recording_recordingMp3_fileSizeInBytes_gte")]
    public System.Int32? Recording_RecordingMp3_FileSizeInBytes_GTE { get; set; }

    /// <summary> Recording.RecordingMp3.Md5Hash equals </summary>
    [JsonProperty("recording_recordingMp3_md5Hash_eq")]
    public string? Recording_RecordingMp3_Md5Hash_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.Md5Hash contains </summary>
    [JsonProperty("recording_recordingMp3_md5Hash_con")]
    public string? Recording_RecordingMp3_Md5Hash_CON { get; set; }
    /// <summary> Recording.RecordingMp3.Md5Hash regex </summary>
    [JsonProperty("recording_recordingMp3_md5Hash_reg")]
    public string? Recording_RecordingMp3_Md5Hash_REG { get; set; }

    /// <summary> Recording.RecordingMp3.Url equals </summary>
    [JsonProperty("recording_recordingMp3_url_eq")]
    public string? Recording_RecordingMp3_Url_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.Url contains </summary>
    [JsonProperty("recording_recordingMp3_url_con")]
    public string? Recording_RecordingMp3_Url_CON { get; set; }
    /// <summary> Recording.RecordingMp3.Url regex </summary>
    [JsonProperty("recording_recordingMp3_url_reg")]
    public string? Recording_RecordingMp3_Url_REG { get; set; }

    /// <summary> Recording.RecordingMp3.Id equals </summary>
    [JsonProperty("recording_recordingMp3_id_eq")]
    public string? Recording_RecordingMp3_Id_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.Id contains </summary>
    [JsonProperty("recording_recordingMp3_id_con")]
    public string? Recording_RecordingMp3_Id_CON { get; set; }
    /// <summary> Recording.RecordingMp3.Id regex </summary>
    [JsonProperty("recording_recordingMp3_id_reg")]
    public string? Recording_RecordingMp3_Id_REG { get; set; }


    /// <summary> Recording.RecordingDurationInSeconds equals </summary>
    [JsonProperty("recording_recordingDurationInSeconds_eq")]
    public System.Int32? Recording_RecordingDurationInSeconds_EQ { get; set; }
    /// <summary> Recording.RecordingDurationInSeconds less than or equal to </summary>
    [JsonProperty("recording_recordingDurationInSeconds_lte")]
    public System.Int32? Recording_RecordingDurationInSeconds_LTE { get; set; }
    /// <summary> Recording.RecordingDurationInSeconds greater than or equal to </summary>
    [JsonProperty("recording_recordingDurationInSeconds_gte")]
    public System.Int32? Recording_RecordingDurationInSeconds_GTE { get; set; }

    /// <summary> Recording.Id equals </summary>
    [JsonProperty("recording_id_eq")]
    public string? Recording_Id_EQ { get; set; }
    /// <summary> Recording.Id contains </summary>
    [JsonProperty("recording_id_con")]
    public string? Recording_Id_CON { get; set; }
    /// <summary> Recording.Id regex </summary>
    [JsonProperty("recording_id_reg")]
    public string? Recording_Id_REG { get; set; }


    /// <summary> DisabledVideo equals </summary>
    [JsonProperty("disabledVideo_eq")]
    public bool? DisabledVideo_EQ { get; set; }

    /// <summary> DigitsSent equals </summary>
    [JsonProperty("digitsSent_eq")]
    public string? DigitsSent_EQ { get; set; }
    /// <summary> DigitsSent contains </summary>
    [JsonProperty("digitsSent_con")]
    public string? DigitsSent_CON { get; set; }
    /// <summary> DigitsSent regex </summary>
    [JsonProperty("digitsSent_reg")]
    public string? DigitsSent_REG { get; set; }

    /// <summary> IsInternational equals </summary>
    [JsonProperty("isInternational_eq")]
    public bool? IsInternational_EQ { get; set; }

    /// <summary> DateEnded equals </summary>
    [JsonProperty("dateEnded_eq")]
    public DateTime? DateEnded_EQ { get; set; }
    /// <summary> DateEnded less than or equal to </summary>
    [JsonProperty("dateEnded_lte")]
    public DateTime? DateEnded_LTE { get; set; }
    /// <summary> DateEnded greater than or equal to </summary>
    [JsonProperty("dateEnded_gte")]
    public DateTime? DateEnded_GTE { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for CallOutgoings </summary>
public class CallOutgoingFilterRequest 
{
    /// <summary> Contact.IdIdentityUser equals </summary>
    [JsonProperty("contact_idIdentityUser_eq")]
    public string? Contact_IdIdentityUser_EQ { get; set; }
    /// <summary> Contact.IdIdentityUser contains </summary>
    [JsonProperty("contact_idIdentityUser_con")]
    public string? Contact_IdIdentityUser_CON { get; set; }
    /// <summary> Contact.IdIdentityUser regex </summary>
    [JsonProperty("contact_idIdentityUser_reg")]
    public string? Contact_IdIdentityUser_REG { get; set; }

    /// <summary> Contact.ContactNumbers.SearchIndex equals </summary>
    [JsonProperty("contact_contactNumbers_searchIndex_eq")]
    public string? Contact_ContactNumbers_SearchIndex_EQ { get; set; }
    /// <summary> Contact.ContactNumbers.SearchIndex contains </summary>
    [JsonProperty("contact_contactNumbers_searchIndex_con")]
    public string? Contact_ContactNumbers_SearchIndex_CON { get; set; }
    /// <summary> Contact.ContactNumbers.SearchIndex regex </summary>
    [JsonProperty("contact_contactNumbers_searchIndex_reg")]
    public string? Contact_ContactNumbers_SearchIndex_REG { get; set; }

    /// <summary> Contact.ContactNumbers.Number equals </summary>
    [JsonProperty("contact_contactNumbers_number_eq")]
    public string? Contact_ContactNumbers_Number_EQ { get; set; }
    /// <summary> Contact.ContactNumbers.Number contains </summary>
    [JsonProperty("contact_contactNumbers_number_con")]
    public string? Contact_ContactNumbers_Number_CON { get; set; }
    /// <summary> Contact.ContactNumbers.Number regex </summary>
    [JsonProperty("contact_contactNumbers_number_reg")]
    public string? Contact_ContactNumbers_Number_REG { get; set; }

    /// <summary> Contact.ContactNumbers.NumberInternationalFormat equals </summary>
    [JsonProperty("contact_contactNumbers_numberInternationalFormat_eq")]
    public string? Contact_ContactNumbers_NumberInternationalFormat_EQ { get; set; }
    /// <summary> Contact.ContactNumbers.NumberInternationalFormat contains </summary>
    [JsonProperty("contact_contactNumbers_numberInternationalFormat_con")]
    public string? Contact_ContactNumbers_NumberInternationalFormat_CON { get; set; }
    /// <summary> Contact.ContactNumbers.NumberInternationalFormat regex </summary>
    [JsonProperty("contact_contactNumbers_numberInternationalFormat_reg")]
    public string? Contact_ContactNumbers_NumberInternationalFormat_REG { get; set; }

    /// <summary> Contact.ContactNumbers.Label equals </summary>
    [JsonProperty("contact_contactNumbers_label_eq")]
    public LabelNumber? Contact_ContactNumbers_Label_EQ { get; set; }


    /// <summary> Contact.ContactEmails.SearchIndex equals </summary>
    [JsonProperty("contact_contactEmails_searchIndex_eq")]
    public string? Contact_ContactEmails_SearchIndex_EQ { get; set; }
    /// <summary> Contact.ContactEmails.SearchIndex contains </summary>
    [JsonProperty("contact_contactEmails_searchIndex_con")]
    public string? Contact_ContactEmails_SearchIndex_CON { get; set; }
    /// <summary> Contact.ContactEmails.SearchIndex regex </summary>
    [JsonProperty("contact_contactEmails_searchIndex_reg")]
    public string? Contact_ContactEmails_SearchIndex_REG { get; set; }

    /// <summary> Contact.ContactEmails.Email equals </summary>
    [JsonProperty("contact_contactEmails_email_eq")]
    public string? Contact_ContactEmails_Email_EQ { get; set; }
    /// <summary> Contact.ContactEmails.Email contains </summary>
    [JsonProperty("contact_contactEmails_email_con")]
    public string? Contact_ContactEmails_Email_CON { get; set; }
    /// <summary> Contact.ContactEmails.Email regex </summary>
    [JsonProperty("contact_contactEmails_email_reg")]
    public string? Contact_ContactEmails_Email_REG { get; set; }

    /// <summary> Contact.ContactEmails.Label equals </summary>
    [JsonProperty("contact_contactEmails_label_eq")]
    public LabelEmailType? Contact_ContactEmails_Label_EQ { get; set; }


    /// <summary> Contact.FirstName equals </summary>
    [JsonProperty("contact_firstName_eq")]
    public string? Contact_FirstName_EQ { get; set; }
    /// <summary> Contact.FirstName contains </summary>
    [JsonProperty("contact_firstName_con")]
    public string? Contact_FirstName_CON { get; set; }
    /// <summary> Contact.FirstName regex </summary>
    [JsonProperty("contact_firstName_reg")]
    public string? Contact_FirstName_REG { get; set; }

    /// <summary> Contact.LastName equals </summary>
    [JsonProperty("contact_lastName_eq")]
    public string? Contact_LastName_EQ { get; set; }
    /// <summary> Contact.LastName contains </summary>
    [JsonProperty("contact_lastName_con")]
    public string? Contact_LastName_CON { get; set; }
    /// <summary> Contact.LastName regex </summary>
    [JsonProperty("contact_lastName_reg")]
    public string? Contact_LastName_REG { get; set; }

    /// <summary> Contact.JobTittle equals </summary>
    [JsonProperty("contact_jobTittle_eq")]
    public string? Contact_JobTittle_EQ { get; set; }
    /// <summary> Contact.JobTittle contains </summary>
    [JsonProperty("contact_jobTittle_con")]
    public string? Contact_JobTittle_CON { get; set; }
    /// <summary> Contact.JobTittle regex </summary>
    [JsonProperty("contact_jobTittle_reg")]
    public string? Contact_JobTittle_REG { get; set; }

    /// <summary> Contact.Company equals </summary>
    [JsonProperty("contact_company_eq")]
    public string? Contact_Company_EQ { get; set; }
    /// <summary> Contact.Company contains </summary>
    [JsonProperty("contact_company_con")]
    public string? Contact_Company_CON { get; set; }
    /// <summary> Contact.Company regex </summary>
    [JsonProperty("contact_company_reg")]
    public string? Contact_Company_REG { get; set; }

    /// <summary> Contact.Hash equals </summary>
    [JsonProperty("contact_hash_eq")]
    public string? Contact_Hash_EQ { get; set; }
    /// <summary> Contact.Hash contains </summary>
    [JsonProperty("contact_hash_con")]
    public string? Contact_Hash_CON { get; set; }
    /// <summary> Contact.Hash regex </summary>
    [JsonProperty("contact_hash_reg")]
    public string? Contact_Hash_REG { get; set; }

    /// <summary> Contact.Notes equals </summary>
    [JsonProperty("contact_notes_eq")]
    public string? Contact_Notes_EQ { get; set; }
    /// <summary> Contact.Notes contains </summary>
    [JsonProperty("contact_notes_con")]
    public string? Contact_Notes_CON { get; set; }
    /// <summary> Contact.Notes regex </summary>
    [JsonProperty("contact_notes_reg")]
    public string? Contact_Notes_REG { get; set; }

    /// <summary> Contact.Variables.Name equals </summary>
    [JsonProperty("contact_variables_name_eq")]
    public string? Contact_Variables_Name_EQ { get; set; }
    /// <summary> Contact.Variables.Name contains </summary>
    [JsonProperty("contact_variables_name_con")]
    public string? Contact_Variables_Name_CON { get; set; }
    /// <summary> Contact.Variables.Name regex </summary>
    [JsonProperty("contact_variables_name_reg")]
    public string? Contact_Variables_Name_REG { get; set; }

    /// <summary> Contact.Variables.JsonValue equals </summary>
    [JsonProperty("contact_variables_jsonValue_eq")]
    public string? Contact_Variables_JsonValue_EQ { get; set; }
    /// <summary> Contact.Variables.JsonValue contains </summary>
    [JsonProperty("contact_variables_jsonValue_con")]
    public string? Contact_Variables_JsonValue_CON { get; set; }
    /// <summary> Contact.Variables.JsonValue regex </summary>
    [JsonProperty("contact_variables_jsonValue_reg")]
    public string? Contact_Variables_JsonValue_REG { get; set; }


    /// <summary> Contact.Id equals </summary>
    [JsonProperty("contact_id_eq")]
    public string? Contact_Id_EQ { get; set; }
    /// <summary> Contact.Id contains </summary>
    [JsonProperty("contact_id_con")]
    public string? Contact_Id_CON { get; set; }
    /// <summary> Contact.Id regex </summary>
    [JsonProperty("contact_id_reg")]
    public string? Contact_Id_REG { get; set; }

    /// <summary> Contact.DateCreated equals </summary>
    [JsonProperty("contact_dateCreated_eq")]
    public DateTime? Contact_DateCreated_EQ { get; set; }
    /// <summary> Contact.DateCreated less than or equal to </summary>
    [JsonProperty("contact_dateCreated_lte")]
    public DateTime? Contact_DateCreated_LTE { get; set; }
    /// <summary> Contact.DateCreated greater than or equal to </summary>
    [JsonProperty("contact_dateCreated_gte")]
    public DateTime? Contact_DateCreated_GTE { get; set; }

    /// <summary> Contact.DateUpdated equals </summary>
    [JsonProperty("contact_dateUpdated_eq")]
    public DateTime? Contact_DateUpdated_EQ { get; set; }
    /// <summary> Contact.DateUpdated less than or equal to </summary>
    [JsonProperty("contact_dateUpdated_lte")]
    public DateTime? Contact_DateUpdated_LTE { get; set; }
    /// <summary> Contact.DateUpdated greater than or equal to </summary>
    [JsonProperty("contact_dateUpdated_gte")]
    public DateTime? Contact_DateUpdated_GTE { get; set; }


    /// <summary> LineThatInitiatedCall.FriendlyName equals </summary>
    [JsonProperty("lineThatInitiatedCall_friendlyName_eq")]
    public string? LineThatInitiatedCall_FriendlyName_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.FriendlyName contains </summary>
    [JsonProperty("lineThatInitiatedCall_friendlyName_con")]
    public string? LineThatInitiatedCall_FriendlyName_CON { get; set; }
    /// <summary> LineThatInitiatedCall.FriendlyName regex </summary>
    [JsonProperty("lineThatInitiatedCall_friendlyName_reg")]
    public string? LineThatInitiatedCall_FriendlyName_REG { get; set; }

    /// <summary> LineThatInitiatedCall.LineConnectionStatus.IpWAN equals </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_ipWAN_eq")]
    public string? LineThatInitiatedCall_LineConnectionStatus_IpWAN_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.IpWAN contains </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_ipWAN_con")]
    public string? LineThatInitiatedCall_LineConnectionStatus_IpWAN_CON { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.IpWAN regex </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_ipWAN_reg")]
    public string? LineThatInitiatedCall_LineConnectionStatus_IpWAN_REG { get; set; }

    /// <summary> LineThatInitiatedCall.LineConnectionStatus.PortWAN equals </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_portWAN_eq")]
    public System.Int32? LineThatInitiatedCall_LineConnectionStatus_PortWAN_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.PortWAN less than or equal to </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_portWAN_lte")]
    public System.Int32? LineThatInitiatedCall_LineConnectionStatus_PortWAN_LTE { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.PortWAN greater than or equal to </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_portWAN_gte")]
    public System.Int32? LineThatInitiatedCall_LineConnectionStatus_PortWAN_GTE { get; set; }

    /// <summary> LineThatInitiatedCall.LineConnectionStatus.IpLAN equals </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_ipLAN_eq")]
    public string? LineThatInitiatedCall_LineConnectionStatus_IpLAN_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.IpLAN contains </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_ipLAN_con")]
    public string? LineThatInitiatedCall_LineConnectionStatus_IpLAN_CON { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.IpLAN regex </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_ipLAN_reg")]
    public string? LineThatInitiatedCall_LineConnectionStatus_IpLAN_REG { get; set; }

    /// <summary> LineThatInitiatedCall.LineConnectionStatus.PortLAN equals </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_portLAN_eq")]
    public System.Int32? LineThatInitiatedCall_LineConnectionStatus_PortLAN_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.PortLAN less than or equal to </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_portLAN_lte")]
    public System.Int32? LineThatInitiatedCall_LineConnectionStatus_PortLAN_LTE { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.PortLAN greater than or equal to </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_portLAN_gte")]
    public System.Int32? LineThatInitiatedCall_LineConnectionStatus_PortLAN_GTE { get; set; }

    /// <summary> LineThatInitiatedCall.LineConnectionStatus.UserAgent equals </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_userAgent_eq")]
    public string? LineThatInitiatedCall_LineConnectionStatus_UserAgent_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.UserAgent contains </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_userAgent_con")]
    public string? LineThatInitiatedCall_LineConnectionStatus_UserAgent_CON { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.UserAgent regex </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_userAgent_reg")]
    public string? LineThatInitiatedCall_LineConnectionStatus_UserAgent_REG { get; set; }

    /// <summary> LineThatInitiatedCall.LineConnectionStatus.IsConnected equals </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_isConnected_eq")]
    public bool? LineThatInitiatedCall_LineConnectionStatus_IsConnected_EQ { get; set; }

    /// <summary> LineThatInitiatedCall.LineConnectionStatus.DisconnectedReason equals </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_disconnectedReason_eq")]
    public string? LineThatInitiatedCall_LineConnectionStatus_DisconnectedReason_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.DisconnectedReason contains </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_disconnectedReason_con")]
    public string? LineThatInitiatedCall_LineConnectionStatus_DisconnectedReason_CON { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.DisconnectedReason regex </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_disconnectedReason_reg")]
    public string? LineThatInitiatedCall_LineConnectionStatus_DisconnectedReason_REG { get; set; }

    /// <summary> LineThatInitiatedCall.LineConnectionStatus.DateConnected equals </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_dateConnected_eq")]
    public DateTime? LineThatInitiatedCall_LineConnectionStatus_DateConnected_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.DateConnected less than or equal to </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_dateConnected_lte")]
    public DateTime? LineThatInitiatedCall_LineConnectionStatus_DateConnected_LTE { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.DateConnected greater than or equal to </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_dateConnected_gte")]
    public DateTime? LineThatInitiatedCall_LineConnectionStatus_DateConnected_GTE { get; set; }

    /// <summary> LineThatInitiatedCall.LineConnectionStatus.DateDisconnected equals </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_dateDisconnected_eq")]
    public DateTime? LineThatInitiatedCall_LineConnectionStatus_DateDisconnected_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.DateDisconnected less than or equal to </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_dateDisconnected_lte")]
    public DateTime? LineThatInitiatedCall_LineConnectionStatus_DateDisconnected_LTE { get; set; }
    /// <summary> LineThatInitiatedCall.LineConnectionStatus.DateDisconnected greater than or equal to </summary>
    [JsonProperty("lineThatInitiatedCall_lineConnectionStatus_dateDisconnected_gte")]
    public DateTime? LineThatInitiatedCall_LineConnectionStatus_DateDisconnected_GTE { get; set; }


    /// <summary> LineThatInitiatedCall.CallerIdNumber equals </summary>
    [JsonProperty("lineThatInitiatedCall_callerIdNumber_eq")]
    public string? LineThatInitiatedCall_CallerIdNumber_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.CallerIdNumber contains </summary>
    [JsonProperty("lineThatInitiatedCall_callerIdNumber_con")]
    public string? LineThatInitiatedCall_CallerIdNumber_CON { get; set; }
    /// <summary> LineThatInitiatedCall.CallerIdNumber regex </summary>
    [JsonProperty("lineThatInitiatedCall_callerIdNumber_reg")]
    public string? LineThatInitiatedCall_CallerIdNumber_REG { get; set; }

    /// <summary> LineThatInitiatedCall.RecordExternalCalls equals </summary>
    [JsonProperty("lineThatInitiatedCall_recordExternalCalls_eq")]
    public bool? LineThatInitiatedCall_RecordExternalCalls_EQ { get; set; }

    /// <summary> LineThatInitiatedCall.RecordInternalCalls equals </summary>
    [JsonProperty("lineThatInitiatedCall_recordInternalCalls_eq")]
    public bool? LineThatInitiatedCall_RecordInternalCalls_EQ { get; set; }

    /// <summary> LineThatInitiatedCall.Language equals </summary>
    [JsonProperty("lineThatInitiatedCall_language_eq")]
    public Language? LineThatInitiatedCall_Language_EQ { get; set; }

    /// <summary> LineThatInitiatedCall.Id equals </summary>
    [JsonProperty("lineThatInitiatedCall_id_eq")]
    public string? LineThatInitiatedCall_Id_EQ { get; set; }
    /// <summary> LineThatInitiatedCall.Id contains </summary>
    [JsonProperty("lineThatInitiatedCall_id_con")]
    public string? LineThatInitiatedCall_Id_CON { get; set; }
    /// <summary> LineThatInitiatedCall.Id regex </summary>
    [JsonProperty("lineThatInitiatedCall_id_reg")]
    public string? LineThatInitiatedCall_Id_REG { get; set; }


    /// <summary> IdVoicemail equals </summary>
    [JsonProperty("idVoicemail_eq")]
    public string? IdVoicemail_EQ { get; set; }
    /// <summary> IdVoicemail contains </summary>
    [JsonProperty("idVoicemail_con")]
    public string? IdVoicemail_CON { get; set; }
    /// <summary> IdVoicemail regex </summary>
    [JsonProperty("idVoicemail_reg")]
    public string? IdVoicemail_REG { get; set; }

    /// <summary> IdCallThatTerminatedThisCallDoToAttendantTransfer equals </summary>
    [JsonProperty("idCallThatTerminatedThisCallDoToAttendantTransfer_eq")]
    public string? IdCallThatTerminatedThisCallDoToAttendantTransfer_EQ { get; set; }
    /// <summary> IdCallThatTerminatedThisCallDoToAttendantTransfer contains </summary>
    [JsonProperty("idCallThatTerminatedThisCallDoToAttendantTransfer_con")]
    public string? IdCallThatTerminatedThisCallDoToAttendantTransfer_CON { get; set; }
    /// <summary> IdCallThatTerminatedThisCallDoToAttendantTransfer regex </summary>
    [JsonProperty("idCallThatTerminatedThisCallDoToAttendantTransfer_reg")]
    public string? IdCallThatTerminatedThisCallDoToAttendantTransfer_REG { get; set; }

    /// <summary> ChannelVariables.Language equals </summary>
    [JsonProperty("channelVariables_language_eq")]
    public Language? ChannelVariables_Language_EQ { get; set; }

    /// <summary> ChannelVariables.IdMusicOnHold equals </summary>
    [JsonProperty("channelVariables_idMusicOnHold_eq")]
    public string? ChannelVariables_IdMusicOnHold_EQ { get; set; }
    /// <summary> ChannelVariables.IdMusicOnHold contains </summary>
    [JsonProperty("channelVariables_idMusicOnHold_con")]
    public string? ChannelVariables_IdMusicOnHold_CON { get; set; }
    /// <summary> ChannelVariables.IdMusicOnHold regex </summary>
    [JsonProperty("channelVariables_idMusicOnHold_reg")]
    public string? ChannelVariables_IdMusicOnHold_REG { get; set; }

    /// <summary> ChannelVariables.CallerIdName equals </summary>
    [JsonProperty("channelVariables_callerIdName_eq")]
    public string? ChannelVariables_CallerIdName_EQ { get; set; }
    /// <summary> ChannelVariables.CallerIdName contains </summary>
    [JsonProperty("channelVariables_callerIdName_con")]
    public string? ChannelVariables_CallerIdName_CON { get; set; }
    /// <summary> ChannelVariables.CallerIdName regex </summary>
    [JsonProperty("channelVariables_callerIdName_reg")]
    public string? ChannelVariables_CallerIdName_REG { get; set; }

    /// <summary> ChannelVariables.CallerIdNumber equals </summary>
    [JsonProperty("channelVariables_callerIdNumber_eq")]
    public string? ChannelVariables_CallerIdNumber_EQ { get; set; }
    /// <summary> ChannelVariables.CallerIdNumber contains </summary>
    [JsonProperty("channelVariables_callerIdNumber_con")]
    public string? ChannelVariables_CallerIdNumber_CON { get; set; }
    /// <summary> ChannelVariables.CallerIdNumber regex </summary>
    [JsonProperty("channelVariables_callerIdNumber_reg")]
    public string? ChannelVariables_CallerIdNumber_REG { get; set; }


    /// <summary> ChildCalls.ChildCallType equals </summary>
    [JsonProperty("childCalls_childCallType_eq")]
    public ChildCallType? ChildCalls_ChildCallType_EQ { get; set; }

    /// <summary> ChildCalls.DialStatus equals </summary>
    [JsonProperty("childCalls_dialStatus_eq")]
    public string? ChildCalls_DialStatus_EQ { get; set; }
    /// <summary> ChildCalls.DialStatus contains </summary>
    [JsonProperty("childCalls_dialStatus_con")]
    public string? ChildCalls_DialStatus_CON { get; set; }
    /// <summary> ChildCalls.DialStatus regex </summary>
    [JsonProperty("childCalls_dialStatus_reg")]
    public string? ChildCalls_DialStatus_REG { get; set; }

    /// <summary> ChildCalls.DateCreated equals </summary>
    [JsonProperty("childCalls_dateCreated_eq")]
    public DateTime? ChildCalls_DateCreated_EQ { get; set; }
    /// <summary> ChildCalls.DateCreated less than or equal to </summary>
    [JsonProperty("childCalls_dateCreated_lte")]
    public DateTime? ChildCalls_DateCreated_LTE { get; set; }
    /// <summary> ChildCalls.DateCreated greater than or equal to </summary>
    [JsonProperty("childCalls_dateCreated_gte")]
    public DateTime? ChildCalls_DateCreated_GTE { get; set; }

    /// <summary> ChildCalls.DateEnded equals </summary>
    [JsonProperty("childCalls_dateEnded_eq")]
    public DateTime? ChildCalls_DateEnded_EQ { get; set; }
    /// <summary> ChildCalls.DateEnded less than or equal to </summary>
    [JsonProperty("childCalls_dateEnded_lte")]
    public DateTime? ChildCalls_DateEnded_LTE { get; set; }
    /// <summary> ChildCalls.DateEnded greater than or equal to </summary>
    [JsonProperty("childCalls_dateEnded_gte")]
    public DateTime? ChildCalls_DateEnded_GTE { get; set; }

    /// <summary> ChildCalls.SecondsItTookToAnswer equals </summary>
    [JsonProperty("childCalls_secondsItTookToAnswer_eq")]
    public System.Int32? ChildCalls_SecondsItTookToAnswer_EQ { get; set; }
    /// <summary> ChildCalls.SecondsItTookToAnswer less than or equal to </summary>
    [JsonProperty("childCalls_secondsItTookToAnswer_lte")]
    public System.Int32? ChildCalls_SecondsItTookToAnswer_LTE { get; set; }
    /// <summary> ChildCalls.SecondsItTookToAnswer greater than or equal to </summary>
    [JsonProperty("childCalls_secondsItTookToAnswer_gte")]
    public System.Int32? ChildCalls_SecondsItTookToAnswer_GTE { get; set; }


    /// <summary> DialStatus equals </summary>
    [JsonProperty("dialStatus_eq")]
    public string? DialStatus_EQ { get; set; }
    /// <summary> DialStatus contains </summary>
    [JsonProperty("dialStatus_con")]
    public string? DialStatus_CON { get; set; }
    /// <summary> DialStatus regex </summary>
    [JsonProperty("dialStatus_reg")]
    public string? DialStatus_REG { get; set; }

    /// <summary> SecondsItTookToAnswer equals </summary>
    [JsonProperty("secondsItTookToAnswer_eq")]
    public System.Int32? SecondsItTookToAnswer_EQ { get; set; }
    /// <summary> SecondsItTookToAnswer less than or equal to </summary>
    [JsonProperty("secondsItTookToAnswer_lte")]
    public System.Int32? SecondsItTookToAnswer_LTE { get; set; }
    /// <summary> SecondsItTookToAnswer greater than or equal to </summary>
    [JsonProperty("secondsItTookToAnswer_gte")]
    public System.Int32? SecondsItTookToAnswer_GTE { get; set; }

    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenPlacedOnHold equals </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenPlacedOnHold_eq")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenPlacedOnHold_EQ { get; set; }
    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenPlacedOnHold less than or equal to </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenPlacedOnHold_lte")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenPlacedOnHold_LTE { get; set; }
    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenPlacedOnHold greater than or equal to </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenPlacedOnHold_gte")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenPlacedOnHold_GTE { get; set; }

    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenRemovedFromHold equals </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenRemovedFromHold_eq")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenRemovedFromHold_EQ { get; set; }
    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenRemovedFromHold less than or equal to </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenRemovedFromHold_lte")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenRemovedFromHold_LTE { get; set; }
    /// <summary> TimesWhenCallPlacedOnHold.SecondsElapsedWhenRemovedFromHold greater than or equal to </summary>
    [JsonProperty("timesWhenCallPlacedOnHold_secondsElapsedWhenRemovedFromHold_gte")]
    public System.Int32? TimesWhenCallPlacedOnHold_SecondsElapsedWhenRemovedFromHold_GTE { get; set; }


    /// <summary> From equals </summary>
    [JsonProperty("from_eq")]
    public string? From_EQ { get; set; }
    /// <summary> From contains </summary>
    [JsonProperty("from_con")]
    public string? From_CON { get; set; }
    /// <summary> From regex </summary>
    [JsonProperty("from_reg")]
    public string? From_REG { get; set; }

    /// <summary> FromCountry equals </summary>
    [JsonProperty("fromCountry_eq")]
    public CountryIsoCode? FromCountry_EQ { get; set; }

    /// <summary> To equals </summary>
    [JsonProperty("to_eq")]
    public string? To_EQ { get; set; }
    /// <summary> To contains </summary>
    [JsonProperty("to_con")]
    public string? To_CON { get; set; }
    /// <summary> To regex </summary>
    [JsonProperty("to_reg")]
    public string? To_REG { get; set; }

    /// <summary> ToCountry equals </summary>
    [JsonProperty("toCountry_eq")]
    public CountryIsoCode? ToCountry_EQ { get; set; }

    /// <summary> CallType equals </summary>
    [JsonProperty("callType_eq")]
    public CallType? CallType_EQ { get; set; }

    /// <summary> Recording.ErrorMessage equals </summary>
    [JsonProperty("recording_errorMessage_eq")]
    public string? Recording_ErrorMessage_EQ { get; set; }
    /// <summary> Recording.ErrorMessage contains </summary>
    [JsonProperty("recording_errorMessage_con")]
    public string? Recording_ErrorMessage_CON { get; set; }
    /// <summary> Recording.ErrorMessage regex </summary>
    [JsonProperty("recording_errorMessage_reg")]
    public string? Recording_ErrorMessage_REG { get; set; }

    /// <summary> Recording.RecordingMp3.InstanceId equals </summary>
    [JsonProperty("recording_recordingMp3_instanceId_eq")]
    public string? Recording_RecordingMp3_InstanceId_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.InstanceId contains </summary>
    [JsonProperty("recording_recordingMp3_instanceId_con")]
    public string? Recording_RecordingMp3_InstanceId_CON { get; set; }
    /// <summary> Recording.RecordingMp3.InstanceId regex </summary>
    [JsonProperty("recording_recordingMp3_instanceId_reg")]
    public string? Recording_RecordingMp3_InstanceId_REG { get; set; }

    /// <summary> Recording.RecordingMp3.FileSizeInBytes equals </summary>
    [JsonProperty("recording_recordingMp3_fileSizeInBytes_eq")]
    public System.Int32? Recording_RecordingMp3_FileSizeInBytes_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.FileSizeInBytes less than or equal to </summary>
    [JsonProperty("recording_recordingMp3_fileSizeInBytes_lte")]
    public System.Int32? Recording_RecordingMp3_FileSizeInBytes_LTE { get; set; }
    /// <summary> Recording.RecordingMp3.FileSizeInBytes greater than or equal to </summary>
    [JsonProperty("recording_recordingMp3_fileSizeInBytes_gte")]
    public System.Int32? Recording_RecordingMp3_FileSizeInBytes_GTE { get; set; }

    /// <summary> Recording.RecordingMp3.Md5Hash equals </summary>
    [JsonProperty("recording_recordingMp3_md5Hash_eq")]
    public string? Recording_RecordingMp3_Md5Hash_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.Md5Hash contains </summary>
    [JsonProperty("recording_recordingMp3_md5Hash_con")]
    public string? Recording_RecordingMp3_Md5Hash_CON { get; set; }
    /// <summary> Recording.RecordingMp3.Md5Hash regex </summary>
    [JsonProperty("recording_recordingMp3_md5Hash_reg")]
    public string? Recording_RecordingMp3_Md5Hash_REG { get; set; }

    /// <summary> Recording.RecordingMp3.Url equals </summary>
    [JsonProperty("recording_recordingMp3_url_eq")]
    public string? Recording_RecordingMp3_Url_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.Url contains </summary>
    [JsonProperty("recording_recordingMp3_url_con")]
    public string? Recording_RecordingMp3_Url_CON { get; set; }
    /// <summary> Recording.RecordingMp3.Url regex </summary>
    [JsonProperty("recording_recordingMp3_url_reg")]
    public string? Recording_RecordingMp3_Url_REG { get; set; }

    /// <summary> Recording.RecordingMp3.Id equals </summary>
    [JsonProperty("recording_recordingMp3_id_eq")]
    public string? Recording_RecordingMp3_Id_EQ { get; set; }
    /// <summary> Recording.RecordingMp3.Id contains </summary>
    [JsonProperty("recording_recordingMp3_id_con")]
    public string? Recording_RecordingMp3_Id_CON { get; set; }
    /// <summary> Recording.RecordingMp3.Id regex </summary>
    [JsonProperty("recording_recordingMp3_id_reg")]
    public string? Recording_RecordingMp3_Id_REG { get; set; }


    /// <summary> Recording.RecordingDurationInSeconds equals </summary>
    [JsonProperty("recording_recordingDurationInSeconds_eq")]
    public System.Int32? Recording_RecordingDurationInSeconds_EQ { get; set; }
    /// <summary> Recording.RecordingDurationInSeconds less than or equal to </summary>
    [JsonProperty("recording_recordingDurationInSeconds_lte")]
    public System.Int32? Recording_RecordingDurationInSeconds_LTE { get; set; }
    /// <summary> Recording.RecordingDurationInSeconds greater than or equal to </summary>
    [JsonProperty("recording_recordingDurationInSeconds_gte")]
    public System.Int32? Recording_RecordingDurationInSeconds_GTE { get; set; }

    /// <summary> Recording.Id equals </summary>
    [JsonProperty("recording_id_eq")]
    public string? Recording_Id_EQ { get; set; }
    /// <summary> Recording.Id contains </summary>
    [JsonProperty("recording_id_con")]
    public string? Recording_Id_CON { get; set; }
    /// <summary> Recording.Id regex </summary>
    [JsonProperty("recording_id_reg")]
    public string? Recording_Id_REG { get; set; }


    /// <summary> DisabledVideo equals </summary>
    [JsonProperty("disabledVideo_eq")]
    public bool? DisabledVideo_EQ { get; set; }

    /// <summary> DigitsSent equals </summary>
    [JsonProperty("digitsSent_eq")]
    public string? DigitsSent_EQ { get; set; }
    /// <summary> DigitsSent contains </summary>
    [JsonProperty("digitsSent_con")]
    public string? DigitsSent_CON { get; set; }
    /// <summary> DigitsSent regex </summary>
    [JsonProperty("digitsSent_reg")]
    public string? DigitsSent_REG { get; set; }

    /// <summary> IsInternational equals </summary>
    [JsonProperty("isInternational_eq")]
    public bool? IsInternational_EQ { get; set; }

    /// <summary> DateEnded equals </summary>
    [JsonProperty("dateEnded_eq")]
    public DateTime? DateEnded_EQ { get; set; }
    /// <summary> DateEnded less than or equal to </summary>
    [JsonProperty("dateEnded_lte")]
    public DateTime? DateEnded_LTE { get; set; }
    /// <summary> DateEnded greater than or equal to </summary>
    [JsonProperty("dateEnded_gte")]
    public DateTime? DateEnded_GTE { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for CloudServices </summary>
public class CloudServiceFilterRequest 
{
    /// <summary> CloudServiceType equals </summary>
    [JsonProperty("cloudServiceType_eq")]
    public CloudServiceType? CloudServiceType_EQ { get; set; }

    /// <summary> CountryIsoCode equals </summary>
    [JsonProperty("countryIsoCode_eq")]
    public CountryIsoCode? CountryIsoCode_EQ { get; set; }

    /// <summary> Localnet equals </summary>
    [JsonProperty("localnet_eq")]
    public string? Localnet_EQ { get; set; }
    /// <summary> Localnet contains </summary>
    [JsonProperty("localnet_con")]
    public string? Localnet_CON { get; set; }
    /// <summary> Localnet regex </summary>
    [JsonProperty("localnet_reg")]
    public string? Localnet_REG { get; set; }

    /// <summary> ExternalIp equals </summary>
    [JsonProperty("externalIp_eq")]
    public string? ExternalIp_EQ { get; set; }
    /// <summary> ExternalIp contains </summary>
    [JsonProperty("externalIp_con")]
    public string? ExternalIp_CON { get; set; }
    /// <summary> ExternalIp regex </summary>
    [JsonProperty("externalIp_reg")]
    public string? ExternalIp_REG { get; set; }

    /// <summary> IsFailover equals </summary>
    [JsonProperty("isFailover_eq")]
    public bool? IsFailover_EQ { get; set; }

    /// <summary> Nat equals </summary>
    [JsonProperty("nat_eq")]
    public bool? Nat_EQ { get; set; }

    /// <summary> IsHealthy equals </summary>
    [JsonProperty("isHealthy_eq")]
    public bool? IsHealthy_EQ { get; set; }

    /// <summary> InstanceId equals </summary>
    [JsonProperty("instanceId_eq")]
    public string? InstanceId_EQ { get; set; }
    /// <summary> InstanceId contains </summary>
    [JsonProperty("instanceId_con")]
    public string? InstanceId_CON { get; set; }
    /// <summary> InstanceId regex </summary>
    [JsonProperty("instanceId_reg")]
    public string? InstanceId_REG { get; set; }

    /// <summary> HttpListenPort equals </summary>
    [JsonProperty("httpListenPort_eq")]
    public System.Int32? HttpListenPort_EQ { get; set; }
    /// <summary> HttpListenPort less than or equal to </summary>
    [JsonProperty("httpListenPort_lte")]
    public System.Int32? HttpListenPort_LTE { get; set; }
    /// <summary> HttpListenPort greater than or equal to </summary>
    [JsonProperty("httpListenPort_gte")]
    public System.Int32? HttpListenPort_GTE { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for Extensions </summary>
public class ExtensionFilterRequest 
{
    /// <summary> IdMusicOnHoldGroup equals </summary>
    [JsonProperty("idMusicOnHoldGroup_eq")]
    public string? IdMusicOnHoldGroup_EQ { get; set; }
    /// <summary> IdMusicOnHoldGroup contains </summary>
    [JsonProperty("idMusicOnHoldGroup_con")]
    public string? IdMusicOnHoldGroup_CON { get; set; }
    /// <summary> IdMusicOnHoldGroup regex </summary>
    [JsonProperty("idMusicOnHoldGroup_reg")]
    public string? IdMusicOnHoldGroup_REG { get; set; }

    /// <summary> ExtensionType equals </summary>
    [JsonProperty("extensionType_eq")]
    public ExtensionType? ExtensionType_EQ { get; set; }

    /// <summary> FriendlyName equals </summary>
    [JsonProperty("friendlyName_eq")]
    public string? FriendlyName_EQ { get; set; }
    /// <summary> FriendlyName contains </summary>
    [JsonProperty("friendlyName_con")]
    public string? FriendlyName_CON { get; set; }
    /// <summary> FriendlyName regex </summary>
    [JsonProperty("friendlyName_reg")]
    public string? FriendlyName_REG { get; set; }

    /// <summary> Number equals </summary>
    [JsonProperty("number_eq")]
    public string? Number_EQ { get; set; }
    /// <summary> Number contains </summary>
    [JsonProperty("number_con")]
    public string? Number_CON { get; set; }
    /// <summary> Number regex </summary>
    [JsonProperty("number_reg")]
    public string? Number_REG { get; set; }

    /// <summary> InjectExtensionNameToCallerId equals </summary>
    [JsonProperty("injectExtensionNameToCallerId_eq")]
    public bool? InjectExtensionNameToCallerId_EQ { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for TrunkOriginations </summary>
public class TrunkOriginationFilterRequest 
{
    /// <summary> TrunkOriginationType equals </summary>
    [JsonProperty("trunkOriginationType_eq")]
    public TrunkOriginationType? TrunkOriginationType_EQ { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
/// <summary> Enables searching for VoipNumbers </summary>
public class VoipNumberFilterRequest 
{
    /// <summary> RulesPhone.IdCallFlowLogic equals </summary>
    [JsonProperty("rulesPhone_idCallFlowLogic_eq")]
    public string? RulesPhone_IdCallFlowLogic_EQ { get; set; }
    /// <summary> RulesPhone.IdCallFlowLogic contains </summary>
    [JsonProperty("rulesPhone_idCallFlowLogic_con")]
    public string? RulesPhone_IdCallFlowLogic_CON { get; set; }
    /// <summary> RulesPhone.IdCallFlowLogic regex </summary>
    [JsonProperty("rulesPhone_idCallFlowLogic_reg")]
    public string? RulesPhone_IdCallFlowLogic_REG { get; set; }

    /// <summary> RulesPhone.IdExtension equals </summary>
    [JsonProperty("rulesPhone_idExtension_eq")]
    public string? RulesPhone_IdExtension_EQ { get; set; }
    /// <summary> RulesPhone.IdExtension contains </summary>
    [JsonProperty("rulesPhone_idExtension_con")]
    public string? RulesPhone_IdExtension_CON { get; set; }
    /// <summary> RulesPhone.IdExtension regex </summary>
    [JsonProperty("rulesPhone_idExtension_reg")]
    public string? RulesPhone_IdExtension_REG { get; set; }

    /// <summary> RulesPhone.DaysOfWeek contains </summary>
    [JsonProperty("rulesPhone_daysOfWeek_con")]
    public DayOfWeek? RulesPhone_DaysOfWeek_CON { get; set; }


    /// <summary> RulesSms.ForwardToEmailAddress equals </summary>
    [JsonProperty("rulesSms_forwardToEmailAddress_eq")]
    public string? RulesSms_ForwardToEmailAddress_EQ { get; set; }
    /// <summary> RulesSms.ForwardToEmailAddress contains </summary>
    [JsonProperty("rulesSms_forwardToEmailAddress_con")]
    public string? RulesSms_ForwardToEmailAddress_CON { get; set; }
    /// <summary> RulesSms.ForwardToEmailAddress regex </summary>
    [JsonProperty("rulesSms_forwardToEmailAddress_reg")]
    public string? RulesSms_ForwardToEmailAddress_REG { get; set; }


    /// <summary> RulesFax.ForwardToEmailAddress equals </summary>
    [JsonProperty("rulesFax_forwardToEmailAddress_eq")]
    public string? RulesFax_ForwardToEmailAddress_EQ { get; set; }
    /// <summary> RulesFax.ForwardToEmailAddress contains </summary>
    [JsonProperty("rulesFax_forwardToEmailAddress_con")]
    public string? RulesFax_ForwardToEmailAddress_CON { get; set; }
    /// <summary> RulesFax.ForwardToEmailAddress regex </summary>
    [JsonProperty("rulesFax_forwardToEmailAddress_reg")]
    public string? RulesFax_ForwardToEmailAddress_REG { get; set; }


    /// <summary> VoipNumberType equals </summary>
    [JsonProperty("voipNumberType_eq")]
    public VoipNumberType? VoipNumberType_EQ { get; set; }

    /// <summary> InjectFriendlyNameToCallerId equals </summary>
    [JsonProperty("injectFriendlyNameToCallerId_eq")]
    public bool? InjectFriendlyNameToCallerId_EQ { get; set; }

    /// <summary> RecordIncomingCalls equals </summary>
    [JsonProperty("recordIncomingCalls_eq")]
    public bool? RecordIncomingCalls_EQ { get; set; }

    /// <summary> Number equals </summary>
    [JsonProperty("number_eq")]
    public string? Number_EQ { get; set; }
    /// <summary> Number contains </summary>
    [JsonProperty("number_con")]
    public string? Number_CON { get; set; }
    /// <summary> Number regex </summary>
    [JsonProperty("number_reg")]
    public string? Number_REG { get; set; }

    /// <summary> FriendlyName equals </summary>
    [JsonProperty("friendlyName_eq")]
    public string? FriendlyName_EQ { get; set; }
    /// <summary> FriendlyName contains </summary>
    [JsonProperty("friendlyName_con")]
    public string? FriendlyName_CON { get; set; }
    /// <summary> FriendlyName regex </summary>
    [JsonProperty("friendlyName_reg")]
    public string? FriendlyName_REG { get; set; }

    /// <summary> Description equals </summary>
    [JsonProperty("description_eq")]
    public string? Description_EQ { get; set; }
    /// <summary> Description contains </summary>
    [JsonProperty("description_con")]
    public string? Description_CON { get; set; }
    /// <summary> Description regex </summary>
    [JsonProperty("description_reg")]
    public string? Description_REG { get; set; }

    /// <summary> Language equals </summary>
    [JsonProperty("language_eq")]
    public Language? Language_EQ { get; set; }

    /// <summary> City equals </summary>
    [JsonProperty("city_eq")]
    public string? City_EQ { get; set; }
    /// <summary> City contains </summary>
    [JsonProperty("city_con")]
    public string? City_CON { get; set; }
    /// <summary> City regex </summary>
    [JsonProperty("city_reg")]
    public string? City_REG { get; set; }

    /// <summary> State equals </summary>
    [JsonProperty("state_eq")]
    public string? State_EQ { get; set; }
    /// <summary> State contains </summary>
    [JsonProperty("state_con")]
    public string? State_CON { get; set; }
    /// <summary> State regex </summary>
    [JsonProperty("state_reg")]
    public string? State_REG { get; set; }

    /// <summary> CountryIsoCode equals </summary>
    [JsonProperty("countryIsoCode_eq")]
    public CountryIsoCode? CountryIsoCode_EQ { get; set; }

    /// <summary> IsSmsEnabled equals </summary>
    [JsonProperty("isSmsEnabled_eq")]
    public bool? IsSmsEnabled_EQ { get; set; }

    /// <summary> IsVoiceEnabled equals </summary>
    [JsonProperty("isVoiceEnabled_eq")]
    public bool? IsVoiceEnabled_EQ { get; set; }

    /// <summary> IsTollFree equals </summary>
    [JsonProperty("isTollFree_eq")]
    public bool? IsTollFree_EQ { get; set; }

    /// <summary> IsWhatsappEnabled equals </summary>
    [JsonProperty("isWhatsappEnabled_eq")]
    public bool? IsWhatsappEnabled_EQ { get; set; }

    /// <summary> TimeZone equals </summary>
    [JsonProperty("timeZone_eq")]
    public string? TimeZone_EQ { get; set; }
    /// <summary> TimeZone contains </summary>
    [JsonProperty("timeZone_con")]
    public string? TimeZone_CON { get; set; }
    /// <summary> TimeZone regex </summary>
    [JsonProperty("timeZone_reg")]
    public string? TimeZone_REG { get; set; }

    /// <summary> Id equals </summary>
    [JsonProperty("id_eq")]
    public string? Id_EQ { get; set; }
    /// <summary> Id contains </summary>
    [JsonProperty("id_con")]
    public string? Id_CON { get; set; }
    /// <summary> Id regex </summary>
    [JsonProperty("id_reg")]
    public string? Id_REG { get; set; }

    /// <summary> DateCreated equals </summary>
    [JsonProperty("dateCreated_eq")]
    public DateTime? DateCreated_EQ { get; set; }
    /// <summary> DateCreated less than or equal to </summary>
    [JsonProperty("dateCreated_lte")]
    public DateTime? DateCreated_LTE { get; set; }
    /// <summary> DateCreated greater than or equal to </summary>
    [JsonProperty("dateCreated_gte")]
    public DateTime? DateCreated_GTE { get; set; }

    /// <summary> DateUpdated equals </summary>
    [JsonProperty("dateUpdated_eq")]
    public DateTime? DateUpdated_EQ { get; set; }
    /// <summary> DateUpdated less than or equal to </summary>
    [JsonProperty("dateUpdated_lte")]
    public DateTime? DateUpdated_LTE { get; set; }
    /// <summary> DateUpdated greater than or equal to </summary>
    [JsonProperty("dateUpdated_gte")]
    public DateTime? DateUpdated_GTE { get; set; }

}
