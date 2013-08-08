using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIMS_Panthitsar_Inventory_Management_System.objects;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PIMS_Panthitsar_Inventory_Management_System.util
{
    class DBCategories
    {
        private static DBCategories instance = new DBCategories();
        SqlDataReader dr;
        static string connectionString = ConfigurationManager.ConnectionStrings["dbConnectionString"].ConnectionString;

        public static DBCategories Instance
        {
            get
            {
                return instance;
            }
        }

        public List<Categories> GetCategoryList()
        {
            List<Categories> categorylist = null;
            try
            {
                categorylist = new List<Categories>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_getCategoryList", conn))
                    {
                        cmd.CommandTimeout = 200;
                        cmd.CommandType = CommandType.StoredProcedure;
                        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        while (dr.Read())
                        {
                            Categories category = new Categories();


                            category.CategoryID = (string)dr["CategoryID"];
                            category.CategoryName = (string)dr["CategoryName"];

                            categorylist.Add(category);

                        }
                        dr.Close();

                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL Error : " + ex.Message);
            }
            return categorylist;
        }

        //Add New category to Database
        public Boolean AddNewCategory(Categories  category)
        {
            Boolean insert;
            try
            {
                insert = false;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_InsertNewCategory", conn))
                    {
                        cmd.CommandTimeout = 200;

                        cmd.CommandType = CommandType.StoredProcedure;
                       
                        cmd.Parameters.Add("@CategoryName", SqlDbType.NVarChar).Value = category.CategoryName;
                        
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

        //Update category by ID
        public Boolean UpdateSelectedCategory(Categories  category)
        {
            Boolean update;
            try
            {
                update = false;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_UpdateCategoryByID", conn))
                    {
                        cmd.CommandTimeout = 200;

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@CategoryID", SqlDbType.VarChar).Value = category.CategoryID;
                        cmd.Parameters.Add("@CategoryName", SqlDbType.VarChar).Value = category.CategoryName;
                        
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

        //Update category status
        public Boolean DeleteSelectedCategory(Categories  category)
        {
            Boolean update;
            try
            {
                update = false;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_UpdateCategoryStatusById", conn))
                    {
                        cmd.CommandTimeout = 200;

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@CategoryID", SqlDbType.VarChar).Value = category.CategoryID;
                       

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
