// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace CustomizationsInTsp.Models
{
    /// <summary> Renamed model (original name: ModelToRename). </summary>
    public partial class RenamedModel
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RenamedModel"/>. </summary>
        /// <param name="requiredIntOnBase"> Required int. </param>
        public RenamedModel(int requiredIntOnBase)
        {
            RequiredIntOnBase = requiredIntOnBase;
        }

        /// <summary> Initializes a new instance of <see cref="RenamedModel"/>. </summary>
        /// <param name="requiredIntOnBase"> Required int. </param>
        /// <param name="optionalInt"> Optional int. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RenamedModel(int requiredIntOnBase, int? optionalInt, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RequiredIntOnBase = requiredIntOnBase;
            OptionalInt = optionalInt;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RenamedModel"/> for deserialization. </summary>
        internal RenamedModel()
        {
        }

        /// <summary> Required int. </summary>
        public int RequiredIntOnBase { get; set; }
    }
}