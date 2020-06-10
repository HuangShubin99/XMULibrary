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
    public partial class AddBook : Form
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
        public AddBook()
        {
            InitializeComponent();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            try
            {
                string bookid = txt_isbn.Text.Trim();
                string bookname = txt_bname.Text.Trim();
                string publisher = txt_publish.Text.Trim();
                string author = txt_author.Text.Trim();
                string collectionNum = txt_collection.Text.Trim();
                string canborrowNum = txt_cannum.Text.Trim();
                string canborrow = txt_can.Text.Trim();

                string sql = String.Format(@"insert into bookTable
                                        values( '{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                                       bookid, bookname, publisher, author, collectionNum, canborrowNum,canborrow);
                ExecuteSql(sql);
                MessageBox.Show("添加成功");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            this.Close();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }
    }
}
