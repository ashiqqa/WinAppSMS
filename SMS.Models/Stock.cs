using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models
{
   public class Stock
    {
        public int CompanyId { get; set; }
        public int ItemId { get; set; }
        public int ReorderLevel { get; set; }
        public int AvailableQuantity { get; set; }
        public int Quantity { get; set; }
    }
}
