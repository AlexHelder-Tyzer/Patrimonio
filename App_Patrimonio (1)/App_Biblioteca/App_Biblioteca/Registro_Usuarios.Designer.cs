namespace App_Biblioteca
{
    partial class Registro_Usuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.Confirmar = new System.Windows.Forms.TextBox();
            this.Registrar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Registro = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRAR USUARIOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "USUARIO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "CONTRASEÑA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "CONFIRMAR CONTRASEÑA:";
            // 
            // Usuario
            // 
            this.Usuario.Location = new System.Drawing.Point(312, 127);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(222, 20);
            this.Usuario.TabIndex = 4;
            this.Usuario.TextChanged += new System.EventHandler(this.Usuario_TextChanged);
            // 
            // Contraseña
            // 
            this.Contraseña.Location = new System.Drawing.Point(312, 171);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.PasswordChar = '*';
            this.Contraseña.Size = new System.Drawing.Size(222, 20);
            this.Contraseña.TabIndex = 5;
            this.Contraseña.TextChanged += new System.EventHandler(this.Contraseña_TextChanged);
            // 
            // Confirmar
            // 
            this.Confirmar.Location = new System.Drawing.Point(312, 216);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.PasswordChar = '*';
            this.Confirmar.Size = new System.Drawing.Size(222, 20);
            this.Confirmar.TabIndex = 6;
            // 
            // Registrar
            // 
            this.Registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Registrar.Location = new System.Drawing.Point(84, 254);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(89, 30);
            this.Registrar.TabIndex = 7;
            this.Registrar.Text = "REGISTRAR";
            this.Registrar.UseVisualStyleBackColor = false;
            this.Registrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Cancelar.Location = new System.Drawing.Point(245, 254);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(85, 30);
            this.Cancelar.TabIndex = 8;
            this.Cancelar.Text = "CANCELAR";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Registro
            // 
            this.Registro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Registro.Location = new System.Drawing.Point(412, 249);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(80, 40);
            this.Registro.TabIndex = 9;
            this.Registro.Text = "MOSTRAR REGISTRO";
            this.Registro.UseVisualStyleBackColor = false;
            this.Registro.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNuevo.Location = new System.Drawing.Point(216, 295);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(142, 34);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "NUEVO REGISTRO";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Registro_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(592, 341);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.Registro);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.Confirmar);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registro_Usuarios";
            this.Text = "Registro_Usuarios";
            this.Load += new System.EventHandler(this.Registro_Usuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.TextBox Contraseña;
        private System.Windows.Forms.TextBox Confirmar;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Registro;
        private System.Windows.Forms.Button btnNuevo;
    }
}