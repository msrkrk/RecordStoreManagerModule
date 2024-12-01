using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace RecordStoreManagerModule.DAL.Entities
{
    public class Album:BaseClass
    {
        public string Name { get; set; }
        public string Artist { get; set; }

        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public double? Discount { get; set; }
        public bool IsOnSale { get; set; }
    }
}
