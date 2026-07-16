using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    public class LocalDrivingLicenseApplicationsDataAccess
    {
        public static bool FindFromLocalDrivingLicenseApplicationsByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID, ref int ApplicationID, ref int LicenseClassID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {

                string query = @"SELECT * FROM LocalDrivingLicenseApplications Where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


                    try
                    {

                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {

                            LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];

                            ApplicationID = (int)reader["ApplicationID"];

                            LicenseClassID = (int)reader["LicenseClassID"];


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
        public static bool IsExistsInLocalDrivingLicenseApplicationsByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {

            int isExists = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {

                string query = "SELECT Found=1 FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


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
        public static int AddNewToLocalDrivingLicenseApplications(int ApplicationID, int LicenseClassID)


        {

            int LocalDrivingLicenseApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"INSERT INTO LocalDrivingLicenseApplications(	[ApplicationID],
	[LicenseClassID]
)

		VALUES(

	@ApplicationID,

	@LicenseClassID
);

		SELECT SCOPE_IDENTITY();"
        ;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);



            try
            {

                connection.Open();

                LocalDrivingLicenseApplicationID = Convert.ToInt32(command.ExecuteScalar());

            }
            catch (Exception ex)
            {

                throw;


            }

            finally

            {

                connection.Close();

            }


            return LocalDrivingLicenseApplicationID;

        }
        public static bool UpdateFromLocalDrivingLicenseApplications(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)


        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"UPDATE LocalDrivingLicenseApplications
	SET 		[ApplicationID] = @ApplicationID,
		[LicenseClassID] = @LicenseClassID

	WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID"
        ;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);



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
        public static bool DeleteFromLocalDrivingLicenseApplications(int LocalDrivingLicenseApplicationID)


        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Delete FROM LocalDrivingLicenseApplications
	WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


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
        public static DataTable GetAllFromLocalDrivingLicenseApplications()
        {

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = @"SELECT * FROM LocalDrivingLicenseApplications";

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

        public static DataTable GetLocalDrivingLicenseApplicationsSummary()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string query = @"SELECT l.LocalDrivingLicenseApplicationID AS [L.D.L Application ID],
		                        c.ClassName AS [Driving Class], p.NationalNo [National No.],
		                        [Full name] = p.FirstName + ' ' + p.SecondName + ' ' + 
			                        CASE 
                                    WHEN p.ThirdName is not null
				                        THEN p.ThirdName + ' '
                                    ELSE ''
                                    END + p.LastName,
		                        FORMAT(a.ApplicationDate, 'dd/MM/yyyy') AS [Application Date],
		                        [Passed tests] = 
		                        (
			                        SELECT COUNT(*)
			                        FROM Tests t
			                            JOIN TestAppointments ta
				                            ON t.TestAppointmentID = ta.TestAppointmentID
			                            WHERE l.LocalDrivingLicenseApplicationID = ta.LocalDrivingLicenseApplicationID
				                            and t.TestResult = 1
		                        ),
		                        [Status] = CASE 
			                    WHEN a.ApplicationStatus = 1
				                    THEN 'New'
			                    WHEN a.ApplicationStatus = 2
				                    THEN 'Cancelled'
			                    WHEN a.ApplicationStatus = 3
				                    THEN 'Completed'
			                    END

                                FROM 
	                            LocalDrivingLicenseApplications l
	                                JOIN Applications a
		                                ON a.ApplicationID = l.ApplicationID
	                                JOIN LicenseClasses c
		                                ON c.LicenseClassID = l.LicenseClassID
	                                JOIN People p
		                                ON p.PersonID = a.ApplicantPersonID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    try
                    {

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dataTable.Load(reader);
                            }
                            reader.Close();
                        }

                        foreach (DataColumn column in dataTable.Columns)
                        {
                            column.ReadOnly = false;
                        }

                        dataTable.PrimaryKey = new DataColumn[]
                        {
                                dataTable.Columns["L.D.L Application ID"]
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

        public static int HasActiveApplicationForClass(int ApplicantPersonID, int LicenseClassID)
        {
            int FoundApplicationID = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string query = @"SELECT top 1 l.LocalDrivingLicenseApplicationID
                                FROM Applications a
	                                JOIN LocalDrivingLicenseApplications l
	                                	ON l.ApplicationID = a.ApplicationID
                                WHERE a.ApplicationTypeID = 1
                                AND a.ApplicationStatus = 1
                                AND a.ApplicantPersonID = @ApplicantPersonID
                                AND l.LicenseClassID = @LicenseClassID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
                    command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                    try
                    {

                        connection.Open();

                        FoundApplicationID = Convert.ToInt32(command.ExecuteScalar());

                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }

            return FoundApplicationID;
        }


        public static int GetPassedTestsCount(int LocalDrivingLicenseApplicationID)
        {
            int passedTestsCount = 0;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string query = @"SELECT COUNT(*)
                                    FROM Tests t
                                        JOIN TestAppointments ta
                                            ON t.TestAppointmentID = ta.TestAppointmentID
                                    WHERE t.TestResult = 1 
                                        AND ta.LocalDrivingLicenseApplicationID
                                            = @LocalDrivingLicenseApplicationID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue(
                            "@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                        connection.Open();

                        passedTestsCount = Convert.ToInt32(command.ExecuteScalar());

                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }

            return passedTestsCount;
        }

    }
}
