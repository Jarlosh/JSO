using System;
using System.Collections.Generic;

namespace NagaiTools.JSO
{
    public static class JSOIgnoredTypes
    {
        private static readonly List<string> ignoreClassFullNames = new List<string>
        {
            "TMPro.TMP_FontAsset"
        };

        public static bool IsIgnored(Type type)
        {
            return ignoreClassFullNames.Contains(type.FullName);
        }
    }
}