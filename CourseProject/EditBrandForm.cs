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
    public partial class EditBrandForm : Form
    {
        public EditBrandForm()
        {
            InitializeComponent();
            brandTableAdapter.Fill(this.medicinalPlantAphotecaryDataSet.Brand);
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

        public EditBrandForm(int id, string name, string owner, string goods, int founding_year, string country) : this()
        {
            brandTableAdapter.Fill(this.medicinalPlantAphotecaryDataSet.Brand);

            edit = true;

            this.id = id;
            nameTextBox.Text = name;
            ownerTextBox.Text = owner;
            goodsTextBox.Text = goods;
            foundingYearTextBox.Text = founding_year.ToString();
            countryTextBox.Text = country;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || foundingYearTextBox.Text == "")
                MessageBox.Show("Введіть дані");
            else if ((Convert.ToInt32(foundingYearTextBox.Text) < 1700 || Convert.ToInt32(foundingYearTextBox.Text) > DateTime.Now.Year))
                MessageBox.Show("Введіть коректний рік заснування");
            else
            {
                if (edit)
                    brandTableAdapter.UpdateQuery(nameTextBox.Text, ownerTextBox.Text, goodsTextBox.Text, Convert.ToInt32(foundingYearTextBox.Text), countryTextBox.Text, id);
                else
                    brandTableAdapter.Insert(nameTextBox.Text, ownerTextBox.Text, goodsTextBox.Text, Convert.ToInt32(foundingYearTextBox.Text), countryTextBox.Text);
                Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
