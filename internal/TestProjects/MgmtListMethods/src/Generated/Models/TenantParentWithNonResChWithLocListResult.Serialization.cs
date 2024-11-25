// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace MgmtListMethods.Models
{
    internal partial class TenantParentWithNonResChWithLocListResult
    {
        internal static TenantParentWithNonResChWithLocListResult DeserializeTenantParentWithNonResChWithLocListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<TenantParentWithNonResChWithLocData> value = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<TenantParentWithNonResChWithLocData> array = new List<TenantParentWithNonResChWithLocData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TenantParentWithNonResChWithLocData.DeserializeTenantParentWithNonResChWithLocData(item));
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
            return new TenantParentWithNonResChWithLocListResult(value, nextLink);
        }
    }
}
