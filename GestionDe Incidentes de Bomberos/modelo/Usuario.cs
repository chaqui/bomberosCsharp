using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDe_Incidentes_de_Bomberos.modelo
{
    class Usuario
    {
        private string _nickName;

        public string nickName
        {
            get { return _nickName; }
            set { _nickName = value; }
        }

        private String _contrasenia;

        public String contrasenia
        {
            get { return _contrasenia; }
            set { _contrasenia = value; }
        }

        private Boolean _estado;

        public Boolean estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        private Bombero _bombero;

        public Bombero bombero
        {
            get { return _bombero; }
            set { _bombero = value; }
        }




    }
}
