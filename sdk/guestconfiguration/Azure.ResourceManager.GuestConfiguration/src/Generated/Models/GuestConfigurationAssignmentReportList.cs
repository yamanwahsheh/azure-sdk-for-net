// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    /// <summary> List of guest configuration assignment reports. </summary>
    internal partial class GuestConfigurationAssignmentReportList
    {
        /// <summary> Initializes a new instance of GuestConfigurationAssignmentReportList. </summary>
        internal GuestConfigurationAssignmentReportList()
        {
            Value = new ChangeTrackingList<GuestConfigurationAssignmentReport>();
        }

        /// <summary> Initializes a new instance of GuestConfigurationAssignmentReportList. </summary>
        /// <param name="value"> List of reports for the guest configuration. Report contains information such as compliance status, reason and more. </param>
        internal GuestConfigurationAssignmentReportList(IReadOnlyList<GuestConfigurationAssignmentReport> value)
        {
            Value = value;
        }

        /// <summary> List of reports for the guest configuration. Report contains information such as compliance status, reason and more. </summary>
        public IReadOnlyList<GuestConfigurationAssignmentReport> Value { get; }
    }
}
