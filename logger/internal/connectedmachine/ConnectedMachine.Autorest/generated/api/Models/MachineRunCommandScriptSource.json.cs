// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Extensions;

    /// <summary>
    /// Describes the script sources for run command. Use only one of script, scriptUri, commandId.
    /// </summary>
    public partial class MachineRunCommandScriptSource
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineRunCommandScriptSource.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineRunCommandScriptSource.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineRunCommandScriptSource FromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject json ? new MachineRunCommandScriptSource(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject into a new instance of <see cref="MachineRunCommandScriptSource" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal MachineRunCommandScriptSource(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_scriptUriManagedIdentity = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject>("scriptUriManagedIdentity"), out var __jsonScriptUriManagedIdentity) ? Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.RunCommandManagedIdentity.FromJson(__jsonScriptUriManagedIdentity) : _scriptUriManagedIdentity;}
            {_script = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("script"), out var __jsonScript) ? (string)__jsonScript : (string)_script;}
            {_scriptUri = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("scriptUri"), out var __jsonScriptUri) ? (string)__jsonScriptUri : (string)_scriptUri;}
            {_commandId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString>("commandId"), out var __jsonCommandId) ? (string)__jsonCommandId : (string)_commandId;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="MachineRunCommandScriptSource" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="MachineRunCommandScriptSource" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._scriptUriManagedIdentity ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) this._scriptUriManagedIdentity.ToJson(null,serializationMode) : null, "scriptUriManagedIdentity" ,container.Add );
            AddIf( null != (((object)this._script)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._script.ToString()) : null, "script" ,container.Add );
            AddIf( null != (((object)this._scriptUri)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._scriptUri.ToString()) : null, "scriptUri" ,container.Add );
            AddIf( null != (((object)this._commandId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Json.JsonString(this._commandId.ToString()) : null, "commandId" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}