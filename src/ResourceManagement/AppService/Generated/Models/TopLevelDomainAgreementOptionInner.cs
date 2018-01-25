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
    using System.Linq;

    /// <summary>
    /// Options for retrieving the list of top level domain legal agreements.
    /// </summary>
    public partial class TopLevelDomainAgreementOptionInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// TopLevelDomainAgreementOptionInner class.
        /// </summary>
        public TopLevelDomainAgreementOptionInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// TopLevelDomainAgreementOptionInner class.
        /// </summary>
        /// <param name="includePrivacy">If &lt;code&gt;true&lt;/code&gt;, then
        /// the list of agreements will include agreements for domain privacy
        /// as well; otherwise, &lt;code&gt;false&lt;/code&gt;.</param>
        /// <param name="forTransfer">If &lt;code&gt;true&lt;/code&gt;, then
        /// the list of agreements will include agreements for domain transfer
        /// as well; otherwise, &lt;code&gt;false&lt;/code&gt;.</param>
        public TopLevelDomainAgreementOptionInner(bool? includePrivacy = default(bool?), bool? forTransfer = default(bool?))
        {
            IncludePrivacy = includePrivacy;
            ForTransfer = forTransfer;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets if &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt;, then
        /// the list of agreements will include agreements for domain privacy
        /// as well; otherwise, &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "includePrivacy")]
        public bool? IncludePrivacy { get; set; }

        /// <summary>
        /// Gets or sets if &amp;lt;code&amp;gt;true&amp;lt;/code&amp;gt;, then
        /// the list of agreements will include agreements for domain transfer
        /// as well; otherwise, &amp;lt;code&amp;gt;false&amp;lt;/code&amp;gt;.
        /// </summary>
        [JsonProperty(PropertyName = "forTransfer")]
        public bool? ForTransfer { get; set; }

    }
}
