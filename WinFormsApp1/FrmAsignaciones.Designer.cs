
namespace Capa_Presentacion
{
    partial class FrmAsignaciones
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
            txtReparacionID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dgvAsignaciones = new DataGridView();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dtpFechaAsignacion = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvAsignaciones).BeginInit();
            SuspendLayout();
            // 
            // txtTecnicoID
            // 
            txtTecnicoID.Location = new Point(24, 114);
            txtTecnicoID.Name = "txtTecnicoID";
            txtTecnicoID.Size = new Size(125, 27);
            txtTecnicoID.TabIndex = 1;
            txtTecnicoID.TextChanged += txtTecnicoID_TextChanged;
            // 
            // txtReparacionID
            // 
            txtReparacionID.Location = new Point(24, 202);
            txtReparacionID.Name = "txtReparacionID";
            txtReparacionID.Size = new Size(125, 27);
            txtReparacionID.TabIndex = 2;
            txtReparacionID.TextChanged += txtReparacionID_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 91);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 5;
            label2.Text = "TecnicoID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 179);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 6;
            label3.Text = "ReparacionID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 264);
            label4.Name = "label4";
            label4.Size = new Size(145, 20);
            label4.TabIndex = 7;
            label4.Text = "Fecha de Asignación";
            // 
            // dgvAsignaciones
            // 
            dgvAsignaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsignaciones.Location = new Point(261, 12);
            dgvAsignaciones.Name = "dgvAsignaciones";
            dgvAsignaciones.RowHeadersWidth = 51;
            dgvAsignaciones.Size = new Size(616, 268);
            dgvAsignaciones.TabIndex = 8;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(371, 312);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(508, 312);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(644, 312);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(783, 312);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dtpFechaAsignacion
            // 
            dtpFechaAsignacion.Location = new Point(9, 324);
            dtpFechaAsignacion.Name = "dtpFechaAsignacion";
            dtpFechaAsignacion.Size = new Size(250, 27);
            dtpFechaAsignacion.TabIndex = 13;
            dtpFechaAsignacion.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // FrmAsignaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 520);
            Controls.Add(dtpFechaAsignacion);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvAsignaciones);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtReparacionID);
            Controls.Add(txtTecnicoID);
            Name = "FrmAsignaciones";
            Text = "FrmAsignaciones";
            ((System.ComponentModel.ISupportInitialize)dgvAsignaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtAsignacionID_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private TextBox txtTecnicoID;
        private TextBox txtReparacionID;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dgvAsignaciones;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DateTimePicker dtpFechaAsignacion;
    }
}