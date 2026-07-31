using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DetainedLicensesDataAccess
    {
        public static bool FindFromDetainedLicensesByDetainID(int DetainID, ref int LicenseID, ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime? ReleaseDate, ref int? ReleasedByUserID, ref int? ReleaseApplicationID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {

                string query = @"SELECT * FROM DetainedLicenses Where DetainID = @DetainID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@DetainID", DetainID);


                    try
                    {

                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {

                            DetainID = (int)reader["DetainID"];

                            LicenseID = (int)reader["LicenseID"];

                            DetainDate = (DateTime)reader["DetainDate"];

                            FineFees = (decimal)reader["FineFees"];

                            CreatedByUserID = (int)reader["CreatedByUserID"];

                            IsReleased = (bool)reader["IsReleased"];

                            if (reader["ReleaseDate"] != System.DBNull.Value)

                            {

                                ReleaseDate = (DateTime)reader["ReleaseDate"];

                            }

                            else

                                ReleaseDate = null;

                            if (reader["ReleasedByUserID"] != System.DBNull.Value)

                            {

                                ReleasedByUserID = (int)reader["ReleasedByUserID"];

                            }

                            else

                                ReleasedByUserID = null;

                            if (reader["ReleaseApplicationID"] != System.DBNull.Value)

                            {

                                ReleaseApplicationID = (int)reader["ReleaseApplicationID"];

                            }

                            else

                                ReleaseApplicationID = null;


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

        public static bool FindByLicenseID(int LicenseID, ref int DetainID, ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime? ReleaseDate, ref int? ReleasedByUserID, ref int? ReleaseApplicationID)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string query = @"SELECT *
                                    FROM DetainedLicenses
                                    WHERE LicenseID = @LicenseID AND IsReleased = 0";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseID", LicenseID);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                DetainID = (int)reader["DetainID"];
                                LicenseID = (int)reader["LicenseID"];
                                DetainDate = (DateTime)reader["DetainDate"];
                                FineFees = (decimal)reader["FineFees"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                IsReleased = (bool)reader["IsReleased"];

                                if (reader["ReleaseDate"] != System.DBNull.Value)
                                {
                                    ReleaseDate = (DateTime)reader["ReleaseDate"];
                                }

                                else
                                    ReleaseDate = null;

                                if (reader["ReleasedByUserID"] != System.DBNull.Value)
                                {
                                    ReleasedByUserID = (int)reader["ReleasedByUserID"];
                                }
                                else
                                    ReleasedByUserID = null;

                                if (reader["ReleaseApplicationID"] != System.DBNull.Value)
                                {
                                    ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
                                }
                                else
                                    ReleaseApplicationID = null;


                                isFound = true;
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }

                return isFound;
            }
        }
        public static bool IsExistsInDetainedLicensesByDetainID(int DetainID)
        {

            int isExists = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {

                string query = "SELECT Found=1 FROM DetainedLicenses WHERE DetainID = @DetainID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@DetainID", DetainID);


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

        public static int AddNewToDetainedLicenses(int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime? ReleaseDate, int? ReleasedByUserID, int? ReleaseApplicationID)


        {

            int DetainID = -1;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"INSERT INTO DetainedLicenses(	[LicenseID],
	[DetainDate],
	[FineFees],
	[CreatedByUserID],
	[IsReleased],
	[ReleaseDate],
	[ReleasedByUserID],
	[ReleaseApplicationID]
)

		VALUES(

	@LicenseID,

	@DetainDate,

	@FineFees,

	@CreatedByUserID,

	@IsReleased,

	@ReleaseDate,

	@ReleasedByUserID,

	@ReleaseApplicationID
);

		SELECT SCOPE_IDENTITY();"
        ;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);

            if (ReleaseDate.HasValue)
            {
                command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            }
            else
            {
                command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
            }

            if (ReleasedByUserID.HasValue)
            {
                command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            }
            else 
            {
                command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
            }

            if (ReleaseApplicationID.HasValue)
            {
                command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            }
            else 
            {
                command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
            }

                try
                {

                    connection.Open();

                    DetainID = Convert.ToInt32(command.ExecuteScalar());

                }
                catch (Exception ex)
                {

                    throw;


                }

                finally

                {

                    connection.Close();

                }


            return DetainID;

        }
        public static bool UpdateFromDetainedLicenses(int DetainID, int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime? ReleaseDate, int? ReleasedByUserID, int? ReleaseApplicationID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"UPDATE DetainedLicenses
	SET 		[LicenseID] = @LicenseID,
		[DetainDate] = @DetainDate,
		[FineFees] = @FineFees,
		[CreatedByUserID] = @CreatedByUserID,
		[IsReleased] = @IsReleased,
		[ReleaseDate] = @ReleaseDate,
		[ReleasedByUserID] = @ReleasedByUserID,
		[ReleaseApplicationID] = @ReleaseApplicationID

	WHERE DetainID = @DetainID"
        ;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);

            if (ReleaseDate.HasValue)
            {
                command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            }
            else
            {
                command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
            }

            if (ReleasedByUserID.HasValue)
            {
                command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            }
            else
            {
                command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
            }

            if (ReleaseApplicationID.HasValue)
            {
                command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            }
            else
            {
                command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
            }

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
        public static bool DeleteFromDetainedLicenses(int DetainID)


        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Delete FROM DetainedLicenses
	                        WHERE DetainID = @DetainID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DetainID", DetainID);


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
        public static DataTable GetAllFromDetainedLicenses()
        {

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = @"SELECT * FROM DetainedLicenses";

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

        public static DataTable GetDetainedLicensesSummary()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string query = @"SELECT 
                                dl.DetainID AS [Detained ID],
                                dl.LicenseID AS [License ID],
                                FORMAT(dl.DetainDate, 'dd/MM/yyyy') AS [Detained date],
                                dl.IsReleased AS [Is released],
                                dl.FineFees AS [Fine fees],
                                FORMAT(dl.ReleaseDate, 'dd/MM/yyyy')  AS [Release date],
                                p.NationalNo AS [National No.],
                                [Full name] = p.FirstName + ' ' + p.SecondName + ' ' +
                                    CASE 
                                    WHEN p.ThirdName is not null
                                    THEN p.ThirdName + ' '
                                    ELSE ''
                                    END + p.LastName,
                                dl.ReleaseApplicationID AS [R. Application ID]

                            FROM DetainedLicenses dl
                                JOIN Licenses l 
                                    ON dl.LicenseID = l.LicenseID
                                JOIN Drivers d
                                    ON l.DriverID = d.DriverID
                                JOIN People p
                                    ON d.PersonID = p.PersonID
                                JOIN Users u 
                                    ON dl.CreatedByUserID = u.UserID";

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

                        dataTable.PrimaryKey = new DataColumn[]
                        {
                                dataTable.Columns["Detained ID"]
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
        public static bool IsDetainedByLicenseID(int LicenseID)
        {
            int isDetained = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string query = @"SELECT Found = 1 
                                    FROM DetainedLicenses
                                    WHERE LicenseID = @LicenseID AND IsReleased = 0";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseID", LicenseID);
                    try
                    {
                        connection.Open();
                        isDetained = Convert.ToInt32(command.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }

            return (isDetained > 0);
        }
    }
}
