namespace 票务交易系统
{
    partial class AdminLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LblAdminID = new System.Windows.Forms.Label();
            this.LblAdminPassword = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUsername
            // 
            this.TxtUsername.Font = new System.Drawing.Font("宋体", 12F);
            this.TxtUsername.Location = new System.Drawing.Point(400, 265);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(165, 26);
            this.TxtUsername.TabIndex = 0;
            this.TxtUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("宋体", 12F);
            this.TxtPassword.Location = new System.Drawing.Point(400, 336);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(165, 26);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.BtnLogin.Font = new System.Drawing.Font("宋体", 30F);
            this.BtnLogin.Location = new System.Drawing.Point(362, 410);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(245, 46);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "管理员登录";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LblAdminID
            // 
            this.LblAdminID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblAdminID.Font = new System.Drawing.Font("宋体", 20F);
            this.LblAdminID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblAdminID.Location = new System.Drawing.Point(229, 265);
            this.LblAdminID.Name = "LblAdminID";
            this.LblAdminID.Size = new System.Drawing.Size(156, 26);
            this.LblAdminID.TabIndex = 3;
            this.LblAdminID.Text = "管理员ID:";
            this.LblAdminID.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblAdminPassword
            // 
            this.LblAdminPassword.Font = new System.Drawing.Font("宋体", 20F);
            this.LblAdminPassword.Location = new System.Drawing.Point(229, 330);
            this.LblAdminPassword.Name = "LblAdminPassword";
            this.LblAdminPassword.Size = new System.Drawing.Size(120, 40);
            this.LblAdminPassword.TabIndex = 4;
            this.LblAdminPassword.Text = "密码:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(833, 206);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.BtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 536);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblAdminPassword);
            this.Controls.Add(this.LblAdminID);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.Name = "Login";
            this.Text = "LoginScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label LblAdminID;
        private System.Windows.Forms.Label LblAdminPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

