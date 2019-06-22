namespace facebook
{
    partial class upstatus
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_nd = new System.Windows.Forms.RichTextBox();
            this.btn_dang = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_dang);
            this.groupBox1.Controls.Add(this.tb_nd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng Status Facebook";
            // 
            // tb_nd
            // 
            this.tb_nd.Location = new System.Drawing.Point(46, 48);
            this.tb_nd.Name = "tb_nd";
            this.tb_nd.Size = new System.Drawing.Size(426, 344);
            this.tb_nd.TabIndex = 0;
            this.tb_nd.Text = "";
            this.tb_nd.TextChanged += new System.EventHandler(this.Tb_nd_TextChanged);
            // 
            // btn_dang
            // 
            this.btn_dang.Location = new System.Drawing.Point(545, 303);
            this.btn_dang.Name = "btn_dang";
            this.btn_dang.Size = new System.Drawing.Size(152, 78);
            this.btn_dang.TabIndex = 1;
            this.btn_dang.Text = "Đăng";
            this.btn_dang.UseVisualStyleBackColor = true;
            this.btn_dang.Click += new System.EventHandler(this.Btn_dang_Click);
            // 
            // upstatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "upstatus";
            this.Text = "upstatus";
            this.Load += new System.EventHandler(this.Upstatus_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_dang;
        private System.Windows.Forms.RichTextBox tb_nd;
    }
}