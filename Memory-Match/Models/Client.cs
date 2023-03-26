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
        private int score;

        public Client(int id, string name, string password, int score)
        {
            this.id = id;
            this.name = name;
            this.password = password;
            this.score = score;
        }

        public Client(string text)
        {

            string[] prop = text.Split(',');

            this.id = int.Parse(prop[0]);   
            this.name = prop[1];
            this.password = prop[2];
            this.score = int.Parse(prop[3]);

        }

        public int getId() {
            return id; }

        public string getName() {
            return name; }

        public string getPassword() { 
            return password; }
        
        public int getScore()
        {
            return score;
        }

        public void setScore(int score)
        {
            this.score = score;
        }

        public string descriere()
        {

            string t = "";

            t += "Id: " + getId() + "\n";
            t += "Name: " + getName() + "\n";
            t += "Password: " + getPassword() + "\n";

            return t;
        }

        public string toSave()
        {
            return id.ToString() + "," + name + "," + password + "," + score.ToString();
        }

    }
}
