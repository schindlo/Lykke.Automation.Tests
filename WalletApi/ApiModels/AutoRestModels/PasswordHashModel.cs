// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PasswordHashModel
    {
        /// <summary>
        /// Initializes a new instance of the PasswordHashModel class.
        /// </summary>
        public PasswordHashModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PasswordHashModel class.
        /// </summary>
        public PasswordHashModel(string pwdHash = default(string))
        {
            PwdHash = pwdHash;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PwdHash")]
        public string PwdHash { get; set; }

    }
}
