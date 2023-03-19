using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.DataVisualization.Charting;
using System.Reflection.Emit;

namespace StockMarket
{
    public partial class Form1 : Form
    {
        SqlConnection cs = new SqlConnection("Data Source=LAPTOP-KT7UFLKK\\SQLEXPRESS;Initial Catalog=StockMarket;Integrated Security=True");  
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0; 
            button3.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0; 
            button1.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0; 
            button2.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button6.FlatAppearance.BorderSize = 0; 
            button6.FlatStyle = FlatStyle.Flat;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;

           
            Color darkBlue = Color.FromArgb(22, 26, 30);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.BackgroundColor = darkBlue;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.GridColor = darkBlue;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.RowsDefaultCellStyle.BackColor = darkBlue;
            dataGridView1.RowsDefaultCellStyle.SelectionBackColor = Color.LightGray;
            dataGridView1.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = darkBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Font poppinsLight = new Font("Poppins Light", 10);
            dataGridView1.Font = poppinsLight;
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;
            dataGridView1.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;
            dataGridView1.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.Single;
            dataGridView1.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.Single;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.GridColor = Color.DarkSlateGray;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;

           
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.BackgroundColor = darkBlue;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView2.GridColor = darkBlue;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.RowsDefaultCellStyle.BackColor = darkBlue;
            dataGridView2.RowsDefaultCellStyle.SelectionBackColor = Color.LightGray;
            dataGridView2.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = darkBlue;
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView2.Font = poppinsLight;
            dataGridView2.DefaultCellStyle.ForeColor = Color.White;
            dataGridView2.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single;
            dataGridView2.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;
            dataGridView2.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.Single;
            dataGridView2.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.Single;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.GridColor = Color.DarkSlateGray;
            dataGridView2.RowHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;


        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.SelectCommand = new SqlCommand("SELECT * FROM Stock", cs);
            ds.Clear();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            SqlDataAdapter da2 = new SqlDataAdapter();
            DataSet ds2 = new DataSet();
            da2.SelectCommand = new SqlCommand("SELECT * FROM Trade", cs);
            ds2.Clear();
            da2.Fill(ds2);
            dataGridView2.DataSource = ds2.Tables[0];

            // Set up the chart properties
            chart1.Series.Clear();
            chart1.Series.Add("MySeries");
            chart1.Series["MySeries"].ChartType = SeriesChartType.Line;
            chart1.Series["MySeries"].XValueType = ChartValueType.Date;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd/yyyy";
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
            chart1.ChartAreas[0].AxisX.Interval = 1;

            chart1.BackColor = System.Drawing.ColorTranslator.FromHtml("#161a1e");

            // Connect to your database and retrieve the data
            string query = "SELECT date, price FROM Trade";
            SqlCommand command = new SqlCommand(query, cs);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            // Add the data to the chart
            foreach (DataRow row in table.Rows)
            {
                DateTime date = (DateTime)row["date"];
                decimal price = (decimal)row["price"];
                chart1.Series["MySeries"].Points.AddXY(date, price);
            }
            chart1.Series["MySeries"].Color = System.Drawing.ColorTranslator.FromHtml("#77ff00");
            // Set the color of the x-axis labels to white
            chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;

            // Set the color of the y-axis labels to white
            chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chart1.ChartAreas[0].BackColor = System.Drawing.ColorTranslator.FromHtml("#161a1e");
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.ColorTranslator.FromHtml("#363636");

            // Set the color of the y-axis grid to #363636
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.ColorTranslator.FromHtml("#363636");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.SelectCommand = new SqlCommand("SELECT * FROM Stock", cs);
            ds.Clear();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.SelectCommand = new SqlCommand("SELECT * FROM Trade", cs);
            ds.Clear();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }
        private void dataGridView2_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewCell buySellCell = dataGridView2.Rows[e.RowIndex].Cells["buy_sell"];
            if (buySellCell != null && buySellCell.Value != null)
            {
                string buySellValue = buySellCell.Value.ToString();

                // Set the row's text color based on the "buy_sell" value
                if (buySellValue == "buy")
                {
                    dataGridView2.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.LimeGreen;
                }
                else if (buySellValue == "sell")
                {
                    dataGridView2.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void button5_click(object sender, EventArgs e)
        {
            addStockForm addForm = new addStockForm();
            addForm.ShowDialog();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = new SqlCommand("INSERT INTO Stock(stock_id, name, symbol) VALUES(@ID, @NAME, @SYMBOL)", cs);
                da.InsertCommand.Parameters.Add("@ID", SqlDbType.Int).Value = addForm.stock_id;
                da.InsertCommand.Parameters.Add("@NAME", SqlDbType.VarChar, 50).Value = addForm.stock_name;
                da.InsertCommand.Parameters.Add("@SYMBOL", SqlDbType.VarChar, 10).Value = addForm.stock_symbol;
                cs.Open();
                da.InsertCommand.ExecuteNonQuery();
                cs.Close();
            }
            catch(Exception ex) { 
                MessageBox.Show(ex.Message);
                cs.Close();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string stock_id = selectedRow.Cells["stock_id"].Value.ToString();

                addTrade addT = new addTrade("BUY STOCK", "Buy Stock");
                addT.ShowDialog();

                try
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.InsertCommand = new SqlCommand("INSERT INTO Trade(trade_id, user_id, stock_id, date, buy_sell, price, quantity) VALUES(@T_ID, @U_ID, @S_ID, @DATE, @BUY_SELL, @PRICE, @QUANTITY)", cs);
                    da.InsertCommand.Parameters.Add("@T_ID", SqlDbType.Int).Value = addT.trade_id;
                    da.InsertCommand.Parameters.Add("@U_ID", SqlDbType.Int).Value = addT.user_id;
                    da.InsertCommand.Parameters.Add("@S_ID", SqlDbType.Int).Value = stock_id;
                    da.InsertCommand.Parameters.Add("@DATE", SqlDbType.Date).Value = DateTime.Now;
                    da.InsertCommand.Parameters.Add("@BUY_SELL", SqlDbType.VarChar, 10).Value = "buy";
                    da.InsertCommand.Parameters.Add("@PRICE", SqlDbType.Decimal).Value = addT.price;
                    da.InsertCommand.Parameters.Add("@QUANTITY", SqlDbType.Int).Value = addT.quantity;

                    cs.Open();
                    da.InsertCommand.ExecuteNonQuery();
                    cs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cs.Close();
                }

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string stock_id = selectedRow.Cells["stock_id"].Value.ToString();

                addTrade addT = new addTrade("SELL STOCK", "Sell Stock");
                addT.ShowDialog();

                try
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.InsertCommand = new SqlCommand("INSERT INTO Trade(trade_id, user_id, stock_id, date, buy_sell, price, quantity) VALUES(@T_ID, @U_ID, @S_ID, @DATE, @BUY_SELL, @PRICE, @QUANTITY)", cs);
                    da.InsertCommand.Parameters.Add("@T_ID", SqlDbType.Int).Value = addT.trade_id;
                    da.InsertCommand.Parameters.Add("@U_ID", SqlDbType.Int).Value = addT.user_id;
                    da.InsertCommand.Parameters.Add("@S_ID", SqlDbType.Int).Value = stock_id;
                    da.InsertCommand.Parameters.Add("@DATE", SqlDbType.Date).Value = DateTime.Now;
                    da.InsertCommand.Parameters.Add("@BUY_SELL", SqlDbType.VarChar, 10).Value = "sell";
                    da.InsertCommand.Parameters.Add("@PRICE", SqlDbType.Decimal).Value = addT.price;
                    da.InsertCommand.Parameters.Add("@QUANTITY", SqlDbType.Int).Value = addT.quantity;

                    cs.Open();
                    da.InsertCommand.ExecuteNonQuery();
                    cs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cs.Close();
                }

            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string stock_id = selectedRow.Cells["stock_id"].Value.ToString();


                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = new SqlCommand("SELECT * FROM Trade WHERE stock_id = @STOCK_ID", cs);
                da.SelectCommand.Parameters.Add("@STOCK_ID", SqlDbType.Int).Value = int.Parse(stock_id);
                ds.Clear();
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];

                
            }
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string stock_id = selectedRow.Cells["stock_id"].Value.ToString();

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = new SqlCommand("SELECT TOP 1 * FROM Price WHERE stock_id = @STOCK_ID", cs);
                da.SelectCommand.Parameters.Add("@STOCK_ID", SqlDbType.Int).Value = int.Parse(stock_id);
                ds.Clear();
                DataTable table = new DataTable();
                da.Fill(table);

                // Add the data to the chart
                foreach (DataRow row in table.Rows)
                {
                    high_price.Text = ((decimal)row["high_price"]).ToString("0.00");
                    low_price.Text = ((decimal)row["low_price"]).ToString("0.00");
                    open_price.Text = ((decimal)row["open_price"]).ToString("0.00");
                    close_price.Text = ((decimal)row["close_price"]).ToString("0.00");
                    volume.Text = ((int)row["volume"]).ToString();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(dataGridView2.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                    string trade_id = selectedRow.Cells["trade_id"].Value.ToString();


                    SqlDataAdapter da = new SqlDataAdapter();
                    da.DeleteCommand = new SqlCommand("DELETE FROM Trade WHERE trade_id = @TRADE_ID", cs);
                    da.DeleteCommand.Parameters.Add("@TRADE_ID", SqlDbType.Int).Value = int.Parse(trade_id);
                    cs.Open();
                    da.DeleteCommand.ExecuteNonQuery();
                    cs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cs.Close();
                }
        }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            // Set up the chart properties
            chart1.Series.Clear();
            chart1.Series.Add("MySeries");
            chart1.Series["MySeries"].ChartType = SeriesChartType.Line;
            chart1.Series["MySeries"].XValueType = ChartValueType.Date;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "MM/dd/yyyy";
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
            chart1.ChartAreas[0].AxisX.Interval = 1;

            chart1.BackColor = System.Drawing.ColorTranslator.FromHtml("#161a1e");

            // Connect to your database and retrieve the data
            string query = "SELECT date, price FROM Trade";
            SqlCommand command = new SqlCommand(query, cs);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            // Add the data to the chart
            foreach (DataRow row in table.Rows)
            {
                DateTime date = (DateTime)row["date"];
                decimal price = (decimal)row["price"];
                chart1.Series["MySeries"].Points.AddXY(date, price);
            }
            chart1.Series["MySeries"].Color = System.Drawing.ColorTranslator.FromHtml("#77ff00");
            // Set the color of the x-axis labels to white
            chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;

            // Set the color of the y-axis labels to white
            chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chart1.ChartAreas[0].BackColor = System.Drawing.ColorTranslator.FromHtml("#161a1e");
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.ColorTranslator.FromHtml("#363636");

            // Set the color of the y-axis grid to #363636
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.ColorTranslator.FromHtml("#363636");
        }
        //--------------------------------------------------------------------


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
