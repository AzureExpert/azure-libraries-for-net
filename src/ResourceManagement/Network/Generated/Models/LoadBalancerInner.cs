// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Network;
    using Microsoft.Azure.Management.Network.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// LoadBalancer resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class LoadBalancerInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the LoadBalancerInner class.
        /// </summary>
        public LoadBalancerInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LoadBalancerInner class.
        /// </summary>
        /// <param name="sku">The load balancer SKU.</param>
        /// <param name="frontendIPConfigurations">Object representing the
        /// frontend IPs to be used for the load balancer</param>
        /// <param name="backendAddressPools">Collection of backend address
        /// pools used by a load balancer</param>
        /// <param name="loadBalancingRules">Object collection representing the
        /// load balancing rules Gets the provisioning </param>
        /// <param name="probes">Collection of probe objects used in the load
        /// balancer</param>
        /// <param name="inboundNatRules">Collection of inbound NAT Rules used
        /// by a load balancer. Defining inbound NAT rules on your load
        /// balancer is mutually exclusive with defining an inbound NAT pool.
        /// Inbound NAT pools are referenced from virtual machine scale sets.
        /// NICs that are associated with individual virtual machines cannot
        /// reference an Inbound NAT pool. They have to reference individual
        /// inbound NAT rules.</param>
        /// <param name="inboundNatPools">Defines an external port range for
        /// inbound NAT to a single backend port on NICs associated with a load
        /// balancer. Inbound NAT rules are created automatically for each NIC
        /// associated with the Load Balancer using an external port from this
        /// range. Defining an Inbound NAT pool on your Load Balancer is
        /// mutually exclusive with defining inbound Nat rules. Inbound NAT
        /// pools are referenced from virtual machine scale sets. NICs that are
        /// associated with individual virtual machines cannot reference an
        /// inbound NAT pool. They have to reference individual inbound NAT
        /// rules.</param>
        /// <param name="outboundNatRules">The outbound NAT rules.</param>
        /// <param name="resourceGuid">The resource GUID property of the load
        /// balancer resource.</param>
        /// <param name="provisioningState">Gets the provisioning state of the
        /// PublicIP resource. Possible values are: 'Updating', 'Deleting', and
        /// 'Failed'.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="zones">A list of availability zones denoting the IP
        /// allocated for the resource needs to come from.</param>
        public LoadBalancerInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), LoadBalancerSku sku = default(LoadBalancerSku), IList<FrontendIPConfigurationInner> frontendIPConfigurations = default(IList<FrontendIPConfigurationInner>), IList<BackendAddressPoolInner> backendAddressPools = default(IList<BackendAddressPoolInner>), IList<LoadBalancingRuleInner> loadBalancingRules = default(IList<LoadBalancingRuleInner>), IList<ProbeInner> probes = default(IList<ProbeInner>), IList<InboundNatRuleInner> inboundNatRules = default(IList<InboundNatRuleInner>), IList<InboundNatPoolInner> inboundNatPools = default(IList<InboundNatPoolInner>), IList<OutboundNatRuleInner> outboundNatRules = default(IList<OutboundNatRuleInner>), string resourceGuid = default(string), string provisioningState = default(string), string etag = default(string), IList<string> zones = default(IList<string>))
            : base(location, id, name, type, tags)
        {
            Sku = sku;
            FrontendIPConfigurations = frontendIPConfigurations;
            BackendAddressPools = backendAddressPools;
            LoadBalancingRules = loadBalancingRules;
            Probes = probes;
            InboundNatRules = inboundNatRules;
            InboundNatPools = inboundNatPools;
            OutboundNatRules = outboundNatRules;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            Etag = etag;
            Zones = zones;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the load balancer SKU.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public LoadBalancerSku Sku { get; set; }

        /// <summary>
        /// Gets or sets object representing the frontend IPs to be used for
        /// the load balancer
        /// </summary>
        [JsonProperty(PropertyName = "properties.frontendIPConfigurations")]
        public IList<FrontendIPConfigurationInner> FrontendIPConfigurations { get; set; }

        /// <summary>
        /// Gets or sets collection of backend address pools used by a load
        /// balancer
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendAddressPools")]
        public IList<BackendAddressPoolInner> BackendAddressPools { get; set; }

        /// <summary>
        /// Gets or sets object collection representing the load balancing
        /// rules Gets the provisioning
        /// </summary>
        [JsonProperty(PropertyName = "properties.loadBalancingRules")]
        public IList<LoadBalancingRuleInner> LoadBalancingRules { get; set; }

        /// <summary>
        /// Gets or sets collection of probe objects used in the load balancer
        /// </summary>
        [JsonProperty(PropertyName = "properties.probes")]
        public IList<ProbeInner> Probes { get; set; }

        /// <summary>
        /// Gets or sets collection of inbound NAT Rules used by a load
        /// balancer. Defining inbound NAT rules on your load balancer is
        /// mutually exclusive with defining an inbound NAT pool. Inbound NAT
        /// pools are referenced from virtual machine scale sets. NICs that are
        /// associated with individual virtual machines cannot reference an
        /// Inbound NAT pool. They have to reference individual inbound NAT
        /// rules.
        /// </summary>
        [JsonProperty(PropertyName = "properties.inboundNatRules")]
        public IList<InboundNatRuleInner> InboundNatRules { get; set; }

        /// <summary>
        /// Gets or sets defines an external port range for inbound NAT to a
        /// single backend port on NICs associated with a load balancer.
        /// Inbound NAT rules are created automatically for each NIC associated
        /// with the Load Balancer using an external port from this range.
        /// Defining an Inbound NAT pool on your Load Balancer is mutually
        /// exclusive with defining inbound Nat rules. Inbound NAT pools are
        /// referenced from virtual machine scale sets. NICs that are
        /// associated with individual virtual machines cannot reference an
        /// inbound NAT pool. They have to reference individual inbound NAT
        /// rules.
        /// </summary>
        [JsonProperty(PropertyName = "properties.inboundNatPools")]
        public IList<InboundNatPoolInner> InboundNatPools { get; set; }

        /// <summary>
        /// Gets or sets the outbound NAT rules.
        /// </summary>
        [JsonProperty(PropertyName = "properties.outboundNatRules")]
        public IList<OutboundNatRuleInner> OutboundNatRules { get; set; }

        /// <summary>
        /// Gets or sets the resource GUID property of the load balancer
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; set; }

        /// <summary>
        /// Gets the provisioning state of the PublicIP resource. Possible
        /// values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets a list of availability zones denoting the IP allocated
        /// for the resource needs to come from.
        /// </summary>
        [JsonProperty(PropertyName = "zones")]
        public IList<string> Zones { get; set; }

    }
}
