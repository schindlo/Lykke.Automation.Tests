// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ApiAssetPairModel
    {
        /// <summary>
        /// Initializes a new instance of the ApiAssetPairModel class.
        /// </summary>
        public ApiAssetPairModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApiAssetPairModel class.
        /// </summary>
        public ApiAssetPairModel(string group = default(string), string id = default(string), string name = default(string), int? accuracy = default(int?), int? invertedAccuracy = default(int?), string baseAssetId = default(string), string quotingAssetId = default(string), bool? inverted = default(bool?))
        {
            Group = group;
            Id = id;
            Name = name;
            Accuracy = accuracy;
            InvertedAccuracy = invertedAccuracy;
            BaseAssetId = baseAssetId;
            QuotingAssetId = quotingAssetId;
            Inverted = inverted;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Group")]
        public string Group { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Accuracy")]
        public int? Accuracy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InvertedAccuracy")]
        public int? InvertedAccuracy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BaseAssetId")]
        public string BaseAssetId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "QuotingAssetId")]
        public string QuotingAssetId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Inverted")]
        public bool? Inverted { get; set; }

    }
}