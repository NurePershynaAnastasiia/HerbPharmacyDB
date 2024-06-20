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
    public partial class EditPurchaseForm : Form
    {
        public EditPurchaseForm()
        {
            InitializeComponent();
            purchaseTableAdapter.Fill(this.medicinalPlantAphotecaryDataSet.Purchase);
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


        public EditPurchaseForm(int id, DateTime date, decimal sum, int? card) : this()
        {
            purchaseTableAdapter.Fill(this.medicinalPlantAphotecaryDataSet.Purchase);
            client_CardTableAdapter.Fill(this.medicinalPlantAphotecaryDataSet.Client_Card);

            edit = true;

            this.id = id;
            sumTextBox.Text = sum.ToString();
            dateTextBox.Text = date.ToString();
            if (card != null)
                cardComboBox.SelectedValue = card;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                purchaseTableAdapter.UpdateQuery(dateTextBox.Text, Convert.ToDecimal(sumTextBox.Text), Convert.ToInt32(cardComboBox.SelectedValue), id);
            }
            else
            {
                purchaseTableAdapter.Insert(Convert.ToDateTime(dateTextBox.Text), Convert.ToDecimal(sumTextBox.Text), Convert.ToInt32(cardComboBox.SelectedValue));
            }
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditPurchaseForm_Load(object sender, EventArgs e) { }

    }
}
