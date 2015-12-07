using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Resources
{
    static public class DebugLogger
    {
        static String filePath;

        static public void setDebugPath(String path)
        {
            filePath = path;
        }

        static public void writeDebug(String message)
        {
            StreamWriter file = new StreamWriter(filePath);
            file.WriteLine(message);
            file.Close();
        }
    }
}
