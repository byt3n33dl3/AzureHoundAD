// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace MgmtDiscriminator.Models
{
    /// <summary> A model with a single object for testing safe-flattening. </summary>
    internal partial class Sku1
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="Sku1"/>. </summary>
        public Sku1()
        {
        }

        /// <summary> Initializes a new instance of <see cref="Sku1"/>. </summary>
        /// <param name="name1"> The middle sku property. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Sku1(Sku2 name1, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name1 = name1;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The middle sku property. </summary>
        internal Sku2 Name1 { get; set; }
        /// <summary> The childmost sku property. </summary>
        [WirePath("name1.nestedName")]
        public string NestedName
        {
            get => Name1 is null ? default : Name1.NestedName;
            set => Name1 = new Sku2(value);
        }
    }
}