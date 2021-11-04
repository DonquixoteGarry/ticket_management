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
    public partial class Buy : Form
    {
        public Buy()
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

        private void BtnExecuteBuy_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            string random_tickectid = ran.Next(100, 1000).ToString();
            string _a ="'"+ TxtUserName_Buy.Text.ToString()+"'" ;
            string _b =TxtUserStartTime_Buy.Text.ToString();
            string _c =TxtUserEndTime_Buy.Text.ToString();
            string _d =TxtUserStartSta_Buy.Text.ToString();
            string _f = TxtUserEndSta_Buy.Text.ToString();
            string a = "'" + _a + "'";
            string b = "'" + _b + "'";
            string c = "'" + _c + "'";
            string d = "'" + _d + "'";
            string f = "'" + _f + "'";

            if (TxtUserEndSta_Buy.Text == "" || TxtUserEndTime_Buy.Text == "" 
                || TxtUserName_Buy.Text == "" || TxtUserStartSta_Buy.Text == "" 
                || TxtUserStartTime_Buy.Text == "")
            {
                MessageBox.Show("任意一项都不能为空！");
                return;
            }
            else
            {

                string f1 = "select scheduleid from scheduleinfo where"
                + " schedulestart = " + b
                + " and scheduleend = " + c + ";";
                MySqlConnection con1 = getmysqlcon();
                MySqlCommand f__1 = new MySqlCommand(f1, con1);
                con1.Open();
                MySqlDataReader f_1 = f__1.ExecuteReader();
                if (!f_1.Read())
                {
                    MessageBox.Show("时间安排不存在");
                    System.Environment.Exit(0);
                }
                string the_schedule = "'"+f_1[0].ToString()+"'";
                con1.Close();

                string f2 = "select routeid from routeinfo where routestart = " + d
                                + " and routeend = " + f + ";";
                MySqlConnection con2 = getmysqlcon();
                MySqlCommand f__2 = new MySqlCommand(f2, con2);
                con2.Open();
                MySqlDataReader f_2 = f__2.ExecuteReader();
                if (!f_2.Read())
                {
                    MessageBox.Show("路线安排不存在");
                    System.Environment.Exit(0);
                }
                string the_route = "'" + f_2[0].ToString() + "'";
                con2.Close();

                string Sql1 = 
                    " select ticketid from ticketinfo where  ticketBuyer = " +_a
                + " and ticketscheduleid= " + the_schedule
                + " and ticketrouteid= " + the_route + ";";

                MySqlConnection ms1 = getmysqlcon();
                MySqlCommand mySqlCommand1 = new MySqlCommand(Sql1, ms1);
                ms1.Open();
                MySqlDataReader reader1 = mySqlCommand1.ExecuteReader();

                if (reader1.Read())
                {
                    MessageBox.Show("重复购票失败!");
                    ms1.Close();
                    System.Environment.Exit(0);
                    return;
                }
                else
                {
                    ms1.Close();
                    string Sql2 =
                   " insert  into ticketinfo (ticketid,ticketscheduleid,ticketrouteid,ticketbuyer) "
                   + "VALUES (("+random_tickectid+"),"
                   + "("+the_schedule+"),"
                   + "(" + the_route + "),"
                   + "(" + _a + "));";

                    MySqlConnection ms2 = getmysqlcon();
                    MySqlCommand mySqlCommand2 = new MySqlCommand(Sql2, ms2);
                    ms2.Open();
                    int k=mySqlCommand2.ExecuteNonQuery();
                    ms2.Close();
                    string news = "用户" + _a + "成功购买该车票!\n"
                        + "车辆运行时间:"+_b + "-->" + _c + "\n" +
                        "车辆运行区间" + _d + "-->" + _f+"\n"+"车票编号为:"+random_tickectid;
                    MessageBox.Show(news);
                    System.Environment.Exit(0);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
