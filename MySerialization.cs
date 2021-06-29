using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace MASI_pro
{
    public static class MySerialization
    {
        private static string unitermsPath = @"../../SavedUniterms/";

        public static string getUnitermsPath() { return unitermsPath; }
        public static bool TrySerializeObject<T>(T serializableObject, string fileName)
        {
            if (serializableObject == null) { Console.WriteLine("Przekazany obiekt nie mozna serializowac"); return false; }

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(serializableObject.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, serializableObject);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    xmlDocument.Save(fileName);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Blad podczas serializacji, blad: " + ex.Message);
                return false;
            }
        }

        public static T DeSerializeObject<T>(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) { return default(T); }

            T objectOut = default(T);

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(fileName);
                string xmlString = xmlDocument.OuterXml;

                using (StringReader read = new StringReader(xmlString))
                {
                    Type outType = typeof(T);

                    XmlSerializer serializer = new XmlSerializer(outType);
                    using (XmlReader reader = new XmlTextReader(read))
                    {
                        objectOut = (T)serializer.Deserialize(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Blad deserializacji: " + ex.Message);
            }

            return objectOut;
        }
    }
}
