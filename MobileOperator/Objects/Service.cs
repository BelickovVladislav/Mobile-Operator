using System.Collections.Generic;

namespace MobileOperator.Objects
{
    public class Service
    {
        private static string tableName = "service";


        public static List<Service> getList()
        {
            List<Service> list = new List<Service>();
            MySQL mySQL = MySQL.getInstance();
            mySQL.TableName = tableName;
            string[][] result = mySQL.select();
            foreach (string[] res in result)
            {
                list.Add(new Service(int.Parse(res[0])));
            }
            return list;
        }
        public static void Add(string name, string description, double price)
        {
            MySQL mySQL = MySQL.getInstance();
            mySQL.TableName = tableName;
            mySQL.insert("name, description, price", string.Format("'{0}', '{1}', '{2}'", name, description, price));


        }
        public static void Delete(int id)
        {
            MySQL mySQL = MySQL.getInstance();
            mySQL.TableName = tableName;
            mySQL.delete("id = " + id);
        }
        private MySQL mySQL;
        public Service(int id)
        {
            mySQL = MySQL.getInstance();
            mySQL.TableName = tableName;
            string[][] result = mySQL.select("id = " + id);
            this.id = id;
            name = result[0][1];
            description = result[0][2];
            price = double.Parse(result[0][3]);


        }
        private string name, description;
        private double price;
        public int id { get; private set; }
        public string Name
        {
            get { return name; }
            set
            {
                if (name == value)
                    return;
                name = value;
                mySQL.TableName = tableName;
                mySQL.update("name = " + name, "id = " + id);
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                if (description == value)
                    return;
                description = value;
                mySQL.TableName = tableName;
                mySQL.update("description = '" + description + "'", "id = " + id);
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (price == value)
                    return;
                price = value;
                mySQL.TableName = tableName;
                mySQL.update("price = '" + price + "'", "id = " + id);
            }
        }
    }

}
