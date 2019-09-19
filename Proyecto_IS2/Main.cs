using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_IS2
{
    public partial class Main : Form
    {
        public Main(bool esAdmin)
        {
            InitializeComponent();
            OcultarMenuPerfil(esAdmin);
        }

        private void OcultarMenuPerfil(bool esAdmin)
        {
            administrarFlotasToolStripMenuItem.Visible = esAdmin;
            gestionarUsuariosToolStripMenuItem.Visible = esAdmin;
            gestionarLavaderoToolStripMenuItem.Visible = esAdmin;
            generarReporteToolStripMenuItem.Visible = !esAdmin;
            operarLavaderoToolStripMenuItem.Visible = !esAdmin;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

    }
}
