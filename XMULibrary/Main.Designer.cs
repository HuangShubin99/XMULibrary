namespace XMULibrary
{
    partial class XMULibrary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XMULibrary));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.loginpwd = new System.Windows.Forms.TextBox();
            this.UserNamelabel = new System.Windows.Forms.Label();
            this.UserPswdlabel = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Confirmbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.loginname = new System.Windows.Forms.TextBox();
            this.tbDBSub = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDBPassword = new System.Windows.Forms.TextBox();
            this.tbDBUserID = new System.Windows.Forms.TextBox();
            this.tbDBInitialCatalog = new System.Windows.Forms.TextBox();
            this.tbDBDataSource = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton1.Location = new System.Drawing.Point(219, 411);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 24);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "管理员";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // loginpwd
            // 
            this.loginpwd.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginpwd.Location = new System.Drawing.Point(367, 313);
            this.loginpwd.Multiline = true;
            this.loginpwd.Name = "loginpwd";
            this.loginpwd.PasswordChar = '*';
            this.loginpwd.Size = new System.Drawing.Size(386, 37);
            this.loginpwd.TabIndex = 1;
            this.loginpwd.TextChanged += new System.EventHandler(this.loginpwd_TextChanged);
            // 
            // UserNamelabel
            // 
            this.UserNamelabel.BackColor = System.Drawing.Color.Transparent;
            this.UserNamelabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserNamelabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UserNamelabel.Location = new System.Drawing.Point(245, 225);
            this.UserNamelabel.Name = "UserNamelabel";
            this.UserNamelabel.Size = new System.Drawing.Size(113, 75);
            this.UserNamelabel.TabIndex = 2;
            this.UserNamelabel.Text = "用户名：";
            this.UserNamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UserNamelabel.Click += new System.EventHandler(this.UserNamelabel_Click);
            // 
            // UserPswdlabel
            // 
            this.UserPswdlabel.BackColor = System.Drawing.Color.Transparent;
            this.UserPswdlabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserPswdlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UserPswdlabel.Location = new System.Drawing.Point(245, 300);
            this.UserPswdlabel.Name = "UserPswdlabel";
            this.UserPswdlabel.Size = new System.Drawing.Size(116, 65);
            this.UserPswdlabel.TabIndex = 3;
            this.UserPswdlabel.Text = "密码：";
            this.UserPswdlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton2
            // 
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton2.Location = new System.Drawing.Point(219, 381);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 24);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "读者";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Confirmbutton
            // 
            this.Confirmbutton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Confirmbutton.Location = new System.Drawing.Point(377, 390);
            this.Confirmbutton.Name = "Confirmbutton";
            this.Confirmbutton.Size = new System.Drawing.Size(142, 45);
            this.Confirmbutton.TabIndex = 6;
            this.Confirmbutton.Text = "登陆";
            this.Confirmbutton.UseVisualStyleBackColor = true;
            this.Confirmbutton.Click += new System.EventHandler(this.Confirmbutton_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("楷体", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(281, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(529, 102);
            this.label3.TabIndex = 8;
            this.label3.Text = "书山有路勤为径\r\n学海无涯苦作舟";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginname
            // 
            this.loginname.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginname.Location = new System.Drawing.Point(367, 240);
            this.loginname.Multiline = true;
            this.loginname.Name = "loginname";
            this.loginname.Size = new System.Drawing.Size(386, 35);
            this.loginname.TabIndex = 10;
            this.loginname.TextChanged += new System.EventHandler(this.loginname_TextChanged);
            // 
            // tbDBSub
            // 
            this.tbDBSub.Location = new System.Drawing.Point(935, 158);
            this.tbDBSub.Name = "tbDBSub";
            this.tbDBSub.Size = new System.Drawing.Size(88, 31);
            this.tbDBSub.TabIndex = 32;
            this.tbDBSub.Text = "确认";
            this.tbDBSub.UseVisualStyleBackColor = true;
            this.tbDBSub.Click += new System.EventHandler(this.tbDBSub_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(778, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "数据库源:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(733, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "数据库用户密码:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(747, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "数据库用户ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(763, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "数据库名称:";
            // 
            // tbDBPassword
            // 
            this.tbDBPassword.Location = new System.Drawing.Point(859, 127);
            this.tbDBPassword.Name = "tbDBPassword";
            this.tbDBPassword.Size = new System.Drawing.Size(164, 25);
            this.tbDBPassword.TabIndex = 27;
            this.tbDBPassword.Text = "123456";
            // 
            // tbDBUserID
            // 
            this.tbDBUserID.Location = new System.Drawing.Point(859, 95);
            this.tbDBUserID.Name = "tbDBUserID";
            this.tbDBUserID.Size = new System.Drawing.Size(164, 25);
            this.tbDBUserID.TabIndex = 26;
            this.tbDBUserID.Text = "t1";
            // 
            // tbDBInitialCatalog
            // 
            this.tbDBInitialCatalog.Location = new System.Drawing.Point(859, 64);
            this.tbDBInitialCatalog.Name = "tbDBInitialCatalog";
            this.tbDBInitialCatalog.Size = new System.Drawing.Size(164, 25);
            this.tbDBInitialCatalog.TabIndex = 25;
            this.tbDBInitialCatalog.Text = "XMULibrary";
            // 
            // tbDBDataSource
            // 
            this.tbDBDataSource.Location = new System.Drawing.Point(859, 33);
            this.tbDBDataSource.Name = "tbDBDataSource";
            this.tbDBDataSource.Size = new System.Drawing.Size(164, 25);
            this.tbDBDataSource.TabIndex = 24;
            this.tbDBDataSource.Text = "WIN-6NGPCQQABM2";
            // 
            // register
            // 
            this.register.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.register.Location = new System.Drawing.Point(586, 390);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(156, 45);
            this.register.TabIndex = 33;
            this.register.Text = "注册";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // XMULibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.register);
            this.Controls.Add(this.tbDBSub);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDBPassword);
            this.Controls.Add(this.tbDBUserID);
            this.Controls.Add(this.tbDBInitialCatalog);
            this.Controls.Add(this.tbDBDataSource);
            this.Controls.Add(this.loginname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Confirmbutton);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.UserPswdlabel);
            this.Controls.Add(this.UserNamelabel);
            this.Controls.Add(this.loginpwd);
            this.Name = "XMULibrary";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox loginpwd;
        private System.Windows.Forms.Label UserNamelabel;
        private System.Windows.Forms.Label UserPswdlabel;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button Confirmbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loginname;
        private System.Windows.Forms.Button tbDBSub;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDBPassword;
        private System.Windows.Forms.TextBox tbDBUserID;
        private System.Windows.Forms.TextBox tbDBInitialCatalog;
        private System.Windows.Forms.TextBox tbDBDataSource;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button register;
    }
}

