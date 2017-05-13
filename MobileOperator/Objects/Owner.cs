using System.Collections.Generic;

namespace MobileOperator.Objects
{
    class Owner
    {
        private static string tableName = "owner";
        private MySQL mySQL;

        public Owner(int id)
        {
            mySQL = MySQL.getInstance();
            mySQL.TableName = tableName;
            string[] result = mySQL.select("id = " + id)[0];
            this.id = id;
            this.mobileNumber = new MobilePhone(int.Parse(result[1]));
            this.tariff = new Tariff(int.Parse(result[2]));
            this.firstName = result[3];
            this.middleName = result[4];
            this.surname = result[5];
            this.sex = bool.Parse(result[6]);
            this.photoUrl = result[7];
            this.passportNumber = result[8];
            this.mobileNumber = result[9];
            mySQL.TableName = "owner_include_service";
            string[][] res = mySQL.select("id_owner = "+id);
            foreach (var r in res) {
                services.Add(new Service(int.Parse(r[1])));
            }
        }

        public static List<Owner> getList()
        {
            List<Owner> list = new List<Owner>();
            MySQL mySQL = MySQL.getInstance();
            mySQL.TableName = tableName;
            string[][] result = mySQL.select();
            foreach (string[] res in result)
            {
                list.Add(new Owner(int.Parse(res[0])));
            }
            return list;
        }

        public int id { get; private set; }
        public MobilePhone mobilePhone {
            get {
                return mobilePhone;
            } set
            {
                if (mobilePhone.id == value.id)
                    return;
                mySQL.TableName = tableName;
                mySQL.update("id_mobile_phone = " + value.id, "id = " + id);
                mobilePhone = value;
            } } 
        public Tariff tariff { get {
                return tariff;
            } set {
                if (tariff.id == value.id)
                    return;
                mySQL.TableName = tableName;
                mySQL.update("id_tariff = " + value.id, "id = " + id);
                tariff = value;
            } }

        public string surname { get { return surname; } set {
                if (surname == value)
                    return;
                mySQL.TableName = tableName;
                mySQL.update("surname = " + value, "id = " + id);
                surname = value;
            } }

        public string middleName { get { return middleName; } set {
                if (middleName == value)
                    return;
                mySQL.TableName = tableName;
                mySQL.update("middle_name = " + value, "id = " + id);
                middleName = value;
            } }

        public string firstName { get { return firstName; } set {
                if (firstName == value)
                    return;
                mySQL.TableName = tableName;
                mySQL.update("name = " + value, "id = " + id);
                firstName = value;
            } }

        public bool sex { get { return sex; } set {
                if (sex == value)
                    return;
                mySQL.TableName = tableName;
                mySQL.update("sex = " + value.ToString(), "id = " + id);//todo МОжеть БЫть ОШибка
                sex = value;
            } }

        public string photoUrl { get { return photoUrl; } set {
                if (photoUrl == value)
                    return;
                mySQL.TableName = tableName;
                mySQL.update("photo_url = " + value, "id = " + id);
                photoUrl = value;
            } }

        public string passportNumber { get { return passportNumber; } set {
                if (passportNumber == value)
                    return;
                mySQL.TableName = tableName;
                mySQL.update("passport_number = " + value, "id = " + id);
                passportNumber = value;
            } }

        public string mobileNumber { get { return mobileNumber; } set {
                if (mobileNumber == value)
                    return;
                mySQL.TableName = tableName;
                mySQL.update("number_phone = " + value, "id = " + id);
                mobileNumber = value;
            } }
        public List<Service> services
        {
            get
            {
            
                return services;
            }
            set
            {
                mySQL.TableName = "owner_include_service";
                mySQL.delete("id_owner = " + id);
                foreach (var val in value)
                    mySQL.insert("id_owner, id_service", string.Format("{0},{1}", id, val.id));
                services = value;
            }
        }
    }
}
