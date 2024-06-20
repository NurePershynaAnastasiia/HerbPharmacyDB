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
using System.Drawing.Printing;

namespace CourseProject
{
    public partial class CreateReceiptForm : Form
    {
        const string ConnectionString = "Data Source=DESKTOP-D0GBIS9;Initial Catalog=MedicinalPlantAphotecary;Integrated Security=True";
        ReceiptPurchase receipt = new ReceiptPurchase();

        public CreateReceiptForm()
        {
            InitializeComponent();
        }

        public static string ExecuteScalar(string sql)
        {
            SqlConnection cnn = new SqlConnection(ConnectionString);
            cnn.Open();
            SqlCommand mycommand = new SqlCommand(sql, cnn);
            object value = mycommand.ExecuteScalar();
            cnn.Close();
            if (value != null)
            {
                return value.ToString();
            }
            return "";
        }

        public void UpdateDB()
        {
            SqlConnection cnn = new SqlConnection(ConnectionString);
            cnn.Open();
            SqlCommand mycommand;

            //inserting information about current purchase
            string purchase;
            string sumStr = receipt.Sum.ToString(System.Globalization.CultureInfo.InvariantCulture);
            if (receipt.Card_id != 0)
                purchase = $"insert into purchase (date, sum, client_card) values ( '{receipt.CreatedDate.ToString("yyyy-MM-dd HH:mm:ss")}'," + sumStr + $", {receipt.Card_id})";
            else
                purchase = "insert into purchase (date, sum) values ('" + receipt.CreatedDate.ToString("yyyy-MM-dd HH:mm:ss") + "', " + sumStr + ")";
            mycommand = new SqlCommand(purchase, cnn);
            mycommand.ExecuteNonQuery();

            int purchase_id = Convert.ToInt32(ExecuteScalar("select purchase_id from purchase order by purchase_id desc"));
            foreach (var item in receipt.items)
            {
                mycommand = new SqlCommand("update product set quantity = quantity - " + item.Quantity + " where product_id = " + item.Id, cnn);
                mycommand.ExecuteNonQuery();
                mycommand = new SqlCommand($"insert into product_quantity (quantity, product_id, purchase_id) values ({item.Quantity}, {item.Id}, {purchase_id})", cnn);
                mycommand.ExecuteNonQuery();
            }

            medicinalPlantAphotecaryDataSet.AcceptChanges();
            cnn.Close();
        }

        private void CreateReceiptForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicinalPlantAphotecaryDataSet.Client_Card' table. You can move, or remove it, as needed.
            this.client_CardTableAdapter.Fill(this.medicinalPlantAphotecaryDataSet.Client_Card);
            //filling printers list
            if (PrinterSettings.InstalledPrinters.Count <= 0)
                MessageBox.Show("Printer not found!");
            else foreach (String printer in PrinterSettings.InstalledPrinters)
                printersList.Items.Add(printer.ToString());

            //filling products table
            string sqlString = "select Product_id, Product_Name, Price, Quantity from Product";
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter(sqlString, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                productsDataGridView.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Щось пішло не так");
            }

            //filling receipt table
            System.Windows.Forms.DataGridViewTextBoxColumn Id;
            System.Windows.Forms.DataGridViewTextBoxColumn Name;
            System.Windows.Forms.DataGridViewTextBoxColumn Price;
            System.Windows.Forms.DataGridViewTextBoxColumn Quantity;

            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();

            Id.HeaderText = "Id";
            Id.Name = "Id";

            Name.HeaderText = "Name";
            Name.Name = "Name";

            Price.HeaderText = "Price";
            Price.Name = "Price";

            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";

            receiptDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {Id, Name, Price, Quantity});
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bool alreadyInReceipt = false;
            foreach (DataGridViewRow row in receiptDataGridView.Rows)
            {
                if (row.Cells[0].Value == null) break;
                else if (productsDataGridView.CurrentRow.Cells[0].Value.ToString() == row.Cells[0].Value.ToString())
                {
                    int newQuantity = int.Parse(row.Cells[3].Value.ToString()) + int.Parse(quantityNumericUpDown.Value.ToString());

                    if (newQuantity <= int.Parse(productsDataGridView.CurrentRow.Cells[3].Value.ToString()))
                        row.Cells[3].Value = int.Parse(row.Cells[3].Value.ToString()) + int.Parse(quantityNumericUpDown.Value.ToString());
                    else
                    {
                       MessageBox.Show("Задана кількість перевищує наявну кількість");
                        return;
                    }
                    alreadyInReceipt = true;
                    break;
                }
            }
            if (!alreadyInReceipt)
            {
                if (int.Parse(quantityNumericUpDown.Value.ToString()) <= int.Parse(productsDataGridView.CurrentRow.Cells[3].Value.ToString()))
                    receiptDataGridView.Rows.Add(productsDataGridView.CurrentRow.Cells[0].Value, productsDataGridView.CurrentRow.Cells[1].Value, productsDataGridView.CurrentRow.Cells[2].Value, quantityNumericUpDown.Value.ToString());
                else
                {
                    MessageBox.Show("Задана кількість перевищує наявну кількість");
                    return;
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (receiptDataGridView.SelectedCells.Count == 0) return;

            if (receiptDataGridView.CurrentRow.Cells[0].Value == null)
                return;
            receiptDataGridView.Rows.RemoveAt(receiptDataGridView.CurrentRow.Index);
        }

        public void FillReceipt()
        {
            receipt.CreatedDate = DateTime.Now;

            receipt.items = new List <ReceiptItem>();

            foreach (DataGridViewRow row in receiptDataGridView.Rows)
            {
                if (row.Cells[0].Value == null) break;
                receipt.items.Add(
                        new ReceiptItem()
                        {
                            Id = int.Parse(row.Cells[0].Value.ToString()),
                            ProductName = row.Cells[1].Value.ToString(),
                            Price = decimal.Parse(row.Cells[2].Value.ToString()),
                            Quantity = int.Parse(row.Cells[3].Value.ToString())
                        }
                    );
            }
        }

        // The PrintPage event handler
        public void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            //Fill receipt object
            FillReceipt();

            //Get discount
            int discount = 0;
            if (cardCheckBox.Checked)
            {
                discount = Convert.ToInt32(ExecuteScalar("select discount from client_card where client_name = N'" + clientComboBox.Text + "'"));
                receipt.Card_id = Convert.ToInt32(clientComboBox.SelectedValue);
                receipt.Discount = discount;
            }
                
            // Get the Graphics object
            Graphics g = ev.Graphics;
            SolidBrush brush = new SolidBrush(Color.Black);

            g.DrawString("Аптека лікарських рослин",
             new Font("Arial", 22, FontStyle.Bold), brush,
             new Rectangle(30, 50, 500, 500));

            g.DrawString("Чек",
             new Font("Arial", 20, FontStyle.Bold), brush,
             new Rectangle(180, 80, 500, 500));

            g.DrawString(receipt.CreatedDate.ToString("dd.MM.yyyy HH:mm:ss"),
             new Font("Arial", 12), brush,
             new Rectangle(150, 110, 500, 500));

            int y = 160;
            decimal sum = 0;
            foreach (var item in receipt.items)
            {
                g.DrawString(item.ProductName,
                new Font("Arial", 15), brush,
                new Rectangle(70, y, 500, 500));

                g.DrawString(item.Price.ToString() + " грн. x " + item.Quantity.ToString() + "        " + item.Price * item.Quantity + " грн.",
                new Font("Arial", 15), brush,
                new Rectangle(100, y + 20, 500, 500));

                y += 80;
                sum += item.Price * item.Quantity;
            }

            y += 40;
            g.DrawString("Сума:             " + sum.ToString() + " грн.",
             new Font("Arial", 20), brush,
             new Rectangle(70, y, 500, 500));

            receipt.Sum = Convert.ToDecimal(sum);
            if (discount != 0)
            {
                double percent = 1.0 - discount * 0.01;
                y += 30;
                receipt.Sum = Math.Round((Convert.ToDecimal(sum * (decimal)percent)), 2);
                g.DrawString("Сума зі знижкою:             " + receipt.Sum.ToString() + " грн.",
                new Font("Arial", 15), brush,
                new Rectangle(70, y, 500, 500));
            }
            

            g.DrawString("Дякуємо за покупку!",
             new Font("Arial", 12), brush,
             new Rectangle(150, y + 40, 500, 500));

            //Updating db
            UpdateDB();

            //Automatization task
            int newQuantity, curQuantity;
            foreach (var item in receipt.items)
            {
                curQuantity = Convert.ToInt32(ExecuteScalar("select quantity from product where product_id = " + item.Id));
                newQuantity = Automatization.DefineAdditionalQuantity(item.Id, curQuantity);
            }
        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            // Create a PrintDocument object
            PrintDocument pd = new PrintDocument();
            // Set PrinterName as the selected printer
            // in the printers list
            if (printersList.SelectedItem == null)
                MessageBox.Show("Оберіть принтер");
            else if (receiptDataGridView.Rows[0].Cells[0].Value == null)
                MessageBox.Show("Додайте продукти до покупки");
            else
            {
                pd.PrinterSettings.PrinterName = printersList.SelectedItem.ToString();
                // Add PrintPage event handler
                pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
                // Print the document
                pd.Print();
            }
        }
    }
}
