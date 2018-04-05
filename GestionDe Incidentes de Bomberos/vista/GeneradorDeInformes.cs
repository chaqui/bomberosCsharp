using GestionDe_Incidentes_de_Bomberos.informes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDe_Incidentes_de_Bomberos.vista
{
    public partial class GeneradorDeInformes : Form
    {
        public GeneradorDeInformes()
        {
            InitializeComponent();
        }

        private void cbTipoIncidente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btGenerarInfome_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = Convert.ToDateTime(monthFechaIncialIncidente.SelectionEnd.ToShortDateString());
            DateTime fechaFinal = Convert.ToDateTime(monthFechaFinalIncidente.SelectionEnd.ToShortDateString());
            Accidente accidente = new Accidente();
            accidente.crearInforme(1, fechaInicio, fechaFinal);
        }
    }
}
