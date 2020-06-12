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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            string inputAccount = account.Text.Trim();
            string inputPassword = password.Text;
            int inputIdentity = (identity.Text == "admin") ? 0 : 1;

            if (String.IsNullOrEmpty(inputAccount) || String.IsNullOrEmpty(inputPassword))
            {
                if (MessageBox.Show("请先把信息填写完整！", "提示") == DialogResult.OK)
                    return;
            }

            string connectionString = "server=localhost;database=XMULibrary;uid=t1;pwd=123456";
            SqlConnection con = new SqlConnection(connectionString);

            string role;
            if (inputIdentity == 0) role = "admin";
            else role = "reader";
            string registerTran = String.Format(@"begin tran 
                                    SET XACT_ABORT ON 
                                    create login {0} with password='{1}', default_database=XMULibrary 
                                    create user {2} for login {3} 
                                    exec sp_addrolemember '{4}', '{5}' 
                                    insert into loginTable values('{6}', '{7}', '{8}') 
                                    commit tran",
                                    inputAccount, inputPassword, inputAccount, inputAccount, role, inputAccount, inputAccount, inputPassword, identity.Text);



            SqlCommand registerCmd = new SqlCommand(registerTran, con);

            try
            {
                con.Open();
                registerCmd.ExecuteNonQuery();
            }
            catch (SqlException exception)
            {
                //throw new Exception(exception.Message);
                if (MessageBox.Show(exception.Message, "错误") == DialogResult.OK)
                {
                    con.Close();
                    registerCmd.Dispose();
                    return;
                }
            }
            finally
            {
                registerCmd.Dispose(); //对SqlCommand进行处理，回收
            }

            string addRole = String.Format("exec sp_addsrvrolemember '{0}', 'securityadmin' ", inputAccount);
            if (inputIdentity == 0) addRole += String.Format("exec sp_addrolemember 'db_accessadmin','{0}'", inputAccount);
            SqlCommand addSrvRoleCmd = new SqlCommand(addRole, con);
            try
            {
                addSrvRoleCmd.ExecuteNonQuery();
            }
            catch (SqlException exception)
            {
                if (MessageBox.Show(exception.Message, "错误") == DialogResult.OK)
                {
                    con.Close();
                    addSrvRoleCmd.Dispose();
                    return;
                }
            }

            if (MessageBox.Show("注册成功！", "提示") == DialogResult.OK)
            {
                con.Close();
                addSrvRoleCmd.Dispose();
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
