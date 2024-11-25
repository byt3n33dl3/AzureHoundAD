// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ModelReaderWriterValidationTypeSpec.Models
{
    /// <summary> The type of the token that the alias path is referring to. </summary>
    public readonly partial struct ResourceTypeAliasPathTokenType : IEquatable<ResourceTypeAliasPathTokenType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ResourceTypeAliasPathTokenType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResourceTypeAliasPathTokenType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string AnyValue = "Any";
        private const string StringValue = "String";
        private const string ObjectValue = "Object";
        private const string ArrayValue = "Array";
        private const string IntegerValue = "Integer";
        private const string NumberValue = "Number";
        private const string BooleanValue = "Boolean";

        /// <summary> The token type is not specified. </summary>
        public static ResourceTypeAliasPathTokenType NotSpecified { get; } = new ResourceTypeAliasPathTokenType(NotSpecifiedValue);
        /// <summary> The token type can be anything. </summary>
        public static ResourceTypeAliasPathTokenType Any { get; } = new ResourceTypeAliasPathTokenType(AnyValue);
        /// <summary> The token type is string. </summary>
        public static ResourceTypeAliasPathTokenType String { get; } = new ResourceTypeAliasPathTokenType(StringValue);
        /// <summary> The token type is object. </summary>
        public static ResourceTypeAliasPathTokenType Object { get; } = new ResourceTypeAliasPathTokenType(ObjectValue);
        /// <summary> The token type is array. </summary>
        public static ResourceTypeAliasPathTokenType Array { get; } = new ResourceTypeAliasPathTokenType(ArrayValue);
        /// <summary> The token type is integer. </summary>
        public static ResourceTypeAliasPathTokenType Integer { get; } = new ResourceTypeAliasPathTokenType(IntegerValue);
        /// <summary> The token type is number. </summary>
        public static ResourceTypeAliasPathTokenType Number { get; } = new ResourceTypeAliasPathTokenType(NumberValue);
        /// <summary> The token type is boolean. </summary>
        public static ResourceTypeAliasPathTokenType Boolean { get; } = new ResourceTypeAliasPathTokenType(BooleanValue);
        /// <summary> Determines if two <see cref="ResourceTypeAliasPathTokenType"/> values are the same. </summary>
        public static bool operator ==(ResourceTypeAliasPathTokenType left, ResourceTypeAliasPathTokenType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResourceTypeAliasPathTokenType"/> values are not the same. </summary>
        public static bool operator !=(ResourceTypeAliasPathTokenType left, ResourceTypeAliasPathTokenType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ResourceTypeAliasPathTokenType"/>. </summary>
        public static implicit operator ResourceTypeAliasPathTokenType(string value) => new ResourceTypeAliasPathTokenType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResourceTypeAliasPathTokenType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResourceTypeAliasPathTokenType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}