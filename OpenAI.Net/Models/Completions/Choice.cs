using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAI.Net.Models.Completions
{
    internal class Choice
    {
        public string Text { get; set; }
        public int Index { get; set; }
        public object Logprobabilities { get; set; }
        public string FinishReason { get; set; }
    }
}
