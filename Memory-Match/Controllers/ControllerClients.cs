using Memory_Match.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Match.Controllers
{
    internal class ControllerClients
    {
        private List<Client> clients;

        public ControllerClients()
        {

            clients = new List<Client>();

            load();

        }

        public void load()
        {
            string path = Application.StartupPath + @"/data/clients.txt";
            StreamReader reader = new StreamReader(path);

            string text;

            while((text = reader.ReadLine()) != null)
            {
                Client a = new Client(text);

                clients.Add(a);
            }

            reader.Close();
        }

        public void afisare()
        {

            for(int i=0;i<clients.Count; i++)
            {
                MessageBox.Show(clients[i].descriere());
            }

        }

        public bool verificare(string name, string pass)
        {

            for(int i=0;i< clients.Count;i++)
            {
                if (clients[i].getName().Equals(name) && clients[i].getPassword().Equals(pass)) {
                return true;
                }
            }
            return false;
        }

        public int idByName(string name, string pass)
        {

            for (int i = 0; i < clients.Count; i++)
            {
                if (clients[i].getName().Equals(name) && clients[i].getPassword().Equals(pass))
                {
                    return clients[i].getId();
                }
            }
            return -1;
        }

        public int scoreById(int id)
        {

            for(int i=0;i<clients.Count;i++) {

                if (clients[i].getId() == id)
                {
                    return clients[i].getScore();
                }
            
            }

            return -1;
        }

        public string toSaveFisier()
        {

            string t = "";

            for(int i=0;i < clients.Count;i++)
            {
                t += clients[i].toSave() + "\n";
            }

            return t;
        }
        
        public void save()
        {

            string path = Application.StartupPath + @"/data/clients.txt";
            StreamWriter streamWriter = new StreamWriter(path); 

            streamWriter.Write(this.toSaveFisier());

            streamWriter.Close();

        }

        public void setScore(int id, int score)
        {

            for(int i=0;i< clients.Count;i++)
            {

                if (clients[i].getId() == id)
                {
                    clients[i].setScore(score);
                }

            }

        }

        public void addClient(string textul)
        {

            string text = textul;
            string path = Application.StartupPath + @"/data/clients.txt";
            File.AppendAllText(path, text + "\n");


        }

        public Client getById(int id)
        {

            for(int i= 0;i < clients.Count; i++)
            {
                if (id == clients[i].getId())
                {
                    return clients[i];
                }
            }

            return null;    
        }

        public int generareId()
        {

            Random random = new Random();

            int id = random.Next();

            while(this.getById(id) != null)
            {
                id = random.Next();
            }

            return id;
        }


    }
}
