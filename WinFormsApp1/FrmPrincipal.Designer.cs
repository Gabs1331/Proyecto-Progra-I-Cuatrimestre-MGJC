namespace Capa_Presentacion
{
    partial class FrmPrincipal
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
            btnUsuarios = new Button();
            btnTecnicos = new Button();
            btnEquipos = new Button();
            btnCerrarSesion = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            BtnAsignaciones = new Button();
            BtnReparaciones = new Button();
            btnDetallesReparacion = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(3, 3);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(121, 30);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnTecnicos
            // 
            btnTecnicos.Location = new Point(168, 3);
            btnTecnicos.Name = "btnTecnicos";
            btnTecnicos.Size = new Size(121, 35);
            btnTecnicos.TabIndex = 2;
            btnTecnicos.Text = "Tecnicos";
            btnTecnicos.UseVisualStyleBackColor = true;
            btnTecnicos.Click += btnTecnicos_Click;
            // 
            // btnEquipos
            // 
            btnEquipos.Location = new Point(3, 109);
            btnEquipos.Name = "btnEquipos";
            btnEquipos.Size = new Size(121, 36);
            btnEquipos.TabIndex = 3;
            btnEquipos.Text = "Equipos";
            btnEquipos.UseVisualStyleBackColor = true;
            btnEquipos.Click += btnEquipos_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(26, 402);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(121, 36);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnSalir_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnUsuarios, 0, 0);
            tableLayoutPanel1.Controls.Add(btnTecnicos, 1, 0);
            tableLayoutPanel1.Controls.Add(btnEquipos, 0, 1);
            tableLayoutPanel1.Controls.Add(BtnAsignaciones, 1, 1);
            tableLayoutPanel1.Controls.Add(BtnReparaciones, 0, 2);
            tableLayoutPanel1.Controls.Add(btnDetallesReparacion, 1, 2);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 102F));
            tableLayoutPanel1.Size = new Size(331, 314);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // BtnAsignaciones
            // 
            BtnAsignaciones.ImageAlign = ContentAlignment.BottomCenter;
            BtnAsignaciones.Location = new Point(168, 109);
            BtnAsignaciones.Name = "BtnAsignaciones";
            BtnAsignaciones.Size = new Size(121, 29);
            BtnAsignaciones.TabIndex = 4;
            BtnAsignaciones.Text = "Asignaciones";
            BtnAsignaciones.UseVisualStyleBackColor = true;
            BtnAsignaciones.Click += btnAsignaciones_Click;
            // 
            // BtnReparaciones
            // 
            BtnReparaciones.Location = new Point(3, 215);
            BtnReparaciones.Name = "BtnReparaciones";
            BtnReparaciones.Size = new Size(121, 34);
            BtnReparaciones.TabIndex = 5;
            BtnReparaciones.Text = "Reparaciones";
            BtnReparaciones.UseVisualStyleBackColor = true;
            BtnReparaciones.Click += btnReparaciones_Click;
            // 
            // btnDetallesReparacion
            // 
            btnDetallesReparacion.Location = new Point(168, 215);
            btnDetallesReparacion.Name = "btnDetallesReparacion";
            btnDetallesReparacion.Size = new Size(94, 29);
            btnDetallesReparacion.TabIndex = 6;
            btnDetallesReparacion.Text = "Detalles Reparacion";
            btnDetallesReparacion.UseVisualStyleBackColor = true;
            btnDetallesReparacion.Click += btnDetallesReparacion_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 449);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnCerrarSesion);
            IsMdiContainer = true;
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnUsuarios;
        private Button btnTecnicos;
        private Button btnEquipos;
        private Button btnCerrarSesion;
        private TableLayoutPanel tableLayoutPanel1;
        private Button BtnAsignaciones;
        private Button BtnReparaciones;
        private Button btnDetallesReparacion;
    }
}