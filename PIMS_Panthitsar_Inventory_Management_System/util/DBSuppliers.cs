using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using PIMS_Panthitsar_Inventory_Management_System.objects;
using System.Data.SqlClient;
using System.Data;

namespace PIMS_Panthitsar_Inventory_Management_System.util
{
    class DBSuppliers
    {
        private static DBSuppliers instance = new DBSuppliers();
        SqlDataReader dr;
        static string connectionString = ConfigurationManager.ConnectionStrings["dbConnectionString"].ConnectionString;

        public static DBSuppliers Instance
        {
            get
            {
                return instance;
            }
        }

        //Populate DropDownList
        public List<Suppliers> GetSupplierList()
        {
            List<Suppliers> supplierlist = null;
            try
            {
                supplierlist = new List<Suppliers>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_getSuppliersNameList", conn))
                    {
                        cmd.CommandTimeout = 200;
                        cmd.CommandType = CommandType.StoredProcedure;
                        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        while (dr.Read())
                        {
                            Suppliers supplier = new Suppliers();


                            supplier.SupplierID = (string)dr["SupplierID"];
                            supplier.SupplierName = (string)dr["SupplierName"];

                            supplierlist.Add(supplier);

                        }
                        dr.Close();

                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL Error : " + ex.Message);
            }
            return supplierlist;
        }

        //Populate GridView
        public List<Suppliers> GetSuppliersDetails()
        {
            List<Suppliers> supplierslist = null;
            try
            {
                supplierslist = new List<Suppliers>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_getAllSuppliers", conn))
                    {
                        cmd.CommandTimeout = 200;
                        cmd.CommandType = CommandType.StoredProcedure;
                        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        while (dr.Read())
                        {
                            Suppliers supplier = new Suppliers();

                            supplier.Address = (string)dr["Address"];
                            supplier.CreditDue=Convert.ToDouble(dr["CreditDue"]);
                            supplier.Email= (string)dr["Email"];
                            supplier.Phone = (string)dr["Phone"];
                            supplier.SupplierID = (string)dr["SupplierID"];
                            supplier.SupplierName = (string)dr["SupplierName"];

                            supplierslist.Add(supplier);

                        }
                        dr.Close();

                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL Error : " + ex.Message);
            }
            return supplierslist;
        }

        //Add New Supplier to Database
        public Boolean AddNewSupplier(Suppliers supplier)
        {
            Boolean insert;
            try
            {
                insert = false;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_InsertNewSupplier", conn))
                    {
                        cmd.CommandTimeout = 200;

                        cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.Parameters.Add("@ItemID", SqlDbType.NVarChar).Value = item.ItemID;
                        cmd.Parameters.Add("@SupplierName", SqlDbType.NVarChar).Value = supplier.SupplierName;
                        cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = supplier.Phone;
                        cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = supplier.Address;
                        cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value =supplier.Email;
                        
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
        public Boolean UpdateSelectedSupplier(Suppliers     supplier)
        {
            Boolean update;
            try
            {
                update = false;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_UpdateSupplierByID", conn))
                    {
                        cmd.CommandTimeout = 200;

                        cmd.CommandType = CommandType.StoredProcedure;
                       
                        cmd.Parameters.Add("@SupplierID", SqlDbType.VarChar).Value = supplier.SupplierID;
                         cmd.Parameters.Add("@SupplierName", SqlDbType.NVarChar).Value = supplier.SupplierName;
                        cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = supplier.Phone;
                        cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = supplier.Address;
                        cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value =supplier.Email;
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
        public Boolean DeleteSelectedSupplier(Suppliers supplier)
        {
            Boolean update;
            try
            {
                update = false;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_UpdateSupplierStatusById", conn))
                    {
                        cmd.CommandTimeout = 200;

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@SupplierID", SqlDbType.NVarChar).Value = supplier.SupplierID;
                        cmd.Parameters.Add("@Status", SqlDbType.NVarChar).Value = supplier.Status;

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

