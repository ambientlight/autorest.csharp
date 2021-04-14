// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtParent
{
    /// <summary> A class representing the VirtualMachineExtensionImage data model. </summary>
    public partial class VirtualMachineExtensionImageData
    {
        /// <summary> Initializes a new instance of VirtualMachineExtensionImageData. </summary>
        internal VirtualMachineExtensionImageData()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineExtensionImageData. </summary>
        /// <param name="bar"> specifies the bar. </param>
        internal VirtualMachineExtensionImageData(string bar)
        {
            Bar = bar;
        }

        /// <summary> specifies the bar. </summary>
        public string Bar { get; }
    }
}