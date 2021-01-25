// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace CognitiveSearch.Models
{
    /// <summary> Response from a get service statistics request. If successful, it includes service level counters and limits. </summary>
    public partial class ServiceStatistics
    {
        /// <summary> Initializes a new instance of ServiceStatistics. </summary>
        /// <param name="counters"> Service level resource counters. </param>
        /// <param name="limits"> Service level general limits. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="counters"/> or <paramref name="limits"/> is null. </exception>
        internal ServiceStatistics(ServiceCounters counters, ServiceLimits limits)
        {
            if (counters == null)
            {
                throw new ArgumentNullException(nameof(counters));
            }
            if (limits == null)
            {
                throw new ArgumentNullException(nameof(limits));
            }

            Counters = counters;
            Limits = limits;
        }

        /// <summary> Service level resource counters. </summary>
        public ServiceCounters Counters { get; }
        /// <summary> Service level general limits. </summary>
        public ServiceLimits Limits { get; }
    }
}