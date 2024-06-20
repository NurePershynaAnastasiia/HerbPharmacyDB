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
    public partial class EditMedicinalPlantForm : Form
    {
        public EditMedicinalPlantForm()
        {
            InitializeComponent();
            medicinal_PlantTableAdapter.Fill(this.medicinalPlantAphotecaryDataSet.Medicinal_Plant);
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
        /// <summary>
        /// конструктор формы, для создания новой записи
        /// </summary>

        public EditMedicinalPlantForm(int id, string name, string latin_name, string classification) : this()
        {
            medicinal_PlantTableAdapter.Fill(this.medicinalPlantAphotecaryDataSet.Medicinal_Plant);

            edit = true;

            this.id = id;
            nameTextBox.Text = name;
            latinNameTextBox.Text = latin_name;
            classificationComboBox.Text = classification;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
                MessageBox.Show("Введіть дані");
            {
                if (edit)
                {
                    medicinal_PlantTableAdapter.UpdateQuery(nameTextBox.Text, latinNameTextBox.Text, classificationComboBox.Text, id);
                }
                else
                {
                    medicinal_PlantTableAdapter.Insert(nameTextBox.Text, latinNameTextBox.Text, classificationComboBox.Text);
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
