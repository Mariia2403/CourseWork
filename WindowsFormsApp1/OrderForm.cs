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

            if (!double.TryParse(txtWeight.Text, out weight) || weight <= 0)//чи потрібно тут перевіряти чи менше за нуль,
                                                                            //якщов мене вже записано у властивостях
            {
                MessageBox.Show("Введіть коректну вагу вантажу.");
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

                default:
                    MessageBox.Show("Choose the type of transport");
                    return;
            }

            SelectedTransport.Weight = weight;
            this.DialogResult = DialogResult.OK;// що означає ?
            this.Close();
            
        }
    }
}
