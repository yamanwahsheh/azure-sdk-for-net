// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    internal static partial class AppServiceDomainTypeExtensions
    {
        public static string ToSerialString(this AppServiceDomainType value) => value switch
        {
            AppServiceDomainType.Regular => "Regular",
            AppServiceDomainType.SoftDeleted => "SoftDeleted",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AppServiceDomainType value.")
        };

        public static AppServiceDomainType ToAppServiceDomainType(this string value)
        {
            if (string.Equals(value, "Regular", StringComparison.InvariantCultureIgnoreCase)) return AppServiceDomainType.Regular;
            if (string.Equals(value, "SoftDeleted", StringComparison.InvariantCultureIgnoreCase)) return AppServiceDomainType.SoftDeleted;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AppServiceDomainType value.");
        }
    }
}
