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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Main f2 = new Main(true);
            f2.Show();
            this.Hide();
            BaseDatos db = new BaseDatos();
            DataTable datos = db.RetornarTabla("select nombre from usuario where usuario = '" + textUsuario.Text.Trim() + "' and password = '" + textPassword.Text.Trim() + "'");
            bool es_usuario = false;
            if (datos != null)
            {
                if (datos.Rows.Count > 0)
                {
                    es_usuario = true;
                    MessageBox.Show("Bienvenido " + datos.Rows[0]["nombre"].ToString());
                    bool esAdmin = datos.Rows[0]["nombre"].ToString() == "admin";
                    Main f1 = new Main(esAdmin);
                    f1.Show();
                    this.Hide();
                }
            }
            if (!es_usuario)
            {
                MessageBox.Show("el usuario o la contraseña no son correctos");
            }
        }
    }
}
