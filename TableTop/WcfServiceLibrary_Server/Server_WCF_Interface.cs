using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary_Server
{
    public class Server_WCF_Interface : IServer_WCF_Interface
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public void performConnection(Boolean isGM)
        {

        }

        Client_WCF_Interface Callback
        {
            get
            {
                return OperationContext.Current.GetCallbackChannel<Client_WCF_Interface>();
            }
        }
    }

}
