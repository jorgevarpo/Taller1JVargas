﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1JVargas
{
    class Base
    {
        public Base() {
            Fill();
        }

        public static int Id = 0;

         public static List<User> DataBase = new List<User>();
        public static List<Post> Publish = new List<Post>();

        public void Fill() {
            DataBase.Add(new User("John", "Smith", true));
            DataBase.Add(new User("Ramon", "Valdez", false));
        }
    }
}
