using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing.Responses
{
    public class OrderSummary
    {
        public string Status { get; set; }
        public string Category {  get; set; }
        public int Count { get; set; }
    }
}
