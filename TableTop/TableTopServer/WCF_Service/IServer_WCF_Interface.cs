using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Drawing;
using Character;

namespace TableTopServer.WCF_Service
{

    [ServiceContract(SessionMode = SessionMode.Required,
                 CallbackContract = typeof(Client_WCF_Interface))]
    public interface IServer_WCF_Interface
    {
        [OperationContract]
        int performConnection(String userName, Boolean isGM, ref String gameMode);

        [OperationContract]
        void getCurrentlyConnectedPlayers(int client_id);

        [OperationContract]
        void recieveChatInput(String chatType, String message);

        [OperationContract]
        void updateUserProfile(int client_id, CharacterSheet characterSheet);

        [OperationContract]
        void connectionClose(int client_id);
    }

    [ServiceContract]
    public interface Client_WCF_Interface
    {
        [OperationContract]
        void newUserLoggedIn(int client_id, String user_name);

        [OperationContract]
        void loadLoggedInUsers(int client_id, CharacterSheet sheet);

        [OperationContract]
        void updateUserProfile(int client_id, CharacterSheet characterSheet);

        [OperationContract]
        void recieveChatInput(String chatType, String message);

        [OperationContract]
        void clientDisconnected(int client_id);
    }
}
