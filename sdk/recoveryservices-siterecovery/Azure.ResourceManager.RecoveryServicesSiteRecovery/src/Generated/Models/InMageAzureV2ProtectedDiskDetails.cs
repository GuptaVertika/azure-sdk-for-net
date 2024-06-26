// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageAzureV2 protected disk details. </summary>
    public partial class InMageAzureV2ProtectedDiskDetails
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="InMageAzureV2ProtectedDiskDetails"/>. </summary>
        internal InMageAzureV2ProtectedDiskDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="InMageAzureV2ProtectedDiskDetails"/>. </summary>
        /// <param name="diskId"> The disk id. </param>
        /// <param name="diskName"> The disk name. </param>
        /// <param name="protectionStage"> The protection stage. </param>
        /// <param name="healthErrorCode"> The health error code for the disk. </param>
        /// <param name="rpoInSeconds"> The RPO in seconds. </param>
        /// <param name="resyncRequired"> A value indicating whether resync is required for this disk. </param>
        /// <param name="resyncProgressPercentage"> The resync progress percentage. </param>
        /// <param name="resyncDurationInSeconds"> The resync duration in seconds. </param>
        /// <param name="diskCapacityInBytes"> The disk capacity in bytes. </param>
        /// <param name="fileSystemCapacityInBytes"> The disk file system capacity in bytes. </param>
        /// <param name="sourceDataInMegaBytes"> The source data transit in MB. </param>
        /// <param name="psDataInMegaBytes"> The PS data transit in MB. </param>
        /// <param name="targetDataInMegaBytes"> The target data transit in MB. </param>
        /// <param name="diskResized"> A value indicating whether disk is resized. </param>
        /// <param name="lastRpoCalculatedOn"> The last RPO calculated time. </param>
        /// <param name="resyncProcessedBytes"> The resync processed bytes. </param>
        /// <param name="resyncTotalTransferredBytes"> The resync total transferred bytes. </param>
        /// <param name="resyncLast15MinutesTransferredBytes"> The resync last 15 minutes transferred bytes. </param>
        /// <param name="resyncLastDataTransferOn"> The last data transfer time in UTC. </param>
        /// <param name="resyncStartOn"> The resync start time. </param>
        /// <param name="progressHealth"> The Progress Health. </param>
        /// <param name="progressStatus"> The Progress Status. </param>
        /// <param name="secondsToTakeSwitchProvider"> The seconds to take for switch provider. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InMageAzureV2ProtectedDiskDetails(string diskId, string diskName, string protectionStage, string healthErrorCode, long? rpoInSeconds, string resyncRequired, int? resyncProgressPercentage, long? resyncDurationInSeconds, long? diskCapacityInBytes, long? fileSystemCapacityInBytes, double? sourceDataInMegaBytes, double? psDataInMegaBytes, double? targetDataInMegaBytes, string diskResized, DateTimeOffset? lastRpoCalculatedOn, long? resyncProcessedBytes, long? resyncTotalTransferredBytes, long? resyncLast15MinutesTransferredBytes, DateTimeOffset? resyncLastDataTransferOn, DateTimeOffset? resyncStartOn, string progressHealth, string progressStatus, long? secondsToTakeSwitchProvider, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DiskId = diskId;
            DiskName = diskName;
            ProtectionStage = protectionStage;
            HealthErrorCode = healthErrorCode;
            RpoInSeconds = rpoInSeconds;
            ResyncRequired = resyncRequired;
            ResyncProgressPercentage = resyncProgressPercentage;
            ResyncDurationInSeconds = resyncDurationInSeconds;
            DiskCapacityInBytes = diskCapacityInBytes;
            FileSystemCapacityInBytes = fileSystemCapacityInBytes;
            SourceDataInMegaBytes = sourceDataInMegaBytes;
            PSDataInMegaBytes = psDataInMegaBytes;
            TargetDataInMegaBytes = targetDataInMegaBytes;
            DiskResized = diskResized;
            LastRpoCalculatedOn = lastRpoCalculatedOn;
            ResyncProcessedBytes = resyncProcessedBytes;
            ResyncTotalTransferredBytes = resyncTotalTransferredBytes;
            ResyncLast15MinutesTransferredBytes = resyncLast15MinutesTransferredBytes;
            ResyncLastDataTransferOn = resyncLastDataTransferOn;
            ResyncStartOn = resyncStartOn;
            ProgressHealth = progressHealth;
            ProgressStatus = progressStatus;
            SecondsToTakeSwitchProvider = secondsToTakeSwitchProvider;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The disk id. </summary>
        public string DiskId { get; }
        /// <summary> The disk name. </summary>
        public string DiskName { get; }
        /// <summary> The protection stage. </summary>
        public string ProtectionStage { get; }
        /// <summary> The health error code for the disk. </summary>
        public string HealthErrorCode { get; }
        /// <summary> The RPO in seconds. </summary>
        public long? RpoInSeconds { get; }
        /// <summary> A value indicating whether resync is required for this disk. </summary>
        public string ResyncRequired { get; }
        /// <summary> The resync progress percentage. </summary>
        public int? ResyncProgressPercentage { get; }
        /// <summary> The resync duration in seconds. </summary>
        public long? ResyncDurationInSeconds { get; }
        /// <summary> The disk capacity in bytes. </summary>
        public long? DiskCapacityInBytes { get; }
        /// <summary> The disk file system capacity in bytes. </summary>
        public long? FileSystemCapacityInBytes { get; }
        /// <summary> The source data transit in MB. </summary>
        public double? SourceDataInMegaBytes { get; }
        /// <summary> The PS data transit in MB. </summary>
        public double? PSDataInMegaBytes { get; }
        /// <summary> The target data transit in MB. </summary>
        public double? TargetDataInMegaBytes { get; }
        /// <summary> A value indicating whether disk is resized. </summary>
        public string DiskResized { get; }
        /// <summary> The last RPO calculated time. </summary>
        public DateTimeOffset? LastRpoCalculatedOn { get; }
        /// <summary> The resync processed bytes. </summary>
        public long? ResyncProcessedBytes { get; }
        /// <summary> The resync total transferred bytes. </summary>
        public long? ResyncTotalTransferredBytes { get; }
        /// <summary> The resync last 15 minutes transferred bytes. </summary>
        public long? ResyncLast15MinutesTransferredBytes { get; }
        /// <summary> The last data transfer time in UTC. </summary>
        public DateTimeOffset? ResyncLastDataTransferOn { get; }
        /// <summary> The resync start time. </summary>
        public DateTimeOffset? ResyncStartOn { get; }
        /// <summary> The Progress Health. </summary>
        public string ProgressHealth { get; }
        /// <summary> The Progress Status. </summary>
        public string ProgressStatus { get; }
        /// <summary> The seconds to take for switch provider. </summary>
        public long? SecondsToTakeSwitchProvider { get; }
    }
}
