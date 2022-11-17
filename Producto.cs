using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore_Cafe_Soluble.Model
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contenido { get; set; }
        public int Peso { get; set; }
        public string Color { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
    }
}
