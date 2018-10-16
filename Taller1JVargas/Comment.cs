using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1JVargas
{
    class Comment:Post
    {
        public Comment(string autor, string content) {
            Autor = autor;
            Content = content;
        }

        public String Info() {
            StringBuilder sb = new StringBuilder();
            sb.Append("         -------------------------------------"+Environment.NewLine);
            sb.Append("         |Fecha:" + Date + Environment.NewLine);
            sb.Append("         |" + Content+Environment.NewLine);
            sb.Append("         |Por: " + Autor);
            sb.Append( Environment.NewLine);
            return sb.ToString();
        }
    }
}
