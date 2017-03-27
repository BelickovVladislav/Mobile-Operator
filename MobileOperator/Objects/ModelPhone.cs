namespace MobileOperator.Objects
{
    class ModelPhone
    {
        private static string tableName = "model_phone";


        public int id { get; set; }
        public string name { get; set; }
        public Producer producer { get; set; }
    }
}
