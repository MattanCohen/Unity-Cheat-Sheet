using UnityEngine;

public class NewledgeTask
{
    int taskId;
    int startTime;
    
    public NewledgeTask(int taskId){
        this.taskId = taskId;
        startTime = Time.time;
    }

    public int GetTaskTime() => Time.time - startTime;
}