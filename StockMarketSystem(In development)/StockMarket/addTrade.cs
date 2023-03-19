using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMarket
{
    public partial class addTrade : Form
    {
        public int trade_id { get; private set; }
        public int user_id { get; private set; }
        public decimal price { get; private set; }
        public int quantity { get; private set; }
        public addTrade(String title, String buttonLabel)
        {
            InitializeComponent();
            label3.Text = title;
            button5.Text = buttonLabel;
            button5.FlatAppearance.BorderSize = 0;  // Set the border width to 0 to ensure the border is completely hidden
            button5.FlatStyle = FlatStyle.Flat;
            button7.FlatAppearance.BorderSize = 0;  // Set the border width to 0 to ensure the border is completely hidden
            button7.FlatStyle = FlatStyle.Flat;
            textBox1.BorderStyle = BorderStyle.None;
            textBox2.BorderStyle = BorderStyle.None;
            textBox3.BorderStyle = BorderStyle.None;
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            trade_id = Convert.ToInt32(textBox4.Text);
            user_id = Convert.ToInt32(textBox1.Text);
            price = Convert.ToDecimal(textBox2.Text);
            quantity = Convert.ToInt32(textBox3.Text);

            this.Close();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void addTrade_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
