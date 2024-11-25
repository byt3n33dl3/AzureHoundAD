// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;

namespace Inheritance.Models
{
    [JsonConverter(typeof(AnotherDerivedClassWithExtensibleEnumDiscriminatorConverter))]
    public partial class AnotherDerivedClassWithExtensibleEnumDiscriminator : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("DiscriminatorProperty"u8);
            writer.WriteStringValue(DiscriminatorProperty.ToString());
            writer.WriteEndObject();
        }

        internal static AnotherDerivedClassWithExtensibleEnumDiscriminator DeserializeAnotherDerivedClassWithExtensibleEnumDiscriminator(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BaseClassWithEntensibleEnumDiscriminatorEnum discriminatorProperty = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("DiscriminatorProperty"u8))
                {
                    discriminatorProperty = new BaseClassWithEntensibleEnumDiscriminatorEnum(property.Value.GetString());
                    continue;
                }
            }
            return new AnotherDerivedClassWithExtensibleEnumDiscriminator(discriminatorProperty);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new AnotherDerivedClassWithExtensibleEnumDiscriminator FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAnotherDerivedClassWithExtensibleEnumDiscriminator(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal partial class AnotherDerivedClassWithExtensibleEnumDiscriminatorConverter : JsonConverter<AnotherDerivedClassWithExtensibleEnumDiscriminator>
        {
            public override void Write(Utf8JsonWriter writer, AnotherDerivedClassWithExtensibleEnumDiscriminator model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }

            public override AnotherDerivedClassWithExtensibleEnumDiscriminator Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAnotherDerivedClassWithExtensibleEnumDiscriminator(document.RootElement);
            }
        }
    }
}