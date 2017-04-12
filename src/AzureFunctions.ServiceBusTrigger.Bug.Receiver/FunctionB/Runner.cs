using Microsoft.Azure.WebJobs.Host;

namespace AzureFunctions.ServiceBusTrigger.Bug.Receiver.FunctionB
{
    public class Runner
    {
        public static void Run(string message, TraceWriter log)
        {
            log.Info($"FunctionB processed the message: {message}");
        }
    }
}
