// ---------------------------------------------------------------------------------- 
// Copyright (c) The Standard Organization, a coalition of the Good-Hearted Engineers 
// ----------------------------------------------------------------------------------

namespace Standard.AI.OpenAI.Models.Services.Foundations.Edits
{
    public class EditRequest
    {
        public string Model { get; set; }
        public string Input { get; set; }
        public string Instruction { get; set; }
        public int NumberOfEdits { get; set; }
        public decimal Temperature { get; set; }
        public double ProbabilityMass { get; set; }
    }
}
