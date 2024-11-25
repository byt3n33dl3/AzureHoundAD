// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.PowerShell;

    /// <summary>Describes the Update properties of a License Profile.</summary>
    [System.ComponentModel.TypeConverter(typeof(LicenseUpdatePropertiesTypeConverter))]
    public partial class LicenseUpdateProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.LicenseUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdateProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdateProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new LicenseUpdateProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.LicenseUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdateProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdateProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new LicenseUpdateProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="LicenseUpdateProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="LicenseUpdateProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdateProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.LicenseUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal LicenseUpdateProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("LicenseDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdatePropertiesInternal)this).LicenseDetail = (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdatePropertiesLicenseDetails) content.GetValueForProperty("LicenseDetail",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdatePropertiesInternal)this).LicenseDetail, Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.LicenseUpdatePropertiesLicenseDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("LicenseType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdatePropertiesInternal)this).LicenseType = (string) content.GetValueForProperty("LicenseType",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdatePropertiesInternal)this).LicenseType, global::System.Convert.ToString);
            }
            if (content.Contains("LicenseDetailState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdatePropertiesInternal)this).LicenseDetailState = (string) content.GetValueForProperty("LicenseDetailState",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdatePropertiesInternal)this).LicenseDetailState, global::System.Convert.ToString);
            }
            if (content.Contains("LicenseDetailTarget"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdatePropertiesInternal)this).LicenseDetailTarget = (string) content.GetValueForProperty("LicenseDetailTarget",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdatePropertiesInternal)this).LicenseDetailTarget, global::System.Convert.ToString);
            }
            if (content.Contains("LicenseDetailEdition"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdatePropertiesInternal)this).LicenseDetailEdition = (string) content.GetValueForProperty("LicenseDetailEdition",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdatePropertiesInternal)this).LicenseDetailEdition, global::System.Convert.ToString);
            }
            if (content.Contains("LicenseDetailType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdatePropertiesInternal)this).LicenseDetailType = (string) content.GetValueForProperty("LicenseDetailType",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdatePropertiesInternal)this).LicenseDetailType, global::System.Convert.ToString);
            }
            if (content.Contains("LicenseDetailProcessor"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdatePropertiesInternal)this).LicenseDetailProcessor = (int?) content.GetValueForProperty("LicenseDetailProcessor",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdatePropertiesInternal)this).LicenseDetailProcessor, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.LicenseUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal LicenseUpdateProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("LicenseDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdatePropertiesInternal)this).LicenseDetail = (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdatePropertiesLicenseDetails) content.GetValueForProperty("LicenseDetail",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdatePropertiesInternal)this).LicenseDetail, Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.LicenseUpdatePropertiesLicenseDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("LicenseType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdatePropertiesInternal)this).LicenseType = (string) content.GetValueForProperty("LicenseType",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdatePropertiesInternal)this).LicenseType, global::System.Convert.ToString);
            }
            if (content.Contains("LicenseDetailState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdatePropertiesInternal)this).LicenseDetailState = (string) content.GetValueForProperty("LicenseDetailState",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdatePropertiesInternal)this).LicenseDetailState, global::System.Convert.ToString);
            }
            if (content.Contains("LicenseDetailTarget"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdatePropertiesInternal)this).LicenseDetailTarget = (string) content.GetValueForProperty("LicenseDetailTarget",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdatePropertiesInternal)this).LicenseDetailTarget, global::System.Convert.ToString);
            }
            if (content.Contains("LicenseDetailEdition"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdatePropertiesInternal)this).LicenseDetailEdition = (string) content.GetValueForProperty("LicenseDetailEdition",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdatePropertiesInternal)this).LicenseDetailEdition, global::System.Convert.ToString);
            }
            if (content.Contains("LicenseDetailType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdatePropertiesInternal)this).LicenseDetailType = (string) content.GetValueForProperty("LicenseDetailType",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdatePropertiesInternal)this).LicenseDetailType, global::System.Convert.ToString);
            }
            if (content.Contains("LicenseDetailProcessor"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdatePropertiesInternal)this).LicenseDetailProcessor = (int?) content.GetValueForProperty("LicenseDetailProcessor",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseUpdatePropertiesInternal)this).LicenseDetailProcessor, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Describes the Update properties of a License Profile.
    [System.ComponentModel.TypeConverter(typeof(LicenseUpdatePropertiesTypeConverter))]
    public partial interface ILicenseUpdateProperties

    {

    }
}