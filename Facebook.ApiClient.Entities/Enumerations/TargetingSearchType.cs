namespace Facebook.ApiClient.Entities.Enumerations
{
    /// <summary>
    /// https://developers.facebook.com/docs/marketing-api/audiences/reference/targeting-search
    /// enum of the type= values for targeting search
    /// common parameters: q, type=, list, limit
    /// </summary>
    public enum TargetingSearchType
    {
        /// <summary>
        /// Parameter q ignored. See all possible targeting options for class with parameter class.
        /// Possible values of class: interests, behaviors, demographics, life_events, industries, income, family_statuses, user_device, user_os, behaviorsa
        /// </summary>
        adTargetingCategory,

        /// <summary>
        /// Autocomplete interest targeting
        /// </summary>
        adinterest,

        /// <summary>
        /// adinterest.adinterestsuggestion Suggestions based on interest targeting
        /// needs interest_list=["interst1", "interest2"]
        /// </summary>
        adinterestsuggestion,

        /// <summary>
        /// adinterest.adinterestvalid Validates string as valid interest targeting option
        /// needs interest_list=["interst1", "interest2"]
        /// </summary>
        adinterestvalid,

        /// <summary>
        /// Autocomplete combined for country, city, state & zip
        /// needs location_types=['region','city']
        /// </summary>
        adgeolocation,

        /// <summary>
        /// To verify current and/or planned status of targeting objects, use the targeting_option_list parameter:
        /// needs targeting_option_list=[<TARGETING_OPTION_ ID>,<TARGETING_OPTION_ID>]
        /// </summary>
        targetingoptionstatus,

        /// <summary>
        /// Autocomplete locale targeting
        /// </summary>
        adlocale,

        /// <summary>
        /// adgeolocation.adgeolocationmeta Additional metadata for geolocations
        /// needs at least 1 location entity array
        /// 'cities=[2418779]'
        /// 'zips=["US:90210"]'
        /// 'regions=[10]'
        /// 'countries=["US","JP"]'
        /// country_groups=[]
        /// </summary>
        adgeolocationmeta,

        /// <summary>
        /// adgeolocation.adradiussuggestion Returns recommended radius around location
        /// requires latitude=&longitude=
        /// </summary>
        adradiussuggestion,

        /// <summary>
        /// Autocomplete college targeting
        /// </summary>
        adeducationschool,

        /// <summary>
        /// Autocomplete college major targeting
        /// </summary>
        adeducationmajor,

        /// <summary>
        /// Autocomplete values for work employer
        /// </summary>
        adworkemployer,

        /// <summary>
        /// Autocomplete values for job title
        /// </summary>
        adworkposition
    }
}
