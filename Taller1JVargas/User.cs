using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1JVargas
{
    public class User
    {
        public string Name { get; set; }
        public string LastName { get; set; } 
        public bool Editor { get; set; }

        public User(string name, string lastName, bool valor) {
            Name = name;
            LastName = lastName;
            Editor = valor;
        }

    }
}
