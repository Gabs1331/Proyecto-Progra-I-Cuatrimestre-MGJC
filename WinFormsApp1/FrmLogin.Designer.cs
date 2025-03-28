
namespace Capa_Presentacion
{
    partial class FrmLogin
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
            btnIngresar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUsuarioID = new TextBox();
            txtContraseña = new TextBox();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(66, 265);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(94, 29);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 44);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 3;
            label1.Text = "UsuarioID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 144);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // txtUsuarioID
            // 
            txtUsuarioID.Location = new Point(62, 91);
            txtUsuarioID.Name = "txtUsuarioID";
            txtUsuarioID.Size = new Size(125, 27);
            txtUsuarioID.TabIndex = 5;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(57, 182);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(125, 27);
            txtContraseña.TabIndex = 6;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuarioID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnIngresar);
            Name = "FrmLogin";
            Text = "FrmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtUsuarioID_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Button btnIngresar;
        private Label label1;
        private Label label2;
        private TextBox txtUsuarioID;
        private TextBox txtContraseña;
    }
}