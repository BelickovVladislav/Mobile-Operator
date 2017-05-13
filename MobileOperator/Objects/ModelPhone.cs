using System.Collections.Generic;

namespace MobileOperator.Objects
{
    class ModelPhone
    {
        private static string tableName = "model_phone";

        public static List<ModelPhone> getList()
        {
            List<ModelPhone> list = new List<ModelPhone>();
            MySQL mySQL = MySQL.getInstance();
            mySQL.TableName = tableName;
            string[][] result = mySQL.select();
            foreach (string[] res in result)
            {
                list.Add(new ModelPhone(int.Parse(res[0])));
            }
            return list;
        }
        public static void Add(string name, Producer producer)
        {
            MySQL mySQL = MySQL.getInstance();
            mySQL.TableName = tableName;
            mySQL.insert("`name`, `id_producer`", string.Format("`{0}`, `{1}`", name, producer.id));
        }
        public static void Delete(int id)
        {
            MySQL mySQL = MySQL.getInstance();
            mySQL.TableName = tableName;
            mySQL.delete("`id` = " + id);
        }
        private MySQL mySQL;
        public ModelPhone(int id)
        {
            mySQL = MySQL.getInstance();
            mySQL.TableName = tableName;
            this.id = id;
            string[][] result = mySQL.select("`id` = " + id);
            this.name = result[0][2];
            this._producer = new Producer(int.Parse(result[0][1]));
        }
        public int id { get; private set; }
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == name)
                    return;
                name = value;
                mySQL.TableName = tableName;
                mySQL.update(string.Format("`name` = `{0}`",  name), "`id` = " + id);
            }
        }
        private Producer _producer;
        public Producer producer
        {
            get { return _producer; }
            set
            {
                if (value.id == _producer.id)
                    return;
                _producer = value;
                mySQL.update("`id_producer` = " + _producer.id, "`id` = " + id );
            }
        }
    }
}

