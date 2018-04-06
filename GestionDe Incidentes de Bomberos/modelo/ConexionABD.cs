using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionDe_Incidentes_de_Bomberos.modelo
{
    class ConexionABD
    {

        public static MySqlConnection conectar()
        {

                string source = "localhost";
                string port = "3306";
                string database = "bitacorabomberos";
                string usuario = "root";
                string password = "";
                try
                {
                    MySqlConnection conectar = new MySqlConnection(String.Format("server={0};port={1}; database={2}; Uid={3}; pwd={4};", source, port, database, usuario, password));
                    conectar.Open();

                    return conectar;
                }
                catch (Exception e)
                {
                    return null;
                }
            
        }

    }
}
