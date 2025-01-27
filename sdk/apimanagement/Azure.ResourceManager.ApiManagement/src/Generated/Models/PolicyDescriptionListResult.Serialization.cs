// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    internal partial class PolicyDescriptionListResult
    {
        internal static PolicyDescriptionListResult DeserializePolicyDescriptionListResult(JsonElement element)
        {
            Optional<IReadOnlyList<PolicyDescriptionContractData>> value = default;
            Optional<long> count = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PolicyDescriptionContractData> array = new List<PolicyDescriptionContractData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PolicyDescriptionContractData.DeserializePolicyDescriptionContractData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("count"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    count = property.Value.GetInt64();
                    continue;
                }
            }
            return new PolicyDescriptionListResult(Optional.ToList(value), Optional.ToNullable(count));
        }
    }
}
