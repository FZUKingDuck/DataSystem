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
    public partial class Student : Form {
        public Student() {
            InitializeComponent();
        }

        /// <summary>
        /// panel中加载我的成绩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchScore_Click(object sender, EventArgs e) {
            panel.Controls.Clear();
            MyScore myScore = new MyScore();
            myScore.Dock = DockStyle.Fill;
            panel.Controls.Add(myScore);
            panel.Show();
        }

        /// <summary>
        /// 在panel中加载教师评语
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) {
            panel.Controls.Clear();
            teacherremark t = new teacherremark();
            t.Dock = DockStyle.Fill;
            panel.Controls.Add(t);
            panel.Show();
        }

        /// <summary>
        /// 退出按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quit_Click(object sender, EventArgs e) {
            try {
                SqlEntity.connection.Close();
            }
            catch {

            }
            Application.Exit();
        }
    }
}
