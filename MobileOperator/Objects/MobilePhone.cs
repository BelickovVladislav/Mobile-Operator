﻿using System.Collections.Generic;

namespace MobileOperator.Objects
{
    public class MobilePhone
    {
        private static string tableName = "mobile_phone";
        private MySQL mySQL;

        private Producer _producer;
        private PhoneType _phoneType;
        OS _os;
        ModelPhone _modelPhone;
        string _photoUrl;
        double _price;

        public static List<MobilePhone> getList()
        {
            List<MobilePhone> list = new List<MobilePhone>();
            MySQL mySQL = MySQL.getInstance();
            mySQL.TableName = tableName;
            string[][] result = mySQL.select();
            foreach (string[] res in result)
            {
                list.Add(new MobilePhone(int.Parse(res[0])));
            }
            return list;
        }
        public static void Add(
            Producer producer,
            PhoneType phoneType,
            OS os,
            ModelPhone modelPhone,
            string photoUrl,
            double price)
        {
            MySQL mySQL = MySQL.getInstance();
            mySQL.TableName = tableName;
            mySQL.insert("`id_producer`, `id_phone_type`, `id_os`, `id_model_phone`, `photo_url`, `price`",
                string.Format("'{0}', '{1}', '{2}', '{3}', '{4}', '{5}'",
                producer.id, phoneType.id, os.id,modelPhone.Id, photoUrl, price));
        }
        public static void Delete(int id)
        {
            MySQL mySQL = MySQL.getInstance();
            mySQL.TableName = tableName;
            mySQL.delete("id = " + id);
        }
        public MobilePhone() { }
        public MobilePhone(int id)
        {
            mySQL = MySQL.getInstance();
            mySQL.TableName = tableName;
            this.id = id;
            string[] result = mySQL.select("id = " + id)[0];
            _producer = new Producer(int.Parse(result[1]));
            _phoneType = new PhoneType(int.Parse(result[2]));
            _os = new OS(int.Parse(result[3]));
            _modelPhone = new ModelPhone(int.Parse(result[4]));
            _photoUrl = result[5];
            _price = double.Parse(result[6]);

        }

        public int id { get; private set; }
        public Producer producer
        {
            get { return _producer; }
            set
            {
                if (value.id == _producer.id)
                    return;
                _producer = value;
                mySQL.update("`id_producer` = " + _producer.id, "`id` = " + "'" + id + "'");
            }
        }
        public PhoneType phoneType
        {
            get
            {
                return _phoneType;
            }
            set
            {
                if (_phoneType.id == value.id)
                    return;
                _phoneType = value;
                mySQL.update("`id_phone_Type` = " + _phoneType.id, "`id` = " + "'" + id + "'");
            }
        }
        public OS os
        {
            get { return _os; }
            set
            {
                if (_os.id == value.id)
                    return;
                _os = value;
                mySQL.update("`id_os` = " + _os.id, "`id` = " + "'" + id + "'");
            }
        }
        public ModelPhone modelPhone
        {
            get { return _modelPhone; }
            set
            {
                if (_modelPhone.Id == value.Id)
                    return;
                _modelPhone = value;
                mySQL.update("`id_model_Phone` = " + _modelPhone.Id, "`id` = " + "'" + id + "'");
            }
        }
        public string photoUrl
        {
            get { return _photoUrl; }
            set
            {
                if (_photoUrl == value)
                    return;
                _photoUrl = value;
                mySQL.update("`photo_url` = '" + _photoUrl + "'", "`id` = " + "'" + id + "'");
            }
        }
        public double price
        {
            get { return _price; }
            set
            {
                if (_price == value)
                    return;
                _price = value;
                mySQL.update("`price` = '" + _price + "'", "`id` = " + "'" + id + "'");
            }
        }
    }
}
