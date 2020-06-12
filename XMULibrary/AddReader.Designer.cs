namespace XMULibrary
{
    partial class AddReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddReader));
            this.confirm = new System.Windows.Forms.Button();
            this.txt_sex = new System.Windows.Forms.ComboBox();
            this.txt_rid = new System.Windows.Forms.TextBox();
            this.txt_cbn = new System.Windows.Forms.TextBox();
            this.txt_rname = new System.Windows.Forms.TextBox();
            this.txt_bn = new System.Windows.Forms.TextBox();
            this.txt_job = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_dept = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(347, 348);
            this.confirm.Margin = new System.Windows.Forms.Padding(4);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(100, 29);
            this.confirm.TabIndex = 52;
            this.confirm.Text = "确认";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click_1);
            // 
            // txt_sex
            // 
            this.txt_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_sex.FormattingEnabled = true;
            this.txt_sex.Items.AddRange(new object[] {
            "male",
            "female"});
            this.txt_sex.Location = new System.Drawing.Point(514, 209);
            this.txt_sex.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sex.Name = "txt_sex";
            this.txt_sex.Size = new System.Drawing.Size(141, 23);
            this.txt_sex.TabIndex = 45;
            // 
            // txt_rid
            // 
            this.txt_rid.Location = new System.Drawing.Point(241, 74);
            this.txt_rid.Margin = new System.Windows.Forms.Padding(4);
            this.txt_rid.Name = "txt_rid";
            this.txt_rid.Size = new System.Drawing.Size(141, 25);
            this.txt_rid.TabIndex = 37;
            // 
            // txt_cbn
            // 
            this.txt_cbn.Location = new System.Drawing.Point(514, 77);
            this.txt_cbn.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cbn.Name = "txt_cbn";
            this.txt_cbn.Size = new System.Drawing.Size(141, 25);
            this.txt_cbn.TabIndex = 47;
            // 
            // txt_rname
            // 
            this.txt_rname.Location = new System.Drawing.Point(241, 116);
            this.txt_rname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_rname.Name = "txt_rname";
            this.txt_rname.Size = new System.Drawing.Size(141, 25);
            this.txt_rname.TabIndex = 38;
            // 
            // txt_bn
            // 
            this.txt_bn.Location = new System.Drawing.Point(514, 124);
            this.txt_bn.Margin = new System.Windows.Forms.Padding(4);
            this.txt_bn.Name = "txt_bn";
            this.txt_bn.Size = new System.Drawing.Size(141, 25);
            this.txt_bn.TabIndex = 48;
            // 
            // txt_job
            // 
            this.txt_job.Location = new System.Drawing.Point(241, 163);
            this.txt_job.Margin = new System.Windows.Forms.Padding(4);
            this.txt_job.Name = "txt_job";
            this.txt_job.Size = new System.Drawing.Size(141, 25);
            this.txt_job.TabIndex = 41;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(514, 170);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(141, 25);
            this.txt_phone.TabIndex = 51;
            // 
            // txt_dept
            // 
            this.txt_dept.Location = new System.Drawing.Point(241, 205);
            this.txt_dept.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dept.Name = "txt_dept";
            this.txt_dept.Size = new System.Drawing.Size(141, 25);
            this.txt_dept.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(410, 170);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 50;
            this.label8.Text = "电话";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(410, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 49;
            this.label7.Text = "已借数量";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(410, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 46;
            this.label6.Text = "可借数量";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(412, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 44;
            this.label5.Text = "性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(145, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 42;
            this.label4.Text = "部门";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(145, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "职称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(145, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(145, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "借书证号";
            // 
            // AddReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.txt_sex);
            this.Controls.Add(this.txt_rid);
            this.Controls.Add(this.txt_cbn);
            this.Controls.Add(this.txt_rname);
            this.Controls.Add(this.txt_bn);
            this.Controls.Add(this.txt_job);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_dept);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddReader";
            this.Text = "读者信息添加";
            this.Load += new System.EventHandler(this.AddReader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.ComboBox txt_sex;
        private System.Windows.Forms.TextBox txt_rid;
        private System.Windows.Forms.TextBox txt_cbn;
        private System.Windows.Forms.TextBox txt_rname;
        private System.Windows.Forms.TextBox txt_bn;
        private System.Windows.Forms.TextBox txt_job;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_dept;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}