using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView1.RowPostPaint += dataGridView1_RowPostPaint;
            // button1.Click += button1_Click; //що це означає?
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();

            if (orderForm.ShowDialog() == DialogResult.OK)//Що це означає
            {
                Transport transport = orderForm.SelectedTransport;

                dataGridView1.Rows.Add(transport.GetTransportType(),

                transport.CalculateTransportationCost());


            }
        }

        //як додавати нумерацію запуталась не розібралась 
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string rowNumber = (e.RowIndex + 1).ToString();//отримуємо немер рядка тут,
                                                           //1 додаємо щоб не розпочиналось з нуля

            var grid = sender as DataGridView;
            var rowHeaderBounds = new System.Drawing.Rectangle(e.RowBounds.Left,
                                                               e.RowBounds.Top,
                                                               grid.RowHeadersWidth,
                                                               e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics,
                                   rowNumber,
                                   grid.Font,
                                   rowHeaderBounds,
                                   Color.Black,
                                   TextFormatFlags.VerticalCenter |
                                   TextFormatFlags.HorizontalCenter);

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count) //що означає
            {
                string transport = dataGridView1.Rows[rowIndex].Cells["Transport"].Value.ToString();

                string weight = dataGridView1.Rows[rowIndex].Cells["Weight"].Value.ToString();

                MessageBox.Show($"Детальна інформація про замовлення:\n" +
                               $"Транспорт: {transport}\n" +
                               $"Вага вантажу: {weight} кг",
                               "Деталі замовлення",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
        }
    }
}
