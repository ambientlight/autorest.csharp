// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace CognitiveSearch.Models
{
    internal static class SnowballTokenFilterLanguageExtensions
    {
        public static string ToSerialString(this SnowballTokenFilterLanguage value) => value switch
        {
            SnowballTokenFilterLanguage.Armenian => "armenian",
            SnowballTokenFilterLanguage.Basque => "basque",
            SnowballTokenFilterLanguage.Catalan => "catalan",
            SnowballTokenFilterLanguage.Danish => "danish",
            SnowballTokenFilterLanguage.Dutch => "dutch",
            SnowballTokenFilterLanguage.English => "english",
            SnowballTokenFilterLanguage.Finnish => "finnish",
            SnowballTokenFilterLanguage.French => "french",
            SnowballTokenFilterLanguage.German => "german",
            SnowballTokenFilterLanguage.German2 => "german2",
            SnowballTokenFilterLanguage.Hungarian => "hungarian",
            SnowballTokenFilterLanguage.Italian => "italian",
            SnowballTokenFilterLanguage.Kp => "kp",
            SnowballTokenFilterLanguage.Lovins => "lovins",
            SnowballTokenFilterLanguage.Norwegian => "norwegian",
            SnowballTokenFilterLanguage.Porter => "porter",
            SnowballTokenFilterLanguage.Portuguese => "portuguese",
            SnowballTokenFilterLanguage.Romanian => "romanian",
            SnowballTokenFilterLanguage.Russian => "russian",
            SnowballTokenFilterLanguage.Spanish => "spanish",
            SnowballTokenFilterLanguage.Swedish => "swedish",
            SnowballTokenFilterLanguage.Turkish => "turkish",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SnowballTokenFilterLanguage value.")
        };

        public static SnowballTokenFilterLanguage ToSnowballTokenFilterLanguage(this string value) => value switch
        {
            "armenian" => SnowballTokenFilterLanguage.Armenian,
            "basque" => SnowballTokenFilterLanguage.Basque,
            "catalan" => SnowballTokenFilterLanguage.Catalan,
            "danish" => SnowballTokenFilterLanguage.Danish,
            "dutch" => SnowballTokenFilterLanguage.Dutch,
            "english" => SnowballTokenFilterLanguage.English,
            "finnish" => SnowballTokenFilterLanguage.Finnish,
            "french" => SnowballTokenFilterLanguage.French,
            "german" => SnowballTokenFilterLanguage.German,
            "german2" => SnowballTokenFilterLanguage.German2,
            "hungarian" => SnowballTokenFilterLanguage.Hungarian,
            "italian" => SnowballTokenFilterLanguage.Italian,
            "kp" => SnowballTokenFilterLanguage.Kp,
            "lovins" => SnowballTokenFilterLanguage.Lovins,
            "norwegian" => SnowballTokenFilterLanguage.Norwegian,
            "porter" => SnowballTokenFilterLanguage.Porter,
            "portuguese" => SnowballTokenFilterLanguage.Portuguese,
            "romanian" => SnowballTokenFilterLanguage.Romanian,
            "russian" => SnowballTokenFilterLanguage.Russian,
            "spanish" => SnowballTokenFilterLanguage.Spanish,
            "swedish" => SnowballTokenFilterLanguage.Swedish,
            "turkish" => SnowballTokenFilterLanguage.Turkish,
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SnowballTokenFilterLanguage value.")
        };
    }
}