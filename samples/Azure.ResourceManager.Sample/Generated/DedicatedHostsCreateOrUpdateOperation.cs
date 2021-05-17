// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Sample
{
    /// <summary> Create or update a dedicated host . </summary>
    public partial class DedicatedHostsCreateOrUpdateOperation : Operation<DedicatedHostData>, IOperationSource<DedicatedHostData>
    {
        private readonly OperationInternals<DedicatedHostData> _operation;

        /// <summary> Initializes a new instance of DedicatedHostsCreateOrUpdateOperation for mocking. </summary>
        protected DedicatedHostsCreateOrUpdateOperation()
        {
        }

        internal DedicatedHostsCreateOrUpdateOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<DedicatedHostData>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "DedicatedHostsCreateOrUpdateOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override DedicatedHostData Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<DedicatedHostData>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<DedicatedHostData>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        DedicatedHostData IOperationSource<DedicatedHostData>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return DedicatedHostData.DeserializeDedicatedHostData(document.RootElement);
        }

        async ValueTask<DedicatedHostData> IOperationSource<DedicatedHostData>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return DedicatedHostData.DeserializeDedicatedHostData(document.RootElement);
        }
    }
}