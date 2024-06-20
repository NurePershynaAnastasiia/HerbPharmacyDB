using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class EditCardForm : Form
    {
        public EditCardForm()
        {
            InitializeComponent();
            client_CardTableAdapter.Fill(this.medicinalPlantAphotecaryDataSet.Client_Card);
            edit = false;
        }
        /// <summary>
        /// Id хвороби
        /// </summary>
        private readonly int id;
        /// <summary>
        /// true - если запись модифицируется, false - если создаётся новая
        /// </summary>
        readonly bool edit;

        public EditCardForm(int id, string name, int discount, string card_type, DateTime date) : this()
        {
            client_CardTableAdapter.Fill(this.medicinalPlantAphotecaryDataSet.Client_Card);

            edit = true;

            this.id = id;
            nameTextBox.Text = name;
            discountTextBox.Text = discount.ToString();
            switch (card_type)
            {
                case "Silver":
                    cardTypeComboBox.SelectedIndex = 0;
                    break;
                case "Gold":
                    cardTypeComboBox.SelectedIndex = 1;
                    break;
                case "Platinum":
                    cardTypeComboBox.SelectedIndex = 2;
                    break;
                default:
                    cardTypeComboBox.SelectedIndex = 0;
                    break;
            }
            registerDateTimePicker.Value = date;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || discountTextBox.Text == "")
                MessageBox.Show("Введіть дані");
            else if (Convert.ToInt32(discountTextBox.Text) < 0 || Convert.ToInt32(discountTextBox.Text) > 100)
                MessageBox.Show("Введіть коректну знижку");
            else if (registerDateTimePicker.Value > DateTime.Now)
            {
                MessageBox.Show("Введіть коректну дату");
                return;
            }
            else
            {
                string card_type = "";
                if (cardTypeComboBox.SelectedIndex == 0)
                {
                    card_type = "Silver";
                }
                else if (cardTypeComboBox.SelectedIndex == 1)
                {
                    card_type = "Gold";
                }
                else if (cardTypeComboBox.SelectedIndex == 2)
                {
                    card_type = "Platinum";
                }
                if (edit)
                {
                    client_CardTableAdapter.UpdateQuery(nameTextBox.Text, Convert.ToInt32(discountTextBox.Text), card_type, Convert.ToDateTime(registerDateTimePicker.Value), id);
                }
                else
                {
                    client_CardTableAdapter.Insert(nameTextBox.Text, Convert.ToInt32(discountTextBox.Text), card_type, Convert.ToDateTime(registerDateTimePicker.Value));
                }
                Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
