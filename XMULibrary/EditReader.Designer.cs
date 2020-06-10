namespace XMULibrary
{
    partial class EditReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditReader));
            this.confirm = new System.Windows.Forms.Button();
            this.txt_sex = new System.Windows.Forms.ComboBox();
            this.txt_rid = new System.Windows.Forms.TextBox();
            this.txt_cbn = new System.Windows.Forms.TextBox();
            this.txt_rname = new System.Windows.Forms.TextBox();
            this.txt_bn = new System.Windows.Forms.TextBox();
            this.txt_job = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_dep = new System.Windows.Forms.TextBox();
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
            this.confirm.Location = new System.Drawing.Point(347, 357);
            this.confirm.Margin = new System.Windows.Forms.Padding(4);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(100, 29);
            this.confirm.TabIndex = 35;
            this.confirm.Text = "确认";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // txt_sex
            // 
            this.txt_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_sex.FormattingEnabled = true;
            this.txt_sex.Items.AddRange(new object[] {
            "male",
            "female"});
            this.txt_sex.Location = new System.Drawing.Point(514, 218);
            this.txt_sex.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sex.Name = "txt_sex";
            this.txt_sex.Size = new System.Drawing.Size(141, 23);
            this.txt_sex.TabIndex = 28;
            // 
            // txt_rid
            // 
            this.txt_rid.Location = new System.Drawing.Point(241, 83);
            this.txt_rid.Margin = new System.Windows.Forms.Padding(4);
            this.txt_rid.Name = "txt_rid";
            this.txt_rid.Size = new System.Drawing.Size(141, 25);
            this.txt_rid.TabIndex = 20;
            // 
            // txt_cbn
            // 
            this.txt_cbn.Location = new System.Drawing.Point(514, 86);
            this.txt_cbn.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cbn.Name = "txt_cbn";
            this.txt_cbn.Size = new System.Drawing.Size(141, 25);
            this.txt_cbn.TabIndex = 30;
            // 
            // txt_rname
            // 
            this.txt_rname.Location = new System.Drawing.Point(241, 125);
            this.txt_rname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_rname.Name = "txt_rname";
            this.txt_rname.Size = new System.Drawing.Size(141, 25);
            this.txt_rname.TabIndex = 21;
            // 
            // txt_bn
            // 
            this.txt_bn.Location = new System.Drawing.Point(514, 133);
            this.txt_bn.Margin = new System.Windows.Forms.Padding(4);
            this.txt_bn.Name = "txt_bn";
            this.txt_bn.Size = new System.Drawing.Size(141, 25);
            this.txt_bn.TabIndex = 31;
            // 
            // txt_job
            // 
            this.txt_job.Location = new System.Drawing.Point(241, 172);
            this.txt_job.Margin = new System.Windows.Forms.Padding(4);
            this.txt_job.Name = "txt_job";
            this.txt_job.Size = new System.Drawing.Size(141, 25);
            this.txt_job.TabIndex = 24;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(514, 179);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(141, 25);
            this.txt_phone.TabIndex = 34;
            // 
            // txt_dep
            // 
            this.txt_dep.Location = new System.Drawing.Point(241, 214);
            this.txt_dep.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dep.Name = "txt_dep";
            this.txt_dep.Size = new System.Drawing.Size(141, 25);
            this.txt_dep.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(410, 179);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "电话";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(410, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "已借数量";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(410, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "可借数量";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(412, 221);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(145, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "部门";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(145, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "职称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(145, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(145, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "借书证号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EditReader
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
            this.Controls.Add(this.txt_dep);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditReader";
            this.Text = "编辑读者信息";
            this.Load += new System.EventHandler(this.EditReader_Load);
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
        private System.Windows.Forms.TextBox txt_dep;
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