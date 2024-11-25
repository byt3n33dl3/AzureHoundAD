// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Models
{
    public partial class OpenAIFile : IJsonModel<OpenAIFile>
    {
        void IJsonModel<OpenAIFile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenAIFile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OpenAIFile)} does not support writing '{format}' format.");
            }

            if (SerializedAdditionalRawData?.ContainsKey("id") != true)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (SerializedAdditionalRawData?.ContainsKey("object") != true)
            {
                writer.WritePropertyName("object"u8);
                writer.WriteStringValue(Object.ToString());
            }
            if (SerializedAdditionalRawData?.ContainsKey("bytes") != true)
            {
                writer.WritePropertyName("bytes"u8);
                writer.WriteNumberValue(Bytes);
            }
            if (SerializedAdditionalRawData?.ContainsKey("createdAt") != true)
            {
                writer.WritePropertyName("createdAt"u8);
                writer.WriteNumberValue(CreatedAt, "U");
            }
            if (SerializedAdditionalRawData?.ContainsKey("filename") != true)
            {
                writer.WritePropertyName("filename"u8);
                writer.WriteStringValue(Filename);
            }
            if (SerializedAdditionalRawData?.ContainsKey("purpose") != true)
            {
                writer.WritePropertyName("purpose"u8);
                writer.WriteStringValue(Purpose);
            }
            if (SerializedAdditionalRawData?.ContainsKey("status") != true)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.ToSerialString());
            }
            if (SerializedAdditionalRawData?.ContainsKey("status_details") != true && Optional.IsDefined(StatusDetails))
            {
                if (StatusDetails != null)
                {
                    writer.WritePropertyName("status_details"u8);
                    writer.WriteStringValue(StatusDetails);
                }
                else
                {
                    writer.WriteNull("status_details");
                }
            }
            if (SerializedAdditionalRawData != null)
            {
                foreach (var item in SerializedAdditionalRawData)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
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

        OpenAIFile IJsonModel<OpenAIFile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenAIFile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OpenAIFile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOpenAIFile(document.RootElement, options);
        }

        internal static OpenAIFile DeserializeOpenAIFile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            OpenAIFileObject @object = default;
            long bytes = default;
            DateTimeOffset createdAt = default;
            string filename = default;
            string purpose = default;
            OpenAIFileStatus status = default;
            string statusDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("object"u8))
                {
                    @object = new OpenAIFileObject(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("bytes"u8))
                {
                    bytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("createdAt"u8))
                {
                    createdAt = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                    continue;
                }
                if (property.NameEquals("filename"u8))
                {
                    filename = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("purpose"u8))
                {
                    purpose = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString().ToOpenAIFileStatus();
                    continue;
                }
                if (property.NameEquals("status_details"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        statusDetails = null;
                        continue;
                    }
                    statusDetails = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new OpenAIFile(
                id,
                @object,
                bytes,
                createdAt,
                filename,
                purpose,
                status,
                statusDetails,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OpenAIFile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenAIFile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OpenAIFile)} does not support writing '{options.Format}' format.");
            }
        }

        OpenAIFile IPersistableModel<OpenAIFile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenAIFile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOpenAIFile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OpenAIFile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OpenAIFile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static OpenAIFile FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeOpenAIFile(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}