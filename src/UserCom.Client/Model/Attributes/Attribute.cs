namespace UserCom.Model.Attributes
{
    public class Attribute
    {
        public int Id { get; set; }

        public ContentType ContentType { get; set; }

        public string NameStd { get; set; }

        public ValueType ValueType { get; set; }

        public string Name { get; set; }
    }
}