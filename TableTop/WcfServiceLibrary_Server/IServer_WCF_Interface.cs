using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary_Server
{
    [ServiceContract(SessionMode = SessionMode.Required,
                 CallbackContract = typeof(Client_WCF_Interface))]
    public interface IServer_WCF_Interface
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        void performConnection(Boolean isGM);
    }

    [ServiceContract]
    public interface Client_WCF_Interface
    {
        [OperationContract]
        void dummy();
    }

}
