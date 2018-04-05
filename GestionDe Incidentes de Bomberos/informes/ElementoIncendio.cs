using System;
using System.Collections.Generic;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace GestionDe_Incidentes_de_Bomberos.informes
{
    class ElementoIncendio
    {
        private String _fecha;

        public String fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        private String _hora;

        public String hora
        {
            get { return _hora; }
            set { _hora = value; }
        }

        private String _cantidad;

        public String cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
        private String _lugar;

        public String lugar
        {
            get { return _lugar; }
            set { _lugar = value; }
        }

        private String _propietario;

        public String propietario
        {
            get { return _propietario; }
            set { _propietario = value; }
        }

        private String _causa;

        public String causa
        {
            get { return _causa; }
            set { _causa = value; }
        }
        private String _perdidas;

        public String perdidas
        {
            get { return _perdidas; }
            set { _perdidas = value; }
        }

        private String _aguaUtilizada;

        public String aguaUtilizada
        {
            get { return _aguaUtilizada; }
            set { _aguaUtilizada = value; }
        }







    }
}
