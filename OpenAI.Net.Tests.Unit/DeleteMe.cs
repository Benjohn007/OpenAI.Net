using OpenAI.Net.Brokers.OpenAIs;
using OpenAI.Net.Models;
using OpenAI.Net.Models.ExternalCompleteions;
using System.Threading.Tasks;

namespace OpenAI.Net.Tests.Unit
{
    public class DeleteMe
    {
        [Fact]
        public void ShouldBeTrue() => Assert.True(true);

       // [Fact]
        //public async Task ShouldDoStuffAndDeleteMeTooAsync()
        //{
        //    var apiConfiguration = new ApiConfigurations
        //    {
        //        ApiKey = "",
        //        ApiUrl = "https://api.openai.com/",
        //        OrganisationId = "",
        //    };

        //    var openAIBroker = new OpenAIBroker(apiConfiguration);
        //    var completeRequest = new CompletionRequest
        //    {
        //        Model = "gpt-3.5-turbo-instruct",
        //        Prompt = new string[] { "Human: Hello", "AI:"},
        //        MaxTokens = 5,
        //        Temperature = 0.9,
        //        ProbabilityMass = 1,
        //        FrequencyPenalty = 0,
        //        PresencePenalty = 0
        //    };

        //    CompletionResponse completionResponse = await openAIBroker.PostCompletionRequestAsync(completeRequest);

        //    Assert.NotNull(completionResponse);
        //}
    }
}