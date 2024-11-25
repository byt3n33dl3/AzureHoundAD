// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Cmdlets
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Extensions;
    using System;

    /// <summary>Starts a role instance of a vendor network function.</summary>
    /// <remarks>
    /// [OpenAPI] Start=>POST:"/subscriptions/{subscriptionId}/providers/Microsoft.HybridNetwork/locations/{locationName}/vendors/{vendorName}/networkFunctions/{serviceKey}/roleInstances/{roleInstanceName}/start"
    /// </remarks>
    [global::System.Management.Automation.Cmdlet(global::System.Management.Automation.VerbsLifecycle.Start, @"AzConnectedNetworkVendorFunctionRoleInstance_Start", SupportsShouldProcess = true)]
    [global::System.Management.Automation.OutputType(typeof(bool))]
    [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Description(@"Starts a role instance of a vendor network function.")]
    [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Generated]
    [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.HttpPath(Path = "/subscriptions/{subscriptionId}/providers/Microsoft.HybridNetwork/locations/{locationName}/vendors/{vendorName}/networkFunctions/{serviceKey}/roleInstances/{roleInstanceName}/start", ApiVersion = "2021-05-01")]
    public partial class StartAzConnectedNetworkVendorFunctionRoleInstance_Start : global::System.Management.Automation.PSCmdlet,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IEventListener
    {
        /// <summary>A unique id generatd for the this cmdlet when it is instantiated.</summary>
        private string __correlationId = System.Guid.NewGuid().ToString();

        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
        private global::System.Management.Automation.InvocationInfo __invocationInfo;

        /// <summary>A unique id generatd for the this cmdlet when ProcessRecord() is called.</summary>
        private string __processRecordId;

        /// <summary>
        /// The <see cref="global::System.Threading.CancellationTokenSource" /> for this operation.
        /// </summary>
        private global::System.Threading.CancellationTokenSource _cancellationTokenSource = new global::System.Threading.CancellationTokenSource();

        /// <summary>when specified, runs this cmdlet as a PowerShell job</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command as a job")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter AsJob { get; set; }

        /// <summary>Wait for .NET debugger to attach</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Wait for .NET debugger to attach")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter Break { get; set; }

        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.ConnectedNetwork Client => Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Module.Instance.ClientAPI;

        /// <summary>
        /// The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet
        /// against a different subscription
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The DefaultProfile parameter is not functional. Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::System.Management.Automation.Alias("AzureRMContext", "AzureCredential")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.ParameterCategory.Azure)]
        public global::System.Management.Automation.PSObject DefaultProfile { get; set; }

        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.SendAsyncStep[] HttpPipelineAppend { get; set; }

        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.ParameterCategory.Runtime)]
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.SendAsyncStep[] HttpPipelinePrepend { get; set; }

        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public global::System.Management.Automation.InvocationInfo InvocationInformation { get => __invocationInfo = __invocationInfo ?? this.MyInvocation ; set { __invocationInfo = value; } }

        /// <summary>Backing field for <see cref="LocationName" /> property.</summary>
        private string _locationName;

        /// <summary>The Azure region where the network function resource was created by customer.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The Azure region where the network function resource was created by customer.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The Azure region where the network function resource was created by customer.",
        SerializedName = @"locationName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.ParameterCategory.Path)]
        public string LocationName { get => this._locationName; set => this._locationName = value; }

        /// <summary>
        /// <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
        global::System.Action Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;

        /// <summary><see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IEventListener" /> cancellation token.</summary>
        global::System.Threading.CancellationToken Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IEventListener.Token => _cancellationTokenSource.Token;

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the role instance of the vendor network function.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the role instance of the vendor network function.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the role instance of the vendor network function.",
        SerializedName = @"roleInstanceName",
        PossibleTypes = new [] { typeof(string) })]
        [global::System.Management.Automation.Alias("RoleInstanceName")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.ParameterCategory.Path)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>
        /// when specified, will make the remote call, and return an AsyncOperationResponse, letting the remote operation continue
        /// asynchronously.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command asynchronously")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter NoWait { get; set; }

        /// <summary>
        /// When specified, forces the cmdlet return a 'bool' given that there isn't a return type by default.
        /// </summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Returns true when the command succeeds")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter PassThru { get; set; }

        /// <summary>
        /// The instance of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.HttpPipeline Pipeline { get; set; }

        /// <summary>The URI for the proxy server to use</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "The URI for the proxy server to use")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.ParameterCategory.Runtime)]
        public global::System.Uri Proxy { get; set; }

        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [global::System.Management.Automation.ValidateNotNull]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.ParameterCategory.Runtime)]
        public global::System.Management.Automation.PSCredential ProxyCredential { get; set; }

        /// <summary>Use the default credentials for the proxy</summary>
        [global::System.Management.Automation.Parameter(Mandatory = false, DontShow = true, HelpMessage = "Use the default credentials for the proxy")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.ParameterCategory.Runtime)]
        public global::System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials { get; set; }

        /// <summary>Backing field for <see cref="ServiceKey" /> property.</summary>
        private string _serviceKey;

        /// <summary>The GUID for the vendor network function.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The GUID for the vendor network function.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The GUID for the vendor network function.",
        SerializedName = @"serviceKey",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.ParameterCategory.Path)]
        public string ServiceKey { get => this._serviceKey; set => this._serviceKey = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The ID of the target subscription.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The ID of the target subscription.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.DefaultInfo(
        Name = @"",
        Description =@"",
        Script = @"(Get-AzContext).Subscription.Id")]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.ParameterCategory.Path)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Backing field for <see cref="VendorName" /> property.</summary>
        private string _vendorName;

        /// <summary>The name of the vendor.</summary>
        [global::System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the vendor.")]
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The name of the vendor.",
        SerializedName = @"vendorName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Category(global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.ParameterCategory.Path)]
        public string VendorName { get => this._vendorName; set => this._vendorName = value; }

        /// <summary>
        /// <c>overrideOnDefault</c> will be called before the regular onDefault has been processed, allowing customization of what
        /// happens on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20.IErrorResponse</see>
        /// from the remote call</param>
        /// <param name="returnNow">/// Determines if the rest of the onDefault method should be processed, or if the method should
        /// return immediately (set to true to skip further processing )</param>

        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20.IErrorResponse> response, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// <c>overrideOnOk</c> will be called before the regular onOk has been processed, allowing customization of what happens
        /// on that response. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="returnNow">/// Determines if the rest of the onOk method should be processed, or if the method should return
        /// immediately (set to true to skip further processing )</param>

        partial void overrideOnOk(global::System.Net.Http.HttpResponseMessage responseMessage, ref global::System.Threading.Tasks.Task<bool> returnNow);

        /// <summary>
        /// (overrides the default BeginProcessing method in global::System.Management.Automation.PSCmdlet)
        /// </summary>
        protected override void BeginProcessing()
        {
            var telemetryId = Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Module.Instance.GetTelemetryId.Invoke();
            if (telemetryId != "" && telemetryId != "internal")
            {
                __correlationId = telemetryId;
            }
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.AttachDebugger.Break();
            }
            ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }

        /// <summary>Creates a duplicate instance of this cmdlet (via JSON serialization).</summary>
        /// <returns>a duplicate instance of StartAzConnectedNetworkVendorFunctionRoleInstance_Start</returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Cmdlets.StartAzConnectedNetworkVendorFunctionRoleInstance_Start Clone()
        {
            var clone = new StartAzConnectedNetworkVendorFunctionRoleInstance_Start();
            clone.__correlationId = this.__correlationId;
            clone.__processRecordId = this.__processRecordId;
            clone.DefaultProfile = this.DefaultProfile;
            clone.InvocationInformation = this.InvocationInformation;
            clone.Proxy = this.Proxy;
            clone.Pipeline = this.Pipeline;
            clone.AsJob = this.AsJob;
            clone.Break = this.Break;
            clone.ProxyCredential = this.ProxyCredential;
            clone.ProxyUseDefaultCredentials = this.ProxyUseDefaultCredentials;
            clone.HttpPipelinePrepend = this.HttpPipelinePrepend;
            clone.HttpPipelineAppend = this.HttpPipelineAppend;
            clone.LocationName = this.LocationName;
            clone.VendorName = this.VendorName;
            clone.ServiceKey = this.ServiceKey;
            clone.Name = this.Name;
            clone.SubscriptionId = this.SubscriptionId;
            return clone;
        }

        /// <summary>Performs clean-up after the command execution</summary>
        protected override void EndProcessing()
        {
            var telemetryInfo = Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Module.Instance.GetTelemetryInfo?.Invoke(__correlationId);
            if (telemetryInfo != null)
            {
                telemetryInfo.TryGetValue("ShowSecretsWarning", out var showSecretsWarning);
                telemetryInfo.TryGetValue("SanitizedProperties", out var sanitizedProperties);
                telemetryInfo.TryGetValue("InvocationName", out var invocationName);
                if (showSecretsWarning == "true")
                {
                    if (string.IsNullOrEmpty(sanitizedProperties))
                    {
                        WriteWarning($"The output of cmdlet {invocationName} may compromise security by showing secrets. Learn more at https://go.microsoft.com/fwlink/?linkid=2258844");
                    }
                    else
                    {
                        WriteWarning($"The output of cmdlet {invocationName} may compromise security by showing the following secrets: {sanitizedProperties}. Learn more at https://go.microsoft.com/fwlink/?linkid=2258844");
                    }
                }
            }
        }

        /// <summary>Handles/Dispatches events during the call to the REST service.</summary>
        /// <param name="id">The message id</param>
        /// <param name="token">The message cancellation token. When this call is cancelled, this should be <c>true</c></param>
        /// <param name="messageData">Detailed message data for the message event.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the message is completed.
        /// </returns>
         async global::System.Threading.Tasks.Task Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IEventListener.Signal(string id, global::System.Threading.CancellationToken token, global::System.Func<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }

                switch ( id )
                {
                    case Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Events.Warning:
                    {
                        WriteWarning($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Events.Information:
                    {
                        // When an operation supports asjob, Information messages must go thru verbose.
                        WriteVerbose($"INFORMATION: {(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Events.Debug:
                    {
                        WriteDebug($"{(messageData().Message ?? global::System.String.Empty)}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Events.Error:
                    {
                        WriteError(new global::System.Management.Automation.ErrorRecord( new global::System.Exception(messageData().Message), string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Events.DelayBeforePolling:
                    {
                        if (true == MyInvocation?.BoundParameters?.ContainsKey("NoWait"))
                        {
                            var data = messageData();
                            if (data.ResponseMessage is System.Net.Http.HttpResponseMessage response)
                            {
                                var asyncOperation = response.GetFirstHeader(@"Azure-AsyncOperation");
                                var location = response.GetFirstHeader(@"Location");
                                var uri = global::System.String.IsNullOrEmpty(asyncOperation) ? global::System.String.IsNullOrEmpty(location) ? response.RequestMessage.RequestUri.AbsoluteUri : location : asyncOperation;
                                WriteObject(new Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.PowerShell.AsyncOperationResponse { Target = uri });
                                // do nothing more.
                                data.Cancel();
                                return;
                            }
                        }
                        break;
                    }
                }
                await Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Module.Instance.Signal(id, token, messageData, (i,t,m) => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IEventListener)this).Signal(i,t,()=> Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.EventDataConverter.ConvertFrom( m() ) as Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.EventData ), InvocationInformation, this.ParameterSetName, __correlationId, __processRecordId, null );
                if (token.IsCancellationRequested)
                {
                    return ;
                }
                WriteDebug($"{id}: {(messageData().Message ?? global::System.String.Empty)}");
            }
        }

        /// <summary>Performs execution of the command.</summary>
        protected override void ProcessRecord()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                if (ShouldProcess($"Call remote 'RoleInstancesStart' operation"))
                {
                    if (true == MyInvocation?.BoundParameters?.ContainsKey("AsJob"))
                    {
                        var instance = this.Clone();
                        var job = new Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.PowerShell.AsyncJob(instance, this.MyInvocation.Line, this.MyInvocation.MyCommand.Name, this._cancellationTokenSource.Token, this._cancellationTokenSource.Cancel);
                        JobRepository.Add(job);
                        var task = instance.ProcessRecordAsync();
                        job.Monitor(task);
                        WriteObject(job);
                    }
                    else
                    {
                        using( var asyncCommandRuntime = new Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IEventListener)this).Token) )
                        {
                            asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IEventListener)this).Token);
                        }
                    }
                }
            }
            catch (global::System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new global::System.Management.Automation.ErrorRecord(innerException,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (global::System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)== null || (exception as System.Management.Automation.PipelineStoppedException).InnerException != null)
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new global::System.Management.Automation.ErrorRecord(exception,string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Events.CmdletProcessRecordEnd).Wait();
            }
        }

        /// <summary>Performs execution of the command, working asynchronously if required.</summary>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        protected async global::System.Threading.Tasks.Task ProcessRecordAsync()
        {
            using( NoSynchronizationContext )
            {
                await ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Module.Instance.CreatePipeline(InvocationInformation, __correlationId, __processRecordId, this.ParameterSetName);
                if (null != HttpPipelinePrepend)
                {
                    Pipeline.Prepend((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelinePrepend) ?? HttpPipelinePrepend);
                }
                if (null != HttpPipelineAppend)
                {
                    Pipeline.Append((this.CommandRuntime as Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.PowerShell.IAsyncCommandRuntimeExtensions)?.Wrap(HttpPipelineAppend) ?? HttpPipelineAppend);
                }
                // get the client instance
                try
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    await this.Client.RoleInstancesStart(LocationName, VendorName, ServiceKey, Name, SubscriptionId, onOk, onDefault, this, Pipeline);
                    await ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                catch (Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.UndeclaredResponseException urexception)
                {
                    WriteError(new global::System.Management.Automation.ErrorRecord(urexception, urexception.StatusCode.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new {  LocationName=LocationName,VendorName=VendorName,ServiceKey=ServiceKey,Name=Name,SubscriptionId=SubscriptionId})
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(urexception.Message) { RecommendedAction = urexception.Action }
                    });
                }
                finally
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }

        /// <summary>
        /// Intializes a new instance of the <see cref="StartAzConnectedNetworkVendorFunctionRoleInstance_Start" /> cmdlet class.
        /// </summary>
        public StartAzConnectedNetworkVendorFunctionRoleInstance_Start()
        {

        }

        /// <summary>Interrupts currently running code within the command.</summary>
        protected override void StopProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }

        /// <param name="sendToPipeline"></param>
        new protected void WriteObject(object sendToPipeline)
        {
            Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline);
        }

        /// <param name="sendToPipeline"></param>
        /// <param name="enumerateCollection"></param>
        new protected void WriteObject(object sendToPipeline, bool enumerateCollection)
        {
            Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Module.Instance.SanitizeOutput?.Invoke(sendToPipeline, __correlationId);
            base.WriteObject(sendToPipeline, enumerateCollection);
        }

        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20.IErrorResponse">Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20.IErrorResponse</see>
        /// from the remote call</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20.IErrorResponse> response)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnDefault(responseMessage, response, ref _returnNow);
                // if overrideOnDefault has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // Error Response : default
                var code = (await response)?.Code;
                var message = (await response)?.Message;
                if ((null == code || null == message))
                {
                    // Unrecognized Response. Create an error record based on what we have.
                    var ex = new Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Runtime.RestException<Microsoft.Azure.PowerShell.Cmdlets.ConnectedNetwork.Models.Api20.IErrorResponse>(responseMessage, await response);
                    WriteError( new global::System.Management.Automation.ErrorRecord(ex, ex.Code, global::System.Management.Automation.ErrorCategory.InvalidOperation, new { LocationName=LocationName, VendorName=VendorName, ServiceKey=ServiceKey, Name=Name, SubscriptionId=SubscriptionId })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(ex.Message) { RecommendedAction = ex.Action }
                    });
                }
                else
                {
                    WriteError( new global::System.Management.Automation.ErrorRecord(new global::System.Exception($"[{code}] : {message}"), code?.ToString(), global::System.Management.Automation.ErrorCategory.InvalidOperation, new { LocationName=LocationName, VendorName=VendorName, ServiceKey=ServiceKey, Name=Name, SubscriptionId=SubscriptionId })
                    {
                      ErrorDetails = new global::System.Management.Automation.ErrorDetails(message) { RecommendedAction = global::System.String.Empty }
                    });
                }
            }
        }

        /// <summary>a delegate that is called when the remote service returns 200 (OK).</summary>
        /// <param name="responseMessage">the raw response message as an global::System.Net.Http.HttpResponseMessage.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async global::System.Threading.Tasks.Task onOk(global::System.Net.Http.HttpResponseMessage responseMessage)
        {
            using( NoSynchronizationContext )
            {
                var _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(false);
                overrideOnOk(responseMessage, ref _returnNow);
                // if overrideOnOk has returned true, then return right away.
                if ((null != _returnNow && await _returnNow))
                {
                    return ;
                }
                // onOk - response for 200 /
                if (true == MyInvocation?.BoundParameters?.ContainsKey("PassThru"))
                {
                    WriteObject(true);
                }
            }
        }
    }
}