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

namespace validation.Models
{
    public partial class Product : IUtf8JsonSerializable, IJsonModel<Product>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<Product>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<Product>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Product>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Product)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(DisplayNames))
            {
                writer.WritePropertyName("display_names"u8);
                writer.WriteStartArray();
                foreach (var item in DisplayNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Capacity))
            {
                writer.WritePropertyName("capacity"u8);
                writer.WriteNumberValue(Capacity.Value);
            }
            if (Optional.IsDefined(Image))
            {
                writer.WritePropertyName("image"u8);
                writer.WriteStringValue(Image);
            }
            writer.WritePropertyName("child"u8);
            writer.WriteObjectValue(Child, options);
            writer.WritePropertyName("constChild"u8);
            writer.WriteObjectValue(ConstChild, options);
            writer.WritePropertyName("constInt"u8);
            writer.WriteNumberValue(ConstInt.ToSerialInt32());
            writer.WritePropertyName("constString"u8);
            writer.WriteStringValue(ConstString.ToString());
            if (Optional.IsDefined(ConstStringAsEnum))
            {
                writer.WritePropertyName("constStringAsEnum"u8);
                writer.WriteStringValue(ConstStringAsEnum.Value.ToString());
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        Product IJsonModel<Product>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Product>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Product)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProduct(document.RootElement, options);
        }

        internal static Product DeserializeProduct(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> displayNames = default;
            int? capacity = default;
            string image = default;
            ChildProduct child = default;
            ConstantProduct constChild = default;
            ProductConstInt constInt = default;
            ProductConstString constString = default;
            EnumConst? constStringAsEnum = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("display_names"u8))
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
                    displayNames = array;
                    continue;
                }
                if (property.NameEquals("capacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacity = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("image"u8))
                {
                    image = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("child"u8))
                {
                    child = ChildProduct.DeserializeChildProduct(property.Value, options);
                    continue;
                }
                if (property.NameEquals("constChild"u8))
                {
                    constChild = ConstantProduct.DeserializeConstantProduct(property.Value, options);
                    continue;
                }
                if (property.NameEquals("constInt"u8))
                {
                    constInt = new ProductConstInt(property.Value.GetInt32());
                    continue;
                }
                if (property.NameEquals("constString"u8))
                {
                    constString = new ProductConstString(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("constStringAsEnum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    constStringAsEnum = new EnumConst(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new Product(
                displayNames ?? new ChangeTrackingList<string>(),
                capacity,
                image,
                child,
                constChild,
                constInt,
                constString,
                constStringAsEnum,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<Product>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Product>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(Product)} does not support writing '{options.Format}' format.");
            }
        }

        Product IPersistableModel<Product>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Product>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProduct(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(Product)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<Product>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static Product FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeProduct(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}