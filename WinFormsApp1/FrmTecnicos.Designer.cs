namespace Capa_Presentacion
{
    partial class FrmTecnicos
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
            txtTecnicoID = new TextBox();
            txtNombre = new TextBox();
            txtEspecialidad = new TextBox();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvTecnicos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTecnicos).BeginInit();
            SuspendLayout();
            // 
            // txtTecnicoID
            // 
            txtTecnicoID.Location = new Point(39, 40);
            txtTecnicoID.Name = "txtTecnicoID";
            txtTecnicoID.Size = new Size(125, 27);
            txtTecnicoID.TabIndex = 0;
            txtTecnicoID.TextChanged += txtTecnicoID_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(39, 148);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(39, 251);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(125, 27);
            txtEspecialidad.TabIndex = 2;
            txtEspecialidad.TextChanged += txtEspecialidad_TextChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(214, 343);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(339, 343);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(469, 343);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(597, 343);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvTecnicos
            // 
            dgvTecnicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTecnicos.Location = new Point(214, 40);
            dgvTecnicos.Name = "dgvTecnicos";
            dgvTecnicos.RowHeadersWidth = 51;
            dgvTecnicos.Size = new Size(505, 238);
            dgvTecnicos.TabIndex = 7;
            dgvTecnicos.CellContentClick += dgvTecnicos_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 17);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 8;
            label1.Text = "TecnicoID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 125);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 9;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 228);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 10;
            label3.Text = "Especialidad";
            // 
            // FrmTecnicos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvTecnicos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(txtEspecialidad);
            Controls.Add(txtNombre);
            Controls.Add(txtTecnicoID);
            Name = "FrmTecnicos";
            Text = "FrmTecnicos";
            ((System.ComponentModel.ISupportInitialize)dgvTecnicos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTecnicoID;
        private TextBox txtNombre;
        private TextBox txtEspecialidad;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvTecnicos;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}