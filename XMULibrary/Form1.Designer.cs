namespace XMULibrary
{
    partial class LoginForm
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
            System.Windows.Forms.RadioButton radioButton1;
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.PswdtextBox = new System.Windows.Forms.TextBox();
            this.UserNamelabel = new System.Windows.Forms.Label();
            this.UserPswdlabel = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Confirmbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(413, 233);
            this.NametextBox.Multiline = true;
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(290, 50);
            this.NametextBox.TabIndex = 0;
            // 
            // PswdtextBox
            // 
            this.PswdtextBox.Location = new System.Drawing.Point(413, 308);
            this.PswdtextBox.Multiline = true;
            this.PswdtextBox.Name = "PswdtextBox";
            this.PswdtextBox.Size = new System.Drawing.Size(290, 50);
            this.PswdtextBox.TabIndex = 1;
            // 
            // UserNamelabel
            // 
            this.UserNamelabel.Location = new System.Drawing.Point(283, 233);
            this.UserNamelabel.Name = "UserNamelabel";
            this.UserNamelabel.Size = new System.Drawing.Size(97, 50);
            this.UserNamelabel.TabIndex = 2;
            this.UserNamelabel.Text = "用户名";
            this.UserNamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserPswdlabel
            // 
            this.UserPswdlabel.Location = new System.Drawing.Point(280, 308);
            this.UserPswdlabel.Name = "UserPswdlabel";
            this.UserPswdlabel.Size = new System.Drawing.Size(100, 50);
            this.UserPswdlabel.TabIndex = 3;
            this.UserPswdlabel.Text = "密码";
            this.UserPswdlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton1
            // 
            radioButton1.Location = new System.Drawing.Point(60, 43);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(104, 24);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "管理员";
            radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(60, 90);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 24);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "用户";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Confirmbutton
            // 
            this.Confirmbutton.Location = new System.Drawing.Point(413, 403);
            this.Confirmbutton.Name = "Confirmbutton";
            this.Confirmbutton.Size = new System.Drawing.Size(75, 23);
            this.Confirmbutton.TabIndex = 6;
            this.Confirmbutton.Text = "确认";
            this.Confirmbutton.UseVisualStyleBackColor = true;
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(627, 403);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 7;
            this.Cancelbutton.Text = "取消";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(289, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(529, 102);
            this.label3.TabIndex = 8;
            this.label3.Text = "书山有路勤为径\r\n学海无涯苦作舟";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Confirmbutton);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(radioButton1);
            this.Controls.Add(this.UserPswdlabel);
            this.Controls.Add(this.UserNamelabel);
            this.Controls.Add(this.PswdtextBox);
            this.Controls.Add(this.NametextBox);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox PswdtextBox;
        private System.Windows.Forms.Label UserNamelabel;
        private System.Windows.Forms.Label UserPswdlabel;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button Confirmbutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Label label3;
    }
}

