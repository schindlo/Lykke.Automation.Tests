// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class TransactionOutputContract
    {
        /// <summary>
        /// Initializes a new instance of the TransactionOutputContract class.
        /// </summary>
        public TransactionOutputContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TransactionOutputContract class.
        /// </summary>
        public TransactionOutputContract(string toAddress = default(string), string amount = default(string))
        {
            ToAddress = toAddress;
            Amount = amount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "toAddress")]
        public string ToAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public string Amount { get; set; }

    }
}