using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTestApp
{
    public class Delivery:IHasId
    {

        public int Id { get; set; }
        public DateTime ShipmentDate { get; set; }
        public int OrderId { get; set; }
        public string Status { get; set; } = "Pending";

        public override string ToString()
        {
            return Id + " " + OrderId + " " + Status;
        }


    }
}
