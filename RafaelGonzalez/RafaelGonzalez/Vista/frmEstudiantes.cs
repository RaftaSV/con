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

namespace RafaelGonzalez.Vista
{
    public partial class frmEstudiantes : Form
    {
        public frmEstudiantes()
        {
            InitializeComponent();
        }
        estudiantes est = new estudiantes();
        private void frmEstudiantes_Load(object sender, EventArgs e)
        {
            cargardatos();

        }
        public void cargardatos()
        {
            using (controlNotasEntities db = new controlNotasEntities())
            {
                var lista = from es in db.estudiantes
                            select new { es.id_Estudiante, es.nombre, es.apellido, es.usuario, es.contraseña };

                dgvEstudiantes.DataSource = lista.ToList();
                
            }
        }

        public void limpiar()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtUsuario.Text = "";
            txtContraseña.Text = "";



        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (controlNotasEntities db = new controlNotasEntities())
            {
                est.nombre = txtNombres.Text;
                est.apellido = txtApellidos.Text;
                est.usuario = txtUsuario.Text;
                est.contraseña = txtContraseña.Text;

                db.estudiantes.Add(est);
                db.SaveChanges();
                cargardatos();
                limpiar();


            }

        }

        private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombre = dgvEstudiantes.CurrentRow.Cells[1].Value.ToString();
            string apellido = dgvEstudiantes.CurrentRow.Cells[2].Value.ToString();
            string usuario = dgvEstudiantes.CurrentRow.Cells[3].Value.ToString();
            string contra = dgvEstudiantes.CurrentRow.Cells[4].Value.ToString();

            txtNombres.Text = nombre;
            txtApellidos.Text = apellido;
            txtUsuario.Text = usuario;
            txtContraseña.Text = contra;
            btnGuardar.Enabled = false;
            

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text=="") { } else {
                using (controlNotasEntities db = new controlNotasEntities())
                {
                    string id = dgvEstudiantes.CurrentRow.Cells[0].Value.ToString();
                    int ID = int.Parse(id);
                    est = db.estudiantes.Where(verificarId => verificarId.id_Estudiante == ID).First();
                    est.nombre = txtNombres.Text;
                    est.apellido = txtApellidos.Text;
                    est.usuario = txtUsuario.Text;
                    est.contraseña = txtContraseña.Text;
                    db.Entry(est).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    cargardatos();
                    limpiar();
                    btnGuardar.Enabled = true;
                }

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (controlNotasEntities db = new controlNotasEntities())
            {
                string id = dgvEstudiantes.CurrentRow.Cells[0].Value.ToString();
                int ID = int.Parse(id);
                est = db.estudiantes.Find(ID);
                db.estudiantes.Remove(est);
                db.SaveChanges();
                cargardatos();
                limpiar();
                btnGuardar.Enabled = true;
            }

        }
    }
}
