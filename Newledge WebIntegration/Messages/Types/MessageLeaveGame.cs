public class MessageLeaveGame: Message
{
    public MessageLeaveGame(int gameToken){
        messageText = "leave-game";
        objectsToSend = new object[] { gameToken };
    }
}