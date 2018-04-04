using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDe_Incidentes_de_Bomberos.modelo
{
    interface CRUD
    {
        void guardar();
        void eliminar();
        void modificar();
        void seleccionar();

    }
}
