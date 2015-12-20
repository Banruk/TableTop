using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Shared_Resources
{
    /// <summary>
    /// Static class containing methods for serialization/deserialization
    /// </summary>
    public static class Serialization
    {
        /// <summary>
        /// Method for serializing objects to xml files
        /// </summary>
        /// <param name="to_serialize">The object to serialize</param>
        /// <param name="objectType">The type of the object to serialize</param>
        /// <param name="file_path">The file path to save the object to</param>
        public static void xml_serialize(object to_serialize, Type objectType, String file_path)
        {
            XmlSerializer xs = new XmlSerializer(objectType);
            TextWriter tw = new StreamWriter(file_path);
            xs.Serialize(tw, to_serialize);
            tw.Close();
        }

        /// <summary>
        /// Method for deserializing objects from xml files
        /// </summary>
        /// <param name="objectType">The type of the object we're deserializing</param>
        /// <param name="file_path">The path to the XML document to deserialize from</param>
        /// <returns>The deserialized object</returns>
        public static object xml_deserialize(Type objectType, String file_path)
        {
            XmlSerializer xs = new XmlSerializer(objectType);
            using (var sr = new StreamReader(file_path))
            {
                return xs.Deserialize(sr);
            }
        }

    }
}
