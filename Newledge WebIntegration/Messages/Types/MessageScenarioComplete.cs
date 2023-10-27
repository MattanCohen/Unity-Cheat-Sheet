using System;

public class MessageScenarioComplete: Message
{
    int GetEpochTimeInMilliseconds() => (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;

    public MessageScenarioComplete(int gameToken){
        messageText = "scenario-completed";
        int epochTime = GetEpochTimeInMilliseconds();
        objectsToSend = new object[] { gameToken , epochTime };
    }
}