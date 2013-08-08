using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.ComponentModel;
using PIMS_Panthitsar_Inventory_Management_System.objects;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace PIMS_Panthitsar_Inventory_Management_System.util
{
    class DBUtil
    {
        private static DBUtil instance = new DBUtil();
        SqlDataReader dr;
        static string connectionString = ConfigurationManager.ConnectionStrings["dbConnectionString"].ConnectionString;

        public static DBUtil Instance
        {
            get
            {
                return instance;
            }
        }
       

        public Boolean AddNewItem(Items item)
        {
            Boolean insert;
            try
            {
                insert = false;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_InsertNewItem", conn))
                    {
                        cmd.CommandTimeout = 200;

                        cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.Parameters.Add("@ItemID", SqlDbType.NVarChar).Value = item.ItemID;
                        cmd.Parameters.Add("@ItemName", SqlDbType.NVarChar).Value = item.ItemName;                       
                        cmd.Parameters.Add("@CategoryID", SqlDbType.VarChar).Value = item.CategoryID;
                        cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar).Value = item.SupplierID;
                        cmd.Parameters.Add("@ImagePath", SqlDbType.NVarChar).Value = item.ImagePath;
                        cmd.Parameters.Add("@Status", SqlDbType.NVarChar).Value = "Active";
                        cmd.Parameters.Add("@Stock", SqlDbType.Int).Value = item.Stock;
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



        public List<Items> GetItemsList()
        {
            List<Items> itemlist = null;
            try
            {
                itemlist = new List<Items>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_getAllItems", conn))
                    {
                        cmd.CommandTimeout = 200;
                        cmd.CommandType = CommandType.StoredProcedure;
                        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        while (dr.Read())
                        {
                            Items item = new Items();

                            item.ItemName = (string)dr["ItemName"];
                            item.ItemID = (string)dr["ItemID"];
                            item.CategoryID = (string)dr["CategoryID"];
                            item.SupplierID = (string)dr["SupplierID"];
                            item.Stock = (int)dr["Stock"];
                            item.ImagePath=(string)dr["ImagePath"];
                            item.SupplierName =(string) dr["SupplierName"];
                            item.CategoryName = (string)dr["CategoryName"];
                            itemlist.Add(item);

                        }
                        dr.Close();

                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL Error : " + ex.Message);
            }
            return itemlist;
        }

        public List<Items> GetItemsListByCategoryID(Items itemCategory)
        {
            List<Items> itemlist = null;
            try
            {
                itemlist = new List<Items>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_getItemsByCategoryID", conn))
                    {
                        cmd.CommandTimeout = 200;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@CategoryID", SqlDbType.NVarChar).Value = itemCategory.CategoryID;
                        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        while (dr.Read())
                        {
                            Items item = new Items();

                            item.ItemName = (string)dr["ItemName"];
                            item.ItemID = (string)dr["ItemID"];
                           
                            itemlist.Add(item);

                        }
                        dr.Close();

                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL Error : " + ex.Message);
            }
            return itemlist;
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

                    using (SqlCommand cmd = new SqlCommand("sp_getAllCategories", conn))
                    {
                        cmd.CommandTimeout = 200;
                        cmd.CommandType = CommandType.StoredProcedure;
                        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        while (dr.Read())
                        {
                            Categories category = new Categories();


                            category.CategoryID = (string)dr["CategoryID"];
                            category.CategoryID = (string)dr["CategoryName"];

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
        public Boolean UpdateSelectedItem(Items item)
        {
            Boolean update;
            try
            {
                update = false;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_UpdateItemByID", conn))
                    {
                        cmd.CommandTimeout = 200;

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@ItemID", SqlDbType.NVarChar).Value = item.ItemID;
                        cmd.Parameters.Add("@ItemName", SqlDbType.NVarChar).Value = item.ItemName;
                        cmd.Parameters.Add("@CategoryID", SqlDbType.NVarChar).Value = item.CategoryID;
                        cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar).Value = item.SupplierID;
                        cmd.Parameters.Add("@ImagePath", SqlDbType.NVarChar).Value = item.ImagePath;
                        cmd.Parameters.Add("@Stock", SqlDbType.Int).Value = item.Stock;
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

        public Boolean DeleteSelectedItem(Items item)
        {
            Boolean update;
            try
            {
                update = false;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_UpdateItemStatusById", conn))
                    {
                        cmd.CommandTimeout = 200;

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@ItemID", SqlDbType.NVarChar).Value = item.ItemID;
                        cmd.Parameters.Add("@Status", SqlDbType.NVarChar).Value = item.Status;
                        
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

      
