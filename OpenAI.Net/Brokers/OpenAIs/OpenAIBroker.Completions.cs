using OpenAI.Net.Models.ExternalCompleteions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAI.Net.Brokers.OpenAIs
{
    internal partial class OpenAIBroker
    {
        public async ValueTask<CompletionResponse> PostCompletionRequestAsync(CompletionRequest completionRequest) =>
            await PostAsync<CompletionRequest, CompletionResponse>(relativeUrl: "v1/completions", completionRequest);

    }
}
