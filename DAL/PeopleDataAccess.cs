using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PeopleDataAccess
    {
        public static bool FindFromPeopleByPersonID(int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref int Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {

                string query = @"SELECT * FROM People Where PersonID = @PersonID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@PersonID", PersonID);


                    try
                    {

                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {

                            PersonID = (int)reader["PersonID"];

                            NationalNo = (string)reader["NationalNo"];

                            FirstName = (string)reader["FirstName"];

                            SecondName = (string)reader["SecondName"];

                            if (reader["ThirdName"] != System.DBNull.Value)

                            {

                                ThirdName = (string)reader["ThirdName"];

                            }

                            else

                                ThirdName = string.Empty;


                            LastName = (string)reader["LastName"];

                            DateOfBirth = (DateTime)reader["DateOfBirth"];

                            Gendor = Convert.ToInt32(reader["Gendor"]);

                            Address = (string)reader["Address"];

                            Phone = (string)reader["Phone"];

                            if (reader["Email"] != System.DBNull.Value)

                            {

                                Email = (string)reader["Email"];

                            }

                            else

                                Email = string.Empty;


                            NationalityCountryID = (int)reader["NationalityCountryID"];

                            if (reader["ImagePath"] != System.DBNull.Value)

                            {

                                ImagePath = (string)reader["ImagePath"];

                            }

                            else

                                ImagePath = string.Empty;



                            isFound = true;
                            connection.Close();
                        }

                    }
                    catch (Exception ex)
                    {

                        throw;


                    }

                    finally

                    {

                        connection.Close();

                    }
                }
            }


            return isFound;

        }

        public static bool FindFromPeopleByNationalNo(string NationalNo, ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref int Gendor, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {

                string query = @"SELECT * FROM People Where NationalNo = @NationalNo";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@NationalNo", NationalNo);


                    try
                    {

                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {

                            PersonID = (int)reader["PersonID"];

                            NationalNo = (string)reader["NationalNo"];

                            FirstName = (string)reader["FirstName"];

                            SecondName = (string)reader["SecondName"];

                            if (reader["ThirdName"] != System.DBNull.Value)

                            {

                                ThirdName = (string)reader["ThirdName"];

                            }

                            else

                                ThirdName = string.Empty;


                            LastName = (string)reader["LastName"];

                            DateOfBirth = (DateTime)reader["DateOfBirth"];

                            Gendor = Convert.ToInt32(reader["Gendor"]);

                            Address = (string)reader["Address"];

                            Phone = (string)reader["Phone"];

                            if (reader["Email"] != System.DBNull.Value)

                            {

                                Email = (string)reader["Email"];

                            }

                            else

                                Email = string.Empty;


                            NationalityCountryID = (int)reader["NationalityCountryID"];

                            if (reader["ImagePath"] != System.DBNull.Value)

                            {

                                ImagePath = (string)reader["ImagePath"];

                            }

                            else

                                ImagePath = string.Empty;



                            isFound = true;
                            connection.Close();
                        }

                    }
                    catch (Exception ex)
                    {

                        throw;


                    }

                    finally

                    {

                        connection.Close();

                    }
                }
            }


            return isFound;

        }

        public static bool IsExistsInPeopleByPersonID(int PersonID)


        {

            int isExists = -1;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = "SELECT Found=1 FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);


            try
            {

                connection.Open();

                isExists = Convert.ToInt32(command.ExecuteScalar());

            }
            catch (Exception ex)
            {

                throw;


            }

            finally

            {

                connection.Close();

            }



            return (isExists > 0);

        }
        public static int AddNewToPeople(string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, int Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)


        {

            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"INSERT INTO People(	[NationalNo],
	[FirstName],
	[SecondName],
	[ThirdName],
	[LastName],
	[DateOfBirth],
	[Gendor],
	[Address],
	[Phone],
	[Email],
	[NationalityCountryID],
	[ImagePath]
)

		VALUES(

	@NationalNo,

	@FirstName,

	@SecondName,

	@ThirdName,

	@LastName,

	@DateOfBirth,

	@Gendor,

	@Address,

	@Phone,

	@Email,

	@NationalityCountryID,

	@ImagePath
)

		SELECT SCOPE_IDENTITY();"
        ;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);

            if (ThirdName != "")
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);

            if (Email != "")
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (!string.IsNullOrWhiteSpace(ImagePath))
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);



            try
            {

                connection.Open();

                PersonID = Convert.ToInt32(command.ExecuteScalar());

            }
            catch (Exception ex)
            {

                throw;


            }

            finally

            {

                connection.Close();

            }


            return PersonID;

        }
        public static bool UpdateFromPeople(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, int Gendor, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)


        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"UPDATE People
	SET 		[NationalNo] = @NationalNo,
		[FirstName] = @FirstName,
		[SecondName] = @SecondName,
		[ThirdName] = @ThirdName,
		[LastName] = @LastName,
		[DateOfBirth] = @DateOfBirth,
		[Gendor] = @Gendor,
		[Address] = @Address,
		[Phone] = @Phone,
		[Email] = @Email,
		[NationalityCountryID] = @NationalityCountryID,
		[ImagePath] = @ImagePath

	WHERE PersonID = @PersonID"
        ;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);

            if (ThirdName != "")

                command.Parameters.AddWithValue("@ThirdName", ThirdName);

            else

                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);

            if (Email != "")

                command.Parameters.AddWithValue("@Email", Email);

            else

                command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (!string.IsNullOrWhiteSpace(ImagePath))

                command.Parameters.AddWithValue("@ImagePath", ImagePath);

            else

                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);



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
        public static bool DeleteFromPeople(int PersonID)


        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Delete FROM People
	WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);


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
        public static DataTable GetAllFromPeople()

        {

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = @"SELECT * FROM People";

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

        public static DataTable GetPeopleSummary()
        {
                DataTable dataTable = new DataTable();

            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.ConnectionString))
            {
                string query =
                $@"SELECT p.PersonID AS [Person ID], p.NationalNo AS [National No.], p.FirstName AS [First name],
                p.SecondName AS [Second Name], p.ThirdName AS [Third Name], p.LastName AS [Last Name],
                FORMAT(p.DateOfBirth, 'dd/MM/yyyy') AS [Birth Date], 
                CASE
                WHEN p.Gendor <> 1
                THEN 'Male'
                ELSE 'Female'
                END AS [Gender],
                c.CountryName AS [Nationality],
                p.Phone AS [Phone Number], p.Email AS [Email]
                    FROM People p
                    JOIN Countries c 
                    ON c.CountryID = p.NationalityCountryID";

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
                                dataTable.Columns["Person ID"] 
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



    }
}
