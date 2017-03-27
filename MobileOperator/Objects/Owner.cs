using System.Collections.Generic;

namespace MobileOperator.Objects
{
    class Owner
    {
        private static string tableName = "owner";


        public int id { get; set; }
        public MobilePhone mobilePhone { get; set; } 
        public Tariff tariff { get; set; }
        public string surname { get; set; }
        public string middleName { get; set; }
        public string firstName { get; set; }
        public bool sex { get; set; }
        public string photoUrl { get; set; }
        public string passportNumber { get; set; }
        public string mobileNumber { get; set; }
        public List<Service> services { get; set; }
    }
}
