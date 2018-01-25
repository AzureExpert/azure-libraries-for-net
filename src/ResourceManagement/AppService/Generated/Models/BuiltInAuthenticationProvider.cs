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
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for BuiltInAuthenticationProvider.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BuiltInAuthenticationProvider
    {
        [EnumMember(Value = "AzureActiveDirectory")]
        AzureActiveDirectory,
        [EnumMember(Value = "Facebook")]
        Facebook,
        [EnumMember(Value = "Google")]
        Google,
        [EnumMember(Value = "MicrosoftAccount")]
        MicrosoftAccount,
        [EnumMember(Value = "Twitter")]
        Twitter
    }
    internal static class BuiltInAuthenticationProviderEnumExtension
    {
        internal static string ToSerializedValue(this BuiltInAuthenticationProvider? value) =>
            value == null ? null : ((BuiltInAuthenticationProvider)value).ToSerializedValue();

        internal static string ToSerializedValue(this BuiltInAuthenticationProvider value)
        {
            switch (value)
            {
                case BuiltInAuthenticationProvider.AzureActiveDirectory:
                    return "AzureActiveDirectory";
                case BuiltInAuthenticationProvider.Facebook:
                    return "Facebook";
                case BuiltInAuthenticationProvider.Google:
                    return "Google";
                case BuiltInAuthenticationProvider.MicrosoftAccount:
                    return "MicrosoftAccount";
                case BuiltInAuthenticationProvider.Twitter:
                    return "Twitter";
            }
            return null;
        }

        internal static BuiltInAuthenticationProvider? ParseBuiltInAuthenticationProvider(this string value)
        {
            switch (value)
            {
                case "AzureActiveDirectory":
                    return BuiltInAuthenticationProvider.AzureActiveDirectory;
                case "Facebook":
                    return BuiltInAuthenticationProvider.Facebook;
                case "Google":
                    return BuiltInAuthenticationProvider.Google;
                case "MicrosoftAccount":
                    return BuiltInAuthenticationProvider.MicrosoftAccount;
                case "Twitter":
                    return BuiltInAuthenticationProvider.Twitter;
            }
            return null;
        }
    }
}
