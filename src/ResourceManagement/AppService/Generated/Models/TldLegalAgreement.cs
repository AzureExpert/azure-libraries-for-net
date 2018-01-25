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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Legal agreement for a top level domain.
    /// </summary>
    public partial class TldLegalAgreement
    {
        /// <summary>
        /// Initializes a new instance of the TldLegalAgreement class.
        /// </summary>
        public TldLegalAgreement()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TldLegalAgreement class.
        /// </summary>
        /// <param name="agreementKey">Unique identifier for the
        /// agreement.</param>
        /// <param name="title">Agreement title.</param>
        /// <param name="content">Agreement details.</param>
        /// <param name="url">URL where a copy of the agreement details is
        /// hosted.</param>
        public TldLegalAgreement(string agreementKey, string title, string content, string url = default(string))
        {
            AgreementKey = agreementKey;
            Title = title;
            Content = content;
            Url = url;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique identifier for the agreement.
        /// </summary>
        [JsonProperty(PropertyName = "agreementKey")]
        public string AgreementKey { get; set; }

        /// <summary>
        /// Gets or sets agreement title.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets agreement details.
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets URL where a copy of the agreement details is hosted.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AgreementKey == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AgreementKey");
            }
            if (Title == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Title");
            }
            if (Content == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Content");
            }
        }
    }
}
