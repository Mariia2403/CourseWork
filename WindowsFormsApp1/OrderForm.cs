using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class OrderForm : Form
    {
        public Transport SelectedTransport { get; private set; }//чому тут приватний set та що таке internal 
        public OrderForm()
        {
            InitializeComponent();

            cmbTransport.SelectedIndex = 0;
            btnSave.Click += btnSave_Click;//що означає?

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string transportType = cmbTransport.SelectedItem.ToString();//яке значення тут отримується?

            double weight;
            double volume;

            if ((!double.TryParse(textVolume.Text, out volume) || volume <= 0))
            {
                MessageBox.Show("Enter the correct volume.");
                return;
            }
            if (!double.TryParse(txtWeight.Text, out weight) || weight <= 0)//чи потрібно тут перевіряти чи менше за нуль,
                                                                            //якщов мене вже записано у властивостях
            {
                MessageBox.Show("Enter the correct weight of the cargo.");
                return;
            }

            //поліморфізм
            switch (transportType)
            {
                case "Gazell":
                    SelectedTransport = new Gazell();
                    break;

                case "Track":
                    SelectedTransport = new Track();
                    break;
                case "Beads":
                    SelectedTransport = new Beads();
                    break;

                default:
                    MessageBox.Show("Choose the type of transport");
                    return;
            }

            SelectedTransport.Weight = weight;
            SelectedTransport.Volume = volume;

            this.DialogResult = DialogResult.OK;// що означає ?
            this.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
