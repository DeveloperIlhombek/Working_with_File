using System;
using System.Xml.Serialization;
namespace XMLserializing;

class XMLserializing
{
    static void Main(string[] args)
    {
        Patient patient = new Patient()
        {
            Id = 1,
            FirstName = "Ilhombek",
            LastName = "Toshqulov",
            Birthday = new DateTime(1999, 12, 15),
            CreateDate=DateTime .Now,
            RoomNo = 25
        };
        XmlSerializer serializer = new XmlSerializer(typeof(Patient));
        string path = "D://Documents/patient.xml";
        using (var writer = new StreamWriter(path))
        {
            serializer.Serialize(writer, patient);
        }
    }
}
