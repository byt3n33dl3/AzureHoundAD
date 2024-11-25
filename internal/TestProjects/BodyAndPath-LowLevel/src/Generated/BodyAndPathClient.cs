// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace BodyAndPath_LowLevel
{
    // Data plane generated client.
    /// <summary> The BodyAndPath service client. </summary>
    public partial class BodyAndPathClient
    {
        private const string AuthorizationHeader = "Fake-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of BodyAndPathClient for mocking. </summary>
        protected BodyAndPathClient()
        {
        }

        /// <summary> Initializes a new instance of BodyAndPathClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> is null. </exception>
        public BodyAndPathClient(AzureKeyCredential credential) : this(new Uri("http://localhost:3000"), credential, new BodyAndPathClientOptions())
        {
        }

        /// <summary> Initializes a new instance of BodyAndPathClient. </summary>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public BodyAndPathClient(Uri endpoint, AzureKeyCredential credential, BodyAndPathClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new BodyAndPathClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _keyCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader) }, new ResponseClassifier());
            _endpoint = endpoint;
        }

        /// <summary>
        /// [Protocol Method] Create products
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="itemName"> item name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="itemName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="itemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/BodyAndPathClient.xml" path="doc/members/member[@name='CreateAsync(string,RequestContent,RequestContext)']/*" />
        public virtual async Task<Response> CreateAsync(string itemName, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(itemName, nameof(itemName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("BodyAndPathClient.Create");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateRequest(itemName, content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Create products
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="itemName"> item name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="itemName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="itemName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/BodyAndPathClient.xml" path="doc/members/member[@name='Create(string,RequestContent,RequestContext)']/*" />
        public virtual Response Create(string itemName, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(itemName, nameof(itemName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("BodyAndPathClient.Create");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateRequest(itemName, content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Create products
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="itemNameStream"> item name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> Upload file type. Allowed values: "application/json" | "application/octet-stream". </param>
        /// <param name="excluded"> Excluded connection Ids. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="itemNameStream"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="itemNameStream"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/BodyAndPathClient.xml" path="doc/members/member[@name='CreateStreamAsync(string,RequestContent,ContentType,IEnumerable{string},RequestContext)']/*" />
        public virtual async Task<Response> CreateStreamAsync(string itemNameStream, RequestContent content, ContentType contentType, IEnumerable<string> excluded = null, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(itemNameStream, nameof(itemNameStream));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("BodyAndPathClient.CreateStream");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateStreamRequest(itemNameStream, content, contentType, excluded, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Create products
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="itemNameStream"> item name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> Upload file type. Allowed values: "application/json" | "application/octet-stream". </param>
        /// <param name="excluded"> Excluded connection Ids. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="itemNameStream"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="itemNameStream"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/BodyAndPathClient.xml" path="doc/members/member[@name='CreateStream(string,RequestContent,ContentType,IEnumerable{string},RequestContext)']/*" />
        public virtual Response CreateStream(string itemNameStream, RequestContent content, ContentType contentType, IEnumerable<string> excluded = null, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(itemNameStream, nameof(itemNameStream));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("BodyAndPathClient.CreateStream");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateStreamRequest(itemNameStream, content, contentType, excluded, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Create another product
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="enumName1"> The first name. Allowed values: "current" | "default". </param>
        /// <param name="enumName2"> The second name. Allowed values: "latest". </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="enumName1"/>, <paramref name="enumName2"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="enumName1"/> or <paramref name="enumName2"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/BodyAndPathClient.xml" path="doc/members/member[@name='CreateEnumAsync(string,string,RequestContent,RequestContext)']/*" />
        public virtual async Task<Response> CreateEnumAsync(string enumName1, string enumName2, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(enumName1, nameof(enumName1));
            Argument.AssertNotNullOrEmpty(enumName2, nameof(enumName2));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("BodyAndPathClient.CreateEnum");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateEnumRequest(enumName1, enumName2, content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Create another product
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="enumName1"> The first name. Allowed values: "current" | "default". </param>
        /// <param name="enumName2"> The second name. Allowed values: "latest". </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="enumName1"/>, <paramref name="enumName2"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="enumName1"/> or <paramref name="enumName2"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/BodyAndPathClient.xml" path="doc/members/member[@name='CreateEnum(string,string,RequestContent,RequestContext)']/*" />
        public virtual Response CreateEnum(string enumName1, string enumName2, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(enumName1, nameof(enumName1));
            Argument.AssertNotNullOrEmpty(enumName2, nameof(enumName2));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("BodyAndPathClient.CreateEnum");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateEnumRequest(enumName1, enumName2, content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] List
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/BodyAndPathClient.xml" path="doc/members/member[@name='GetBodyAndPathsAsync(RequestContext)']/*" />
        public virtual async Task<Response> GetBodyAndPathsAsync(RequestContext context)
        {
            using var scope = ClientDiagnostics.CreateScope("BodyAndPathClient.GetBodyAndPaths");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetBodyAndPathsRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] List
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/BodyAndPathClient.xml" path="doc/members/member[@name='GetBodyAndPaths(RequestContext)']/*" />
        public virtual Response GetBodyAndPaths(RequestContext context)
        {
            using var scope = ClientDiagnostics.CreateScope("BodyAndPathClient.GetBodyAndPaths");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetBodyAndPathsRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] List products
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/BodyAndPathClient.xml" path="doc/members/member[@name='GetItemsAsync(RequestContext)']/*" />
        public virtual async Task<Response> GetItemsAsync(RequestContext context)
        {
            using var scope = ClientDiagnostics.CreateScope("BodyAndPathClient.GetItems");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetItemsRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] List products
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/BodyAndPathClient.xml" path="doc/members/member[@name='GetItems(RequestContext)']/*" />
        public virtual Response GetItems(RequestContext context)
        {
            using var scope = ClientDiagnostics.CreateScope("BodyAndPathClient.GetItems");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetItemsRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method]
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="item3"> Expected to be the first parameter because of its position in the path. </param>
        /// <param name="item2"> Expected to be the second parameter because of its position in the path. 'item4' in the path isn't a parameter, it is a static part of the path. </param>
        /// <param name="item1"> Expected to be the sixth parameter because it is a query parameter and has a default value, so it is treated as optional despite 'required: true'. 'item1' in the path isn't a parameter, it is a static part of the path. The default value is "value". </param>
        /// <param name="item4"> Expected to be the third parameter because it is a required query parameter. 'item4' in the path isn't a parameter, it is a static part of the path. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="item5"> Expected to be the fifth parameter because it is an optional query parameter which goes after RequestContent. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="item3"/>, <paramref name="item2"/>, <paramref name="item1"/>, <paramref name="item4"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="item3"/> or <paramref name="item2"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/BodyAndPathClient.xml" path="doc/members/member[@name='UpdateAsync(string,string,string,string,RequestContent,string,RequestContext)']/*" />
        public virtual async Task<Response> UpdateAsync(string item3, string item2, string item1, string item4, RequestContent content, string item5 = null, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(item3, nameof(item3));
            Argument.AssertNotNullOrEmpty(item2, nameof(item2));
            Argument.AssertNotNull(item1, nameof(item1));
            Argument.AssertNotNull(item4, nameof(item4));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("BodyAndPathClient.Update");
            scope.Start();
            try
            {
                using HttpMessage message = CreateUpdateRequest(item3, item2, item1, item4, content, item5, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method]
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="item3"> Expected to be the first parameter because of its position in the path. </param>
        /// <param name="item2"> Expected to be the second parameter because of its position in the path. 'item4' in the path isn't a parameter, it is a static part of the path. </param>
        /// <param name="item1"> Expected to be the sixth parameter because it is a query parameter and has a default value, so it is treated as optional despite 'required: true'. 'item1' in the path isn't a parameter, it is a static part of the path. The default value is "value". </param>
        /// <param name="item4"> Expected to be the third parameter because it is a required query parameter. 'item4' in the path isn't a parameter, it is a static part of the path. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="item5"> Expected to be the fifth parameter because it is an optional query parameter which goes after RequestContent. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="item3"/>, <paramref name="item2"/>, <paramref name="item1"/>, <paramref name="item4"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="item3"/> or <paramref name="item2"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/BodyAndPathClient.xml" path="doc/members/member[@name='Update(string,string,string,string,RequestContent,string,RequestContext)']/*" />
        public virtual Response Update(string item3, string item2, string item1, string item4, RequestContent content, string item5 = null, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(item3, nameof(item3));
            Argument.AssertNotNullOrEmpty(item2, nameof(item2));
            Argument.AssertNotNull(item1, nameof(item1));
            Argument.AssertNotNull(item4, nameof(item4));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("BodyAndPathClient.Update");
            scope.Start();
            try
            {
                using HttpMessage message = CreateUpdateRequest(item3, item2, item1, item4, content, item5, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateCreateRequest(string itemName, RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(itemName, true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateCreateStreamRequest(string itemNameStream, RequestContent content, ContentType contentType, IEnumerable<string> excluded, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(itemNameStream, true);
            if (excluded != null && !(excluded is ChangeTrackingList<string> changeTrackingList && changeTrackingList.IsUndefined))
            {
                foreach (var param in excluded)
                {
                    uri.AppendQuery("excluded", param, true);
                }
            }
            request.Uri = uri;
            request.Headers.Add("Content-Type", contentType.ToString());
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateCreateEnumRequest(string enumName1, string enumName2, RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(enumName1, true);
            uri.AppendPath("/", false);
            uri.AppendPath(enumName2, true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateGetBodyAndPathsRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/list", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetItemsRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/listItems", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateUpdateRequest(string item3, string item2, string item1, string item4, RequestContent content, string item5, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(item3, true);
            uri.AppendPath("/item4/", false);
            uri.AppendPath(item2, true);
            uri.AppendPath("/item1", false);
            uri.AppendQuery("item1", item1, true);
            uri.AppendQuery("item4", item4, true);
            if (item5 != null)
            {
                uri.AppendQuery("item5", item5, true);
            }
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}