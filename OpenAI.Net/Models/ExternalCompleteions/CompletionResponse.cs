using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace OpenAI.Net.Models.ExternalCompleteions
{
    internal partial class CompletionResponse
    {

        [JsonProperty("id")]
        
        public string Id { get; set; }
        [JsonProperty("_object")]
        
        public string Object { get; set; }
        [JsonProperty("created")]
        
        public int Created { get; set; }
        [JsonProperty("model")]
        
        public string Model { get; set; }
        [JsonProperty("system_fingerprint")]
        
        public string SystemFingerprint { get; set; }
        [JsonProperty("choices")]
        public Choice[] Choices { get; set; }
       
        [JsonProperty("usage")]
        public Usage usage { get; set; }

    }
}
