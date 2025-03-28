namespace Capa_Presentacion
{
    partial class FrmDetallesReparacion
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
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvDetalles = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtDetalleID = new TextBox();
            txtReparacionID = new TextBox();
            txtDescripcion = new TextBox();
            txtFechaInicio = new TextBox();
            label5 = new Label();
            txtFechaFin = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(209, 446);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(376, 446);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(559, 446);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(742, 446);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvDetalles
            // 
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Location = new Point(209, 37);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.RowHeadersWidth = 51;
            dgvDetalles.Size = new Size(920, 320);
            dgvDetalles.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 5;
            label1.Text = "Detalles de la reparacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 117);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 6;
            label2.Text = "ReparacionID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 205);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 285);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 8;
            label4.Text = "Fecha de inicio";
            // 
            // txtDetalleID
            // 
            txtDetalleID.Location = new Point(17, 70);
            txtDetalleID.Name = "txtDetalleID";
            txtDetalleID.Size = new Size(125, 27);
            txtDetalleID.TabIndex = 9;
            // 
            // txtReparacionID
            // 
            txtReparacionID.Location = new Point(16, 154);
            txtReparacionID.Name = "txtReparacionID";
            txtReparacionID.Size = new Size(125, 27);
            txtReparacionID.TabIndex = 10;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(12, 239);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(125, 27);
            txtDescripcion.TabIndex = 11;
            // 
            // txtFechaInicio
            // 
            txtFechaInicio.Location = new Point(17, 320);
            txtFechaInicio.Name = "txtFechaInicio";
            txtFechaInicio.Size = new Size(125, 27);
            txtFechaInicio.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 364);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 13;
            label5.Text = "Fecha de Fin";
            // 
            // txtFechaFin
            // 
            txtFechaFin.Location = new Point(19, 389);
            txtFechaFin.Name = "txtFechaFin";
            txtFechaFin.Size = new Size(125, 27);
            txtFechaFin.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 205);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 15;
            label6.Text = "Descripción";
            // 
            // FrmDetallesReparacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 587);
            Controls.Add(label6);
            Controls.Add(txtFechaFin);
            Controls.Add(label5);
            Controls.Add(txtFechaInicio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtReparacionID);
            Controls.Add(txtDetalleID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvDetalles);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Name = "FrmDetallesReparacion";
            Text = "FrmDetallesReparacion";
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvDetalles;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDetalleID;
        private TextBox txtReparacionID;
        private TextBox txtDescripcion;
        private TextBox txtFechaInicio;
        private Label label5;
        private TextBox txtFechaFin;
        private Label label6;
    }
}