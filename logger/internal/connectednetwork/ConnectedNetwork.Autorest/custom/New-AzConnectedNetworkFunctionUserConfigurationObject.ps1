
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create a in-memory object for NetworkFunctionUserConfiguration
.Description
Create a in-memory object for NetworkFunctionUserConfiguration

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.NetworkFunctionUserConfiguration
.Link
https://learn.microsoft.com/powershell/module/az.ConnectedNetwork/new-AzConnectedNetworkFunctionUserConfigurationObject
#>
function New-AzConnectedNetworkFunctionUserConfigurationObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.NetworkFunctionUserConfiguration')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="The network interface configuration.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.INetworkInterface[]]
        $NetworkInterface,
        [Parameter(HelpMessage="Specifies a base-64 encoded string of custom data. The base-64 encoded string is decoded to a binary array that is saved as a file on the virtual machine. The maximum length of the binary array is 65535 bytes. <br><br> **Note: Do not pass any secrets or passwords in customData property** <br><br> This property cannot be updated after the VM is created. <br><br> customData is passed to the VM to be saved as a file. For more information see [Custom Data on Azure VMs](https://azure.microsoft.com/en-us/blog/custom-data-and-cloud-init-on-windows-azure/) <br><br> For using cloud-init for your Linux VM, see [Using cloud-init to customize a Linux VM during creation](https://learn.microsoft.com/azure/virtual-machines/virtual-machines-linux-using-cloud-init?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json).")]
        [string]
        $OSProfileCustomData,
        [Parameter(HelpMessage="The name of the network function role.")]
        [string]
        $RoleName,
        [Parameter(HelpMessage="The user data parameters from the customer.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.IAny]
        $UserDataParameter
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20210501.NetworkFunctionUserConfiguration]::New()

        $Object.NetworkInterface = $NetworkInterface
        $Object.OSProfileCustomData = $OSProfileCustomData
        $Object.RoleName = $RoleName
        $Object.UserDataParameter = $UserDataParameter
        return $Object
    }
}
