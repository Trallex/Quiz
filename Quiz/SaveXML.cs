using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;using System.IO;
using System.Xml.Serialization;


namespace Quiz
{
    public class SaveXML
    {
        public static void SaveData(object obj, string name)
        {
            XmlSerializer sr = new XmlSerializer(obj.GetType());
            StreamWriter writer = new StreamWriter(name);
            sr.Serialize(writer, obj);
            writer.Close();
        }
    }
}
