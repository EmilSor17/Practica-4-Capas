using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Repository.DTOs
{
    public class cbbOrderDTO
    {
        public int CarId { get; set; }
        public string Car { get; set; }
        public int Mid { get; set; }
        public string MechanicalName { get; set; }
        public string ClienId { get; set; }
        public string ClientName { get; set; }
        public string ServiceName { get; set; }
        public int Code { get; set; }
        public DateTime Date { get; set; }
    }
}
