// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class AccountRegistrationModel_back
    {
        /// <summary>
        /// Initializes a new instance of the AccountRegistrationModel class.
        /// </summary>
        public AccountRegistrationModel_back()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AccountRegistrationModel class.
        /// </summary>
        public AccountRegistrationModel_back(string email = default(string), string fullName = default(string), string contactPhone = default(string), string password = default(string), string hint = default(string), string clientInfo = default(string), string partnerId = default(string))
        {
            Email = email;
            FullName = fullName;
            ContactPhone = contactPhone;
            Password = password;
            Hint = hint;
            ClientInfo = clientInfo;
            PartnerId = partnerId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FullName")]
        public string FullName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ContactPhone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Password")]
        public string Password { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Hint")]
        public string Hint { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ClientInfo")]
        public string ClientInfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PartnerId")]
        public string PartnerId { get; set; }

    }
}
