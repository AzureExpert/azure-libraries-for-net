// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VirtualMachineScaleSetVMsOperations.
    /// </summary>
    public static partial class VirtualMachineScaleSetVMsOperationsExtensions
    {
        /// <summary>
        /// Reimages (upgrade the operating system) a specific virtual machine in a VM
        /// scale set.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance ID of the virtual machine.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> ReimageAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ReimageWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Allows you to re-image all the disks ( including data disks ) in the a VM
        /// scale set instance. This operation is only supported for managed disks.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance ID of the virtual machine.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> ReimageAllAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ReimageAllWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Deallocates a specific virtual machine in a VM scale set. Shuts down the
        /// virtual machine and releases the compute resources it uses. You are not
        /// billed for the compute resources of this virtual machine once it is
        /// deallocated.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance ID of the virtual machine.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> DeallocateAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.DeallocateWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Deletes a virtual machine from a VM scale set.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance ID of the virtual machine.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> DeleteAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Gets a virtual machine from a VM scale set.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance ID of the virtual machine.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<VirtualMachineScaleSetVMInner> GetAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Gets the status of a virtual machine from a VM scale set.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance ID of the virtual machine.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<VirtualMachineScaleSetVMInstanceViewInner> GetInstanceViewAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetInstanceViewWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Gets a list of all virtual machines in a VM scale sets.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='virtualMachineScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='select'>
        /// The list parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IPage<VirtualMachineScaleSetVMInner>> ListAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string virtualMachineScaleSetName, ODataQuery<VirtualMachineScaleSetVMInner> odataQuery = default(ODataQuery<VirtualMachineScaleSetVMInner>), string select = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, virtualMachineScaleSetName, odataQuery, select, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Power off (stop) a virtual machine in a VM scale set. Note that resources
        /// are still attached and you are getting charged for the resources. Instead,
        /// use deallocate to release resources and avoid charges.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance ID of the virtual machine.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> PowerOffAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.PowerOffWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Restarts a virtual machine in a VM scale set.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance ID of the virtual machine.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> RestartAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.RestartWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Starts a virtual machine in a VM scale set.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance ID of the virtual machine.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> StartAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.StartWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Reimages (upgrade the operating system) a specific virtual machine in a VM
        /// scale set.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance ID of the virtual machine.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> BeginReimageAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.BeginReimageWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Allows you to re-image all the disks ( including data disks ) in the a VM
        /// scale set instance. This operation is only supported for managed disks.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance ID of the virtual machine.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> BeginReimageAllAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.BeginReimageAllWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Deallocates a specific virtual machine in a VM scale set. Shuts down the
        /// virtual machine and releases the compute resources it uses. You are not
        /// billed for the compute resources of this virtual machine once it is
        /// deallocated.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance ID of the virtual machine.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> BeginDeallocateAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.BeginDeallocateWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Deletes a virtual machine from a VM scale set.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance ID of the virtual machine.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> BeginDeleteAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Power off (stop) a virtual machine in a VM scale set. Note that resources
        /// are still attached and you are getting charged for the resources. Instead,
        /// use deallocate to release resources and avoid charges.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance ID of the virtual machine.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> BeginPowerOffAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.BeginPowerOffWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Restarts a virtual machine in a VM scale set.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance ID of the virtual machine.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> BeginRestartAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.BeginRestartWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Starts a virtual machine in a VM scale set.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the VM scale set.
        /// </param>
        /// <param name='instanceId'>
        /// The instance ID of the virtual machine.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<OperationStatusResponseInner> BeginStartAsync(this IVirtualMachineScaleSetVMsOperations operations, string resourceGroupName, string vmScaleSetName, string instanceId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.BeginStartWithHttpMessagesAsync(resourceGroupName, vmScaleSetName, instanceId, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Gets a list of all virtual machines in a VM scale sets.
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
        public static async Task<IPage<VirtualMachineScaleSetVMInner>> ListNextAsync(this IVirtualMachineScaleSetVMsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

    }
}
