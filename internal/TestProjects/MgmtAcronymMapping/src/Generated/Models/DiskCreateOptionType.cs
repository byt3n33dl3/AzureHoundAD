// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace MgmtAcronymMapping.Models
{
    /// <summary>
    /// Specifies how the virtual machine should be created.&lt;br&gt;&lt;br&gt; Possible values are:&lt;br&gt;&lt;br&gt; **Attach** \u2013 This value is used when you are using a specialized disk to create the virtual machine.&lt;br&gt;&lt;br&gt; **FromImage** \u2013 This value is used when you are using an image to create the virtual machine. If you are using a platform image, you also use the imageReference element described above. If you are using a marketplace image, you  also use the plan element previously described.
    /// Serialized Name: DiskCreateOptionTypes
    /// </summary>
    public readonly partial struct DiskCreateOptionType : IEquatable<DiskCreateOptionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DiskCreateOptionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DiskCreateOptionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FromImageValue = "FromImage";
        private const string EmptyValue = "Empty";
        private const string AttachValue = "Attach";

        /// <summary>
        /// FromImage
        /// Serialized Name: DiskCreateOptionTypes.FromImage
        /// </summary>
        public static DiskCreateOptionType FromImage { get; } = new DiskCreateOptionType(FromImageValue);
        /// <summary>
        /// Empty
        /// Serialized Name: DiskCreateOptionTypes.Empty
        /// </summary>
        public static DiskCreateOptionType Empty { get; } = new DiskCreateOptionType(EmptyValue);
        /// <summary>
        /// Attach
        /// Serialized Name: DiskCreateOptionTypes.Attach
        /// </summary>
        public static DiskCreateOptionType Attach { get; } = new DiskCreateOptionType(AttachValue);
        /// <summary> Determines if two <see cref="DiskCreateOptionType"/> values are the same. </summary>
        public static bool operator ==(DiskCreateOptionType left, DiskCreateOptionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DiskCreateOptionType"/> values are not the same. </summary>
        public static bool operator !=(DiskCreateOptionType left, DiskCreateOptionType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DiskCreateOptionType"/>. </summary>
        public static implicit operator DiskCreateOptionType(string value) => new DiskCreateOptionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DiskCreateOptionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DiskCreateOptionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}