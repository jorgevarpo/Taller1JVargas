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

        /// <summary>
        /// Este metodo verifica si el usuario ingresado esta en la lista
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool Check(string name) {
            bool data = false;
            foreach (User x in Base.DataBase)
            {
                if (name.Equals(x.Name)) data = true;
            }
            return data;
        }

        public bool Editor(string name)
        /// <summary>
        /// Este metodo devolvera el valor del booleano editor
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        {
            bool data = false;
            foreach (User x in Base.DataBase)
            {
                if (x.Name == name) data = x.Editor;
            }
            return data;
        }

        public void AddPost(string autor) {
            /// <summary>
            /// Este metodo creara un objeto de tipo POST con la publicacion y lo agregara en la lista de publicaciones
            /// ademas verificara si la publicacion contiene algo para evitar publicaciones vacias
            /// </summary>
            /// <param name="name"></param>
            /// <returns></returns>
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
            /// <summary>
            /// Este metodo Creara un String con todas las publicaciones para ser mostradas en pantalla
            /// si no hubieran mostrara la advertencia
            /// </summary>
            /// <param name="name"></param>
            /// <returns></returns>
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
            /// <summary>
            /// Este metodo verifica si existe una publicacion, con un numero dado
            /// </summary>
            /// <param name="name"></param>
            /// <returns></returns>
            bool a = false;
            foreach (Post x in Base.Publish)
            {
                if (x.IdPost == id) a = true;
            }
            return a;
        }

        public void AddComment(string autor)
        {
            /// <summary>
            /// Este metodo agregara el comentario a la publicacion, si no la encuentra o no existe mostrara la advertencia
            /// </summary>
            /// <param name="name"></param>
            /// <returns></returns>
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
        {/// <summary>
        /// Este metodo servira para validar que el usuario ingrese unicamente 1 o 2 en la seleccion para moverse dentro de la aplicacion 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
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
