using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DriversDataAccess
    {
        public static bool FindFromDriversByDriverID(int DriverID, ref int PersonID, ref int CreatedByUserID, ref object CreatedDate)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {

                string query = @"SELECT * FROM Drivers Where DriverID = @DriverID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@DriverID", DriverID);


                    try
                    {

                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {

                            DriverID = (int)reader["DriverID"];

                            PersonID = (int)reader["PersonID"];

                            CreatedByUserID = (int)reader["CreatedByUserID"];

                            CreatedDate = (object)reader["CreatedDate"];


                            isFound = true;
                            connection.Close();
                        }

                    }
                    catch (Exception ex)
                    {

                        throw;


                    }

                }
            }


            return isFound;

        }
        public static bool IsExistsInDriversByDriverID(int DriverID)


        {

            int isExists = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {

                string query = "SELECT Found=1 FROM Drivers WHERE DriverID = @DriverID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@DriverID", DriverID);


                    try
                    {

                        connection.Open();

                        isExists = Convert.ToInt32(command.ExecuteScalar());

                    }
                    catch (Exception ex)
                    {

                        throw;


                    }
                }
            }


            return (isExists > 0);

        }
        public static int AddNewToDrivers(int PersonID, int CreatedByUserID, object CreatedDate)


        {

            int DriverID = -1;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"INSERT INTO Drivers(	[PersonID],
	[CreatedByUserID],
	[CreatedDate]
)

		VALUES(

	@PersonID,

	@CreatedByUserID,

	@CreatedDate
);

		SELECT SCOPE_IDENTITY();"
        ;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);



            try
            {

                connection.Open();

                DriverID = Convert.ToInt32(command.ExecuteScalar());

            }
            catch (Exception ex)
            {

                throw;


            }

            finally

            {

                connection.Close();

            }


            return DriverID;

        }
        public static bool UpdateFromDrivers(int DriverID, int PersonID, int CreatedByUserID, object CreatedDate)


        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"UPDATE Drivers
	SET 		[PersonID] = @PersonID,
		[CreatedByUserID] = @CreatedByUserID,
		[CreatedDate] = @CreatedDate

	WHERE DriverID = @DriverID"
        ;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);



            try
            {

                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw;


            }

            finally

            {

                connection.Close();

            }


            return (rowsAffected > 0);

        }
        public static bool DeleteFromDrivers(int DriverID)


        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Delete FROM Drivers
	WHERE DriverID = @DriverID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);


            try
            {

                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw;


            }

            finally

            {

                connection.Close();

            }


            return (rowsAffected > 0);

        }
        public static DataTable GetAllFromDrivers()

        {

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = @"SELECT * FROM Drivers";

            SqlCommand command = new SqlCommand(query, connection);

            DataTable dataTable = new DataTable();



            try
            {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
                reader.Close();

            }
            catch (Exception ex)
            {

                throw;


            }

            finally

            {

                connection.Close();

            }

            return dataTable;

        }

    }
}
