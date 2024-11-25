// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace FlattenedParameters.Models
{
    /// <summary> The PathsYkez7BOperationPatchRequestbodyContentApplicationJsonSchema. </summary>
    internal partial class PathsYkez7BOperationPatchRequestbodyContentApplicationJsonSchema
    {
        /// <summary> Initializes a new instance of <see cref="PathsYkez7BOperationPatchRequestbodyContentApplicationJsonSchema"/>. </summary>
        public PathsYkez7BOperationPatchRequestbodyContentApplicationJsonSchema()
        {
            Items = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="PathsYkez7BOperationPatchRequestbodyContentApplicationJsonSchema"/>. </summary>
        /// <param name="items"></param>
        internal PathsYkez7BOperationPatchRequestbodyContentApplicationJsonSchema(IList<string> items)
        {
            Items = items;
        }

        /// <summary> Gets or sets the items. </summary>
        public IList<string> Items { get; set; }
    }
}