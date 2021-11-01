using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Repository.DTOs
{
    public class OrderDTO
    {
        public int OrdenId { get; set; }
        public string Service { get; set; }
        public int Coste { get; set; }
        public string MechanicalName { get; set; }
        public DateTime Date { get; set; }
        public string  Brand { get; set; }
        public string Model { get; set; }
        public string ClientName { get; set; }

    }
}
