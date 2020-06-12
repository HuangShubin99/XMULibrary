using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMULibrary
{
    public partial class Admin : Form
    {
        SqlConnection myConn = new SqlConnection(XMULibrary.str);//创建数据库连接类的对象
        private string id;
        private string pwd;
        private string authority;
        public String userId, userPassword, userName, userSex;
        public static DataSet Query(string sql)//查询数据
        {
            SqlConnection con = new SqlConnection(XMULibrary.str);//创建一个数据库连接
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);//创建DataSet和Sql Server之间的桥接桥，用于对数据库进行操作
            DataSet ds = new DataSet();//创建一个数据集
            try
            {
                con.Open();//打开连接
                sda.Fill(ds, "ds");//往窗体里students表中填充数据集ds
                return ds;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);//抛出异常
            }
            finally
            {
                sda.Dispose();//sda处理，以便空间回收
                con.Close();//连接关闭
            }
        }

        //增删改数据
        public static int ExecuteSql(String sql)
        {
            SqlConnection con = new SqlConnection(XMULibrary.str);//创建一个数据库连接
            SqlCommand cmd = new SqlCommand(sql, con);//创建一个sqlCommand,用于对数据库进行操作
            try
            {
                con.Open();
                int rows = cmd.ExecuteNonQuery();//rows接受sql执行后返回的行数
                return rows;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);//抛出异常
            }
            finally
            {
                cmd.Dispose();//对SqlCommand进行处理，以便空间回收
                con.Close();//连接关闭
            }
        }
        public Admin()
        {
            InitializeComponent();
        }

        public Admin(string id, string pwd, string authority)
        {
            InitializeComponent();
            this.id = id;
            this.pwd = pwd;
            this.authority = authority;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string readerid = txt_rid.Text.Trim();
            string rname = txt_rname.Text.Trim();
            string sex = txt_sex.Text.Trim();
            string jobTitle = txt_job.Text.Trim();
            string canBorrowNum = txt_cbn.Text.Trim();
            string borrowedNum = txt_bn.Text.Trim();
            string department = txt_dept.Text.Trim();
            string phone = txt_phone.Text.Trim();
            this.Readerlist.DataSource = Query("select * from readerTable where ReaderId like '%" + readerid + "%' and ReaderName like '%" + rname + "%' and Sex like '%" + sex + "%' and JobTitle like '%" + jobTitle + "%' and CanBorrowNum like '%" + canBorrowNum + "%' and BorrowedNum like '%" + borrowedNum + "%' and Department like '%" + department + "%' and PhoneNumber like '%" + phone + "%'").Tables["ds"];
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string readerid = txt_rid.Text.Trim();
            string rname = txt_rname.Text.Trim();
            string sex = txt_sex.Text.Trim();
            string jobTitle = txt_job.Text.Trim();
            string canBorrowNum = txt_cbn.Text.Trim();
            string borrowedNum = txt_bn.Text.Trim();
            string department = txt_dept.Text.Trim();
            string phone = txt_phone.Text.Trim();
            AddReader childrenform = new AddReader();
            childrenform.Owner = this;
            childrenform.ShowDialog();
            childrenform.Dispose();

            this.Readerlist.DataSource = Query("select * from readerTable where ReaderId like '%" + readerid + "%' and ReaderName like '%" + rname + "%' and Sex like '%" + sex + "%' and JobTitle like '%" + jobTitle + "%' and CanBorrowNum like '%" + canBorrowNum + "%' and BorrowedNum like '%" + borrowedNum + "%' and Department like '%" + department + "%' and PhoneNumber like '%" + phone + "%'").Tables["ds"];
        }

        private void button13_Click(object sender, EventArgs e)
        {

            string readerid = txt_rid.Text.Trim();
            string rname = txt_rname.Text.Trim();
            string sex = txt_sex.Text.Trim();
            string jobTitle = txt_job.Text.Trim();
            string canBorrowNum = txt_cbn.Text.Trim();
            string borrowedNum = txt_bn.Text.Trim();
            string department = txt_dept.Text.Trim();
            string phone = txt_phone.Text.Trim();
            int index = -1;
            index = Readerlist.CurrentRow.Index;//获取当前选中行
            string inputreaderid = Readerlist.Rows[index].Cells[0].Value.ToString().Trim();

            if (index == -1)
            {
                MessageBox.Show("请选择要编辑的行");
                return;
            }

            EditReader childrenform = new EditReader(inputreaderid);
            childrenform.Owner = this;
            childrenform.ShowDialog();
            childrenform.Dispose();

            this.Readerlist.DataSource = Query("select * from readerTable where ReaderId like '%" + readerid + "%' and ReaderName like '%" + rname + "%' and Sex like '%" + sex + "%' and JobTitle like '%" + jobTitle + "%' and CanBorrowNum like '%" + canBorrowNum + "%' and BorrowedNum like '%" + borrowedNum + "%' and Department like '%" + department + "%' and PhoneNumber like '%" + phone + "%'").Tables["ds"];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string bookid = txt_isbn.Text.Trim();
            string bookname = txt_bname.Text.Trim();
            string publisher = txt_publish.Text.Trim();
            string author = txt_author.Text.Trim();
            string collectionNum = txt_collection.Text.Trim();
            string canborrowNum = txt_canNum.Text.Trim();
            string canborrow = txt_can.Text.Trim();
            this.booklist.DataSource = Query("select * from bookTable where ISBN like '%" + bookid+ "%' and BookName like '%" + bookname + "%' and Publisher like '%" + publisher + "%' and Author like '%" + author + "%' and CollectionNum like '%" + collectionNum + "%' and CanBorrowNum like '%" + canborrowNum + "%' and CanBorrow like '%" + canborrow + "%' ").Tables["ds"];
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void bookadd_Click(object sender, EventArgs e)
        {
            string bookid = txt_isbn.Text.Trim();
            string bookname = txt_bname.Text.Trim();
            string publisher = txt_publish.Text.Trim();
            string author = txt_author.Text.Trim();
            string collectionNum = txt_collection.Text.Trim();
            string canborrowNum = txt_canNum.Text.Trim();
            string canborrow = txt_can.Text.Trim();

            AddBook childrenform = new AddBook();
            childrenform.Owner = this;
            childrenform.ShowDialog();
            childrenform.Dispose();

            this.booklist.DataSource = Query("select * from bookTable where ISBN like '%" + bookid + "%' and BookName like '%" + bookname + "%' and Publisher like '%" + publisher + "%' and Author like '%" + author + "%' and CollectionNum like '%" + collectionNum + "%' and CanBorrowNum like '%" + canborrowNum + "%' and CanBorrow like '%" + canborrow + "%' ").Tables["ds"];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string bookid = txt_isbn.Text.Trim();
            string bookname = txt_bname.Text.Trim();
            string publisher = txt_publish.Text.Trim();
            string author = txt_author.Text.Trim();
            string collectionNum = txt_collection.Text.Trim();
            string canborrowNum = txt_canNum.Text.Trim();
            string canborrow = txt_can.Text.Trim();

            int index = -1;
            index = booklist.CurrentRow.Index;//获取当前选中行
            if (index == -1)
            {
                MessageBox.Show("请选择要编辑的行");
                return;
            }

            EditBook childrenform = new EditBook(booklist.Rows[index].Cells[0].Value.ToString().Trim());
            childrenform.Owner = this;
            childrenform.ShowDialog();
            childrenform.Dispose();

            this.booklist.DataSource = Query("select * from bookTable where ISBN like '%" + bookid + "%' and BookName like '%" + bookname + "%' and Publisher like '%" + publisher + "%' and Author like '%" + author + "%' and CollectionNum like '%" + collectionNum + "%' and CanBorrowNum like '%" + canborrowNum + "%' and CanBorrow like '%" + canborrow + "%' ").Tables["ds"];

        }

        private void Readerlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string bookid2 = txt_isbn.Text.Trim();
            string bookname = txt_bname.Text.Trim();
            string publisher = txt_publish.Text.Trim();
            string author = txt_author.Text.Trim();
            string collectionNum = txt_collection.Text.Trim();
            string canborrowNum = txt_canNum.Text.Trim();
            string canborrow = txt_can.Text.Trim();

            int a = booklist.CurrentRow.Index;//获取当前选中行
            string bookid = booklist.Rows[a].Cells[0].Value.ToString().Trim();//获取该行的第0列数据
            //MessageBox.Show(sid);
            string sql = "delete from bookTable where ISBN ='" + bookid + "'";

            if (ExecuteSql(sql) > 0)
            {
                MessageBox.Show("删除成功");
            }

            this.booklist.DataSource = Query("select * from bookTable where ISBN like '%" + bookid2 + "%' and BookName like '%" + bookname + "%' and Publisher like '%" + publisher + "%' and Author like '%" + author + "%' and CollectionNum like '%" + collectionNum + "%' and CanBorrowNum like '%" + canborrowNum + "%' and CanBorrow like '%" + canborrow + "%' ").Tables["ds"];
        }

        private void overdue_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("select * from borrowTable where returnDate < '{0}'", DateTime.Now.ToString("yyyy-MM-dd"));
                DataSet result = Query(sql);
                this.overduelist.DataSource = result.Tables["ds"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void txt_can_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            string readerid = txt_rid.Text.Trim();
            string rname = txt_rname.Text.Trim();
            string sex = txt_sex.Text.Trim();
            string jobTitle = txt_job.Text.Trim();
            string canBorrowNum = txt_cbn.Text.Trim();
            string borrowedNum = txt_bn.Text.Trim();
            string department = txt_dept.Text.Trim();
            string phone = txt_phone.Text.Trim();
            int a = Readerlist.CurrentRow.Index;//获取当前选中行
            string rid = Readerlist.Rows[a].Cells[0].Value.ToString().Trim();//获取该行的第0列数据
            //MessageBox.Show(sid);
            string sql = "delete from readerTable where ReaderId ='" + rid + "'";

            if (ExecuteSql(sql) > 0)
            {
                MessageBox.Show("删除成功");
            }

            this.Readerlist.DataSource = Query("select * from readerTable where ReaderId like '%" + readerid + "%' and ReaderName like '%" + rname + "%' and Sex like '%" + sex + "%' and JobTitle like '%" + jobTitle + "%' and CanBorrowNum like '%" + canBorrowNum + "%' and BorrowedNum like '%" + borrowedNum + "%' and Department like '%" + department + "%' and PhoneNumber like '%" + phone + "%'").Tables["ds"];
        }
    }
}
