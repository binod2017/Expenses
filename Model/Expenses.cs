using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Expenses 
    {
        public int ID { get; set; }
        public string Item { get; set; }
        public string Price { get; set; }
		public string Quantity { get; set; }
        public DateTime DateSpent { get; set; }
        public int Days { get; set; }
        public string Months { get; set; }
        public int Years { get; set; }
        public bool Active { get; set; }
    }
}
