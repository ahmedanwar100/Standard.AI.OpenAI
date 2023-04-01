// ---------------------------------------------------------------------------------- 
// Copyright (c) The Standard Organization, a coalition of the Good-Hearted Engineers 
// ----------------------------------------------------------------------------------

using System.Threading.Tasks;
using Standard.AI.OpenAI.Models.Services.Foundations.Edits;

namespace Standard.AI.OpenAI.Services.Foundations.Edits
{
    internal interface IEditService
    {
        ValueTask<Edit> EditAsync(Edit edit);
    }
}
