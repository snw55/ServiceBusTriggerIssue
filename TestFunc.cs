using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace ServiceBusTriggerIssue
{
    public static class TestFunc
    {
        [FunctionName("TestFunc")]
        public static void Run([ServiceBusTrigger("%ServiceBusSettings:QueueName%", Connection = "ServiceBusSettings:ServiceBusConnection")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
