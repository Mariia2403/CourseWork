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
            btnSave.Click -= btnSave_Click;
            btnSave.Click += btnSave_Click;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           bool isValidInput = false;
            
            while (!isValidInput)
            {
                string transportType = cmbTransport.SelectedItem.ToString();//яке значення тут отримується?
                string conditionType = cmbSpecialCond.SelectedItem.ToString();



                if ((!double.TryParse(textVolume.Text, out double volume) || volume <= 0))
                {
                    MessageBox.Show("Enter the correct volume.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!double.TryParse(txtWeight.Text, out double weight) || weight <= 0)//чи потрібно тут перевіряти чи менше за нуль,
                                                                                       //якщов мене вже записано у властивостях
                {
                    MessageBox.Show("Enter the correct weight of the cargo.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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



                try
                {

                    SelectedTransport.Weight = weight;
                    SelectedTransport.Volume = volume;
                    SelectedTransport.SpecialCondition = conditionType;
                    if (!SelectedTransport.ex)
                    {
                        isValidInput = true;
                        break;
                    }

                    return;
                }
                catch (Exception ex )
                {
                    MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
                    this.DialogResult = DialogResult.OK;// що означає ?
                    this.Close();
        }


    }
}
