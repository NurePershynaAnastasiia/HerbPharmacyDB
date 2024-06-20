using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public class ReceiptPurchase
    {
        public DateTime CreatedDate { get; set; }
        public List <ReceiptItem> items { get; set; }
        public decimal Sum { get; set; }
        public int Discount { get; set; }
        public int Card_id { get; set; }
    }
}
