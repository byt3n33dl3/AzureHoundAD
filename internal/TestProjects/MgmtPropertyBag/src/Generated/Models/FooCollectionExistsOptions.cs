// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;

namespace MgmtPropertyBag.Models
{
    /// <summary> The FooCollectionExistsOptions. </summary>
    public partial class FooCollectionExistsOptions
    {
        /// <summary> Initializes a new instance of <see cref="FooCollectionExistsOptions"/>. </summary>
        /// <param name="fooName"> The foo name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fooName"/> is null. </exception>
        public FooCollectionExistsOptions(string fooName)
        {
            Argument.AssertNotNull(fooName, nameof(fooName));

            FooName = fooName;
        }

        /// <summary> The foo name. </summary>
        public string FooName { get; }
        /// <summary> The filter to apply on the operation. </summary>
        public string Filter { get; set; }
        /// <summary> The top. </summary>
        public int? Top { get; set; }
        /// <summary> The orderby. </summary>
        public string Orderby { get; set; }
        /// <summary> The entity state (Etag) version. A value of "*" can be used for If-Match to unconditionally apply the operation. </summary>
        public ETag? IfMatch { get; set; }
        /// <summary> Optional. Number of records to skip. </summary>
        public int? Skip { get; set; }
    }
}
