// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Batch.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Batch;
    using Microsoft.Azure.Management.Batch.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An application package which represents a particular version of an
    /// application.
    /// </summary>
    public partial class ApplicationPackageInner
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationPackageInner class.
        /// </summary>
        public ApplicationPackageInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationPackageInner class.
        /// </summary>
        /// <param name="id">The ID of the application.</param>
        /// <param name="version">The version of the application package.
        /// </param>
        /// <param name="state">The current state of the application package.
        /// Possible values include: 'pending', 'active', 'unmapped'</param>
        /// <param name="format">The format of the application package, if the
        /// package is active.</param>
        /// <param name="storageUrl">The URL for the application package in
        /// Azure Storage.</param>
        /// <param name="storageUrlExpiry">The UTC time at which the Azure
        /// Storage URL will expire.</param>
        /// <param name="lastActivationTime">The time at which the package was
        /// last activated, if the package is active.</param>
        public ApplicationPackageInner(string id = default(string), string version = default(string), PackageState? state = default(PackageState?), string format = default(string), string storageUrl = default(string), System.DateTime? storageUrlExpiry = default(System.DateTime?), System.DateTime? lastActivationTime = default(System.DateTime?))
        {
            Id = id;
            Version = version;
            State = state;
            Format = format;
            StorageUrl = storageUrl;
            StorageUrlExpiry = storageUrlExpiry;
            LastActivationTime = lastActivationTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the ID of the application.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the version of the application package.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; private set; }

        /// <summary>
        /// Gets the current state of the application package. Possible values
        /// include: 'pending', 'active', 'unmapped'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public PackageState? State { get; private set; }

        /// <summary>
        /// Gets the format of the application package, if the package is
        /// active.
        /// </summary>
        [JsonProperty(PropertyName = "format")]
        public string Format { get; private set; }

        /// <summary>
        /// Gets the URL for the application package in Azure Storage.
        /// </summary>
        [JsonProperty(PropertyName = "storageUrl")]
        public string StorageUrl { get; private set; }

        /// <summary>
        /// Gets the UTC time at which the Azure Storage URL will expire.
        /// </summary>
        [JsonProperty(PropertyName = "storageUrlExpiry")]
        public System.DateTime? StorageUrlExpiry { get; private set; }

        /// <summary>
        /// Gets the time at which the package was last activated, if the
        /// package is active.
        /// </summary>
        [JsonProperty(PropertyName = "lastActivationTime")]
        public System.DateTime? LastActivationTime { get; private set; }

    }
}
