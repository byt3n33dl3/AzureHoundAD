// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Models
{
    public partial class CreateEditResponseChoice : IJsonModel<CreateEditResponseChoice>
    {
        void IJsonModel<CreateEditResponseChoice>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateEditResponseChoice>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreateEditResponseChoice)} does not support writing '{format}' format.");
            }

            if (SerializedAdditionalRawData?.ContainsKey("text") != true)
            {
                writer.WritePropertyName("text"u8);
                writer.WriteStringValue(Text);
            }
            if (SerializedAdditionalRawData?.ContainsKey("index") != true)
            {
                writer.WritePropertyName("index"u8);
                writer.WriteNumberValue(Index);
            }
            if (SerializedAdditionalRawData?.ContainsKey("finish_reason") != true)
            {
                writer.WritePropertyName("finish_reason"u8);
                writer.WriteStringValue(FinishReason.ToSerialString());
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

        CreateEditResponseChoice IJsonModel<CreateEditResponseChoice>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateEditResponseChoice>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CreateEditResponseChoice)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCreateEditResponseChoice(document.RootElement, options);
        }

        internal static CreateEditResponseChoice DeserializeCreateEditResponseChoice(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string text = default;
            long index = default;
            CreateEditResponseChoiceFinishReason finishReason = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("index"u8))
                {
                    index = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("finish_reason"u8))
                {
                    finishReason = property.Value.GetString().ToCreateEditResponseChoiceFinishReason();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CreateEditResponseChoice(text, index, finishReason, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CreateEditResponseChoice>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateEditResponseChoice>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CreateEditResponseChoice)} does not support writing '{options.Format}' format.");
            }
        }

        CreateEditResponseChoice IPersistableModel<CreateEditResponseChoice>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CreateEditResponseChoice>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCreateEditResponseChoice(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CreateEditResponseChoice)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CreateEditResponseChoice>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static CreateEditResponseChoice FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeCreateEditResponseChoice(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
