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
    public partial class Admin : Form {
        public Admin() {
            InitializeComponent();
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

        /// <summary>
        /// panel中加载学生信息管理窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void infoset_Click(object sender, EventArgs e) {
            StudentInfoSet studentinfoset = new StudentInfoSet();
            panel.Controls.Clear();
            panel.Controls.Add(studentinfoset);
            studentinfoset.Show();
        }

        /// <summary>
        /// panel中加载学生成绩管理窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scoreset_Click(object sender, EventArgs e) {
            ScoreSet scoreSet = new ScoreSet();
            panel.Controls.Clear();
            panel.Controls.Add(scoreSet);
            scoreSet.Show();
        }

        /// <summary>
        /// panel中加载成绩统计窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scorecount_Click(object sender, EventArgs e) {
            ScoreCount scoreCount = new ScoreCount();
            panel.Controls.Clear();
            panel.Controls.Add(scoreCount);
            scoreCount.Show();
        }
    }
}
