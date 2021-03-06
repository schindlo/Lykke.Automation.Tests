// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ObsoleteApiDictAsset
    {
        /// <summary>
        /// Initializes a new instance of the ObsoleteApiDictAsset class.
        /// </summary>
        public ObsoleteApiDictAsset()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ObsoleteApiDictAsset class.
        /// </summary>
        public ObsoleteApiDictAsset(string id = default(string), string name = default(string), int? accuracy = default(int?), string issuerId = default(string))
        {
            Id = id;
            Name = name;
            Accuracy = accuracy;
            IssuerId = issuerId;
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
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Accuracy")]
        public int? Accuracy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IssuerId")]
        public string IssuerId { get; set; }

    }
}
