// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtMockAndSample.Models
{
    /// <summary> This is a single property of read-only string. </summary>
    internal partial class ReadOnlySinglePropertyModel
    {
        /// <summary> Initializes a new instance of <see cref="ReadOnlySinglePropertyModel"/>. </summary>
        public ReadOnlySinglePropertyModel()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ReadOnlySinglePropertyModel"/>. </summary>
        /// <param name="readOnlySomething"> This is a read only string property. </param>
        internal ReadOnlySinglePropertyModel(string readOnlySomething)
        {
            ReadOnlySomething = readOnlySomething;
        }

        /// <summary> This is a read only string property. </summary>
        public string ReadOnlySomething { get; }
    }
}