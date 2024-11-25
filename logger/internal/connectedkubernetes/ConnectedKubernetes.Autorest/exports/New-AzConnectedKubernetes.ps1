
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
New-AzConnectedKubernetes -ClusterName azps_test_cluster -ResourceGroupName azps_test_group -Location eastus
.Example
New-AzConnectedKubernetes -ClusterName azps_test_cluster -ResourceGroupName azps_test_group -Location eastus -KubeConfig $HOME\.kube\config -KubeContext azps_aks_t01
.Example
New-AzConnectedKubernetes -ClusterName azps_test_cluster_ahb -ResourceGroupName azps_test_group -Location eastus -KubeConfig $HOME\.kube\config -KubeContext azps_aks_t01 -PrivateLinkState 'Enabled' -Distribution "AKS_Management" -DistributionVersion "1.0" -PrivateLinkScopeResourceId "/subscriptions/{subscriptionId}/resourceGroups/azps_test_group/providers/Microsoft.HybridCompute/privateLinkScopes/azps-privatelinkscope" -infrastructure "azure_stack_hci" -ProvisioningState 'Succeeded' -AzureHybridBenefit 'True'
.Example
New-AzConnectedKubernetes -ClusterName azps_test_cluster_ahb -ResourceGroupName azps_test_group -Location eastus -KubeConfig $HOME\.kube\config -KubeContext azps_aks_t01 -PrivateLinkState 'Enabled' -Distribution "AKS_Management" -DistributionVersion "1.0" -PrivateLinkScopeResourceId "/subscriptions/{subscriptionId}/resourceGroups/azps_test_group/providers/Microsoft.HybridCompute/privateLinkScopes/azps-privatelinkscope" -infrastructure "azure_stack_hci" -ProvisioningState 'Succeeded' -AzureHybridBenefit 'True' -AcceptEULA
.Example
New-AzConnectedKubernetes -ClusterName azps_test_cluster_ahb -ResourceGroupName azps_test_group -Location eastus -KubeConfig $HOME\.kube\config -KubeContext azps_aks_t01 -HttpProxy "http://proxy-user:proxy-password@proxy-ip:port" -HttpsProxy "http://proxy-user:proxy-password@proxy-ip:port" -NoProxy "localhost,127.0.0.0/8,192.168.0.0/16,172.17.0.0/16,10.96.0.0/12,10.244.0.0/16,10.43.0.0/24,.svc" -Proxy "http://proxy-user:proxy-password@proxy-ip:port" 
.Example
$pwd = ConvertTo-SecureString -String "****" -AsPlainText -Force
$cred = New-Object System.Management.Automation.PSCredential ("proxy-user", $pwd)
New-AzConnectedKubernetes -ClusterName azps_test_cluster_ahb -ResourceGroupName azps_test_group -Location eastus -KubeConfig $HOME\.kube\config -KubeContext azps_aks_t01 -HttpProxy "http://proxy-user:proxy-password@proxy-ip:port" -HttpsProxy "http://proxy-user:proxy-password@proxy-ip:port" -NoProxy "localhost,127.0.0.0/8,192.168.0.0/16,172.17.0.0/16,10.96.0.0/12,10.244.0.0/16,10.43.0.0/24,.svc" -Proxy "http://proxy-ip:port" -ProxyCredential $cred
.Example
New-AzConnectedKubernetes -ClusterName azps_test_cluster -ResourceGroupName azps_test_group -Location eastus -DisableAutoUpgrade
.Example
New-AzConnectedKubernetes -ClusterName azps_test_cluster -ResourceGroupName azps_test_group -Location eastus -OnboardingTimeout 600

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview.IConnectedCluster
.Link
https://learn.microsoft.com/powershell/module/az.connectedkubernetes/new-azconnectedkubernetes
#>
function New-AzConnectedKubernetes {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview.IConnectedCluster])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
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

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Path')]
    [System.Uri]
    # The http URI of the proxy server for the kubernetes cluster to use
    ${HttpProxy},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Path')]
    [System.Uri]
    # The https URI of the proxy server for the kubernetes cluster to use
    ${HttpsProxy},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Path')]
    [System.String]
    # The comma-separated list of hostnames that should be excluded from the proxy server for the kubernetes cluster to use
    ${NoProxy},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Path')]
    [System.String]
    # The path to the certificate file for proxy or custom Certificate Authority.
    ${ProxyCert},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Path')]
    [System.Int32]
    # The time required (in seconds) for the arc-agent pods to be installed on the kubernetes cluster.
    ${OnboardingTimeout},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Path')]
    [System.Management.Automation.SwitchParameter]
    # Flag to disable auto upgrade of arc agents.
    ${DisableAutoUpgrade},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Path')]
    [System.String]
    # Override the default container log path to enable fluent-bit logging.
    ${ContainerLogPath},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
    [System.String]
    # The geo-location where the resource lives
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
    [System.String]
    # Path to the kube config file
    ${KubeConfig},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
    [System.String]
    # Kubconfig context from current machine
    ${KubeContext},

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
    [System.String]
    # The infrastructure on which the Kubernetes cluster represented by this connected cluster is running on.
    ${Infrastructure},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
    [System.String]
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
    [System.String]
    # OID of 'custom-locations' app.
    ${CustomLocationsOid},

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
    [System.Management.Automation.SwitchParameter]
    # Whether to enable or disable the workload identity Webhook
    ${WorkloadIdentityEnabled},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Accept EULA of ConnectedKubernetes, legal term will pop up without this parameter provided
    ${AcceptEULA},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
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
    # The URI of the proxy server for host os to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # The credential of the proxy server for host os to use
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Runtime')]
    [System.Collections.Hashtable]
    # Arc Agentry System Configuration (hash table of hash tables).
    ${ConfigurationSetting},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Runtime')]
    [System.Collections.Hashtable]
    # Arc Agentry System Protected Configuration (hash table of hash tables).
    ${ConfigurationProtectedSetting},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Category('Runtime')]
    [System.String]
    # Arc Gateway resource Id
    ${GatewayResourceId}
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
            [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
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
            CreateExpanded = 'Az.ConnectedKubernetes.custom\New-AzConnectedKubernetes';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $testPlayback = $false
            $PSBoundParameters['HttpPipelinePrepend'] | Foreach-Object { if ($_) { $testPlayback = $testPlayback -or ('Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.PipelineMock' -eq $_.Target.GetType().FullName -and 'Playback' -eq $_.Target.Mode) } }
            if ($testPlayback) {
                $PSBoundParameters['SubscriptionId'] = . (Join-Path $PSScriptRoot '..' 'utils' 'Get-SubscriptionIdTestSafe.ps1')
            } else {
                $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
            }
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        if ($null -ne $MyInvocation.MyCommand -and [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets -notcontains $MyInvocation.MyCommand.Name -and [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.MessageAttributeHelper]::ContainsPreviewAttribute($cmdInfo, $MyInvocation)){
            [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.MessageAttributeHelper]::ProcessPreviewMessageAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
            [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}