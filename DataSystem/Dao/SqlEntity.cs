using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace DataSystem {

    /// <summary>
    /// 数据库基本操作的类
    /// </summary>
    class SqlEntity {
        private MySqlConnection cnt;
        static public MySqlConnection connection;
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public SqlEntity() {
            LinkSql();
        }

        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <returns>成功连接返回true</returns>
        public bool LinkSql() {
            string connstr = "server=localhost;User Id=root;password=root;Database=Studentinfo;SslMode=none;";
            MySqlConnection mycon = new MySqlConnection(connstr);
            try {
                mycon.Open();
                connection = mycon;
                cnt = mycon;
                return true;
            }
            catch {
                return false;
            }
        }

        public bool close() {
            if (cnt == null)
                return false;
            try {
                cnt.Close();
                return true;
            }
            catch {
                return false;
            }
        }

       


        public MySqlConnection Cnt {
            get => cnt;
            set => cnt = value;
        }



    }
}
