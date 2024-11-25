// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace MgmtMockAndSample.Models
{
    public partial class KeyForDiskEncryptionSet : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SourceVault))
            {
                writer.WritePropertyName("sourceVault"u8);
                JsonSerializer.Serialize(writer, SourceVault);
            }
            writer.WritePropertyName("keyUrl"u8);
            writer.WriteStringValue(KeyUri.AbsoluteUri);
            if (Optional.IsDefined(NewKeyUri))
            {
                writer.WritePropertyName("newKeyUrl"u8);
                writer.WriteStringValue(NewKeyUri.AbsoluteUri);
            }
            if (Optional.IsCollectionDefined(NewListProperty))
            {
                writer.WritePropertyName("newListProperty"u8);
                writer.WriteStartArray();
                foreach (var item in NewListProperty)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static KeyForDiskEncryptionSet DeserializeKeyForDiskEncryptionSet(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WritableSubResource sourceVault = default;
            Uri keyUrl = default;
            Uri newKeyUrl = default;
            IList<string> newListProperty = default;
            IReadOnlyList<string> newReadOnlyListProperty = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceVault"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceVault = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("keyUrl"u8))
                {
                    keyUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("newKeyUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    newKeyUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("newListProperty"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    newListProperty = array;
                    continue;
                }
                if (property.NameEquals("newReadOnlyListProperty"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    newReadOnlyListProperty = array;
                    continue;
                }
            }
            return new KeyForDiskEncryptionSet(sourceVault, keyUrl, newKeyUrl, newListProperty ?? new ChangeTrackingList<string>(), newReadOnlyListProperty ?? new ChangeTrackingList<string>());
        }
    }
}