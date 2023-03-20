using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fill_Click(object sender, EventArgs e)
        {
            wishList.Items.Add("Gaming PC");
            wishList.Items.Add("Pet Doggie");
            wishList.Items.Add("Trip to Japan");
            wishList.Items.Add("Money");
            wishList.Items.Add("Neko");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void wishList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectionBox.Text = wishList.Text;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void sort_Click(object sender, EventArgs e)
        {
            wishList.Sorted = true;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            wishList.Items.Clear();
        }

        private void count_Click(object sender, EventArgs e)
        {
            countBox.Text = Convert.ToString(wishList.Items.Count);
        }

        private void countBox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void selectionBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
