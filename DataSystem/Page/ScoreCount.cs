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
    public partial class ScoreCount : UserControl {
        public ScoreCount() {
            InitializeComponent();
        }

        /// <summary>
        /// 计算平均分，并在textbox中显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) {
            double chinesecount = 0;
            double mathcount = 0;
            double enlishcount = 0;
            var stdlist = DataEntity.Get();
            foreach (var key in stdlist) {
                chinesecount += key.Chinese;
                mathcount += key.Math;
                enlishcount += key.English;
            }
            textBox1.Text = "语文平均分:" + chinesecount / stdlist.Count + "\r\n" + "数学平均分:" + mathcount / stdlist.Count + "\r\n" + "英语平均分:" + enlishcount
                    / stdlist.Count;
        }

        /// <summary>
        /// 计算最高分并在textbox中显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e) {
            double maxc=0;
            double maxm=0;
            double maxe=0;
            string cn="";
            string mn="";
            string en="";
            var stdlist = DataEntity.Get();
            if (stdlist == null)
                stdlist = new List<DataEntity>();
            foreach (var key in stdlist) {
                if (key.Chinese > maxc) {
                    maxc = key.Chinese;
                    cn = key.Userid;
                }
                if (key.Math > maxm) {
                    maxm = key.Math;
                    mn = key.Userid;
                }
                if(key.English > maxe) {
                    maxe = key.English;
                    en = key.Userid;
                }
            }
            textBox1.Text = "语文最高分:" + maxc + "    " + cn + "\r\n数学最高分:" + maxm + "    " + mn + "\r\n英语最高分:" + maxe + "    " + en;    

        }
    }
}
