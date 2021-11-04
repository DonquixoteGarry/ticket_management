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
    public partial class TicketChange : Form
    {
        public TicketChange()
        {
            InitializeComponent();
        }

        public MySqlConnection getmysqlcon()
        {
            string sql = "server=localhost;user id=root;password=123456;database=ticket_db;allowuservariables=True;";
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

        private void button1_Click(object sender, EventArgs e)
        {
            string change_ticketid="'"+TxtChange_Ticketid.Text.Trim()+"'";
            string change_sql1 = 
                "select * from ticketinfo where ticketid= " + change_ticketid+";";

            MySqlConnection con1 = getmysqlcon();
            MySqlCommand change_1 = new MySqlCommand(change_sql1, con1);
            con1.Open();
            MySqlDataReader change_flag1 = change_1.ExecuteReader();
            if(!change_flag1.Read())
            {
                MessageBox.Show("该车票不存在!");
                con1.Close();
                System.Environment.Exit(0);
            }
            con1.Close();
           
            string ScheduleStart = " ScheduleStart='" + TxtChange_StartTime.Text.Trim() + "'";
            string ScheduleEnd = " ScheduleEnd='" + TxtChange_EndTime.Text.Trim() + "'"; 
            string change_sql3 = " select scheduleid from scheduleinfo where"
                + ScheduleStart + " and " + ScheduleEnd + ";";

            MySqlConnection con3 = getmysqlcon();
            MySqlCommand change_3 = new MySqlCommand(change_sql3, con3);
            con3.Open();
            MySqlDataReader change_flag3 = change_3.ExecuteReader();
            if (!change_flag3.Read())
            {
                MessageBox.Show("该时间安排不存在!");
                con3.Close();
                System.Environment.Exit(0);
            }
            string find_scheduleid = "'" + change_flag3[0].ToString() + "'";
            con3.Close();

            MySqlConnection con4 = getmysqlcon();
            string change_sql4 =
                "call changeinfo(" + change_ticketid + "," + find_scheduleid + ",@p);" +
                "select@p;";
            MySqlCommand change_4 = new MySqlCommand(change_sql4, con4);
            con4.Open();
            MySqlDataReader change_flag4 = change_4.ExecuteReader();
            string a = "";
            if (change_flag4.Read())
            {
                a = a+change_flag4[0].ToString();
            }
            MessageBox.Show(a);
            con4.Close();
            System.Environment.Exit(0);
        }
    }
}
