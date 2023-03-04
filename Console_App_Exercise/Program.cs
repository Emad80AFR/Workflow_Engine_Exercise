namespace Console_App_Exercise
{
    public interface IWorkFlow
    {
        void Execute();
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var workFlowEngine = new WorkFlowEngine();
            workFlowEngine.AddWorkFlow(new AntivirusExecute());
            workFlowEngine.AddWorkFlow(new OperationSystem());
            workFlowEngine.AddWorkFlow(new ApplicationExecute());
            workFlowEngine.RunWorkFlowEngine();
            Console.WriteLine();
        }
    }
}