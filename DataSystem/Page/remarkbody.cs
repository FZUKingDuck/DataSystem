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
    public partial class remarkbody : Form {
        /// <summary>
        /// 保存教师评价
        /// </summary>
        private string remark;
        

        public remarkbody() {
            InitializeComponent();
        }

        #region geter/seter
        public string Remark {
            get => remark;
            set => remark = value;
        }
        #endregion

        /// <summary>
        /// 保存用户输入的账号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) {
            remark = textBox1.Text;
            if (!string.IsNullOrEmpty(remark)) {
                this.Close();
            }
        }
    }
}
