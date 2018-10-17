using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSystem {

    class UserEntity {

        private static string tablename = "userinfo";
        private string userid;
        private string userpwd;
        private int job;
        private string remark;
        private MySqlConnection con;

        #region 判断数据是否为空
        public bool isEmpty() {
            if (string.IsNullOrEmpty(userid) && string.IsNullOrEmpty(userpwd) && job < 2 && job > 0)
                return true;
            else
                return false;
        }
        #endregion

        #region 操作数据库
        /// <summary>
        /// 静态方法，根据id查询表，返回相关的entity类
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        static public UserEntity GetByID(string userid) {
            SqlEntity sqlEntity = new SqlEntity();
            if (sqlEntity.Cnt == null) {
                return null;
            }
            else {
                string sql = "select * from " + tablename + " where userid='" + userid + "';";
                try {
                    MySqlCommand cmd = new MySqlCommand(sql, sqlEntity.Cnt);
                    var reader = cmd.ExecuteReader();
                    if (reader == null) {
                        sqlEntity.close();
                        return null;
                    }
                    UserEntity userentity = new UserEntity();
                    while (reader.Read()) {
                        userentity.userid = reader.GetString("userid");
                        userentity.userpwd = reader.GetString("userpwd");
                        userentity.job = int.Parse(reader.GetString("job"));
                        if (!reader.IsDBNull(3)) {
                            userentity.remark = reader.GetString("remark");
                        }
                    }
                    sqlEntity.close();
                    return userentity;
                }
                catch {
                    sqlEntity.close();
                    return null;
                }
            }
        }

        static public List<UserEntity> Get() {
            SqlEntity sqlEntity = new SqlEntity();
            if (sqlEntity.Cnt == null) {
                return null;
            }
            else {
                string sql = "select * from " + tablename +";";
                try {
                    MySqlCommand cmd = new MySqlCommand(sql, sqlEntity.Cnt);
                    var reader = cmd.ExecuteReader();
                    if (reader == null) {
                        sqlEntity.close();
                        return null;
                    }
                    List<UserEntity> userList = new List<UserEntity>();
                    while (reader.Read()) {
                        UserEntity userentity = new UserEntity();
                        userentity.userid = reader.GetString("userid");
                        userentity.userpwd = reader.GetString("userpwd");
                        userentity.job = int.Parse(reader.GetString("job"));
                        if (!reader.IsDBNull(3)) {
                            userentity.remark = reader.GetString("remark");
                        }
                        else {
                            userentity.remark = "";
                        }

                        userList.Add(userentity);
                    }
                    sqlEntity.close();
                    return userList;
                }
                catch {
                    sqlEntity.close();
                    return null;
                }
            }
        }


        /// <summary>
        /// 数据库更新
        /// </summary>
        /// <returns>成功为true</returns>
        public bool save() {
            MySqlCommand cmd;
            if (isEmpty()) {
                return false;
            }
            if (con == null) {
                con = new SqlEntity().Cnt;
            }
            string sql = "update " + tablename + " set userid='" + userid + "',userpwd='" + userpwd + "',job='" + job + "',remark='" + remark + "' where userid='" + userid + "';";
            cmd = new MySqlCommand(sql, con);
            try {
                var ans = cmd.ExecuteNonQuery();
                if (ans == 1)
                    return true;
                else {
                    return false;
                }
            }
            catch {
                return false;
            }
        }

        /// <summary>
        /// 删除表中该数据
        /// </summary>
        /// <returns></returns>
        public bool delete() {
            MySqlCommand cmd;
            if (isEmpty()) {
                return false;
            }
            if (con == null) {
                con = new SqlEntity().Cnt;
            }

            //保证有数据删除
            if (DataSystem.UserEntity.GetByID(userid).Userid == null)
                return false;
            string sql = "delete from " + tablename + " where userid='" + userid + "';";
            cmd = new MySqlCommand(sql, con);
            try {
                var ans = cmd.ExecuteNonQuery();
                if (ans == 1)
                    return true;
                else {
                    return false;
                }
            }
            catch {
                return false;
            }
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <returns></returns>
        public bool insert() {
            MySqlCommand cmd;
            if (isEmpty()) {
                return false;
            }

            if (con == null) {
                con = new SqlEntity().Cnt;

            }

            //保证不会复写数据
            if (DataSystem.UserEntity.GetByID(userid).Userid != null)
                return false;
            string sql = "insert into " + tablename + " value('" + userid + "','" + userpwd + "','" + job + "','" + remark + "');";
            cmd = new MySqlCommand(sql, con);
            try {
                var ans = cmd.ExecuteNonQuery();
                if (ans == 1)
                    return true;
                else {
                    return false;
                }
            }
            catch {
                return false;
            }
        }


        #endregion

        #region Geter Seter
        public string Userid {
            get => userid;
            set => userid = value;
        }
        public string Userpwd {
            get => userpwd;
            set => userpwd = value;
        }
        public int Job {
            get => job;
            set => job = value;
        }
        public string Remark {
            get => remark;
            set => remark = value;
        }
        public MySqlConnection Con {
            get => con;
            set => con = value;
        }
        #endregion
    }

}
