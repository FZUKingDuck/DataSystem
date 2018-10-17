using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSystem.Page {

    /// <summary>
    /// 学生成绩管理界面
    /// </summary>
    public partial class ScoreSet : UserControl {
        public ScoreSet() {
            InitializeComponent();
        }
        private string message;

        #region Seter/Geter
        public string Message {
            get => message;
            set => message = value;
        }
        #endregion


        /// <summary>
        /// 录入成绩
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) {
            #region 弹出输入窗口
            inputbody2 ipt2 = new inputbody2();
            ipt2.ShowDialog();
            #endregion
            #region 处理数据
            var std = DataEntity.GetByID(ipt2.Userid);
            if (std==null||string.IsNullOrEmpty(std.Userid) ){
                message = "无此学生";
            }
            else {
                std.Chinese = ipt2.Chinese;
                std.Math = ipt2.Math;
                std.English = ipt2.English;
                var ans = std.save();
                if (ans) {
                    message = "录入成功";
                }
                else {

                    message = "录入失败";
                }
            }
            #endregion
            textBox1.Text = message; 
        }

        /// <summary>
        /// 删除学生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e) {
            #region 弹出输入窗口
            openbody opd = new openbody();
            opd.ShowDialog();
            #endregion
            #region 数据处理
            var std = DataEntity.GetByID(openbody.Userid);
            if (std == null) {
                message = "无此学生";
            }
            else {
                std.Chinese = 0;
                std.English = 0;
                std.Math = 0;
                var ans = std.save();
                if (ans) {
                    message = "删除成功";

                }
                else {
                    message = "删除失败";

                }
            }
            #endregion
            textBox1.Text = message;
        }
    }
}
