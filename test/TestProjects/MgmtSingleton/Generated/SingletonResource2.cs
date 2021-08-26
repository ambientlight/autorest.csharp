// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;
using MgmtSingleton.Models;

namespace MgmtSingleton
{
    /// <summary> A Class representing a SingletonResource2 along with the instance operations that can be performed on it. </summary>
    public partial class SingletonResource2 : ArmResource
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly SingletonResources2RestOperations _restClient;
        private readonly SingletonResource2Data _data;

        /// <summary> Initializes a new instance of the <see cref="SingletonResource2"/> class for mocking. </summary>
        protected SingletonResource2()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SingletonResource2"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal SingletonResource2(ArmResource options, SingletonResource2Data resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            Parent = options;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new SingletonResources2RestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="SingletonResource2"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SingletonResource2(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            Parent = options;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new SingletonResources2RestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Billing/parentResources/singletonResources2";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SingletonResource2Data Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// <summary> Gets the parent resource of this resource. </summary>
        public ArmResource Parent { get; }

        /// <summary> Singleton Test Example without explicit /default, /latest ending. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<SingletonResource2>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SingletonResource2.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetDefaultAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SingletonResource2(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Singleton Test Example without explicit /default, /latest ending. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SingletonResource2> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SingletonResource2.Get");
            scope.Start();
            try
            {
                var response = _restClient.GetDefault(Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SingletonResource2(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<Location>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<Location> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> Delete an SingletonResources2. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<SingletonResources2DeleteOperation> DeleteAsync(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SingletonResource2.Delete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SingletonResources2DeleteOperation(response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete an SingletonResources2. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual SingletonResources2DeleteOperation Delete(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SingletonResource2.Delete");
            scope.Start();
            try
            {
                var response = _restClient.Delete(Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new SingletonResources2DeleteOperation(response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <param name="parameters"> The SingletonResource2 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual async Task<Response<SingletonResource2>> CreateOrUpdateAsync(SingletonResource2Data parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SingletonResource2.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SingletonResource2(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="parameters"> The SingletonResource2 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual Response<SingletonResource2> CreateOrUpdate(SingletonResource2Data parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SingletonResource2.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, parameters, cancellationToken);
                return Response.FromValue(new SingletonResource2(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update an SingletonResources2. </summary>
        /// <param name="parameters"> The SingletonResource2 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual async Task<Response<SingletonResource2>> UpdateAsync(SingletonResource2Data parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SingletonResource2.Update");
            scope.Start();
            try
            {
                var response = await _restClient.UpdateAsync(Id.ResourceGroupName, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SingletonResource2(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update an SingletonResources2. </summary>
        /// <param name="parameters"> The SingletonResource2 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual Response<SingletonResource2> Update(SingletonResource2Data parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SingletonResource2.Update");
            scope.Start();
            try
            {
                var response = _restClient.Update(Id.ResourceGroupName, Id.Name, parameters, cancellationToken);
                return Response.FromValue(new SingletonResource2(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to do POST request. </summary>
        /// <param name="postParameter"> The Boolean to use. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<SingletonResources2PostTestOperation> PostTestAsync(bool? postParameter = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SingletonResource2.PostTest");
            scope.Start();
            try
            {
                var response = await _restClient.PostTestAsync(Id.ResourceGroupName, Id.Name, postParameter, cancellationToken).ConfigureAwait(false);
                var operation = new SingletonResources2PostTestOperation(_clientDiagnostics, Pipeline, _restClient.CreatePostTestRequest(Id.ResourceGroupName, Id.Name, postParameter).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to do POST request. </summary>
        /// <param name="postParameter"> The Boolean to use. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual SingletonResources2PostTestOperation PostTest(bool? postParameter = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SingletonResource2.PostTest");
            scope.Start();
            try
            {
                var response = _restClient.PostTest(Id.ResourceGroupName, Id.Name, postParameter, cancellationToken);
                var operation = new SingletonResources2PostTestOperation(_clientDiagnostics, Pipeline, _restClient.CreatePostTestRequest(Id.ResourceGroupName, Id.Name, postParameter).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
