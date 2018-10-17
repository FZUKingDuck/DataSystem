using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSystem {
    class DataEntity {

        private string userid;
        private string username;
        private int sex;
        private int grade;
        private double chinese;
        private double math;
        private double english;
        private string remark;
        private MySqlConnection con;
        static private string tablename = "datainfo";


        #region 常用操作
        public bool isEmpty() {
            if (!string.IsNullOrEmpty(userid)&&!string.IsNullOrEmpty(username)&&sex >=0 && sex <= 1 && grade >= 1 && grade <= 6)
                return false;
            return true;
        }

        public string show() {
            return "姓名:" + username + "   性别:" + (sex == 1 ? "男" : "女") + "  年级:" + grade + "  语文:" + chinese + "    数学:" + math + "   英语:" + english;
        }

        #endregion

        #region 存储操作

        /// <summary>
        /// 静态方法，根据id获取对象
        /// </summary>
        /// <param name="userid"></param>
        /// <returns>查询所得的datainfo对象</returns>
        static public DataEntity GetByID(string userid) {
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
                    DataEntity dataEntity = new DataEntity();
                    while (reader.Read()) {
                        dataEntity.userid = reader.GetString("userid");
                        dataEntity.username = reader.GetString("username");
                        dataEntity.sex = reader.GetInt16("sex");
                        dataEntity.grade = reader.GetInt16("grade");
                        dataEntity.chinese = reader.GetDouble("chinese");
                        dataEntity.math = reader.GetDouble("math");
                        dataEntity.english = reader.GetDouble("english");
                        if (!reader.IsDBNull(6)) {
                            dataEntity.remark = reader.GetString("remark");
                        }
                        else {
                            dataEntity.remark = "";
                        }
                    }
                    sqlEntity.close();
                    return dataEntity;
                }
                catch {
                    sqlEntity.close();
                    return null;
                }

            }
        }

        /// <summary>
        /// 静态方法，获取表中所有数据
        /// </summary>
        /// <returns></returns>
        static public List<DataEntity> Get() {
            SqlEntity sqlEntity = new SqlEntity();
            if (sqlEntity.Cnt == null)
                return null;
            else {
                string sql = "select * from " + tablename + ";";
                try {
                    MySqlCommand cmd = new MySqlCommand(sql, sqlEntity.Cnt);
                    var reader = cmd.ExecuteReader();
                    if (reader == null) {
                        sqlEntity.close();
                        return null;
                    }
                    List<DataEntity> dataList = new List<DataEntity>();
                    while (reader.Read()) {
                        DataEntity dataEntity = new DataEntity();
                        dataEntity.userid = reader.GetString("userid");
                        dataEntity.username = reader.GetString("username");
                        dataEntity.sex = (int)reader.GetDouble("sex");
                        dataEntity.grade = (int)reader.GetDouble("grade");
                        dataEntity.chinese = reader.GetDouble("chinese");
                        dataEntity.math = reader.GetDouble("math");
                        dataEntity.english = reader.GetDouble("english");
                        if (!reader.IsDBNull(7)) {
                            dataEntity.remark = reader.GetString("remark");
                        }
                        else {
                            dataEntity.remark = "";
                        }
                        dataList.Add(dataEntity);
                    }
                    sqlEntity.close();
                    return dataList;
                }
                catch {
                    sqlEntity.close();
                    return null;
                }

            }
        }


        /// <summary>
        /// 插入数据
        /// </summary>
        /// <returns>是否操作成功</returns>
        public bool insert() {
            MySqlCommand cmd;
            if (isEmpty()) {
                return false;
            }

            if (con == null) {
                con = new SqlEntity().Cnt;
            }

            if (DataSystem.DataEntity.GetByID(userid).Userid != null)
                return false;
            string sql = "insert into " + tablename + " value('" + userid + "','" + username + "','" + sex + "','" + grade + "','" + chinese + "','" + math + "','" + english+"','" + remark + "');";
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
        /// 保存更新
        /// </summary>
        /// <returns></returns>
        public bool save() {
            MySqlCommand cmd;
            if (isEmpty()==true) {
                return false;
            }
            if (con == null) {
                con = new SqlEntity().Cnt;
            }
            string sql = "update " + tablename + " set userid='" + userid + "',username='" + username + "',sex='" + sex + "',grade='" + grade + "',chinese='" + chinese + "',math='" + math + "',english='" + english+ "',remark='" + remark + "' where userid='" + userid + "';";
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
        /// 删除数据
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
            if (DataSystem.DataEntity.GetByID(userid).Userid == null)
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



        #endregion


        #region Geter,Seter
        public string Username {
            get => username;
            set => username = value;
        }
        public int Sex {
            get => sex;
            set => sex = value;
        }
        public int Grade {
            get => grade;
            set => grade = value;
        }
        public double Chinese {
            get => chinese;
            set => chinese = value;
        }
        public double Math {
            get => math;
            set => math = value;
        }
        public double English {
            get => english;
            set => english = value;
        }
        public string Remark {
            get => remark;
            set => remark = value;
        }
        public MySqlConnection Con {
            get => con;
            set => con = value;
        }
        public string Userid {
            get => userid;
            set => userid = value;
        }

        #endregion
    }
}