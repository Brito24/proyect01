using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class Alumno
    {
        public string Nombre;
        public string TipoDocumento;
        public string Documento;
        public List<Materia> listaMaterias = new();//SE CREA UNA LISTA TIPO CLASE QUE SE TRAE DE MATERIA
    }
}
