using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSystem.Page {

    /// <summary>
    /// 输入信息窗口
    /// </summary>
    public partial class inputbody : Form {
        public inputbody() {
            InitializeComponent();
        }

        private string userid;
        private string username;
        private int sex;
        private string userpwd;
        private int grade;

        public string Userid {
            get => userid;
            set => userid = value;
        }
        public string Username {
            get => username;
            set => username = value;
        }
        public int Sex {
            get => sex;
            set => sex = value;
        }
        public string Userpwd {
            get => userpwd;
            set => userpwd = value;
        }
        public int Grade {
            get => grade;
            set => grade = value;
        }

        private void label5_Click(object sender, EventArgs e) {

        }
        /// <summary>
        /// 将输入的信息保存，方便调用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) {
            userid = textBox1.Text;
            username = textBox2.Text;
            userpwd = textBox3.Text;
            //0为男
            sex = "男".Equals(textBox4.Text) ? 0 : 1;
            grade = int.Parse(textBox5.Text);
            //防止没输入数据就点击确定
            if (!string.IsNullOrEmpty(userid) && grade > 0) {
                this.Close();
            }
            
        }

    }
}
