using System;
using System.Xml.Linq;

namespace CreateXML
{
     class XML
    {
        static void Main(string[] args)
        {
            XElement person = new XElement("Talabalar",
                new XElement("Talaba"),
                new XElement("Id", 1),
                new XElement("Name", "Ilhom"),
                new XElement("Familiya", "Toshqulov"));

            person.Save("D://Documents/personxml.xml");
        }
    }
}
