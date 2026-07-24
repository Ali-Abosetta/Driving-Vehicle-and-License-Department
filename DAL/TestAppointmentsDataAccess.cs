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
        public static bool FindFromTestAppointmentsByTestAppointmentID(int TestAppointmentID, ref int TestTypeID, ref int LocalDrivingLicenseApplicationID, ref DateTime AppointmentDate, ref decimal PaidFees, ref int CreatedByUserID, ref bool IsLocked, ref int? RetakeTestApplicationID)
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

                            AppointmentDate = (DateTime)reader["AppointmentDate"];

                            PaidFees = (decimal)reader["PaidFees"];

                            CreatedByUserID = (int)reader["CreatedByUserID"];

                            IsLocked = (bool)reader["IsLocked"];

                            if (reader["RetakeTestApplicationID"] != System.DBNull.Value)
                                RetakeTestApplicationID = (int)reader["RetakeTestApplicationID"];
                            else
                                RetakeTestApplicationID = null;

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
        public static int AddNewToTestAppointments(int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked, int? RetakeTestApplicationID)


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

            if (RetakeTestApplicationID == null)
            {
                command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
            }



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
        public static bool UpdateFromTestAppointments(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, decimal PaidFees, int CreatedByUserID, bool IsLocked, int? RetakeTestApplicationID)


        {

            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {

                string query = @"UPDATE TestAppointments
	                            SET
                                [TestTypeID] = @TestTypeID,
		                        [LocalDrivingLicenseApplicationID] = @LocalDrivingLicenseApplicationID,
		                        [AppointmentDate] = @AppointmentDate,
		                        [PaidFees] = @PaidFees,
		                        [CreatedByUserID] = @CreatedByUserID,
		                        [IsLocked] = @IsLocked,
		                        [RetakeTestApplicationID] = @RetakeTestApplicationID

                            	WHERE TestAppointmentID = @TestAppointmentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    try
                    {
                        command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                        command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                        command.Parameters.AddWithValue("@PaidFees", PaidFees);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@IsLocked", IsLocked);

                        if (RetakeTestApplicationID.HasValue)
                        {
                            command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
                        }

                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
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

        public static DataTable GetTestAppointmentSummary(int ApplicantID, int TestTypeID, int LicenseClassID)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.ConnectionString))
            {
                string query =
                $@"SELECT 
	                ta.TestAppointmentID AS [Appointment ID],
	                FORMAT(ta.AppointmentDate, 'dd/MM/yyyy') AS [Appointment date],
	                ta.PaidFees AS [Paid Fees],
                	                ta.IsLocked AS [Is Looked]
                FROM TestAppointments ta
	                JOIN LocalDrivingLicenseApplications l
	                ON ta.LocalDrivingLicenseApplicationID = l.LocalDrivingLicenseApplicationID
	                JOIN Applications a 
	                ON l.ApplicationID = a.ApplicationID
					JOIN LicenseClasses c
					ON c.LicenseClassID = l.LicenseClassID
                WHERE ta.TestTypeID = @TestTypeID 
	                AND a.ApplicantPersonID = @ApplicantPersonID
					AND l.LicenseClassID = @LicenseClassID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    try
                    {
                        command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantID);
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                        command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                            reader.Close();
                        }

                        foreach (DataColumn column in dataTable.Columns)
                        {
                            column.ReadOnly = false;
                        }

                        dataTable.PrimaryKey = new DataColumn[]
                        {
                                dataTable.Columns["Appointment ID"]
                        };
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }
            return dataTable;

        }
        public static int GetTestTrials(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            int Trials = 0;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string query = @"SELECT Count(TestAppointmentID) 
                                 FROM TestAppointments
                                 WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                                    AND TestTypeID = @TestTypeID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                        Trials = Convert.ToInt32(command.ExecuteScalar());

                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }

            return Trials;
        }

        public static bool HasActiveAppointment(int PersonID, int TestTypeID, int LicenseClassID)
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string query = @"SELECT Found = 1
                        FROM TestAppointments ta
	                        JOIN LocalDrivingLicenseApplications l
		                        ON l.LocalDrivingLicenseApplicationID = ta.LocalDrivingLicenseApplicationID
	                        JOIN Applications a
		                        ON a.ApplicationID = l.ApplicationID
                        WHERE ta.IsLocked = 0 
	                        AND a.ApplicantPersonID = @PersonID AND ta.TestTypeID = @TestTypeID
 							AND l.LicenseClassID = @LicenseClassID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                        command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                        connection.Open();

                        result = Convert.ToInt32(command.ExecuteScalar());

                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }
            return result > 0;
        }

    }
}
