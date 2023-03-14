﻿// --------------------------------------------------------------- 
// Copyright (c) Coalition of the Good-Hearted Engineers 
// ---------------------------------------------------------------

using Newtonsoft.Json;

namespace OpenAI.NET.Models.ExternalCompletions
{
    public class Choice
    {
        [JsonProperty(propertyName: "text")]
        public string Text { get; set; }

        [JsonProperty(propertyName: "index")]
        public int Index { get; set; }

        [JsonProperty(propertyName: "logprobs")]
        public object LogProbabilities { get; set; }

        [JsonProperty(propertyName: "finish_reason")]
        public string Finish_reason { get; set; }
    }
}