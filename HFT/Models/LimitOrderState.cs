// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LimitOrderState
    {
        /// <summary>
        /// Initializes a new instance of the LimitOrderState class.
        /// </summary>
        public LimitOrderState()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LimitOrderState class.
        /// </summary>
        public LimitOrderState(System.Guid id, double volume, double remainingVolume, System.DateTime createdAt, string status = default(string), string assetPairId = default(string), double? price = default(double?), System.DateTime? lastMatchTime = default(System.DateTime?))
        {
            Id = id;
            Status = status;
            AssetPairId = assetPairId;
            Volume = volume;
            Price = price;
            RemainingVolume = remainingVolume;
            LastMatchTime = lastMatchTime;
            CreatedAt = createdAt;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public string Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AssetPairId")]
        public string AssetPairId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Volume")]
        public double Volume { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Price")]
        public double? Price { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RemainingVolume")]
        public double RemainingVolume { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LastMatchTime")]
        public System.DateTime? LastMatchTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreatedAt")]
        public System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
