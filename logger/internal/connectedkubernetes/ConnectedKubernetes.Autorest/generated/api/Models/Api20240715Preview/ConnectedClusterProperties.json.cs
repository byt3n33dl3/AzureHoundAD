// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Extensions;

    /// <summary>Properties of the connected cluster.</summary>
    public partial class ConnectedClusterProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonObject into a new instance of <see cref="ConnectedClusterProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ConnectedClusterProperties(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_aadProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonObject>("aadProfile"), out var __jsonAadProfile) ? Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview.AadProfile.FromJson(__jsonAadProfile) : AadProfile;}
            {_arcAgentProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonObject>("arcAgentProfile"), out var __jsonArcAgentProfile) ? Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview.ArcAgentProfile.FromJson(__jsonArcAgentProfile) : ArcAgentProfile;}
            {_securityProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonObject>("securityProfile"), out var __jsonSecurityProfile) ? Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview.SecurityProfile.FromJson(__jsonSecurityProfile) : SecurityProfile;}
            {_oidcIssuerProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonObject>("oidcIssuerProfile"), out var __jsonOidcIssuerProfile) ? Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview.OidcIssuerProfile.FromJson(__jsonOidcIssuerProfile) : OidcIssuerProfile;}
            {_gateway = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonObject>("gateway"), out var __jsonGateway) ? Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview.Gateway.FromJson(__jsonGateway) : Gateway;}
            {_agentPublicKeyCertificate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString>("agentPublicKeyCertificate"), out var __jsonAgentPublicKeyCertificate) ? (string)__jsonAgentPublicKeyCertificate : (string)AgentPublicKeyCertificate;}
            {_kubernetesVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString>("kubernetesVersion"), out var __jsonKubernetesVersion) ? (string)__jsonKubernetesVersion : (string)KubernetesVersion;}
            {_totalNodeCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNumber>("totalNodeCount"), out var __jsonTotalNodeCount) ? (int?)__jsonTotalNodeCount : TotalNodeCount;}
            {_totalCoreCount = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNumber>("totalCoreCount"), out var __jsonTotalCoreCount) ? (int?)__jsonTotalCoreCount : TotalCoreCount;}
            {_agentVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString>("agentVersion"), out var __jsonAgentVersion) ? (string)__jsonAgentVersion : (string)AgentVersion;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;}
            {_distribution = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString>("distribution"), out var __jsonDistribution) ? (string)__jsonDistribution : (string)Distribution;}
            {_distributionVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString>("distributionVersion"), out var __jsonDistributionVersion) ? (string)__jsonDistributionVersion : (string)DistributionVersion;}
            {_infrastructure = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString>("infrastructure"), out var __jsonInfrastructure) ? (string)__jsonInfrastructure : (string)Infrastructure;}
            {_offering = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString>("offering"), out var __jsonOffering) ? (string)__jsonOffering : (string)Offering;}
            {_managedIdentityCertificateExpirationTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString>("managedIdentityCertificateExpirationTime"), out var __jsonManagedIdentityCertificateExpirationTime) ? global::System.DateTime.TryParse((string)__jsonManagedIdentityCertificateExpirationTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonManagedIdentityCertificateExpirationTimeValue) ? __jsonManagedIdentityCertificateExpirationTimeValue : ManagedIdentityCertificateExpirationTime : ManagedIdentityCertificateExpirationTime;}
            {_lastConnectivityTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString>("lastConnectivityTime"), out var __jsonLastConnectivityTime) ? global::System.DateTime.TryParse((string)__jsonLastConnectivityTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonLastConnectivityTimeValue) ? __jsonLastConnectivityTimeValue : LastConnectivityTime : LastConnectivityTime;}
            {_connectivityStatus = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString>("connectivityStatus"), out var __jsonConnectivityStatus) ? (string)__jsonConnectivityStatus : (string)ConnectivityStatus;}
            {_privateLinkState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString>("privateLinkState"), out var __jsonPrivateLinkState) ? (string)__jsonPrivateLinkState : (string)PrivateLinkState;}
            {_privateLinkScopeResourceId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString>("privateLinkScopeResourceId"), out var __jsonPrivateLinkScopeResourceId) ? (string)__jsonPrivateLinkScopeResourceId : (string)PrivateLinkScopeResourceId;}
            {_azureHybridBenefit = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString>("azureHybridBenefit"), out var __jsonAzureHybridBenefit) ? (string)__jsonAzureHybridBenefit : (string)AzureHybridBenefit;}
            {_arcAgentryConfiguration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonArray>("arcAgentryConfigurations"), out var __jsonArcAgentryConfigurations) ? If( __jsonArcAgentryConfigurations as Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview.IArcAgentryConfigurations[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview.IArcAgentryConfigurations) (Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview.ArcAgentryConfigurations.FromJson(__u) )) ))() : null : ArcAgentryConfiguration;}
            {_miscellaneousProperty = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonObject>("miscellaneousProperties"), out var __jsonMiscellaneousProperties) ? Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview.ConnectedClusterPropertiesMiscellaneousProperties.FromJson(__jsonMiscellaneousProperties) : MiscellaneousProperty;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview.IConnectedClusterProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview.IConnectedClusterProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview.IConnectedClusterProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonObject json ? new ConnectedClusterProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="ConnectedClusterProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ConnectedClusterProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._aadProfile ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode) this._aadProfile.ToJson(null,serializationMode) : null, "aadProfile" ,container.Add );
            AddIf( null != this._arcAgentProfile ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode) this._arcAgentProfile.ToJson(null,serializationMode) : null, "arcAgentProfile" ,container.Add );
            AddIf( null != this._securityProfile ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode) this._securityProfile.ToJson(null,serializationMode) : null, "securityProfile" ,container.Add );
            AddIf( null != this._oidcIssuerProfile ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode) this._oidcIssuerProfile.ToJson(null,serializationMode) : null, "oidcIssuerProfile" ,container.Add );
            AddIf( null != this._gateway ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode) this._gateway.ToJson(null,serializationMode) : null, "gateway" ,container.Add );
            AddIf( null != (((object)this._agentPublicKeyCertificate)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString(this._agentPublicKeyCertificate.ToString()) : null, "agentPublicKeyCertificate" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._kubernetesVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString(this._kubernetesVersion.ToString()) : null, "kubernetesVersion" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._totalNodeCount ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNumber((int)this._totalNodeCount) : null, "totalNodeCount" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._totalCoreCount ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNumber((int)this._totalCoreCount) : null, "totalCoreCount" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._agentVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString(this._agentVersion.ToString()) : null, "agentVersion" ,container.Add );
            }
            AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            AddIf( null != (((object)this._distribution)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString(this._distribution.ToString()) : null, "distribution" ,container.Add );
            AddIf( null != (((object)this._distributionVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString(this._distributionVersion.ToString()) : null, "distributionVersion" ,container.Add );
            AddIf( null != (((object)this._infrastructure)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString(this._infrastructure.ToString()) : null, "infrastructure" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._offering)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString(this._offering.ToString()) : null, "offering" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._managedIdentityCertificateExpirationTime ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString(this._managedIdentityCertificateExpirationTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "managedIdentityCertificateExpirationTime" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._lastConnectivityTime ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString(this._lastConnectivityTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "lastConnectivityTime" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._connectivityStatus)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString(this._connectivityStatus.ToString()) : null, "connectivityStatus" ,container.Add );
            }
            AddIf( null != (((object)this._privateLinkState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString(this._privateLinkState.ToString()) : null, "privateLinkState" ,container.Add );
            AddIf( null != (((object)this._privateLinkScopeResourceId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString(this._privateLinkScopeResourceId.ToString()) : null, "privateLinkScopeResourceId" ,container.Add );
            AddIf( null != (((object)this._azureHybridBenefit)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonString(this._azureHybridBenefit.ToString()) : null, "azureHybridBenefit" ,container.Add );
            if (null != this._arcAgentryConfiguration)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.XNodeArray();
                foreach( var __x in this._arcAgentryConfiguration )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("arcAgentryConfigurations",__w);
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._miscellaneousProperty ? (Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Json.JsonNode) this._miscellaneousProperty.ToJson(null,serializationMode) : null, "miscellaneousProperties" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}