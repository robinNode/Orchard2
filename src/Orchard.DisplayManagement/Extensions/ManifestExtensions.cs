﻿using Orchard.Environment.Extensions;
using System;

namespace Orchard.DisplayManagement
{
    public static class ManifestExtensions
    {
        public static bool IsTheme(this IManifestInfo manifestInfo)
        {
            return manifestInfo.Type.Equals("theme", StringComparison.OrdinalIgnoreCase);
        }
    }
}