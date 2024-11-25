﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using AutoRest.CSharp.Output.Builders;

namespace AutoRest.CSharp.Common.Input
{
    internal sealed class TypeSpecInputModelPropertyConverter : JsonConverter<InputModelProperty>
    {
        private readonly TypeSpecReferenceHandler _referenceHandler;

        public TypeSpecInputModelPropertyConverter(TypeSpecReferenceHandler referenceHandler)
        {
            _referenceHandler = referenceHandler;
        }

        public override InputModelProperty Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => reader.ReadReferenceAndResolve<InputModelProperty>(_referenceHandler.CurrentResolver) ?? ReadInputModelProperty(ref reader, null, null, options, _referenceHandler.CurrentResolver);

        public override void Write(Utf8JsonWriter writer, InputModelProperty value, JsonSerializerOptions options)
            => throw new NotSupportedException("Writing not supported");

        private static InputModelProperty ReadInputModelProperty(ref Utf8JsonReader reader, string? id, string? name, JsonSerializerOptions options, ReferenceResolver resolver)
        {
            var isFirstProperty = true;
            string? serializedName = null;
            string? description = null;
            InputType? propertyType = null;
            InputConstant? defaultValue = null;
            bool isReadOnly = false;
            bool isOptional = false;
            bool isDiscriminator = false;
            IReadOnlyList<InputDecoratorInfo>? decorators = null;
            bool isFlattened = false;

            while (reader.TokenType != JsonTokenType.EndObject)
            {
                var isKnownProperty = reader.TryReadReferenceId(ref isFirstProperty, ref id)
                    || reader.TryReadString("name", ref name)
                    || reader.TryReadString("serializedName", ref serializedName)
                    || reader.TryReadString("description", ref description)
                    || reader.TryReadWithConverter("type", options, ref propertyType)
                    || reader.TryReadBoolean("readOnly", ref isReadOnly)
                    || reader.TryReadBoolean("optional", ref isOptional)
                    || reader.TryReadBoolean("discriminator", ref isDiscriminator)
                    || reader.TryReadWithConverter("decorators", options, ref decorators)
                    || reader.TryReadBoolean("flatten", ref isFlattened);

                if (!isKnownProperty)
                {
                    reader.SkipProperty();
                }
            }

            name = name ?? throw new JsonException($"{nameof(InputModelProperty)} must have a name.");
            description = BuilderHelpers.EscapeXmlDocDescription(description ?? string.Empty);
            propertyType = propertyType ?? throw new JsonException($"{nameof(InputModelProperty)} must have a property type.");

            if (propertyType is InputLiteralType lt)
            {
                defaultValue = new InputConstant(lt.Value, lt.ValueType);
                propertyType = lt.ValueType;
            }

            var property = new InputModelProperty(name, serializedName ?? name, description, propertyType, defaultValue, !isOptional, isReadOnly, isDiscriminator)
            {
                Decorators = decorators ?? [],
                IsFlattened = isFlattened
            };
            if (id != null)
            {
                resolver.AddReference(id, property);
            }

            return property;
        }
    }
}