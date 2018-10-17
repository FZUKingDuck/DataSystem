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
    /// 弹出输入信息界面
    /// </summary>
    public partial class openbody : Form {
        public openbody() {
            InitializeComponent();
        }

        /// <summary>
        /// 保存输入的userid
        /// </summary>
        private static string userid;
        #region geter/seter
        public static string Userid {
            get => userid;
            set => userid = value;
        }
        #endregion


        /// <summary>
        /// 保存输入的账号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Click(object sender, EventArgs e) {
            userid = textBox1.Text;
            if (!string.IsNullOrEmpty(userid))
                this.Close();
        }
    }
}
