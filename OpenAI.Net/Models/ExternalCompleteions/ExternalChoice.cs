using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace OpenAI.Net.Models.ExternalCompleteions
{
    internal partial class ExternalCompletionResponse
    {
        public class ExternalChoice
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
