using System.Collections.Generic;

namespace MobileOperator.Objects
{
    class Producer
    {
        private static string tableName = "producer";
        public static List<Producer> getList()
        {
            List<Producer> list = new List<Producer>();
            MySQL mySQL = MySQL.getMySQL();
            mySQL.TableName = tableName;
            string[][] result = mySQL.select();
            foreach (string[] res in result)
            {
                list.Add(new Producer(int.Parse(res[0])));
            }
            return list;
        }
        public static void Add(string name)
        {
            MySQL mySQL = MySQL.getMySQL();
            mySQL.TableName = tableName;
            mySQL.insert("name", name);
        }
        public static void Delete(int id)
        {
            MySQL mySQL = MySQL.getMySQL();
            mySQL.TableName = tableName;
            mySQL.delete("id = " + id);
        }
        private MySQL mySQL;
        public Producer(int id)
        {
            mySQL = MySQL.getMySQL();
            mySQL.TableName = tableName;
            this.id = id;
            this.name = mySQL.select("id = " + id)[0][1];
        }
        public int id {get; private set; }
        public string name; 
        public string Name {
            get { return name; }
            set
            {
                if (value == name)
                    return;
                name = value;
                mySQL.TableName = tableName;
                mySQL.update("name = " + name, "id = " + id);
            }
        }
    }
}
