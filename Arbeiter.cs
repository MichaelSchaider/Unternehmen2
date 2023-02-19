using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unternehmen_SEW
{
    public class Arbeiter : Management
    {
        public Arbeiter(int age, int id, string name, string job, string address) : base(age, id, name, job)
        {

        }
        public override void AssignAufgabe()
        {
            Console.WriteLine("Der Arbeiter beginnt zu Arbeiten");
        }
    }
}
