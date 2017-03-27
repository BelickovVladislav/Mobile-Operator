using System.Collections.Generic;

namespace MobileOperator.Objects
{
    class PhoneType
    {
        private static string tableName = "phone_type";

        public static List<PhoneType> getList()
        {
            List<PhoneType> list = new List<PhoneType>();
            MySQL mySQL = MySQL.getMySQL();
            mySQL.TableName = tableName;
            string[][] result = mySQL.select();
            foreach (string[] res in result)
            {
                list.Add(new PhoneType(int.Parse(res[0])));
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
        public PhoneType(int id)
        {
            mySQL = MySQL.getMySQL();
            mySQL.TableName = tableName;
            this.id = id;
            this.name = mySQL.select("id = " + id)[0][1];
        }
        public int id { get; private set; }
        public string name;
        public string Name
        {
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
