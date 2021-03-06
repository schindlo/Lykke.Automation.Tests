// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class PaginationResponseAssetResponse
    {
        /// <summary>
        /// Initializes a new instance of the PaginationResponseAssetResponse
        /// class.
        /// </summary>
        public PaginationResponseAssetResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PaginationResponseAssetResponse
        /// class.
        /// </summary>
        public PaginationResponseAssetResponse(string continuation = default(string), IList<AssetResponse> items = default(IList<AssetResponse>))
        {
            Continuation = continuation;
            Items = items;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "continuation")]
        public string Continuation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public IList<AssetResponse> Items { get; set; }

    }
}
