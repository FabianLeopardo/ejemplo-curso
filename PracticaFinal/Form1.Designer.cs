namespace PracticaFinal
{
    partial class PracticaFianl
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
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.txbEdad = new System.Windows.Forms.TextBox();
            this.lwDatosPersonales = new System.Windows.Forms.ListView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(33, 32);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(33, 63);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(33, 122);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(33, 91);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 8;
            this.lblEdad.Text = "Edad";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(33, 190);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(73, 13);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "RESULTADO";
            // 
            // txbApellido
            // 
            this.txbApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbApellido.Location = new System.Drawing.Point(104, 32);
            this.txbApellido.MaxLength = 35;
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(267, 20);
            this.txbApellido.TabIndex = 0;
            this.txbApellido.Enter += new System.EventHandler(this.txbApellido_Enter);
            this.txbApellido.Leave += new System.EventHandler(this.txbApellido_Leave);
            // 
            // txbNombre
            // 
            this.txbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre.Location = new System.Drawing.Point(104, 63);
            this.txbNombre.MaxLength = 35;
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(267, 20);
            this.txbNombre.TabIndex = 1;
            this.txbNombre.Enter += new System.EventHandler(this.txbNombre_Enter);
            this.txbNombre.Leave += new System.EventHandler(this.txbNombre_Leave);
            // 
            // txbDireccion
            // 
            this.txbDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDireccion.Location = new System.Drawing.Point(104, 122);
            this.txbDireccion.MaxLength = 35;
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(267, 20);
            this.txbDireccion.TabIndex = 3;
            this.txbDireccion.Enter += new System.EventHandler(this.txbDireccion_Enter);
            this.txbDireccion.Leave += new System.EventHandler(this.txbDireccion_Leave);
            // 
            // txbEdad
            // 
            this.txbEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEdad.Location = new System.Drawing.Point(104, 91);
            this.txbEdad.MaxLength = 3;
            this.txbEdad.Name = "txbEdad";
            this.txbEdad.Size = new System.Drawing.Size(38, 20);
            this.txbEdad.TabIndex = 2;
            this.txbEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbEdad.TextChanged += new System.EventHandler(this.txbEdad_TextChanged);
            this.txbEdad.Enter += new System.EventHandler(this.txbEdad_Enter);
            this.txbEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbEdad_KeyPress);
            this.txbEdad.Leave += new System.EventHandler(this.txbEdad_Leave);
            // 
            // lwDatosPersonales
            // 
            this.lwDatosPersonales.GridLines = true;
            this.lwDatosPersonales.HideSelection = false;
            this.lwDatosPersonales.LabelEdit = true;
            this.lwDatosPersonales.Location = new System.Drawing.Point(12, 225);
            this.lwDatosPersonales.Name = "lwDatosPersonales";
            this.lwDatosPersonales.Size = new System.Drawing.Size(533, 96);
            this.lwDatosPersonales.TabIndex = 11;
            this.lwDatosPersonales.UseCompatibleStateImageBehavior = false;
            this.lwDatosPersonales.View = System.Windows.Forms.View.SmallIcon;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(108, 341);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 25);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(273, 341);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 25);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelat";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // PracticaFianl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(573, 446);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lwDatosPersonales);
            this.Controls.Add(this.txbEdad);
            this.Controls.Add(this.txbDireccion);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbApellido);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PracticaFianl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Personales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.TextBox txbEdad;
        private System.Windows.Forms.ListView lwDatosPersonales;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}

