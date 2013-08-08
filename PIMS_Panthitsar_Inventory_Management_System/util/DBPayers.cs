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
    class DBPayers
    {
        private static DBPayers instance = new DBPayers();
        SqlDataReader dr;
        static string connectionString = ConfigurationManager.ConnectionStrings["dbConnectionString"].ConnectionString;

        public static DBPayers Instance
        {
            get
            {
                return instance;
            }
        }

        //Populate DropDownList
        public List<Payers> GetPayerList()
        {
            List<Payers> payerlist = null;
            try
            {
                payerlist = new List<Payers>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_getAllPayers", conn))
                    {
                        cmd.CommandTimeout = 200;
                        cmd.CommandType = CommandType.StoredProcedure;
                        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        while (dr.Read())
                        {
                            Payers payer = new Payers();


                            payer.PayerID = (string)dr["PayerID"];
                            payer.PayerName = (string)dr["PayerName"];

                            payerlist.Add(payer);

                        }
                        dr.Close();

                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL Error : " + ex.Message);
            }
            return payerlist;
        }

        //Populate GridView
        public List<Payers> GetPayersDetails()
        {
            List<Payers> Payerslist = null;
            try
            {
                Payerslist = new List<Payers>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_getAllPayers", conn))
                    {
                        cmd.CommandTimeout = 200;
                        cmd.CommandType = CommandType.StoredProcedure;
                        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        while (dr.Read())
                        {
                            Payers payer = new Payers();

                            payer.Address = (string)dr["Address"];

                            payer.Email = (string)dr["Email"];
                            payer.Phone = (string)dr["Phone"];
                            payer.PayerID = (string)dr["PayerID"];
                            payer.PayerName = (string)dr["PayerName"];

                            Payerslist.Add(payer);

                        }
                        dr.Close();

                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL Error : " + ex.Message);
            }
            return Payerslist;
        }

        //Add New Supplier to Database
        public Boolean AddNewPayers(Payers payer)
        {
            Boolean insert;
            try
            {
                insert = false;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_InsertNewPayer", conn))
                    {
                        cmd.CommandTimeout = 200;

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@PayerName", SqlDbType.NVarChar).Value = payer.PayerName;
                        cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = payer.Phone;
                        cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = payer.Address;
                        cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = payer.Email;

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
        public Boolean UpdateSelectedPayers(Payers payer)
        {
            Boolean update;
            try
            {
                update = false;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_UpdatePayerByID", conn))
                    {
                        cmd.CommandTimeout = 200;

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@PayerID", SqlDbType.VarChar).Value = payer.PayerID;
                        cmd.Parameters.Add("@PayerName", SqlDbType.NVarChar).Value = payer.PayerName;
                        cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = payer.Phone;
                        cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = payer.Address;
                        cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = payer.Email;
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
        public Boolean DeleteSelectedPayer(Payers payer)
        {
            Boolean update;
            try
            {
                update = false;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_UpdatePayerStatusById", conn))
                    {
                        cmd.CommandTimeout = 200;

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@PayerID", SqlDbType.NVarChar).Value = payer.PayerID;


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
