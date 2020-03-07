// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Network.Management.Interface.Models
{
    /// <summary> Properties of the private link service. </summary>
    public partial class PrivateLinkServiceProperties
    {
        /// <summary> An array of references to the load balancer IP configurations. </summary>
        public ICollection<FrontendIPConfiguration> LoadBalancerFrontendIpConfigurations { get; set; }
        /// <summary> An array of private link service IP configurations. </summary>
        public ICollection<PrivateLinkServiceIpConfiguration> IpConfigurations { get; set; }
        /// <summary> An array of references to the network interfaces created for this private link service. </summary>
        public ICollection<NetworkInterface> NetworkInterfaces { get; internal set; }
        /// <summary> The provisioning state of the private link service resource. </summary>
        public ProvisioningState? ProvisioningState { get; internal set; }
        /// <summary> An array of list about connections to the private endpoint. </summary>
        public ICollection<PrivateEndpointConnection> PrivateEndpointConnections { get; internal set; }
        /// <summary> The visibility list of the private link service. </summary>
        public PrivateLinkServicePropertiesVisibility Visibility { get; set; }
        /// <summary> The auto-approval list of the private link service. </summary>
        public PrivateLinkServicePropertiesAutoApproval AutoApproval { get; set; }
        /// <summary> The list of Fqdn. </summary>
        public ICollection<string> Fqdns { get; set; }
        /// <summary> The alias of the private link service. </summary>
        public string Alias { get; internal set; }
        /// <summary> Whether the private link service is enabled for proxy protocol or not. </summary>
        public bool? EnableProxyProtocol { get; set; }
    }
}