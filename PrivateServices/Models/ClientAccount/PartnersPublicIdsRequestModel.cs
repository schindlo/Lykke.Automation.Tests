﻿// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace LykkeAutomationPrivate.Models.ClientAccount.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class PartnersPublicIdsRequestModel
    {
        /// <summary>
        /// Initializes a new instance of the PartnersPublicIdsRequestModel
        /// class.
        /// </summary>
        public PartnersPublicIdsRequestModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PartnersPublicIdsRequestModel
        /// class.
        /// </summary>
        public PartnersPublicIdsRequestModel(IList<string> publicIds = default(IList<string>))
        {
            PublicIds = publicIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PublicIds")]
        public IList<string> PublicIds { get; set; }

    }
}