// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using AdditionalPropertiesEx.Models;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace AdditionalPropertiesEx
{
    internal partial class APRestClient
    {
        private string host;
        private ClientDiagnostics clientDiagnostics;
        private HttpPipeline pipeline;

        /// <summary> Initializes a new instance of APRestClient. </summary>
        public APRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "http://localhost:3000")
        {
            if (host == null)
            {
                throw new ArgumentNullException(nameof(host));
            }

            this.host = host;
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }

        internal HttpMessage CreateWriteOnlyRequest(InputAdditionalPropertiesModel createParameters)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/ap_operation", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(createParameters);
            request.Content = content;
            return message;
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="createParameters"> The InputAdditionalPropertiesModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> WriteOnlyAsync(InputAdditionalPropertiesModel createParameters, CancellationToken cancellationToken = default)
        {
            if (createParameters == null)
            {
                throw new ArgumentNullException(nameof(createParameters));
            }

            using var scope = clientDiagnostics.CreateScope("APClient.WriteOnly");
            scope.Start();
            try
            {
                using var message = CreateWriteOnlyRequest(createParameters);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="createParameters"> The InputAdditionalPropertiesModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response WriteOnly(InputAdditionalPropertiesModel createParameters, CancellationToken cancellationToken = default)
        {
            if (createParameters == null)
            {
                throw new ArgumentNullException(nameof(createParameters));
            }

            using var scope = clientDiagnostics.CreateScope("APClient.WriteOnly");
            scope.Start();
            try
            {
                using var message = CreateWriteOnlyRequest(createParameters);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        return message.Response;
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateReadOnlyRequest()
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/ap_operation", false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<OutputAdditionalPropertiesModel>> ReadOnlyAsync(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("APClient.ReadOnly");
            scope.Start();
            try
            {
                using var message = CreateReadOnlyRequest();
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            OutputAdditionalPropertiesModel value = default;
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            value = OutputAdditionalPropertiesModel.DeserializeOutputAdditionalPropertiesModel(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create a Pet which contains more properties than what is defined. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<OutputAdditionalPropertiesModel> ReadOnly(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("APClient.ReadOnly");
            scope.Start();
            try
            {
                using var message = CreateReadOnlyRequest();
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            OutputAdditionalPropertiesModel value = default;
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            value = OutputAdditionalPropertiesModel.DeserializeOutputAdditionalPropertiesModel(document.RootElement);
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
