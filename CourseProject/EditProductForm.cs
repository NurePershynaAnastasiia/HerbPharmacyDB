using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CourseProject
{
    public partial class EditProductForm : Form
    {
        const string ConnectionString = "Data Source=DESKTOP-D0GBIS9;Initial Catalog=MedicinalPlantAphotecary;Integrated Security=True";

        List <ProductComponent> plantsInProduct= new List <ProductComponent> ();
        List<ProductComponent> illnessesInProduct = new List<ProductComponent>();

        List<ProductComponent> newPlantsInProduct = new List<ProductComponent>();
        List<ProductComponent> newIllnessesInProduct = new List<ProductComponent>();

        public EditProductForm()
        {
            InitializeComponent();
            // TODO: This line of code loads data into the 'medicinalPlantAphotecaryDataSet.Medicinal_Plant' table. You can move, or remove it, as needed.
            this.medicinal_PlantTableAdapter.Fill(this.medicinalPlantAphotecaryDataSet.Medicinal_Plant);
            this.brandTableAdapter.Fill(this.medicinalPlantAphotecaryDataSet.Brand);
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

        public EditProductForm(int id, string name, string category, string contraindication, decimal price, string method_of_application, decimal weight, int quantity, int brand) : this()
        {
            productTableAdapter.Fill(this.medicinalPlantAphotecaryDataSet.Product);

            edit = true;

            this.id = id;
            nameTextBox.Text = name;
            categoryTextBox.Text = category;
            contraindicationsTextBox.Text = contraindication;
            priceTextBox.Text = price.ToString();
            methodOfApplicationTextBox.Text = method_of_application;
            weightTextBox.Text = weight.ToString();
            quantityTextBox.Text = quantity.ToString();
            brandComboBox.SelectedValue = brand;
        }

        public void FillTablesUpdate()
        {
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();

            //filling plants in product
            SqlCommand com = new SqlCommand("select Medicinal_Plant.Plant_id, Medicinal_Plant.Plant_Name from Medicinal_Plant inner join Plant_in_Product on Plant_in_Product.Plant_id = Medicinal_Plant.Plant_id where Plant_in_Product.Product_id = " + id, sqlconn);
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    int id = Convert.ToInt32(reader.GetValue(0));
                    string name = reader.GetValue(1).ToString();
                    plantsInProduct.Add(
                       new ProductComponent()
                       {
                           Id = id,
                           Name = name
                       });
                    addedPlantDataGridView.Rows.Add(id, name);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Щось пішло не так");
                }
            }
            reader.Close();
            //filling product from illness
            com = new SqlCommand("select Illness.Illness_id, Illness.Illness_name from Illness inner join Product_from_illness on Product_from_illness.Illness_id = Illness.Illness_id where Product_from_illness.Product_Id = " + id, sqlconn);
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    int id = Convert.ToInt32(reader.GetValue(0));
                    string name = reader.GetValue(1).ToString();
                    illnessesInProduct.Add(
                       new ProductComponent()
                       {
                           Id = id,
                           Name = name
                       });
                    addedIllnessDataGridView.Rows.Add(id, name);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Щось пішло не так");
                }
            }
            reader.Close();
        }

        public void FillTablesUpdate2()
        {
            //filling added plants table
            string sqlString = "select Medicinal_Plant.Plant_id, Medicinal_Plant.Plant_Name from Medicinal_Plant inner join Plant_in_Product on Plant_in_Product.Plant_id = Medicinal_Plant.Plant_id inner join Product on Product.Product_Id = Plant_in_Product.Product_id where Product.Product_Id = " + id;
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter(sqlString, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                addedPlantDataGridView.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Щось пішло не так");
            }

            //filling added illness table
            sqlString = "select Illness.Illness_id, Illness.Illness_Name from Illness inner join Product_from_Illness on Product_from_Illness.Illness_id = Illness.Illness_id inner join Product on Product.Product_Id = Product_from_Illness.Product_id where Product.Product_Id = " + id;
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter(sqlString, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                addedIllnessDataGridView.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Щось пішло не так");
            }
        }

        public void FillTablesBase()
        {
            System.Windows.Forms.DataGridViewTextBoxColumn Plant_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            System.Windows.Forms.DataGridViewTextBoxColumn Plant_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            System.Windows.Forms.DataGridViewTextBoxColumn Illness_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            System.Windows.Forms.DataGridViewTextBoxColumn Illness_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();

            Plant_Id.HeaderText = "Plant_Id";
            Plant_Id.Name = "Plant_Id";
            Plant_Name.HeaderText = "Plant_Name";
            Plant_Name.Name = "Plant_Name";

            Illness_Id.HeaderText = "Illness_Id";
            Illness_Id.Name = "Illness_Id";
            Illness_Name.HeaderText = "Illness_Name";
            Illness_Name.Name = "Illness_Name";

            addedPlantDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Plant_Id, Plant_Name, });
            addedIllnessDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Illness_Id, Illness_Name, });
        }

        public void FillAuxiliaryTables()
        {
            SqlConnection cnn = new SqlConnection(ConnectionString);
            cnn.Open();

            SqlCommand mycommand = new SqlCommand("select product_id from product order by product_id desc", cnn);
            int product_id = (id == 0) ? Convert.ToInt32(mycommand.ExecuteScalar()) : id;

            //deleting already existing information Plant_in_Product
            string sqlString = "delete from plant_in_product where product_id = " + product_id;
            mycommand = new SqlCommand(sqlString, cnn);
            mycommand.ExecuteNonQuery();
            //adding new information Plant_in_Product
            foreach (DataGridViewRow row in addedPlantDataGridView.Rows)
            {
                if (row.Cells[0].Value == null)
                    break;
                sqlString = "insert into Plant_in_Product (Plant_id, Product_id) values (" + row.Cells[0].Value + ", " + product_id + ")";

                mycommand = new SqlCommand(sqlString, cnn);
                mycommand.ExecuteNonQuery();
            }
            //deleting already existing information Product_from_Illness
            sqlString = "delete from product_from_illness where product_id = " + product_id;
            mycommand = new SqlCommand(sqlString, cnn);
            mycommand.ExecuteNonQuery();
            //adding new information Product_from_Illness
            foreach (DataGridViewRow row in addedIllnessDataGridView.Rows)
            {
                if (row.Cells[0].Value == null)
                    break;
                sqlString = $"insert into Product_from_Illness (Illness_id, Product_id) values (" + row.Cells[0].Value + ", " + product_id + ")";

                mycommand = new SqlCommand(sqlString, cnn);
                mycommand.ExecuteNonQuery();
            }
        }

        public void FillTables()
        {
            //filling plants table
            string sqlString = "select Plant_id, Plant_Name from Medicinal_Plant";
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter(sqlString, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                plantDataGridView.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Щось пішло не так");
            }

            //filling plants table
            sqlString = "select Illness_id, Illness_Name from Illness";
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter(sqlString, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                illnessDataGridView.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Щось пішло не так");
            }
        }

        private void EditProductForm_Load(object sender, EventArgs e) 
        { 
            FillTables();
            FillTablesBase();
            if (edit)
                FillTablesUpdate();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || priceTextBox.Text == "" || weightTextBox.Text == "" || quantityTextBox.Text == "")
                MessageBox.Show("Введіть дані");
            else if (Convert.ToDecimal(priceTextBox.Text) <= 0 || Convert.ToDecimal(weightTextBox.Text) <= 0 || Convert.ToInt32(quantityTextBox.Text) < 0)
                MessageBox.Show("Введіть коректні дані");
            else
            {
                if (addedIllnessDataGridView.RowCount == 1 || addedPlantDataGridView.RowCount == 1)
                {
                    MessageBox.Show("Додайте вибірки хвороб та рослин");
                }
                else
                {
                    if (edit)
                    {
                        productTableAdapter.UpdateQuery(nameTextBox.Text, categoryTextBox.Text, contraindicationsTextBox.Text, Convert.ToDecimal(priceTextBox.Text), methodOfApplicationTextBox.Text, Convert.ToDecimal(weightTextBox.Text), Convert.ToInt32(quantityTextBox.Text), Convert.ToInt32(brandComboBox.SelectedValue), id);
                    }
                    else
                    {
                        productTableAdapter.Insert(nameTextBox.Text, categoryTextBox.Text, contraindicationsTextBox.Text, Convert.ToDecimal(priceTextBox.Text), methodOfApplicationTextBox.Text, Convert.ToDecimal(weightTextBox.Text), Convert.ToInt32(quantityTextBox.Text), Convert.ToInt32(brandComboBox.SelectedValue));
                    }
                    productTableAdapter.Fill(medicinalPlantAphotecaryDataSet.Product);
                    FillAuxiliaryTables();
                    Close();
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addPlantButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in addedPlantDataGridView.Rows)
            {
                if (row.Cells[0].Value == null) break;
                else if (plantDataGridView.CurrentRow.Cells[0].Value.ToString() == row.Cells[0].Value.ToString())
                {
                    MessageBox.Show("Дана рослина вже наявна у виборці");
                    return;
                }
            }
 
            addedPlantDataGridView.Rows.Add(plantDataGridView.CurrentRow.Cells[0].Value, plantDataGridView.CurrentRow.Cells[1].Value);
        }

        private void addIllnessButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in addedIllnessDataGridView.Rows)
            {
                if (row.Cells[0].Value == null) break;
                else if (illnessDataGridView.CurrentRow.Cells[0].Value.ToString() == row.Cells[0].Value.ToString())
                {
                    MessageBox.Show("Дана хвороба вже наявна у виборці");
                    return;
                }
            }
            addedIllnessDataGridView.Rows.Add(illnessDataGridView.CurrentRow.Cells[0].Value, illnessDataGridView.CurrentRow.Cells[1].Value);
        }

        private void deletePlantButton_Click(object sender, EventArgs e)
        {
            if (addedPlantDataGridView.SelectedCells.Count == 0) return;

            if (addedPlantDataGridView.CurrentRow.Cells[0].Value == null)
                return;
            addedPlantDataGridView.Rows.RemoveAt(addedPlantDataGridView.CurrentRow.Index);
        }

        private void deleteIllnessButton_Click(object sender, EventArgs e)
        {
            if (addedIllnessDataGridView.SelectedCells.Count == 0) return;

            if (addedIllnessDataGridView.CurrentRow.Cells[0].Value == null)
                return;
            addedIllnessDataGridView.Rows.RemoveAt(addedIllnessDataGridView.CurrentRow.Index);
        }
    }

}
