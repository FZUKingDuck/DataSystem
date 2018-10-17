namespace DataSystem.Page {
    partial class openbody {
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.showtext = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(185, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 27);
            this.textBox1.TabIndex = 0;
            // 
            // showtext
            // 
            this.showtext.AutoSize = true;
            this.showtext.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showtext.Location = new System.Drawing.Point(28, 45);
            this.showtext.Name = "showtext";
            this.showtext.Size = new System.Drawing.Size(112, 25);
            this.showtext.TabIndex = 1;
            this.showtext.Text = "输入账号";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(147, 105);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(214, 50);
            this.btn.TabIndex = 2;
            this.btn.Text = "确定";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // openbody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 167);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.showtext);
            this.Controls.Add(this.textBox1);
            this.Name = "openbody";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label showtext;
        private System.Windows.Forms.Button btn;
    }
}