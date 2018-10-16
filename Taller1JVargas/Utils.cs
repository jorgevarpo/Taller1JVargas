using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1JVargas
{
    class Utils
    {
        Base basesita = new Base();

        public bool Check(string name) {
            bool data = false;
            foreach (User x in Base.DataBase)
            {
                if (name.Equals(x.Name)) data = true;
            }
            return data;
        }

        public bool Editor(string name)
        {
            bool data = false;
            foreach (User x in Base.DataBase)
            {
                if (x.Name == name) data = x.Editor;
            }
            return data;
        }

        public void AddPost(string autor) {
            Console.WriteLine("Ingrese el contenido de la Publicacion");
            string content = null;
            while(content == null)
            {
                content = Console.ReadLine();
                if (content.Length < 1)
                { Console.WriteLine("Ingrese algun contenido en el Post");
                  content = null;
                }
           }
            Base.Publish.Add(new Post(autor, content));
            Console.WriteLine("Post Agregado!");
        }

        public string ShowPublish() {
            StringBuilder sb = new StringBuilder();
            if (Base.Publish.Count > 0)
            {
                foreach (Post x in Base.Publish)
                {
                    sb.Append(x.GetPost());
                }
                return sb.ToString();
            }
            else {
                sb.Append("No hay publicaciones");
            }
            return sb.ToString();
        }

        public bool Check(int id) {
            bool a = false;
            foreach (Post x in Base.Publish)
            {
                if (x.IdPost == id) a = true;
            }
            return a;
        }

        public void AddComment(string autor)
        {
            Console.WriteLine("Ingrese el numero de Publicacion");
            int op = int.Parse(Console.ReadLine());
            if (Check(op))
            {
                Console.WriteLine("Ingrese el comentario");
                string content = Console.ReadLine();
                foreach (Post x in Base.Publish) {
                    if (x.IdPost == op) x.AddComment(autor,content);
                }
                Console.WriteLine("Comentario Agregado!");
            }
            else {
                Console.WriteLine("No hay publicaciones con ese numero");
            }
        }

        public bool Input(String message)
        {
            Console.WriteLine(message);
            int opc = 0 ;
            while (opc < 1)
            {
                try
                {
                    opc = int.Parse(Console.ReadLine());
                    if (opc > 2)
                    {
                        opc = 0;
                        Console.WriteLine("Las opciones validas son 1 o 2");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Ingrese solo numeros");
                }
            }

            if (opc == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
