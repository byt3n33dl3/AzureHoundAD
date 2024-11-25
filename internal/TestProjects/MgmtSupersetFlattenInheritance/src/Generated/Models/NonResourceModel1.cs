// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtSupersetFlattenInheritance.Models
{
    /// <summary> Normal custom object with flatten properties from CustomModel2. Also marked as azure resource, but it's not recognized either. </summary>
    public partial class NonResourceModel1
    {
        /// <summary> Initializes a new instance of <see cref="NonResourceModel1"/>. </summary>
        public NonResourceModel1()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NonResourceModel1"/>. </summary>
        /// <param name="bar"></param>
        /// <param name="id"></param>
        /// <param name="foo"></param>
        internal NonResourceModel1(string bar, string id, string foo)
        {
            Bar = bar;
            Id = id;
            Foo = foo;
        }

        /// <summary> Gets or sets the bar. </summary>
        public string Bar { get; set; }
        /// <summary> Gets or sets the id. </summary>
        public string Id { get; set; }
        /// <summary> Gets or sets the foo. </summary>
        public string Foo { get; set; }
    }
}