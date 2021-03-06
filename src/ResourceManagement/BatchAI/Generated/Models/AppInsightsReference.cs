// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Specifies Azure Application Insights information for performance
    /// counters reporting.
    /// </summary>
    public partial class AppInsightsReference
    {
        /// <summary>
        /// Initializes a new instance of the AppInsightsReference class.
        /// </summary>
        public AppInsightsReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AppInsightsReference class.
        /// </summary>
        /// <param name="component">Specifies the Azure Application Insights
        /// component resource id.</param>
        /// <param name="instrumentationKey">Value of the Azure Application
        /// Insights instrumentation key.</param>
        /// <param name="instrumentationKeySecretReference">Specifies a
        /// KeyVault Secret containing Azure Application Insights
        /// instrumentation key.</param>
        public AppInsightsReference(ResourceId component, string instrumentationKey = default(string), KeyVaultSecretReference instrumentationKeySecretReference = default(KeyVaultSecretReference))
        {
            Component = component;
            InstrumentationKey = instrumentationKey;
            InstrumentationKeySecretReference = instrumentationKeySecretReference;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the Azure Application Insights component
        /// resource id.
        /// </summary>
        [JsonProperty(PropertyName = "component")]
        public ResourceId Component { get; set; }

        /// <summary>
        /// Gets or sets value of the Azure Application Insights
        /// instrumentation key.
        /// </summary>
        [JsonProperty(PropertyName = "instrumentationKey")]
        public string InstrumentationKey { get; set; }

        /// <summary>
        /// Gets or sets specifies a KeyVault Secret containing Azure
        /// Application Insights instrumentation key.
        /// </summary>
        /// <remarks>
        /// Specifies KeyVault Store and Secret which contains Azure
        /// Application Insights instrumentation key. One of instumentationKey
        /// or instrumentationKeySecretReference must be specified.
        /// </remarks>
        [JsonProperty(PropertyName = "instrumentationKeySecretReference")]
        public KeyVaultSecretReference InstrumentationKeySecretReference { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Component == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Component");
            }
            if (Component != null)
            {
                Component.Validate();
            }
            if (InstrumentationKeySecretReference != null)
            {
                InstrumentationKeySecretReference.Validate();
            }
        }
    }
}
