using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataSystem.Page;

namespace DataSystem {
    public partial class Form1 : Form {


        public Form1() {
            InitializeComponent();
            
        }

        /// <summary>
        /// 登陆按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) {
            string username = Username.Text.ToString();
            string userpwd = Userpwd.Text.ToString();
            SqlEntity entity = new SqlEntity();
            if (entity.Cnt == null) {
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            //查询数据库是否有该用户密码信息
            var user = DataSystem.UserEntity.GetByID(username);
            if (user.Userid == null) {
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
            else if (!userpwd.Equals(user.Userpwd)) {
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
            else {
                DataSystem.Customer.Userid = user.Userid;
                DataSystem.Customer.Job = user.Job;
                if (Customer.isAdmin())
                    changeFormToAdmin();
                else {
                    changeFormToStd();
                }
            }

        }
        /// <summary>
        /// 切换界面至管理员界面
        /// </summary>
        public void changeFormToAdmin() {
            Form adminform = new Admin();
            Loginpanel.Controls.Clear();
            adminform.TopLevel = false;
            adminform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            adminform.Dock = System.Windows.Forms.DockStyle.Fill;
            Loginpanel.Controls.Add(adminform);
            adminform.Show();
        }

        /// <summary>
        /// 切换至学生界面
        /// </summary>
        public void changeFormToStd() {
            Form student = new Student();
            Loginpanel.Controls.Clear();
            student.TopLevel = false;
            student.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            student.Dock = System.Windows.Forms.DockStyle.Fill;
            Loginpanel.Controls.Add(student);
            student.Show();
        }


    }
}
