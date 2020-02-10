// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using model_flattening.Models;

namespace model_flattening
{
    internal partial class AllOperations
    {
        private string host;
        private ClientDiagnostics clientDiagnostics;
        private HttpPipeline pipeline;
        /// <summary> Initializes a new instance of AllOperations. </summary>
        public AllOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "http://localhost:3000")
        {
            if (host == null)
            {
                throw new ArgumentNullException(nameof(host));
            }

            this.host = host;
            this.clientDiagnostics = clientDiagnostics;
            this.pipeline = pipeline;
        }
        internal HttpMessage CreatePutArrayRequest(IEnumerable<Resource> resourceArray)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/model-flatten/array", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteStartArray();
            foreach (var item in resourceArray)
            {
                content.JsonWriter.WriteObjectValue(item);
            }
            content.JsonWriter.WriteEndArray();
            request.Content = content;
            return message;
        }
        /// <summary> Put External Resource as an Array. </summary>
        /// <param name="resourceArray"> External Resource as an Array to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PutArrayAsync(IEnumerable<Resource> resourceArray, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("AllOperations.PutArray");
            scope.Start();
            try
            {
                using var message = CreatePutArrayRequest(resourceArray);
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
        /// <summary> Put External Resource as an Array. </summary>
        /// <param name="resourceArray"> External Resource as an Array to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PutArray(IEnumerable<Resource> resourceArray, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("AllOperations.PutArray");
            scope.Start();
            try
            {
                using var message = CreatePutArrayRequest(resourceArray);
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
        internal HttpMessage CreateGetArrayRequest()
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/model-flatten/array", false);
            request.Uri = uri;
            return message;
        }
        /// <summary> Get External Resource as an Array. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<ICollection<FlattenedProduct>>> GetArrayAsync(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("AllOperations.GetArray");
            scope.Start();
            try
            {
                using var message = CreateGetArrayRequest();
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            ICollection<FlattenedProduct> value = new List<FlattenedProduct>();
                            foreach (var item in document.RootElement.EnumerateArray())
                            {
                                value.Add(FlattenedProduct.DeserializeFlattenedProduct(item));
                            }
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
        /// <summary> Get External Resource as an Array. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ICollection<FlattenedProduct>> GetArray(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("AllOperations.GetArray");
            scope.Start();
            try
            {
                using var message = CreateGetArrayRequest();
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            ICollection<FlattenedProduct> value = new List<FlattenedProduct>();
                            foreach (var item in document.RootElement.EnumerateArray())
                            {
                                value.Add(FlattenedProduct.DeserializeFlattenedProduct(item));
                            }
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
        internal HttpMessage CreatePutWrappedArrayRequest(IEnumerable<WrappedProduct> resourceArray)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/model-flatten/wrappedarray", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteStartArray();
            foreach (var item in resourceArray)
            {
                content.JsonWriter.WriteObjectValue(item);
            }
            content.JsonWriter.WriteEndArray();
            request.Content = content;
            return message;
        }
        /// <summary> No need to have a route in Express server for this operation. Used to verify the type flattened is not removed if it&apos;s referenced in an array. </summary>
        /// <param name="resourceArray"> External Resource as an Array to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PutWrappedArrayAsync(IEnumerable<WrappedProduct> resourceArray, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("AllOperations.PutWrappedArray");
            scope.Start();
            try
            {
                using var message = CreatePutWrappedArrayRequest(resourceArray);
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
        /// <summary> No need to have a route in Express server for this operation. Used to verify the type flattened is not removed if it&apos;s referenced in an array. </summary>
        /// <param name="resourceArray"> External Resource as an Array to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PutWrappedArray(IEnumerable<WrappedProduct> resourceArray, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("AllOperations.PutWrappedArray");
            scope.Start();
            try
            {
                using var message = CreatePutWrappedArrayRequest(resourceArray);
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
        internal HttpMessage CreateGetWrappedArrayRequest()
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/model-flatten/wrappedarray", false);
            request.Uri = uri;
            return message;
        }
        /// <summary> No need to have a route in Express server for this operation. Used to verify the type flattened is not removed if it&apos;s referenced in an array. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<ICollection<ProductWrapper>>> GetWrappedArrayAsync(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("AllOperations.GetWrappedArray");
            scope.Start();
            try
            {
                using var message = CreateGetWrappedArrayRequest();
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            ICollection<ProductWrapper> value = new List<ProductWrapper>();
                            foreach (var item in document.RootElement.EnumerateArray())
                            {
                                value.Add(ProductWrapper.DeserializeProductWrapper(item));
                            }
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
        /// <summary> No need to have a route in Express server for this operation. Used to verify the type flattened is not removed if it&apos;s referenced in an array. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ICollection<ProductWrapper>> GetWrappedArray(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("AllOperations.GetWrappedArray");
            scope.Start();
            try
            {
                using var message = CreateGetWrappedArrayRequest();
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            ICollection<ProductWrapper> value = new List<ProductWrapper>();
                            foreach (var item in document.RootElement.EnumerateArray())
                            {
                                value.Add(ProductWrapper.DeserializeProductWrapper(item));
                            }
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
        internal HttpMessage CreatePutDictionaryRequest(IDictionary<string, FlattenedProduct> resourceDictionary)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/model-flatten/dictionary", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteStartObject();
            foreach (var item in resourceDictionary)
            {
                content.JsonWriter.WritePropertyName(item.Key);
                content.JsonWriter.WriteObjectValue(item.Value);
            }
            content.JsonWriter.WriteEndObject();
            request.Content = content;
            return message;
        }
        /// <summary> Put External Resource as a Dictionary. </summary>
        /// <param name="resourceDictionary"> External Resource as a Dictionary to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PutDictionaryAsync(IDictionary<string, FlattenedProduct> resourceDictionary, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("AllOperations.PutDictionary");
            scope.Start();
            try
            {
                using var message = CreatePutDictionaryRequest(resourceDictionary);
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
        /// <summary> Put External Resource as a Dictionary. </summary>
        /// <param name="resourceDictionary"> External Resource as a Dictionary to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PutDictionary(IDictionary<string, FlattenedProduct> resourceDictionary, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("AllOperations.PutDictionary");
            scope.Start();
            try
            {
                using var message = CreatePutDictionaryRequest(resourceDictionary);
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
        internal HttpMessage CreateGetDictionaryRequest()
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/model-flatten/dictionary", false);
            request.Uri = uri;
            return message;
        }
        /// <summary> Get External Resource as a Dictionary. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<IDictionary<string, FlattenedProduct>>> GetDictionaryAsync(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("AllOperations.GetDictionary");
            scope.Start();
            try
            {
                using var message = CreateGetDictionaryRequest();
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            IDictionary<string, FlattenedProduct> value = new Dictionary<string, FlattenedProduct>();
                            foreach (var property in document.RootElement.EnumerateObject())
                            {
                                value.Add(property.Name, FlattenedProduct.DeserializeFlattenedProduct(property.Value));
                            }
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
        /// <summary> Get External Resource as a Dictionary. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<IDictionary<string, FlattenedProduct>> GetDictionary(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("AllOperations.GetDictionary");
            scope.Start();
            try
            {
                using var message = CreateGetDictionaryRequest();
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            IDictionary<string, FlattenedProduct> value = new Dictionary<string, FlattenedProduct>();
                            foreach (var property in document.RootElement.EnumerateObject())
                            {
                                value.Add(property.Name, FlattenedProduct.DeserializeFlattenedProduct(property.Value));
                            }
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
        internal HttpMessage CreatePutResourceCollectionRequest(ResourceCollection resourceComplexObject)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/model-flatten/resourcecollection", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(resourceComplexObject);
            request.Content = content;
            return message;
        }
        /// <summary> Put External Resource as a ResourceCollection. </summary>
        /// <param name="resourceComplexObject"> External Resource as a ResourceCollection to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> PutResourceCollectionAsync(ResourceCollection resourceComplexObject, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("AllOperations.PutResourceCollection");
            scope.Start();
            try
            {
                using var message = CreatePutResourceCollectionRequest(resourceComplexObject);
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
        /// <summary> Put External Resource as a ResourceCollection. </summary>
        /// <param name="resourceComplexObject"> External Resource as a ResourceCollection to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PutResourceCollection(ResourceCollection resourceComplexObject, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("AllOperations.PutResourceCollection");
            scope.Start();
            try
            {
                using var message = CreatePutResourceCollectionRequest(resourceComplexObject);
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
        internal HttpMessage CreateGetResourceCollectionRequest()
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/model-flatten/resourcecollection", false);
            request.Uri = uri;
            return message;
        }
        /// <summary> Get External Resource as a ResourceCollection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<ResourceCollection>> GetResourceCollectionAsync(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("AllOperations.GetResourceCollection");
            scope.Start();
            try
            {
                using var message = CreateGetResourceCollectionRequest();
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            var value = ResourceCollection.DeserializeResourceCollection(document.RootElement);
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
        /// <summary> Get External Resource as a ResourceCollection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ResourceCollection> GetResourceCollection(CancellationToken cancellationToken = default)
        {
            using var scope = clientDiagnostics.CreateScope("AllOperations.GetResourceCollection");
            scope.Start();
            try
            {
                using var message = CreateGetResourceCollectionRequest();
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            var value = ResourceCollection.DeserializeResourceCollection(document.RootElement);
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
        internal HttpMessage CreatePutSimpleProductRequest(SimpleProduct simpleBodyProduct)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/model-flatten/customFlattening", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(simpleBodyProduct);
            request.Content = content;
            return message;
        }
        /// <summary> Put Simple Product with client flattening true on the model. </summary>
        /// <param name="simpleBodyProduct"> Simple body product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<SimpleProduct>> PutSimpleProductAsync(SimpleProduct simpleBodyProduct, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("AllOperations.PutSimpleProduct");
            scope.Start();
            try
            {
                using var message = CreatePutSimpleProductRequest(simpleBodyProduct);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            var value = SimpleProduct.DeserializeSimpleProduct(document.RootElement);
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
        /// <summary> Put Simple Product with client flattening true on the model. </summary>
        /// <param name="simpleBodyProduct"> Simple body product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SimpleProduct> PutSimpleProduct(SimpleProduct simpleBodyProduct, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("AllOperations.PutSimpleProduct");
            scope.Start();
            try
            {
                using var message = CreatePutSimpleProductRequest(simpleBodyProduct);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            var value = SimpleProduct.DeserializeSimpleProduct(document.RootElement);
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
        internal HttpMessage CreatePostFlattenedSimpleProductRequest(SimpleProduct simpleBodyProduct)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/model-flatten/customFlattening", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(simpleBodyProduct);
            request.Content = content;
            return message;
        }
        /// <summary> Put Flattened Simple Product with client flattening true on the parameter. </summary>
        /// <param name="simpleBodyProduct"> Simple body product to post. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<SimpleProduct>> PostFlattenedSimpleProductAsync(SimpleProduct simpleBodyProduct, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("AllOperations.PostFlattenedSimpleProduct");
            scope.Start();
            try
            {
                using var message = CreatePostFlattenedSimpleProductRequest(simpleBodyProduct);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            var value = SimpleProduct.DeserializeSimpleProduct(document.RootElement);
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
        /// <summary> Put Flattened Simple Product with client flattening true on the parameter. </summary>
        /// <param name="simpleBodyProduct"> Simple body product to post. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SimpleProduct> PostFlattenedSimpleProduct(SimpleProduct simpleBodyProduct, CancellationToken cancellationToken = default)
        {

            using var scope = clientDiagnostics.CreateScope("AllOperations.PostFlattenedSimpleProduct");
            scope.Start();
            try
            {
                using var message = CreatePostFlattenedSimpleProductRequest(simpleBodyProduct);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            var value = SimpleProduct.DeserializeSimpleProduct(document.RootElement);
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
        internal HttpMessage CreatePutSimpleProductWithGroupingRequest(string name, SimpleProduct simpleBodyProduct)
        {
            var message = pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethodAdditional.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/model-flatten/customFlattening/parametergrouping/", false);
            uri.AppendPath(name, true);
            uri.AppendPath("/", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(simpleBodyProduct);
            request.Content = content;
            return message;
        }
        /// <summary> Put Simple Product with client flattening true on the model. </summary>
        /// <param name="name"> Product name with value &apos;groupproduct&apos;. </param>
        /// <param name="simpleBodyProduct"> Simple body product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<SimpleProduct>> PutSimpleProductWithGroupingAsync(string name, SimpleProduct simpleBodyProduct, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = clientDiagnostics.CreateScope("AllOperations.PutSimpleProductWithGrouping");
            scope.Start();
            try
            {
                using var message = CreatePutSimpleProductWithGroupingRequest(name, simpleBodyProduct);
                await pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            var value = SimpleProduct.DeserializeSimpleProduct(document.RootElement);
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
        /// <summary> Put Simple Product with client flattening true on the model. </summary>
        /// <param name="name"> Product name with value &apos;groupproduct&apos;. </param>
        /// <param name="simpleBodyProduct"> Simple body product to put. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SimpleProduct> PutSimpleProductWithGrouping(string name, SimpleProduct simpleBodyProduct, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = clientDiagnostics.CreateScope("AllOperations.PutSimpleProductWithGrouping");
            scope.Start();
            try
            {
                using var message = CreatePutSimpleProductWithGroupingRequest(name, simpleBodyProduct);
                pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            var value = SimpleProduct.DeserializeSimpleProduct(document.RootElement);
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
