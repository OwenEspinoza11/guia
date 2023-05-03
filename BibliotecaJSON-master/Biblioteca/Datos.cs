using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Newtonsoft.Json;

namespace Biblioteca
{
    public class Datos<T>
    {
        public List<T> valores = new List<T>();
        public string ruta;

        public Datos(string r)
        {
            ruta = r;
        }
        public void Guardar()
        {
            string texto = JsonConvert.SerializeObject(valores);
            File.WriteAllText(ruta, texto);
        }

        public void Cargar()
        {
            try
            {
                string archivo = File.ReadAllText(ruta);
                valores = JsonConvert.DeserializeObject<List<T>>(archivo)!;
            }
            catch (Exception) { }
        }


        public void Insertar(T nuevo)
        {
            valores.Add(nuevo);
            Guardar();
        }

        public List<T> Buscar(Func<T, bool> criterio)
        {
            return valores.Where(criterio).ToList();
        }


       
    }
}
