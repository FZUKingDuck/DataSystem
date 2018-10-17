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
    public partial class inputbody2 : Form {
        public inputbody2() {
            InitializeComponent();
        }

        private string userid;
        private double chinese;
        private double math;
        private double english;

        #region Geter/Seter
        public string Userid {
            get => userid;
            set => userid = value;
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

        #endregion

        /// <summary>
        /// 保存输入信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) {
            userid = textBox1.Text;
            chinese = double.Parse(textBox3.Text);
            math = double.Parse(textBox2.Text);
            english = double.Parse(textBox4.Text);
            if (!string.IsNullOrEmpty(userid))
                this.Close();
        }
    }
}
