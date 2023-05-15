using System;
using System.Xml.Serialization;

namespace XML_file_in_Nested_Class;

public class XmlSerialization
{
   static void Main(string[] args)
    {
        var person = new Person()
        {
            Id = 1,
            FirstName = "John",
            LastName = "Karter",
            Birthday = new DateTime(1980, 10, 19),
            CreateDate = DateTime.Now,
            HomeAdress = new Adress()
            {
                street = "Volk",
                city = "Nyu-York",
                country = "America",
                zipcode = 15
            }
        };

        var serialize=new XmlSerializer(typeof(Person));
        string filepath = "D://Documents/person.xml";
        using (var writer = new StreamWriter(filepath))
        {
            serialize .Serialize(writer,person );
        }
        
    }
}

