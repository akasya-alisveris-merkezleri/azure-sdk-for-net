// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class SqlVmAutoBackupSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enable");
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(IsEncryptionEnabled))
            {
                writer.WritePropertyName("enableEncryption");
                writer.WriteBooleanValue(IsEncryptionEnabled.Value);
            }
            if (Optional.IsDefined(RetentionPeriodInDays))
            {
                writer.WritePropertyName("retentionPeriod");
                writer.WriteNumberValue(RetentionPeriodInDays.Value);
            }
            if (Optional.IsDefined(StorageAccountUri))
            {
                writer.WritePropertyName("storageAccountUrl");
                writer.WriteStringValue(StorageAccountUri.AbsoluteUri);
            }
            if (Optional.IsDefined(StorageContainerName))
            {
                writer.WritePropertyName("storageContainerName");
                writer.WriteStringValue(StorageContainerName);
            }
            if (Optional.IsDefined(StorageAccessKey))
            {
                writer.WritePropertyName("storageAccessKey");
                writer.WriteStringValue(StorageAccessKey);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password");
                writer.WriteStringValue(Password);
            }
            if (Optional.IsDefined(AreSystemDbsIncludedInBackup))
            {
                writer.WritePropertyName("backupSystemDbs");
                writer.WriteBooleanValue(AreSystemDbsIncludedInBackup.Value);
            }
            if (Optional.IsDefined(BackupScheduleType))
            {
                writer.WritePropertyName("backupScheduleType");
                writer.WriteStringValue(BackupScheduleType.Value.ToString());
            }
            if (Optional.IsDefined(FullBackupFrequency))
            {
                writer.WritePropertyName("fullBackupFrequency");
                writer.WriteStringValue(FullBackupFrequency.Value.ToString());
            }
            if (Optional.IsCollectionDefined(DaysOfWeek))
            {
                writer.WritePropertyName("daysOfWeek");
                writer.WriteStartArray();
                foreach (var item in DaysOfWeek)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FullBackupStartHour))
            {
                writer.WritePropertyName("fullBackupStartTime");
                writer.WriteNumberValue(FullBackupStartHour.Value);
            }
            if (Optional.IsDefined(FullBackupWindowHours))
            {
                writer.WritePropertyName("fullBackupWindowHours");
                writer.WriteNumberValue(FullBackupWindowHours.Value);
            }
            if (Optional.IsDefined(LogBackupFrequency))
            {
                writer.WritePropertyName("logBackupFrequency");
                writer.WriteNumberValue(LogBackupFrequency.Value);
            }
            writer.WriteEndObject();
        }

        internal static SqlVmAutoBackupSettings DeserializeSqlVmAutoBackupSettings(JsonElement element)
        {
            Optional<bool> enable = default;
            Optional<bool> enableEncryption = default;
            Optional<int> retentionPeriod = default;
            Optional<Uri> storageAccountUrl = default;
            Optional<string> storageContainerName = default;
            Optional<string> storageAccessKey = default;
            Optional<string> password = default;
            Optional<bool> backupSystemDbs = default;
            Optional<SqVmBackupScheduleType> backupScheduleType = default;
            Optional<SqlVmFullBackupFrequency> fullBackupFrequency = default;
            Optional<IList<SqlVmAutoBackupDayOfWeek>> daysOfWeek = default;
            Optional<int> fullBackupStartTime = default;
            Optional<int> fullBackupWindowHours = default;
            Optional<int> logBackupFrequency = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableEncryption"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enableEncryption = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("retentionPeriod"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    retentionPeriod = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("storageAccountUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        storageAccountUrl = null;
                        continue;
                    }
                    storageAccountUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageContainerName"))
                {
                    storageContainerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageAccessKey"))
                {
                    storageAccessKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupSystemDbs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    backupSystemDbs = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("backupScheduleType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    backupScheduleType = new SqVmBackupScheduleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fullBackupFrequency"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fullBackupFrequency = new SqlVmFullBackupFrequency(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("daysOfWeek"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SqlVmAutoBackupDayOfWeek> array = new List<SqlVmAutoBackupDayOfWeek>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new SqlVmAutoBackupDayOfWeek(item.GetString()));
                    }
                    daysOfWeek = array;
                    continue;
                }
                if (property.NameEquals("fullBackupStartTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fullBackupStartTime = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("fullBackupWindowHours"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fullBackupWindowHours = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("logBackupFrequency"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    logBackupFrequency = property.Value.GetInt32();
                    continue;
                }
            }
            return new SqlVmAutoBackupSettings(Optional.ToNullable(enable), Optional.ToNullable(enableEncryption), Optional.ToNullable(retentionPeriod), storageAccountUrl.Value, storageContainerName.Value, storageAccessKey.Value, password.Value, Optional.ToNullable(backupSystemDbs), Optional.ToNullable(backupScheduleType), Optional.ToNullable(fullBackupFrequency), Optional.ToList(daysOfWeek), Optional.ToNullable(fullBackupStartTime), Optional.ToNullable(fullBackupWindowHours), Optional.ToNullable(logBackupFrequency));
        }
    }
}
