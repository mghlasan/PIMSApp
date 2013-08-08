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
    class DBBanks
    {
        private static DBBanks instance = new DBBanks();
        SqlDataReader dr;
        static string connectionString = ConfigurationManager.ConnectionStrings["dbConnectionString"].ConnectionString;

        public static DBBanks Instance
        {
            get
            {
                return instance;
            }
        }

        //Populate DropDownList
        public List<Banks> GetBankList()
        {
            List<Banks> banklist = null;
            try
            {
                banklist = new List<Banks>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_getAllBanks", conn))
                    {
                        cmd.CommandTimeout = 200;
                        cmd.CommandType = CommandType.StoredProcedure;
                        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        while (dr.Read())
                        {
                            Banks bank = new Banks();


                            bank.BankID = (string)dr["BankID"];
                            bank.BankName = (string)dr["BankName"];

                            banklist.Add(bank);

                        }
                        dr.Close();

                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL Error : " + ex.Message);
            }
            return banklist;
        }

        //Populate GridView
        public List<Banks> GetBanksDetails()
        {
            List<Banks> Bankslist = null;
            try
            {
                Bankslist = new List<Banks>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_getAllBanks", conn))
                    {
                        cmd.CommandTimeout = 200;
                        cmd.CommandType = CommandType.StoredProcedure;
                        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        while (dr.Read())
                        {
                            Banks bank = new Banks();

                            bank.Address = (string)dr["Address"];

                            bank.Email = (string)dr["Email"];
                            bank.Phone = (string)dr["Phone"];
                            bank.BankID = (string)dr["BankID"];
                            bank.BankName = (string)dr["BankName"];

                            Bankslist.Add(bank);

                        }
                        dr.Close();

                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("SQL Error : " + ex.Message);
            }
            return Bankslist;
        }

        //Add New Supplier to Database
        public Boolean AddNewBank(Banks bank)
        {
            Boolean insert;
            try
            {
                insert = false;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_InsertNewBank", conn))
                    {
                        cmd.CommandTimeout = 200;

                        cmd.CommandType = CommandType.StoredProcedure;
                       
                        cmd.Parameters.Add("@BankName", SqlDbType.NVarChar).Value = bank.BankName;
                        cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = bank.Phone;
                        cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = bank.Address;
                        cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = bank.Email;

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
        public Boolean UpdateSelectedBanks(Banks bank)
        {
            Boolean update;
            try
            {
                update = false;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_UpdateBankByID", conn))
                    {
                        cmd.CommandTimeout = 200;

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@BankID", SqlDbType.VarChar).Value = bank.BankID;
                        cmd.Parameters.Add("@BankName", SqlDbType.NVarChar).Value = bank.BankName;
                        cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = bank.Phone;
                        cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = bank.Address;
                        cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = bank.Email;
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
        public Boolean DeleteSelectedBank(Banks bank)
        {
            Boolean update;
            try
            {
                update = false;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_UpdateBankStatusById", conn))
                    {
                        cmd.CommandTimeout = 200;

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@BankID", SqlDbType.NVarChar).Value = bank.BankID;
                        

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
