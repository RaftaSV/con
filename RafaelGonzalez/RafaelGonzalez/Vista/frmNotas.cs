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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();

        }
        notas n = new notas();
        string estud = "";
        string mat = "";
        DialogResult result;
        public void cargarDatos()
        {
            using (controlNotasEntities db = new controlNotasEntities())
            {
                var lista = from n in db.notas
                            from e in db.estudiantes
                            from m in db.materias
                            where e.id_Estudiante == n.id_Estudiante
                            where m.id_Materia == n.id_Materia
                            select new {ID= n.id_Nota,Estudiante= e.nombre,Materia = m.nombre_Materia, Nota= n.nota };
                dgvnotas.DataSource = lista.ToList();

            }

        }

        private void frmNotas_Load(object sender, EventArgs e)
        {
            cargarDatos();
            cargarCombo();
            desactivarEditar();


        }
        private void cmbEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            estud = cmbEstudiantes.SelectedValue.ToString();

        }

        private void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            mat = cmbMateria.SelectedValue.ToString();
        }

        public void cargarCombo()
        {
            using (controlNotasEntities db = new controlNotasEntities())
            {
                var estud = db.estudiantes.ToList();
                if (estud.Count > 0)
                {
                    cmbEstudiantes.DataSource = estud;
                    cmbEstudiantes.DisplayMember = "nombre";
                    cmbEstudiantes.ValueMember = "id_Estudiante";

                }
                var materias = db.materias.ToList();
                if (materias.Count > 0)
                {
                    cmbMateria.DataSource = materias;
                    cmbMateria.DisplayMember = "nombre_Materia";
                    cmbMateria.ValueMember = "id_Materia";

                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (controlNotasEntities db = new controlNotasEntities())
            {
                int es = int.Parse(estud);
                n.id_Estudiante = es;
                int mate = int.Parse(mat);
                n.id_Materia = mate;
                string nota = txtNota.Text;
                double N = double.Parse(nota);
                n.nota = N;
                db.notas.Add(n);
                db.SaveChanges();
                cargarDatos();

            }
        }

        public void desactivarEditar()
        {
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
        }

        public void desactivarGuardar()
        {
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;

        }

        private void dgvnotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            string nota = dgvnotas.CurrentRow.Cells[3].Value.ToString();

            txtNota.Text = nota;
            desactivarGuardar();
            cmbEstudiantes.Enabled = false;
            cmbMateria.Enabled = false;


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (controlNotasEntities db = new controlNotasEntities())
            {
                result = MessageBox.Show("¿Desea guardar los cambios?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    string id = dgvnotas.CurrentRow.Cells[0].Value.ToString();
                    int ID = int.Parse(id);
                    n = db.notas.Where(verificarId => verificarId.id_Nota == ID).First();
                    //int es = int.Parse(estud);
                    //n.id_Estudiante = es;
                    //int mate = int.Parse(mat);
                    //n.id_Materia = mate;
                    string nota = txtNota.Text;
                    double N = double.Parse(nota);
                    n.nota = N;
                    db.Entry(n).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    desactivarEditar();
                    cargarDatos();
                    cmbEstudiantes.Enabled = true;
                    cmbMateria.Enabled = true;
                    txtNota.Text = "";


                }
                else
                {
                    desactivarEditar();
                    txtNota.Text = "";
                    cmbEstudiantes.Enabled = true;
                    cmbMateria.Enabled = true;
                }

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (controlNotasEntities db = new controlNotasEntities())
            {
                result = MessageBox.Show("¿Desea eliminar este registro?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    string id = dgvnotas.CurrentRow.Cells[0].Value.ToString();
                    int ID = int.Parse(id);

                    n = db.notas.Find(ID);
                    db.notas.Remove(n);
                    db.SaveChanges();
                    cargarDatos();
                    txtNota.Text = "";
                    desactivarEditar();
                }
                else
                {
                    txtNota.Text = "";
                }
            }
        }

    }
}
