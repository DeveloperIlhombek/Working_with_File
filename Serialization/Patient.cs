using System.Diagnostics.Metrics;

namespace Serialization
{
    public  class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime CreateDate { get; set; }
        public Adress HomeAdress { get; set; }
        public List<Measurement> Measurements { get; set; }
    }
}
