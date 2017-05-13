using System.Collections.Generic;

namespace MobileOperator.Objects
{
    class Owner
    {
        private static string tableName = "owner";
        private MySQL mySQL;

        private MobilePhone _mobilePhone;
        private Tariff _tariff;
        private string _surname;
        private string _middleName;
        private string _firstName;
        private bool _sex;
        private string _photoUrl;
        private string _passportNumber;
        private string _mobileNumber;
        private List<Service> _services;


        public Owner(int id)
        {
            mySQL = MySQL.getInstance();
            mySQL.TableName = tableName;
            string[] result = mySQL.select("id = " + id)[0];
            this.id = id;
            _mobilePhone = new MobilePhone(int.Parse(result[1]));
            _tariff = new Tariff(int.Parse(result[2]));
            _firstName = result[3];
            _middleName = result[4];
            _surname = result[5];
            _sex = bool.Parse(result[6]);
            _photoUrl = result[7];
            _passportNumber = result[8];
            _mobileNumber = result[9];
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
        public static void Add(
            MobilePhone mobilePhone, 
            Tariff tariff, 
            string surname, 
            string middleName, 
            string firstName,
            bool sex,
            string photoUrl,
            string passportNubmer,
            string mobileNumber
            )
        {
            MySQL mySQL = MySQL.getInstance();
            mySQL.TableName = tableName;
            mySQL.insert(
            "`id_mobile_phone`, `id_tariff`, `name`, `middle_name`, `surname`, `sex`, `photo_url`, `passport_number`, `number_phone`",
            string.Format("`{0}`, `{1}, `{2}`, `{3}`, `{4}`, `{5}`, `{6}`, `{7}`, `{8}`", 
            mobilePhone.id, tariff.id, firstName, middleName,surname, sex, photoUrl, passportNubmer,mobileNumber));
        }
        public static void Delete(int id)
        {
            MySQL mySQL = MySQL.getInstance();
            mySQL.TableName = tableName;
            mySQL.delete("`id` = " + id);
        }
        public int id { get; private set; }
        public MobilePhone mobilePhone {
            get {
                return _mobilePhone;
            } set
            {
                if (mobilePhone.id == value.id)
                    return;
                mySQL.TableName = tableName;
                mySQL.update("id_mobile_phone = " + value.id, "id = " + id);
                _mobilePhone = value;
            } } 
        public Tariff tariff { get {
                return _tariff;
            } set {
                if (tariff.id == value.id)
                    return;
                mySQL.TableName = tableName;
                mySQL.update("id_tariff = " + value.id, "id = " + id);
                _tariff = value;
            } }

        public string surname { get { return _surname; } set {
                if (surname == value)
                    return;
                mySQL.TableName = tableName;
                mySQL.update("surname = " + value, "id = " + id);
                _surname = value;
            } }

        public string middleName { get { return _middleName; } set {
                if (middleName == value)
                    return;
                mySQL.TableName = tableName;
                mySQL.update("middle_name = " + value, "id = " + id);
                _middleName = value;
            } }

        public string firstName { get { return _firstName; } set {
                if (firstName == value)
                    return;
                mySQL.TableName = tableName;
                mySQL.update("name = " + value, "id = " + id);
                _firstName = value;
            } }

        public bool sex { get { return sex; } set {
                if (sex == value)
                    return;
                mySQL.TableName = tableName;
                mySQL.update("sex = " + value.ToString(), "id = " + id);//todo МОжеть БЫть ОШибка
                _sex = value;
            } }

        public string photoUrl { get { return _photoUrl; } set {
                if (photoUrl == value)
                    return;
                mySQL.TableName = tableName;
                mySQL.update("photo_url = " + value, "id = " + id);
                _photoUrl = value;
            } }

        public string passportNumber { get
            { return _passportNumber; }
             set {
                if (passportNumber == value)
                    return;
                mySQL.TableName = tableName;
                mySQL.update("passport_number = " + value, "id = " + id);
                _passportNumber = value;
            } }

        public string mobileNumber { get { return _mobileNumber; } set {
                if (mobileNumber == value)
                    return;
                mySQL.TableName = tableName;
                mySQL.update("number_phone = " + value, "id = " + id);
                _mobileNumber = value;
            } }
        public List<Service> services
        {
            get
            {
            
                return _services;
            }
            set
            {
                mySQL.TableName = "owner_include_service";
                mySQL.delete("id_owner = " + id);
                foreach (var val in value)
                    mySQL.insert("id_owner, id_service", string.Format("{0},{1}", id, val.id));
                _services = value;
            }
        }
    }
}
