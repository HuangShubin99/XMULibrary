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
    public partial class EditReader : Form
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
        public EditReader()
        {
            InitializeComponent();
        }

        public EditReader(string inputreaderid)
        {
            InitializeComponent();

            //获取在main中选中的各字段信息显示在文本框中
            txt_rid.Text = inputreaderid;
            string readerid = inputreaderid;
            string sql = "SELECT ReaderName,Sex,JobTitle,CanBorrowNum,BorrowedNum,Department,PhoneNumber FROM readerTable "
    + " WHERE ReaderId ='" + readerid + "'";
            DataSet dataSet = Query(sql);
            if (dataSet != null && dataSet.Tables[0].Rows.Count > 0)
            {

                this.txt_rname.Text = dataSet.Tables[0].Rows[0]["ReaderName"].ToString();
                this.txt_sex.SelectedItem = dataSet.Tables[0].Rows[0]["Sex"];
                this.txt_job.Text = dataSet.Tables[0].Rows[0]["JobTitle"].ToString();
                this.txt_cbn.Text = dataSet.Tables[0].Rows[0]["Department"].ToString();
                this.txt_cbn.Text = dataSet.Tables[0].Rows[0]["CanBorrowNum"].ToString();
                this.txt_bn.Text = dataSet.Tables[0].Rows[0]["BorrowedNum"].ToString();
                this.txt_phone.Text = dataSet.Tables[0].Rows[0]["PhoneNumber"].ToString(); 
                this.txt_dep.Text = dataSet.Tables[0].Rows[0]["Department"].ToString();
            }
        }

        private void EditReader_Load(object sender, EventArgs e)
        {
            

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            try
            {
                string readerid = txt_rid.Text.Trim();
                string rname = txt_rname.Text.Trim();
                string sex = txt_sex.Text.Trim();
                string jobTitle = txt_job.Text.Trim();
                string canBorrowNum = txt_cbn.Text.Trim();
                string borrowedNum = txt_bn.Text.Trim();
                string department = txt_dep.Text.Trim();
                string phone = txt_phone.Text.Trim();
                string sql = String.Format(@"update readerTable set ReaderName = '{0}' , Sex = '{1}' , JobTitle = '{2}' , CanBorrowNum = '{3}' , BorrowedNum = '{4}' , Department = '{5}' , PhoneNumber = '{6}' where ReaderId = '{7}'"
                    ,rname,sex,jobTitle,canBorrowNum,borrowedNum,department,phone,readerid);
                EditReader.ExecuteSql(sql);
                MessageBox.Show("编辑成功");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
