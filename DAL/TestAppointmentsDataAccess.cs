using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TestAppointmentsDataAccess
    {
        public static bool FindFromTestAppointmentsByTestAppointmentID(int TestAppointmentID, ref int TestTypeID, ref int LocalDrivingLicenseApplicationID, ref object AppointmentDate, ref decimal PaidFees, ref int CreatedByUserID, ref bool IsLocked, ref int RetakeTestApplicationID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {

                string query = @"SELECT * FROM TestAppointments Where TestAppointmentID = @TestAppointmentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);


                    try
                    {

                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {

                            TestAppointmentID = (int)reader["TestAppointmentID"];

                            TestTypeID = (int)reader["TestTypeID"];

                            LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];

                            AppointmentDate = (object)reader["AppointmentDate"];

                            PaidFees = (decimal)reader["PaidFees"];

                            CreatedByUserID = (int)reader["CreatedByUserID"];

                            IsLocked = (bool)reader["IsLocked"];

                            if (reader["RetakeTestApplicationID"] != System.DBNull.Value)

                            {

                                RetakeTestApplicationID = (int)reader["RetakeTestApplicationID"];

                            }

                            else

                                RetakeTestApplicationID = -1;


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
        public static bool IsExistsInTestAppointmentsByTestAppointmentID(int TestAppointmentID)


        {

            int isExists = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {

                string query = "SELECT Found=1 FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);


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
        public static int AddNewToTestAppointments(int TestTypeID, int LocalDrivingLicenseApplicationID, object AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)


        {

            int TestAppointmentID = -1;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"INSERT INTO TestAppointments(	[TestTypeID],
	[LocalDrivingLicenseApplicationID],
	[AppointmentDate],
	[PaidFees],
	[CreatedByUserID],
	[IsLocked],
	[RetakeTestApplicationID]
)

		VALUES(

	@TestTypeID,

	@LocalDrivingLicenseApplicationID,

	@AppointmentDate,

	@PaidFees,

	@CreatedByUserID,

	@IsLocked,

	@RetakeTestApplicationID
);

		SELECT SCOPE_IDENTITY();"
        ;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);

            if (RetakeTestApplicationID != 0)



                try
                {

                    connection.Open();

                    TestAppointmentID = Convert.ToInt32(command.ExecuteScalar());

                }
                catch (Exception ex)
                {

                    throw;


                }

                finally

                {

                    connection.Close();

                }


            return TestAppointmentID;

        }
        public static bool UpdateFromTestAppointments(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, object AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)


        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"UPDATE TestAppointments
	SET 		[TestTypeID] = @TestTypeID,
		[LocalDrivingLicenseApplicationID] = @LocalDrivingLicenseApplicationID,
		[AppointmentDate] = @AppointmentDate,
		[PaidFees] = @PaidFees,
		[CreatedByUserID] = @CreatedByUserID,
		[IsLocked] = @IsLocked,
		[RetakeTestApplicationID] = @RetakeTestApplicationID

	WHERE TestAppointmentID = @TestAppointmentID"
        ;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);

            if (RetakeTestApplicationID != 0)



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
        public static bool DeleteFromTestAppointments(int TestAppointmentID)


        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Delete FROM TestAppointments
	WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);


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
        public static DataTable GetAllFromTestAppointments()

        {

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = @"SELECT * FROM TestAppointments";

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
