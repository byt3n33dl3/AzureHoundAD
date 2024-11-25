// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace MgmtMockAndSample.Models
{
    internal partial class RoleAssignmentListResult
    {
        internal static RoleAssignmentListResult DeserializeRoleAssignmentListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<RoleAssignmentData> value = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RoleAssignmentData> array = new List<RoleAssignmentData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RoleAssignmentData.DeserializeRoleAssignmentData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new RoleAssignmentListResult(value ?? new ChangeTrackingList<RoleAssignmentData>(), nextLink);
        }
    }
}