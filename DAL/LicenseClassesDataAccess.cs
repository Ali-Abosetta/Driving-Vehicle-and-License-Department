using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LicenseClassesDataAccess
    {
        public static bool FindFromLicenseClassesByLicenseClassID(int LicenseClassID, ref string ClassName, ref string ClassDescription, ref int MinimumAllowedAge, ref int DefaultValidityLength, ref decimal ClassFees)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {

                string query = @"SELECT * FROM LicenseClasses Where LicenseClassID = @LicenseClassID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


                    try
                    {

                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {

                            LicenseClassID = (int)reader["LicenseClassID"];

                            ClassName = (string)reader["ClassName"];

                            ClassDescription = (string)reader["ClassDescription"];

                            MinimumAllowedAge = Convert.ToInt32(reader["MinimumAllowedAge"]);

                            DefaultValidityLength = Convert.ToInt32(reader["DefaultValidityLength"]);

                            ClassFees = (decimal)reader["ClassFees"];


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
        public static bool IsExistsInLicenseClassesByLicenseClassID(int LicenseClassID)


        {

            int isExists = -1;

            using (SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString))
            {

                string query = "SELECT Found=1 FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


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
        public static int AddNewToLicenseClasses(string ClassName, string ClassDescription, int MinimumAllowedAge, int DefaultValidityLength, decimal ClassFees)


        {

            int LicenseClassID = -1;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"INSERT INTO LicenseClasses(	[ClassName],
	[ClassDescription],
	[MinimumAllowedAge],
	[DefaultValidityLength],
	[ClassFees]
)

		VALUES(

	@ClassName,

	@ClassDescription,

	@MinimumAllowedAge,

	@DefaultValidityLength,

	@ClassFees
);

		SELECT SCOPE_IDENTITY();"
        ;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClassName", ClassName);
            command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
            command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
            command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
            command.Parameters.AddWithValue("@ClassFees", ClassFees);



            try
            {

                connection.Open();

                LicenseClassID = Convert.ToInt32(command.ExecuteScalar());

            }
            catch (Exception ex)
            {

                throw;


            }

            finally

            {

                connection.Close();

            }


            return LicenseClassID;

        }
        public static bool UpdateFromLicenseClasses(int LicenseClassID, string ClassName, string ClassDescription, int MinimumAllowedAge, int DefaultValidityLength, decimal ClassFees)


        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"UPDATE LicenseClasses
	SET 		[ClassName] = @ClassName,
		[ClassDescription] = @ClassDescription,
		[MinimumAllowedAge] = @MinimumAllowedAge,
		[DefaultValidityLength] = @DefaultValidityLength,
		[ClassFees] = @ClassFees

	WHERE LicenseClassID = @LicenseClassID"
        ;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@ClassName", ClassName);
            command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
            command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
            command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
            command.Parameters.AddWithValue("@ClassFees", ClassFees);



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
        public static bool DeleteFromLicenseClasses(int LicenseClassID)


        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);

            string query = @"Delete FROM LicenseClasses
	WHERE LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, connection);
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
        public static DataTable GetAllFromLicenseClasses()

        {

            SqlConnection connection = new SqlConnection(clsConnectionString.ConnectionString);
            string query = @"SELECT * FROM LicenseClasses";

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
