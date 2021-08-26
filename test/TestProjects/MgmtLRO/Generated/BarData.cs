// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using MgmtLRO.Models;

namespace MgmtLRO
{
    /// <summary> A class representing the Bar data model. </summary>
    public partial class BarData : TrackedResource
    {
        /// <summary> Initializes a new instance of BarData. </summary>
        /// <param name="location"> The location. </param>
        public BarData(Location location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of BarData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> The instance view of a resource. </param>
        internal BarData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, Location location, BarProperties properties) : base(id, name, type, tags, location)
        {
            Properties = properties;
        }

        /// <summary> The instance view of a resource. </summary>
        public BarProperties Properties { get; set; }
    }
}
