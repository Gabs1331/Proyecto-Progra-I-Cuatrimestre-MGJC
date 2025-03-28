namespace Capa_Presentacion
{
    partial class FrmReparaciones
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtReparacionID = new TextBox();
            txtEquipoID = new TextBox();
            txtFechaSolicitud = new TextBox();
            txtEstado = new TextBox();
            dgvReparaciones = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReparaciones).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(220, 350);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(353, 350);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(491, 350);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(637, 350);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 36);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 4;
            label1.Text = "ReparacionID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 105);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 5;
            label2.Text = "EquipoID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 178);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 6;
            label3.Text = "Fecha de Solicitud";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 252);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 7;
            label4.Text = "Estado";
            // 
            // txtReparacionID
            // 
            txtReparacionID.Location = new Point(26, 59);
            txtReparacionID.Name = "txtReparacionID";
            txtReparacionID.Size = new Size(125, 27);
            txtReparacionID.TabIndex = 8;
            txtReparacionID.TextChanged += txtReparacionID_TextChanged;
            // 
            // txtEquipoID
            // 
            txtEquipoID.Location = new Point(26, 128);
            txtEquipoID.Name = "txtEquipoID";
            txtEquipoID.Size = new Size(125, 27);
            txtEquipoID.TabIndex = 9;
            txtEquipoID.TextChanged += txtEquipoID_TextChanged;
            // 
            // txtFechaSolicitud
            // 
            txtFechaSolicitud.Location = new Point(26, 201);
            txtFechaSolicitud.Name = "txtFechaSolicitud";
            txtFechaSolicitud.Size = new Size(125, 27);
            txtFechaSolicitud.TabIndex = 10;
            txtFechaSolicitud.TextChanged += txtFechaSolicitud_TextChanged;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(26, 275);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(125, 27);
            txtEstado.TabIndex = 11;
            txtEstado.TextChanged += txtEstado_TextChanged;
            // 
            // dgvReparaciones
            // 
            dgvReparaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReparaciones.Location = new Point(220, 40);
            dgvReparaciones.Name = "dgvReparaciones";
            dgvReparaciones.RowHeadersWidth = 51;
            dgvReparaciones.Size = new Size(544, 262);
            dgvReparaciones.TabIndex = 12;
            dgvReparaciones.CellContentClick += dgvReparaciones_CellContentClick;
            // 
            // FrmReparaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvReparaciones);
            Controls.Add(txtEstado);
            Controls.Add(txtFechaSolicitud);
            Controls.Add(txtEquipoID);
            Controls.Add(txtReparacionID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Name = "FrmReparaciones";
            Text = "FrmReparaciones";
            Load += FrmReparaciones_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvReparaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtReparacionID;
        private TextBox txtEquipoID;
        private TextBox txtFechaSolicitud;
        private TextBox txtEstado;
        private DataGridView dgvReparaciones;
    }
}