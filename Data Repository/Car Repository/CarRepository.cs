using Domain_Repository.DTOs;
using Domain_Repository.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data_Repository.Car_Repository
{
    public class CarRepository
    {
        public static List<CarDTO> ShowCars()
        {
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_ShowCar",con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                List<CarDTO> cars = new List<CarDTO>();
                while(reader.Read())
                {
                    cars.Add(new CarDTO {
                        CardId = reader["Placa"].ToString(),
                        Brand = reader["Marca"].ToString(),
                        Model = reader["Modelo"].ToString(),
                        Color = reader["Color"].ToString(),
                        Id = int.Parse(reader["Id"].ToString()),
                        FirstName = reader["Nombre"].ToString(),
                        Year = int.Parse(reader["Año"].ToString()),
                        Status = Convert.ToBoolean(reader["Estado"])

                    });
                }
                return cars;

            }
        }
        public static bool AddCar (ECar car)
        {
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_AddCar", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add( new SqlParameter("@Brand",car.Brand));
                cmd.Parameters.Add(new SqlParameter("@Model", car.Model));
                cmd.Parameters.Add(new SqlParameter("@Year", car.Year));
                cmd.Parameters.Add(new SqlParameter("@Color", car.Color));
                cmd.Parameters.Add(new SqlParameter("@UserId", car.UserId));
                cmd.Parameters.Add(new SqlParameter("@IdCar", car.CarId));
                cmd.Parameters.Add(new SqlParameter("@Status", car.Status));
                if(cmd.ExecuteNonQuery()>0)
                { return true; }
                else
                { return false; }
            }
        }
        public static bool DisableCar(int id)
        {
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_DisableCar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Id", id));
                if(cmd.ExecuteNonQuery()>0)
                { return true; }
                else
                { return false; }

            }
        }
        public static bool EnableCar(int id)
        {
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_EnableCar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Id", id));
                if (cmd.ExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }

            }
        }
        public static bool UpdateCar (ECar car)
        {
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_UpdateCar",con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Brand", car.Brand));
                cmd.Parameters.Add(new SqlParameter("@Model", car.Model));
                cmd.Parameters.Add(new SqlParameter("@Year", car.Year));
                cmd.Parameters.Add(new SqlParameter("@Color", car.Color));
                cmd.Parameters.Add(new SqlParameter("@UserId", car.UserId));
                cmd.Parameters.Add(new SqlParameter("@Id", car.Id));
                if (cmd.ExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
        }
        public static List<cbbNameDTO> cbbnameclient ()
        {
            using (SqlConnection con = new SqlConnection(Connectionstring.connection))
            {
                if (con.State != ConnectionState.Open) con.Open();
                SqlCommand cmd = new SqlCommand("sp_cbbName", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                List<cbbNameDTO> cbb = new List<cbbNameDTO>();
                while (reader.Read())
                {
                    cbb.Add(new cbbNameDTO { 
                        Cedula = reader["Cedula"].ToString(),
                         FullName = reader["Nombre"].ToString()
                     });
                    
                }
                
                return cbb;
            }
        }
    }
    
}

