using System.Collections.Generic;
namespace MobileOperator.Objects
{
    class Tariff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public List<Service> services { get; set; }

    }
}
