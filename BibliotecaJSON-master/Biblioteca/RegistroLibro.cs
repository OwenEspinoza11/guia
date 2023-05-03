using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Biblioteca
{
    public class RegistroLibro
    {
        public int ISBN;
        public string Titulo;
        public string Autor;
        public string Editorial;
        public int Paginas;
        public RegistroLibro(int isbn, string nombre, string autor, string editorial, int paginas)
        {
            this.ISBN = isbn;
            this.Titulo = nombre;
            this.Autor = autor;
            this.Editorial = editorial;
            this.Paginas = paginas;
        }
    }
    
}
