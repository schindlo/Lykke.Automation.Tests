// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class AccountsRegistrationResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the AccountsRegistrationResponseModel
        /// class.
        /// </summary>
        public AccountsRegistrationResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AccountsRegistrationResponseModel
        /// class.
        /// </summary>
        public AccountsRegistrationResponseModel(string token = default(string), string notificationsId = default(string), ApiPersonalDataModel personalData = default(ApiPersonalDataModel), bool? canCashInViaBankCard = default(bool?), bool? swiftDepositEnabled = default(bool?))
        {
            Token = token;
            NotificationsId = notificationsId;
            PersonalData = personalData;
            CanCashInViaBankCard = canCashInViaBankCard;
            SwiftDepositEnabled = swiftDepositEnabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Token")]
        public string Token { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NotificationsId")]
        public string NotificationsId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PersonalData")]
        public ApiPersonalDataModel PersonalData { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CanCashInViaBankCard")]
        public bool? CanCashInViaBankCard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SwiftDepositEnabled")]
        public bool? SwiftDepositEnabled { get; set; }

    }
}
