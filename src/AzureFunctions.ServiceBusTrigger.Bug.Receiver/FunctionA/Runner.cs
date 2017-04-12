using Microsoft.Azure.WebJobs.Host;

namespace AzureFunctions.ServiceBusTrigger.Bug.Receiver.FunctionA
{
    public class Runner
    {
        public static void Run(string message, TraceWriter log)
        {
            log.Info($"FunctionA processed the message: {message}");
        }
    }
}
