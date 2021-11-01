using Domain_Repository.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Repository.Mechanical_Repository
{
    public class MechanicalRepository
    {
        public static List<MechanicalDTO> mechanicals ()
        {
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_ShowMechanicals", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                List<MechanicalDTO> mechanicals = new List<MechanicalDTO>();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    mechanicals.Add(new MechanicalDTO
                    {
                        Id = reader["Id"].ToString(),
                        FirstName = reader["NombreMecanico"].ToString(),
                        Type = reader["Tipo"].ToString(),
                        Status = Convert.ToBoolean(reader["Estado"].ToString()),
                        Date = Convert.ToDateTime(reader["Dateb"].ToString())
                    });
                }
                
                return mechanicals;
            }
            
        }
        public static bool AddMechanical(MechanicalDTO mechanical)
        {
            using(SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_AddMechanical",con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@IdPerson",mechanical.Id));
                cmd.Parameters.Add(new SqlParameter("@FirstName",mechanical.FirstName));
                cmd.Parameters.Add(new SqlParameter("@Status", mechanical.Status));
                cmd.Parameters.Add(new SqlParameter("@MechanicalType", mechanical.Type));
                cmd.Parameters.Add(new SqlParameter("@LastName", mechanical.LastName));
                cmd.Parameters.Add(new SqlParameter("@Birth", mechanical.Date));
                if (cmd.ExecuteNonQuery()>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }            
        }
        public static bool DisableMechanical(int id)
        {
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_DisableMechanical",con);
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
        public static bool EnableMechanical(int id)
        {
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_EnableMechanical", con);
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
