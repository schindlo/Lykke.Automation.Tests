// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ResponseModelApiTransaction
    {
        /// <summary>
        /// Initializes a new instance of the ResponseModelApiTransaction
        /// class.
        /// </summary>
        public ResponseModelApiTransaction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResponseModelApiTransaction
        /// class.
        /// </summary>
        public ResponseModelApiTransaction(ApiTransaction result = default(ApiTransaction), ErrorModel error = default(ErrorModel))
        {
            Result = result;
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Result")]
        public ApiTransaction Result { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Error")]
        public ErrorModel Error { get; set; }

    }
}
