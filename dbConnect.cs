//using MySql.Data.MySqlClient;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace gamePDD
//{
//    class dbConnect
//    {
//        private MySqlConnection connection;
//        private string server, database, uid, password;

//        public DBconnect()
//        {
//            Initialize();
//        }

//        private void Initialize()
//        {
//            ...
//        }
//        Открываем соединение
//        private bool OpenConnection()
//        {
//            ...
//        }
//        Закрываем соединение
//        private bool CloseConnection()
//        {
//            ...
//        }
//        public DataTable Select()
//        {
//            var dt = new DataTable();
//            if (this.OpenConnection() == true)
//            {
//                MySqlDataAdapter da = new MySqlDataAdapter();
//                da.SelectCommand.Connection = this.connection;
//                da.SelectCommand.CommandText = " SELECT * FROM personal";
//                da.Fill(dt);
//                this.CloseConnection();
//            }
//            return dt;
//        }
//    }
//}


