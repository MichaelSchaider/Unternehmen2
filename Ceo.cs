using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Unternehmen_SEW
{
    public class Ceo : Management
    {
        public Ceo(int age, int id, string name, string job, string address) : base(age, id, name, job)

        {

        }
        public override void AssignAufgabe()
        {
            Console.WriteLine("Der CEO kümmert sich um das Unternehmen");
        }
    }
}
