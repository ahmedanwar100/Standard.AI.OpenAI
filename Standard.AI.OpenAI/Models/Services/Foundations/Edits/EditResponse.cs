// ---------------------------------------------------------------------------------- 
// Copyright (c) The Standard Organization, a coalition of the Good-Hearted Engineers 
// ----------------------------------------------------------------------------------

namespace Standard.AI.OpenAI.Models.Services.Foundations.Edits
{
    public class EditResponse
    {
        public string Object { get; set; }
        public int Created { get; set; }
        public EditChoice[] Choices { get; set; }
        public EditUsage Usage { get; set; }
    }
}
