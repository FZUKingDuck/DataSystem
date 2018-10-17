namespace DataSystem.Page {
    partial class Admin {
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
            this.infoset = new System.Windows.Forms.Button();
            this.scoreset = new System.Windows.Forms.Button();
            this.scorecount = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // infoset
            // 
            this.infoset.Location = new System.Drawing.Point(30, 60);
            this.infoset.Name = "infoset";
            this.infoset.Size = new System.Drawing.Size(115, 61);
            this.infoset.TabIndex = 0;
            this.infoset.Text = "学生信息管理";
            this.infoset.UseVisualStyleBackColor = true;
            this.infoset.Click += new System.EventHandler(this.infoset_Click);
            // 
            // scoreset
            // 
            this.scoreset.Location = new System.Drawing.Point(30, 171);
            this.scoreset.Name = "scoreset";
            this.scoreset.Size = new System.Drawing.Size(115, 61);
            this.scoreset.TabIndex = 1;
            this.scoreset.Text = "学生成绩管理";
            this.scoreset.UseVisualStyleBackColor = true;
            this.scoreset.Click += new System.EventHandler(this.scoreset_Click);
            // 
            // scorecount
            // 
            this.scorecount.Location = new System.Drawing.Point(30, 279);
            this.scorecount.Name = "scorecount";
            this.scorecount.Size = new System.Drawing.Size(115, 61);
            this.scorecount.TabIndex = 2;
            this.scorecount.Text = "学生成绩统计";
            this.scorecount.UseVisualStyleBackColor = true;
            this.scorecount.Click += new System.EventHandler(this.scorecount_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(30, 391);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(115, 61);
            this.quit.TabIndex = 3;
            this.quit.Text = "退出";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(212, 47);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(640, 470);
            this.panel.TabIndex = 4;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.scorecount);
            this.Controls.Add(this.scoreset);
            this.Controls.Add(this.infoset);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button infoset;
        private System.Windows.Forms.Button scoreset;
        private System.Windows.Forms.Button scorecount;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Panel panel;
    }
}