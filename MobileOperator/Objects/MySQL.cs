using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace MobileOperator.Objects
{
    public class MySQL
    {
        private static MySQL instance;
        public static MySQL getInstance()
        {
            instance = instance ?? new MySQL();
            return instance;
        }
        private string tableName;
        private MySqlConnection connection;


        public MySQL()
        {
            try
            {
                connection = new MySqlConnection("server= localhost;user= root; database= Mobile_Operator;password=;");
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Проблема подключение к Базе Данных, пожалуйста проверьте подключение!");
                throw;
            }
        }
        public string TableName
        {
            set
            {
                tableName = value;
            }
            get
            {
                return tableName;
            }
        }
        public string[][] select()
        {
            return select("1");
        }
        public string[][] select(string where)
        {
            string query = "SELECT * FROM `" + tableName + "` WHERE " + where;
            MySqlCommand comand = new MySqlCommand(query, connection);
            comand.ExecuteNonQuery();
            MySqlDataAdapter data = new MySqlDataAdapter(comand);
            DataTable dt = new DataTable();
            data.Fill(dt);
            var myData = dt.Select();
            string[][] result = new string[myData.Length][];
            for (int i = 0; i < myData.Length; i++)
                result[i] = new string[myData[i].ItemArray.Length];
            for (int i = 0; i < myData.Length; i++)
            {
                for (int j = 0; j < myData[i].ItemArray.Length; j++)
                {

                    result[i][j] = myData[i].ItemArray[j].ToString();
                }

            }
            return result;
        }
        public void insert(string keys, string values)
        {
            string query = "INSERT INTO `" + tableName + "`(" + keys + ") VALUES " + "(" + values + ")";
            MySqlCommand sqlCom = new MySqlCommand(query, connection);

            sqlCom.ExecuteNonQuery();
        }
        public void update(string keys, string where)
        {
            string query = "UPDATE `" + tableName + "` SET " + keys + " WHERE " + where;
            MySqlCommand sqlCom = new MySqlCommand(query, connection);
            sqlCom.ExecuteNonQuery();
        }

        public string[][] useQuery(string query)
        {
            MySqlCommand sqlCom = new MySqlCommand(query, connection);
            sqlCom.ExecuteNonQuery();
            return select();
        }
        public void delete(string where)
        {
            string query = "DELETE FROM `" + tableName + "` WHERE " + where;
            MySqlCommand sqlCom = new MySqlCommand(query, connection);
            sqlCom.ExecuteNonQuery();
        }
        public void close()
        {
            try
            {
                connection.Close();
            }
            catch
            {
            }
        }
    }
}

