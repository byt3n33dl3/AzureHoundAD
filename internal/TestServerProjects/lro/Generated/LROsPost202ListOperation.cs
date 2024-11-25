// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using lro.Models;

namespace lro
{
    /// <summary> Long running put request, service returns a 202 with empty body to first request, returns a 200 with body [{ 'id': '100', 'name': 'foo' }]. </summary>
    public partial class LROsPost202ListOperation : Operation<IReadOnlyList<Product>>, IOperationSource<IReadOnlyList<Product>>
    {
        private readonly OperationInternal<IReadOnlyList<Product>> _operation;

        /// <summary> Initializes a new instance of LROsPost202ListOperation for mocking. </summary>
        protected LROsPost202ListOperation()
        {
        }

        internal LROsPost202ListOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            IOperation<IReadOnlyList<Product>> nextLinkOperation = NextLinkOperationImplementation.Create(this, pipeline, request.Method, request.Uri.ToUri(), response, OperationFinalStateVia.Location);
            _operation = new OperationInternal<IReadOnlyList<Product>>(nextLinkOperation, clientDiagnostics, response, "LROsPost202ListOperation");
        }

        /// <inheritdoc />
#pragma warning disable CA1822
        public override string Id => throw new NotImplementedException();
#pragma warning restore CA1822

        /// <inheritdoc />
        public override IReadOnlyList<Product> Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.RawResponse;

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override Response<IReadOnlyList<Product>> WaitForCompletion(CancellationToken cancellationToken = default) => _operation.WaitForCompletion(cancellationToken);

        /// <inheritdoc />
        public override Response<IReadOnlyList<Product>> WaitForCompletion(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletion(pollingInterval, cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<IReadOnlyList<Product>>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<IReadOnlyList<Product>>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        IReadOnlyList<Product> IOperationSource<IReadOnlyList<Product>>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            List<Product> array = new List<Product>();
            foreach (var item in document.RootElement.EnumerateArray())
            {
                array.Add(Product.DeserializeProduct(item));
            }
            return array;
        }

        async ValueTask<IReadOnlyList<Product>> IOperationSource<IReadOnlyList<Product>>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            List<Product> array = new List<Product>();
            foreach (var item in document.RootElement.EnumerateArray())
            {
                array.Add(Product.DeserializeProduct(item));
            }
            return array;
        }
    }
}