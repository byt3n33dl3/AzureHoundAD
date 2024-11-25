// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using body_complex.Models;

namespace body_complex
{
    /// <summary> The Polymorphism service client. </summary>
    public partial class PolymorphismClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal PolymorphismRestClient RestClient { get; }

        /// <summary> Initializes a new instance of PolymorphismClient for mocking. </summary>
        protected PolymorphismClient()
        {
        }

        /// <summary> Initializes a new instance of PolymorphismClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal PolymorphismClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new PolymorphismRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Get complex types that are polymorphic. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Fish>> GetValidAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.GetValid");
            scope.Start();
            try
            {
                return await RestClient.GetValidAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex types that are polymorphic. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Fish> GetValid(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.GetValid");
            scope.Start();
            try
            {
                return RestClient.GetValid(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types that are polymorphic. </summary>
        /// <param name="complexBody">
        /// Please put a salmon that looks like this:
        /// {
        ///         'fishtype':'Salmon',
        ///         'location':'alaska',
        ///         'iswild':true,
        ///         'species':'king',
        ///         'length':1.0,
        ///         'siblings':[
        ///           {
        ///             'fishtype':'Shark',
        ///             'age':6,
        ///             'birthday': '2012-01-05T01:00:00Z',
        ///             'length':20.0,
        ///             'species':'predator',
        ///           },
        ///           {
        ///             'fishtype':'Sawshark',
        ///             'age':105,
        ///             'birthday': '1900-01-05T01:00:00Z',
        ///             'length':10.0,
        ///             'picture': new Buffer([255, 255, 255, 255, 254]).toString('base64'),
        ///             'species':'dangerous',
        ///           },
        ///           {
        ///             'fishtype': 'goblin',
        ///             'age': 1,
        ///             'birthday': '2015-08-08T00:00:00Z',
        ///             'length': 30.0,
        ///             'species': 'scary',
        ///             'jawsize': 5
        ///           }
        ///         ]
        ///       };
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PutValidAsync(Fish complexBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.PutValid");
            scope.Start();
            try
            {
                return await RestClient.PutValidAsync(complexBody, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types that are polymorphic. </summary>
        /// <param name="complexBody">
        /// Please put a salmon that looks like this:
        /// {
        ///         'fishtype':'Salmon',
        ///         'location':'alaska',
        ///         'iswild':true,
        ///         'species':'king',
        ///         'length':1.0,
        ///         'siblings':[
        ///           {
        ///             'fishtype':'Shark',
        ///             'age':6,
        ///             'birthday': '2012-01-05T01:00:00Z',
        ///             'length':20.0,
        ///             'species':'predator',
        ///           },
        ///           {
        ///             'fishtype':'Sawshark',
        ///             'age':105,
        ///             'birthday': '1900-01-05T01:00:00Z',
        ///             'length':10.0,
        ///             'picture': new Buffer([255, 255, 255, 255, 254]).toString('base64'),
        ///             'species':'dangerous',
        ///           },
        ///           {
        ///             'fishtype': 'goblin',
        ///             'age': 1,
        ///             'birthday': '2015-08-08T00:00:00Z',
        ///             'length': 30.0,
        ///             'species': 'scary',
        ///             'jawsize': 5
        ///           }
        ///         ]
        ///       };
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PutValid(Fish complexBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.PutValid");
            scope.Start();
            try
            {
                return RestClient.PutValid(complexBody, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex types that are polymorphic, JSON key contains a dot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DotFish>> GetDotSyntaxAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.GetDotSyntax");
            scope.Start();
            try
            {
                return await RestClient.GetDotSyntaxAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex types that are polymorphic, JSON key contains a dot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DotFish> GetDotSyntax(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.GetDotSyntax");
            scope.Start();
            try
            {
                return RestClient.GetDotSyntax(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex object composing a polymorphic scalar property and array property with polymorphic element type, with discriminator specified. Deserialization must NOT fail and use the discriminator type specified on the wire. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DotFishMarket>> GetComposedWithDiscriminatorAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.GetComposedWithDiscriminator");
            scope.Start();
            try
            {
                return await RestClient.GetComposedWithDiscriminatorAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex object composing a polymorphic scalar property and array property with polymorphic element type, with discriminator specified. Deserialization must NOT fail and use the discriminator type specified on the wire. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DotFishMarket> GetComposedWithDiscriminator(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.GetComposedWithDiscriminator");
            scope.Start();
            try
            {
                return RestClient.GetComposedWithDiscriminator(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex object composing a polymorphic scalar property and array property with polymorphic element type, without discriminator specified on wire. Deserialization must NOT fail and use the explicit type of the property. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DotFishMarket>> GetComposedWithoutDiscriminatorAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.GetComposedWithoutDiscriminator");
            scope.Start();
            try
            {
                return await RestClient.GetComposedWithoutDiscriminatorAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex object composing a polymorphic scalar property and array property with polymorphic element type, without discriminator specified on wire. Deserialization must NOT fail and use the explicit type of the property. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DotFishMarket> GetComposedWithoutDiscriminator(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.GetComposedWithoutDiscriminator");
            scope.Start();
            try
            {
                return RestClient.GetComposedWithoutDiscriminator(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex types that are polymorphic, but not at the root of the hierarchy; also have additional properties. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Salmon>> GetComplicatedAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.GetComplicated");
            scope.Start();
            try
            {
                return await RestClient.GetComplicatedAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get complex types that are polymorphic, but not at the root of the hierarchy; also have additional properties. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Salmon> GetComplicated(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.GetComplicated");
            scope.Start();
            try
            {
                return RestClient.GetComplicated(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types that are polymorphic, but not at the root of the hierarchy; also have additional properties. </summary>
        /// <param name="complexBody"> The <see cref="Salmon"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PutComplicatedAsync(Salmon complexBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.PutComplicated");
            scope.Start();
            try
            {
                return await RestClient.PutComplicatedAsync(complexBody, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types that are polymorphic, but not at the root of the hierarchy; also have additional properties. </summary>
        /// <param name="complexBody"> The <see cref="Salmon"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PutComplicated(Salmon complexBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.PutComplicated");
            scope.Start();
            try
            {
                return RestClient.PutComplicated(complexBody, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types that are polymorphic, omitting the discriminator. </summary>
        /// <param name="complexBody"> The <see cref="Salmon"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Salmon>> PutMissingDiscriminatorAsync(Salmon complexBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.PutMissingDiscriminator");
            scope.Start();
            try
            {
                return await RestClient.PutMissingDiscriminatorAsync(complexBody, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types that are polymorphic, omitting the discriminator. </summary>
        /// <param name="complexBody"> The <see cref="Salmon"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Salmon> PutMissingDiscriminator(Salmon complexBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.PutMissingDiscriminator");
            scope.Start();
            try
            {
                return RestClient.PutMissingDiscriminator(complexBody, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types that are polymorphic, attempting to omit required 'birthday' field - the request should not be allowed from the client. </summary>
        /// <param name="complexBody">
        /// Please attempt put a sawshark that looks like this, the client should not allow this data to be sent:
        /// {
        ///     "fishtype": "sawshark",
        ///     "species": "snaggle toothed",
        ///     "length": 18.5,
        ///     "age": 2,
        ///     "birthday": "2013-06-01T01:00:00Z",
        ///     "location": "alaska",
        ///     "picture": base64(FF FF FF FF FE),
        ///     "siblings": [
        ///         {
        ///             "fishtype": "shark",
        ///             "species": "predator",
        ///             "birthday": "2012-01-05T01:00:00Z",
        ///             "length": 20,
        ///             "age": 6
        ///         },
        ///         {
        ///             "fishtype": "sawshark",
        ///             "species": "dangerous",
        ///             "picture": base64(FF FF FF FF FE),
        ///             "length": 10,
        ///             "age": 105
        ///         }
        ///     ]
        /// }
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PutValidMissingRequiredAsync(Fish complexBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.PutValidMissingRequired");
            scope.Start();
            try
            {
                return await RestClient.PutValidMissingRequiredAsync(complexBody, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put complex types that are polymorphic, attempting to omit required 'birthday' field - the request should not be allowed from the client. </summary>
        /// <param name="complexBody">
        /// Please attempt put a sawshark that looks like this, the client should not allow this data to be sent:
        /// {
        ///     "fishtype": "sawshark",
        ///     "species": "snaggle toothed",
        ///     "length": 18.5,
        ///     "age": 2,
        ///     "birthday": "2013-06-01T01:00:00Z",
        ///     "location": "alaska",
        ///     "picture": base64(FF FF FF FF FE),
        ///     "siblings": [
        ///         {
        ///             "fishtype": "shark",
        ///             "species": "predator",
        ///             "birthday": "2012-01-05T01:00:00Z",
        ///             "length": 20,
        ///             "age": 6
        ///         },
        ///         {
        ///             "fishtype": "sawshark",
        ///             "species": "dangerous",
        ///             "picture": base64(FF FF FF FF FE),
        ///             "length": 10,
        ///             "age": 105
        ///         }
        ///     ]
        /// }
        /// </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PutValidMissingRequired(Fish complexBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolymorphismClient.PutValidMissingRequired");
            scope.Start();
            try
            {
                return RestClient.PutValidMissingRequired(complexBody, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}