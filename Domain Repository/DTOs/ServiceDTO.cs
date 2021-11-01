using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Repository.DTOs
{
    public class ServiceDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Coste { get; set; }
        public bool State { get; set; }
    }
}
