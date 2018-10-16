using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1JVargas
{
    class Post
    {
        
        public Post(string autor, string content) {
            Base.Id += 1;
            Autor = autor;
            Content = content;
        }
        public Post() { }
        public int IdPost = Base.Id;
        public string Date = DateTime.Now.ToString("dd-MM-yyyy h:mm:ss tt");
        public string Content { get; set; }
        public string Autor { get; set; }
        public List<Comment> Comments = new List<Comment>();

        public string GetComment()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Comment x in Comments)
            {
                sb.Append(x.Info());
            }
            return sb.ToString();
        }

        public void AddComment(string autor, string content) {
            Comments.Add(new Comment(autor, content));
        }

        public string GetPost()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append( Environment.NewLine);
            sb.Append("------------------------------------------------" + Environment.NewLine);
            sb.Append("Publicacion: "+ IdPost+ " Fecha: " + Date + Environment.NewLine);
            sb.Append(" "+Content + Environment.NewLine);
            sb.Append("Autor: " + Autor + Environment.NewLine);
            if (!(Comments == null))
            {
                if (Comments.Count > 0)
                {
                    sb.Append("         Comentarios:" + Environment.NewLine);
                    sb.Append(GetComment());
                }
            }
            
            return sb.ToString();
        }

    }
}
