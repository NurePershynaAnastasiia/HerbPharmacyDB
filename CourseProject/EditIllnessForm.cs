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
    public partial class EditIllnessForm : Form
    {
        public EditIllnessForm()
        {
            InitializeComponent();
            illnessTableAdapter.Fill(this.medicinalPlantAphotecaryDataSet.Illness);
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

        public EditIllnessForm(int id, string illness_name, string symptoms, string severity, string duration) : this()
        {
            illnessTableAdapter.Fill(this.medicinalPlantAphotecaryDataSet.Illness);

            edit = true;

            this.id = id;
            nameTextBox.Text = illness_name;
            symptomsTextBox.Text = symptoms;
            switch (severity)
            {
                case "Легка":
                    severityComboBox.SelectedIndex = 0;
                    break;
                case "Середня":
                    severityComboBox.SelectedIndex = 1;
                    break;
                case "Важка":
                    severityComboBox.SelectedIndex = 2;
                    break;
                default:
                    severityComboBox.SelectedIndex = 0;
                    break;
            }
            durationTextBox.Text = duration;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
                MessageBox.Show("Введіть дані");
            else
            {
                string severity = "";
                if (severityComboBox.SelectedIndex == 0)
                {
                    severity = "Легка";
                }
                else if (severityComboBox.SelectedIndex == 1)
                {
                    severity = "Середня";
                }
                else if (severityComboBox.SelectedIndex == 2)
                {
                    severity = "Важка";
                }
                if (edit)
                {
                    illnessTableAdapter.UpdateQuery(nameTextBox.Text, symptomsTextBox.Text, severity, durationTextBox.Text, id);
                }
                else
                {
                    illnessTableAdapter.Insert(nameTextBox.Text, symptomsTextBox.Text, severity, durationTextBox.Text);
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
