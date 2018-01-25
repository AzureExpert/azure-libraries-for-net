// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.AppService;
    using Microsoft.Azure.Management.AppService.Fluent;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// String dictionary resource.
    /// </summary>
    public partial class ConnectionStringDictionaryInner : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionStringDictionaryInner
        /// class.
        /// </summary>
        public ConnectionStringDictionaryInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionStringDictionaryInner
        /// class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="properties">Connection strings.</param>
        public ConnectionStringDictionaryInner(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), IDictionary<string, ConnStringValueTypePair> properties = default(IDictionary<string, ConnStringValueTypePair>))
            : base(id, name, kind, type)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets connection strings.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, ConnStringValueTypePair> Properties { get; set; }

    }
}
