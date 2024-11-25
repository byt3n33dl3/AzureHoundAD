// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtLRO.Models
{
    /// <summary> The FakePostResult. </summary>
    public partial class FakePostResult
    {
        /// <summary> Initializes a new instance of <see cref="FakePostResult"/>. </summary>
        internal FakePostResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FakePostResult"/>. </summary>
        /// <param name="properties"></param>
        internal FakePostResult(FakePostResultProperties properties)
        {
            Properties = properties;
        }

        /// <summary> Gets the properties. </summary>
        internal FakePostResultProperties Properties { get; }
        /// <summary> Bar property. </summary>
        public string FakePostResultBar
        {
            get => Properties?.Bar;
        }
    }
}