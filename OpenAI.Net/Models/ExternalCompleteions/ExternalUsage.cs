using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace OpenAI.Net.Models.ExternalCompleteions
{
    internal partial class ExternalCompletionResponse
    {
        public class ExternalUsage
        {
            [JsonProperty("prompt_tokens")]         
            public int PromptTokens { get; set; }

            [JsonProperty("completion_tokens")]
            public int CompletionTokens { get; set; }

            [JsonProperty("total_tokens")]
            public int TotalTokens { get; set; }
        }

    }
}
