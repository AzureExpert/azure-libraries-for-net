// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Batch.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Batch;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ApplicationOperations.
    /// </summary>
    public static partial class ApplicationOperationsExtensions
    {

        /// <summary>
        /// Adds an application to the specified Batch account.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the Batch account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Batch account.
        /// </param>
        /// <param name='applicationId'>
        /// The ID of the application.
        /// </param>
        /// <param name='parameters'>
        /// The parameters for the request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<ApplicationInner> CreateAsync(this IApplicationOperations operations, string resourceGroupName, string accountName, string applicationId, ApplicationCreateParametersInner parameters = default(ApplicationCreateParametersInner), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, accountName, applicationId, parameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }


        /// <summary>
        /// Deletes an application.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the Batch account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Batch account.
        /// </param>
        /// <param name='applicationId'>
        /// The ID of the application.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task DeleteAsync(this IApplicationOperations operations, string resourceGroupName, string accountName, string applicationId, CancellationToken cancellationToken = default(CancellationToken))
        {
            (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, applicationId, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }


        /// <summary>
        /// Gets information about the specified application.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the Batch account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Batch account.
        /// </param>
        /// <param name='applicationId'>
        /// The ID of the application.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<ApplicationInner> GetAsync(this IApplicationOperations operations, string resourceGroupName, string accountName, string applicationId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, applicationId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }


        /// <summary>
        /// Updates settings for the specified application.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the Batch account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Batch account.
        /// </param>
        /// <param name='applicationId'>
        /// The ID of the application.
        /// </param>
        /// <param name='parameters'>
        /// The parameters for the request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task UpdateAsync(this IApplicationOperations operations, string resourceGroupName, string accountName, string applicationId, ApplicationUpdateParametersInner parameters, CancellationToken cancellationToken = default(CancellationToken))
        {
            (await operations.UpdateWithHttpMessagesAsync(resourceGroupName, accountName, applicationId, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }


        /// <summary>
        /// Lists all of the applications in the specified account.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the Batch account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Batch account.
        /// </param>
        /// <param name='maxresults'>
        /// The maximum number of items to return in the response.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<ApplicationInner>> ListAsync(this IApplicationOperations operations, string resourceGroupName, string accountName, int? maxresults = default(int?), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, accountName, maxresults, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }


        /// <summary>
        /// Lists all of the applications in the specified account.
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
        public static async Task<IPage<ApplicationInner>> ListNextAsync(this IApplicationOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

    }
}
