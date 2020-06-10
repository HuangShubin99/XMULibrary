namespace XMULibrary
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.button1 = new System.Windows.Forms.Button();
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.bookupdate = new System.Windows.Forms.Button();
            this.bookadd = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.booklist = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_can = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_collection = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_publish = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_bname = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_canNum = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_isbn = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.overdue = new System.Windows.Forms.Button();
            this.overduelist = new System.Windows.Forms.DataGridView();
            this.Readerlist = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_sex = new System.Windows.Forms.ComboBox();
            this.txt_job = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_bn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_dept = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_rname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cbn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_rid = new System.Windows.Forms.TextBox();
            this.tab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booklist)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overduelist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Readerlist)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "添加新图书信息";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabPage1);
            this.tab1.Controls.Add(this.tabPage2);
            this.tab1.Controls.Add(this.tabPage3);
            this.tab1.Location = new System.Drawing.Point(4, -3);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(1585, 681);
            this.tab1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.Readerlist);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1577, 652);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "读者信息";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button14.Location = new System.Drawing.Point(169, 385);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(106, 47);
            this.button14.TabIndex = 5;
            this.button14.Text = "删除";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button13.Location = new System.Drawing.Point(168, 450);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(106, 47);
            this.button13.TabIndex = 4;
            this.button13.Text = "修改";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button12.Location = new System.Drawing.Point(48, 450);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(98, 47);
            this.button12.TabIndex = 3;
            this.button12.Text = "添加";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button11.Location = new System.Drawing.Point(48, 385);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(98, 47);
            this.button11.TabIndex = 2;
            this.button11.Text = "查询";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.booklist);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1577, 652);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "图书信息";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(176, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 47);
            this.button2.TabIndex = 9;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bookupdate
            // 
            this.bookupdate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bookupdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bookupdate.Location = new System.Drawing.Point(31, 419);
            this.bookupdate.Name = "bookupdate";
            this.bookupdate.Size = new System.Drawing.Size(135, 47);
            this.bookupdate.TabIndex = 8;
            this.bookupdate.Text = "修改";
            this.bookupdate.UseVisualStyleBackColor = true;
            this.bookupdate.Click += new System.EventHandler(this.button3_Click);
            // 
            // bookadd
            // 
            this.bookadd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bookadd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bookadd.Location = new System.Drawing.Point(176, 346);
            this.bookadd.Name = "bookadd";
            this.bookadd.Size = new System.Drawing.Size(130, 47);
            this.bookadd.TabIndex = 7;
            this.bookadd.Text = "添加";
            this.bookadd.UseVisualStyleBackColor = true;
            this.bookadd.Click += new System.EventHandler(this.bookadd_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(35, 346);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 47);
            this.button5.TabIndex = 6;
            this.button5.Text = "查询";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // booklist
            // 
            this.booklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booklist.Location = new System.Drawing.Point(378, 25);
            this.booklist.Name = "booklist";
            this.booklist.RowHeadersWidth = 51;
            this.booklist.RowTemplate.Height = 27;
            this.booklist.Size = new System.Drawing.Size(984, 529);
            this.booklist.TabIndex = 3;
            this.booklist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txt_can);
            this.groupBox2.Controls.Add(this.bookupdate);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.bookadd);
            this.groupBox2.Controls.Add(this.txt_collection);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_author);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_publish);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txt_bname);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txt_canNum);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txt_isbn);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(30, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 499);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "读者信息操作";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txt_can
            // 
            this.txt_can.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_can.FormattingEnabled = true;
            this.txt_can.Items.AddRange(new object[] {
            "true",
            "false"});
            this.txt_can.Location = new System.Drawing.Point(118, 245);
            this.txt_can.Name = "txt_can";
            this.txt_can.Size = new System.Drawing.Size(156, 23);
            this.txt_can.TabIndex = 16;
            this.txt_can.SelectedIndexChanged += new System.EventHandler(this.txt_can_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "是否可借";
            // 
            // txt_collection
            // 
            this.txt_collection.Location = new System.Drawing.Point(118, 206);
            this.txt_collection.Name = "txt_collection";
            this.txt_collection.Size = new System.Drawing.Size(157, 25);
            this.txt_collection.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "最少馆藏数量";
            // 
            // txt_author
            // 
            this.txt_author.Location = new System.Drawing.Point(118, 162);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(157, 25);
            this.txt_author.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(75, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "作者";
            // 
            // txt_publish
            // 
            this.txt_publish.Location = new System.Drawing.Point(118, 122);
            this.txt_publish.Name = "txt_publish";
            this.txt_publish.Size = new System.Drawing.Size(157, 25);
            this.txt_publish.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(60, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 15);
            this.label13.TabIndex = 6;
            this.label13.Text = "出版社";
            // 
            // txt_bname
            // 
            this.txt_bname.Location = new System.Drawing.Point(118, 81);
            this.txt_bname.Name = "txt_bname";
            this.txt_bname.Size = new System.Drawing.Size(157, 25);
            this.txt_bname.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(75, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 15);
            this.label14.TabIndex = 4;
            this.label14.Text = "书名";
            // 
            // txt_canNum
            // 
            this.txt_canNum.Location = new System.Drawing.Point(118, 289);
            this.txt_canNum.Name = "txt_canNum";
            this.txt_canNum.Size = new System.Drawing.Size(157, 25);
            this.txt_canNum.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 292);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 15);
            this.label15.TabIndex = 2;
            this.label15.Text = "最少可借数量";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(45, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 15);
            this.label16.TabIndex = 1;
            this.label16.Text = "ISBN书号";
            // 
            // txt_isbn
            // 
            this.txt_isbn.Location = new System.Drawing.Point(118, 44);
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.Size = new System.Drawing.Size(157, 25);
            this.txt_isbn.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.Controls.Add(this.overdue);
            this.tabPage3.Controls.Add(this.overduelist);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1146, 652);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "逾期图书信息";
            // 
            // overdue
            // 
            this.overdue.Location = new System.Drawing.Point(481, 576);
            this.overdue.Name = "overdue";
            this.overdue.Size = new System.Drawing.Size(206, 56);
            this.overdue.TabIndex = 11;
            this.overdue.Text = "查询";
            this.overdue.UseVisualStyleBackColor = true;
            this.overdue.Click += new System.EventHandler(this.overdue_Click);
            // 
            // overduelist
            // 
            this.overduelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.overduelist.Location = new System.Drawing.Point(6, 7);
            this.overduelist.Name = "overduelist";
            this.overduelist.RowHeadersWidth = 51;
            this.overduelist.RowTemplate.Height = 27;
            this.overduelist.Size = new System.Drawing.Size(1139, 553);
            this.overduelist.TabIndex = 10;
            // 
            // Readerlist
            // 
            this.Readerlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Readerlist.Location = new System.Drawing.Point(396, 23);
            this.Readerlist.Name = "Readerlist";
            this.Readerlist.RowHeadersWidth = 51;
            this.Readerlist.RowTemplate.Height = 27;
            this.Readerlist.Size = new System.Drawing.Size(1160, 531);
            this.Readerlist.TabIndex = 1;
            this.Readerlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Readerlist_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_sex);
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.txt_job);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.txt_bn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_phone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_dept);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_rname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_cbn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_rid);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(85, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 525);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "读者信息操作";
            // 
            // txt_sex
            // 
            this.txt_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_sex.FormattingEnabled = true;
            this.txt_sex.Items.AddRange(new object[] {
            "male",
            "female"});
            this.txt_sex.Location = new System.Drawing.Point(118, 109);
            this.txt_sex.Name = "txt_sex";
            this.txt_sex.Size = new System.Drawing.Size(156, 23);
            this.txt_sex.TabIndex = 16;
            // 
            // txt_job
            // 
            this.txt_job.Location = new System.Drawing.Point(117, 252);
            this.txt_job.Name = "txt_job";
            this.txt_job.Size = new System.Drawing.Size(157, 25);
            this.txt_job.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(74, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "职称";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(74, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "性别";
            // 
            // txt_bn
            // 
            this.txt_bn.Location = new System.Drawing.Point(118, 342);
            this.txt_bn.Name = "txt_bn";
            this.txt_bn.Size = new System.Drawing.Size(157, 25);
            this.txt_bn.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(15, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "最少已借数量";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(118, 204);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(157, 25);
            this.txt_phone.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(44, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "联系电话";
            // 
            // txt_dept
            // 
            this.txt_dept.Location = new System.Drawing.Point(118, 154);
            this.txt_dept.Name = "txt_dept";
            this.txt_dept.Size = new System.Drawing.Size(157, 25);
            this.txt_dept.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(45, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "工作部门";
            // 
            // txt_rname
            // 
            this.txt_rname.Location = new System.Drawing.Point(118, 65);
            this.txt_rname.Name = "txt_rname";
            this.txt_rname.Size = new System.Drawing.Size(157, 25);
            this.txt_rname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(75, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "姓名";
            // 
            // txt_cbn
            // 
            this.txt_cbn.Location = new System.Drawing.Point(117, 298);
            this.txt_cbn.Name = "txt_cbn";
            this.txt_cbn.Size = new System.Drawing.Size(157, 25);
            this.txt_cbn.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(14, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "最少可借数量";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(45, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "借书证号";
            // 
            // txt_rid
            // 
            this.txt_rid.Location = new System.Drawing.Point(118, 21);
            this.txt_rid.Name = "txt_rid";
            this.txt_rid.Size = new System.Drawing.Size(157, 25);
            this.txt_rid.TabIndex = 0;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1653, 588);
            this.Controls.Add(this.tab1);
            this.Controls.Add(this.button1);
            this.Name = "Admin";
            this.Text = "图书管理系统";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.booklist)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.overduelist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Readerlist)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.DataGridView booklist;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox txt_can;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_collection;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_publish;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_bname;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_canNum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_isbn;
        private System.Windows.Forms.DataGridView overduelist;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bookupdate;
        private System.Windows.Forms.Button bookadd;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button overdue;
        private System.Windows.Forms.DataGridView Readerlist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txt_sex;
        private System.Windows.Forms.TextBox txt_job;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_bn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_dept;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_rname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cbn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_rid;
    }
}