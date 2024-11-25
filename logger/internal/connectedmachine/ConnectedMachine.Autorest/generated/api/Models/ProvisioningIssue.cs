// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Extensions;

    /// <summary>Details on issues that occurred during provisioning.</summary>
    public partial class ProvisioningIssue :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssue,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssueInternal
    {

        /// <summary>Description of the provisioning issue.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssuePropertiesInternal)Property).Description; }

        /// <summary>Issue type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public string IssueType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssuePropertiesInternal)Property).IssueType; }

        /// <summary>Internal Acessors for Description</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssueInternal.Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssuePropertiesInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssuePropertiesInternal)Property).Description = value; }

        /// <summary>Internal Acessors for IssueType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssueInternal.IssueType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssuePropertiesInternal)Property).IssueType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssuePropertiesInternal)Property).IssueType = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssueInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssueProperties Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssueInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ProvisioningIssueProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Severity</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssueInternal.Severity { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssuePropertiesInternal)Property).Severity; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssuePropertiesInternal)Property).Severity = value; }

        /// <summary>Internal Acessors for SuggestedAccessRule</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IAccessRule> Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssueInternal.SuggestedAccessRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssuePropertiesInternal)Property).SuggestedAccessRule; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssuePropertiesInternal)Property).SuggestedAccessRule = value; }

        /// <summary>Internal Acessors for SuggestedResourceId</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssueInternal.SuggestedResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssuePropertiesInternal)Property).SuggestedResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssuePropertiesInternal)Property).SuggestedResourceId = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the provisioning issue.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssueProperties _property;

        /// <summary>Provisioning issue properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssueProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ProvisioningIssueProperties()); }

        /// <summary>Severity of the provisioning issue.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public string Severity { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssuePropertiesInternal)Property).Severity; }

        /// <summary>Access rules that can be added to the perimeter to remediate the issue</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IAccessRule> SuggestedAccessRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssuePropertiesInternal)Property).SuggestedAccessRule; }

        /// <summary>
        /// ARM Ids of the resources that can be associated to the same perimeter to remediate the issue
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> SuggestedResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssuePropertiesInternal)Property).SuggestedResourceId; }

        /// <summary>Creates an new <see cref="ProvisioningIssue" /> instance.</summary>
        public ProvisioningIssue()
        {

        }
    }
    /// Details on issues that occurred during provisioning.
    public partial interface IProvisioningIssue :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.IJsonSerializable
    {
        /// <summary>Description of the provisioning issue.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Description of the provisioning issue.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get;  }
        /// <summary>Issue type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Issue type",
        SerializedName = @"issueType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PSArgumentCompleterAttribute("MissingPerimeterConfiguration", "MissingIdentityConfiguration", "ConfigurationPropagationFailure", "Other")]
        string IssueType { get;  }
        /// <summary>Name of the provisioning issue.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Name of the provisioning issue.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>Severity of the provisioning issue.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Severity of the provisioning issue.",
        SerializedName = @"severity",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PSArgumentCompleterAttribute("Warning", "Error")]
        string Severity { get;  }
        /// <summary>Access rules that can be added to the perimeter to remediate the issue</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Access rules that can be added to the perimeter to remediate the issue",
        SerializedName = @"suggestedAccessRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IAccessRule) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IAccessRule> SuggestedAccessRule { get;  }
        /// <summary>
        /// ARM Ids of the resources that can be associated to the same perimeter to remediate the issue
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"ARM Ids of the resources that can be associated to the same perimeter to remediate the issue",
        SerializedName = @"suggestedResourceIds",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> SuggestedResourceId { get;  }

    }
    /// Details on issues that occurred during provisioning.
    internal partial interface IProvisioningIssueInternal

    {
        /// <summary>Description of the provisioning issue.</summary>
        string Description { get; set; }
        /// <summary>Issue type</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PSArgumentCompleterAttribute("MissingPerimeterConfiguration", "MissingIdentityConfiguration", "ConfigurationPropagationFailure", "Other")]
        string IssueType { get; set; }
        /// <summary>Name of the provisioning issue.</summary>
        string Name { get; set; }
        /// <summary>Provisioning issue properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IProvisioningIssueProperties Property { get; set; }
        /// <summary>Severity of the provisioning issue.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PSArgumentCompleterAttribute("Warning", "Error")]
        string Severity { get; set; }
        /// <summary>Access rules that can be added to the perimeter to remediate the issue</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IAccessRule> SuggestedAccessRule { get; set; }
        /// <summary>
        /// ARM Ids of the resources that can be associated to the same perimeter to remediate the issue
        /// </summary>
        System.Collections.Generic.List<string> SuggestedResourceId { get; set; }

    }
}