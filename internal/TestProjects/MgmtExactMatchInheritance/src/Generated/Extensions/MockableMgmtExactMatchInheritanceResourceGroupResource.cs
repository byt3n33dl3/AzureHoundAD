// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using MgmtExactMatchInheritance.Models;

namespace MgmtExactMatchInheritance.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableMgmtExactMatchInheritanceResourceGroupResource : ArmResource
    {
        private ClientDiagnostics _exactMatchModel2sClientDiagnostics;
        private ExactMatchModel2SRestOperations _exactMatchModel2sRestClient;
        private ClientDiagnostics _exactMatchModel3sClientDiagnostics;
        private ExactMatchModel3SRestOperations _exactMatchModel3sRestClient;
        private ClientDiagnostics _exactMatchModel4sClientDiagnostics;
        private ExactMatchModel4SRestOperations _exactMatchModel4sRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableMgmtExactMatchInheritanceResourceGroupResource"/> class for mocking. </summary>
        protected MockableMgmtExactMatchInheritanceResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableMgmtExactMatchInheritanceResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableMgmtExactMatchInheritanceResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ExactMatchModel2sClientDiagnostics => _exactMatchModel2sClientDiagnostics ??= new ClientDiagnostics("MgmtExactMatchInheritance", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ExactMatchModel2SRestOperations ExactMatchModel2sRestClient => _exactMatchModel2sRestClient ??= new ExactMatchModel2SRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics ExactMatchModel3sClientDiagnostics => _exactMatchModel3sClientDiagnostics ??= new ClientDiagnostics("MgmtExactMatchInheritance", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ExactMatchModel3SRestOperations ExactMatchModel3sRestClient => _exactMatchModel3sRestClient ??= new ExactMatchModel3SRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics ExactMatchModel4sClientDiagnostics => _exactMatchModel4sClientDiagnostics ??= new ClientDiagnostics("MgmtExactMatchInheritance", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ExactMatchModel4SRestOperations ExactMatchModel4sRestClient => _exactMatchModel4sRestClient ??= new ExactMatchModel4SRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ExactMatchModel1Resources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ExactMatchModel1Resources and their operations over a ExactMatchModel1Resource. </returns>
        public virtual ExactMatchModel1Collection GetExactMatchModel1s()
        {
            return GetCachedClient(client => new ExactMatchModel1Collection(client, Id));
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel1s/{exactMatchModel1sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExactMatchModel1s_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExactMatchModel1Resource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exactMatchModel1SName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel1SName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel1SName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ExactMatchModel1Resource>> GetExactMatchModel1Async(string exactMatchModel1SName, CancellationToken cancellationToken = default)
        {
            return await GetExactMatchModel1s().GetAsync(exactMatchModel1SName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel1s/{exactMatchModel1sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExactMatchModel1s_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExactMatchModel1Resource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exactMatchModel1SName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel1SName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel1SName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ExactMatchModel1Resource> GetExactMatchModel1(string exactMatchModel1SName, CancellationToken cancellationToken = default)
        {
            return GetExactMatchModel1s().Get(exactMatchModel1SName, cancellationToken);
        }

        /// <summary> Gets a collection of ExactMatchModel5Resources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ExactMatchModel5Resources and their operations over a ExactMatchModel5Resource. </returns>
        public virtual ExactMatchModel5Collection GetExactMatchModel5s()
        {
            return GetCachedClient(client => new ExactMatchModel5Collection(client, Id));
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel5s/{exactMatchModel5sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExactMatchModel5s_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExactMatchModel5Resource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exactMatchModel5SName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel5SName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel5SName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ExactMatchModel5Resource>> GetExactMatchModel5Async(string exactMatchModel5SName, CancellationToken cancellationToken = default)
        {
            return await GetExactMatchModel5s().GetAsync(exactMatchModel5SName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel5s/{exactMatchModel5sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExactMatchModel5s_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExactMatchModel5Resource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exactMatchModel5SName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel5SName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel5SName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ExactMatchModel5Resource> GetExactMatchModel5(string exactMatchModel5SName, CancellationToken cancellationToken = default)
        {
            return GetExactMatchModel5s().Get(exactMatchModel5SName, cancellationToken);
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel2s/{exactMatchModel2sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExactMatchModel2s_Put</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exactMatchModel2SName"> The <see cref="string"/> to use. </param>
        /// <param name="exactMatchModel2"> The <see cref="ExactMatchModel2"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel2SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel2SName"/> or <paramref name="exactMatchModel2"/> is null. </exception>
        public virtual async Task<Response<ExactMatchModel2>> PutExactMatchModel2Async(string exactMatchModel2SName, ExactMatchModel2 exactMatchModel2, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel2SName, nameof(exactMatchModel2SName));
            Argument.AssertNotNull(exactMatchModel2, nameof(exactMatchModel2));

            using var scope = ExactMatchModel2sClientDiagnostics.CreateScope("MockableMgmtExactMatchInheritanceResourceGroupResource.PutExactMatchModel2");
            scope.Start();
            try
            {
                var response = await ExactMatchModel2sRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel2SName, exactMatchModel2, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel2s/{exactMatchModel2sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExactMatchModel2s_Put</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exactMatchModel2SName"> The <see cref="string"/> to use. </param>
        /// <param name="exactMatchModel2"> The <see cref="ExactMatchModel2"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel2SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel2SName"/> or <paramref name="exactMatchModel2"/> is null. </exception>
        public virtual Response<ExactMatchModel2> PutExactMatchModel2(string exactMatchModel2SName, ExactMatchModel2 exactMatchModel2, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel2SName, nameof(exactMatchModel2SName));
            Argument.AssertNotNull(exactMatchModel2, nameof(exactMatchModel2));

            using var scope = ExactMatchModel2sClientDiagnostics.CreateScope("MockableMgmtExactMatchInheritanceResourceGroupResource.PutExactMatchModel2");
            scope.Start();
            try
            {
                var response = ExactMatchModel2sRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel2SName, exactMatchModel2, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel3s</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExactMatchModel3s_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExactMatchModel3"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExactMatchModel3> GetExactMatchModel3sAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ExactMatchModel3sRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, ExactMatchModel3.DeserializeExactMatchModel3, ExactMatchModel3sClientDiagnostics, Pipeline, "MockableMgmtExactMatchInheritanceResourceGroupResource.GetExactMatchModel3s", "value", null, cancellationToken);
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel3s</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExactMatchModel3s_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExactMatchModel3"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExactMatchModel3> GetExactMatchModel3s(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ExactMatchModel3sRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, ExactMatchModel3.DeserializeExactMatchModel3, ExactMatchModel3sClientDiagnostics, Pipeline, "MockableMgmtExactMatchInheritanceResourceGroupResource.GetExactMatchModel3s", "value", null, cancellationToken);
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel3s/{exactMatchModel3sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExactMatchModel3s_Put</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exactMatchModel3SName"> The <see cref="string"/> to use. </param>
        /// <param name="exactMatchModel3"> The <see cref="ExactMatchModel3"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel3SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel3SName"/> or <paramref name="exactMatchModel3"/> is null. </exception>
        public virtual async Task<Response<ExactMatchModel3>> PutExactMatchModel3Async(string exactMatchModel3SName, ExactMatchModel3 exactMatchModel3, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel3SName, nameof(exactMatchModel3SName));
            Argument.AssertNotNull(exactMatchModel3, nameof(exactMatchModel3));

            using var scope = ExactMatchModel3sClientDiagnostics.CreateScope("MockableMgmtExactMatchInheritanceResourceGroupResource.PutExactMatchModel3");
            scope.Start();
            try
            {
                var response = await ExactMatchModel3sRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel3SName, exactMatchModel3, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel3s/{exactMatchModel3sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExactMatchModel3s_Put</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exactMatchModel3SName"> The <see cref="string"/> to use. </param>
        /// <param name="exactMatchModel3"> The <see cref="ExactMatchModel3"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel3SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel3SName"/> or <paramref name="exactMatchModel3"/> is null. </exception>
        public virtual Response<ExactMatchModel3> PutExactMatchModel3(string exactMatchModel3SName, ExactMatchModel3 exactMatchModel3, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel3SName, nameof(exactMatchModel3SName));
            Argument.AssertNotNull(exactMatchModel3, nameof(exactMatchModel3));

            using var scope = ExactMatchModel3sClientDiagnostics.CreateScope("MockableMgmtExactMatchInheritanceResourceGroupResource.PutExactMatchModel3");
            scope.Start();
            try
            {
                var response = ExactMatchModel3sRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel3SName, exactMatchModel3, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel3s/{exactMatchModel3sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExactMatchModel3s_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exactMatchModel3SName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel3SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel3SName"/> is null. </exception>
        public virtual async Task<Response<ExactMatchModel3>> GetExactMatchModel3Async(string exactMatchModel3SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel3SName, nameof(exactMatchModel3SName));

            using var scope = ExactMatchModel3sClientDiagnostics.CreateScope("MockableMgmtExactMatchInheritanceResourceGroupResource.GetExactMatchModel3");
            scope.Start();
            try
            {
                var response = await ExactMatchModel3sRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel3SName, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel3s/{exactMatchModel3sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExactMatchModel3s_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exactMatchModel3SName"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel3SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel3SName"/> is null. </exception>
        public virtual Response<ExactMatchModel3> GetExactMatchModel3(string exactMatchModel3SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel3SName, nameof(exactMatchModel3SName));

            using var scope = ExactMatchModel3sClientDiagnostics.CreateScope("MockableMgmtExactMatchInheritanceResourceGroupResource.GetExactMatchModel3");
            scope.Start();
            try
            {
                var response = ExactMatchModel3sRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel3SName, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel4s/{exactMatchModel4sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExactMatchModel4s_Put</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exactMatchModel4SName"> The <see cref="string"/> to use. </param>
        /// <param name="exactMatchModel4"> The <see cref="ExactMatchModel4"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel4SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel4SName"/> or <paramref name="exactMatchModel4"/> is null. </exception>
        public virtual async Task<Response<ExactMatchModel4>> PutExactMatchModel4Async(string exactMatchModel4SName, ExactMatchModel4 exactMatchModel4, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel4SName, nameof(exactMatchModel4SName));
            Argument.AssertNotNull(exactMatchModel4, nameof(exactMatchModel4));

            using var scope = ExactMatchModel4sClientDiagnostics.CreateScope("MockableMgmtExactMatchInheritanceResourceGroupResource.PutExactMatchModel4");
            scope.Start();
            try
            {
                var response = await ExactMatchModel4sRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel4SName, exactMatchModel4, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel4s/{exactMatchModel4sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExactMatchModel4s_Put</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="exactMatchModel4SName"> The <see cref="string"/> to use. </param>
        /// <param name="exactMatchModel4"> The <see cref="ExactMatchModel4"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel4SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel4SName"/> or <paramref name="exactMatchModel4"/> is null. </exception>
        public virtual Response<ExactMatchModel4> PutExactMatchModel4(string exactMatchModel4SName, ExactMatchModel4 exactMatchModel4, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel4SName, nameof(exactMatchModel4SName));
            Argument.AssertNotNull(exactMatchModel4, nameof(exactMatchModel4));

            using var scope = ExactMatchModel4sClientDiagnostics.CreateScope("MockableMgmtExactMatchInheritanceResourceGroupResource.PutExactMatchModel4");
            scope.Start();
            try
            {
                var response = ExactMatchModel4sRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel4SName, exactMatchModel4, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
