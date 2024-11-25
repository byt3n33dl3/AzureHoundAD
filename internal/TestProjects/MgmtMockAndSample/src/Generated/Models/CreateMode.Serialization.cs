// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace MgmtMockAndSample.Models
{
    internal static partial class CreateModeExtensions
    {
        public static string ToSerialString(this CreateMode value) => value switch
        {
            CreateMode.Recover => "recover",
            CreateMode.Default => "default",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CreateMode value.")
        };

        public static CreateMode ToCreateMode(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "recover")) return CreateMode.Recover;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "default")) return CreateMode.Default;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CreateMode value.");
        }
    }
}