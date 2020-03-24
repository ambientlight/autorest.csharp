// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using AdditionalPropertiesEx.Models;
using Azure;
using Azure.Core.Pipeline;

namespace AdditionalPropertiesEx
{
    public partial class APClient
    {
        private readonly ClientDiagnostics clientDiagnostics;
        private readonly HttpPipeline pipeline;
        internal APRestClient RestClient { get; }
        /// <summary> Initializes a new instance of APClient for mocking. </summary>
        protected APClient()
        {
        }
        /// <summary> Initializes a new instance of APClient. </summary>
        internal APClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "http://localhost:3000")
        {
            RestClient = new APRestClient(clientDiagnostics, pipeline, host);
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="createParameters"> The InputAdditionalPropertiesModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> WriteOnlyAsync(InputAdditionalPropertiesModel createParameters, CancellationToken cancellationToken = default)
        {
            return await RestClient.WriteOnlyAsync(createParameters, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="createParameters"> The InputAdditionalPropertiesModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response WriteOnly(InputAdditionalPropertiesModel createParameters, CancellationToken cancellationToken = default)
        {
            return RestClient.WriteOnly(createParameters, cancellationToken);
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<OutputAdditionalPropertiesModel>> ReadOnlyAsync(CancellationToken cancellationToken = default)
        {
            return await RestClient.ReadOnlyAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<OutputAdditionalPropertiesModel> ReadOnly(CancellationToken cancellationToken = default)
        {
            return RestClient.ReadOnly(cancellationToken);
        }
    }
}
