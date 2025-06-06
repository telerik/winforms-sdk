using Azure.AI.OpenAI;
using Microsoft.Extensions.AI;
using OpenAI.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Documents.AIConnector;
using Telerik.Windows.Documents.TextRepresentation;

namespace GenAITest
{
    internal class AIManager
    {
        private readonly IChatClient iChatClient;
        private readonly int maxTokenCount = 128000;

        private readonly CompleteContextQuestionProcessor completeContextQuestionProcessor;
        private readonly SummarizationProcessor summarizationProcessor;

        public AIManager()
        {
            string key = Environment.GetEnvironmentVariable("AZUREOPENAI_KEY");
            string endpoint = Environment.GetEnvironmentVariable("AZUREOPENAI_ENDPOINT");
            string model = "gpt-4o-mini";

            AzureOpenAIClient azureClient = new(
                new Uri(endpoint),
                new Azure.AzureKeyCredential(key),
                new AzureOpenAIClientOptions());
            ChatClient chatClient = azureClient.GetChatClient(model);

            this.iChatClient = new OpenAIChatClient(chatClient);
            

            this.summarizationProcessor = new SummarizationProcessor(this.iChatClient, this.maxTokenCount);
            this.summarizationProcessor.Settings.PromptAddition = "Summarize the text in a few sentences. Be concise and clear.";
            this.summarizationProcessor.SummaryResourcesCalculated += SummarizationProcessor_SummaryResourcesCalculated;

            this.completeContextQuestionProcessor = new CompleteContextQuestionProcessor(this.iChatClient, this.maxTokenCount);
        }

        private void SummarizationProcessor_SummaryResourcesCalculated(object? sender, SummaryResourcesCalculatedEventArgs e)
        {
            Console.WriteLine($"The summary will require {e.EstimatedCallsRequired} calls and {e.EstimatedTokensRequired} tokens");
            e.ShouldContinueExecution = true;
        }

        public async Task<string> Summarize(ISimpleTextDocument document)
        {
            var result = await this.summarizationProcessor.Summarize(document);
            return result;
        }

        public async Task<string> AskQuestion(string question, ISimpleTextDocument document)
        {
            var result = await this.completeContextQuestionProcessor.AnswerQuestion(document, question);
            return result;
        }

        public async Task<string> AskPartialContextQuestion(string question, ISimpleTextDocument document)
        {
            PartialContextQuestionProcessor partialContextQuestionProcessor = new PartialContextQuestionProcessor(this.iChatClient, this.maxTokenCount, document);

            var result = await partialContextQuestionProcessor.AnswerQuestion(question);
            return result;
        }
    }
}
