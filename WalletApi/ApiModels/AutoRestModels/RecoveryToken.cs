// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class RecoveryToken
    {
        /// <summary>
        /// Initializes a new instance of the RecoveryToken class.
        /// </summary>
        public RecoveryToken()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecoveryToken class.
        /// </summary>
        public RecoveryToken(string accessToken = default(string))
        {
            AccessToken = accessToken;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AccessToken")]
        public string AccessToken { get; set; }

    }
}
