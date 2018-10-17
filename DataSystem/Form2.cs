using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSystem {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        /// <summary>
        /// 数据库连接失败提是窗口,点击确定退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
