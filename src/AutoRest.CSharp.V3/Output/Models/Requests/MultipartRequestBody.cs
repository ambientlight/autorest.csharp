﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Reflection.Metadata;

namespace AutoRest.CSharp.V3.Output.Models.Requests
{
    internal class MultipartRequestBody : RequestBody
    {
        public ReferenceOrConstant[] Value { get; }

        public MultipartRequestBody(ReferenceOrConstant[] value)
        {
            Value = value;
        }

    }
}
