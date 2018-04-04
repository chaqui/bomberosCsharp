using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDe_Incidentes_de_Bomberos.modelo
{
    class Bombero: Persona, CRUD
    {
        private String _dpi;

        public String dpi
        {
            get { return _dpi; }
            set { _dpi = value; }
        }
        private DateTime _fechaNacimiento;

        public DateTime fechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        private Boolean _estado;

        public Boolean estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public void guardar()
        {
            throw new NotImplementedException();
        }

        public void eliminar()
        {
            throw new NotImplementedException();
        }

        public void modificar()
        {
            throw new NotImplementedException();
        }

        public void seleccionar()
        {
            throw new NotImplementedException();
        }


    }
}
