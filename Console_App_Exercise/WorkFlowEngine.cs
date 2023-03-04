namespace Console_App_Exercise;

public class WorkFlowEngine
{
    public static List<IWorkFlow> WorkFlows = new();

    public void AddWorkFlow(IWorkFlow workFlow)
    {
        WorkFlows.Add(workFlow);
    }

    public void RunWorkFlowEngine()
    {
        foreach (var workFlow in WorkFlows)
        {
            workFlow.Execute();
        }
    }
}