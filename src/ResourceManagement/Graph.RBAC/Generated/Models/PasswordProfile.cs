// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Graph.RBAC.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Graph;
    using Microsoft.Azure.Management.Graph.RBAC;
    using Microsoft.Azure.Management.Graph.RBAC.Fluent;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The password profile associated with a user.
    /// </summary>
    public partial class PasswordProfile
    {
        /// <summary>
        /// Initializes a new instance of the PasswordProfile class.
        /// </summary>
        public PasswordProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PasswordProfile class.
        /// </summary>
        /// <param name="password">Password</param>
        /// <param name="forceChangePasswordNextLogin">Whether to force a
        /// password change on next login.</param>
        public PasswordProfile(string password, bool? forceChangePasswordNextLogin = default(bool?))
        {
            Password = password;
            ForceChangePasswordNextLogin = forceChangePasswordNextLogin;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets password
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets whether to force a password change on next login.
        /// </summary>
        [JsonProperty(PropertyName = "forceChangePasswordNextLogin")]
        public bool? ForceChangePasswordNextLogin { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Password == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Password");
            }
        }
    }
}
