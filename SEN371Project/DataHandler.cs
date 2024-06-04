using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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

        string conn = "Server=RGOT-NB-01\\SQL2019;Database=pss_db_project2_sen371;Integrated Security=True;";

        //Incidents
        public DataTable getIncidents()
        {
            SqlConnection con = new SqlConnection(conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("sp_ReadIncident", con);

            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;  
        }

        //Service Requests
        public DataTable getServiceRequests()
        {
            SqlConnection con = new SqlConnection(conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("sp_ReadServiceRequest", con);

            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;
        }
        //CallCenter
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

        //Clients
      
        //Method using Stored Procedure to update Client detials from newclientform 
        public void updateClientDetails(string ClientNumber, string ClientName, string ClientLocation, int ContractID )
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("sp_UpdateClient", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ClientName", ClientNumber);
                cmd.Parameters.AddWithValue("@ClientNumber", ClientName);
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
                SqlCommand cmd = new SqlCommand("sp_CreateClientIfNotExist", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ClientName", ClientName);
                cmd.Parameters.AddWithValue("@ClientNumber", ClientNumber);
                cmd.Parameters.AddWithValue("@ClientLocation", ClientLocation);
                cmd.Parameters.AddWithValue("@ContractID", ContractID);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        //Method using Stored Procedure to Search Client detials from Clients Table into Datatable 
        public DataTable searchClient(string ClientName)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("sp_SearchClients", con);
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
        //Method using Stored Procedure to DELETE Client detials
        public void deleteClient(string ClientName)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("sp_DeleteClient", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClientName", ClientName);
                con.Open();
                cmd.ExecuteNonQuery();

            }
        }
        //Method using Stored Procedure to READ Client detials
        public DataTable getClientDetails()
        {

            SqlConnection con = new SqlConnection(conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("sp_ReadClient", con);

            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;
        }

        //Contracts
        //Method using Stored Procedure to Update Contract detials
        public void updateContractDetails(string ContractName, string StartDate, string EndDate, float Cost)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("sp_UpdateContract", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ContractName", ContractName);
                cmd.Parameters.AddWithValue("@StartDate", StartDate);
                cmd.Parameters.AddWithValue("@EndDate", EndDate);
                cmd.Parameters.AddWithValue("@Cost", Cost);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        //Method using Stored Procedure to Create Contract detials
        public void createContract(string ContractName, string StartDate, string EndDate, float Cost)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("sp_CreateContractIfNotExist", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ContractName", ContractName);
                cmd.Parameters.AddWithValue("@StartDate", StartDate);
                cmd.Parameters.AddWithValue("@EndDate", EndDate);
                cmd.Parameters.AddWithValue("@Cost", Cost);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //Method using Stored Procedure to search Contract detials
        public DataTable searchContracts(string ContractName)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("sp_SearchContracts", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ContractName", ContractName);
                con.Open();

                DataTable dt = new DataTable();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                    return dt;
                }
                cmd.ExecuteNonQuery();
            }
        }

        //Method using Stored Procedure to DELETE Contract detials
        public void deleteContract(string ContractName)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("sp_DeleteContract", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ContractName", ContractName);
                con.Open();
                cmd.ExecuteNonQuery();

            }
        }

        //Method using Stored Procedure to READ Contract detials
        public DataTable getContractDetails()
        {

            SqlConnection con = new SqlConnection(conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("sp_ReadContract", con);

            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;
        }

        //ServiceRequests
        //Method using Stored Procedure to UPDATE ServiceRequests STATUS sp_UpdateServiceRequestStatus
        public void updateServiceRequestStatus(string RequestNumber, int TicketStatusID)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("sp_UpdateIncidentStatus", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RequestNumber", RequestNumber);
                cmd.Parameters.AddWithValue("@TicketStatusID", TicketStatusID);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        //Method using Stored Procedure to CREATE ServiceRequests detials sp_InsertServiceRequest

        //Method using Stored Procedure to SEARCH ServiceRequests detials sp_SearchServiceRequests
        public DataTable searchServiceRequests(string RequestNumber)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("sp_SearchServiceRequests", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RequestNumber", RequestNumber);
                con.Open();

                DataTable dt = new DataTable();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                    return dt;
                }
                cmd.ExecuteNonQuery();
            }
        }
        //Method using Stored Procedure to DELETE ServiceRequests detials sp_DeleteServiceRequest
        public void deleteServiceRequest(string RequestNumber)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("sp_DeleteServiceRequest", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RequestNumber", RequestNumber);
                con.Open();
                cmd.ExecuteNonQuery();

            }
        }
        //Method using Stored Procedure to READ ServiceRequests detials sp_ReadServiceRequest
        public DataTable getServiceRequestDetails()
        {

            SqlConnection con = new SqlConnection(conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("sp_ReadServiceRequest", con);

            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;
        }


        //Incidents
        //Method using Stored Procedure to UPDATE Incidents STATUS sp_UpdateIncidentStatus
        public void updateIncidentStatus(string IncidentNumber, int TicketStatusID)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("sp_UpdateIncidentStatus", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IncidentNumber", IncidentNumber);
                cmd.Parameters.AddWithValue("@TicketStatusID", TicketStatusID);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        //Method using Stored Procedure to CREATE Incidents detials sp_CreateIncident

        //Method using Stored Procedure to SEARCH Incidents detials sp_SearchIncidents
        public DataTable searchIncidents(string IncidentNumber)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("sp_SearchIncidents", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IncidentNumber", IncidentNumber);
                con.Open();

                DataTable dt = new DataTable();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                    return dt;
                }
                cmd.ExecuteNonQuery();
            }
        }
        //Method using Stored Procedure to DELETE Incidents detials sp_DeleteIncident
        public void deleteIncident(string IncidentNumber)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("sp_DeleteIncident", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IncidentNumber", IncidentNumber);
                con.Open();
                cmd.ExecuteNonQuery();

            }
        }

        //Method using Stored Procedure to READ Incidents detials sp_ReadIncident
        public DataTable getIncidentDetails()
        {

            SqlConnection con = new SqlConnection(conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("sp_ReadIncident", con);

            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;
        }
    }

}
