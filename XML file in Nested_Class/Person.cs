namespace XML_file_in_Nested_Class
{
    public  class Person
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string?  LastName { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime CreateDate { get; set; }
        public Adress? HomeAdress { get; set; }
    }
}
