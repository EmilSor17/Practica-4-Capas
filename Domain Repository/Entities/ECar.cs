using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Repository.Entities
{
    public class ECar
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string CarId { get; set; }
        public string UserId { get; set; }
        public int Year { get; set; }
        public bool Status { get; set; }

    }
}
