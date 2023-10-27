namespace ConnectioNameSpace
{
    // INTEGRATION_TODO :  class to contain connection details
    public class ConnectionDetails{
        // Constractor
        public ConnectionDetails(){

        }

        /// <summary>
        /// sends a message online to those connection details
        /// </summary>
        /// <param name="message">      the message name            </param>
        /// <param name="objects">  the message's objects to send    </param>
        public void SendMessage(string message, object [] objects){
            
        }
    }


    public static class ConnectionManager{
        public static ConnectionDetails connectionDetails;
        
        public static bool IsConnected() => connectionDetails != null;

        public static bool Connect(){

            // connection segment
            bool connected = false;
            // INTEGRATION_TODO :      CODE TO ATTEMP A CONNECTION
            // ------------------

            // on fail:
            if (!connected){
                Debug.Log("Web communication couldn't connect");
                return false;
            }
            // on success:
            else{
                connectionDetails = new ConnectionDetails();

                Debug.Log("Connected succesfuly.");
                return true;
            }
        }

        public static bool Disconnect(){

            // dicconnection segment
            bool disconnected = false;
            // INTEGRATION_TODO :       CODE TO ATTEMP A DISCONNECTION
            // ------------------
            
            // on fail:
            if (!disconnected){
                Debug.Log("Web communication couldn't disconnect");
                return false;
            }
            // on success:
            else{
                connectionDetails = null;

                Debug.Log("Disconnected succesfuly.");
                return true;
            }
        }
    }   
}