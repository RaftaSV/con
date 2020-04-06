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
    public partial class frmMaterias : Form
    {
        public frmMaterias()
        {
            InitializeComponent();
        }
        materias ma = new materias();
        DialogResult result;
        private void frmMaterias_Load(object sender, EventArgs e)
        {
            Cargardatos();
            desactivarEditar();
        }
        public void Cargardatos() {
            using (controlNotasEntities db = new controlNotasEntities()) {
                var lista = from m in db.materias
                            select new {ID= m.id_Materia, Materia= m.nombre_Materia };
                dgvMaterias.DataSource = lista.ToList();

            }



        }
        public void limpiar()
        {
            txtMateria.Text = "";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (controlNotasEntities db = new controlNotasEntities()) {

                ma.nombre_Materia = txtMateria.Text;
                db.materias.Add(ma);
                db.SaveChanges();
                limpiar();
                Cargardatos();


            }

        }

        private void dgvMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string Materia = dgvMaterias.CurrentRow.Cells[1].Value.ToString();
            txtMateria.Text = Materia;

            desactivarGuardar();

        }

        public void desactivarEditar (){
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

        private void btnEditar_Click(object sender, EventArgs e)

        {
            result = MessageBox.Show("¿Desea guardar los cambios?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);


            if (result == DialogResult.Yes)
            {

                using (controlNotasEntities db = new controlNotasEntities())
                {

                    string ID = dgvMaterias.CurrentRow.Cells[0].Value.ToString();
                    int id = int.Parse(ID);
                    ma = db.materias.Where(verificarId => verificarId.id_Materia == id).First();
                    ma.nombre_Materia = txtMateria.Text;
                    db.Entry(ma).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    desactivarEditar();
                    Cargardatos();
                    limpiar();


                }
            }
            else
            {
                desactivarEditar();
                Cargardatos();
                limpiar();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            result = MessageBox.Show("¿Desea eliminar este registro?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                using (controlNotasEntities db = new controlNotasEntities())
                {
                    string ID = dgvMaterias.CurrentRow.Cells[0].Value.ToString();
                    int id = int.Parse(ID);
                    ma = db.materias.Find(id);
                    db.materias.Remove(ma);
                    db.SaveChanges();
                    limpiar();
                    Cargardatos();
                    desactivarEditar();

                }
            }
            else
            {
                limpiar();
                Cargardatos();
                desactivarEditar();
            }
            

        }
    }
}
