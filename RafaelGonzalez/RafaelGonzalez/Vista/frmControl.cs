using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RafaelGonzalez.Vista;

namespace RafaelGonzalez
{
    public partial class frmControl : Form
    {
        public frmControl()
        {
            InitializeComponent();
        }

      
        private DialogResult result;


        private void frmControl_Load(object sender, EventArgs e)
        {
            frmEstudiantes f = new frmEstudiantes();
            f.MdiParent = this;
            f.Show();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void estudiantesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            cerrarfrm();
            frmEstudiantes f = new frmEstudiantes();
            f.MdiParent = this;
            f.Show();


        }

        private void materiasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            cerrarfrm();
            frmMaterias f = new frmMaterias();
            f.MdiParent = this;
            f.Show();


        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            result = MessageBox.Show("¿Desea cerrar el programa?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);


            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarfrm();
            frmNotas f = new frmNotas();
            f.MdiParent = this;
            f.Show();
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void cerrarfrm()
        {
            frmEstudiantes fes = new frmEstudiantes();
            fes.Close();
            frmNotas fno = new frmNotas();
            fno.Close();
            frmMaterias fma = new frmMaterias();
            fma.Close();
        }
    }
}
