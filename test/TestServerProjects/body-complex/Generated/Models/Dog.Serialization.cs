// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;

namespace body_complex.Models.V20160229
{
    public partial class DogSerializer
    {
        internal static void Serialize(Dog model, Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (model.Food != null)
            {
                writer.WritePropertyName("food");
                writer.WriteStringValue(model.Food);
            }

            if (model.Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteNumberValue(model.Id.Value);
            }
            if (model.Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(model.Name);
            }
            writer.WriteEndObject();
        }
        internal static Dog Deserialize(JsonElement element)
        {
            var result = new Dog();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("food"))
                {
                    result.Food = property.Value.GetString();
                    continue;
                }

                if (property.NameEquals("id"))
                {
                    result.Id = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    result.Name = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
