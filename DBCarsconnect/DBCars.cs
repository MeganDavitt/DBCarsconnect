using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DBCarsconnect
{
    class DBCars
    {
        public MySqlDataReader GetCars(MySqlConnection connection)
        {
            string sql = "SELECT * FROM car;";

            MySqlCommand cmd = new MySqlCommand(sql, connection);

            MySqlDataReader reader = null;

            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Exception found: " + ex.Message);
            }

            return reader;
        }


        public bool Update(MySqlConnection connection, CarInfo carInfo) //ADD originalVehicleRegNo
        {
            // Sample UPDATE sql:
            // UPDATE car SET VehicleRegNo = 'BV557UTR', Make = 'Mazda', EngineSize = '1.6L', DateRegistered = '2007-06-12 00:00:00', RentalPerDay = 80, Available = 0 WHERE VehicleRegNo = 'BV557UTR';
                                                                                                                                                                                                          //Add OriginalVehicleRegNo
            string sql = "UPDATE car SET VehicleRegNo = @vehicleRegNo, Make = @make, EngineSize = @engineSize, DateRegistered = @dateRegistered, RentalPerDay = @rentalCost, Available = @available WHERE VehicleRegNo = @vehicleRegNo;";

            MySqlCommand cmd = new MySqlCommand(sql, connection);

            //cmd.Parameters.AddWithValue("@originalVehicleNo", carInfo.OriginalVehicleRegNo);
            cmd.Parameters.AddWithValue("@vehicleRegNo", carInfo.VehicleRegNo);
            cmd.Parameters.AddWithValue("@make", carInfo.Make);
            cmd.Parameters.AddWithValue("@engineSize", carInfo.EngineSize);
            cmd.Parameters.AddWithValue("@dateRegistered", carInfo.DateRegistered);
            cmd.Parameters.AddWithValue("@rentalCost", carInfo.RentalPerDay);
            cmd.Parameters.AddWithValue("@available", carInfo.Available);

            try
            {
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Exception found:" + ex.Message);
                return false;
            }
            return true;

        }


        public bool Insert(MySqlConnection connection, CarInfo carInfo)
        {
            string sql = "INSERT INTO car VALUES (@vehicleRegNo, @make, @engineSize, @dateRegistered, @rentalCost, @available);"; 


            MySqlCommand cmd = new MySqlCommand(sql, connection);

         
            cmd.Parameters.AddWithValue("@vehicleRegNo", carInfo.VehicleRegNo); 
            cmd.Parameters.AddWithValue("@make", carInfo.Make);
            cmd.Parameters.AddWithValue("@engineSize", carInfo.EngineSize);
            cmd.Parameters.AddWithValue("@dateRegistered", carInfo.DateRegistered);
            cmd.Parameters.AddWithValue("@rentalCost", carInfo.RentalPerDay);
            cmd.Parameters.AddWithValue("@available", carInfo.Available);

            try
            {
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Exception found:" + ex.Message);
                return false;
            }
            return true;
        }

       
        public void Delete(MySqlConnection connection, string vehicleRegNo) // change to public bool
        {
            // TODO: Add code to DELETE a car table record

            MessageBox.Show("Are you sure?");

            string sql = "DELETE FROM car WHERE vehicleRegNo = 'AB376DER' ";

            MySqlCommand cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@vehicleRegNo", vehicleRegNo);

            cmd.Prepare();
            cmd.ExecuteNonQuery();

        }
    }
}

