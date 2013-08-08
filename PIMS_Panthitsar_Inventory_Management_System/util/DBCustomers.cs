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
    class DBCustomers
    {
        private static DBCustomers instance = new DBCustomers();
        SqlDataReader dr;
        static string connectionString = ConfigurationManager.ConnectionStrings["dbConnectionString"].ConnectionString;

        public static DBCustomers Instance
        {
            get
            {
                return instance;
            }
        }

        //Populate DropDownList
        public List<Customers> GetCustomerNameList()
        {
            List<Customers> customerlist = null;
            try
            {
                customerlist = new List<Customers>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_getAllCustomers", conn))
                    {
                        cmd.CommandTimeout = 200;
                        cmd.CommandType = CommandType.StoredProcedure;
                        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        while (dr.Read())
                        {
                            Customers customer = new Customers();


                            customer.CustomerID = (string)dr["CustomerID"];
                            customer.CustomerName = (string)dr["CustomerName"];

                            customerlist.Add(customer);

                        }
                        dr.Close();

                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL Error : " + ex.Message);
            }
            return customerlist;
        }

        //Populate GridView
        public List<Customers> GetCustomersDetails()
        {
            List<Customers> Customerslist = null;
            try
            {
                Customerslist = new List<Customers>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_getAllCustomers", conn))
                    {
                        cmd.CommandTimeout = 200;
                        cmd.CommandType = CommandType.StoredProcedure;
                        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        while (dr.Read())
                        {
                            Customers customer = new Customers();

                            customer.Address = (string)dr["Address"];

                            customer.Email = (string)dr["Email"];
                            customer.Phone = (string)dr["Phone"];
                            customer.CustomerID = (string)dr["CustomerID"];
                            customer.CustomerName = (string)dr["CustomerName"];
                            customer.DebitDue = Convert.ToDouble(dr["DebitDue"]);

                            Customerslist.Add(customer);

                        }
                        dr.Close();

                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL Error : " + ex.Message);
            }
            return Customerslist;
        }

        public List<Customers> GetCustomerDetailsByID(Customers customers)
        {
            List<Customers> Customerslist = null;
            try
            {
                Customerslist = new List<Customers>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_getCustomerDetailsByID", conn))
                    {
                        cmd.CommandTimeout = 200;
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@CustomerID", SqlDbType.NVarChar).Value = customers.CustomerID;

                        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        while (dr.Read())
                        {
                            Customers customer = new Customers();

                            customer.Address = (string)dr["Address"];

                            customer.Email = (string)dr["Email"];
                            customer.Phone = (string)dr["Phone"];
                            customer.CustomerID = (string)dr["CustomerID"];
                            customer.CustomerName = (string)dr["CustomerName"];
                            customer.DebitDue = Convert.ToDouble(dr["DebitDue"]);

                            Customerslist.Add(customer);

                        }
                        dr.Close();

                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL Error : " + ex.Message);
            }
            return Customerslist;
        }
        //Add New Supplier to Database
        public Boolean AddNewCustomers(Customers customer)
        {
            Boolean insert;
            try
            {
                insert = false;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_InsertNewCustomer", conn))
                    {
                        cmd.CommandTimeout = 200;

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@CustomerName", SqlDbType.NVarChar).Value = customer.CustomerName;
                        cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = customer.Phone;
                        cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = customer.Address;
                        cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = customer.Email;

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
        public Boolean UpdateSelectedCustomers(Customers customer)
        {
            Boolean update;
            try
            {
                update = false;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_UpdateCustomerByID", conn))
                    {
                        cmd.CommandTimeout = 200;

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@CustomerID", SqlDbType.VarChar).Value = customer.CustomerID;
                        cmd.Parameters.Add("@CustomerName", SqlDbType.NVarChar).Value = customer.CustomerName;
                        cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = customer.Phone;
                        cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = customer.Address;
                        cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = customer.Email;
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

        //Update Payer status
        public Boolean DeleteSelectedCustomer(Customers customer)
        {
            Boolean update;
            try
            {
                update = false;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_UpdateCustomerstatusById", conn))
                    {
                        cmd.CommandTimeout = 200;

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@CustomerID", SqlDbType.NVarChar).Value = customer.CustomerID;


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
