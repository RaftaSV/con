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

        private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private Form activeForm = null;
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
    }
}
