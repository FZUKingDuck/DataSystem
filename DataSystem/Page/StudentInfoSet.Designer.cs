namespace DataSystem.Page {
    partial class StudentInfoSet {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.addstudent = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.showBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addstudent
            // 
            this.addstudent.Location = new System.Drawing.Point(38, 369);
            this.addstudent.Name = "addstudent";
            this.addstudent.Size = new System.Drawing.Size(134, 50);
            this.addstudent.TabIndex = 0;
            this.addstudent.Text = "新增学生";
            this.addstudent.UseVisualStyleBackColor = true;
            this.addstudent.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "删除学生";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(318, 369);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "查看学生";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // showBox
            // 
            this.showBox.Location = new System.Drawing.Point(51, 43);
            this.showBox.Multiline = true;
            this.showBox.Name = "showBox";
            this.showBox.Size = new System.Drawing.Size(535, 320);
            this.showBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "评价学生";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // StudentInfoSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addstudent);
            this.Name = "StudentInfoSet";
            this.Size = new System.Drawing.Size(640, 470);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addstudent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox showBox;
        private System.Windows.Forms.Button button1;
    }
}
