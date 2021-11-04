using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 票务交易系统
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            var BuyScreen = new Buy();
            this.Hide();
            BuyScreen.Show();
        }

        private void BtnRefund_Click(object sender, EventArgs e)
        {
            var RefundScreen = new Refund();
            this.Hide();
            RefundScreen.Show();
        }


        private void LblBuyInfo_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var Search = new Search();
            this.Hide();
            Search.Show();
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            var TicketChange = new TicketChange();
            this.Hide();
            TicketChange.Show(); 
        }
    }
}
