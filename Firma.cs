using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unternehmen_SEW
{
    public class Firma
    {
        private string name = string.Empty;
        private string address = string.Empty;
        protected Management[] arbeiter;

        public Firma(string name, string address, Management[] arbeiter)
        {
            this.name = name;
            this.address = address;
            this.arbeiter = arbeiter;   
        }

        public string Name   
        {
            get { return name; }   
            set { name = value; }  
        }
        public string Address
        {
            get { return address; }   
            set { address = value; }  
        }

        public Management[] GetArbeiter()
        {
            return arbeiter;
        }

        public string DisplayWorker()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arbeiter.Length; i++)
            {
                sb.Append($"Der Arbeiter mit der Nummer {arbeiter[i].Id}, heißt {arbeiter[i].Name} und ist {arbeiter[i].Age} Jahre alt. Job: {arbeiter[i].Job} \n");
            }
            return sb.ToString();
        }
    }
}
