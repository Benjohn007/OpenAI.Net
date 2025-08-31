using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace OpenAI.Net.Models.ExternalCompleteions
{
    internal partial class CompletionResponse
    {
        public class Choice
        {
            [JsonProperty("text")]           
            public string Text { get; set; }

            [JsonProperty("index")]          
            public int Index { get; set; }

            [JsonProperty( "logprobs")]
            public object Logprobabilities { get; set; }

            [JsonProperty("finish_reason")]           
            public string FinishReason { get; set; }
        }

    }
}
