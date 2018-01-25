// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Cdn;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ProfilesOperations.
    /// </summary>
    public static partial class ProfilesOperationsExtensions
    {

        /// <summary>
        /// Lists all of the CDN profiles within an Azure subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<ProfileInner>> ListAsync(this IProfilesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }


        /// <summary>
        /// Lists all of the CDN profiles within a resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<ProfileInner>> ListByResourceGroupAsync(this IProfilesOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }


        /// <summary>
        /// Gets a CDN profile with the specified profile name under the specified
        /// subscription and resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// Name of the CDN profile which is unique within the resource group.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<ProfileInner> GetAsync(this IProfilesOperations operations, string resourceGroupName, string profileName, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, profileName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }


        /// <summary>
        /// Creates a new CDN profile with a profile name under the specified
        /// subscription and resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// Name of the CDN profile which is unique within the resource group.
        /// </param>
        /// <param name='profile'>
        /// Profile properties needed to create a new profile.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<ProfileInner> CreateAsync(this IProfilesOperations operations, string resourceGroupName, string profileName, ProfileInner profile, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, profileName, profile, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }


        /// <summary>
        /// Updates an existing CDN profile with the specified profile name under the
        /// specified subscription and resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// Name of the CDN profile which is unique within the resource group.
        /// </param>
        /// <param name='tags'>
        /// Profile tags
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<ProfileInner> UpdateAsync(this IProfilesOperations operations, string resourceGroupName, string profileName, IDictionary<string, string> tags, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, profileName, tags, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }


        /// <summary>
        /// Deletes an existing CDN profile with the specified parameters. Deleting a
        /// profile will result in the deletion of all of the sub-resources including
        /// endpoints, origins and custom domains.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// Name of the CDN profile which is unique within the resource group.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task DeleteAsync(this IProfilesOperations operations, string resourceGroupName, string profileName, CancellationToken cancellationToken = default(CancellationToken))
        {
            (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, profileName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }


        /// <summary>
        /// Generates a dynamic SSO URI used to sign in to the CDN supplemental portal.
        /// Supplemnetal portal is used to configure advanced feature capabilities that
        /// are not yet available in the Azure portal, such as core reports in a
        /// standard profile; rules engine, advanced HTTP reports, and real-time stats
        /// and alerts in a premium profile. The SSO URI changes approximately every 10
        /// minutes.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// Name of the CDN profile which is unique within the resource group.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<SsoUriInner> GenerateSsoUriAsync(this IProfilesOperations operations, string resourceGroupName, string profileName, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GenerateSsoUriWithHttpMessagesAsync(resourceGroupName, profileName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }


        /// <summary>
        /// Checks the quota and actual usage of endpoints under the given CDN profile.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// Name of the CDN profile which is unique within the resource group.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<ResourceUsageInner>> ListResourceUsageAsync(this IProfilesOperations operations, string resourceGroupName, string profileName, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ListResourceUsageWithHttpMessagesAsync(resourceGroupName, profileName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }


        /// <summary>
        /// Creates a new CDN profile with a profile name under the specified
        /// subscription and resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// Name of the CDN profile which is unique within the resource group.
        /// </param>
        /// <param name='profile'>
        /// Profile properties needed to create a new profile.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<ProfileInner> BeginCreateAsync(this IProfilesOperations operations, string resourceGroupName, string profileName, ProfileInner profile, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, profileName, profile, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }


        /// <summary>
        /// Updates an existing CDN profile with the specified profile name under the
        /// specified subscription and resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// Name of the CDN profile which is unique within the resource group.
        /// </param>
        /// <param name='tags'>
        /// Profile tags
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<ProfileInner> BeginUpdateAsync(this IProfilesOperations operations, string resourceGroupName, string profileName, IDictionary<string, string> tags, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, profileName, tags, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }


        /// <summary>
        /// Deletes an existing CDN profile with the specified parameters. Deleting a
        /// profile will result in the deletion of all of the sub-resources including
        /// endpoints, origins and custom domains.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the Resource group within the Azure subscription.
        /// </param>
        /// <param name='profileName'>
        /// Name of the CDN profile which is unique within the resource group.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task BeginDeleteAsync(this IProfilesOperations operations, string resourceGroupName, string profileName, CancellationToken cancellationToken = default(CancellationToken))
        {
            (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, profileName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }


        /// <summary>
        /// Lists all of the CDN profiles within an Azure subscription.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<ProfileInner>> ListNextAsync(this IProfilesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }


        /// <summary>
        /// Lists all of the CDN profiles within a resource group.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<ProfileInner>> ListByResourceGroupNextAsync(this IProfilesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }


        /// <summary>
        /// Checks the quota and actual usage of endpoints under the given CDN profile.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<ResourceUsageInner>> ListResourceUsageNextAsync(this IProfilesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ListResourceUsageNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

    }
}
