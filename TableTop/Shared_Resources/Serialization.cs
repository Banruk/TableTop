using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Resources
{
    /// <summary>
    /// Static class containing methods for serialization/deserialization
    /// </summary>
    public static class Serialization
    {
        /// <summary>
        /// Method used to serialize an object for transfer
        /// </summary>
        /// <param name="input">The object to be serialized</param>
        /// <returns>A string representing the serialized object</returns>
        public static string serialize(object input)
        {
            using (MemoryStream mStream = new MemoryStream())
            using (StreamReader reader = new StreamReader(mStream))
            {
                DataContractSerializer serializer = new DataContractSerializer(input.GetType());
                serializer.WriteObject(mStream, input);
                mStream.Position = 0;
                return reader.ReadToEnd();
            }
        }

        /// <summary>
        /// This method is used to deserialize a given object.
        /// </summary>
        /// <param name="input">The contents of the object to deserialize</param>
        /// <param name="objType">The type of the object to deserialize</param>
        /// <returns>The object after it has been deserialized</returns>
        public static object deserialize(string input, Type objType)
        {
            using (Stream stream = new MemoryStream())
            {
                byte[] data = System.Text.Encoding.UTF8.GetBytes(input);
                stream.Write(data, 0, data.Length);
                stream.Position = 0;
                DataContractSerializer deserializer = new DataContractSerializer(objType);
                return deserializer.ReadObject(stream);
            }
        }

    }
}
