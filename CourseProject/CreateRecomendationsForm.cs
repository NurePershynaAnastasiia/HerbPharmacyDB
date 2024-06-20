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
    public partial class CreateRecomendationsForm : Form
    {
        const string ConnectionString = "Data Source=DESKTOP-D0GBIS9;Initial Catalog=MedicinalPlantAphotecary;Integrated Security=True";
        List <Recommendation> recommendations;

        public CreateRecomendationsForm()
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

        private void GetRecomendationsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicinalPlantAphotecaryDataSet.Illness' table. You can move, or remove it, as needed.
            this.illnessTableAdapter.Fill(this.medicinalPlantAphotecaryDataSet.Illness);

            //filling printers list
            if (PrinterSettings.InstalledPrinters.Count <= 0)
                MessageBox.Show("Printer not found!");
            else foreach (String printer in PrinterSettings.InstalledPrinters)
                    printersList.Items.Add(printer.ToString());

            recommendations = new List<Recommendation>();

        }

        public void FillRecommendation()
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                string sqlString = "select product_id, product_name, price, contraindication, brand_name from product, brand where brand = brand_id and product_id in (select product_id from product_from_illness where illness_id = " + illnessComboBox.SelectedValue.ToString() + ")";
                SqlDataAdapter oda = new SqlDataAdapter(sqlString, sqlconn);
                DataTable rec = new DataTable();
                oda.Fill(rec);

                foreach (DataRow row in rec.Rows)
                {
                    if (row[0] == null) break;
                    else
                    {
                        int product_id = Convert.ToInt32(row[0]);
                        sqlString = "select p.plant_name from medicinal_plant p, plant_in_product pp where p.plant_id = pp.plant_id and pp.product_id = " + product_id.ToString();
                        SqlDataAdapter oda1 = new SqlDataAdapter(sqlString, sqlconn);
                        DataTable plants = new DataTable();
                        oda1.Fill(plants);

                        List <string> plant_name = new List<string>();
                        foreach (DataRow plant_row in plants.Rows)
                            plant_name.Add(plant_row[0].ToString());

                        Recommendation current_recommendation = new Recommendation()
                        {
                            Product_name = row[1].ToString(),
                            Price = Convert.ToDecimal(row[2]),
                            Contraindications = row[3].ToString(),
                            Brand = row[4].ToString(),
                            Plants = plant_name
                        };
                        recommendations.Add(current_recommendation);
                    };
                        
                }
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Щось пішло не так");
            }
        }

        // The PrintPage event handler
        public void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            FillRecommendation();

            // Get the Graphics object
            Graphics g = ev.Graphics;
            SolidBrush brush = new SolidBrush(Color.Black);

            g.DrawString("Рекомендації щодо лікування хвороби " + illnessComboBox.Text,
             new Font("Arial", 22, FontStyle.Bold), brush,
             new Rectangle(90, 40, 1000, 500));

            g.DrawString("Продукти, які використовують при лікуванні: ",
             new Font("Arial", 20), brush,
             new Rectangle(30, 120, 1000, 500));

            int y = 150;
            foreach (var recommendation in recommendations)
            {
                g.DrawString("Назва: " + recommendation.Product_name,
                new Font("Arial", 15), brush,
                new Rectangle(70, y, 1000, 500));

                y += 25;
                g.DrawString("Ціна: " + recommendation.Price.ToString() + " грн.",
                new Font("Arial", 15), brush,
                new Rectangle(70, y, 1000, 500));

                y += 25;
                g.DrawString("Бренд-виробник: " + recommendation.Brand,
                new Font("Arial", 15), brush,
                new Rectangle(70, y, 1000, 500));

                y += 25;
                g.DrawString("Протипоказання: " + recommendation.Contraindications,
                new Font("Arial", 15), brush,
                new Rectangle(70, y, 1000, 500));

                y += 25;
                g.DrawString("Лікарскі рослини у складі: ",
                new Font("Arial", 15), brush,
                new Rectangle(100, y, 500, 500));

                foreach (var plant in recommendation.Plants)
                {
                    y += 25;
                    g.DrawString("- " + plant,
                    new Font("Arial", 15), brush,
                    new Rectangle(150, y, 500, 500));
                }
                y += 70;
            }

            g.DrawString("Дата створення: " + DateTime.Now,
                new Font("Arial", 14), brush,
               new Rectangle(200, y, 1000, 500));
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            // Create a PrintDocument object
            PrintDocument pd = new PrintDocument();
            // Set PrinterName as the selected printer
            // in the printers list
            if (printersList.SelectedItem == null)
                MessageBox.Show("Оберіть принтер");
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
