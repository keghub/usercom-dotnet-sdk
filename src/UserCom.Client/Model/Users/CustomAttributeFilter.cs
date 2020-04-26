namespace UserCom.Model.Users
{
    public class CustomAttributeFilter
    {
        public string Name { get; set; }

        public CustomAttributeLookup Lookup { get; set; }

        public object Value { get; set; }
    }
}