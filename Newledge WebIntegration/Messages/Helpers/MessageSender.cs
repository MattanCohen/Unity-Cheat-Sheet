using CM = ConnectioNameSpace.ConnectionManager;

public static class MessageSender
{
    static int gameToken = -1;
    static int GetGameToken(){
        if (gameToken == -1){
            // INTEGRATION_TODO : set game token
        }
        return gameToken;
    }


    public static void JoinGame() {var task = new MessageJoinGame(GetGameToken()); SendMessage(task);}
    public static void CompleteScenario() {var task = new MessageScenarioComplete(GetGameToken()); SendMessage(task); }
    public static void LeaveGame() {var task = new MessageLeaveGame(GetGameToken()); SendMessage(task);}
    public static void FinishTask(int taskId, int taskTime){
        bool isCorrect = true;
        var task = new MessageTask(GetGameToken(), taskId, isCorrect, taskTime);
        SendMessage(task);
    }
    public static void FailTask(int taskId, int taskTime){
        bool isCorrect = false;
        var task = new MessageTask(GetGameToken(), taskId, isCorrect, taskTime);
        SendMessage(task);
    }

    static void SendMessage(Message task){
        // cache message items
        string message          = task.messageText;
        object [] objectsToSend = task.objectsToSend;

        // check for connection and connect if not yet connected
        if (!CM.IsConnected()){
            bool connectedSuccesfuly = CM.Connect();
            if (!connectedSuccesfuly){
                Debug.LogWarning("Couldn't send message online, because connection is unsuccesful");
                return;
            }
        }

        // send the message
        CM.connectionDetails.SendMessage(message, objectsToSend);
    }

    /// <summary>
    /// INTEGRATION_TODO : FIX THE RECIEVE OF JSON FILE
    /// </summary>
    public void RecieveMessage(){

    }
}