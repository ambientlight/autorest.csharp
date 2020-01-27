// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class SuggestRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Filter != null)
            {
                writer.WritePropertyName("filter");
                writer.WriteStringValue(Filter);
            }
            if (UseFuzzyMatching != null)
            {
                writer.WritePropertyName("fuzzy");
                writer.WriteBooleanValue(UseFuzzyMatching.Value);
            }
            if (HighlightPostTag != null)
            {
                writer.WritePropertyName("highlightPostTag");
                writer.WriteStringValue(HighlightPostTag);
            }
            if (HighlightPreTag != null)
            {
                writer.WritePropertyName("highlightPreTag");
                writer.WriteStringValue(HighlightPreTag);
            }
            if (MinimumCoverage != null)
            {
                writer.WritePropertyName("minimumCoverage");
                writer.WriteNumberValue(MinimumCoverage.Value);
            }
            if (OrderBy != null)
            {
                writer.WritePropertyName("orderby");
                writer.WriteStringValue(OrderBy);
            }
            if (SearchText != null)
            {
                writer.WritePropertyName("search");
                writer.WriteStringValue(SearchText);
            }
            if (SearchFields != null)
            {
                writer.WritePropertyName("searchFields");
                writer.WriteStringValue(SearchFields);
            }
            if (Select != null)
            {
                writer.WritePropertyName("select");
                writer.WriteStringValue(Select);
            }
            if (SuggesterName != null)
            {
                writer.WritePropertyName("suggesterName");
                writer.WriteStringValue(SuggesterName);
            }
            if (Top != null)
            {
                writer.WritePropertyName("top");
                writer.WriteNumberValue(Top.Value);
            }
            writer.WriteEndObject();
        }
        internal static SuggestRequest DeserializeSuggestRequest(JsonElement element)
        {
            SuggestRequest result = new SuggestRequest();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("filter"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Filter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fuzzy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.UseFuzzyMatching = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("highlightPostTag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.HighlightPostTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("highlightPreTag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.HighlightPreTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("minimumCoverage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.MinimumCoverage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("orderby"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.OrderBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("search"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.SearchText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("searchFields"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.SearchFields = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("select"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Select = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("suggesterName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.SuggesterName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("top"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Top = property.Value.GetInt32();
                    continue;
                }
            }
            return result;
        }
    }
}