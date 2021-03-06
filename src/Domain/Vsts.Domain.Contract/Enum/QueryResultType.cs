﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Vsts.Domain.Contract.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum QueryResultType
    {
        [EnumMember(Value = "workItem")]
        WorkItem = 0
    }
}