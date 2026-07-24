using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LicensesDataAccess
    {
        public static bool FindFromLicensesByLicenseID(int LicenseID, ref int ApplicationID, ref int DriverID, ref int LicenseClass, ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes, ref decimal PaidFees, ref bool IsActive, ref int IssueReason, ref int CreatedByUserID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {

                string query = @"SELECT * FROM Licenses Where LicenseID = @LicenseID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@LicenseID", LicenseID);


                    try
                    {

                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {

                            LicenseID = (int)reader["LicenseID"];

                            ApplicationID = (int)reader["ApplicationID"];

                            DriverID = (int)reader["DriverID"];

                            LicenseClass = (int)reader["LicenseClass"];

                            IssueDate = (DateTime)reader["IssueDate"];

                            ExpirationDate = (DateTime)reader["ExpirationDate"];

                            if (reader["Notes"] != System.DBNull.Value)

                            {

                                Notes = (string)reader["Notes"];

                            }

                            else

                                Notes = string.Empty;

                            PaidFees = (decimal)reader["PaidFees"];

                            IsActive = (bool)reader["IsActive"];

                            IssueReason = (int)reader["IssueReason"];

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
        public static bool IsExistsInLicensesByLicenseID(int LicenseID)


        {

            int isExists = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {

                string query = "SELECT Found=1 FROM Licenses WHERE LicenseID = @LicenseID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@LicenseID", LicenseID);


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
        public static int AddNewToLicenses(int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, int IssueReason, int CreatedByUserID)


        {

            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"INSERT INTO Licenses(	[ApplicationID],
	[DriverID],
	[LicenseClass],
	[IssueDate],
	[ExpirationDate],
	[Notes],
	[PaidFees],
	[IsActive],
	[IssueReason],
	[CreatedByUserID]
)

		VALUES(

	@ApplicationID,

	@DriverID,

	@LicenseClass,

	@IssueDate,

	@ExpirationDate,

	@Notes,

	@PaidFees,

	@IsActive,

	@IssueReason,

	@CreatedByUserID
);

		SELECT SCOPE_IDENTITY();"
        ;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);

            if (string.IsNullOrWhiteSpace(Notes))
                command.Parameters.AddWithValue("@Notes", Notes);
            else
                command.Parameters.AddWithValue("@Notes", System.DBNull.Value);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);



            try
            {

                connection.Open();

                LicenseID = Convert.ToInt32(command.ExecuteScalar());

            }
            catch (Exception ex)
            {

                throw;


            }

            finally

            {

                connection.Close();

            }


            return LicenseID;

        }
        public static bool UpdateFromLicenses(int LicenseID, int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, int IssueReason, int CreatedByUserID)


        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"UPDATE Licenses
	SET 		[ApplicationID] = @ApplicationID,
		[DriverID] = @DriverID,
		[LicenseClass] = @LicenseClass,
		[IssueDate] = @IssueDate,
		[ExpirationDate] = @ExpirationDate,
		[Notes] = @Notes,
		[PaidFees] = @PaidFees,
		[IsActive] = @IsActive,
		[IssueReason] = @IssueReason,
		[CreatedByUserID] = @CreatedByUserID

	WHERE LicenseID = @LicenseID"
        ;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);

            if (Notes != "")

                command.Parameters.AddWithValue("@Notes", Notes);

            else

                command.Parameters.AddWithValue("@Notes", System.DBNull.Value);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
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
        public static bool DeleteFromLicenses(int LicenseID)


        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Delete FROM Licenses
	WHERE LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);


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
        public static DataTable GetAllFromLicenses()

        {

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = @"SELECT * FROM Licenses";

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
