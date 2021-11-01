using Domain_Repository.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Repository.Services_Repository
{
    public class ServicesRepository
    {
        public static List<ServiceDTO> service()
        {
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_ShowServices", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                List<ServiceDTO> service = new List<ServiceDTO>();
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    service.Add(new ServiceDTO
                    {
                        State = Convert.ToBoolean(reader["Estado"].ToString()),
                        Coste = int.Parse(reader["Costo"].ToString()),
                        Id = int.Parse(reader["Codigo"].ToString()),
                        Name = reader["Nombre"].ToString()
                    });                    
                }
                return service;
            }
        }
        public static bool AddService (ServiceDTO service)
        {
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_AddServices", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Name", service.Name));
                cmd.Parameters.Add(new SqlParameter("@Coste", service.Coste));
                cmd.Parameters.Add(new SqlParameter("@State", service.State));
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
        public static bool DisableService(int id)
        {
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_DisableService", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Id", id));
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
        public static bool EnableService(int id)
        {
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_EnableService", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Id", id));
                if (cmd.ExecuteNonQuery() > 0)
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
