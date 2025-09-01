using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OpenAI.Net.Models.ExternalCompleteions.ExternalCompletionResponse;

namespace OpenAI.Net.Models.Completions
{
    internal class Usage
    {
        public int PromptTokens { get; set; }
        public int CompletionTokens { get; set; }
        public int TotalTokens { get; set; }
    }
}
