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
    public partial class Search : Form
    {
        public Search()
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
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string search_ticketid = "'" + TxtSearch.Text.Trim() + "'";
            string find =
                "select * from ticketinfo where ticketid=" + search_ticketid + ";";
            MySqlConnection con_find = getmysqlcon();
            MySqlCommand _find= new MySqlCommand(find, con_find);
            con_find.Open();
            MySqlDataReader reader1= _find.ExecuteReader();
            if(!reader1.Read())
            {
                con_find.Close();
                MessageBox.Show("该车票不存在!");
                System.Environment.Exit(0);
            }

            string drop = "drop view if exists `ticketallinfo`; ";
            
            MySqlConnection con_drop = getmysqlcon();
            MySqlCommand _drop= new MySqlCommand(drop, con_drop);
             con_drop.Open();
            int s=_drop.ExecuteNonQuery();
            con_drop.Close();

            string search_sql1 =
                "create view ticketallinfo as " +
                "select ticketbuyer,routestart,routeend,schedulestart,scheduleend " +
                "from routeinfo,scheduleinfo,ticketinfo " +
                "where routeid = ticketrouteid and scheduleid = ticketscheduleid" +
                " and ticketid =" + search_ticketid + " ;select * from ticketallinfo;";
            MySqlConnection con1 = getmysqlcon();
            con1.Open();
            MySqlCommand cmd_search = new MySqlCommand(search_sql1, con1);
            MySqlDataReader search1 = cmd_search.ExecuteReader();
            while (search1.Read())
            {
                int index = this.View1.Rows.Add();
                this.View1.Rows[index].Cells[0].Value = search1[0].ToString();
                this.View1.Rows[index].Cells[1].Value = search1[1].ToString();
                this.View1.Rows[index].Cells[2].Value = search1[2].ToString();
                this.View1.Rows[index].Cells[3].Value = search1[3].ToString();
                this.View1.Rows[index].Cells[4].Value = search1[4].ToString();
            }
        }

        private void View1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {

        }
    }
}
