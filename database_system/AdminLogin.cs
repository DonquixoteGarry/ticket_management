using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace 票务交易系统
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        public MySqlConnection getmysqlcon()
        {
            string sql = "server=localhost;user id=root;password=123456;database=ticket_db;allowuservariables=True;"; //根据自己的设置
            MySqlConnection conn = new MySqlConnection(sql);

            return conn;
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
          

            if (TxtUsername.Text == "" || TxtPassword.Text == "")
            {
                MessageBox.Show("管理员ID或者密码都不能为空！");
                return;
            }
            else
            {
                MySqlConnection ms = getmysqlcon();
                string selectSql = "select AdminID,AdminPassword from AdminInfo where AdminID = '" + TxtUsername.Text.Trim() + "' and AdminPassword = '" + TxtPassword.Text.Trim() + "'";
                MySqlCommand mySqlCommand = new MySqlCommand(selectSql, ms);
                ms.Open();

                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    String AdminID = reader[0].ToString();
                    MessageBox.Show("管理员 " + AdminID + " 成功登录！");
                    this.Hide();
                    var _MainScreen = new MainScreen();
                    this.Hide();
                    _MainScreen.ShowDialog();
                    return;
                }
                if (reader.Read() == false)
                {
                    MessageBox.Show("该用户不存在,或用户名密码有错误");
                }
                ms.Close();
            }
        }
    }
}
