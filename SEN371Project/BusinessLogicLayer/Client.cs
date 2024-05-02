using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//regex
using System.Text.RegularExpressions;

namespace SEN371Project.BusinessLogicLayer
{
    internal class Client
    {
        //properties
        int clientId { get; set; }
        string clientName { get; set; }
        string clientNumber { get; set; } //to-do: add some regex for number validation
        string location { get; set; }


        //constructor
        public Client(int id, string cname, string cnumber, string loc)
        {
            this.clientId = id;
            this.clientName = cname;
            this.clientNumber = cnumber;
            this.location = loc;
        }

        //methods
        public string addClient()
        { 
            //add client to repository
            //number validation on client number
        }

        public string updateClient()
        {
            //update client in repository
            //number validation on client number
        }

        public string getClient()
        {
            //get client from repository
        }
    }
}
