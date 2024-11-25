// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Extensions;

    /// <summary>Specifies the operating system settings for the role instance.</summary>
    public partial class NetworkFunctionUserConfigurationOSProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.INetworkFunctionUserConfigurationOSProfile,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.INetworkFunctionUserConfigurationOSProfileInternal
    {

        /// <summary>Backing field for <see cref="CustomData" /> property.</summary>
        private string _customData;

        /// <summary>
        /// Specifies a base-64 encoded string of custom data. The base-64 encoded string is decoded to a binary array that is saved
        /// as a file on the virtual machine. The maximum length of the binary array is 65535 bytes. <br><br> **Note: Do not pass
        /// any secrets or passwords in customData property** <br><br> This property cannot be updated after the VM is created. <br><br>
        /// customData is passed to the VM to be saved as a file. For more information see [Custom Data on Azure VMs](https://azure.microsoft.com/en-us/blog/custom-data-and-cloud-init-on-windows-azure/)
        /// <br><br> For using cloud-init for your Linux VM, see [Using cloud-init to customize a Linux VM during creation](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-using-cloud-init?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.PropertyOrigin.Owned)]
        public string CustomData { get => this._customData; set => this._customData = value; }

        /// <summary>
        /// Creates an new <see cref="NetworkFunctionUserConfigurationOSProfile" /> instance.
        /// </summary>
        public NetworkFunctionUserConfigurationOSProfile()
        {

        }
    }
    /// Specifies the operating system settings for the role instance.
    public partial interface INetworkFunctionUserConfigurationOSProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Specifies a base-64 encoded string of custom data. The base-64 encoded string is decoded to a binary array that is saved
        /// as a file on the virtual machine. The maximum length of the binary array is 65535 bytes. <br><br> **Note: Do not pass
        /// any secrets or passwords in customData property** <br><br> This property cannot be updated after the VM is created. <br><br>
        /// customData is passed to the VM to be saved as a file. For more information see [Custom Data on Azure VMs](https://azure.microsoft.com/en-us/blog/custom-data-and-cloud-init-on-windows-azure/)
        /// <br><br> For using cloud-init for your Linux VM, see [Using cloud-init to customize a Linux VM during creation](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-using-cloud-init?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies a base-64 encoded string of custom data. The base-64 encoded string is decoded to a binary array that is saved as a file on the virtual machine. The maximum length of the binary array is 65535 bytes. <br><br> **Note: Do not pass any secrets or passwords in customData property** <br><br> This property cannot be updated after the VM is created. <br><br> customData is passed to the VM to be saved as a file. For more information see [Custom Data on Azure VMs](https://azure.microsoft.com/en-us/blog/custom-data-and-cloud-init-on-windows-azure/) <br><br> For using cloud-init for your Linux VM, see [Using cloud-init to customize a Linux VM during creation](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-using-cloud-init?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)",
        SerializedName = @"customData",
        PossibleTypes = new [] { typeof(string) })]
        string CustomData { get; set; }

    }
    /// Specifies the operating system settings for the role instance.
    internal partial interface INetworkFunctionUserConfigurationOSProfileInternal

    {
        /// <summary>
        /// Specifies a base-64 encoded string of custom data. The base-64 encoded string is decoded to a binary array that is saved
        /// as a file on the virtual machine. The maximum length of the binary array is 65535 bytes. <br><br> **Note: Do not pass
        /// any secrets or passwords in customData property** <br><br> This property cannot be updated after the VM is created. <br><br>
        /// customData is passed to the VM to be saved as a file. For more information see [Custom Data on Azure VMs](https://azure.microsoft.com/en-us/blog/custom-data-and-cloud-init-on-windows-azure/)
        /// <br><br> For using cloud-init for your Linux VM, see [Using cloud-init to customize a Linux VM during creation](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-using-cloud-init?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json)
        /// </summary>
        string CustomData { get; set; }

    }
}