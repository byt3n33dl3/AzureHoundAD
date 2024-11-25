// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace MgmtExactMatchFlattenInheritance
{
    /// <summary>
    /// A Class representing a CustomModel2 along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="CustomModel2Resource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetCustomModel2Resource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource"/> using the GetCustomModel2 method.
    /// </summary>
    public partial class CustomModel2Resource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CustomModel2Resource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="name"> The name. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/customModel2s/{name}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _customModel2ClientDiagnostics;
        private readonly CustomModel2SRestOperations _customModel2RestClient;
        private readonly CustomModel2Data _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Compute/customModel2s";

        /// <summary> Initializes a new instance of the <see cref="CustomModel2Resource"/> class for mocking. </summary>
        protected CustomModel2Resource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CustomModel2Resource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CustomModel2Resource(ArmClient client, CustomModel2Data data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="CustomModel2Resource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CustomModel2Resource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _customModel2ClientDiagnostics = new ClientDiagnostics("MgmtExactMatchFlattenInheritance", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string customModel2ApiVersion);
            _customModel2RestClient = new CustomModel2SRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, customModel2ApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CustomModel2Data Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get an CustomModel2.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/customModel2s/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomModel2s_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CustomModel2Resource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CustomModel2Resource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _customModel2ClientDiagnostics.CreateScope("CustomModel2Resource.Get");
            scope.Start();
            try
            {
                var response = await _customModel2RestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CustomModel2Resource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an CustomModel2.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/customModel2s/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomModel2s_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CustomModel2Resource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CustomModel2Resource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _customModel2ClientDiagnostics.CreateScope("CustomModel2Resource.Get");
            scope.Start();
            try
            {
                var response = _customModel2RestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CustomModel2Resource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update an CustomModel2.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/customModel2s/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomModel2s_Put</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CustomModel2Resource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="foo"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<CustomModel2Resource>> UpdateAsync(WaitUntil waitUntil, string foo = null, CancellationToken cancellationToken = default)
        {
            using var scope = _customModel2ClientDiagnostics.CreateScope("CustomModel2Resource.Update");
            scope.Start();
            try
            {
                var response = await _customModel2RestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, foo, cancellationToken).ConfigureAwait(false);
                var uri = _customModel2RestClient.CreatePutRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, foo);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new MgmtExactMatchFlattenInheritanceArmOperation<CustomModel2Resource>(Response.FromValue(new CustomModel2Resource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Create or update an CustomModel2.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/customModel2s/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CustomModel2s_Put</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CustomModel2Resource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="foo"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<CustomModel2Resource> Update(WaitUntil waitUntil, string foo = null, CancellationToken cancellationToken = default)
        {
            using var scope = _customModel2ClientDiagnostics.CreateScope("CustomModel2Resource.Update");
            scope.Start();
            try
            {
                var response = _customModel2RestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, foo, cancellationToken);
                var uri = _customModel2RestClient.CreatePutRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, foo);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new MgmtExactMatchFlattenInheritanceArmOperation<CustomModel2Resource>(Response.FromValue(new CustomModel2Resource(Client, response), response.GetRawResponse()), rehydrationToken);
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
    }
}