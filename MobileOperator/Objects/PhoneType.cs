using System.Collections.Generic;

namespace MobileOperator.Objects
{
    public class PhoneType
    {
        private static string tableName = "phone_type";
        private string name;
        private MySQL mySQL;
        public static List<PhoneType> getList()
        {
            List<PhoneType> list = new List<PhoneType>();
            MySQL mySQL = MySQL.getInstance();
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
            MySQL mySQL = MySQL.getInstance();
            mySQL.TableName = tableName;
            mySQL.insert("name", "'" + name + "'");
        }
        public static void Delete(int id)
        {
            MySQL mySQL = MySQL.getInstance();
            mySQL.TableName = tableName;
            mySQL.delete("id = " + id);
        }

        public PhoneType(int id)
        {
            mySQL = MySQL.getInstance();
            mySQL.TableName = tableName;
            this.id = id;
            this.name = mySQL.select("id = " + id)[0][1];
        }
        public int id { get; private set; }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == name)
                    return;
                name = value;
                mySQL.TableName = tableName;
                mySQL.update("name = '" + name + "'", "id = " + id);
            }
        }
    }
}
