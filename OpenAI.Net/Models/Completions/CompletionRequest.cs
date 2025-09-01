using System.Collections.Generic;

namespace OpenAI.Net.Models.Completions
{
    internal class CompletionRequest
    {
        public string Model { get; set; }
        public string[] Prompt { get; set; } = new string[0];
        public string? Suffix { get; set; }
        public int? MaxTokens { get; set; }
        public double? Temperature { get; set; }
        public double? ProbabilityMass { get; set; }
        public int? CompletionsPerPrompt { get; set; }
        public bool? Stream { get; set; }
        public int? LogProbabilities { get; set; }
        public bool? Echo { get; set; }
        public string[]? Stop { get; set; }
        public double? PresencePenalty { get; set; }
        public double? FrequencyPenalty { get; set; }
        public int? BestOf { get; set; }
        public Dictionary<string, int>? LogitBias { get; set; }
        public string? User { get; set; }
    }
}
