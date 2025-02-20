// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.KeyVault.Models
{
    using System.Linq;

    /// <summary>
    /// SKU details
    /// </summary>
    public partial class ManagedHsmSku
    {
        /// <summary>
        /// Initializes a new instance of the ManagedHsmSku class.
        /// </summary>
        public ManagedHsmSku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedHsmSku class.
        /// </summary>

        /// <param name="name">SKU of the managed HSM Pool
        /// Possible values include: 'Standard_B1', 'Custom_B32'</param>
        public ManagedHsmSku(ManagedHsmSkuName name)

        {
            this.Name = name;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for ManagedHsmSku class.
        /// </summary>
        static ManagedHsmSku()
        {
            Family = "B";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets sKU of the managed HSM Pool Possible values include: &#39;Standard_B1&#39;, &#39;Custom_B32&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public ManagedHsmSkuName Name {get; set; }
        /// <summary>
        /// Gets or sets sKU Family of the managed HSM Pool
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "family")]
        public static string Family {get; private set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {


        }
    }
}