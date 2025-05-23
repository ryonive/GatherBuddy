﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GatherBuddy.Enums;

[JsonConverter(typeof(StringEnumConverter))]
public enum BiteType : byte
{
    Unknown   = 0,
    Weak      = 36,
    Strong    = 37,
    Legendary = 38,
    None      = 255,
}
