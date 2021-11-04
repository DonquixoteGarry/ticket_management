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
    public partial class Refund : Form
    {
        public Refund()
        {
            InitializeComponent();
        }

    public MySqlConnection getmysqlcon()
    {
        string sql = "server=localhost;user id=root;password=123456;database=ticket_db;allowuservariables=True;";
            //根据自己的设置
        MySqlConnection conn = new MySqlConnection(sql);
        return conn;
        try
        {
            conn.Open();
            if (conn.State == ConnectionState.Open){}
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

        private void BtnRefund_Click(object sender, EventArgs e)
        {
            string refund_ticketid = "'"+TxtRefund.Text.Trim()+"'";
            string refund_sql1 = "select ticketinfo.ticketid,userinfo.userisvip" 
                +" from ticketinfo,userinfo where "
                + "ticketinfo.ticketid=" + refund_ticketid
                + " and ticketinfo.ticketbuyer=userinfo.username;";

            MySqlConnection con1 = getmysqlcon();
            MySqlCommand refund_1 = new MySqlCommand(refund_sql1, con1);
            con1.Open();
            MySqlDataReader refund1 = refund_1.ExecuteReader();
            if(!refund1.Read())
            {
                MessageBox.Show("该票不存在");
                con1.Close();
                System.Environment.Exit(0);
            }
            else
            {
                if(refund1[1].ToString()=="0")
                {
                    MessageBox.Show("该票购买者无VIP用户资格,无法退票");
                    con1.Close();
                    System.Environment.Exit(0);
                }
                else
                {
                    con1.Close();
                    string refund_sql2 = 
                        "begin;" +
                        "DELETE FROM ticketinfo " +
                        "WHERE ticketid ="+refund_ticketid+";" +
                        "commit;";
                    MySqlConnection con2 = getmysqlcon();
                    MySqlCommand refund2 = new MySqlCommand(refund_sql2, con2);
                    con2.Open();
                    int flag = refund2.ExecuteNonQuery();
                    if (flag == 1)
                    {
                        MessageBox.Show("用户成功退票!");
                        con2.Close();
                        System.Environment.Exit(0);
                    }
                    else
                    {
                        MessageBox.Show("用户退票失败!");
                        con2.Close();
                        System.Environment.Exit(0);
                    }
                }
            }
        }
    }
}
