// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Extensions;

    /// <summary>The List hybrid machine license profile operation response.</summary>
    public partial class LicenseProfilesListResult :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseProfilesListResult,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseProfilesListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>
        /// The URI to fetch the next page of Machines. Call ListNext() with this URI to fetch the next page of license profile.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseProfile> _value;

        /// <summary>The list of license profiles.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseProfile> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="LicenseProfilesListResult" /> instance.</summary>
        public LicenseProfilesListResult()
        {

        }
    }
    /// The List hybrid machine license profile operation response.
    public partial interface ILicenseProfilesListResult :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The URI to fetch the next page of Machines. Call ListNext() with this URI to fetch the next page of license profile.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The URI to fetch the next page of Machines. Call ListNext() with this URI to fetch the next page of license profile.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The list of license profiles.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of license profiles.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseProfile) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseProfile> Value { get; set; }

    }
    /// The List hybrid machine license profile operation response.
    internal partial interface ILicenseProfilesListResultInternal

    {
        /// <summary>
        /// The URI to fetch the next page of Machines. Call ListNext() with this URI to fetch the next page of license profile.
        /// </summary>
        string NextLink { get; set; }
        /// <summary>The list of license profiles.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ILicenseProfile> Value { get; set; }

    }
}