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
    public partial class MyScore : UserControl {
        public MyScore() {
            InitializeComponent();
            showScore();
        }

        /// <summary>
        /// 显示我的成绩,登陆的信息从customer类中获取
        /// </summary>
        private void showScore() {
            SqlEntity sqlEntity = new SqlEntity();
            if (sqlEntity.Cnt == null) {
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            var myscore = new DataEntity();
            myscore.Con = sqlEntity.Cnt;
            myscore = DataEntity.GetByID(Customer.Userid);
            textBox.Text = myscore.show();
                
        }
    }
}
