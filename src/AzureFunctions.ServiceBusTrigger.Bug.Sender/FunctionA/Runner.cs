namespace AzureFunctions.ServiceBusTrigger.Bug.Sender.FunctionA
{
    public class Runner
    {
        public static void Run(string input, out string outputQueue)
        {
            outputQueue = input;
        }
    }
}
