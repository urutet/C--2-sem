using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace LAB2_3
{
    static class SerializerClass
    {
        public static void SerializeJSON<T>(string path, T obj)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                    string serialize = JsonConvert.SerializeObject(obj, Formatting.Indented);
                    sw.Write(serialize);

                    sw.Close();
            }
        }

        public static T DeserializeJSON<T>(string path)
        {
            T computer;
            using (StreamReader sr = new StreamReader(path))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                computer = (T)jsonSerializer.Deserialize(sr, typeof(T));
                sr.Close();
            }
            return computer;
        }
    }
}
