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
    public partial class teacherremark : UserControl {
        public teacherremark() {
            InitializeComponent();
            showRemark();
        }

        /// <summary>
        /// 显示教师评语
        /// </summary>
        private void showRemark() {
            textBox1.Text = DataEntity.GetByID(Customer.Userid).Remark;
        }
    }
}
