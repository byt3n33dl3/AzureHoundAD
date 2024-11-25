// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace MgmtScopeResource.Models
{
    public partial class DeploymentOperation
    {
        internal static DeploymentOperation DeserializeDeploymentOperation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string operationId = default;
            DeploymentOperationProperties properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = DeploymentOperationProperties.DeserializeDeploymentOperationProperties(property.Value);
                    continue;
                }
            }
            return new DeploymentOperation(id, operationId, properties);
        }
    }
}