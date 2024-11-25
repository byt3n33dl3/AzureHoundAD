// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace xms_error_responses.Models
{
    /// <summary> The AnimalNotFound. </summary>
    internal partial class AnimalNotFound : NotFoundErrorBase
    {
        /// <summary> Initializes a new instance of <see cref="AnimalNotFound"/>. </summary>
        internal AnimalNotFound()
        {
            WhatNotFound = "AnimalNotFound";
        }

        /// <summary> Initializes a new instance of <see cref="AnimalNotFound"/>. </summary>
        /// <param name="someBaseProp"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="reason"></param>
        /// <param name="whatNotFound"></param>
        /// <param name="name"></param>
        internal AnimalNotFound(string someBaseProp, IDictionary<string, BinaryData> serializedAdditionalRawData, string reason, string whatNotFound, string name) : base(someBaseProp, serializedAdditionalRawData, reason, whatNotFound)
        {
            Name = name;
            WhatNotFound = whatNotFound ?? "AnimalNotFound";
        }

        /// <summary> Gets the name. </summary>
        public string Name { get; }
    }
}