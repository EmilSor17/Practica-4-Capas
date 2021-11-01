using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Repository
{
    public class Connectionstring
    {
        public static string connection =>
            "Data Source=localhost;Initial Catalog=Taller de Mecanica;Integrated Security=True";

    }
}
