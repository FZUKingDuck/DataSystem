namespace DataSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Loginpanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Userpwd = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Loginpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Loginpanel
            // 
            this.Loginpanel.BackColor = System.Drawing.Color.FloralWhite;
            this.Loginpanel.Controls.Add(this.button1);
            this.Loginpanel.Controls.Add(this.Userpwd);
            this.Loginpanel.Controls.Add(this.Username);
            this.Loginpanel.Controls.Add(this.label4);
            this.Loginpanel.Controls.Add(this.label2);
            this.Loginpanel.Controls.Add(this.label1);
            this.Loginpanel.Location = new System.Drawing.Point(0, 0);
            this.Loginpanel.Name = "Loginpanel";
            this.Loginpanel.Size = new System.Drawing.Size(900, 600);
            this.Loginpanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.Font = new System.Drawing.Font("宋体", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(325, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 62);
            this.button1.TabIndex = 6;
            this.button1.Text = "登陆";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Userpwd
            // 
            this.Userpwd.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Userpwd.Location = new System.Drawing.Point(325, 303);
            this.Userpwd.MinimumSize = new System.Drawing.Size(267, 30);
            this.Userpwd.Name = "Userpwd";
            this.Userpwd.Size = new System.Drawing.Size(267, 36);
            this.Userpwd.TabIndex = 5;
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Username.Location = new System.Drawing.Point(325, 208);
            this.Username.MinimumSize = new System.Drawing.Size(267, 30);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(267, 36);
            this.Username.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(233, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(233, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "账号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(323, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "登陆系统";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 601);
            this.Controls.Add(this.Loginpanel);
            this.Name = "Form1";
            this.Text = "程序管理系统";
            this.Loginpanel.ResumeLayout(false);
            this.Loginpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Loginpanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Userpwd;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}