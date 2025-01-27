// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class ActivityTimelineItem
    {
        internal static ActivityTimelineItem DeserializeActivityTimelineItem(JsonElement element)
        {
            string queryId = default;
            DateTimeOffset bucketStartTimeUTC = default;
            DateTimeOffset bucketEndTimeUTC = default;
            DateTimeOffset firstActivityTimeUTC = default;
            DateTimeOffset lastActivityTimeUTC = default;
            string content = default;
            string title = default;
            EntityTimelineKind kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queryId"))
                {
                    queryId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bucketStartTimeUTC"))
                {
                    bucketStartTimeUTC = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("bucketEndTimeUTC"))
                {
                    bucketEndTimeUTC = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("firstActivityTimeUTC"))
                {
                    firstActivityTimeUTC = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastActivityTimeUTC"))
                {
                    lastActivityTimeUTC = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("content"))
                {
                    content = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("title"))
                {
                    title = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = new EntityTimelineKind(property.Value.GetString());
                    continue;
                }
            }
            return new ActivityTimelineItem(kind, queryId, bucketStartTimeUTC, bucketEndTimeUTC, firstActivityTimeUTC, lastActivityTimeUTC, content, title);
        }
    }
}
