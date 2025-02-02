// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> The BackupResourceEncryptionConfigExtended. </summary>
    public partial class BackupResourceEncryptionConfigExtended : BackupResourceEncryptionConfig
    {
        /// <summary> Initializes a new instance of BackupResourceEncryptionConfigExtended. </summary>
        public BackupResourceEncryptionConfigExtended()
        {
        }

        /// <summary> Initializes a new instance of BackupResourceEncryptionConfigExtended. </summary>
        /// <param name="encryptionAtRestType"> Encryption At Rest Type. </param>
        /// <param name="keyUri"> Key Vault Key URI. </param>
        /// <param name="subscriptionId"> Key Vault Subscription Id. </param>
        /// <param name="lastUpdateStatus"></param>
        /// <param name="infrastructureEncryptionState"></param>
        /// <param name="userAssignedIdentity"> User Assigned Identity Id. </param>
        /// <param name="useSystemAssignedIdentity"> bool to indicate whether to use system Assigned Identity or not. </param>
        internal BackupResourceEncryptionConfigExtended(EncryptionAtRestType? encryptionAtRestType, Uri keyUri, string subscriptionId, LastUpdateStatus? lastUpdateStatus, InfrastructureEncryptionState? infrastructureEncryptionState, string userAssignedIdentity, bool? useSystemAssignedIdentity) : base(encryptionAtRestType, keyUri, subscriptionId, lastUpdateStatus, infrastructureEncryptionState)
        {
            UserAssignedIdentity = userAssignedIdentity;
            UseSystemAssignedIdentity = useSystemAssignedIdentity;
        }

        /// <summary> User Assigned Identity Id. </summary>
        public string UserAssignedIdentity { get; set; }
        /// <summary> bool to indicate whether to use system Assigned Identity or not. </summary>
        public bool? UseSystemAssignedIdentity { get; set; }
    }
}
