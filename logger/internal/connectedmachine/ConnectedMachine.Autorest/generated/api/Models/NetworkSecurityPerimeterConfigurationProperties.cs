// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Extensions;

    /// <summary>Properties that define a Network Security Perimeter resource.</summary>
    public partial class NetworkSecurityPerimeterConfigurationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterConfigurationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal
    {

        /// <summary>Internal Acessors for NetworkSecurityPerimeter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeter Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal.NetworkSecurityPerimeter { get => (this._networkSecurityPerimeter = this._networkSecurityPerimeter ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.NetworkSecurityPerimeter()); set { {_networkSecurityPerimeter = value;} } }

        /// <summary>Internal Acessors for NetworkSecurityPerimeterGuid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal.NetworkSecurityPerimeterGuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterInternal)NetworkSecurityPerimeter).PerimeterGuid; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterInternal)NetworkSecurityPerimeter).PerimeterGuid = value; }

        /// <summary>Internal Acessors for NetworkSecurityPerimeterId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal.NetworkSecurityPerimeterId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterInternal)NetworkSecurityPerimeter).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterInternal)NetworkSecurityPerimeter).Id = value; }

        /// <summary>Internal Acessors for NetworkSecurityPerimeterLocation</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal.NetworkSecurityPerimeterLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterInternal)NetworkSecurityPerimeter).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterInternal)NetworkSecurityPerimeter).Location = value; }

        /// <summary>Internal Acessors for Profile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterProfile Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal.Profile { get => (this._profile = this._profile ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.NetworkSecurityPerimeterProfile()); set { {_profile = value;} } }

        /// <summary>Internal Acessors for ProfileAccessRule</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IAccessRule> Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal.ProfileAccessRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterProfileInternal)Profile).AccessRule; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterProfileInternal)Profile).AccessRule = value; }

        /// <summary>Internal Acessors for ProfileAccessRulesVersion</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal.ProfileAccessRulesVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterProfileInternal)Profile).AccessRulesVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterProfileInternal)Profile).AccessRulesVersion = value; }

        /// <summary>Internal Acessors for ProfileDiagnosticSettingsVersion</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal.ProfileDiagnosticSettingsVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterProfileInternal)Profile).DiagnosticSettingsVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterProfileInternal)Profile).DiagnosticSettingsVersion = value; }

        /// <summary>Internal Acessors for ProfileEnabledLogCategory</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal.ProfileEnabledLogCategory { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterProfileInternal)Profile).EnabledLogCategory; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterProfileInternal)Profile).EnabledLogCategory = value; }

        /// <summary>Internal Acessors for ProfileName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal.ProfileName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterProfileInternal)Profile).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterProfileInternal)Profile).Name = value; }

        /// <summary>Internal Acessors for ProvisioningIssue</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssue> Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal.ProvisioningIssue { get => this._provisioningIssue; set { {_provisioningIssue = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for ResourceAssociation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAssociation Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal.ResourceAssociation { get => (this._resourceAssociation = this._resourceAssociation ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ResourceAssociation()); set { {_resourceAssociation = value;} } }

        /// <summary>Internal Acessors for ResourceAssociationAccessMode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal.ResourceAssociationAccessMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAssociationInternal)ResourceAssociation).AccessMode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAssociationInternal)ResourceAssociation).AccessMode = value; }

        /// <summary>Internal Acessors for ResourceAssociationName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterConfigurationPropertiesInternal.ResourceAssociationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAssociationInternal)ResourceAssociation).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAssociationInternal)ResourceAssociation).Name = value; }

        /// <summary>Backing field for <see cref="NetworkSecurityPerimeter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeter _networkSecurityPerimeter;

        /// <summary>The Network Security Perimeter associated with this configuration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeter NetworkSecurityPerimeter { get => (this._networkSecurityPerimeter = this._networkSecurityPerimeter ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.NetworkSecurityPerimeter()); set => this._networkSecurityPerimeter = value; }

        /// <summary>Guid of the Network Security Perimeter</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public string NetworkSecurityPerimeterGuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterInternal)NetworkSecurityPerimeter).PerimeterGuid; }

        /// <summary>Azure resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public string NetworkSecurityPerimeterId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterInternal)NetworkSecurityPerimeter).Id; }

        /// <summary>Regional location of the perimeter</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public string NetworkSecurityPerimeterLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterInternal)NetworkSecurityPerimeter).Location; }

        /// <summary>Backing field for <see cref="Profile" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterProfile _profile;

        /// <summary>Network Security Perimeter profile</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterProfile Profile { get => (this._profile = this._profile ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.NetworkSecurityPerimeterProfile()); set => this._profile = value; }

        /// <summary>Collection of access rules for the profile</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IAccessRule> ProfileAccessRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterProfileInternal)Profile).AccessRule; }

        /// <summary>Access rules version number</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public int? ProfileAccessRulesVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterProfileInternal)Profile).AccessRulesVersion; }

        /// <summary>Diagnostic settings version number</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public int? ProfileDiagnosticSettingsVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterProfileInternal)Profile).DiagnosticSettingsVersion; }

        /// <summary>Collection of enabled log categories for the profile</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> ProfileEnabledLogCategory { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterProfileInternal)Profile).EnabledLogCategory; }

        /// <summary>Name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public string ProfileName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterProfileInternal)Profile).Name; }

        /// <summary>Backing field for <see cref="ProvisioningIssue" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssue> _provisioningIssue;

        /// <summary>Provisioning issues.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssue> ProvisioningIssue { get => this._provisioningIssue; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>
        /// Current state of this NetworkSecurityPerimeter: whether or not is has been provisioned within the resource group it is
        /// defined. Users cannot change this value but are able to read from it. Values will include Provisioning ,Succeeded, Canceled
        /// and Failed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="ResourceAssociation" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAssociation _resourceAssociation;

        /// <summary>The Resource Association.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAssociation ResourceAssociation { get => (this._resourceAssociation = this._resourceAssociation ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ResourceAssociation()); set => this._resourceAssociation = value; }

        /// <summary>The access mode</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public string ResourceAssociationAccessMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAssociationInternal)ResourceAssociation).AccessMode; }

        /// <summary>Name of the Resource Association</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public string ResourceAssociationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAssociationInternal)ResourceAssociation).Name; }

        /// <summary>
        /// Creates an new <see cref="NetworkSecurityPerimeterConfigurationProperties" /> instance.
        /// </summary>
        public NetworkSecurityPerimeterConfigurationProperties()
        {

        }
    }
    /// Properties that define a Network Security Perimeter resource.
    public partial interface INetworkSecurityPerimeterConfigurationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.IJsonSerializable
    {
        /// <summary>Guid of the Network Security Perimeter</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Guid of the Network Security Perimeter",
        SerializedName = @"perimeterGuid",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkSecurityPerimeterGuid { get;  }
        /// <summary>Azure resource Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Azure resource Id",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkSecurityPerimeterId { get;  }
        /// <summary>Regional location of the perimeter</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Regional location of the perimeter",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkSecurityPerimeterLocation { get;  }
        /// <summary>Collection of access rules for the profile</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Collection of access rules for the profile",
        SerializedName = @"accessRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IAccessRule) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IAccessRule> ProfileAccessRule { get;  }
        /// <summary>Access rules version number</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Access rules version number",
        SerializedName = @"accessRulesVersion",
        PossibleTypes = new [] { typeof(int) })]
        int? ProfileAccessRulesVersion { get;  }
        /// <summary>Diagnostic settings version number</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Diagnostic settings version number",
        SerializedName = @"diagnosticSettingsVersion",
        PossibleTypes = new [] { typeof(int) })]
        int? ProfileDiagnosticSettingsVersion { get;  }
        /// <summary>Collection of enabled log categories for the profile</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Collection of enabled log categories for the profile",
        SerializedName = @"enabledLogCategories",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ProfileEnabledLogCategory { get;  }
        /// <summary>Name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Name of the resource",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ProfileName { get;  }
        /// <summary>Provisioning issues.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning issues.",
        SerializedName = @"provisioningIssues",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssue) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssue> ProvisioningIssue { get;  }
        /// <summary>
        /// Current state of this NetworkSecurityPerimeter: whether or not is has been provisioned within the resource group it is
        /// defined. Users cannot change this value but are able to read from it. Values will include Provisioning ,Succeeded, Canceled
        /// and Failed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Current state of this NetworkSecurityPerimeter: whether or not is has been provisioned within the resource group it is defined. Users cannot change this value but are able to read from it. Values will include Provisioning ,Succeeded, Canceled and Failed.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get;  }
        /// <summary>The access mode</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The access mode",
        SerializedName = @"accessMode",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PSArgumentCompleterAttribute("enforced", "audit", "learning")]
        string ResourceAssociationAccessMode { get;  }
        /// <summary>Name of the Resource Association</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Name of the Resource Association",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceAssociationName { get;  }

    }
    /// Properties that define a Network Security Perimeter resource.
    internal partial interface INetworkSecurityPerimeterConfigurationPropertiesInternal

    {
        /// <summary>The Network Security Perimeter associated with this configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeter NetworkSecurityPerimeter { get; set; }
        /// <summary>Guid of the Network Security Perimeter</summary>
        string NetworkSecurityPerimeterGuid { get; set; }
        /// <summary>Azure resource Id</summary>
        string NetworkSecurityPerimeterId { get; set; }
        /// <summary>Regional location of the perimeter</summary>
        string NetworkSecurityPerimeterLocation { get; set; }
        /// <summary>Network Security Perimeter profile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.INetworkSecurityPerimeterProfile Profile { get; set; }
        /// <summary>Collection of access rules for the profile</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IAccessRule> ProfileAccessRule { get; set; }
        /// <summary>Access rules version number</summary>
        int? ProfileAccessRulesVersion { get; set; }
        /// <summary>Diagnostic settings version number</summary>
        int? ProfileDiagnosticSettingsVersion { get; set; }
        /// <summary>Collection of enabled log categories for the profile</summary>
        System.Collections.Generic.List<string> ProfileEnabledLogCategory { get; set; }
        /// <summary>Name of the resource</summary>
        string ProfileName { get; set; }
        /// <summary>Provisioning issues.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssue> ProvisioningIssue { get; set; }
        /// <summary>
        /// Current state of this NetworkSecurityPerimeter: whether or not is has been provisioned within the resource group it is
        /// defined. Users cannot change this value but are able to read from it. Values will include Provisioning ,Succeeded, Canceled
        /// and Failed.
        /// </summary>
        string ProvisioningState { get; set; }
        /// <summary>The Resource Association.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAssociation ResourceAssociation { get; set; }
        /// <summary>The access mode</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PSArgumentCompleterAttribute("enforced", "audit", "learning")]
        string ResourceAssociationAccessMode { get; set; }
        /// <summary>Name of the Resource Association</summary>
        string ResourceAssociationName { get; set; }

    }
}