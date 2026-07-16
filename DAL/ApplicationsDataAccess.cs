using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ApplicationsDataAccess
    {
        public static bool FindFromApplicationsByApplicationID(int ApplicationID, ref int ApplicantPersonID, ref DateTime ApplicationDate, ref int ApplicationTypeID, ref int ApplicationStatus, ref DateTime LastStatusDate, ref decimal PaidFees, ref int CreatedByUserID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {

                string query = @"SELECT * FROM Applications Where ApplicationID = @ApplicationID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);


                    try
                    {

                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {

                            ApplicationID = (int)reader["ApplicationID"];

                            ApplicantPersonID = (int)reader["ApplicantPersonID"];

                            ApplicationDate = (DateTime)reader["ApplicationDate"];

                            ApplicationTypeID = (int)reader["ApplicationTypeID"];

                            ApplicationStatus = Convert.ToInt32(reader["ApplicationStatus"]);

                            LastStatusDate = (DateTime)reader["LastStatusDate"];

                            PaidFees = (decimal)reader["PaidFees"];

                            CreatedByUserID = (int)reader["CreatedByUserID"];


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
        public static bool IsExistsInApplicationsByApplicationID(int ApplicationID)


        {

            int isExists = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {

                string query = "SELECT Found=1 FROM Applications WHERE ApplicationID = @ApplicationID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);


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
        public static int AddNewToApplications(int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, int ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)


        {

            int ApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"INSERT INTO Applications(	[ApplicantPersonID],
	[ApplicationDate],
	[ApplicationTypeID],
	[ApplicationStatus],
	[LastStatusDate],
	[PaidFees],
	[CreatedByUserID]
)

		VALUES(

	@ApplicantPersonID,

	@ApplicationDate,

	@ApplicationTypeID,

	@ApplicationStatus,

	@LastStatusDate,

	@PaidFees,

	@CreatedByUserID
);

		SELECT SCOPE_IDENTITY();"
        ;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);



            try
            {

                connection.Open();

                ApplicationID = Convert.ToInt32(command.ExecuteScalar());

            }
            catch (Exception ex)
            {

                throw;


            }

            finally

            {

                connection.Close();

            }


            return ApplicationID;

        }
        public static bool UpdateFromApplications(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, int ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)


        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"UPDATE Applications
	SET 		[ApplicantPersonID] = @ApplicantPersonID,
		[ApplicationDate] = @ApplicationDate,
		[ApplicationTypeID] = @ApplicationTypeID,
		[ApplicationStatus] = @ApplicationStatus,
		[LastStatusDate] = @LastStatusDate,
		[PaidFees] = @PaidFees,
		[CreatedByUserID] = @CreatedByUserID

	WHERE ApplicationID = @ApplicationID"
        ;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);



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
        public static bool DeleteFromApplications(int ApplicationID)


        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Delete FROM Applications
	WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);


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
        public static DataTable GetAllFromApplications()

        {

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = @"SELECT * FROM Applications";

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
