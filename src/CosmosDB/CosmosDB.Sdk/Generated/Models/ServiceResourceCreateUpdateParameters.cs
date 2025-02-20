// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using System.Linq;

    /// <summary>
    /// Parameters for Create or Update Request for ServiceResource
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ServiceResourceCreateUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the ServiceResourceCreateUpdateParameters class.
        /// </summary>
        public ServiceResourceCreateUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceResourceCreateUpdateParameters class.
        /// </summary>

        /// <param name="serviceType">ServiceType for the service.
        /// Possible values include: 'SqlDedicatedGateway', 'DataTransfer',
        /// 'GraphAPICompute', 'MaterializedViewsBuilder'</param>

        /// <param name="instanceSize">Instance type for the service.
        /// Possible values include: 'Cosmos.D4s', 'Cosmos.D8s', 'Cosmos.D16s'</param>

        /// <param name="instanceCount">Instance count for the service.
        /// </param>
        public ServiceResourceCreateUpdateParameters(string serviceType = default(string), string instanceSize = default(string), int? instanceCount = default(int?))

        {
            this.ServiceType = serviceType;
            this.InstanceSize = instanceSize;
            this.InstanceCount = instanceCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets serviceType for the service. Possible values include: &#39;SqlDedicatedGateway&#39;, &#39;DataTransfer&#39;, &#39;GraphAPICompute&#39;, &#39;MaterializedViewsBuilder&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.serviceType")]
        public string ServiceType {get; set; }

        /// <summary>
        /// Gets or sets instance type for the service. Possible values include: &#39;Cosmos.D4s&#39;, &#39;Cosmos.D8s&#39;, &#39;Cosmos.D16s&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.instanceSize")]
        public string InstanceSize {get; set; }

        /// <summary>
        /// Gets or sets instance count for the service.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.instanceCount")]
        public int? InstanceCount {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {


            if (this.InstanceCount != null)
            {
                if (this.InstanceCount < 0)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMinimum, "InstanceCount", 0);
                }
            }
        }
    }
}