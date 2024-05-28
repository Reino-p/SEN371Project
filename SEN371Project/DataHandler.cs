using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN371Project
{
    internal class DataHandler
    {
        public DataHandler()
        {

        }

        string conn = "Server=RGOT-NB-01\\SQLEXPRESS;Database=pss_db_project2_sen371;Integrated Security=True;";

        public DataTable getIncidents()
        {
            SqlConnection con = new SqlConnection(conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("something", con);

            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;  
        }

        public DataTable getServiceRequests()
        {
            SqlConnection con = new SqlConnection(conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("something", con);

            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;
        }
        //Method using Stored Procedure to read Client detials for CallcenterForm
        public TextBox getCallerID(int ClientID, string ClientNumber)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                using(SqlCommand cmd = new SqlCommand("something", con))
                {
                    cmd.Parameters.Add("@ClientID", ClientID);
                    cmd.Parameters.Add("@ClientNumber", ClientNumber);

                    con.Open();

                    string callerID = cmd.ExecuteScalar()?.ToString();
                }              
            }
            TextBox textbox = new TextBox()
            {
                Text = ClientNumber,
            };           
            return textbox;
        }


        //Method using Stored Procedure to update Client detials from newclientform 
        public void updateClientDetails(string ClientName, string ClientNumber, string ClientLocation, int ContractID )
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spGetCallerID", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ClientName", ClientName);
                cmd.Parameters.AddWithValue("@ClientNumber", ClientNumber);
                cmd.Parameters.AddWithValue("@ClientLocation", ClientLocation);
                cmd.Parameters.AddWithValue("@ContractID", ContractID);
                
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //Method using Stored Procedure to create new Client detials from newclientform 
        public void createClient(string ClientName, string ClientNumber, string ClientLocation, int ContractID)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spCreateClient", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ClientName", ClientName);
                cmd.Parameters.AddWithValue("@ClientNumber", ClientNumber);
                cmd.Parameters.AddWithValue("@ClientLocation", ClientLocation);
                cmd.Parameters.AddWithValue("@ContractID", ContractID);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        //Method using Stored Procedure to read Client detials from Clients Table into Datatable 
        public DataTable searchClient(string ClientName)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spSearchClient", con);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClientName", ClientName);
                con.Open ();

                DataTable dt = new DataTable();

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                    return dt;
                }
                cmd.ExecuteNonQuery ();
            }
        }


    }
}
