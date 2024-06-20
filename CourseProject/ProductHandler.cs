using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CourseProject
{
    public class ProductHandler
    {
        const string ConnectionString = "Data Source=DESKTOP-D0GBIS9;Initial Catalog=MedicinalPlantAphotecary;Integrated Security=True";

        public void FillAuxiliaryTables(DataGridView addedPlantDataGridView, DataGridView addedIllnessDataGridView)
        {
            SqlConnection cnn = new SqlConnection(ConnectionString);
            cnn.Open();

            SqlCommand mycommand = new SqlCommand("select product_id from product order by desc", cnn);
            int id = Convert.ToInt32(mycommand.ExecuteScalar());


            foreach (DataGridViewRow row in addedPlantDataGridView.Rows)
            {
                string sqlString = "insert into Plant_in_Product (Plant_id, Product_id) values (" + row.Cells[0].Value + ", " + id + ")";

                mycommand = new SqlCommand(sqlString, cnn);
                mycommand.ExecuteNonQuery();
            }
            foreach (DataGridViewRow row in addedIllnessDataGridView.Rows)
            {
                string sqlString = $"insert into Product_from_Illness (Illness_id, Product_id) values (" + row.Cells[0].Value + ", " + id + ")";

                mycommand = new SqlCommand(sqlString, cnn);
                mycommand.ExecuteNonQuery();
            }
        }
    }
}
