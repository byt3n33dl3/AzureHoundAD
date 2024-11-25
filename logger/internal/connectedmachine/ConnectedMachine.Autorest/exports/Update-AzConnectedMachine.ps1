
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
The operation to update a hybrid machine.
.Description
The operation to update a hybrid machine.
.Example
Update-AzConnectedMachine -Name $env.MachineName -ResourceGroupName $env.ResourceGroupName -PrivateLinkScopeResourceId $env.PrivateLinkScopeUri

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IConnectedMachineIdentity
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineUpdate
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachine
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IConnectedMachineIdentity>: Identity Parameter
  [BaseProvider <String>]: The name of the base Resource Provider.
  [BaseResourceName <String>]: The name of the base resource.
  [BaseResourceType <String>]: The name of the base Resource Type.
  [ExtensionName <String>]: The name of the machine extension.
  [ExtensionType <String>]: The extensionType of the Extension being received.
  [GatewayName <String>]: The name of the Gateway.
  [GroupName <String>]: The name of the private link resource.
  [Id <String>]: Resource identity path
  [LicenseName <String>]: The name of the license.
  [LicenseProfileName <String>]: The name of the license profile.
  [Location <String>]: The location of the Extension being received.
  [MachineName <String>]: The name of the hybrid machine.
  [MetadataName <String>]: Name of the HybridIdentityMetadata.
  [Name <String>]: The name of the hybrid machine.
  [OSType <String>]: Defines the os type.
  [PerimeterName <String>]: The name, in the format {perimeterGuid}.{associationName}, of the Network Security Perimeter resource.
  [PrivateEndpointConnectionName <String>]: The name of the private endpoint connection.
  [PrivateLinkScopeId <String>]: The id (Guid) of the Azure Arc PrivateLinkScope resource.
  [Publisher <String>]: The publisher of the Extension being received.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [RunCommandName <String>]: The name of the run command.
  [ScopeName <String>]: The name of the Azure Arc PrivateLinkScope resource.
  [SettingsResourceName <String>]: The name of the settings resource.
  [SubscriptionId <String>]: The ID of the target subscription.
  [Version <String>]: The version of the Extension being received.

OSPROFILE <IOSProfile>: Specifies the operating system settings for the hybrid machine.
  [LinuxConfigurationPatchSettingsAssessmentMode <String>]: Specifies the assessment mode.
  [LinuxConfigurationPatchSettingsEnableHotpatching <Boolean?>]: Captures the hotpatch capability enrollment intent of the customers, which enables customers to patch their Windows machines without requiring a reboot.
  [LinuxConfigurationPatchSettingsPatchMode <String>]: Specifies the patch mode.
  [WindowsConfigurationPatchSettingsAssessmentMode <String>]: Specifies the assessment mode.
  [WindowsConfigurationPatchSettingsEnableHotpatching <Boolean?>]: Captures the hotpatch capability enrollment intent of the customers, which enables customers to patch their Windows machines without requiring a reboot.
  [WindowsConfigurationPatchSettingsPatchMode <String>]: Specifies the patch mode.

PARAMETER <IMachineUpdate>: Describes a hybrid machine Update.
  [Tags <IResourceUpdateTags>]: Resource tags
    [(Any) <String>]: This indicates any property can be added to this object.
  [AgentUpgradeCorrelationId <String>]: The correlation ID associated with an agent upgrade operation.
  [AgentUpgradeDesiredVersion <String>]: Specifies the version info w.r.t AgentUpgrade for the machine.
  [AgentUpgradeEnableAutomaticUpgrade <Boolean?>]: Specifies if the machine's agent should be upgraded
  [IdentityType <String>]: The identity type.
  [Kind <String>]: Indicates which kind of Arc machine placement on-premises, such as HCI, SCVMM or VMware etc.
  [LocationDataCity <String>]: The city or locality where the resource is located.
  [LocationDataCountryOrRegion <String>]: The country or region where the resource is located
  [LocationDataDistrict <String>]: The district, state, or province where the resource is located.
  [LocationDataName <String>]: A canonical name for the geographic or physical location.
  [OSProfile <IOSProfile>]: Specifies the operating system settings for the hybrid machine.
    [LinuxConfigurationPatchSettingsAssessmentMode <String>]: Specifies the assessment mode.
    [LinuxConfigurationPatchSettingsEnableHotpatching <Boolean?>]: Captures the hotpatch capability enrollment intent of the customers, which enables customers to patch their Windows machines without requiring a reboot.
    [LinuxConfigurationPatchSettingsPatchMode <String>]: Specifies the patch mode.
    [WindowsConfigurationPatchSettingsAssessmentMode <String>]: Specifies the assessment mode.
    [WindowsConfigurationPatchSettingsEnableHotpatching <Boolean?>]: Captures the hotpatch capability enrollment intent of the customers, which enables customers to patch their Windows machines without requiring a reboot.
    [WindowsConfigurationPatchSettingsPatchMode <String>]: Specifies the patch mode.
  [ParentClusterResourceId <String>]: The resource id of the parent cluster (Azure HCI) this machine is assigned to, if any.
  [PrivateLinkScopeResourceId <String>]: The resource id of the private link scope this machine is assigned to, if any.
.Link
https://learn.microsoft.com/powershell/module/az.connectedmachine/update-azconnectedmachine
#>
function Update-AzConnectedMachine {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachine])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaJsonString', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaJsonFilePath', Mandatory)]
    [Parameter(ParameterSetName='Update', Mandatory)]
    [Alias('MachineName')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Path')]
    [System.String]
    # The name of the hybrid machine.
    ${Name},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaJsonString', Mandatory)]
    [Parameter(ParameterSetName='UpdateViaJsonFilePath', Mandatory)]
    [Parameter(ParameterSetName='Update', Mandatory)]
    [ArgumentCompleter({Get-AzResourceGroup | Select-Object -ExpandProperty ResourceGroupName})]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaJsonString')]
    [Parameter(ParameterSetName='UpdateViaJsonFilePath')]
    [Parameter(ParameterSetName='Update')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='UpdateViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IConnectedMachineIdentity]
    # Identity Parameter
    ${InputObject},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
    [System.Nullable[System.Boolean]]
    # Decides if enable a system assigned identity for the resource.
    ${EnableSystemAssignedIdentity},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
    [System.String]
    # The correlation ID passed in from RSM per upgrade.
    ${AgentUpgradeCorrelationId},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
    [System.String]
    # Specifies the version info w.r.t AgentUpgrade for the machine.
    ${AgentUpgradeDesiredVersion},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Specifies if RSM should try to upgrade this machine
    ${AgentUpgradeEnableAutomatic},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PSArgumentCompleterAttribute("SystemAssigned")]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
    [System.String]
    # The identity type.
    ${IdentityType},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PSArgumentCompleterAttribute("AVS", "HCI", "SCVMM", "VMware", "EPS", "GCP", "AWS")]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
    [System.String]
    # Indicates which kind of Arc machine placement on-premises, such as HCI, SCVMM or VMware etc.
    ${Kind},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
    [System.String]
    # The city or locality where the resource is located.
    ${LocationDataCity},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
    [System.String]
    # The country or region where the resource is located
    ${LocationDataCountryOrRegion},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
    [System.String]
    # The district, state, or province where the resource is located.
    ${LocationDataDistrict},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
    [System.String]
    # A canonical name for the geographic or physical location.
    ${LocationDataName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IOSProfile]
    # Specifies the operating system settings for the hybrid machine.
    ${OSProfile},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
    [System.String]
    # The resource id of the parent cluster (Azure HCI) this machine is assigned to, if any.
    ${ParentClusterResourceId},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
    [System.String]
    # The resource id of the private link scope this machine is assigned to, if any.
    ${PrivateLinkScopeResourceId},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Parameter(ParameterSetName='UpdateViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceUpdateTags]))]
    [System.Collections.Hashtable]
    # Resource tags
    ${Tag},

    [Parameter(ParameterSetName='UpdateViaJsonString', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
    [System.String]
    # Json string supplied to the Update operation
    ${JsonString},

    [Parameter(ParameterSetName='UpdateViaJsonFilePath', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
    [System.String]
    # Path of Json file supplied to the Update operation
    ${JsonFilePath},

    [Parameter(ParameterSetName='Update', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='UpdateViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IMachineUpdate]
    # Describes a hybrid machine Update.
    ${Parameter},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Category('Runtime')]
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
            [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
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
            UpdateExpanded = 'Az.ConnectedMachine.custom\Update-AzConnectedMachine';
            UpdateViaJsonString = 'Az.ConnectedMachine.custom\Update-AzConnectedMachine';
            UpdateViaJsonFilePath = 'Az.ConnectedMachine.custom\Update-AzConnectedMachine';
            Update = 'Az.ConnectedMachine.custom\Update-AzConnectedMachine';
            UpdateViaIdentityExpanded = 'Az.ConnectedMachine.custom\Update-AzConnectedMachine';
            UpdateViaIdentity = 'Az.ConnectedMachine.custom\Update-AzConnectedMachine';
        }
        if (('UpdateExpanded', 'UpdateViaJsonString', 'UpdateViaJsonFilePath', 'Update') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId') ) {
            $testPlayback = $false
            $PSBoundParameters['HttpPipelinePrepend'] | Foreach-Object { if ($_) { $testPlayback = $testPlayback -or ('Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.PipelineMock' -eq $_.Target.GetType().FullName -and 'Playback' -eq $_.Target.Mode) } }
            if ($testPlayback) {
                $PSBoundParameters['SubscriptionId'] = . (Join-Path $PSScriptRoot '..' 'utils' 'Get-SubscriptionIdTestSafe.ps1')
            } else {
                $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
            }
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        if ($null -ne $MyInvocation.MyCommand -and [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets -notcontains $MyInvocation.MyCommand.Name -and [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.MessageAttributeHelper]::ContainsPreviewAttribute($cmdInfo, $MyInvocation)){
            [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.MessageAttributeHelper]::ProcessPreviewMessageAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
            [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
