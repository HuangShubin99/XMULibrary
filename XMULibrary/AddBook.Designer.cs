namespace XMULibrary
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            this.txt_can = new System.Windows.Forms.ComboBox();
            this.txt_collection = new System.Windows.Forms.TextBox();
            this.txt_cannum = new System.Windows.Forms.TextBox();
            this.txt_publish = new System.Windows.Forms.TextBox();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.txt_isbn = new System.Windows.Forms.TextBox();
            this.txt_bname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_can
            // 
            this.txt_can.BackColor = System.Drawing.SystemColors.Window;
            this.txt_can.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_can.FormattingEnabled = true;
            this.txt_can.Items.AddRange(new object[] {
            "true",
            "false"});
            this.txt_can.Location = new System.Drawing.Point(372, 249);
            this.txt_can.Margin = new System.Windows.Forms.Padding(4);
            this.txt_can.Name = "txt_can";
            this.txt_can.Size = new System.Drawing.Size(160, 23);
            this.txt_can.TabIndex = 83;
            // 
            // txt_collection
            // 
            this.txt_collection.Location = new System.Drawing.Point(207, 184);
            this.txt_collection.Margin = new System.Windows.Forms.Padding(4);
            this.txt_collection.Name = "txt_collection";
            this.txt_collection.Size = new System.Drawing.Size(160, 25);
            this.txt_collection.TabIndex = 78;
            // 
            // txt_cannum
            // 
            this.txt_cannum.Location = new System.Drawing.Point(518, 180);
            this.txt_cannum.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cannum.Name = "txt_cannum";
            this.txt_cannum.Size = new System.Drawing.Size(160, 25);
            this.txt_cannum.TabIndex = 80;
            // 
            // txt_publish
            // 
            this.txt_publish.Location = new System.Drawing.Point(207, 128);
            this.txt_publish.Margin = new System.Windows.Forms.Padding(4);
            this.txt_publish.Name = "txt_publish";
            this.txt_publish.Size = new System.Drawing.Size(160, 25);
            this.txt_publish.TabIndex = 74;
            // 
            // txt_author
            // 
            this.txt_author.Location = new System.Drawing.Point(518, 128);
            this.txt_author.Margin = new System.Windows.Forms.Padding(4);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(160, 25);
            this.txt_author.TabIndex = 76;
            // 
            // txt_isbn
            // 
            this.txt_isbn.Location = new System.Drawing.Point(207, 82);
            this.txt_isbn.Margin = new System.Windows.Forms.Padding(4);
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.Size = new System.Drawing.Size(160, 25);
            this.txt_isbn.TabIndex = 70;
            // 
            // txt_bname
            // 
            this.txt_bname.Location = new System.Drawing.Point(518, 82);
            this.txt_bname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_bname.Name = "txt_bname";
            this.txt_bname.Size = new System.Drawing.Size(160, 25);
            this.txt_bname.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("宋体", 9F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(285, 252);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 82;
            this.label7.Text = "是否可借";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("宋体", 9F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(422, 186);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 81;
            this.label6.Text = "可借数量";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 9F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(123, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 79;
            this.label5.Text = "馆藏数量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 9F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(429, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 77;
            this.label4.Text = "作者";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 9F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(123, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 75;
            this.label3.Text = "出版社";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(429, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 73;
            this.label2.Text = "书名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(123, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 71;
            this.label1.Text = "ISBN";
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(341, 339);
            this.confirm.Margin = new System.Windows.Forms.Padding(4);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(100, 29);
            this.confirm.TabIndex = 69;
            this.confirm.Text = "确认";
            this.confirm.UseVisualStyleBackColor = true;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_can);
            this.Controls.Add(this.txt_collection);
            this.Controls.Add(this.txt_cannum);
            this.Controls.Add(this.txt_publish);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.txt_isbn);
            this.Controls.Add(this.txt_bname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirm);
            this.Name = "AddBook";
            this.Text = "图书信息添加";
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txt_can;
        private System.Windows.Forms.TextBox txt_collection;
        private System.Windows.Forms.TextBox txt_cannum;
        private System.Windows.Forms.TextBox txt_publish;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.TextBox txt_isbn;
        private System.Windows.Forms.TextBox txt_bname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirm;
    }
}