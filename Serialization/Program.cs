using System;
using System.Xml.Serialization;

namespace Serialization;

public class Serialization
{
    static void Main(string[] args)
    {
        var patient = new Patient()
        {
            Id = 1,
            FirstName = "Tim",
            LastName = "Corey",
            Birthday = new DateTime(1960, 12, 12),
            CreateDate = DateTime.Now,
            HomeAdress = new Adress()
            {
                Street = "Street",
                City = "Samarkand",
                Country = "Uzbekistan",
                Zip = 36541

            },

            Measurements = new List<Measurement>()
            {
             new Measurement() {TikeTeken =new DateTime(2023,11,19,17,51,0),temp=36.8M},
             new Measurement() { TikeTeken =new DateTime(2023,3,8,22,8,52), temp =20.26M},
             new Measurement() {TikeTeken=new DateTime(2022,12,15,15,22,0),temp =12.22M}
            }
        };

        var serializer= new XmlSerializer(typeof(Patient));
        string filepath = "D://Documents/newperson.xml";

        using (var writer=new StreamWriter(filepath))
        {
            serializer.Serialize(writer, patient);
        }
    }
}