// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Extensions;

    public partial class NetworkConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProxyResourceAutoGenerated"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProxyResourceAutoGenerated __proxyResourceAutoGenerated = new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ProxyResourceAutoGenerated();

        /// <summary>Public key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public string CandidatePublicKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).CandidatePublicKey; }

        /// <summary>Key expiration date</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public global::System.DateTime? CandidatePublicKeyNotAfter { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).CandidatePublicKeyNotAfter; }

        /// <summary>Recommended key renewal date</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public global::System.DateTime? CandidatePublicKeyRenewAfter { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).CandidatePublicKeyRenewAfter; }

        /// <summary>Public key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public string ClientPublicKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).ClientPublicKey; }

        /// <summary>Key expiration date</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public global::System.DateTime? ClientPublicKeyNotAfter { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).ClientPublicKeyNotAfter; }

        /// <summary>Recommended key renewal date</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public global::System.DateTime? ClientPublicKeyRenewAfter { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).ClientPublicKeyRenewAfter; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceInternal)__proxyResourceAutoGenerated).Id; }

        /// <summary>Resource location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).Location = value ?? null; }

        /// <summary>Internal Acessors for CandidatePublicKey</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationInternal.CandidatePublicKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).CandidatePublicKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).CandidatePublicKey = value; }

        /// <summary>Internal Acessors for CandidatePublicKeyNotAfter</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationInternal.CandidatePublicKeyNotAfter { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).CandidatePublicKeyNotAfter; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).CandidatePublicKeyNotAfter = value; }

        /// <summary>Internal Acessors for CandidatePublicKeyRenewAfter</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationInternal.CandidatePublicKeyRenewAfter { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).CandidatePublicKeyRenewAfter; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).CandidatePublicKeyRenewAfter = value; }

        /// <summary>Internal Acessors for ClientPublicKey</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationInternal.ClientPublicKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).ClientPublicKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).ClientPublicKey = value; }

        /// <summary>Internal Acessors for ClientPublicKeyNotAfter</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationInternal.ClientPublicKeyNotAfter { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).ClientPublicKeyNotAfter; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).ClientPublicKeyNotAfter = value; }

        /// <summary>Internal Acessors for ClientPublicKeyRenewAfter</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationInternal.ClientPublicKeyRenewAfter { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).ClientPublicKeyRenewAfter; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).ClientPublicKeyRenewAfter = value; }

        /// <summary>Internal Acessors for KeyProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyProperties Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationInternal.KeyProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).KeyProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).KeyProperty = value; }

        /// <summary>Internal Acessors for KeyPropertyCandidatePublicKey</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyDetails Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationInternal.KeyPropertyCandidatePublicKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).KeyPropertyCandidatePublicKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).KeyPropertyCandidatePublicKey = value; }

        /// <summary>Internal Acessors for KeyPropertyClientPublicKey</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyDetails Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationInternal.KeyPropertyClientPublicKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).KeyPropertyClientPublicKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).KeyPropertyClientPublicKey = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationProperties Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.NetworkConfigurationProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for TenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationInternal.TenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).TenantId = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceInternal)__proxyResourceAutoGenerated).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceInternal)__proxyResourceAutoGenerated).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceInternal)__proxyResourceAutoGenerated).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceInternal)__proxyResourceAutoGenerated).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceInternal)__proxyResourceAutoGenerated).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceInternal)__proxyResourceAutoGenerated).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceInternal)__proxyResourceAutoGenerated).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceInternal)__proxyResourceAutoGenerated).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceInternal)__proxyResourceAutoGenerated).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationProperties _property;

        /// <summary>Network configuration properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.NetworkConfigurationProperties()); set => this._property = value; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Associated Network Configuration Scope Id (GUID)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public string ScopeId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).NetworkConfigurationScopeId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).NetworkConfigurationScopeId = value ?? null; }

        /// <summary>Associated Network Configuration Scope Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public string ScopeResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).NetworkConfigurationScopeResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).NetworkConfigurationScopeResourceId = value ?? null; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceInternal)__proxyResourceAutoGenerated).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceInternal)__proxyResourceAutoGenerated).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceInternal)__proxyResourceAutoGenerated).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceInternal)__proxyResourceAutoGenerated).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceInternal)__proxyResourceAutoGenerated).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceInternal)__proxyResourceAutoGenerated).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceInternal)__proxyResourceAutoGenerated).SystemDataCreatedByType = value ?? null; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceInternal)__proxyResourceAutoGenerated).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceInternal)__proxyResourceAutoGenerated).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceInternal)__proxyResourceAutoGenerated).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceInternal)__proxyResourceAutoGenerated).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceInternal)__proxyResourceAutoGenerated).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceInternal)__proxyResourceAutoGenerated).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Azure resource tenant Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public string TenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal)Property).TenantId; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceInternal)__proxyResourceAutoGenerated).Type; }

        /// <summary>Creates an new <see cref="NetworkConfiguration" /> instance.</summary>
        public NetworkConfiguration()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResourceAutoGenerated), __proxyResourceAutoGenerated);
            await eventListener.AssertObjectIsValid(nameof(__proxyResourceAutoGenerated), __proxyResourceAutoGenerated);
        }
    }
    public partial interface INetworkConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProxyResourceAutoGenerated
    {
        /// <summary>Public key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Public key",
        SerializedName = @"publicKey",
        PossibleTypes = new [] { typeof(string) })]
        string CandidatePublicKey { get;  }
        /// <summary>Key expiration date</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Key expiration date",
        SerializedName = @"notAfter",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CandidatePublicKeyNotAfter { get;  }
        /// <summary>Recommended key renewal date</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Recommended key renewal date",
        SerializedName = @"renewAfter",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CandidatePublicKeyRenewAfter { get;  }
        /// <summary>Public key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Public key",
        SerializedName = @"publicKey",
        PossibleTypes = new [] { typeof(string) })]
        string ClientPublicKey { get;  }
        /// <summary>Key expiration date</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Key expiration date",
        SerializedName = @"notAfter",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ClientPublicKeyNotAfter { get;  }
        /// <summary>Recommended key renewal date</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Recommended key renewal date",
        SerializedName = @"renewAfter",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ClientPublicKeyRenewAfter { get;  }
        /// <summary>Resource location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Resource location",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>Associated Network Configuration Scope Id (GUID)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Associated Network Configuration Scope Id (GUID)",
        SerializedName = @"networkConfigurationScopeId",
        PossibleTypes = new [] { typeof(string) })]
        string ScopeId { get; set; }
        /// <summary>Associated Network Configuration Scope Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Associated Network Configuration Scope Resource Id",
        SerializedName = @"networkConfigurationScopeResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ScopeResourceId { get; set; }
        /// <summary>Azure resource tenant Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Azure resource tenant Id",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get;  }

    }
    internal partial interface INetworkConfigurationInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProxyResourceAutoGeneratedInternal
    {
        /// <summary>Public key</summary>
        string CandidatePublicKey { get; set; }
        /// <summary>Key expiration date</summary>
        global::System.DateTime? CandidatePublicKeyNotAfter { get; set; }
        /// <summary>Recommended key renewal date</summary>
        global::System.DateTime? CandidatePublicKeyRenewAfter { get; set; }
        /// <summary>Public key</summary>
        string ClientPublicKey { get; set; }
        /// <summary>Key expiration date</summary>
        global::System.DateTime? ClientPublicKeyNotAfter { get; set; }
        /// <summary>Recommended key renewal date</summary>
        global::System.DateTime? ClientPublicKeyRenewAfter { get; set; }
        /// <summary>Public key information for client authentication</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyProperties KeyProperty { get; set; }
        /// <summary>Candidate public key details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyDetails KeyPropertyCandidatePublicKey { get; set; }
        /// <summary>Current public key details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyDetails KeyPropertyClientPublicKey { get; set; }
        /// <summary>Resource location</summary>
        string Location { get; set; }
        /// <summary>Network configuration properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationProperties Property { get; set; }
        /// <summary>Associated Network Configuration Scope Id (GUID)</summary>
        string ScopeId { get; set; }
        /// <summary>Associated Network Configuration Scope Resource Id</summary>
        string ScopeResourceId { get; set; }
        /// <summary>Azure resource tenant Id</summary>
        string TenantId { get; set; }

    }
}