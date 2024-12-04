using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArenaTicketSystem
{
    public partial class SearchPage : Form
    {
        public SearchPage()
        {
            InitializeComponent();
        }

        private void rowLabel_Click(object sender, EventArgs e)
        {

        }
        private void bookButton_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout();
            checkout.Show();
        }
    }
}
