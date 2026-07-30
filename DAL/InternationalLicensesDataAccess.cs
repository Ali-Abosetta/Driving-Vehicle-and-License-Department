using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InternationalLicensesDataAccess
    {
        public static bool FindFromInternationalLicensesByInternationalLicenseID(int InternationalLicenseID, ref int ApplicationID, ref int DriverID, ref int IssuedUsingLocalLicenseID, ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {

                string query = @"SELECT * FROM InternationalLicenses Where InternationalLicenseID = @InternationalLicenseID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);


                    try
                    {

                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {

                            InternationalLicenseID = (int)reader["InternationalLicenseID"];

                            ApplicationID = (int)reader["ApplicationID"];

                            DriverID = (int)reader["DriverID"];

                            IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];

                            IssueDate = (DateTime)reader["IssueDate"];

                            ExpirationDate = (DateTime)reader["ExpirationDate"];

                            IsActive = (bool)reader["IsActive"];

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

        public static bool FindFromInternationalLicensesByDriverID(int DriverID, ref int InternationalLicenseID, ref int ApplicationID, ref int IssuedUsingLocalLicenseID, ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string query = @"SELECT * FROM InternationalLicenses 
                                    Where DriverID = @DriverID AND IsActive = 1";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DriverID", DriverID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {

                                InternationalLicenseID = (int)reader["InternationalLicenseID"];
                                ApplicationID = (int)reader["ApplicationID"];
                                DriverID = (int)reader["DriverID"];
                                IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                                IssueDate = (DateTime)reader["IssueDate"];
                                ExpirationDate = (DateTime)reader["ExpirationDate"];
                                IsActive = (bool)reader["IsActive"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];

                                isFound = true;
                            }
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
        public static bool IsExistsInInternationalLicensesByInternationalLicenseID(int InternationalLicenseID)


        {

            int isExists = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {

                string query = "SELECT Found=1 FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);


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
        public static int AddNewToInternationalLicenses(int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)


        {

            int InternationalLicenseID = -1;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"INSERT INTO InternationalLicenses(	[ApplicationID],
	[DriverID],
	[IssuedUsingLocalLicenseID],
	[IssueDate],
	[ExpirationDate],
	[IsActive],
	[CreatedByUserID]
)

		VALUES(

	@ApplicationID,

	@DriverID,

	@IssuedUsingLocalLicenseID,

	@IssueDate,

	@ExpirationDate,

	@IsActive,

	@CreatedByUserID
);

		SELECT SCOPE_IDENTITY();"
        ;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);



            try
            {

                connection.Open();

                InternationalLicenseID = Convert.ToInt32(command.ExecuteScalar());

            }
            catch (Exception ex)
            {

                throw;


            }

            finally

            {

                connection.Close();

            }


            return InternationalLicenseID;

        }
        public static bool UpdateFromInternationalLicenses(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)


        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"UPDATE InternationalLicenses
	SET 		[ApplicationID] = @ApplicationID,
		[DriverID] = @DriverID,
		[IssuedUsingLocalLicenseID] = @IssuedUsingLocalLicenseID,
		[IssueDate] = @IssueDate,
		[ExpirationDate] = @ExpirationDate,
		[IsActive] = @IsActive,
		[CreatedByUserID] = @CreatedByUserID

	WHERE InternationalLicenseID = @InternationalLicenseID"
        ;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
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
        public static bool DeleteFromInternationalLicenses(int InternationalLicenseID)


        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Delete FROM InternationalLicenses
	WHERE InternationalLicenseID = @InternationalLicenseID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);


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
        public static DataTable GetAllFromInternationalLicenses()

        {

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = @"SELECT * FROM InternationalLicenses";

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

        public static int GetActiveInternationalLicenseIDByDriverID(int DriverID)
        {
            int InternationalLicenseID = 0;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string query = @"SELECT InternationalLicenseID FROM InternationalLicenses 
                                    WHERE DriverID = @DriverID AND IsActive = 1";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DriverID", DriverID);
                    connection.Open();
                    InternationalLicenseID = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return InternationalLicenseID;
        }
        public static DataTable GetInternationalLicensesSummary()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string query = @"SELECT 
	                                i.InternationalLicenseID AS [Int. license ID],
                                	i.ApplicationID AS [Application ID],
	                                l.LicenseID AS [Local License ID],
	                                FORMAT(i.IssueDate, 'dd/MM/yyyy') AS [Issue date],
	                                FORMAT(i.ExpirationDate, 'dd/MM/yyyy') AS [Expiration date],
	                                i.IsActive AS [Is active]
                                FROM InternationalLicenses i 
	                                JOIN Licenses l
		                                ON i.DriverID = l.DriverID";

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
                        }
                        foreach (DataColumn column in dataTable.Columns)
                        {
                            column.ReadOnly = false;
                        }

                        //Note: when you change the database from the testing db into the working db uncomment the following:

                        //dataTable.PrimaryKey = new DataColumn[]
                        //{
                        //        dataTable.Columns["Int. license ID"]
                        //};
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }

            return dataTable;
        }

        public static DataTable GetDriverInternationalLicensesSummary(int PersonID)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string query = @"SELECT 
	                                i.InternationalLicenseID AS [Int. license ID],
                                	i.ApplicationID AS [Application ID],
	                                l.LicenseID AS [Local License ID],
	                                FORMAT(i.IssueDate, 'dd/MM/yyyy') AS [Issue date],
	                                FORMAT(i.ExpirationDate, 'dd/MM/yyyy') AS [Expiration date],
	                                i.IsActive AS [Is active]
                                FROM InternationalLicenses i 
	                                JOIN Licenses l
		                                ON i.DriverID = l.DriverID
                                    JOIN Drivers d
                                        ON d.DriverID = i.DriverID
                                WHERE d.PersonID = @PersonID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dataTable.Load(reader);
                            }
                        }
                        foreach (DataColumn column in dataTable.Columns)
                        {
                            column.ReadOnly = false;
                        }
                        //Note: when you change the database from the testing db into the working db uncomment the following:

                        //dataTable.PrimaryKey = new DataColumn[]
                        //{
                        //        dataTable.Columns["Int. license ID"]
                        //};
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }

            return dataTable;
        }


    }
}
