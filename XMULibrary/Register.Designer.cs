namespace XMULibrary
{
    partial class Register
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
            this.confirm = new System.Windows.Forms.Button();
            this.identity = new System.Windows.Forms.ComboBox();
            this.password = new System.Windows.Forms.TextBox();
            this.account = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(313, 304);
            this.confirm.Margin = new System.Windows.Forms.Padding(4);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(100, 29);
            this.confirm.TabIndex = 13;
            this.confirm.Text = "注册";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // identity
            // 
            this.identity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.identity.FormattingEnabled = true;
            this.identity.Items.AddRange(new object[] {
            "admin",
            "reader"});
            this.identity.Location = new System.Drawing.Point(402, 235);
            this.identity.Margin = new System.Windows.Forms.Padding(4);
            this.identity.Name = "identity";
            this.identity.Size = new System.Drawing.Size(160, 23);
            this.identity.TabIndex = 12;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(402, 179);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(132, 25);
            this.password.TabIndex = 11;
            this.password.UseSystemPasswordChar = true;
            // 
            // account
            // 
            this.account.Location = new System.Drawing.Point(402, 118);
            this.account.Margin = new System.Windows.Forms.Padding(4);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(132, 25);
            this.account.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "身份";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "账号";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.identity);
            this.Controls.Add(this.password);
            this.Controls.Add(this.account);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "注册";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.ComboBox identity;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox account;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}