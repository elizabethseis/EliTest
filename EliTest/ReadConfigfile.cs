using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EliTest
{
    class ReadConfigfile
    {
        public static string url;

        public static void ReadFile()
        {

            XmlTextReader reader = new XmlTextReader("C:\\Users\\elizabeth.perez\\source\\repos\\EliTest\\EliTest\\URLFile.xml");
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {

                    switch (reader.Name.ToString())
                    {
                        case "baseurl":
                            url = reader.ReadString();

                            break;
                    }
                }

            }
        }
    }
}
