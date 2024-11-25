// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace ModelReaderWriterValidationTypeSpec.Models
{
    public partial class ModelX : IUtf8JsonSerializable, IJsonModel<ModelX>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ModelX>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ModelX>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelX>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ModelX)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsCollectionDefined(Fields))
            {
                writer.WritePropertyName("fields"u8);
                writer.WriteStartArray();
                foreach (var item in Fields)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NullProperty))
            {
                writer.WritePropertyName("nullProperty"u8);
                writer.WriteNumberValue(NullProperty.Value);
            }
            if (Optional.IsCollectionDefined(KeyValuePairs))
            {
                writer.WritePropertyName("keyValuePairs"u8);
                writer.WriteStartObject();
                foreach (var item in KeyValuePairs)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("xProperty"u8);
                writer.WriteNumberValue(XProperty);
            }
        }

        ModelX IJsonModel<ModelX>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelX>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ModelX)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeModelX(document.RootElement, options);
        }

        internal static ModelX DeserializeModelX(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> fields = default;
            int? nullProperty = default;
            IDictionary<string, string> keyValuePairs = default;
            int xProperty = default;
            string kind = default;
            string name = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fields"u8))
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
                    fields = array;
                    continue;
                }
                if (property.NameEquals("nullProperty"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nullProperty = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("keyValuePairs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    keyValuePairs = dictionary;
                    continue;
                }
                if (property.NameEquals("xProperty"u8))
                {
                    xProperty = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ModelX(
                kind,
                name,
                serializedAdditionalRawData,
                fields ?? new ChangeTrackingList<string>(),
                nullProperty,
                keyValuePairs ?? new ChangeTrackingDictionary<string, string>(),
                xProperty);
        }

        BinaryData IPersistableModel<ModelX>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelX>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ModelX)} does not support writing '{options.Format}' format.");
            }
        }

        ModelX IPersistableModel<ModelX>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelX>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeModelX(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ModelX)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ModelX>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new ModelX FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeModelX(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}