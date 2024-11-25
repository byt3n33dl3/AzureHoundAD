// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace xml_service.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class XmlServiceModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Models.ListContainersResponse"/>. </summary>
        /// <param name="serviceEndpoint"></param>
        /// <param name="prefix"></param>
        /// <param name="marker"></param>
        /// <param name="maxResults"></param>
        /// <param name="containers"></param>
        /// <param name="nextMarker"></param>
        /// <returns> A new <see cref="Models.ListContainersResponse"/> instance for mocking. </returns>
        public static ListContainersResponse ListContainersResponse(string serviceEndpoint = null, string prefix = null, string marker = null, int maxResults = default, IEnumerable<Container> containers = null, string nextMarker = null)
        {
            containers ??= new List<Container>();

            return new ListContainersResponse(
                serviceEndpoint,
                prefix,
                marker,
                maxResults,
                containers?.ToList(),
                nextMarker,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.Container"/>. </summary>
        /// <param name="name"></param>
        /// <param name="properties"> Properties of a container. </param>
        /// <param name="metadata"> Dictionary of &lt;string&gt;. </param>
        /// <returns> A new <see cref="Models.Container"/> instance for mocking. </returns>
        public static Container Container(string name = null, ContainerProperties properties = null, IReadOnlyDictionary<string, string> metadata = null)
        {
            metadata ??= new Dictionary<string, string>();

            return new Container(name, properties, metadata, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ContainerProperties"/>. </summary>
        /// <param name="lastModified"></param>
        /// <param name="etag"></param>
        /// <param name="leaseStatus"></param>
        /// <param name="leaseState"></param>
        /// <param name="leaseDuration"></param>
        /// <param name="publicAccess"></param>
        /// <returns> A new <see cref="Models.ContainerProperties"/> instance for mocking. </returns>
        public static ContainerProperties ContainerProperties(DateTimeOffset lastModified = default, string etag = null, LeaseStatusType? leaseStatus = null, LeaseStateType? leaseState = null, LeaseDurationType? leaseDuration = null, PublicAccessType? publicAccess = null)
        {
            return new ContainerProperties(
                lastModified,
                etag,
                leaseStatus,
                leaseState,
                leaseDuration,
                publicAccess,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ListBlobsResponse"/>. </summary>
        /// <param name="serviceEndpoint"></param>
        /// <param name="containerName"></param>
        /// <param name="prefix"></param>
        /// <param name="marker"></param>
        /// <param name="maxResults"></param>
        /// <param name="delimiter"></param>
        /// <param name="blobs"></param>
        /// <param name="nextMarker"></param>
        /// <returns> A new <see cref="Models.ListBlobsResponse"/> instance for mocking. </returns>
        public static ListBlobsResponse ListBlobsResponse(string serviceEndpoint = null, string containerName = null, string prefix = null, string marker = null, int maxResults = default, string delimiter = null, Blobs blobs = null, string nextMarker = null)
        {
            return new ListBlobsResponse(
                serviceEndpoint,
                containerName,
                prefix,
                marker,
                maxResults,
                delimiter,
                blobs,
                nextMarker,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.Blobs"/>. </summary>
        /// <param name="blobPrefix"></param>
        /// <param name="blob"></param>
        /// <returns> A new <see cref="Models.Blobs"/> instance for mocking. </returns>
        public static Blobs Blobs(IEnumerable<BlobPrefix> blobPrefix = null, IEnumerable<Blob> blob = null)
        {
            blobPrefix ??= new List<BlobPrefix>();
            blob ??= new List<Blob>();

            return new Blobs(blobPrefix?.ToList(), blob?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.BlobPrefix"/>. </summary>
        /// <param name="name"></param>
        /// <returns> A new <see cref="Models.BlobPrefix"/> instance for mocking. </returns>
        public static BlobPrefix BlobPrefix(string name = null)
        {
            return new BlobPrefix(name, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.Blob"/>. </summary>
        /// <param name="name"></param>
        /// <param name="deleted"></param>
        /// <param name="snapshot"></param>
        /// <param name="properties"> Properties of a blob. </param>
        /// <param name="metadata"> Dictionary of &lt;string&gt;. </param>
        /// <returns> A new <see cref="Models.Blob"/> instance for mocking. </returns>
        public static Blob Blob(string name = null, bool deleted = default, string snapshot = null, BlobProperties properties = null, IReadOnlyDictionary<string, string> metadata = null)
        {
            metadata ??= new Dictionary<string, string>();

            return new Blob(
                name,
                deleted,
                snapshot,
                properties,
                metadata,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.BlobProperties"/>. </summary>
        /// <param name="lastModified"></param>
        /// <param name="etag"></param>
        /// <param name="contentLength"> Size in bytes. </param>
        /// <param name="contentType"></param>
        /// <param name="contentEncoding"></param>
        /// <param name="contentLanguage"></param>
        /// <param name="contentMD5"></param>
        /// <param name="contentDisposition"></param>
        /// <param name="cacheControl"></param>
        /// <param name="blobSequenceNumber"></param>
        /// <param name="blobType"></param>
        /// <param name="leaseStatus"></param>
        /// <param name="leaseState"></param>
        /// <param name="leaseDuration"></param>
        /// <param name="copyId"></param>
        /// <param name="copyStatus"></param>
        /// <param name="copySource"></param>
        /// <param name="copyProgress"></param>
        /// <param name="copyCompletionTime"></param>
        /// <param name="copyStatusDescription"></param>
        /// <param name="serverEncrypted"></param>
        /// <param name="incrementalCopy"></param>
        /// <param name="destinationSnapshot"></param>
        /// <param name="deletedTime"></param>
        /// <param name="remainingRetentionDays"></param>
        /// <param name="accessTier"></param>
        /// <param name="accessTierInferred"></param>
        /// <param name="archiveStatus"></param>
        /// <returns> A new <see cref="Models.BlobProperties"/> instance for mocking. </returns>
        public static BlobProperties BlobProperties(DateTimeOffset lastModified = default, string etag = null, long? contentLength = null, string contentType = null, string contentEncoding = null, string contentLanguage = null, string contentMD5 = null, string contentDisposition = null, string cacheControl = null, int? blobSequenceNumber = null, BlobType? blobType = null, LeaseStatusType? leaseStatus = null, LeaseStateType? leaseState = null, LeaseDurationType? leaseDuration = null, string copyId = null, CopyStatusType? copyStatus = null, string copySource = null, string copyProgress = null, DateTimeOffset? copyCompletionTime = null, string copyStatusDescription = null, bool? serverEncrypted = null, bool? incrementalCopy = null, string destinationSnapshot = null, DateTimeOffset? deletedTime = null, int? remainingRetentionDays = null, AccessTier? accessTier = null, bool? accessTierInferred = null, ArchiveStatus? archiveStatus = null)
        {
            return new BlobProperties(
                lastModified,
                etag,
                contentLength,
                contentType,
                contentEncoding,
                contentLanguage,
                contentMD5,
                contentDisposition,
                cacheControl,
                blobSequenceNumber,
                blobType,
                leaseStatus,
                leaseState,
                leaseDuration,
                copyId,
                copyStatus,
                copySource,
                copyProgress,
                copyCompletionTime,
                copyStatusDescription,
                serverEncrypted,
                incrementalCopy,
                destinationSnapshot,
                deletedTime,
                remainingRetentionDays,
                accessTier,
                accessTierInferred,
                archiveStatus,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.JsonOutput"/>. </summary>
        /// <param name="id"></param>
        /// <returns> A new <see cref="Models.JsonOutput"/> instance for mocking. </returns>
        public static JsonOutput JsonOutput(int? id = null)
        {
            return new JsonOutput(id, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ObjectWithXMsTextProperty"/>. </summary>
        /// <param name="language"> Returned value should be 'english'. </param>
        /// <param name="content"> Returned value should be 'I am text'. </param>
        /// <returns> A new <see cref="Models.ObjectWithXMsTextProperty"/> instance for mocking. </returns>
        public static ObjectWithXMsTextProperty ObjectWithXMsTextProperty(string language = null, string content = null)
        {
            return new ObjectWithXMsTextProperty(language, content, serializedAdditionalRawData: null);
        }
    }
}