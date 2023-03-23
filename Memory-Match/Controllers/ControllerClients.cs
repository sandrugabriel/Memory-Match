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

    }
}
