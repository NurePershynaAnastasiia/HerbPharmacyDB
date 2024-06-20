using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CourseProject
{
    public class Automatization
    {
        const string ConnectionString = "Data Source=DESKTOP-D0GBIS9;Initial Catalog=MedicinalPlantAphotecary;Integrated Security=True";

        public static Dictionary<int, int> DaysInMonths = new Dictionary<int, int>()
        {
            { 1, 31},
            { 2, 28},
            { 3, 31},
            { 4, 30},
            { 5, 31},
            { 6, 30},
            { 7, 31},
            { 8, 31},
            { 9, 30},
            { 10, 31},
            { 11, 30},
            { 12, 31},
            {0, 31}
        };

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

        public static int GetAvgCurM (int Product_id)
        {
            DateTime curDate = DateTime.Now;
            string sqlString = "select count(Product_Quantity.Quantity) " +
                                "from Product_Quantity " +
                                "inner join Product on Product.Product_Id = Product_Quantity.Product_id " +
                                "inner join Purchase on Purchase.Purchase_id = Product_Quantity.Purchase_id " +
                                "where month(Purchase.Date) = " + curDate.Month + " and year(Purchase.Date) = " + curDate.Year + " and Product.Product_Id = " + Product_id + " " +
                                "group by Product.Product_id";

            string res = ExecuteScalar(sqlString);
            if (res == "") return 0;
            return Convert.ToInt32(res) / curDate.Day + ((Convert.ToInt32(res) % curDate.Day != 0)? 1 : 0);
        }

        public static int GetAvgLastM(int Product_id)
        {
            DateTime curDate = DateTime.Now;
            string sqlString = "select count(Product_Quantity.Quantity) " +
                                "from Product_Quantity " +
                                "inner join Product on Product.Product_Id = Product_Quantity.Product_id " +
                                "inner join Purchase on Purchase.Purchase_id = Product_Quantity.Purchase_id " +
                                "where month(Purchase.Date) = " + (curDate.Month - 1) + " and year(Purchase.Date) = " + curDate.Year + " and Product.Product_Id = " + Product_id + " " +
                                "group by Product.Product_id";

            int days_in_month = DaysInMonths[curDate.Month - 1];
            if (curDate.Year % 4 == 0 && curDate.Year % 100 != 0 && (curDate.Month - 1) == 2)
                days_in_month = 29;

            string res = ExecuteScalar(sqlString);
            if (res == "") return 0;
            return Convert.ToInt32(res) / days_in_month + ((Convert.ToInt32(res) % days_in_month != 0) ? 1 : 0);
        }

        public static int GetAvgCurMLastY(int Product_id)
        {
            DateTime curDate = DateTime.Now;
            string sqlString = "select count(Product_Quantity.Quantity) " +
                                "from Product_Quantity " +
                                "inner join Product on Product.Product_Id = Product_Quantity.Product_id " +
                                "inner join Purchase on Purchase.Purchase_id = Product_Quantity.Purchase_id " +
                                "where month(Purchase.Date) = " + curDate.Month + " and year(Purchase.Date) = " + (curDate.Year - 1) + " and Product.Product_Id = " + Product_id + " " +
                                "group by Product.Product_id";
            int days_in_month = DaysInMonths[curDate.Month - 1];
            if ( (curDate.Year - 1) % 4 == 0 && (curDate.Year - 1) % 100 != 0 && curDate.Month == 2)
                days_in_month = 29;

            string res = ExecuteScalar(sqlString);
            if (res == "") return 0;
            return Convert.ToInt32(res) / days_in_month + ((Convert.ToInt32(res) % days_in_month != 0) ? 1 : 0); 
        }

        public static int GetAvgLastMLastY(int Product_id)
        {
            DateTime curDate = DateTime.Now;
            string sqlString = "select count(Product_Quantity.Quantity) " +
                                "from Product_Quantity " +
                                "inner join Product on Product.Product_Id = Product_Quantity.Product_id " +
                                "inner join Purchase on Purchase.Purchase_id = Product_Quantity.Purchase_id " +
                                "where month(Purchase.Date) = " + (curDate.Month - 1) + " and year(Purchase.Date) = " + (curDate.Year - 1) + " and Product.Product_Id = " + Product_id + " " +
                                "group by Product.Product_id";

            int days_in_month = DaysInMonths[curDate.Month - 1];
            if ((curDate.Year - 1) % 4 == 0 && (curDate.Year - 1) % 100 != 0 && (curDate.Month - 1) == 2)
                days_in_month = 29;

            string res = ExecuteScalar(sqlString);
            if (res == "") return 0;
            return Convert.ToInt32(res) / days_in_month + ((Convert.ToInt32(res) % days_in_month != 0) ? 1 : 0);
        }

        public static int GetAnalog(int Product_id)
        {
            string sqlString = "select Iln.Illness_id " +
                            "from Product P, Product_Quantity PQ, Illness Iln " +
                            "where P.Product_Id = " + Product_id + " and " +
                            "(Iln.Illness_Id in (select PFInh.Illness_Id from Product_from_Illness PFInh where PFInh.Product_id = P.Product_Id)) and " +
                            "Iln.Illness_Id in (select iln1.illness_id from illness iln1 inner join Product_from_Illness on Product_from_Illness.Illness_id = iln1.Illness_Id inner join Product on Product_from_Illness.Product_id = Product.Product_id where Product.Product_id = P.Product_Id) " +
                            "group by Iln.Illness_id " +
                            "order by sum(PQ.Quantity) desc";

            int illnessId = Convert.ToInt32(ExecuteScalar(sqlString));

            sqlString = "select Product.Product_id " +
                            "from Product " +
                            "inner join Product_from_Illness on Product_from_Illness.Product_id = Product.Product_id " +
                            "inner join Illness on Product_from_Illness.Illness_id = Illness.Illness_Id " +
                            "inner join Product_Quantity on Product_Quantity.Product_id = Product.Product_Id " +
                            "where Illness.Illness_Id = " + illnessId + " " +
                            "group by Product.Product_id " +
                            "order by sum(Product_Quantity.Quantity) desc";

            string analogProduct = ExecuteScalar(sqlString);
            if (analogProduct == "") return 0;

            int analogProductId = Convert.ToInt32(analogProduct);
            return analogProductId;
        }

        public static int DefineAdditionalQuantity(int Product_id, int curQuantity)
        {
            int neededQuantity = Math.Max(Math.Max(GetAvgLastMLastY(Product_id), GetAvgCurMLastY(Product_id)), Math.Max(GetAvgCurM(Product_id), GetAvgLastM(Product_id)));
            if (neededQuantity == 0)
            {
                int analogProductId = GetAnalog(Product_id);
                neededQuantity = Math.Max(Math.Max(GetAvgLastMLastY(analogProductId), GetAvgCurMLastY(analogProductId)), Math.Max(GetAvgCurM(analogProductId), GetAvgLastM(analogProductId)));
            }

            if (neededQuantity == 0)
                return 14 - curQuantity;

            neededQuantity *= 14;
            if (curQuantity < neededQuantity)
                return neededQuantity - curQuantity; 
            return 0;
        }
    }
}
