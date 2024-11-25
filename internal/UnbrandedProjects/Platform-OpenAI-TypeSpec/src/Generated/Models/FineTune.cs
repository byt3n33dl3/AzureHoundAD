// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Models
{
    /// <summary> The `FineTune` object represents a legacy fine-tune job that has been created through the API. </summary>
    [Obsolete("deprecated")]
    public partial class FineTune
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
        /// <summary> Initializes a new instance of <see cref="FineTune"/>. </summary>
        /// <param name="id"> The object identifier, which can be referenced in the API endpoints. </param>
        /// <param name="createdAt"> The Unix timestamp (in seconds) for when the fine-tuning job was created. </param>
        /// <param name="updatedAt"> The Unix timestamp (in seconds) for when the fine-tuning job was last updated. </param>
        /// <param name="model"> The base model that is being fine-tuned. </param>
        /// <param name="fineTunedModel"> The name of the fine-tuned model that is being created. </param>
        /// <param name="organizationId"> The organization that owns the fine-tuning job. </param>
        /// <param name="status">
        /// The current status of the fine-tuning job, which can be either `created`, `running`,
        /// `succeeded`, `failed`, or `cancelled`.
        /// </param>
        /// <param name="hyperparams">
        /// The hyperparameters used for the fine-tuning job. See the
        /// [fine-tuning guide](/docs/guides/legacy-fine-tuning/hyperparameters) for more details.
        /// </param>
        /// <param name="trainingFiles"> The list of files used for training. </param>
        /// <param name="validationFiles"> The list of files used for validation. </param>
        /// <param name="resultFiles"> The compiled results files for the fine-tuning job. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="model"/>, <paramref name="organizationId"/>, <paramref name="hyperparams"/>, <paramref name="trainingFiles"/>, <paramref name="validationFiles"/> or <paramref name="resultFiles"/> is null. </exception>
        internal FineTune(string id, DateTimeOffset createdAt, DateTimeOffset updatedAt, string model, string fineTunedModel, string organizationId, FineTuneStatus status, FineTuneHyperparams hyperparams, IEnumerable<OpenAIFile> trainingFiles, IEnumerable<OpenAIFile> validationFiles, IEnumerable<OpenAIFile> resultFiles)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(model, nameof(model));
            Argument.AssertNotNull(organizationId, nameof(organizationId));
            Argument.AssertNotNull(hyperparams, nameof(hyperparams));
            Argument.AssertNotNull(trainingFiles, nameof(trainingFiles));
            Argument.AssertNotNull(validationFiles, nameof(validationFiles));
            Argument.AssertNotNull(resultFiles, nameof(resultFiles));

            Id = id;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Model = model;
            FineTunedModel = fineTunedModel;
            OrganizationId = organizationId;
            Status = status;
            Hyperparams = hyperparams;
            TrainingFiles = trainingFiles.ToList();
            ValidationFiles = validationFiles.ToList();
            ResultFiles = resultFiles.ToList();
            Events = new ChangeTrackingList<FineTuneEvent>();
        }

        /// <summary> Initializes a new instance of <see cref="FineTune"/>. </summary>
        /// <param name="id"> The object identifier, which can be referenced in the API endpoints. </param>
        /// <param name="object"> The object type, which is always "fine-tune". </param>
        /// <param name="createdAt"> The Unix timestamp (in seconds) for when the fine-tuning job was created. </param>
        /// <param name="updatedAt"> The Unix timestamp (in seconds) for when the fine-tuning job was last updated. </param>
        /// <param name="model"> The base model that is being fine-tuned. </param>
        /// <param name="fineTunedModel"> The name of the fine-tuned model that is being created. </param>
        /// <param name="organizationId"> The organization that owns the fine-tuning job. </param>
        /// <param name="status">
        /// The current status of the fine-tuning job, which can be either `created`, `running`,
        /// `succeeded`, `failed`, or `cancelled`.
        /// </param>
        /// <param name="hyperparams">
        /// The hyperparameters used for the fine-tuning job. See the
        /// [fine-tuning guide](/docs/guides/legacy-fine-tuning/hyperparameters) for more details.
        /// </param>
        /// <param name="trainingFiles"> The list of files used for training. </param>
        /// <param name="validationFiles"> The list of files used for validation. </param>
        /// <param name="resultFiles"> The compiled results files for the fine-tuning job. </param>
        /// <param name="events"> The list of events that have been observed in the lifecycle of the FineTune job. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FineTune(string id, FineTuneObject @object, DateTimeOffset createdAt, DateTimeOffset updatedAt, string model, string fineTunedModel, string organizationId, FineTuneStatus status, FineTuneHyperparams hyperparams, IReadOnlyList<OpenAIFile> trainingFiles, IReadOnlyList<OpenAIFile> validationFiles, IReadOnlyList<OpenAIFile> resultFiles, IReadOnlyList<FineTuneEvent> events, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Object = @object;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Model = model;
            FineTunedModel = fineTunedModel;
            OrganizationId = organizationId;
            Status = status;
            Hyperparams = hyperparams;
            TrainingFiles = trainingFiles;
            ValidationFiles = validationFiles;
            ResultFiles = resultFiles;
            Events = events;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FineTune"/> for deserialization. </summary>
        internal FineTune()
        {
        }

        /// <summary> The object identifier, which can be referenced in the API endpoints. </summary>
        public string Id { get; }
        /// <summary> The object type, which is always "fine-tune". </summary>
        public FineTuneObject Object { get; } = FineTuneObject.FineTune;

        /// <summary> The Unix timestamp (in seconds) for when the fine-tuning job was created. </summary>
        public DateTimeOffset CreatedAt { get; }
        /// <summary> The Unix timestamp (in seconds) for when the fine-tuning job was last updated. </summary>
        public DateTimeOffset UpdatedAt { get; }
        /// <summary> The base model that is being fine-tuned. </summary>
        public string Model { get; }
        /// <summary> The name of the fine-tuned model that is being created. </summary>
        public string FineTunedModel { get; }
        /// <summary> The organization that owns the fine-tuning job. </summary>
        public string OrganizationId { get; }
        /// <summary>
        /// The current status of the fine-tuning job, which can be either `created`, `running`,
        /// `succeeded`, `failed`, or `cancelled`.
        /// </summary>
        public FineTuneStatus Status { get; }
        /// <summary>
        /// The hyperparameters used for the fine-tuning job. See the
        /// [fine-tuning guide](/docs/guides/legacy-fine-tuning/hyperparameters) for more details.
        /// </summary>
        public FineTuneHyperparams Hyperparams { get; }
        /// <summary> The list of files used for training. </summary>
        public IReadOnlyList<OpenAIFile> TrainingFiles { get; }
        /// <summary> The list of files used for validation. </summary>
        public IReadOnlyList<OpenAIFile> ValidationFiles { get; }
        /// <summary> The compiled results files for the fine-tuning job. </summary>
        public IReadOnlyList<OpenAIFile> ResultFiles { get; }
        /// <summary> The list of events that have been observed in the lifecycle of the FineTune job. </summary>
        public IReadOnlyList<FineTuneEvent> Events { get; }
    }
}