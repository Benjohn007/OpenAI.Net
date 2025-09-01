using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OpenAI.Net.Models.ExternalCompleteions.ExternalCompletionResponse;

namespace OpenAI.Net.Models.Completions
{
    internal class CompletionResponse
    {
        public string Id { get; set; }
        public string Object { get; set; }
        public int Created { get; set; }
        public string Model { get; set; }

        public string SystemFingerprint { get; set; }
        public Choice[] Choices { get; set; }

        public Usage usage { get; set; }
    }
}
