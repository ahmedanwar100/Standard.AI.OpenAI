// ---------------------------------------------------------------------------------- 
// Copyright (c) The Standard Organization, a coalition of the Good-Hearted Engineers 
// ----------------------------------------------------------------------------------

namespace Standard.AI.OpenAI.Models.Services.Foundations.Edits
{
    public class EditUsage
    {
        public int TotalPrompTokens { get; set; }
        public int TotalCompletionTokens { get; set; }
        public int TotalTokens { get; set; }
    }
}
