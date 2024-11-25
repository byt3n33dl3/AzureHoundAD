// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using media_types.Models;

namespace media_types
{
    /// <summary> The MediaTypes service client. </summary>
    public partial class MediaTypesClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal MediaTypesRestClient RestClient { get; }

        /// <summary> Initializes a new instance of MediaTypesClient for mocking. </summary>
        protected MediaTypesClient()
        {
        }

        /// <summary> Initializes a new instance of MediaTypesClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal MediaTypesClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new MediaTypesRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Analyze body, that could be different media types. </summary>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="input"> Input parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<string>> AnalyzeBodyAsync(ContentType contentType, Stream input = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MediaTypesClient.AnalyzeBody");
            scope.Start();
            try
            {
                return await RestClient.AnalyzeBodyAsync(contentType, input, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Analyze body, that could be different media types. </summary>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="input"> Input parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<string> AnalyzeBody(ContentType contentType, Stream input = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MediaTypesClient.AnalyzeBody");
            scope.Start();
            try
            {
                return RestClient.AnalyzeBody(contentType, input, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Analyze body, that could be different media types. </summary>
        /// <param name="input"> Input parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<string>> AnalyzeBodyAsync(SourcePath input = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MediaTypesClient.AnalyzeBody");
            scope.Start();
            try
            {
                return await RestClient.AnalyzeBodyAsync(input, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Analyze body, that could be different media types. </summary>
        /// <param name="input"> Input parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<string> AnalyzeBody(SourcePath input = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MediaTypesClient.AnalyzeBody");
            scope.Start();
            try
            {
                return RestClient.AnalyzeBody(input, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Analyze body, that could be different media types. Adds to AnalyzeBody by not having an accept type. </summary>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="input"> Input parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> AnalyzeBodyNoAcceptHeaderAsync(ContentType contentType, Stream input = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MediaTypesClient.AnalyzeBodyNoAcceptHeader");
            scope.Start();
            try
            {
                return await RestClient.AnalyzeBodyNoAcceptHeaderAsync(contentType, input, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Analyze body, that could be different media types. Adds to AnalyzeBody by not having an accept type. </summary>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="input"> Input parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response AnalyzeBodyNoAcceptHeader(ContentType contentType, Stream input = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MediaTypesClient.AnalyzeBodyNoAcceptHeader");
            scope.Start();
            try
            {
                return RestClient.AnalyzeBodyNoAcceptHeader(contentType, input, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Analyze body, that could be different media types. Adds to AnalyzeBody by not having an accept type. </summary>
        /// <param name="input"> Input parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> AnalyzeBodyNoAcceptHeaderAsync(SourcePath input = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MediaTypesClient.AnalyzeBodyNoAcceptHeader");
            scope.Start();
            try
            {
                return await RestClient.AnalyzeBodyNoAcceptHeaderAsync(input, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Analyze body, that could be different media types. Adds to AnalyzeBody by not having an accept type. </summary>
        /// <param name="input"> Input parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response AnalyzeBodyNoAcceptHeader(SourcePath input = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MediaTypesClient.AnalyzeBodyNoAcceptHeader");
            scope.Start();
            try
            {
                return RestClient.AnalyzeBodyNoAcceptHeader(input, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Pass in contentType 'text/plain; charset=UTF-8' to pass test. Value for input does not matter. </summary>
        /// <param name="input"> Input parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<string>> ContentTypeWithEncodingAsync(string input = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MediaTypesClient.ContentTypeWithEncoding");
            scope.Start();
            try
            {
                return await RestClient.ContentTypeWithEncodingAsync(input, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Pass in contentType 'text/plain; charset=UTF-8' to pass test. Value for input does not matter. </summary>
        /// <param name="input"> Input parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<string> ContentTypeWithEncoding(string input = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MediaTypesClient.ContentTypeWithEncoding");
            scope.Start();
            try
            {
                return RestClient.ContentTypeWithEncoding(input, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Binary body with two content types. Pass in of {'hello': 'world'} for the application/json content type, and a byte stream of 'hello, world!' for application/octet-stream. </summary>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="message"> The payload body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<string>> BinaryBodyWithTwoContentTypesAsync(ContentType1 contentType, Stream message, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MediaTypesClient.BinaryBodyWithTwoContentTypes");
            scope.Start();
            try
            {
                return await RestClient.BinaryBodyWithTwoContentTypesAsync(contentType, message, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Binary body with two content types. Pass in of {'hello': 'world'} for the application/json content type, and a byte stream of 'hello, world!' for application/octet-stream. </summary>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="message"> The payload body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<string> BinaryBodyWithTwoContentTypes(ContentType1 contentType, Stream message, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MediaTypesClient.BinaryBodyWithTwoContentTypes");
            scope.Start();
            try
            {
                return RestClient.BinaryBodyWithTwoContentTypes(contentType, message, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Binary body with three content types. Pass in string 'hello, world' with content type 'text/plain', {'hello': world'} with content type 'application/json' and a byte string for 'application/octet-stream'. </summary>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="message"> The payload body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<string>> BinaryBodyWithThreeContentTypesAsync(ContentType2 contentType, Stream message, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MediaTypesClient.BinaryBodyWithThreeContentTypes");
            scope.Start();
            try
            {
                return await RestClient.BinaryBodyWithThreeContentTypesAsync(contentType, message, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Binary body with three content types. Pass in string 'hello, world' with content type 'text/plain', {'hello': world'} with content type 'application/json' and a byte string for 'application/octet-stream'. </summary>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="message"> The payload body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<string> BinaryBodyWithThreeContentTypes(ContentType2 contentType, Stream message, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MediaTypesClient.BinaryBodyWithThreeContentTypes");
            scope.Start();
            try
            {
                return RestClient.BinaryBodyWithThreeContentTypes(contentType, message, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Body with three types. Can be stream, string, or JSON. Pass in string 'hello, world' with content type 'text/plain', {'hello': world'} with content type 'application/json' and a byte string for 'application/octet-stream'. </summary>
        /// <param name="message"> The payload body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<string>> BodyThreeTypesAsync(Stream message, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MediaTypesClient.BodyThreeTypes");
            scope.Start();
            try
            {
                return await RestClient.BodyThreeTypesAsync(message, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Body with three types. Can be stream, string, or JSON. Pass in string 'hello, world' with content type 'text/plain', {'hello': world'} with content type 'application/json' and a byte string for 'application/octet-stream'. </summary>
        /// <param name="message"> The payload body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<string> BodyThreeTypes(Stream message, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MediaTypesClient.BodyThreeTypes");
            scope.Start();
            try
            {
                return RestClient.BodyThreeTypes(message, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Body with three types. Can be stream, string, or JSON. Pass in string 'hello, world' with content type 'text/plain', {'hello': world'} with content type 'application/json' and a byte string for 'application/octet-stream'. </summary>
        /// <param name="message"> The payload body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<string>> BodyThreeTypesAsync(string message, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MediaTypesClient.BodyThreeTypes");
            scope.Start();
            try
            {
                return await RestClient.BodyThreeTypesAsync(message, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Body with three types. Can be stream, string, or JSON. Pass in string 'hello, world' with content type 'text/plain', {'hello': world'} with content type 'application/json' and a byte string for 'application/octet-stream'. </summary>
        /// <param name="message"> The payload body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<string> BodyThreeTypes(string message, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MediaTypesClient.BodyThreeTypes");
            scope.Start();
            try
            {
                return RestClient.BodyThreeTypes(message, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Body with three types. Can be stream, string, or JSON. Pass in string 'hello, world' with content type 'text/plain', {'hello': world'} with content type 'application/json' and a byte string for 'application/octet-stream'. </summary>
        /// <param name="message"> The payload body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<string>> BodyThreeTypesAsync(object message, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MediaTypesClient.BodyThreeTypes");
            scope.Start();
            try
            {
                return await RestClient.BodyThreeTypesAsync(message, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Body with three types. Can be stream, string, or JSON. Pass in string 'hello, world' with content type 'text/plain', {'hello': world'} with content type 'application/json' and a byte string for 'application/octet-stream'. </summary>
        /// <param name="message"> The payload body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<string> BodyThreeTypes(object message, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MediaTypesClient.BodyThreeTypes");
            scope.Start();
            try
            {
                return RestClient.BodyThreeTypes(message, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Body that's either text/plain or application/json. </summary>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="message"> The payload body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<string>> PutTextAndJsonBodyAsync(ContentType3 contentType, string message, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MediaTypesClient.PutTextAndJsonBody");
            scope.Start();
            try
            {
                return await RestClient.PutTextAndJsonBodyAsync(contentType, message, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Body that's either text/plain or application/json. </summary>
        /// <param name="contentType"> Upload file type. </param>
        /// <param name="message"> The payload body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<string> PutTextAndJsonBody(ContentType3 contentType, string message, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MediaTypesClient.PutTextAndJsonBody");
            scope.Start();
            try
            {
                return RestClient.PutTextAndJsonBody(contentType, message, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}