// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class PrivateLinkServicePropertiesAutoApproval : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Subscriptions != null)
            {
                writer.WritePropertyName("subscriptions");
                writer.WriteStartArray();
                foreach (var item in Subscriptions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
        internal static PrivateLinkServicePropertiesAutoApproval DeserializePrivateLinkServicePropertiesAutoApproval(JsonElement element)
        {
            PrivateLinkServicePropertiesAutoApproval result = new PrivateLinkServicePropertiesAutoApproval();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subscriptions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Subscriptions = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Subscriptions.Add(item.GetString());
                    }
                    continue;
                }
            }
            return result;
        }
    }
}