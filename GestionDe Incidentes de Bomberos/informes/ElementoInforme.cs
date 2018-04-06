using GestionDe_Incidentes_de_Bomberos.modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDe_Incidentes_de_Bomberos.informes
{
    class ElementoInforme
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

        private String _nombre;

        public String nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private String _edad;

        public String edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        private String _sexo;

        public String sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

        private String _vivo;

        public String vivo
        {
            get { return _vivo; }
            set { _vivo = value; }
        }

        private String _fallecido;

        public String fallecido
        {
            get { return _fallecido; }
            set { _fallecido = value; }
        }

        public object ConexionABd { get; private set; }

        public List<ElementoInforme> seleccionarElementos(int tipoIncidente)
        {
            List<ElementoInforme> informes = new List<ElementoInforme>();
            MySqlConnection con = ConexionABD.conectar();
            String consulta = "SELECT CONCAT(nombre, ' ', apellidos) As Nombre, estado, edad, sexo, fecha, horaSalida FROM paciente INNER JOIN (SELECT fecha, horaSalida, Paciente_idPaciente from reporte_incidente where tipoIncidente_idtipoIncidente = "+tipoIncidente.ToString()+") as infomeIncidente where Paciente_idPaciente = idPaciente; ";
            MySqlCommand comando = new MySqlCommand(string.Format(consulta));
            IDataReader data = 
            if (data != null)
            {
                while (data.Read())
                {
                    ElementoInforme elemento = new ElementoInforme();
                    elemento.nombre = data.GetString(0);
                    if(data.GetString(1) == "viva")
                    {
                        elemento.vivo = "X";
                    }
                    else
                    {
                        elemento.fallecido = "X";
                    }
                    elemento.edad= data.GetString(2);
                    elemento.sexo = data.GetString(3);
                    elemento.fecha = data.GetString(4);
                    elemento.hora = data.GetString(5);
                    informes.Add(elemento);
                }
            }
            return informes;
        }





    }
}
