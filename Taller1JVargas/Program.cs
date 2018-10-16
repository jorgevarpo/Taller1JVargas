using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1JVargas
{
    class Program
    {
        static void Main(string[] args)
        {
           
            while(Menu());
            Console.WriteLine("Adios");
        }

        public static bool Menu()
        {
            Utils util = new Utils();
            Console.WriteLine("Ingrese Nombre de Usuario");
            string id = Console.ReadLine();
            if (util.Check(id))
            {
                if (util.Editor(id))
                {
                    Console.WriteLine("Bienvenido " + id);
                    while (MenuEditor(id, util)); 
                }
                else {
                    Console.WriteLine("Bienvenido " + id);
                    while (MenuGuest(id, util)) ;
                }
            }
            else {
                Console.WriteLine("Usuario no encontrado");
            }

            return util.Input("Cambiar de Usuario?\n1-Si 2-No");
        }

        public static bool MenuEditor(string id, Utils util)
        {
            if (util.Input("Menu: \n 1-Nueva Publicacion 2-Lista de Publicaciones"))
            {
                util.AddPost(id);
                Console.ReadKey();
            }
            else {
                
                Console.WriteLine(util.ShowPublish());
            }

            return util.Input("Continuar?\n1-Si 2-No");

        }

        public static bool MenuGuest(string id, Utils util) {
            
            if (util.Input("Menu: \n1-Nuevo Comentario 2-Lista de Publicaciones"))
            {
                util.AddComment(id);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(util.ShowPublish());
            }
            
            if (util.Input("Continuar?\n1-Si 2-No"))
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
