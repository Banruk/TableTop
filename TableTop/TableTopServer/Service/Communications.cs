using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TableTopServer.Service
{
    class Communications : ServiceHost
    {
        public String Test(String input)
        {
            return input;
        }
    }
}
