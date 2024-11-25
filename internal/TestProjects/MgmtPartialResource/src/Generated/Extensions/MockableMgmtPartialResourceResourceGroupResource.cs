// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace MgmtPartialResource.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableMgmtPartialResourceResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableMgmtPartialResourceResourceGroupResource"/> class for mocking. </summary>
        protected MockableMgmtPartialResourceResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableMgmtPartialResourceResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableMgmtPartialResourceResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of PublicIPAddressResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of PublicIPAddressResources and their operations over a PublicIPAddressResource. </returns>
        public virtual PublicIPAddressCollection GetPublicIPAddresses()
        {
            return GetCachedClient(client => new PublicIPAddressCollection(client, Id));
        }

        /// <summary>
        /// Gets the specified public IP address in a specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPAddresses/{publicIpAddressName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublicIPAddresses_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PublicIPAddressResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publicIPAddressName"> The name of the public IP address. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIPAddressName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="publicIPAddressName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<PublicIPAddressResource>> GetPublicIPAddressAsync(string publicIPAddressName, string expand = null, CancellationToken cancellationToken = default)
        {
            return await GetPublicIPAddresses().GetAsync(publicIPAddressName, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified public IP address in a specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPAddresses/{publicIpAddressName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublicIPAddresses_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PublicIPAddressResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publicIPAddressName"> The name of the public IP address. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="publicIPAddressName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="publicIPAddressName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<PublicIPAddressResource> GetPublicIPAddress(string publicIPAddressName, string expand = null, CancellationToken cancellationToken = default)
        {
            return GetPublicIPAddresses().Get(publicIPAddressName, expand, cancellationToken);
        }
    }
}