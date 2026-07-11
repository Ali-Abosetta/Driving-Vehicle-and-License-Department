using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsersDataAccess
    {
        public static bool FindFromUsersByUserID(int UserID, ref int PersonID, ref string UserName, ref string Password, ref bool IsActive)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {

                string query = @"SELECT * FROM Users Where UserID = @UserID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@UserID", UserID);


                    try
                    {

                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {

                            UserID = (int)reader["UserID"];

                            PersonID = (int)reader["PersonID"];

                            UserName = (string)reader["UserName"];

                            Password = (string)reader["Password"];

                            IsActive = (bool)reader["IsActive"];


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

        public static bool FindFromUsersByUserName(string UserName, ref int UserID,
            ref int PersonID, ref string Password, ref bool IsActive)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {

                string query = @"SELECT * FROM Users Where UserName = @UserName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@UserName", UserName);


                    try
                    {

                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {

                            UserID = (int)reader["UserID"];

                            PersonID = (int)reader["PersonID"];

                            UserName = (string)reader["UserName"];

                            Password = (string)reader["Password"];

                            IsActive = (bool)reader["IsActive"];


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

        public static bool IsExistsInUsersByUserID(int UserID)
        {

            int isExists = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {

                string query = "SELECT Found=1 FROM Users WHERE UserID = @UserID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@UserID", UserID);


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
        public static int AddNewToUsers(int PersonID, string UserName, string Password, bool IsActive)


        {

            int UserID = -1;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"INSERT INTO Users(	[PersonID],
	[UserName],
	[Password],
	[IsActive]
)

		VALUES(

	@PersonID,

	@UserName,

	@Password,

	@IsActive
);

		SELECT SCOPE_IDENTITY();"
        ;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);



            try
            {

                connection.Open();

                UserID = Convert.ToInt32(command.ExecuteScalar());

            }
            catch (Exception ex)
            {

                throw;


            }

            finally

            {

                connection.Close();

            }


            return UserID;

        }
        public static bool UpdateFromUsers(int UserID, int PersonID, string UserName,
            string Password, bool IsActive)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"UPDATE Users
	SET 		[PersonID] = @PersonID,
		[UserName] = @UserName,
		[Password] = @Password,
		[IsActive] = @IsActive

	WHERE UserID = @UserID"
        ;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);



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
        public static bool UpdatePassword(int UserID,
            string NewPassword)
        {

            int rowsAffected = 0;

            using (SqlConnection connection =
                new SqlConnection(clsConnectionString.ConnectionString))
            {
                string query = @"UPDATE Users
		            SET [Password] = @Password
	                WHERE [UserID] = @UserID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@Password", NewPassword);

                    try
                    {

                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
                return (rowsAffected > 0);

            }
        }
        public static bool DeleteFromUsers(int UserID)


        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Delete FROM Users
	WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);


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
        public static DataTable GetAllFromUsers()

        {

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = @"SELECT * FROM Users";

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

        public static DataTable GetUsersSummary()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {
                string query = @"SELECT u.UserID AS [User ID], u.PersonID AS [Person ID], 
	                    [Full name] = p.FirstName + ' ' + p.SecondName + ' ' + 
	                    CASE 
	                    WHEN p.ThirdName is not null
	                    THEN p.ThirdName + ' '
	                    ELSE ''
	                    END
	                    + p.LastName,
	                    u.UserName AS [Username], u.IsActive AS [Is active]
                        FROM Users u
	                    JOIN People p
	                    ON p.PersonID = u.PersonID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dataTable.Load(reader);
                        }
                    }
                }
            }

            foreach (DataColumn column in dataTable.Columns)
            {
                column.ReadOnly = false;
            }
            dataTable.PrimaryKey = new DataColumn[] 
            { 
                dataTable.Columns["User ID"] 
            };

            return dataTable;
        }

    }
}
