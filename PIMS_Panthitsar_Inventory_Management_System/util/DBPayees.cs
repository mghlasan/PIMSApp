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
    class DBPayees
    {
        private static DBPayees instance = new DBPayees();
        SqlDataReader dr;
        static string connectionString = ConfigurationManager.ConnectionStrings["dbConnectionString"].ConnectionString;

        public static DBPayees Instance
        {
            get
            {
                return instance;
            }
        }

        //Populate DropDownList
        public List<Payees> GetPayeeList()
        {
            List<Payees> payeelist = null;
            try
            {
                payeelist = new List<Payees>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_getAllPayees", conn))
                    {
                        cmd.CommandTimeout = 200;
                        cmd.CommandType = CommandType.StoredProcedure;
                        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        while (dr.Read())
                        {
                            Payees payee = new Payees();


                            payee.PayeeID = (string)dr["PayeeID"];
                            payee.PayeeName = (string)dr["PayeeName"];

                            payeelist.Add(payee);

                        }
                        dr.Close();

                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL Error : " + ex.Message);
            }
            return payeelist;
        }

        //Populate GridView
        public List<Payees> GetPayeesDetails()
        {
            List<Payees> Payeeslist = null;
            try
            {
                Payeeslist = new List<Payees>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_getAllPayees", conn))
                    {
                        cmd.CommandTimeout = 200;
                        cmd.CommandType = CommandType.StoredProcedure;
                        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        while (dr.Read())
                        {
                            Payees payee = new Payees();

                            payee.Address = (string)dr["Address"];

                            payee.Email = (string)dr["Email"];
                            payee.Phone = (string)dr["Phone"];
                            payee.PayeeID = (string)dr["PayeeID"];
                            payee.PayeeName = (string)dr["PayeeName"];

                            Payeeslist.Add(payee);

                        }
                        dr.Close();

                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL Error : " + ex.Message);
            }
            return Payeeslist;
        }

        //Add New Supplier to Database
        public Boolean AddNewPayees(Payees payer)
        {
            Boolean insert;
            try
            {
                insert = false;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_InsertNewPayee", conn))
                    {
                        cmd.CommandTimeout = 200;

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@PayeeName", SqlDbType.NVarChar).Value = payer.PayeeName;
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
        public Boolean UpdateSelectedPayees(Payees payer)
        {
            Boolean update;
            try
            {
                update = false;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_UpdatePayeeByID", conn))
                    {
                        cmd.CommandTimeout = 200;

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@PayeeID", SqlDbType.VarChar).Value = payer.PayeeID;
                        cmd.Parameters.Add("@PayeeName", SqlDbType.NVarChar).Value = payer.PayeeName;
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
        public Boolean DeleteSelectedPayee(Payees payee)
        {
            Boolean update;
            try
            {
                update = false;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_UpdatePayeeStatusById", conn))
                    {
                        cmd.CommandTimeout = 200;

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@PayeeID", SqlDbType.NVarChar).Value = payee.PayeeID;


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
