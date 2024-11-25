// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Inheritance.Models
{
    /// <summary>
    /// The BaseClassWithDiscriminator.
    /// Please note <see cref="BaseClassWithDiscriminator"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ClassThatInheritsFromBaseClassWithDiscriminator"/> and <see cref="ClassThatInheritsFromBaseClassWithDiscriminatorAndSomeProperties"/>.
    /// </summary>
    public abstract partial class BaseClassWithDiscriminator : BaseClass
    {
        /// <summary> Initializes a new instance of <see cref="BaseClassWithDiscriminator"/>. </summary>
        protected BaseClassWithDiscriminator()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BaseClassWithDiscriminator"/>. </summary>
        /// <param name="baseClassProperty"></param>
        /// <param name="dfeString"> Any object. </param>
        /// <param name="dfeDouble"> Any object. </param>
        /// <param name="dfeBool"> Any object. </param>
        /// <param name="dfeInt"> Any object. </param>
        /// <param name="dfeObject"> Any object. </param>
        /// <param name="dfeListOfT"> Any object. </param>
        /// <param name="dfeListOfString"> Any object. </param>
        /// <param name="dfeKeyValuePairs"> Any object. </param>
        /// <param name="dfeDateTime"> Any object. </param>
        /// <param name="dfeDuration"> Any object. </param>
        /// <param name="dfeUri"> Any object. </param>
        /// <param name="discriminatorProperty"></param>
        internal BaseClassWithDiscriminator(string baseClassProperty, DataFactoryElement<string> dfeString, DataFactoryElement<double> dfeDouble, DataFactoryElement<bool> dfeBool, DataFactoryElement<int> dfeInt, DataFactoryElement<BinaryData> dfeObject, DataFactoryElement<IList<SeparateClass>> dfeListOfT, DataFactoryElement<IList<string>> dfeListOfString, DataFactoryElement<IDictionary<string, string>> dfeKeyValuePairs, DataFactoryElement<DateTimeOffset> dfeDateTime, DataFactoryElement<TimeSpan> dfeDuration, DataFactoryElement<Uri> dfeUri, string discriminatorProperty) : base(baseClassProperty, dfeString, dfeDouble, dfeBool, dfeInt, dfeObject, dfeListOfT, dfeListOfString, dfeKeyValuePairs, dfeDateTime, dfeDuration, dfeUri)
        {
            DiscriminatorProperty = discriminatorProperty;
        }

        /// <summary> Gets or sets the discriminator property. </summary>
        internal string DiscriminatorProperty { get; set; }
    }
}