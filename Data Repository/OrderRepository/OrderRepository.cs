using Domain_Repository.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Repository.OrderRepository
{
    public class OrderRepository
    {
        public static List<OrderDTO> ShowOrders ()
        {
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_ShowOrder", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                List<OrderDTO> order = new List<OrderDTO>();
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    order.Add(new OrderDTO {
                    Brand = reader["Marca"].ToString(),
                    OrdenId = int.Parse(reader["Orden Id"].ToString()),
                    Service = reader["snombre"].ToString(),
                    MechanicalName = reader["NombreMecanico"].ToString(),
                    ClientName = reader["NombreCliente"].ToString(),
                        Date = Convert.ToDateTime(reader["Fecha y Hora"].ToString()),
                    Model = reader["Modelo"].ToString(),
                    Coste = int.Parse(reader["Costo"].ToString())
                    });                    
                }
                return order;
            }                
        }
        public static List<cbbOrderDTO> cbbm()
        {
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_cbbMecanico", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                List<cbbOrderDTO> cbbs = new List<cbbOrderDTO>();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbbs.Add(new cbbOrderDTO
                    {

                        Mid = int.Parse(reader["Id"].ToString()),
                        MechanicalName = reader["Nombre"].ToString()
                    });
                }
                return cbbs;
            }
        }
            public static List<cbbOrderDTO> cbbs()
            {
                using (SqlConnection con = new SqlConnection(Connectionstring.connection))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_cbbServicios", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    List<cbbOrderDTO> cbbs = new List<cbbOrderDTO>();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cbbs.Add(new cbbOrderDTO
                        {

                            ServiceName = reader["sNombre"].ToString(),
                            Code = int.Parse(reader["Code"].ToString()),
                            
                        });
                    }
                    return cbbs;
                }
            }
        public static List<cbbOrderDTO> cbbCC()
        {
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_cbbClient", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                List<cbbOrderDTO> order = new List<cbbOrderDTO>();
                while(reader.Read())
                {
                    order.Add(new cbbOrderDTO
                    {
                        ClientName = reader["Nombre"].ToString(),
                        ClienId= reader["pid"].ToString()
                    });
                }
                return order;
            }
        }
        public static List<cbbOrderDTO> cbbCars()
        {
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_cbbCar", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                List<cbbOrderDTO> order = new List<cbbOrderDTO>();
                while (reader.Read())
                {
                    order.Add(new cbbOrderDTO
                    {
                        Car= reader["Brand"].ToString(),
                        CarId = int.Parse(reader["Id"].ToString())

                    });
                }
                return order;
            }
        }
        public static bool PlaceOrder(cbbOrderDTO order)
        {
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_PlaceOrder", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@fecha", order.Date));
                cmd.Parameters.Add(new SqlParameter("@CarroId",order.CarId));
                cmd.Parameters.Add(new SqlParameter("@ClientId", order.ClienId));
                cmd.Parameters.Add(new SqlParameter("@ServicioId", order.Code));
                cmd.Parameters.Add(new SqlParameter("@MecanicoId", order.Mid));
                if(cmd.ExecuteNonQuery()>0)
                {
                    return true;
                }
                else
                {

                    return false;
                }

            }
        }

    }
}
