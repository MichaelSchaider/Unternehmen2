using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unternehmen_SEW
{
    public class Praktikanten : Management
    {
        public Praktikanten(int age, int id, string name, string job, string address) : base(age, id, name, job)
        {

        }
        public override void AssignAufgabe()
        {
            Console.WriteLine("Der Praktikant beginnt zu Arbeiten");
        }
        public void Helfen()
        {
            Console.WriteLine("Der Praktikant hilft bei der Arbeit mit");
        }
    }
}
