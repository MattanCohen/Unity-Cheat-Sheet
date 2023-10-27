public class MessageTask: Message
{
    int GetEpochTimeInMilliseconds() => (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;

    public MessageTask(int gameToken, int taskId, bool isCorrect, int taskTime){
        messageText = isCorrect ? "task-ended" : "error-counter";
        int epochTime = GetEpochTimeInMilliseconds();
        objectsToSend = new object[] { gameToken , epochTime , taskId , isCorrect , taskTime };
    }
}