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

        private Form activeForm = null;
        private DialogResult result;

        public void MostrarPanel(Form Panel)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = Panel;
            Panel.TopLevel = false;
            Panel.FormBorderStyle = FormBorderStyle.None;
            Panel.Dock = DockStyle.Fill;
            pnlPrincipal.Controls.Add(Panel);
            pnlPrincipal.Tag = Panel;
            Panel.BringToFront();
            Panel.Show();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarPanel(new frmEstudiantes());
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarPanel(new frmMaterias());
        }

        private void frmControl_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
           result = MessageBox.Show("¿Desea cerrar el programa?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
           

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
