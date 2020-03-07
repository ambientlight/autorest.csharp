// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class ApplicationGatewayPathRulePropertiesFormat : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Paths != null)
            {
                writer.WritePropertyName("paths");
                writer.WriteStartArray();
                foreach (var item in Paths)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (BackendAddressPool != null)
            {
                writer.WritePropertyName("backendAddressPool");
                writer.WriteObjectValue(BackendAddressPool);
            }
            if (BackendHttpSettings != null)
            {
                writer.WritePropertyName("backendHttpSettings");
                writer.WriteObjectValue(BackendHttpSettings);
            }
            if (RedirectConfiguration != null)
            {
                writer.WritePropertyName("redirectConfiguration");
                writer.WriteObjectValue(RedirectConfiguration);
            }
            if (RewriteRuleSet != null)
            {
                writer.WritePropertyName("rewriteRuleSet");
                writer.WriteObjectValue(RewriteRuleSet);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (FirewallPolicy != null)
            {
                writer.WritePropertyName("firewallPolicy");
                writer.WriteObjectValue(FirewallPolicy);
            }
            writer.WriteEndObject();
        }
        internal static ApplicationGatewayPathRulePropertiesFormat DeserializeApplicationGatewayPathRulePropertiesFormat(JsonElement element)
        {
            ApplicationGatewayPathRulePropertiesFormat result = new ApplicationGatewayPathRulePropertiesFormat();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("paths"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Paths = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Paths.Add(item.GetString());
                    }
                    continue;
                }
                if (property.NameEquals("backendAddressPool"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.BackendAddressPool = SubResource.DeserializeSubResource(property.Value);
                    continue;
                }
                if (property.NameEquals("backendHttpSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.BackendHttpSettings = SubResource.DeserializeSubResource(property.Value);
                    continue;
                }
                if (property.NameEquals("redirectConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.RedirectConfiguration = SubResource.DeserializeSubResource(property.Value);
                    continue;
                }
                if (property.NameEquals("rewriteRuleSet"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.RewriteRuleSet = SubResource.DeserializeSubResource(property.Value);
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ProvisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("firewallPolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.FirewallPolicy = SubResource.DeserializeSubResource(property.Value);
                    continue;
                }
            }
            return result;
        }
    }
}