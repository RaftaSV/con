using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RafaelGonzalez.Model;

namespace RafaelGonzalez
{
    public partial class frmLoggeo : Form
    {
        public frmLoggeo()
        {
            InitializeComponent();
            txtContraseña.PasswordChar= '*';
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            using (controlNotasEntities db = new controlNotasEntities())
            {
                var lista = from estudiante in db.estudiantes
                            where estudiante.usuario == txtUsuario.Text
                            && estudiante.contraseña == txtContraseña.Text
                            select estudiante;
                if (lista.Count () > 0)
                {
                    frmControl f = new frmControl();
                    f.ShowDialog();

                }
                else
                {

                    MessageBox.Show("Usuario o Contraseña no existe");
                }

            }

        }
    }
}
