// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Extensions;

    /// <summary>Network configuration properties</summary>
    public partial class NetworkConfigurationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal
    {

        /// <summary>Public key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public string CandidatePublicKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyPropertiesInternal)KeyProperty).CandidatePublicKeyPublicKey; }

        /// <summary>Key expiration date</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public global::System.DateTime? CandidatePublicKeyNotAfter { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyPropertiesInternal)KeyProperty).CandidatePublicKeyNotAfter; }

        /// <summary>Recommended key renewal date</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public global::System.DateTime? CandidatePublicKeyRenewAfter { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyPropertiesInternal)KeyProperty).CandidatePublicKeyRenewAfter; }

        /// <summary>Public key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public string ClientPublicKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyPropertiesInternal)KeyProperty).ClientPublicKeyPublicKey; }

        /// <summary>Key expiration date</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public global::System.DateTime? ClientPublicKeyNotAfter { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyPropertiesInternal)KeyProperty).ClientPublicKeyNotAfter; }

        /// <summary>Recommended key renewal date</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public global::System.DateTime? ClientPublicKeyRenewAfter { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyPropertiesInternal)KeyProperty).ClientPublicKeyRenewAfter; }

        /// <summary>Backing field for <see cref="KeyProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyProperties _keyProperty;

        /// <summary>Public key information for client authentication</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyProperties KeyProperty { get => (this._keyProperty = this._keyProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.KeyProperties()); }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>Resource location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Internal Acessors for CandidatePublicKey</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal.CandidatePublicKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyPropertiesInternal)KeyProperty).CandidatePublicKeyPublicKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyPropertiesInternal)KeyProperty).CandidatePublicKeyPublicKey = value; }

        /// <summary>Internal Acessors for CandidatePublicKeyNotAfter</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal.CandidatePublicKeyNotAfter { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyPropertiesInternal)KeyProperty).CandidatePublicKeyNotAfter; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyPropertiesInternal)KeyProperty).CandidatePublicKeyNotAfter = value; }

        /// <summary>Internal Acessors for CandidatePublicKeyRenewAfter</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal.CandidatePublicKeyRenewAfter { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyPropertiesInternal)KeyProperty).CandidatePublicKeyRenewAfter; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyPropertiesInternal)KeyProperty).CandidatePublicKeyRenewAfter = value; }

        /// <summary>Internal Acessors for ClientPublicKey</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal.ClientPublicKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyPropertiesInternal)KeyProperty).ClientPublicKeyPublicKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyPropertiesInternal)KeyProperty).ClientPublicKeyPublicKey = value; }

        /// <summary>Internal Acessors for ClientPublicKeyNotAfter</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal.ClientPublicKeyNotAfter { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyPropertiesInternal)KeyProperty).ClientPublicKeyNotAfter; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyPropertiesInternal)KeyProperty).ClientPublicKeyNotAfter = value; }

        /// <summary>Internal Acessors for ClientPublicKeyRenewAfter</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal.ClientPublicKeyRenewAfter { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyPropertiesInternal)KeyProperty).ClientPublicKeyRenewAfter; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyPropertiesInternal)KeyProperty).ClientPublicKeyRenewAfter = value; }

        /// <summary>Internal Acessors for KeyProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyProperties Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal.KeyProperty { get => (this._keyProperty = this._keyProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.KeyProperties()); set { {_keyProperty = value;} } }

        /// <summary>Internal Acessors for KeyPropertyCandidatePublicKey</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyDetails Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal.KeyPropertyCandidatePublicKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyPropertiesInternal)KeyProperty).CandidatePublicKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyPropertiesInternal)KeyProperty).CandidatePublicKey = value; }

        /// <summary>Internal Acessors for KeyPropertyClientPublicKey</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyDetails Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal.KeyPropertyClientPublicKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyPropertiesInternal)KeyProperty).ClientPublicKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IKeyPropertiesInternal)KeyProperty).ClientPublicKey = value; }

        /// <summary>Internal Acessors for TenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkConfigurationPropertiesInternal.TenantId { get => this._tenantId; set { {_tenantId = value;} } }

        /// <summary>Backing field for <see cref="NetworkConfigurationScopeId" /> property.</summary>
        private string _networkConfigurationScopeId;

        /// <summary>Associated Network Configuration Scope Id (GUID)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string NetworkConfigurationScopeId { get => this._networkConfigurationScopeId; set => this._networkConfigurationScopeId = value; }

        /// <summary>Backing field for <see cref="NetworkConfigurationScopeResourceId" /> property.</summary>
        private string _networkConfigurationScopeResourceId;

        /// <summary>Associated Network Configuration Scope Resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string NetworkConfigurationScopeResourceId { get => this._networkConfigurationScopeResourceId; set => this._networkConfigurationScopeResourceId = value; }

        /// <summary>Backing field for <see cref="TenantId" /> property.</summary>
        private string _tenantId;

        /// <summary>Azure resource tenant Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string TenantId { get => this._tenantId; }

        /// <summary>Creates an new <see cref="NetworkConfigurationProperties" /> instance.</summary>
        public NetworkConfigurationProperties()
        {

        }
    }
    /// Network configuration properties
    public partial interface INetworkConfigurationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.IJsonSerializable
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
        string NetworkConfigurationScopeId { get; set; }
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
        string NetworkConfigurationScopeResourceId { get; set; }
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
    /// Network configuration properties
    internal partial interface INetworkConfigurationPropertiesInternal

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
        /// <summary>Associated Network Configuration Scope Id (GUID)</summary>
        string NetworkConfigurationScopeId { get; set; }
        /// <summary>Associated Network Configuration Scope Resource Id</summary>
        string NetworkConfigurationScopeResourceId { get; set; }
        /// <summary>Azure resource tenant Id</summary>
        string TenantId { get; set; }

    }
}