// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Extensions;

    /// <summary>
    /// Specifies information about the operating system disk used by the virtual machine. <br><br> For more information about
    /// disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
    /// </summary>
    public partial class DataDisk :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IDataDisk,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.IDataDiskInternal
    {

        /// <summary>Backing field for <see cref="CreateOption" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.DiskCreateOptionTypes? _createOption;

        /// <summary>Specifies how the virtual machine should be created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.DiskCreateOptionTypes? CreateOption { get => this._createOption; set => this._createOption = value; }

        /// <summary>Backing field for <see cref="DiskSizeGb" /> property.</summary>
        private int? _diskSizeGb;

        /// <summary>
        /// Specifies the size of an empty disk in gigabytes. This element can be used to overwrite the size of the disk in a virtual
        /// machine image.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PropertyOrigin.Owned)]
        public int? DiskSizeGb { get => this._diskSizeGb; set => this._diskSizeGb = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of data disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="DataDisk" /> instance.</summary>
        public DataDisk()
        {

        }
    }
    /// Specifies information about the operating system disk used by the virtual machine. <br><br> For more information about
    /// disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
    public partial interface IDataDisk :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IJsonSerializable
    {
        /// <summary>Specifies how the virtual machine should be created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies how the virtual machine should be created.",
        SerializedName = @"createOption",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.DiskCreateOptionTypes) })]
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.DiskCreateOptionTypes? CreateOption { get; set; }
        /// <summary>
        /// Specifies the size of an empty disk in gigabytes. This element can be used to overwrite the size of the disk in a virtual
        /// machine image.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the size of an empty disk in gigabytes. This element can be used to overwrite the size of the disk in a virtual machine image.",
        SerializedName = @"diskSizeGB",
        PossibleTypes = new [] { typeof(int) })]
        int? DiskSizeGb { get; set; }
        /// <summary>The name of data disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of data disk.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// Specifies information about the operating system disk used by the virtual machine. <br><br> For more information about
    /// disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-about-disks-vhds?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json).
    internal partial interface IDataDiskInternal

    {
        /// <summary>Specifies how the virtual machine should be created.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Support.DiskCreateOptionTypes? CreateOption { get; set; }
        /// <summary>
        /// Specifies the size of an empty disk in gigabytes. This element can be used to overwrite the size of the disk in a virtual
        /// machine image.
        /// </summary>
        int? DiskSizeGb { get; set; }
        /// <summary>The name of data disk.</summary>
        string Name { get; set; }

    }
}