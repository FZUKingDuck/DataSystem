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

    public partial class StudentInfoSet : UserControl {
        static private string remark;
        #region Geter/Seter
        public static string Remark {
            get => remark;
            set => remark = value;
        }
        #endregion


        public StudentInfoSet() {
            InitializeComponent();
           
        }


        /// <summary>
        /// 新增学生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) {
            inputbody ipd = new inputbody();
            ipd.ShowDialog();
            UserEntity user = new UserEntity();
            user.Userid = ipd.Userid;
            user.Userpwd = ipd.Userpwd;
            user.Job = 0;
            if (!user.isEmpty()) {
                var ans = user.insert();
                if (ans) {
                    var datainfo = new DataEntity();
                    datainfo.Userid = ipd.Userid;
                    datainfo.Username = ipd.Username;
                    datainfo.Sex = ipd.Sex;
                    datainfo.Grade = ipd.Grade;
                    datainfo.Chinese = 0;
                    datainfo.Math = 0;
                    datainfo.English = 0;
                    datainfo.insert();
                }
            }
        }

        /// <summary>
        /// 删除学生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e) {
            openbody opd = new openbody();
            opd.ShowDialog();
            string id = openbody.Userid;
            
            var std = DataSystem.UserEntity.GetByID(id);
            if (std != null) {
                var ans = std.delete();
                var std1 = DataSystem.DataEntity.GetByID(id);
                if (ans)
                    std1.delete();
            }
        }

        /// <summary>
        /// 显示所有学生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e) {
            var stdlist = DataEntity.Get();
            if (stdlist == null)
                stdlist = new List<DataEntity>();
            foreach (var key in stdlist) {
                showBox.Text += key.show() + "\r\n评语:" + key.Remark+ "\r\n";
            }
        }

        /// <summary>
        /// 修改教师评语
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e) {
            openbody opd = new openbody();
            opd.ShowDialog();
            var std = DataEntity.GetByID(openbody.Userid);
            if (std == null || string.IsNullOrEmpty(std.Userid)) {
                showBox.Text = "无此学生";
            }
            else {
                remarkbody rkb = new remarkbody();
                rkb.ShowDialog();
               
                bool ans = false;
                std.Remark = rkb.Remark;
                ans = std.save();
                if (ans) {
                    showBox.Text = "评价成功";
                }
                else {
                    showBox.Text = "评价失败";
                }

            }
        }

        
    }
}
