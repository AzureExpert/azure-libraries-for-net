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
    /// Value of resource metric.
    /// </summary>
    public partial class ResourceMetricValue
    {
        /// <summary>
        /// Initializes a new instance of the ResourceMetricValue class.
        /// </summary>
        public ResourceMetricValue()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceMetricValue class.
        /// </summary>
        /// <param name="timestamp">Value timestamp.</param>
        /// <param name="average">Value average.</param>
        /// <param name="minimum">Value minimum.</param>
        /// <param name="maximum">Value maximum.</param>
        /// <param name="total">Value total.</param>
        /// <param name="count">Value count.</param>
        /// <param name="properties">Properties.</param>
        public ResourceMetricValue(string timestamp = default(string), double? average = default(double?), double? minimum = default(double?), double? maximum = default(double?), double? total = default(double?), double? count = default(double?), IList<ResourceMetricProperty> properties = default(IList<ResourceMetricProperty>))
        {
            Timestamp = timestamp;
            Average = average;
            Minimum = minimum;
            Maximum = maximum;
            Total = total;
            Count = count;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets value timestamp.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public string Timestamp { get; private set; }

        /// <summary>
        /// Gets value average.
        /// </summary>
        [JsonProperty(PropertyName = "average")]
        public double? Average { get; private set; }

        /// <summary>
        /// Gets value minimum.
        /// </summary>
        [JsonProperty(PropertyName = "minimum")]
        public double? Minimum { get; private set; }

        /// <summary>
        /// Gets value maximum.
        /// </summary>
        [JsonProperty(PropertyName = "maximum")]
        public double? Maximum { get; private set; }

        /// <summary>
        /// Gets value total.
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public double? Total { get; private set; }

        /// <summary>
        /// Gets value count.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public double? Count { get; private set; }

        /// <summary>
        /// Gets properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IList<ResourceMetricProperty> Properties { get; private set; }

    }
}
