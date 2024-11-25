// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.PowerShell;

    /// <summary>Describes a Machine Extension Update.</summary>
    [System.ComponentModel.TypeConverter(typeof(MachineExtensionUpdateTypeConverter))]
    public partial class MachineExtensionUpdate
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.MachineExtensionUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdate" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdate DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MachineExtensionUpdate(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.MachineExtensionUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdate" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdate DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MachineExtensionUpdate(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MachineExtensionUpdate" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="MachineExtensionUpdate" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdate FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.MachineExtensionUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MachineExtensionUpdate(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.MachineExtensionUpdatePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tags"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceUpdateInternal)this).Tags = (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceUpdateTags) content.GetValueForProperty("Tags",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceUpdateInternal)this).Tags, Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ResourceUpdateTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ForceUpdateTag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).ForceUpdateTag = (string) content.GetValueForProperty("ForceUpdateTag",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).ForceUpdateTag, global::System.Convert.ToString);
            }
            if (content.Contains("Publisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).Publisher = (string) content.GetValueForProperty("Publisher",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).Publisher, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("TypeHandlerVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).TypeHandlerVersion = (string) content.GetValueForProperty("TypeHandlerVersion",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).TypeHandlerVersion, global::System.Convert.ToString);
            }
            if (content.Contains("EnableAutomaticUpgrade"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).EnableAutomaticUpgrade = (bool?) content.GetValueForProperty("EnableAutomaticUpgrade",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).EnableAutomaticUpgrade, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AutoUpgradeMinorVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).AutoUpgradeMinorVersion = (bool?) content.GetValueForProperty("AutoUpgradeMinorVersion",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).AutoUpgradeMinorVersion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Setting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).Setting = (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdatePropertiesSettings) content.GetValueForProperty("Setting",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).Setting, Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.MachineExtensionUpdatePropertiesSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProtectedSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).ProtectedSetting = (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdatePropertiesProtectedSettings) content.GetValueForProperty("ProtectedSetting",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).ProtectedSetting, Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.MachineExtensionUpdatePropertiesProtectedSettingsTypeConverter.ConvertFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.MachineExtensionUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MachineExtensionUpdate(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.MachineExtensionUpdatePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tags"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceUpdateInternal)this).Tags = (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceUpdateTags) content.GetValueForProperty("Tags",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceUpdateInternal)this).Tags, Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ResourceUpdateTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ForceUpdateTag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).ForceUpdateTag = (string) content.GetValueForProperty("ForceUpdateTag",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).ForceUpdateTag, global::System.Convert.ToString);
            }
            if (content.Contains("Publisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).Publisher = (string) content.GetValueForProperty("Publisher",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).Publisher, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("TypeHandlerVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).TypeHandlerVersion = (string) content.GetValueForProperty("TypeHandlerVersion",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).TypeHandlerVersion, global::System.Convert.ToString);
            }
            if (content.Contains("EnableAutomaticUpgrade"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).EnableAutomaticUpgrade = (bool?) content.GetValueForProperty("EnableAutomaticUpgrade",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).EnableAutomaticUpgrade, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AutoUpgradeMinorVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).AutoUpgradeMinorVersion = (bool?) content.GetValueForProperty("AutoUpgradeMinorVersion",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).AutoUpgradeMinorVersion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Setting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).Setting = (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdatePropertiesSettings) content.GetValueForProperty("Setting",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).Setting, Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.MachineExtensionUpdatePropertiesSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProtectedSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).ProtectedSetting = (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdatePropertiesProtectedSettings) content.GetValueForProperty("ProtectedSetting",((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineExtensionUpdateInternal)this).ProtectedSetting, Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.MachineExtensionUpdatePropertiesProtectedSettingsTypeConverter.ConvertFrom);
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
    /// Describes a Machine Extension Update.
    [System.ComponentModel.TypeConverter(typeof(MachineExtensionUpdateTypeConverter))]
    public partial interface IMachineExtensionUpdate

    {

    }
}