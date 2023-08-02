using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGINGONZLAERZ
{
    public partial class frmLogin : Form
    {
        int errores = 2;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Adm" && txtContraseña.Text == "@1a" && (cboModulo.Text == "ADM" || cboModulo.Text == "COM" || cboModulo.Text == "VTA") || txtUsuario.Text == "John" && txtContraseña.Text == "*2b" && cboModulo.Text == "SIST" || txtUsuario.Text == "Ceci" && txtContraseña.Text == "*@3c" && (cboModulo.Text == "ADM" || cboModulo.Text == "VTA") || txtUsuario.Text == "God" && txtContraseña.Text == "*@#4d" && (cboModulo.Text == "ADM" || cboModulo.Text == "SIST" || cboModulo.Text == "COM" || cboModulo.Text == "VTA"))
            {
                Form Bienvenido = new frmBienvenido();
                this.Hide();
                Bienvenido.Show();

            }
            else
            {
                MessageBox.Show("Datos ingresados invalidos");
                txtUsuario.Clear();
                txtContraseña.Clear();
                errores++;
            }
            if (errores == 2) ;
            MessageBox.Show("Demasiados intentos, el formulario se cerrara.");
            this.Close();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
