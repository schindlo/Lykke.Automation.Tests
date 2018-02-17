// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class BccMultisigTransactionResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// BccMultisigTransactionResponseModel class.
        /// </summary>
        public BccMultisigTransactionResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// BccMultisigTransactionResponseModel class.
        /// </summary>
        public BccMultisigTransactionResponseModel(double? clientAmount = default(double?), double? hubAmount = default(double?), double? clientFee = default(double?), string transaction = default(string), string inputs = default(string))
        {
            ClientAmount = clientAmount;
            HubAmount = hubAmount;
            ClientFee = clientFee;
            Transaction = transaction;
            Inputs = inputs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ClientAmount")]
        public double? ClientAmount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "HubAmount")]
        public double? HubAmount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ClientFee")]
        public double? ClientFee { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Transaction")]
        public string Transaction { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Inputs")]
        public string Inputs { get; set; }

    }
}