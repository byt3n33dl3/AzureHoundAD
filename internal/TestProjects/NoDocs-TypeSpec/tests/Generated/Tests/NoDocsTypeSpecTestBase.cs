// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core.TestFramework;

namespace NoDocsTypeSpec.Tests
{
    public partial class NoDocsTypeSpecTestBase : RecordedTestBase<NoDocsTypeSpecTestEnvironment>
    {
        public NoDocsTypeSpecTestBase(bool isAsync) : base(isAsync)
        {
        }

        protected NoDocsTypeSpecClient CreateNoDocsTypeSpecClient(Uri endpoint, AzureKeyCredential credential)
        {
            NoDocsTypeSpecClientOptions options = InstrumentClientOptions(new NoDocsTypeSpecClientOptions());
            NoDocsTypeSpecClient client = new NoDocsTypeSpecClient(endpoint, credential, options);
            return InstrumentClient(client);
        }
    }
}