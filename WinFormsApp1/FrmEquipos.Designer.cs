namespace Capa_Presentacion
{
    partial class FrmEquipos
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
            txtEquipoID = new TextBox();
            txtDescripcion = new TextBox();
            txtModelo = new TextBox();
            txtUsuarioID = new TextBox();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvEquipos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).BeginInit();
            SuspendLayout();
            // 
            // txtEquipoID
            // 
            txtEquipoID.Location = new Point(36, 66);
            txtEquipoID.Name = "txtEquipoID";
            txtEquipoID.Size = new Size(125, 27);
            txtEquipoID.TabIndex = 0;
            txtEquipoID.TextChanged += txtEquipoID_TextChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(36, 135);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(125, 27);
            txtDescripcion.TabIndex = 1;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(36, 210);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(125, 27);
            txtModelo.TabIndex = 2;
            txtModelo.TextChanged += txtModelo_TextChanged;
            // 
            // txtUsuarioID
            // 
            txtUsuarioID.Location = new Point(36, 281);
            txtUsuarioID.Name = "txtUsuarioID";
            txtUsuarioID.Size = new Size(125, 27);
            txtUsuarioID.TabIndex = 3;
            txtUsuarioID.TextChanged += txtUsuarioID_TextChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(212, 346);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(350, 346);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(487, 346);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(622, 346);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvEquipos
            // 
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.Location = new Point(212, 66);
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.RowHeadersWidth = 51;
            dgvEquipos.Size = new Size(576, 242);
            dgvEquipos.TabIndex = 8;
            dgvEquipos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 43);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 9;
            label1.Text = "EquipoID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 112);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 10;
            label2.Text = "Tipo de equipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 187);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 11;
            label3.Text = "Modelo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 258);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 12;
            label4.Text = "UsuarioID";
            // 
            // FrmEquipos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvEquipos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(txtUsuarioID);
            Controls.Add(txtModelo);
            Controls.Add(txtDescripcion);
            Controls.Add(txtEquipoID);
            Name = "FrmEquipos";
            Text = "FrmEquipos";
            Load += FrmEquipos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEquipoID;
        private TextBox txtDescripcion;
        private TextBox txtModelo;
        private TextBox txtUsuarioID;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvEquipos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}