// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MgmtMockAndSample.Models
{
    public partial class FirewallPolicyRuleCollection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("ruleCollectionType"u8);
            writer.WriteStringValue(RuleCollectionType.ToString());
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteNumberValue(Priority.Value);
            }
            writer.WriteEndObject();
        }

        internal static FirewallPolicyRuleCollection DeserializeFirewallPolicyRuleCollection(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("ruleCollectionType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "FirewallPolicyFilterRuleCollection": return FirewallPolicyFilterRuleCollection.DeserializeFirewallPolicyFilterRuleCollection(element);
                    case "FirewallPolicyNatRuleCollection": return FirewallPolicyNatRuleCollection.DeserializeFirewallPolicyNatRuleCollection(element);
                }
            }
            return UnknownFirewallPolicyRuleCollection.DeserializeUnknownFirewallPolicyRuleCollection(element);
        }
    }
}