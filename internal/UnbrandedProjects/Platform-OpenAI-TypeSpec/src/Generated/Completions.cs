// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Threading.Tasks;
using OpenAI.Models;

namespace OpenAI
{
    // Data plane generated sub-client.
    /// <summary> The Completions sub-client. </summary>
    public partial class Completions
    {
        private const string AuthorizationHeader = "Authorization";
        private readonly ApiKeyCredential _keyCredential;
        private const string AuthorizationApiKeyPrefix = "Bearer";
        private readonly ClientPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual ClientPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of Completions for mocking. </summary>
        protected Completions()
        {
        }

        /// <summary> Initializes a new instance of Completions. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="keyCredential"> The key credential to copy. </param>
        /// <param name="endpoint"> Service host. </param>
        internal Completions(ClientPipeline pipeline, ApiKeyCredential keyCredential, Uri endpoint)
        {
            _pipeline = pipeline;
            _keyCredential = keyCredential;
            _endpoint = endpoint;
        }

        /// <summary> Create. </summary>
        /// <param name="model">
        /// ID of the model to use. You can use the [List models](/docs/api-reference/models/list) API to
        /// see all of your available models, or see our [Model overview](/docs/models/overview) for
        /// descriptions of them.
        /// </param>
        /// <param name="prompt">
        /// The prompt(s) to generate completions for, encoded as a string, array of strings, array of
        /// tokens, or array of token arrays.
        ///
        /// Note that &lt;|endoftext|&gt; is the document separator that the model sees during training, so if a
        /// prompt is not specified the model will generate as if from the beginning of a new document.
        /// </param>
        /// <param name="suffix"> The suffix that comes after a completion of inserted text. </param>
        /// <param name="temperature">
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output
        /// more random, while lower values like 0.2 will make it more focused and deterministic.
        ///
        /// We generally recommend altering this or `top_p` but not both.
        /// </param>
        /// <param name="topP">
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers
        /// the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising
        /// the top 10% probability mass are considered.
        ///
        /// We generally recommend altering this or `temperature` but not both.
        /// </param>
        /// <param name="n">
        /// How many completions to generate for each prompt.
        /// **Note:** Because this parameter generates many completions, it can quickly consume your token
        /// quota. Use carefully and ensure that you have reasonable settings for `max_tokens` and `stop`.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of [tokens](/tokenizer) to generate in the completion.
        ///
        /// The token count of your prompt plus `max_tokens` cannot exceed the model's context length.
        /// [Example Python code](https://github.com/openai/openai-cookbook/blob/main/examples/How_to_count_tokens_with_tiktoken.ipynb)
        /// for counting tokens.
        /// </param>
        /// <param name="stop"> Up to 4 sequences where the API will stop generating further tokens. </param>
        /// <param name="presencePenalty">
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on whether they appear
        /// in the text so far, increasing the model's likelihood to talk about new topics.
        ///
        /// [See more information about frequency and presence penalties.](/docs/guides/gpt/parameter-details)
        /// </param>
        /// <param name="frequencyPenalty">
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing
        /// frequency in the text so far, decreasing the model's likelihood to repeat the same line
        /// verbatim.
        ///
        /// [See more information about frequency and presence penalties.](/docs/guides/gpt/parameter-details)
        /// </param>
        /// <param name="logitBias">
        /// Modify the likelihood of specified tokens appearing in the completion.
        /// Accepts a json object that maps tokens (specified by their token ID in the tokenizer) to an
        /// associated bias value from -100 to 100. Mathematically, the bias is added to the logits
        /// generated by the model prior to sampling. The exact effect will vary per model, but values
        /// between -1 and 1 should decrease or increase likelihood of selection; values like -100 or 100
        /// should result in a ban or exclusive selection of the relevant token.
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect
        /// abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids).
        /// </param>
        /// <param name="stream">
        /// If set, partial message deltas will be sent, like in ChatGPT. Tokens will be sent as data-only
        /// [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format)
        /// as they become available, with the stream terminated by a `data: [DONE]` message.
        /// [Example Python code](https://github.com/openai/openai-cookbook/blob/main/examples/How_to_stream_completions.ipynb).
        /// </param>
        /// <param name="logprobs">
        /// Include the log probabilities on the `logprobs` most likely tokens, as well the chosen tokens.
        /// For example, if `logprobs` is 5, the API will return a list of the 5 most likely tokens. The
        /// API will always return the `logprob` of the sampled token, so there may be up to `logprobs+1`
        /// elements in the response.
        ///
        /// The maximum value for `logprobs` is 5.
        /// </param>
        /// <param name="echo"> Echo back the prompt in addition to the completion. </param>
        /// <param name="bestOf">
        /// Generates `best_of` completions server-side and returns the "best" (the one with the highest
        /// log probability per token). Results cannot be streamed.
        ///
        /// When used with `n`, `best_of` controls the number of candidate completions and `n` specifies
        /// how many to return – `best_of` must be greater than `n`.
        ///
        /// **Note:** Because this parameter generates many completions, it can quickly consume your token
        /// quota. Use carefully and ensure that you have reasonable settings for `max_tokens` and `stop`.
        /// </param>
        public virtual async Task<ClientResult<CreateCompletionResponse>> CreateAsync(CreateCompletionRequestModel model, BinaryData prompt, string suffix = null, double? temperature = null, double? topP = null, long? n = null, long? maxTokens = null, BinaryData stop = null, double? presencePenalty = null, double? frequencyPenalty = null, IReadOnlyDictionary<string, long> logitBias = null, string user = null, bool? stream = null, long? logprobs = null, bool? echo = null, long? bestOf = null)
        {
            CreateCompletionRequest createCompletionRequest = new CreateCompletionRequest(
                model,
                prompt,
                suffix,
                temperature,
                topP,
                n,
                maxTokens,
                stop,
                presencePenalty,
                frequencyPenalty,
                logitBias ?? new ChangeTrackingDictionary<string, long>(),
                user,
                stream,
                logprobs,
                echo,
                bestOf,
                null);
            ClientResult result = await CreateAsync(createCompletionRequest.ToBinaryContent(), null).ConfigureAwait(false);
            return ClientResult.FromValue(CreateCompletionResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary> Create. </summary>
        /// <param name="model">
        /// ID of the model to use. You can use the [List models](/docs/api-reference/models/list) API to
        /// see all of your available models, or see our [Model overview](/docs/models/overview) for
        /// descriptions of them.
        /// </param>
        /// <param name="prompt">
        /// The prompt(s) to generate completions for, encoded as a string, array of strings, array of
        /// tokens, or array of token arrays.
        ///
        /// Note that &lt;|endoftext|&gt; is the document separator that the model sees during training, so if a
        /// prompt is not specified the model will generate as if from the beginning of a new document.
        /// </param>
        /// <param name="suffix"> The suffix that comes after a completion of inserted text. </param>
        /// <param name="temperature">
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output
        /// more random, while lower values like 0.2 will make it more focused and deterministic.
        ///
        /// We generally recommend altering this or `top_p` but not both.
        /// </param>
        /// <param name="topP">
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers
        /// the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising
        /// the top 10% probability mass are considered.
        ///
        /// We generally recommend altering this or `temperature` but not both.
        /// </param>
        /// <param name="n">
        /// How many completions to generate for each prompt.
        /// **Note:** Because this parameter generates many completions, it can quickly consume your token
        /// quota. Use carefully and ensure that you have reasonable settings for `max_tokens` and `stop`.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of [tokens](/tokenizer) to generate in the completion.
        ///
        /// The token count of your prompt plus `max_tokens` cannot exceed the model's context length.
        /// [Example Python code](https://github.com/openai/openai-cookbook/blob/main/examples/How_to_count_tokens_with_tiktoken.ipynb)
        /// for counting tokens.
        /// </param>
        /// <param name="stop"> Up to 4 sequences where the API will stop generating further tokens. </param>
        /// <param name="presencePenalty">
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on whether they appear
        /// in the text so far, increasing the model's likelihood to talk about new topics.
        ///
        /// [See more information about frequency and presence penalties.](/docs/guides/gpt/parameter-details)
        /// </param>
        /// <param name="frequencyPenalty">
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing
        /// frequency in the text so far, decreasing the model's likelihood to repeat the same line
        /// verbatim.
        ///
        /// [See more information about frequency and presence penalties.](/docs/guides/gpt/parameter-details)
        /// </param>
        /// <param name="logitBias">
        /// Modify the likelihood of specified tokens appearing in the completion.
        /// Accepts a json object that maps tokens (specified by their token ID in the tokenizer) to an
        /// associated bias value from -100 to 100. Mathematically, the bias is added to the logits
        /// generated by the model prior to sampling. The exact effect will vary per model, but values
        /// between -1 and 1 should decrease or increase likelihood of selection; values like -100 or 100
        /// should result in a ban or exclusive selection of the relevant token.
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect
        /// abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids).
        /// </param>
        /// <param name="stream">
        /// If set, partial message deltas will be sent, like in ChatGPT. Tokens will be sent as data-only
        /// [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format)
        /// as they become available, with the stream terminated by a `data: [DONE]` message.
        /// [Example Python code](https://github.com/openai/openai-cookbook/blob/main/examples/How_to_stream_completions.ipynb).
        /// </param>
        /// <param name="logprobs">
        /// Include the log probabilities on the `logprobs` most likely tokens, as well the chosen tokens.
        /// For example, if `logprobs` is 5, the API will return a list of the 5 most likely tokens. The
        /// API will always return the `logprob` of the sampled token, so there may be up to `logprobs+1`
        /// elements in the response.
        ///
        /// The maximum value for `logprobs` is 5.
        /// </param>
        /// <param name="echo"> Echo back the prompt in addition to the completion. </param>
        /// <param name="bestOf">
        /// Generates `best_of` completions server-side and returns the "best" (the one with the highest
        /// log probability per token). Results cannot be streamed.
        ///
        /// When used with `n`, `best_of` controls the number of candidate completions and `n` specifies
        /// how many to return – `best_of` must be greater than `n`.
        ///
        /// **Note:** Because this parameter generates many completions, it can quickly consume your token
        /// quota. Use carefully and ensure that you have reasonable settings for `max_tokens` and `stop`.
        /// </param>
        public virtual ClientResult<CreateCompletionResponse> Create(CreateCompletionRequestModel model, BinaryData prompt, string suffix = null, double? temperature = null, double? topP = null, long? n = null, long? maxTokens = null, BinaryData stop = null, double? presencePenalty = null, double? frequencyPenalty = null, IReadOnlyDictionary<string, long> logitBias = null, string user = null, bool? stream = null, long? logprobs = null, bool? echo = null, long? bestOf = null)
        {
            CreateCompletionRequest createCompletionRequest = new CreateCompletionRequest(
                model,
                prompt,
                suffix,
                temperature,
                topP,
                n,
                maxTokens,
                stop,
                presencePenalty,
                frequencyPenalty,
                logitBias ?? new ChangeTrackingDictionary<string, long>(),
                user,
                stream,
                logprobs,
                echo,
                bestOf,
                null);
            ClientResult result = Create(createCompletionRequest.ToBinaryContent(), null);
            return ClientResult.FromValue(CreateCompletionResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Create.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateAsync(CreateCompletionRequestModel,BinaryData,string,double?,double?,long?,long?,BinaryData,double?,double?,IReadOnlyDictionary{string,long},string,bool?,long?,bool?,long?)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> CreateAsync(BinaryContent content, RequestOptions options = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using PipelineMessage message = CreateCreateRequest(content, options);
            return ClientResult.FromResponse(await _pipeline.ProcessMessageAsync(message, options).ConfigureAwait(false));
        }

        /// <summary>
        /// [Protocol Method] Create.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://aka.ms/azsdk/net/protocol-methods">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="Create(CreateCompletionRequestModel,BinaryData,string,double?,double?,long?,long?,BinaryData,double?,double?,IReadOnlyDictionary{string,long},string,bool?,long?,bool?,long?)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult Create(BinaryContent content, RequestOptions options = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using PipelineMessage message = CreateCreateRequest(content, options);
            return ClientResult.FromResponse(_pipeline.ProcessMessage(message, options));
        }

        internal PipelineMessage CreateCreateRequest(BinaryContent content, RequestOptions options)
        {
            var message = _pipeline.CreateMessage();
            message.ResponseClassifier = PipelineMessageClassifier200;
            var request = message.Request;
            request.Method = "POST";
            var uri = new ClientUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/completions", false);
            request.Uri = uri.ToUri();
            request.Headers.Set("Accept", "application/json");
            request.Headers.Set("Content-Type", "application/json");
            request.Content = content;
            message.Apply(options);
            return message;
        }

        private static PipelineMessageClassifier _pipelineMessageClassifier200;
        private static PipelineMessageClassifier PipelineMessageClassifier200 => _pipelineMessageClassifier200 ??= PipelineMessageClassifier.Create(stackalloc ushort[] { 200 });
    }
}