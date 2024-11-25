// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace azure_parameter_grouping.Models
{
    /// <summary> Parameter group. </summary>
    public partial class ParameterGroupingPostRequiredParameters
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

        /// <summary> Initializes a new instance of <see cref="ParameterGroupingPostRequiredParameters"/>. </summary>
        /// <param name="path"> Path parameter. </param>
        /// <param name="body"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="path"/> is null. </exception>
        public ParameterGroupingPostRequiredParameters(string path, int body)
        {
            Argument.AssertNotNull(path, nameof(path));

            Path = path;
            Body = body;
        }

        /// <summary> Initializes a new instance of <see cref="ParameterGroupingPostRequiredParameters"/>. </summary>
        /// <param name="customHeader"></param>
        /// <param name="query"> Query parameter with default. </param>
        /// <param name="path"> Path parameter. </param>
        /// <param name="body"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ParameterGroupingPostRequiredParameters(string customHeader, int? query, string path, int body, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CustomHeader = customHeader;
            Query = query;
            Path = path;
            Body = body;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ParameterGroupingPostRequiredParameters"/> for deserialization. </summary>
        internal ParameterGroupingPostRequiredParameters()
        {
        }

        /// <summary> Gets or sets the custom header. </summary>
        public string CustomHeader { get; set; }
        /// <summary> Query parameter with default. </summary>
        public int? Query { get; set; }
        /// <summary> Path parameter. </summary>
        public string Path { get; }
        /// <summary> Gets the body. </summary>
        public int Body { get; }
    }
}