using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Unternehmen_SEW
{
    public abstract class Management
    {
        public string Name;
        public int Id;
        public int Age;
        public string Job;
        public Management(int age, int id, string name, string job)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Job = job;
        }

        public abstract void AssignAufgabe();
    }
}
