// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace MgmtExactMatchInheritance
{
    /// <summary>
    /// A class representing a collection of <see cref="ExactMatchModel5Resource"/> and their operations.
    /// Each <see cref="ExactMatchModel5Resource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get an <see cref="ExactMatchModel5Collection"/> instance call the GetExactMatchModel5s method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class ExactMatchModel5Collection : ArmCollection, IEnumerable<ExactMatchModel5Resource>, IAsyncEnumerable<ExactMatchModel5Resource>
    {
        private readonly ClientDiagnostics _exactMatchModel5ClientDiagnostics;
        private readonly ExactMatchModel5SRestOperations _exactMatchModel5RestClient;

        /// <summary> Initializes a new instance of the <see cref="ExactMatchModel5Collection"/> class for mocking. </summary>
        protected ExactMatchModel5Collection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExactMatchModel5Collection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ExactMatchModel5Collection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _exactMatchModel5ClientDiagnostics = new ClientDiagnostics("MgmtExactMatchInheritance", ExactMatchModel5Resource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ExactMatchModel5Resource.ResourceType, out string exactMatchModel5ApiVersion);
            _exactMatchModel5RestClient = new ExactMatchModel5SRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, exactMatchModel5ApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel5s/{exactMatchModel5sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExactMatchModel5s_Put</description>
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
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="exactMatchModel5SName"> The <see cref="string"/> to use. </param>
        /// <param name="data"> The <see cref="ExactMatchModel5Data"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel5SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel5SName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ExactMatchModel5Resource>> CreateOrUpdateAsync(WaitUntil waitUntil, string exactMatchModel5SName, ExactMatchModel5Data data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel5SName, nameof(exactMatchModel5SName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _exactMatchModel5ClientDiagnostics.CreateScope("ExactMatchModel5Collection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _exactMatchModel5RestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel5SName, data, cancellationToken).ConfigureAwait(false);
                var uri = _exactMatchModel5RestClient.CreatePutRequestUri(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel5SName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new MgmtExactMatchInheritanceArmOperation<ExactMatchModel5Resource>(Response.FromValue(new ExactMatchModel5Resource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel5s/{exactMatchModel5sName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExactMatchModel5s_Put</description>
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
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="exactMatchModel5SName"> The <see cref="string"/> to use. </param>
        /// <param name="data"> The <see cref="ExactMatchModel5Data"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel5SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel5SName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ExactMatchModel5Resource> CreateOrUpdate(WaitUntil waitUntil, string exactMatchModel5SName, ExactMatchModel5Data data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel5SName, nameof(exactMatchModel5SName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _exactMatchModel5ClientDiagnostics.CreateScope("ExactMatchModel5Collection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _exactMatchModel5RestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel5SName, data, cancellationToken);
                var uri = _exactMatchModel5RestClient.CreatePutRequestUri(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel5SName, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new MgmtExactMatchInheritanceArmOperation<ExactMatchModel5Resource>(Response.FromValue(new ExactMatchModel5Resource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
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
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel5SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel5SName"/> is null. </exception>
        public virtual async Task<Response<ExactMatchModel5Resource>> GetAsync(string exactMatchModel5SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel5SName, nameof(exactMatchModel5SName));

            using var scope = _exactMatchModel5ClientDiagnostics.CreateScope("ExactMatchModel5Collection.Get");
            scope.Start();
            try
            {
                var response = await _exactMatchModel5RestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel5SName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExactMatchModel5Resource(Client, response.Value), response.GetRawResponse());
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
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel5SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel5SName"/> is null. </exception>
        public virtual Response<ExactMatchModel5Resource> Get(string exactMatchModel5SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel5SName, nameof(exactMatchModel5SName));

            using var scope = _exactMatchModel5ClientDiagnostics.CreateScope("ExactMatchModel5Collection.Get");
            scope.Start();
            try
            {
                var response = _exactMatchModel5RestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel5SName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExactMatchModel5Resource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel5s</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExactMatchModel5s_List</description>
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
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExactMatchModel5Resource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExactMatchModel5Resource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _exactMatchModel5RestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new ExactMatchModel5Resource(Client, ExactMatchModel5Data.DeserializeExactMatchModel5Data(e)), _exactMatchModel5ClientDiagnostics, Pipeline, "ExactMatchModel5Collection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel5s</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExactMatchModel5s_List</description>
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
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExactMatchModel5Resource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExactMatchModel5Resource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _exactMatchModel5RestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new ExactMatchModel5Resource(Client, ExactMatchModel5Data.DeserializeExactMatchModel5Data(e)), _exactMatchModel5ClientDiagnostics, Pipeline, "ExactMatchModel5Collection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
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
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel5SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel5SName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string exactMatchModel5SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel5SName, nameof(exactMatchModel5SName));

            using var scope = _exactMatchModel5ClientDiagnostics.CreateScope("ExactMatchModel5Collection.Exists");
            scope.Start();
            try
            {
                var response = await _exactMatchModel5RestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel5SName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
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
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel5SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel5SName"/> is null. </exception>
        public virtual Response<bool> Exists(string exactMatchModel5SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel5SName, nameof(exactMatchModel5SName));

            using var scope = _exactMatchModel5ClientDiagnostics.CreateScope("ExactMatchModel5Collection.Exists");
            scope.Start();
            try
            {
                var response = _exactMatchModel5RestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel5SName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
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
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel5SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel5SName"/> is null. </exception>
        public virtual async Task<NullableResponse<ExactMatchModel5Resource>> GetIfExistsAsync(string exactMatchModel5SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel5SName, nameof(exactMatchModel5SName));

            using var scope = _exactMatchModel5ClientDiagnostics.CreateScope("ExactMatchModel5Collection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _exactMatchModel5RestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel5SName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ExactMatchModel5Resource>(response.GetRawResponse());
                return Response.FromValue(new ExactMatchModel5Resource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
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
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel5SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel5SName"/> is null. </exception>
        public virtual NullableResponse<ExactMatchModel5Resource> GetIfExists(string exactMatchModel5SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel5SName, nameof(exactMatchModel5SName));

            using var scope = _exactMatchModel5ClientDiagnostics.CreateScope("ExactMatchModel5Collection.GetIfExists");
            scope.Start();
            try
            {
                var response = _exactMatchModel5RestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, exactMatchModel5SName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ExactMatchModel5Resource>(response.GetRawResponse());
                return Response.FromValue(new ExactMatchModel5Resource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExactMatchModel5Resource> IEnumerable<ExactMatchModel5Resource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExactMatchModel5Resource> IAsyncEnumerable<ExactMatchModel5Resource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}