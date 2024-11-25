// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Extensions;

    /// <summary>
    /// The resource model definition for an Azure Resource Manager tracked top level resource which has 'tags' and a 'location'
    /// </summary>
    public partial class TrackedResourceAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ITrackedResourceAutoGenerated,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ITrackedResourceAutoGeneratedInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGenerated"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGenerated __resourceAutoGenerated = new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ResourceAutoGenerated();

        /// <summary>
        /// Fully qualified resource ID for the resource. E.g. "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Id; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGeneratedInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGeneratedInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGeneratedInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGeneratedInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Name; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataCreatedByType = value ?? null; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGeneratedInternal)__resourceAutoGenerated).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Backing field for <see cref="Tags" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ITrackedResourceTags _tags;

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ITrackedResourceTags Tags { get => (this._tags = this._tags ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.TrackedResourceTags()); set => this._tags = value; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGeneratedInternal)__resourceAutoGenerated).Type; }

        /// <summary>Creates an new <see cref="TrackedResourceAutoGenerated" /> instance.</summary>
        public TrackedResourceAutoGenerated()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resourceAutoGenerated), __resourceAutoGenerated);
            await eventListener.AssertObjectIsValid(nameof(__resourceAutoGenerated), __resourceAutoGenerated);
        }
    }
    /// The resource model definition for an Azure Resource Manager tracked top level resource which has 'tags' and a 'location'
    public partial interface ITrackedResourceAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGenerated
    {
        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"The geo-location where the resource lives",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ITrackedResourceTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ITrackedResourceTags Tags { get; set; }

    }
    /// The resource model definition for an Azure Resource Manager tracked top level resource which has 'tags' and a 'location'
    internal partial interface ITrackedResourceAutoGeneratedInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IResourceAutoGeneratedInternal
    {
        /// <summary>The geo-location where the resource lives</summary>
        string Location { get; set; }
        /// <summary>Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.ITrackedResourceTags Tags { get; set; }

    }
}