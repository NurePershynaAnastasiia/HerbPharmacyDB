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
    public partial class StatisticsForm : Form
    {
        int button_pressed;

        const string ConnectionString = "Data Source=DESKTOP-D0GBIS9;Initial Catalog=MedicinalPlantAphotecary;Integrated Security=True";

        public StatisticsForm(int button_pressed)
        {
            this.button_pressed = button_pressed;
            InitializeComponent();
        }


        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            string sqlString = "";
            switch (button_pressed)
            {
                case 1: sqlString = "select P.Product_Name, sum(PQ.Quantity) as Quantity_Bought from Product P, Product_Quantity PQ where P.Product_Id = PQ.Product_id group by P.Product_Name order by sum(PQ.Quantity) desc";
                    nameLabel.Text = "Найпопулярніші продукти";
                    break;
                case 2:
                    sqlString = "select Iln.Illness_Name, sum(PQ.Quantity) as Products_Bought from Product P, Product_Quantity PQ, Illness Iln where(P.Product_Id = PQ.Product_id) and(Iln.Illness_Id in (select PFInh.Illness_Id from Product_from_Illness PFInh where PFInh.Product_id = P.Product_Id)) group by Iln.Illness_Name order by sum(PQ.Quantity) desc;";
                    nameLabel.Text = "Найрозповсюдженіші хвороби";
                    break;
                case 3:
                    sqlString = "select B.Brand_Name, count(P.Brand) as Number_of_Products from Brand B, Product P where Brand_id = Brand group by B.Brand_Name order by count(P.Brand) desc";
                    nameLabel.Text = "Статистика брендів \r\nза поставленими найменуваннями";
                    break;
                case 4:
                    sqlString = "select distinct month(p.date) as Month, year(p.date) as Year, sum(p.sum) as Total_profit from purchase p group by month(p.date), year(p.date) order by year(p.date), month(p.date)";
                    nameLabel.Text = "Статистика продажів за місяцями";
                    break;
            }
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter(sqlString, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                statisticsDataGridView.DataSource = dt;
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка");
            }
        }
    }
}
