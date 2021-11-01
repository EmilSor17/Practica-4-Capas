using Domain_Repository.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Repository.Client_Repository
{
    public class ClientRepository
    {
        public static List<ClientDTO> ShowClient ()
        {
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                if (con.State != System.Data.ConnectionState.Open) con.Open();
                SqlCommand cmd = new SqlCommand("sp_ShowClient", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                List<ClientDTO> Client = new List<ClientDTO>();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Client.Add(new ClientDTO
                    {
                        Id = reader["Id"].ToString(),
                        FirstName = reader["Nombre"].ToString(),
                        Fecha = Convert.ToDateTime(reader["Fecha"].ToString()),
                        State = Convert.ToBoolean(reader["Estado"].ToString())
                    });
                }
                return Client;
            }
        }
        public static bool Addclient(ClientDTO client)
        {
            using(SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                if (con.State != System.Data.ConnectionState.Open) con.Open();
                SqlCommand cmd = new SqlCommand("sp_AddClient", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@PersonId", client.Id));
                cmd.Parameters.Add(new SqlParameter("@FirstName", client.FirstName));
                cmd.Parameters.Add(new SqlParameter("@LastName", client.LastName));
                cmd.Parameters.Add(new SqlParameter("@Date", client.Fecha));
                cmd.Parameters.Add(new SqlParameter("@State", client.State));
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
        public static bool Disableclient(int id)
        {
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_DisableClient", con);
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
        public static bool Enableclient(int id)
        {
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_EnableClient", con);
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
