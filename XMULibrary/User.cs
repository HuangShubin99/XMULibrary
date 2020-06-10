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
    
    public partial class User : Form
    {
        SqlConnection myConn = new SqlConnection(XMULibrary.str);//创建数据库连接类的对象
        public String userId, userPassword, userName, userSex;
        private string id;
        private string pwd;
        private string authority;

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

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string readerid = txt_reader.Text.Trim();
            string rname = txt_rname.Text.Trim();
            string sex = txt_sex.Text.Trim();
            string jobTitle = txt_job.Text.Trim();
            string canBorrowNum = txt_cbn.Text.Trim();
            string borrowedNum = txt_bn.Text.Trim();
            string department = txt_dep.Text.Trim();
            string phone = txt_phone.Text.Trim();
            this.Readerlist.DataSource = Query("select * from readerTable where ReaderId like '%" + readerid + "%' and ReaderName like '%" + rname + "%' and Sex like '%" + sex + "%' and JobTitle like '%" + jobTitle + "%' and CanBorrowNum like '%" + canBorrowNum + "%' and BorrowedNum like '%" + borrowedNum + "%' and Department like '%" + department + "%' and PhoneNumber like '%" + phone + "%'").Tables["ds"];
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string bookid = txt_isbn.Text.Trim();
            string bookname = txt_bname.Text.Trim();
            string publisher = txt_publish.Text.Trim();
            string author = txt_author.Text.Trim();
            this.booklist.DataSource = Query("select * from bookTable where ISBN like '%" + bookid + "%' and BookName like '%" + bookname + "%' and Publisher like '%" + publisher + "%' and Author like '%" + author + "%'").Tables["ds"];
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void booklist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void brrowbook_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet result = null;

                int index = booklist.CurrentRow.Index;
                string inputIsbn = booklist.Rows[index].Cells[0].Value.ToString().Trim();

                string sql = String.Format("insert into borrowTable values('{0}','{1}','{2}',{3},'{4}',{5})",
                                   txt_rid.Text, inputIsbn, DateTime.Now.ToString("yyyy-MM-dd"), 30, DateTime.Now.AddDays(30).ToString("yyyy-MM-dd"), 30);

                if (DialogResult.Yes == MessageBox.Show("确定借书？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
                {
                    //还书
                    if (ExecuteSql(sql) > 0) //查询数据库，得到借书结果
                    {
                        MessageBox.Show("借书成功");

                        //查询语句
                        string bookSearchSql =
                            String.Format("select * from bookTable where ISBN like '%{0}%' and BookName like '%{1}%' and Publisher like '%{2}%' and Author like '%{3}%'",
                                txt_isbn.Text,txt_bname.Text, txt_publish.Text,txt_author.Text);
                        result = Query(bookSearchSql);

                        this.booklist.DataSource = result.Tables["ds"];
                    }
                    else
                    {
                        MessageBox.Show("借书失败");
                    }
                }
            }
            catch (NullReferenceException exception)
            {
                MessageBox.Show("请先选中一行！");
                return;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void returnbook_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet result = null;

                int index = booklist.CurrentRow.Index;
                string inputIsbn = booklist.Rows[index].Cells[0].Value.ToString().Trim();


                string sql = String.Format("delete from borrowTable where ReaderId ='{0}' and ISBN ='{1}'", txt_rid.Text, inputIsbn);

                if (DialogResult.Yes == MessageBox.Show("确定还书？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
                {
                    //还书
                    if (ExecuteSql(sql) > 0) //查询数据库得到还书结果
                    {
                        MessageBox.Show("还书成功");


                        //查询语句
                        string bookSearchSql =
                            String.Format("select * from bookTable where ISBN like '%{0}%' and BookName like '%{1}%' and Publisher like '%{2}%' and Author like '%{3}%'",
                                txt_isbn.Text, txt_bname.Text, txt_publish.Text, txt_author.Text);
                        result = Query(bookSearchSql);

                        this.booklist.DataSource = result.Tables["ds"];
                    }
                    else
                    {
                        MessageBox.Show("你没有借过这本书！");
                    }
                }
            }
            catch (NullReferenceException exception)
            {
                MessageBox.Show("请先选中一行！");
                return;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
        }

        private void button6_Click(object sender, EventArgs e)
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

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        public User()
        {
            InitializeComponent();
        }

        public User(string id, string pwd, string authority)
        {
            InitializeComponent();
            this.id = id;
            this.pwd = pwd;
            this.authority = authority;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
