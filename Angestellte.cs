using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Unternehmen_SEW
{
    public class Angestellte : Management
    {
        public Angestellte(int age, int id, string name, string job, string address) : base(age, id, name, job)
        {

        }
        public override void AssignAufgabe()
        {
            Console.WriteLine("Der Angestellte beginnt zu Arbeiten");
        }
        public void Programmieren()
        {
            Console.WriteLine("Programmieren");
        }
        public void Lohnverechnen()
        {
            Console.WriteLine("Lohn wird verrechnet");
        }
    }
}
