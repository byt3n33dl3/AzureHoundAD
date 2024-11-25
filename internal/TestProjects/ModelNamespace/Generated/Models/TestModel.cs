// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ModelNamespace
{
    /// <summary> . </summary>
    internal partial class TestModel
    {
        /// <summary> Initializes a new instance of <see cref="TestModel"/>. </summary>
        internal TestModel()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TestModel"/>. </summary>
        /// <param name="code"></param>
        /// <param name="status"></param>
        internal TestModel(string code, string status)
        {
            Code = code;
            Status = status;
        }

        /// <summary> Gets the code. </summary>
        public string Code { get; }
        /// <summary> Gets the status. </summary>
        public string Status { get; }
    }
}