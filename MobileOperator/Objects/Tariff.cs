using System.Collections.Generic;
namespace MobileOperator.Objects
{
    class Tariff
    {
        private static string tableName = "tariff";


        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public List<Service> services { get; set; }

    }
}
