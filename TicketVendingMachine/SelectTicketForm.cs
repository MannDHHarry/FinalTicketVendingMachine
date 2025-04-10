using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketVendingMachine
{
    public partial class SelectTicketForm : Form
    {
        private int ticketCount = 0;
        private const int ticketPrice = 5000;
        public SelectTicketForm()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            ticketCount++;
            UpdateUI();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (ticketCount > 0)
            {
                ticketCount--;
                UpdateUI();
            }
        }

        private void UpdateUI()
        {
            lblTicketCount.Text = ticketCount.ToString();
            lblTotalCost.Text = $"Total: {ticketCount * ticketPrice} VND";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (ticketCount == 0)
            {
                MessageBox.Show("Please select at least one ticket.");
                return;
            }

            MessageBox.Show($"You selected destination: {SelectionDestination.SelectedDestination}\nNumber of tickets: {ticketCount}\nTotal cost: ${ticketCount * ticketPrice}");
        }
    }
}
