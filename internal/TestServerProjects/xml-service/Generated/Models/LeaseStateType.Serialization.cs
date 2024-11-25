// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace xml_service.Models
{
    internal static partial class LeaseStateTypeExtensions
    {
        public static string ToSerialString(this LeaseStateType value) => value switch
        {
            LeaseStateType.Available => "available",
            LeaseStateType.Leased => "leased",
            LeaseStateType.Expired => "expired",
            LeaseStateType.Breaking => "breaking",
            LeaseStateType.Broken => "broken",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown LeaseStateType value.")
        };

        public static LeaseStateType ToLeaseStateType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "available")) return LeaseStateType.Available;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "leased")) return LeaseStateType.Leased;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "expired")) return LeaseStateType.Expired;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "breaking")) return LeaseStateType.Breaking;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "broken")) return LeaseStateType.Broken;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown LeaseStateType value.");
        }
    }
}