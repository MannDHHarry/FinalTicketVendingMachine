using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DestinationBLL;

namespace TicketVendingMachine
{
    public partial class SelectionDestination : Form
    {
        public static string SelectedDestination { get; set; }

        BLL bll = new BLL();
        public SelectionDestination()
        {
            InitializeComponent();
            LoadDestinations();

        }

        private void LoadDestinations()
        {
            var destinations = bll.GetDestinations();
            foreach (var d in destinations)
            {
                comboBoxDestinations.Items.Add(d);
            }
        }

        private void SelectionDestination_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (comboBoxDestinations.SelectedItem != null)
            {
                SelectedDestination = comboBoxDestinations.SelectedItem.ToString();
                SelectTicketForm ticketForm = new SelectTicketForm(); // or pass it via constructor
                ticketForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a destination.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
