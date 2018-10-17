namespace DataSystem.Page {
    partial class Student {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.searchScore = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // searchScore
            // 
            this.searchScore.Location = new System.Drawing.Point(48, 86);
            this.searchScore.Name = "searchScore";
            this.searchScore.Size = new System.Drawing.Size(145, 54);
            this.searchScore.TabIndex = 0;
            this.searchScore.Text = "我的成绩";
            this.searchScore.UseVisualStyleBackColor = true;
            this.searchScore.Click += new System.EventHandler(this.searchScore_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "老师评语";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(48, 333);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(145, 56);
            this.quit.TabIndex = 2;
            this.quit.Text = "退出";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // panel
            // 
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.Location = new System.Drawing.Point(215, 40);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(640, 470);
            this.panel.TabIndex = 3;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchScore);
            this.Name = "Student";
            this.Text = "Student";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchScore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Panel panel;
    }
}