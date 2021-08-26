// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.Management.Storage
{
    /// <summary> A Class representing a FileService along with the instance operations that can be performed on it. </summary>
    public partial class FileService : ArmResource
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly FileServicesRestOperations _restClient;
        private readonly FileServiceData _data;

        /// <summary> Initializes a new instance of the <see cref="FileService"/> class for mocking. </summary>
        protected FileService()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "FileService"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal FileService(ArmResource options, FileServiceData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            Parent = options;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new FileServicesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="FileService"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal FileService(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            Parent = options;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new FileServicesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Storage/storageAccounts/fileServices";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual FileServiceData Data
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

        /// <summary> Gets the properties of file services in storage accounts, including CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<FileService>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FileService.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetServicePropertiesAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new FileService(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the properties of file services in storage accounts, including CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FileService> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FileService.Get");
            scope.Start();
            try
            {
                var response = _restClient.GetServiceProperties(Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FileService(this, response.Value), response.GetRawResponse());
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
        /// <summary> List all file services in storage accounts. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IReadOnlyList<FileService>>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FileService.GetAll");
            scope.Start();
            try
            {
                var response = await _restClient.GetAllAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value.Value.Select(data => new FileService(this, data)).ToArray() as IReadOnlyList<FileService>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List all file services in storage accounts. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<FileService>> GetAll(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FileService.GetAll");
            scope.Start();
            try
            {
                var response = _restClient.GetAll(Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(response.Value.Value.Select(data => new FileService(this, data)).ToArray() as IReadOnlyList<FileService>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Sets the properties of file services in storage accounts, including CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="parameters"> The properties of file services in storage accounts, including CORS (Cross-Origin Resource Sharing) rules. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual async Task<Response<FileService>> SetServicePropertiesAsync(FileServiceData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FileService.SetServiceProperties");
            scope.Start();
            try
            {
                var response = await _restClient.SetServicePropertiesAsync(Id.ResourceGroupName, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new FileService(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Sets the properties of file services in storage accounts, including CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="parameters"> The properties of file services in storage accounts, including CORS (Cross-Origin Resource Sharing) rules. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual Response<FileService> SetServiceProperties(FileServiceData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FileService.SetServiceProperties");
            scope.Start();
            try
            {
                var response = _restClient.SetServiceProperties(Id.ResourceGroupName, Id.Name, parameters, cancellationToken);
                return Response.FromValue(new FileService(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
