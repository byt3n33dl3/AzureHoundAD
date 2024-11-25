// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Models
{
    /// <summary> The CreateModerationResponse. </summary>
    public partial class CreateModerationResponse
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
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        /// <summary> Initializes a new instance of <see cref="CreateModerationResponse"/>. </summary>
        /// <param name="id"> The unique identifier for the moderation request. </param>
        /// <param name="model"> The model used to generate the moderation results. </param>
        /// <param name="results"> A list of moderation objects. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="model"/> or <paramref name="results"/> is null. </exception>
        internal CreateModerationResponse(string id, string model, IEnumerable<CreateModerationResponseResult> results)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(model, nameof(model));
            Argument.AssertNotNull(results, nameof(results));

            Id = id;
            Model = model;
            Results = results.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="CreateModerationResponse"/>. </summary>
        /// <param name="id"> The unique identifier for the moderation request. </param>
        /// <param name="model"> The model used to generate the moderation results. </param>
        /// <param name="results"> A list of moderation objects. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateModerationResponse(string id, string model, IReadOnlyList<CreateModerationResponseResult> results, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Model = model;
            Results = results;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CreateModerationResponse"/> for deserialization. </summary>
        internal CreateModerationResponse()
        {
        }

        /// <summary> The unique identifier for the moderation request. </summary>
        public string Id { get; }
        /// <summary> The model used to generate the moderation results. </summary>
        public string Model { get; }
        /// <summary> A list of moderation objects. </summary>
        public IReadOnlyList<CreateModerationResponseResult> Results { get; }
    }
}