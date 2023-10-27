public class MessageJoinGame: Message
{
    public MessageJoinGame(int gameToken){
        messageText = "joined-game";
        objectsToSend = new object[] { gameToken };
    }
}