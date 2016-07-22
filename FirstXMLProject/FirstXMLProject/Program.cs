using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FirstXMLProject
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument myFirstXmlDoc = new XmlDocument();
            myFirstXmlDoc.Load("..\\..\\test.xml");
            XmlElement root = myFirstXmlDoc.DocumentElement;
            foreach (XmlNode element in root)
            {
                foreach (XmlNode childNodes in element)
                {
                    Console.WriteLine(childNodes.InnerText);
                }
            }
        }
    }
}
