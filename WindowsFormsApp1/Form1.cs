using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        }
    }
}
