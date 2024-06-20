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
    public partial class MainForm : Form
    {

        const string ConnectionString = "Data Source=DESKTOP-D0GBIS9;Initial Catalog=MedicinalPlantAphotecary;Integrated Security=True";
        List <OrderItem> order = new List <OrderItem> ();

        public MainForm()
        {
            InitializeComponent();
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicinalPlantAphotecaryDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.medicinalPlantAphotecaryDataSet.Product);
            this.purchaseTableAdapter.Fill(this.medicinalPlantAphotecaryDataSet.Purchase);
            this.medicinal_PlantTableAdapter.Fill(this.medicinalPlantAphotecaryDataSet.Medicinal_Plant);
            this.client_CardTableAdapter.Fill(this.medicinalPlantAphotecaryDataSet.Client_Card);
            this.brandTableAdapter.Fill(this.medicinalPlantAphotecaryDataSet.Brand);
            this.illnessTableAdapter.Fill(this.medicinalPlantAphotecaryDataSet.Illness);

            

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.Columns[0].Visible = false;
            additionalLabel1.Visible = false;
            additionalLabel2.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            deleteButton.Visible = false;
            cardDateTimePicker.Visible = false;
            purchaseDateTimePicker.Visible = false;
            comboBoxFill();

            FillOrderList();

            this.Show();
        }

        public void FillOrderList()
        {
            order = new List<OrderItem>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value == null) break;

                int id = int.Parse(row.Cells[0].Value.ToString());
                int currentQuantity = int.Parse(row.Cells[7].Value.ToString());
                int newQuantity = Automatization.DefineAdditionalQuantity(id, currentQuantity);

                if (newQuantity != 0)
                {
                    order.Add(
                        new OrderItem()
                        {
                            Id = int.Parse(row.Cells[0].Value.ToString()),
                            ProductName = row.Cells[1].Value.ToString(),
                            OrderQuantity = newQuantity
                        }
                    );
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            productTableAdapter.Update(medicinalPlantAphotecaryDataSet);
            client_CardTableAdapter.Update(medicinalPlantAphotecaryDataSet);
            medicinal_PlantTableAdapter.Update(medicinalPlantAphotecaryDataSet);
            illnessTableAdapter.Update(medicinalPlantAphotecaryDataSet);
            purchaseTableAdapter.Update(medicinalPlantAphotecaryDataSet);
            brandTableAdapter.Update(medicinalPlantAphotecaryDataSet);
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.medicinalPlantAphotecaryDataSet.Product);

            dataGridView1.DataSource = productBindingSource;

            FillOrderList();

            purchaseDateTimePicker.Visible = false;
            cardDateTimePicker.Visible = false;
            //
            dataGridView1.Columns[0].Visible = false;
            additionalLabel1.Visible = false;
            additionalLabel2.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            nameLabel.Text = "Продукти";
            //
            sortComboBox.Text = "";
            sortComboBox.Items.Clear();
            sortComboBox.Items.Add("назвою");
            sortComboBox.Items.Add("ціною");
            sortComboBox.Items.Add("кількістю");
            //
            filterComboBox1.Visible = true;
            filterCheckBox2.Visible = true;
            filterCheckBox3.Visible = true;
            filterComboBox2.Visible = true;
            filterComboBox3.Visible = true;
            filterCheckBox1.Text = "Брендом";
            filterCheckBox2.Text = "Хворобою";
            filterCheckBox3.Text = "Лікарською рослиною";
            comboBoxFill();
            //
            searchButton.Visible = true;
            searchTextBox.Visible = true;
            //
            addButton.Visible = true;
            updateButton.Visible = true;
            deleteButton.Visible = false;
        }

        private void purchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purchaseTableAdapter.Update(medicinalPlantAphotecaryDataSet);
            this.purchaseTableAdapter.Fill(this.medicinalPlantAphotecaryDataSet.Purchase);

            purchaseDateTimePicker.Visible = true;
            cardDateTimePicker.Visible = false;
            //
            dataGridView1.DataSource = purchaseBindingSource;
            dataGridView1.Columns[0].Visible = false;
            additionalLabel1.Visible = false;
            additionalLabel2.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            nameLabel.Text = "Покупки";
            //
            sortComboBox.Text = "";
            sortComboBox.Items.Clear();
            sortComboBox.Items.Add("сумою");
            sortComboBox.Items.Add("датою");
            //
            filterComboBox1.Visible = false;
            filterCheckBox2.Visible = true;
            filterComboBox2.Visible = true;
            filterCheckBox3.Visible = false;
            filterComboBox3.Visible = false;
            filterCheckBox1.Text = "Датою";
            filterCheckBox2.Text = "Власником картки";
            comboBoxFill();
            //
            searchButton.Visible = false;
            searchTextBox.Visible = false;
            //
            addButton.Visible = false;
            updateButton.Visible = false;
            deleteButton.Visible = false;
        }

        private void plantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            medicinal_PlantTableAdapter.Update(medicinalPlantAphotecaryDataSet);
            this.medicinal_PlantTableAdapter.Fill(this.medicinalPlantAphotecaryDataSet.Medicinal_Plant);

            purchaseDateTimePicker.Visible = false;
            cardDateTimePicker.Visible = false;
            //
            dataGridView1.DataSource = medicinal_PlantBindingSource;
            dataGridView1.Columns[0].Visible = false;
            additionalLabel1.Visible = false;
            additionalLabel2.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            nameLabel.Text = "Лікарські рослини";
            //
            sortComboBox.Text = "";
            sortComboBox.Items.Clear();
            sortComboBox.Items.Add("назвою");
            //
            filterComboBox1.Visible = true;
            filterCheckBox2.Visible = false;
            filterCheckBox3.Visible = false;
            filterComboBox2.Visible = false;
            filterComboBox3.Visible = false;
            filterCheckBox1.Text = "Класифікацією";
            comboBoxFill();
            //
            searchButton.Visible = true;
            searchTextBox.Visible = true;
            //
            addButton.Visible = true;
            updateButton.Visible = true;
            deleteButton.Visible = false;
        }

        private void illnessesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            illnessTableAdapter.Update(medicinalPlantAphotecaryDataSet);
            this.illnessTableAdapter.Fill(this.medicinalPlantAphotecaryDataSet.Illness);

            purchaseDateTimePicker.Visible = false;
            cardDateTimePicker.Visible = false;
            //
            dataGridView1.DataSource = illnessBindingSource;
            dataGridView1.Columns[0].Visible = false;
            additionalLabel1.Visible = false;
            additionalLabel2.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            nameLabel.Text = "Хвороби";
            //
            sortComboBox.Text = "";
            sortComboBox.Items.Clear();
            sortComboBox.Items.Add("назвою");
            //
            filterComboBox1.Visible = true;
            filterCheckBox2.Visible = false;
            filterCheckBox3.Visible = false;
            filterComboBox2.Visible = false;
            filterComboBox3.Visible = false;
            filterCheckBox1.Text = "Складністю";
            comboBoxFill();
            //
            searchButton.Visible = true;
            searchTextBox.Visible = true;
            //
            addButton.Visible = true;
            updateButton.Visible = true;
            deleteButton.Visible = false;
        }

        private void brandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brandTableAdapter.Update(medicinalPlantAphotecaryDataSet);
            this.brandTableAdapter.Fill(this.medicinalPlantAphotecaryDataSet.Brand);

            purchaseDateTimePicker.Visible = false;
            cardDateTimePicker.Visible = false;
            //
            dataGridView1.DataSource = brandBindingSource;
            dataGridView1.Columns[0].Visible = false;
            additionalLabel1.Visible = false;
            additionalLabel2.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            nameLabel.Text = "Бренди";
            //
            sortComboBox.Text = "";
            sortComboBox.Items.Clear();
            sortComboBox.Items.Add("назвою");
            sortComboBox.Items.Add("роком заснування");
            //
            filterComboBox1.Visible = true;
            filterCheckBox2.Visible = true;
            filterCheckBox3.Visible = false;
            filterComboBox2.Visible = true;
            filterComboBox3.Visible = false;
            filterCheckBox1.Text = "Країною";
            filterCheckBox2.Text = "Роком заснування";
            comboBoxFill();
            //
            searchButton.Visible = true;
            searchTextBox.Visible = true;
            //
            addButton.Visible = true;
            updateButton.Visible = true;
            deleteButton.Visible = false;
        }

        private void client_CardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            client_CardTableAdapter.Update(medicinalPlantAphotecaryDataSet);
            this.client_CardTableAdapter.Fill(this.medicinalPlantAphotecaryDataSet.Client_Card);

            purchaseDateTimePicker.Visible = false;
            cardDateTimePicker.Visible = true;
            //
            dataGridView1.DataSource = client_CardBindingSource;
            dataGridView1.Columns[0].Visible = false;
            additionalLabel1.Visible = false;
            additionalLabel2.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            nameLabel.Text = "Клієнтські картки";
            //
            sortComboBox.Text = "";
            sortComboBox.Items.Clear();
            sortComboBox.Items.Add("назвою");
            sortComboBox.Items.Add("знижкою");
            //
            filterComboBox1.Visible = true;
            filterCheckBox2.Visible = true;
            filterCheckBox3.Visible = true;
            filterComboBox2.Visible = false;
            filterComboBox3.Visible = true;
            filterCheckBox1.Text = "Типом";
            filterCheckBox2.Text = "Датою реєстрації";
            filterCheckBox3.Text = "Знижкою";
            comboBoxFill();
            //
            searchButton.Visible = true;
            searchTextBox.Visible = true;
            //
            addButton.Visible = true;
            updateButton.Visible = true;
            deleteButton.Visible = true;
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            string sqlString = "";
            switch (sortComboBox.Text)
            {
                case "назвою":
                    sqlString = "SELECT * FROM " + InfoDB.labelDictionary[nameLabel.Text][0] + " ORDER BY (" + InfoDB.labelDictionary[nameLabel.Text][1] + ")";
                    break;
                case "ціною":
                    sqlString = "SELECT * FROM Product ORDER BY Price";
                    break;
                case "кількістю":
                    sqlString = "SELECT * FROM Product ORDER BY Quantity";
                    break;
                case "датою":
                    sqlString = "SELECT * FROM Purchase ORDER BY Date";
                    break;
                case "сумою":
                    sqlString = "SELECT * FROM Purchase ORDER BY Sum";
                    break;
                case "знижкою":
                    sqlString = "SELECT * FROM Client_Card ORDER BY Discount";
                    break;
                case "роком заснування":
                    sqlString = "SELECT * FROM Brand ORDER BY Founding_Year";
                    break;
            };

            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter(sqlString, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Оберіть критерій сортування");
            }
        }

        private void comboBoxFill()
        {
            filterCheckBox1.Checked = false;
            filterCheckBox2.Checked = false;
            filterCheckBox3.Checked = false;
            filterComboBox1.Items.Clear();
            filterComboBox2.Items.Clear();
            filterComboBox3.Items.Clear();
            SqlConnection sqlconn = new SqlConnection(ConnectionString);
            sqlconn.Open();
            //1 param
            string table = InfoDB.filterDictionaryMain[filterCheckBox1.Text][0];
            string column = InfoDB.filterDictionaryMain[filterCheckBox1.Text][1];
            SqlCommand com = new SqlCommand("SELECT DISTINCT " + column + " FROM " + table, sqlconn);
            SqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    string result = reader.GetValue(0).ToString();
                    filterComboBox1.Items.Add(result);
                    filterComboBox1.Text = result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Некоректно задано параметр фільтрації");
                }
            }
            reader.Close();
            //2 param
            if (filterComboBox2.Visible == true)
            {
                table = InfoDB.filterDictionaryMain[filterCheckBox2.Text][0];
                column = InfoDB.filterDictionaryMain[filterCheckBox2.Text][1];
                com = new SqlCommand("SELECT DISTINCT " + column + " FROM " + table, sqlconn);
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        string result = reader.GetValue(0).ToString();
                        filterComboBox2.Items.Add(result);
                        filterComboBox2.Text = result;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Некоректно задано параметр фільтрації");
                    }

                }
                reader.Close();
            }
            //3 param
            if (filterComboBox3.Visible == true)
            {
                table = InfoDB.filterDictionaryMain[filterCheckBox3.Text][0];
                column = InfoDB.filterDictionaryMain[filterCheckBox3.Text][1];
                com = new SqlCommand("SELECT DISTINCT " + column + " FROM " + table, sqlconn);
                reader = com.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        string result = reader.GetValue(0).ToString();
                        filterComboBox3.Items.Add(result);
                        filterComboBox3.Text = result;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Некоректно задано параметр фільтрації");
                    }

                }
                reader.Close();
            }
            sqlconn.Close();
        }

        private void FilterProduct()
        {
            bool selected = false;
            string sqlString = "select distinct p.* from product p, Brand, Plant_in_Product, Product_from_Illness where ";
            if (filterCheckBox1.Visible && filterCheckBox1.Checked)
            {
                sqlString += "Brand.Brand_id = P.Brand and Brand_name = N'" + filterComboBox1.Text + "'";
                selected = true;
            }
            if (filterCheckBox2.Visible && filterCheckBox2.Checked)
            {
                if (selected) sqlString += " and ";
                selected = true;
                sqlString += "Product_from_Illness.Product_id = P.Product_id and Product_from_Illness.Product_id in (select pp.product_id from Product_from_Illness pp, Product p1, Illness iln where pp.product_id = p1.product_id and pp.illness_id = iln.illness_id and iln.illness_name = N'" + filterComboBox2.Text + "')";
            }
            if (filterCheckBox3.Visible && filterCheckBox3.Checked)
            {
                if (selected) sqlString += " and ";
                sqlString += "Plant_in_Product.Product_id = P.Product_id and Plant_in_Product.Product_id in (select pp.product_id from Plant_in_Product pp, Product p1, Medicinal_Plant mp where pp.product_id = p1.product_id and pp.plant_id = mp.plant_id and mp.plant_name = N'" + filterComboBox3.Text + "')";
            }
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter(sqlString, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Оберіть критерій фільтрації");
            }
        }

        private void FilterPurchase()
        {
            bool selected = false;
            string sqlString = "select distinct p.* from purchase p, client_card c where ";
            if (filterCheckBox1.Visible && filterCheckBox1.Checked)
            {
                if (purchaseDateTimePicker.Value > DateTime.Now)
                {
                    MessageBox.Show("Введіть коректну дату");
                    return;
                }
                sqlString += "year(p.date) = '" + purchaseDateTimePicker.Value.Year + 
                    "' and month(p.date) = '" + purchaseDateTimePicker.Value.Month + 
                    "' and day(p.date) = '" + purchaseDateTimePicker.Value.Day + "'";
                selected = true;
            }
            if (filterCheckBox2.Visible && filterCheckBox2.Checked)
            {
                if (selected) sqlString += " and ";
                sqlString += "p.client_card = c.client_card_id and c.client_name = N'" + filterComboBox2.Text + "'";
            }
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter(sqlString, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Оберіть критерій фільтрації");
            }
        }

        private void FilterCard()
        {
            bool selected = false;
            string sqlString = "SELECT * FROM " + InfoDB.filterDictionaryMain[filterCheckBox1.Text][0] + " WHERE ";
            if (filterCheckBox1.Visible && filterCheckBox1.Checked)
            {
                sqlString += InfoDB.filterDictionaryMain[filterCheckBox1.Text][1] + " = N'" + filterComboBox1.Text + "'";
                selected = true;
            }
            if (filterCheckBox2.Visible && filterCheckBox2.Checked)
            {
                if (cardDateTimePicker.Value > DateTime.Now)
                {
                    MessageBox.Show("Введіть коректну дату");
                    return;
                }
                if (selected) sqlString += " and ";
                selected = true;
                sqlString += InfoDB.filterDictionaryMain[filterCheckBox2.Text][1] + " = '" + Convert.ToDateTime(cardDateTimePicker.Value).ToString("yyyy-MM-dd HH:mm:ss") + "'";
            }
            if (filterCheckBox3.Visible && filterCheckBox3.Checked)
            {
                if (selected) sqlString += " and ";
                sqlString += InfoDB.filterDictionaryMain[filterCheckBox3.Text][1] + " = " + filterComboBox3.Text;
            }
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter(sqlString, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Оберіть критерій фільтрації");
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            if (nameLabel.Text == "Продукти")
                FilterProduct();
            else if (nameLabel.Text == "Клієнтські картки")
                FilterCard();
            else if (nameLabel.Text == "Покупки")
                FilterPurchase();
            else
            {
                string sqlString = "SELECT * FROM " + InfoDB.filterDictionaryMain[filterCheckBox1.Text][0] + " WHERE ";
                bool selected = false;
                if (filterCheckBox1.Visible && filterCheckBox1.Checked)
                {
                    sqlString += InfoDB.filterDictionaryMain[filterCheckBox1.Text][1] + " = N'" + filterComboBox1.Text + "'";
                    selected = true;
                }
                if (filterCheckBox2.Visible && filterCheckBox2.Checked)
                {
                    if (selected) sqlString += " and ";
                    if (filterCheckBox2.Text == "Датою реєстрації")
                        sqlString += InfoDB.filterDictionaryMain[filterCheckBox2.Text][1] + " = '" + Convert.ToDateTime(filterComboBox2.Text).ToString("yyyy-MM-dd HH:mm:ss") + "'";
                    else
                        sqlString += InfoDB.filterDictionaryMain[filterCheckBox2.Text][1] + " = " + filterComboBox2.Text;
                    selected = true;
                }
                if (filterCheckBox3.Visible && filterCheckBox3.Checked)
                {
                    if (selected) sqlString += " and ";
                    sqlString += InfoDB.filterDictionaryMain[filterCheckBox3.Text][1] + " = " + filterComboBox3.Text;
                }
                try
                {
                    SqlConnection sqlconn = new SqlConnection(ConnectionString);
                    sqlconn.Open();
                    SqlDataAdapter oda = new SqlDataAdapter(sqlString, sqlconn);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    sqlconn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Оберіть критерій фільтрації");
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string sqlString = "SELECT * FROM " + InfoDB.labelDictionary[nameLabel.Text][0] + " WHERE LOWER(" + InfoDB.labelDictionary[nameLabel.Text][1] + ") LIKE LOWER( N'%" + searchTextBox.Text + "%')";

            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter(sqlString, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введіть коректні параметри пошуку");
            }
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
            new StatisticsForm(Convert.ToInt32(toolStripMenuItem.Tag)).Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == illnessBindingSource)
            {
                var edt = new EditIllnessForm();
                edt.ShowDialog();
                illnessTableAdapter.Fill(medicinalPlantAphotecaryDataSet.Illness);
                medicinalPlantAphotecaryDataSet.AcceptChanges();
            }
            else if (dataGridView1.DataSource == client_CardBindingSource)
            {
                var edt = new EditCardForm();
                edt.ShowDialog();
                client_CardTableAdapter.Fill(medicinalPlantAphotecaryDataSet.Client_Card);
                medicinalPlantAphotecaryDataSet.AcceptChanges();
            }
            else if (dataGridView1.DataSource == purchaseBindingSource)
            {
                var edt = new EditPurchaseForm();
                edt.ShowDialog();
                purchaseTableAdapter.Fill(medicinalPlantAphotecaryDataSet.Purchase);
                medicinalPlantAphotecaryDataSet.AcceptChanges();
            }
            else if (dataGridView1.DataSource == medicinal_PlantBindingSource)
            {
                var edt = new EditMedicinalPlantForm();
                edt.ShowDialog();
                medicinal_PlantTableAdapter.Fill(medicinalPlantAphotecaryDataSet.Medicinal_Plant);
                medicinalPlantAphotecaryDataSet.AcceptChanges();
            }
            else if (dataGridView1.DataSource == brandBindingSource)
            {
                var edt = new EditBrandForm();
                edt.ShowDialog();
                brandTableAdapter.Fill(medicinalPlantAphotecaryDataSet.Brand);
                medicinalPlantAphotecaryDataSet.AcceptChanges();
            }
            else if (dataGridView1.DataSource == productBindingSource)
            {
                var edt = new EditProductForm();
                edt.ShowDialog();
                productTableAdapter.Fill(medicinalPlantAphotecaryDataSet.Product);
                medicinalPlantAphotecaryDataSet.AcceptChanges();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (nameLabel.Text == "Хвороби")
            {
                var st = new MedicinalPlantAphotecaryDataSet.IllnessDataTable();
                illnessTableAdapter.FillBy(st,
                    Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                object[] row = st.Rows[0].ItemArray;
                var edt = new EditIllnessForm(
                    Convert.ToInt32(row[0]),
                    row[1].ToString(),
                    row[2].ToString(),
                    row[3].ToString(),
                    row[4].ToString()
                );
                edt.ShowDialog();
                illnessTableAdapter.Fill(medicinalPlantAphotecaryDataSet.Illness);
                medicinalPlantAphotecaryDataSet.AcceptChanges();
            }
            else if (nameLabel.Text == "Клієнтські картки")
            {
                var st = new MedicinalPlantAphotecaryDataSet.Client_CardDataTable();
                client_CardTableAdapter.FillBy(st,
                    Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                object[] row = st.Rows[0].ItemArray;
                var edt = new EditCardForm(
                    Convert.ToInt32(row[0]),
                    row[1].ToString(),
                    Convert.ToInt32(row[2]),
                    row[3].ToString(),
                    Convert.ToDateTime(row[4])
                );
                edt.ShowDialog();
                client_CardTableAdapter.Fill(medicinalPlantAphotecaryDataSet.Client_Card);
                medicinalPlantAphotecaryDataSet.AcceptChanges();
            }
            else if (nameLabel.Text == "Покупки")
            {
                var st = new MedicinalPlantAphotecaryDataSet.PurchaseDataTable();
                purchaseTableAdapter.FillBy(st,
                    Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                object[] row = st.Rows[0].ItemArray;
                int? row3 = null;
                if (row[3].ToString().Length != 0)
                    row3 = Convert.ToInt32(row[3]);
                var edt = new EditPurchaseForm(
                    Convert.ToInt32(row[0]),
                    Convert.ToDateTime(row[1]),
                    Convert.ToDecimal(row[2]),
                    row3
                );
                edt.ShowDialog();
                purchaseTableAdapter.Fill(medicinalPlantAphotecaryDataSet.Purchase);
                medicinalPlantAphotecaryDataSet.AcceptChanges();
            }
            else if (nameLabel.Text == "Лікарські рослини")
            {
                var st = new MedicinalPlantAphotecaryDataSet.Medicinal_PlantDataTable();
                medicinal_PlantTableAdapter.FillBy(st,
                    Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                object[] row = st.Rows[0].ItemArray;
                var edt = new EditMedicinalPlantForm(
                    Convert.ToInt32(row[0]),
                    row[1].ToString(),
                    row[2].ToString(),
                    row[3].ToString()
                );
                edt.ShowDialog();
                medicinal_PlantTableAdapter.Fill(medicinalPlantAphotecaryDataSet.Medicinal_Plant);
                medicinalPlantAphotecaryDataSet.AcceptChanges();
            }
            else if (nameLabel.Text == "Бренди")
            {
                var st = new MedicinalPlantAphotecaryDataSet.BrandDataTable();
                brandTableAdapter.FillBy(st,
                    Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                object[] row = st.Rows[0].ItemArray;
                var edt = new EditBrandForm(
                    Convert.ToInt32(row[0]),
                    row[1].ToString(),
                    row[2].ToString(),
                    row[3].ToString(),
                    Convert.ToInt32(row[4]),
                    row[5].ToString()
                );
                edt.ShowDialog();
                brandTableAdapter.Fill(medicinalPlantAphotecaryDataSet.Brand);
                medicinalPlantAphotecaryDataSet.AcceptChanges();
            }
            else if (nameLabel.Text == "Продукти")
            {
                var st = new MedicinalPlantAphotecaryDataSet.ProductDataTable();
                productTableAdapter.FillBy(st,
                    Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                object[] row = st.Rows[0].ItemArray;
                var edt = new EditProductForm(
                    Convert.ToInt32(row[0]),
                    row[1].ToString(),
                    row[2].ToString(),
                    row[3].ToString(),
                    Convert.ToDecimal(row[4]),
                    row[5].ToString(),
                    Convert.ToDecimal(row[6]),
                    Convert.ToInt32(row[7]),
                    Convert.ToInt32(row[8])
                );
                edt.ShowDialog();
                productTableAdapter.Fill(medicinalPlantAphotecaryDataSet.Product);
                medicinalPlantAphotecaryDataSet.AcceptChanges();
            }
        }

        private void LoadMedicinalPlants(int productId)
        {
            string sqlString = "select mp.* from Medicinal_Plant mp, Plant_in_Product pp where pp.plant_id = mp.plant_id and pp.Product_id = " + productId;

            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter(sqlString, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView2.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Щось пішло не так");
            }
        }

        private void LoadIllnesses(int productId)
        {
            string sqlString = "select iln.* from Illness iln, Product_from_Illness pi where pi.illness_id = iln.illness_id and pi.Product_id = " + productId;

            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter(sqlString, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView3.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Щось пішло не так");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[0].Value == null)
                return;
            if (dataGridView1.RowCount > 0 && nameLabel.Text == "Продукти")
            {
                additionalLabel1.Visible = true;
                additionalLabel2.Visible = true;
                dataGridView2.Visible = true;
                dataGridView3.Visible = true;

                int productId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                LoadMedicinalPlants(productId);
                LoadIllnesses(productId);
            }
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            new CreateReceiptForm().Show();
        }

        private void recommendationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CreateRecomendationsForm().Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == client_CardBindingSource)
            {
                client_CardTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                client_CardTableAdapter.Fill(medicinalPlantAphotecaryDataSet.Client_Card);
                medicinalPlantAphotecaryDataSet.AcceptChanges();
            }
        }

        private void unsignedOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillOrderList();
            new AutomatizationForm(order).Show();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string sqlString = "SELECT * FROM " + InfoDB.labelDictionary[nameLabel.Text][0] + " WHERE LOWER(" + InfoDB.labelDictionary[nameLabel.Text][1] + ") LIKE LOWER( N'%" + searchTextBox.Text + "%')";

            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter(sqlString, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введіть коректні параметри пошуку");
            }
        }

    }
}
