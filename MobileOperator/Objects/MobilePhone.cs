namespace MobileOperator.Objects
{
    class MobilePhone
    {
        public int id { get; set; }
        public Producer producer { get; set; }
        public PhoneType phoneType { get; set; }
        public OS os { get; set; }
        public ModelPhone modelPhone { get; set; }
        public string photoUrl { get; set; }
        public double price { get; set; }
    }
}
