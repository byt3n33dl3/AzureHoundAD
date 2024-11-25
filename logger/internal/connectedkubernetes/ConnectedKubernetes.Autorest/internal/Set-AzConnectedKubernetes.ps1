
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
API to register a new Kubernetes cluster and create a tracked resource in Azure Resource Manager (ARM).
.Description
API to register a new Kubernetes cluster and create a tracked resource in Azure Resource Manager (ARM).
.Example
Set-AzConnectedKubernetes -ClusterName azps_test_cluster -ResourceGroupName azps_test_group -Location eastus -DisableGateway
.Example
Set-AzConnectedKubernetes -ClusterName azps_test_cluster -ResourceGroupName azps_test_group -Location eastus -GatewayResourceId $gatewayResourceId

.Example
# Get an existing cluster first
$inputObject = Get-AzConnectedKubernetes -ClusterName azps_test_cluster -ResourceGroupName azps_test_group -SubscriptionId $subscriptionId
# Enable gateway and set gateway resource Id 
$inputObject.GatewayEnabled=$true
$inputObject.GatewayResourceId=$gatewayResourceId
Set-AzConnectedKubernetes -InputObject $inputObject     

.Example
# Get an existing cluster first
$inputObject = Get-AzConnectedKubernetes -ClusterName azps_test_cluster -ResourceGroupName azps_test_group -SubscriptionId $subscriptionId
# Enable workload identity and OIDC issuer profile
$inputObject.WorkloadIdentityEnabled=$true
$inputObject.OidcIssuerProfileEnabled=$true
Set-AzConnectedKubernetes -InputObject $inputObject 
.Example
# Get an existing cluster first
$inputObject = Get-AzConnectedKubernetes -ClusterName azps_test_cluster -ResourceGroupName azps_test_group -SubscriptionId $subscriptionId
# Disable workload identity 
$inputObject.WorkloadIdentityEnabled=$falue
Set-AzConnectedKubernetes -InputObject $inputObject 
.Example
Get-AzConnectedKubernetes -ClusterName azps_test_cluster -ResourceGroupName azps_test_group -SubscriptionId $subscriptionId | Set-AzConnectedKubernetes -WorkloadIdentityEnabled:$false

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview.IConnectedCluster
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

ARCAGENTPROFILESYSTEMCOMPONENT <ISystemComponent[]>: List of system extensions that are installed on the cluster resource.
  [MajorVersion <Int32?>]: Major Version of the system extension that is currently installed on the cluster resource.
  [Type <String>]: Type of the system extension
  [UserSpecifiedVersion <String>]: Version of the system extension to be installed on the cluster resource.

ARCAGENTRYCONFIGURATION <IArcAgentryConfigurations[]>: Configuration settings for customizing the behavior of the connected cluster.
  [Feature <String>]: Specifies the name of the feature for the configuration setting.
  [ProtectedSetting <IArcAgentryConfigurationsProtectedSettings>]: The configuration settings for the feature that contain any sensitive or secret information.
    [(Any) <String>]: This indicates any property can be added to this object.
  [Setting <IArcAgentryConfigurationsSettings>]: The configuration settings for the feature that do not contain any sensitive or secret information.
    [(Any) <String>]: This indicates any property can be added to this object.
.Link
https://learn.microsoft.com/powershell/module/az.connectedkubernetes/set-azconnectedkubernetes
#>
function Set-AzConnectedKubernetes {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview.IConnectedCluster])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('Name')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Path')]
    [System.String]
    # The name of the Kubernetes cluster on which get is called.
    ${ClusterName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
    [System.String]
    # Base64 encoded public certificate used by the agent to do the initial handshake to the backend services in Azure.
    ${AgentPublicKeyCertificate},

    [Parameter(Mandatory)]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.ResourceIdentityType])]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.ResourceIdentityType]
    # The type of identity used for the connected cluster.
    # The type 'SystemAssigned, includes a system created identity.
    # The type 'None' means no identity is assigned to the connected cluster.
    ${IdentityType},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
    [System.String]
    # The geo-location where the resource lives
    ${Location},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
    [System.String[]]
    # The list of AAD group object IDs that will have admin role of the cluster.
    ${AadProfileAdminGroupObjectID},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Whether to enable Azure RBAC for Kubernetes authorization.
    ${AadProfileEnableAzureRbac},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
    [System.String]
    # The AAD tenant ID to use for authentication.
    # If not specified, will use the tenant of the deployment subscription.
    ${AadProfileTenantId},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.AutoUpgradeOptions])]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.AutoUpgradeOptions]
    # Indicates whether the Arc agents on the be upgraded automatically to the latest version.
    # Defaults to Enabled.
    ${ArcAgentProfileAgentAutoUpgrade},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview.IAgentError[]]
    # List of arc agentry and system components errors on the cluster resource.
    ${ArcAgentProfileAgentError},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
    [System.String]
    # Version of the Arc agents to be installed on the cluster resource
    ${ArcAgentProfileDesiredAgentVersion},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview.ISystemComponent[]]
    # List of system extensions that are installed on the cluster resource.
    # To construct, see NOTES section for ARCAGENTPROFILESYSTEMCOMPONENT properties and create a hash table.
    ${ArcAgentProfileSystemComponent},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview.IArcAgentryConfigurations[]]
    # Configuration settings for customizing the behavior of the connected cluster.
    # To construct, see NOTES section for ARCAGENTRYCONFIGURATION properties and create a hash table.
    ${ArcAgentryConfiguration},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.AzureHybridBenefit])]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.AzureHybridBenefit]
    # Indicates whether Azure Hybrid Benefit is opted in
    ${AzureHybridBenefit},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
    [System.String]
    # The Kubernetes distribution running on this connected cluster.
    ${Distribution},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
    [System.String]
    # The Kubernetes distribution version on this connected cluster.
    ${DistributionVersion},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Indicates whether the gateway for arc router connectivity is enabled.
    ${GatewayEnabled},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
    [System.String]
    # The resource ID of the gateway used for the Arc router feature.
    ${GatewayResourceId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
    [System.String]
    # The infrastructure on which the Kubernetes cluster represented by this connected cluster is running on.
    ${Infrastructure},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.ConnectedClusterKind])]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.ConnectedClusterKind]
    # The kind of connected cluster.
    ${Kind},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Whether to enable oidc issuer for workload identity integration.
    ${OidcIssuerProfileEnabled},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
    [System.String]
    # The issuer url for public cloud clusters - AKS, EKS, GKE - used for the workload identity feature.
    ${OidcIssuerProfileSelfHostedIssuerUrl},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
    [System.String]
    # This is populated only if privateLinkState is enabled.
    # The resource id of the private link scope this connected cluster is assigned to, if any.
    ${PrivateLinkScopeResourceId},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.PrivateLinkState])]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.PrivateLinkState]
    # Property which describes the state of private link on a connected cluster resource.
    ${PrivateLinkState},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.ProvisioningState])]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.ProvisioningState]
    # Provisioning state of the connected cluster resource.
    ${ProvisioningState},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20.ITrackedResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags.
    ${Tag},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Whether to enable or disable the workload identity Webhook
    ${WorkloadIdentityEnabled},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Runtime')]
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

        $mapping = @{
            UpdateExpanded = 'Az.ConnectedKubernetes.private\Set-AzConnectedKubernetes_UpdateExpanded';
        }
        if (('UpdateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $testPlayback = $false
            $PSBoundParameters['HttpPipelinePrepend'] | Foreach-Object { if ($_) { $testPlayback = $testPlayback -or ('Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.PipelineMock' -eq $_.Target.GetType().FullName -and 'Playback' -eq $_.Target.Mode) } }
            if ($testPlayback) {
                $PSBoundParameters['SubscriptionId'] = . (Join-Path $PSScriptRoot '..' 'utils' 'Get-SubscriptionIdTestSafe.ps1')
            } else {
                $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
            }
        }

        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {

        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {

        throw
    }

}
end {
    try {
        $steppablePipeline.End()

    } catch {

        throw
    }
} 
}
