using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using PIMS_Panthitsar_Inventory_Management_System.objects;

namespace PIMS_Panthitsar_Inventory_Management_System.util
{
    class DBUsers
    {
        private static DBUsers instance = new DBUsers();
        SqlDataReader dr;
        static string connectionString = ConfigurationManager.ConnectionStrings["dbConnectionString"].ConnectionString;

        public static DBUsers Instance
        {
            get
            {
                return instance;
            }
        }

        //Populate DropDownList
        public List<System_Users> GetUserList()
        {
            List<System_Users> userlist = null;
            try
            {
                userlist = new List<System_Users>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_getAllUsers", conn))
                    {
                        cmd.CommandTimeout = 200;
                        cmd.CommandType = CommandType.StoredProcedure;
                        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        while (dr.Read())
                        {
                            System_Users user= new System_Users();


                            user.UserID= (string)dr["UserID"];
                            user.UserName = (string)dr["UserName"];

                            userlist.Add(user);

                        }
                        dr.Close();

                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL Error : " + ex.Message);
            }
            return userlist;
        }

        //Populate GridView
        public List<System_Users> GetUsersDetails()
        {
            List<System_Users> userslist = null;
            try
            {
                userslist = new List<System_Users>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_getAllUsers", conn))
                    {
                        cmd.CommandTimeout = 200;
                        cmd.CommandType = CommandType.StoredProcedure;
                        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        while (dr.Read())
                        {
                            System_Users user = new System_Users();

                            user.Address = (string)dr["Address"];

                            user.Email = (string)dr["Email"];
                            user.Phone = (string)dr["Phone"];
                            user.UserID = (string)dr["UserID"];
                            user.UserName = (string)dr["UserName"];
                            user.Role = (string)dr["UserRole"];
                            userslist.Add(user);

                        }
                        dr.Close();

                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL Error : " + ex.Message);
            }
            return userslist;
        }

        //Add New Supplier to Database
        public Boolean AddNewUser(System_Users user)
        {
            Boolean insert;
            try
            {
                insert = false;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_InsertNewUser", conn))
                    {
                        cmd.CommandTimeout = 200;

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = user.UserName;
                        cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = user.Phone;
                        cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = user.Address;
                        cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = user.Email;
                        cmd.Parameters.Add("@Role", SqlDbType.NVarChar).Value = user.Role;
                        cmd.ExecuteNonQuery();

                        insert = true;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL Error : " + ex.Message);
            }
            return insert;
        }

        //Update supplier by ID
        public Boolean UpdateSelectedUsers(System_Users user)
        {
            Boolean update;
            try
            {
                update = false;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_UpdateUserByID", conn))
                    {
                        cmd.CommandTimeout = 200;

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@UserID", SqlDbType.VarChar).Value = user.UserID;
                        cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = user.UserName;
                        cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = user.Phone;
                        cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = user.Address;
                        cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = user.Email;
                        cmd.Parameters.Add("@Role", SqlDbType.NVarChar).Value = user.Role;
                        cmd.ExecuteNonQuery();
                        update = true;

                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL Error : " + ex.Message);
            }
            return update;
        }

        //Update Supplier status
        public Boolean DeleteSelectedUser(System_Users user)
        {
            Boolean update;
            try
            {
                update = false;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_UpdateUserStatusById", conn))
                    {
                        cmd.CommandTimeout = 200;

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@UserID", SqlDbType.NVarChar).Value = user.UserID;


                        cmd.ExecuteNonQuery();
                        update = true;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL Error : " + ex.Message);
            }
            return update;
        }
    }
}
