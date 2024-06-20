using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public class InfoDB
    {
        public static Dictionary<string, string[]> labelDictionary = new Dictionary<string, string[]>()
        {
            { "Продукти", new string[] {"Product", "Product_Name"} },
            { "Бренди", new string[] {"Brand", "Brand_Name" } },
            { "Хвороби", new string[] {"Illness", "Illness_Name" } },
            { "Лікарські рослини", new string[] {"Medicinal_Plant", "Plant_Name"} },
            { "Клієнтські картки", new string[] {"Client_Card", "Client_Name"} }
        };

        public static Dictionary<string, string[]> filterDictionaryMain = new Dictionary<string, string[]>()
        {
            { "Класифікацією", new string[] { "Medicinal_Plant", "Classification"} },
            { "Країною", new string[] { "Brand", "Country"} },
            { "Роком заснування", new string[] { "Brand", "Founding_Year"} },
            { "Складністю", new string[] { "Illness", "Severity"} },
            { "Типом", new string[] { "Client_Card", "Card_Type"} },
            { "Знижкою", new string[] { "Client_Card", "Discount"} },
            { "Датою реєстрації", new string[] { "Client_Card", "Registration_Date"} },
            { "Датою", new string[] { "Purchase", "Date"} },
            { "Брендом", new string[] { "Brand", "Brand_Name"} },
            { "Хворобою", new string[] { "Illness", "Illness_Name"} },
            { "Лікарською рослиною", new string[] { "Medicinal_Plant", "Plant_Name"} },
            { "Власником картки", new string[] { "Client_Card", "Client_Name"} }
        };
    }
}
