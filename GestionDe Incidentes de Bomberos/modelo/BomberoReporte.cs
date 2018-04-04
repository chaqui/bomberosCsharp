using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDe_Incidentes_de_Bomberos.modelo
{
    class BomberoReporte : CRUD
    {
        private String _labor;

        public String labor
        {
            get { return _labor; }
            set { _labor = value; }
        }

        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        private Bombero _bombero;

        public Bombero bombero
        {
            get { return _bombero; }
            set { _bombero = value; }
        }


        public void eliminar()
        {
            throw new NotImplementedException();
        }

        public void guardar()
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
