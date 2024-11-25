// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtMockAndSample.Models
{
    /// <summary> The VaultKey. </summary>
    public partial class VaultKey
    {
        /// <summary> Initializes a new instance of <see cref="VaultKey"/>. </summary>
        internal VaultKey()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VaultKey"/>. </summary>
        /// <param name="key"> name of the key. </param>
        /// <param name="content"> content of the key. </param>
        internal VaultKey(string key, string content)
        {
            Key = key;
            Content = content;
        }

        /// <summary> name of the key. </summary>
        public string Key { get; }
        /// <summary> content of the key. </summary>
        public string Content { get; }
    }
}