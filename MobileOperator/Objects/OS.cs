﻿

using System.Collections.Generic;

namespace MobileOperator.Objects
{
    class OS
    {
        private static string tableName = "os";
        public static List<OS> getList()
        {
            List<OS> list = new List<OS>();
            MySQL mySQL = MySQL.getMySQL();
            mySQL.TableName = tableName;
            string[][] result =  mySQL.select();
            foreach (string[] res in result)
            {
                list.Add(new OS(int.Parse(res[0])));
            }
            return list;
        }
        public static void Add(string name)
        {
            MySQL mySQL = MySQL.getMySQL();
            mySQL.insert("name",name);
        }
        public OS(int id)
        {
            MySQL mySQL = MySQL.getMySQL();
            mySQL.TableName = tableName;
            this.id = id;
            this.name = mySQL.select("id = " + id)[0][1];
        }
        private MySQL mySQL;
        public int id { get; private set; }
        private string name;
        public string Name
        { get { return name; }
          set
            {
                if (value == name)
                    return;
                name = value;
                mySQL.TableName = tableName;
                mySQL.update("name = "+name, "id = "+id);
            }
        }

    }
}