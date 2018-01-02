// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class GenerateTransferTransactionForEthereumModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GenerateTransferTransactionForEthereumModel class.
        /// </summary>
        public GenerateTransferTransactionForEthereumModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// GenerateTransferTransactionForEthereumModel class.
        /// </summary>
        public GenerateTransferTransactionForEthereumModel(string gasPrice = default(string), string gasAmount = default(string), string sourceAddress = default(string), string destinationAddress = default(string), double? amount = default(double?), string assetId = default(string))
        {
            GasPrice = gasPrice;
            GasAmount = gasAmount;
            SourceAddress = sourceAddress;
            DestinationAddress = destinationAddress;
            Amount = amount;
            AssetId = assetId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GasPrice")]
        public string GasPrice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GasAmount")]
        public string GasAmount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SourceAddress")]
        public string SourceAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DestinationAddress")]
        public string DestinationAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "AssetId")]
        public string AssetId { get; set; }

    }
}
