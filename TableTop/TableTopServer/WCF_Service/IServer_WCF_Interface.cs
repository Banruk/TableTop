using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace TableTopServer.WCF_Service
{

    [ServiceContract(SessionMode = SessionMode.Required,
                 CallbackContract = typeof(Client_WCF_Interface))]
    public interface IServer_WCF_Interface
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        void performConnection(String userName, Boolean isGM);

        [OperationContract]
        void recieveChatInput(String chatType, String message);
    }

    [ServiceContract]
    public interface Client_WCF_Interface
    {
        [OperationContract]
        void recieveChatInput(String chatType, String message);
    }
}
