
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
Starts a role instance of a vendor network function.
.Description
Starts a role instance of a vendor network function.
.Example
Start-AzConnectedNetworkVendorFunctionRoleInstance -LocationName centraluseuap -ServiceKey 1234-abcd-4321-dcba -SubscriptionId xxxx-3333-xxxx-3333 -VendorName myVendor -Name role1
.Example
$role = @{ RoleInstanceName = "role1"; LocationName = "centraluseuap"; SubscriptionId = "xxxx-3333-xxxx-3333"; VendorName = "myVendor"; serviceKey = "1234-abcd-4321-dcba"}
Start-AzConnectedNetworkVendorFunctionRoleInstance -InputObject $role

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.IConnectedNetworkIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IConnectedNetworkIdentity>: Identity Parameter
  [DeviceName <String>]: The name of the device resource.
  [Id <String>]: Resource identity path
  [LocationName <String>]: The Azure region where the network function resource was created by the customer.
  [NetworkFunctionName <String>]: The name of the network function.
  [PreviewSubscription <String>]: Preview subscription ID.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [RoleInstanceName <String>]: The name of the role instance of the vendor network function.
  [ServiceKey <String>]: The GUID for the vendor network function.
  [SkuName <String>]: The name of the sku.
  [SubscriptionId <String>]: The ID of the target subscription.
  [VendorName <String>]: The name of the vendor.
  [VendorSkuName <String>]: The name of the network function sku.
.Link
https://learn.microsoft.com/powershell/module/az.connectednetwork/start-azconnectednetworkvendorfunctionroleinstance
#>
function Start-AzConnectedNetworkVendorFunctionRoleInstance {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='Start', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Start', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Path')]
    [System.String]
    # The Azure region where the network function resource was created by customer.
    ${LocationName},

    [Parameter(ParameterSetName='Start', Mandatory)]
    [Alias('RoleInstanceName')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Path')]
    [System.String]
    # The name of the role instance of the vendor network function.
    ${Name},

    [Parameter(ParameterSetName='Start', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Path')]
    [System.String]
    # The GUID for the vendor network function.
    ${ServiceKey},

    [Parameter(ParameterSetName='Start')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='Start', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Path')]
    [System.String]
    # The name of the vendor.
    ${VendorName},

    [Parameter(ParameterSetName='StartViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.IConnectedNetworkIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName

        if ($null -eq [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion) {
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $PSVersionTable.PSVersion.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
        } else {
            $internalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
            if ($internalCalledCmdlets -eq '') {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $MyInvocation.MyCommand.Name
            } else {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets += ',' + $MyInvocation.MyCommand.Name
            }
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = 'internal'
        }

        $mapping = @{
            Start = 'Az.ConnectedNetwork.private\Start-AzConnectedNetworkVendorFunctionRoleInstance_Start';
            StartViaIdentity = 'Az.ConnectedNetwork.private\Start-AzConnectedNetworkVendorFunctionRoleInstance_StartViaIdentity';
        }
        if (('Start') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $testPlayback = $false
            $PSBoundParameters['HttpPipelinePrepend'] | Foreach-Object { if ($_) { $testPlayback = $testPlayback -or ('Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.PipelineMock' -eq $_.Target.GetType().FullName -and 'Playback' -eq $_.Target.Mode) } }
            if ($testPlayback) {
                $PSBoundParameters['SubscriptionId'] = . (Join-Path $PSScriptRoot '..' 'utils' 'Get-SubscriptionIdTestSafe.ps1')
            } else {
                $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
            }
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        if ($null -ne $MyInvocation.MyCommand -and [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets -notcontains $MyInvocation.MyCommand.Name -and [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.MessageAttributeHelper]::ContainsPreviewAttribute($cmdInfo, $MyInvocation)){
            [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.MessageAttributeHelper]::ProcessPreviewMessageAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets.Enqueue($MyInvocation.MyCommand.Name)
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }

    finally {
        $backupTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        $backupInternalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
    }

}
end {
    try {
        $steppablePipeline.End()

        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $backupTelemetryId
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $backupInternalCalledCmdlets
        if ($preTelemetryId -eq '') {
            [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
