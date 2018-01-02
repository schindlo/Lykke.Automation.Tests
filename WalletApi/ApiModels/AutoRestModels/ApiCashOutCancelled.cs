// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ApiCashOutCancelled
    {
        /// <summary>
        /// Initializes a new instance of the ApiCashOutCancelled class.
        /// </summary>
        public ApiCashOutCancelled()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApiCashOutCancelled class.
        /// </summary>
        public ApiCashOutCancelled(string id = default(string), string dateTime = default(string), string asset = default(string), double? volume = default(double?), string iconId = default(string))
        {
            Id = id;
            DateTime = dateTime;
            Asset = asset;
            Volume = volume;
            IconId = iconId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DateTime")]
        public string DateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Asset")]
        public string Asset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Volume")]
        public double? Volume { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IconId")]
        public string IconId { get; set; }

    }
}
