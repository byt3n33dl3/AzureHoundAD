// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace multiple_inheritance.Models
{
    /// <summary> The Horse. </summary>
    public partial class Horse : Pet
    {
        /// <summary> Initializes a new instance of <see cref="Horse"/>. </summary>
        /// <param name="name"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public Horse(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
        }

        /// <summary> Initializes a new instance of <see cref="Horse"/>. </summary>
        /// <param name="name"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="isAShowHorse"></param>
        internal Horse(string name, IDictionary<string, BinaryData> serializedAdditionalRawData, bool? isAShowHorse) : base(name, serializedAdditionalRawData)
        {
            IsAShowHorse = isAShowHorse;
        }

        /// <summary> Initializes a new instance of <see cref="Horse"/> for deserialization. </summary>
        internal Horse()
        {
        }

        /// <summary> Gets or sets the is a show horse. </summary>
        public bool? IsAShowHorse { get; set; }
    }
}