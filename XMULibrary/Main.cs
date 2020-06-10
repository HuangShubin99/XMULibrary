using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace XMULibrary
{
    public partial class XMULibrary : Form
    {
        public static XMULibrary MainForm = new XMULibrary();
        public static string str = "Data Source=WIN-6NGPCQQABM2;Initial Catalog=XMULibrary;User ID=t1;Password=123456;";
        static SqlConnection myConn = new SqlConnection(str);//创建数据库连接类的对象
        public static string DBDataSource, DBInitialCatalog, DBUserID, DBPassword;
        public static string Id, pwd,authority;
        public XMULibrary()
        {
            InitializeComponent();
            MainForm = this;
            loginname.Text = "请输入用户名";
            loginpwd.Text = "请输入密码";
            this.DoubleBuffered = true;
        }

        private void UserNamelabel_Click(object sender, EventArgs e)
        {

        }


        private void loginpwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {
            Register childrenform = new Register();
            childrenform.Owner = this;
            childrenform.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void loginname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Confirmbutton_Click(object sender, EventArgs e)
        {
            if (loginname.Text == "")
            { MessageBox.Show("用户名不能为空！", "提示"); }
            else if (loginpwd.Text == "")
            { MessageBox.Show("密码不能为空！", "提示"); }
            else
            {
                try //try...catch...异常处理语句
                {
                    if (radioButton1.Checked) {
                        myConn.Open(); //将连接打开
                                       //SQL语句：从数据库的登录表中搜索登录名，密码
                        authority = "admin";
                        string sqlstring = "select * from loginTable where UserId='" + loginname.Text + "' and Pswd ='" + loginpwd.Text + " ' and authority ='" + authority + " '";
                        //执行con对象的函数，返回一个SqlCommand类型的对象
                        SqlCommand command = new SqlCommand(sqlstring, myConn);
                        //用cmd的函数执行语句，返回SqlDataReader对象thisReader,thisReader就是返回的结果集（也就是数据库中查询到的表数据）
                        SqlDataReader thisReader = command.ExecuteReader();
                        //判断用户名及密码是否正确，对flag进行赋值
                        if (thisReader.Read())
                        {
                            Id = thisReader.GetValue(0).ToString().Trim();
                            pwd = thisReader.GetValue(1).ToString().Trim();
                            authority = thisReader.GetValue(2).ToString().Trim();
                            myConn.Close();
                            Admin AD = new Admin(Id, pwd, authority); //显示主页面
                            AD.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("请检查你的用户名和密码!");
                            loginname.Focus();
                            myConn.Close();
                        }
                    }
                    else if (radioButton2.Checked)
                    {
                        myConn.Open(); //将连接打开
                                       //SQL语句：从数据库的登录表中搜索登录名，密码
                        authority = "reader";
                        string sqlstring = "select * from loginTable where UserId='" + loginname.Text + "' and Pswd ='" + loginpwd.Text + " ' and authority ='" + authority + " '";
                        //执行con对象的函数，返回一个SqlCommand类型的对象
                        SqlCommand command = new SqlCommand(sqlstring, myConn);
                        //用cmd的函数执行语句，返回SqlDataReader对象thisReader,thisReader就是返回的结果集（也就是数据库中查询到的表数据）
                        SqlDataReader thisReader = command.ExecuteReader();
                        //判断用户名及密码是否正确，对flag进行赋值
                        if (thisReader.Read())
                        {
                            Id = thisReader.GetValue(0).ToString().Trim();
                            pwd = thisReader.GetValue(1).ToString().Trim();
                            authority = thisReader.GetValue(2).ToString().Trim();
                            myConn.Close();
                            User AD = new User(Id, pwd, authority); //显示主页面
                            AD.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("请检查你的用户名和密码!");
                            loginname.Focus();
                            myConn.Close();
                        }
                    }
                }
                catch (Exception ex2)
                {
                    MessageBox.Show("连接远程SQL数据库发生错误：" + ex2.ToString(), "错误！");
                }
            }
        }

        private void tbDBSub_Click(object sender, EventArgs e)
        {
            DBDataSource = tbDBDataSource.Text;
            DBInitialCatalog = tbDBInitialCatalog.Text;
            DBUserID = tbDBUserID.Text;
            DBPassword = tbDBPassword.Text;
            str = "Data Source=" + DBDataSource + ";Initial Catalog=" + DBInitialCatalog + ";User ID=" + DBUserID + ";Password=" + DBPassword + ";";
            myConn = new SqlConnection(str);//创建数据库连接类的对象
            try { myConn.Open(); }
            catch (Exception)
            { MessageBox.Show("连接失败", "提示"); }
            finally
            {
                myConn.Close();
            }
        }
    }
    }

