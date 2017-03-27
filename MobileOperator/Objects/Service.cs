namespace MobileOperator.Objects
{
    class Service
    {
        private static string tableName = "service";


        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
    }
}
