﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using AutoRest.CSharp.Common.Input;
using AutoRest.CSharp.Input.Source;
using AutoRest.CSharp.Output.Models.Requests;
using AutoRest.CSharp.Output.Models.Shared;
using AutoRest.CSharp.Output.Models.Types;

namespace AutoRest.CSharp.Output.Models
{
    internal abstract class RestClient : TypeProvider
    {
        private readonly Lazy<IReadOnlyDictionary<InputOperation, RestClientMethod>> _requestMethods;
        private readonly Lazy<IReadOnlyDictionary<InputOperation, RestClientMethod>> _nextPageRequestMethods;
        private RestClientMethod[]? _allMethods;
        private ConstructorSignature? _constructor;

        internal InputClient InputClient { get; }
        public IReadOnlyList<Parameter> Parameters { get; }
        public RestClientMethod[] Methods => _allMethods ??= BuildAllMethods().ToArray();
        public ConstructorSignature Constructor => _constructor ??= new ConstructorSignature(Type, $"Initializes a new instance of {Declaration.Name}", null, MethodSignatureModifiers.Public, Parameters.ToArray());

        protected override string DefaultName { get; }
        protected override string DefaultAccessibility => "internal";

        protected RestClient(InputClient inputClient, string restClientName, IReadOnlyList<Parameter> parameters, SourceInputModel? sourceInputModel) : base(Configuration.Namespace, sourceInputModel)
        {
            InputClient = inputClient;

            _requestMethods = new Lazy<IReadOnlyDictionary<InputOperation, RestClientMethod>>(EnsureNormalMethods);
            _nextPageRequestMethods = new Lazy<IReadOnlyDictionary<InputOperation, RestClientMethod>>(EnsureGetNextPageMethods);

            Parameters = parameters;
            DefaultName = restClientName;
        }

        private IEnumerable<RestClientMethod> BuildAllMethods()
        {
            foreach (var operation in InputClient.Operations)
            {
                yield return GetOperationMethod(operation);
            }

            foreach (var operation in InputClient.Operations)
            {
                // remove duplicates when GetNextPage method is not autogenerated
                if (GetNextOperationMethod(operation) is { } nextOperationMethod && operation.Paging is {NextLinkOperation: null, SelfNextLink: false})
                {
                    yield return nextOperationMethod;
                }
            }
        }

        protected abstract Dictionary<InputOperation, RestClientMethod> EnsureNormalMethods();

        protected Dictionary<InputOperation, RestClientMethod> EnsureGetNextPageMethods()
        {
            var nextPageMethods = new Dictionary<InputOperation, RestClientMethod>();
            foreach (var operation in InputClient.Operations)
            {
                var paging = operation.Paging;
                if (paging == null)
                {
                    continue;
                }

                RestClientMethod? nextMethod = null;
                if (paging.NextLinkOperation != null)
                {
                    nextMethod = GetOperationMethod(paging.NextLinkOperation);
                }
                else if (paging.NextLinkName != null)
                {
                    var method = GetOperationMethod(operation);
                    nextMethod = RestClientBuilder.BuildNextPageMethod(method);
                }

                if (nextMethod != null)
                {
                    nextPageMethods.Add(operation, nextMethod);
                }
            }

            return nextPageMethods;
        }

        public RestClientMethod? GetNextOperationMethod(InputOperation request)
        {
            RestClientMethod? value;
            if (request.Paging is { SelfNextLink: true })
            {
                _requestMethods.Value.TryGetValue(request, out value);
            }
            else
            {
                _nextPageRequestMethods.Value.TryGetValue(request, out value);
            }

            return value;
        }

        public RestClientMethod GetOperationMethod(InputOperation request)
            => _requestMethods.Value[request];
    }
}