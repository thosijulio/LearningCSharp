using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients
{
    class Client
    {
        private string name = "";
        private string cpf = "";
        private string occupation = "";

        public void SetName(string newName)
        {
            name = newName;
        }

        public string GetName()
        {
            return name;
        }
        
        public void SetCpf(string newCpf)
        {
            cpf = newCpf;
        }

        public string getCpf()
        {
            return cpf;
        }
        
        public void SetOccupation(string newOccupation)
        {
            occupation = newOccupation;
        }
        
        public string getOccupation()
        {
            return occupation;
        }
    }
}