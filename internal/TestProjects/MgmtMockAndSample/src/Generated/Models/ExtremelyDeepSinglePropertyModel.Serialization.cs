// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MgmtMockAndSample.Models
{
    internal partial class ExtremelyDeepSinglePropertyModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Extreme))
            {
                writer.WritePropertyName("extreme"u8);
                writer.WriteObjectValue(Extreme);
            }
            writer.WriteEndObject();
        }

        internal static ExtremelyDeepSinglePropertyModel DeserializeExtremelyDeepSinglePropertyModel(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SuperDeepSinglePropertyModel extreme = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extreme"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extreme = SuperDeepSinglePropertyModel.DeserializeSuperDeepSinglePropertyModel(property.Value);
                    continue;
                }
            }
            return new ExtremelyDeepSinglePropertyModel(extreme);
        }
    }
}