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
    public partial class EditBook : Form
    {

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
        public EditBook()
        {
            InitializeComponent();
        }

        public EditBook(string inputisbn)
        {
            InitializeComponent();
            txt_isbn.Text = inputisbn;
            string bookid = inputisbn;
            string sql = "SELECT ISBN,BookName,Publisher,Author,CollectionNum,CanBorrowNum,CanBorrow FROM bookTable "
    + " WHERE ISBN ='" + bookid + "'";
            DataSet dataSet = Query(sql);
            if (dataSet != null && dataSet.Tables[0].Rows.Count > 0)
            {
                this.txt_isbn.Text = dataSet.Tables[0].Rows[0]["ISBN"].ToString();
                this.txt_bname.Text = dataSet.Tables[0].Rows[0]["BookName"].ToString();
                this.txt_publish.Text = dataSet.Tables[0].Rows[0]["Publisher"].ToString();
                this.txt_author.Text = dataSet.Tables[0].Rows[0]["Author"].ToString();
                this.txt_collection.Text = dataSet.Tables[0].Rows[0]["CollectionNum"].ToString();
                this.txt_cannum.Text = dataSet.Tables[0].Rows[0]["CanBorrowNum"].ToString();
                this.txt_can.SelectedItem = dataSet.Tables[0].Rows[0]["CanBorrow"];
            }
        }

        private void EditBook_Load(object sender, EventArgs e)
        {

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            try
            {
                string bookid = txt_isbn.Text;
                string bookname = txt_bname.Text;
                string publisher = txt_publish.Text;
                string author = txt_author.Text;
                string collectionNum = txt_collection.Text;
                string canborrowNum = txt_cannum.Text;
                string canborrow = txt_can.Text;

               string sql = String.Format(@"update bookTable set BookName = '{0}' , Publisher = '{1}' , Author = '{2}' , CollectionNum = '{3} ', CanBorrowNum = '{4}' , CanBorrow = '{5}'  where ISBN = '{6}'",
                                        bookname, publisher, author, collectionNum, canborrowNum, canborrow,bookid);
                ExecuteSql(sql);
                MessageBox.Show("编辑成功");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
            this.Close();

        }

        private void txt_can_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
