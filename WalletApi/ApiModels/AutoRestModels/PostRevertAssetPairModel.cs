// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PostRevertAssetPairModel
    {
        /// <summary>
        /// Initializes a new instance of the PostRevertAssetPairModel class.
        /// </summary>
        public PostRevertAssetPairModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PostRevertAssetPairModel class.
        /// </summary>
        public PostRevertAssetPairModel(string assetPairId = default(string), bool? inverted = default(bool?))
        {
            AssetPairId = assetPairId;
            Inverted = inverted;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AssetPairId")]
        public string AssetPairId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Inverted")]
        public bool? Inverted { get; set; }

    }
}
