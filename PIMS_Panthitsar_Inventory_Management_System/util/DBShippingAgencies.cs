using PIMS_Panthitsar_Inventory_Management_System.objects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMS_Panthitsar_Inventory_Management_System.util
{
    class DBShippingAgencies
    {
        private static DBShippingAgencies instance = new DBShippingAgencies();

        SqlDataReader dr;
        static string connectionString = ConfigurationManager.ConnectionStrings["dbConnectionString"].ToString();

        public static DBShippingAgencies Instance
        {
            get
            {
                return instance;
            }
        }

        public List<ShippingAgencies> GetShippingAgenciesList()
        {
            List<ShippingAgencies> shippingAgencylist = null;
            try
            {
                shippingAgencylist = new List<ShippingAgencies>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_getAllShippingAgencies", conn))
                    {
                        cmd.CommandTimeout = 200;
                        cmd.CommandType = CommandType.StoredProcedure;
                        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        while (dr.Read())
                        {
                            ShippingAgencies shippingAgency = new ShippingAgencies();


                            shippingAgency.ShippingAgencyID = (string)dr["ShippingAgencyID"];
                            shippingAgency.ShippingAgencyName = (string)dr["shippingAgencyName"];


                            shippingAgencylist.Add(shippingAgency);

                        }
                        dr.Close();

                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL Error : " + ex.Message);
            }
            return shippingAgencylist;
        }

        //Populate GridView
        public List<ShippingAgencies> GetShippingAgencyDetails()
        {
            List<ShippingAgencies> shippingAgencieslist = null;
            try
            {
                shippingAgencieslist = new List<ShippingAgencies>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_getAllShippingAgencies", conn))
                    {
                        cmd.CommandTimeout = 200;
                        cmd.CommandType = CommandType.StoredProcedure;
                        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        while (dr.Read())
                        {
                            ShippingAgencies shippingAgency = new ShippingAgencies();

                            shippingAgency.Address = (string)dr["Address"];

                            shippingAgency.Email = (string)dr["Email"];
                            shippingAgency.Phone = (string)dr["Phone"];
                            shippingAgency.ShippingAgencyID = (string)dr["ShippingAgencyID"];
                            shippingAgency.ShippingAgencyName = (string)dr["ShippingAgencyName"];
                            shippingAgency.Amount=Convert.ToDouble(dr["Amount"]);

                            shippingAgencieslist.Add(shippingAgency);

                        }
                        dr.Close();

                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL Error : " + ex.Message);
            }
            return shippingAgencieslist;
        }

        //Add New Supplier to Database
        public Boolean AddNewShippingAgencies(ShippingAgencies shippingAgency)
        {
            Boolean insert;
            try
            {
                insert = false;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_InsertNewShippingAgency", conn))
                    {
                        cmd.CommandTimeout = 200;

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@ShippingAgencyName", SqlDbType.NVarChar).Value = shippingAgency.ShippingAgencyName;
                        cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = shippingAgency.Phone;
                        cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = shippingAgency.Address;
                        cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = shippingAgency.Email;

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
        public Boolean UpdateSelectedShippingAgencies(ShippingAgencies shippingAgency)
        {
            Boolean update;
            try
            {
                update = false;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_UpdateShippingAgencyByID", conn))
                    {
                        cmd.CommandTimeout = 200;

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@ShippingAgencyID", SqlDbType.VarChar).Value = shippingAgency.ShippingAgencyID;
                        cmd.Parameters.Add("@ShippingAgencyName", SqlDbType.NVarChar).Value = shippingAgency.ShippingAgencyName;
                        cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = shippingAgency.Phone;
                        cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = shippingAgency.Address;
                        cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = shippingAgency.Email;
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
        public Boolean DeleteSelectedShippingAgencies(ShippingAgencies shippingAgency)
        {
            Boolean update;
            try
            {
                update = false;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_UpdateShippingAgencyStatusById", conn))
                    {
                        cmd.CommandTimeout = 200;

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@ShippingAgencyID", SqlDbType.NVarChar).Value = shippingAgency.ShippingAgencyID;


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
