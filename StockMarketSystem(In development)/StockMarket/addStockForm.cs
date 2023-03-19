using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StockMarket
{
    public partial class addStockForm : Form
    {
        public int stock_id { get; private set; }
        public String stock_name { get; private set; }
        public String stock_symbol { get; private set; }
        public addStockForm()
        {

            InitializeComponent();

            button5.FlatAppearance.BorderSize = 0;  // Set the border width to 0 to ensure the border is completely hidden
            button5.FlatStyle = FlatStyle.Flat;
            button7.FlatAppearance.BorderSize = 0;  // Set the border width to 0 to ensure the border is completely hidden
            button7.FlatStyle = FlatStyle.Flat;
            textBox1.BorderStyle = BorderStyle.None;
            textBox2.BorderStyle = BorderStyle.None;
            textBox3.BorderStyle = BorderStyle.None;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            stock_id = Convert.ToInt32(textBox1.Text);
            stock_name = textBox2.Text;
            stock_symbol = textBox3.Text;

            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void addStockForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
