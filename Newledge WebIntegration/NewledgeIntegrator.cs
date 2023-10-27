using UnityEngine;
using System.Linq;
using System.Collections.Generic;


public static class NewledgeIntegrator : MonoBehaviour {
    static List<NewledgeTask> tasks;

#region Game integration functions
    public static void JoinGame()           => MessageSender.JoinGame();
    public static void CompleteScenario()   => MessageSender.CompleteScenario();
    public static void LeaveGame()          => MessageSender.LeaveGame();
#endregion

#region Tasks integration functions
    public static void StartNewTask(){
        int taskId = -1; // INTEGRATION_TODO - find the right task id
        
        var task = new NewledgeTask(taskId); 
        tasks.Add(task);
    }

    public static void FailInTask()         => MessageSender.FailTask   (tasks.Last().taskId, tasks.Last().GetTaskTime());
    public static void SucceedInTask()      => MessageSender.FinishTask (tasks.Last().taskId, tasks.Last().GetTaskTime());
#endregion
}