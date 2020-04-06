namespace RafaelGonzalez.Vista
{
    partial class frmNotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvnotas = new System.Windows.Forms.DataGridView();
            this.cmbEstudiantes = new System.Windows.Forms.ComboBox();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lblEstudiantes = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnotas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(694, 117);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 37);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(383, 117);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(157, 37);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Actualizar nota";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(60, 117);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 37);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvnotas
            // 
            this.dgvnotas.AllowUserToAddRows = false;
            this.dgvnotas.AllowUserToDeleteRows = false;
            this.dgvnotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvnotas.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvnotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnotas.Location = new System.Drawing.Point(3, 162);
            this.dgvnotas.Name = "dgvnotas";
            this.dgvnotas.ReadOnly = true;
            this.dgvnotas.Size = new System.Drawing.Size(911, 293);
            this.dgvnotas.TabIndex = 18;
            this.dgvnotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnotas_CellContentClick);
            // 
            // cmbEstudiantes
            // 
            this.cmbEstudiantes.BackColor = System.Drawing.SystemColors.Control;
            this.cmbEstudiantes.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbEstudiantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEstudiantes.FormattingEnabled = true;
            this.cmbEstudiantes.Location = new System.Drawing.Point(138, 55);
            this.cmbEstudiantes.Name = "cmbEstudiantes";
            this.cmbEstudiantes.Size = new System.Drawing.Size(161, 28);
            this.cmbEstudiantes.TabIndex = 19;
            this.cmbEstudiantes.SelectedIndexChanged += new System.EventHandler(this.cmbEstudiantes_SelectedIndexChanged);
            // 
            // cmbMateria
            // 
            this.cmbMateria.BackColor = System.Drawing.SystemColors.Control;
            this.cmbMateria.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(383, 55);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(157, 28);
            this.cmbMateria.TabIndex = 20;
            this.cmbMateria.SelectedIndexChanged += new System.EventHandler(this.cmbMateria_SelectedIndexChanged);
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(628, 55);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(156, 28);
            this.txtNota.TabIndex = 21;
            // 
            // lblEstudiantes
            // 
            this.lblEstudiantes.AutoSize = true;
            this.lblEstudiantes.Location = new System.Drawing.Point(175, 32);
            this.lblEstudiantes.Name = "lblEstudiantes";
            this.lblEstudiantes.Size = new System.Drawing.Size(86, 20);
            this.lblEstudiantes.TabIndex = 22;
            this.lblEstudiantes.Text = "Estudiante";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(690, 32);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(43, 20);
            this.lblNota.TabIndex = 23;
            this.lblNota.Text = "Nota";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(415, 32);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(62, 20);
            this.lblMateria.TabIndex = 24;
            this.lblMateria.Text = "Materia";
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(917, 491);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.lblEstudiantes);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.cmbEstudiantes);
            this.Controls.Add(this.dgvnotas);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNotas";
            this.Text = "frmNotas";
            this.Load += new System.EventHandler(this.frmNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvnotas;
        private System.Windows.Forms.ComboBox cmbEstudiantes;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label lblEstudiantes;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label lblMateria;
    }
}