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
    public partial class AutomatizationForm : Form
    {

        const string ConnectionString = "Data Source=DESKTOP-D0GBIS9;Initial Catalog=MedicinalPlantAphotecary;Integrated Security=True";
        List<OrderItem> order;
        public AutomatizationForm(List <OrderItem> order)
        {
            InitializeComponent();
            this.order = order;
        }

        private void AutomatizationForm_Load(object sender, EventArgs e)
        {
            //filling receipt table
            System.Windows.Forms.DataGridViewTextBoxColumn Id;
            System.Windows.Forms.DataGridViewTextBoxColumn Name;
            System.Windows.Forms.DataGridViewTextBoxColumn Quantity;

            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();

            Id.HeaderText = "Id";
            Id.Name = "Id";

            Name.HeaderText = "Name";
            Name.Name = "Name";

            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";

            ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, Name, Quantity });

            ordersDataGridView.AutoGenerateColumns = true;


            //filling dataGrid
            foreach (OrderItem orderItem in order)
                ordersDataGridView.Rows.Add(orderItem.Id, orderItem.ProductName, orderItem.OrderQuantity);
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ordersDataGridView.CurrentRow.Cells[0].Value);
            int addQuantity = Convert.ToInt32(ordersDataGridView.CurrentRow.Cells[2].Value);

            SqlConnection cnn = new SqlConnection(ConnectionString);
            cnn.Open();
            SqlCommand mycommand = new SqlCommand("update product set quantity = quantity + " + addQuantity + " where product_id = " + id, cnn);
            mycommand.ExecuteScalar();
            cnn.Close();

            ordersDataGridView.Rows.RemoveAt(ordersDataGridView.CurrentRow.Index);
        }
    }
}
