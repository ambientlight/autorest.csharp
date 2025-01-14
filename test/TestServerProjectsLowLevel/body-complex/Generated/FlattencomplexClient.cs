// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace body_complex_LowLevel
{
    /// <summary> The Flattencomplex service client. </summary>
    public partial class FlattencomplexClient
    {
        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get => _pipeline; }
        private HttpPipeline _pipeline;
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly FlattencomplexRestClient _restClient;
        private const string AuthorizationHeader = "Fake-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;

        /// <summary> Initializes a new instance of FlattencomplexClient for mocking. </summary>
        protected FlattencomplexClient()
        {
        }

        /// <summary> Initializes a new instance of FlattencomplexClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public FlattencomplexClient(AzureKeyCredential credential, Uri endpoint = null, AutoRestComplexTestServiceClientOptions options = null)
        {
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }
            endpoint ??= new Uri("http://localhost:3000");

            options ??= new AutoRestComplexTestServiceClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _keyCredential = credential;
            var authPolicy = new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader);
            _pipeline = HttpPipelineBuilder.Build(options, new HttpPipelinePolicy[] { new LowLevelCallbackPolicy() }, new HttpPipelinePolicy[] { authPolicy }, new ResponseClassifier());
            _restClient = new FlattencomplexRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   kind: &quot;Kind1&quot;,
        ///   propB1: string,
        ///   helper: {
        ///     propBH1: string
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetValidAsync(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("FlattencomplexClient.GetValid");
            scope.Start();
            try
            {
                return await _restClient.GetValidAsync(options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   kind: &quot;Kind1&quot;,
        ///   propB1: string,
        ///   helper: {
        ///     propBH1: string
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response GetValid(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("FlattencomplexClient.GetValid");
            scope.Start();
            try
            {
                return _restClient.GetValid(options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
