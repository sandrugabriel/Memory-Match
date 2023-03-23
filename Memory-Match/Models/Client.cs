using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Memory_Match.Models
{
    internal class Client
    {

        private int id;
        private string name;
        private string password;

        public Client(int id, string name, string password)
        {
            this.id = id;
            this.name = name;
            this.password = password;
        }

        public Client(string text)
        {

            string[] prop = text.Split(',');

            this.id = int.Parse(prop[0]);   
            this.name = prop[1];
            this.password = prop[2];

        }

        public int getId() {
            return id; }

        public string getName() {
            return name; }

        public string getPassword() { 
            return password; }
        
        public string descriere()
        {

            string t = "";

            t += "Id: " + getId() + "\n";
            t += "Name: " + getName() + "\n";
            t += "Password: " + getPassword() + "\n";

            return t;
        }

    }
}
