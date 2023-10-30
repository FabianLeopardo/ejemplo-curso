namespace Practica2
{
    partial class FrmPratica2
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
            this.btnRun = new System.Windows.Forms.Button();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txbNombres = new System.Windows.Forms.TextBox();
            this.txbNombrer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Image = global::Practica2.Properties.Resources.icons8_verificar_48;
            this.btnRun.Location = new System.Drawing.Point(122, 283);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(116, 61);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "RUN";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombres.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(57, 47);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(58, 18);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombre";
            this.lblNombres.MouseLeave += new System.EventHandler(this.lblNombres_MouseLeave);
            this.lblNombres.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblNombres_MouseMove);
            // 
            // txbNombres
            // 
            this.txbNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbNombres.Location = new System.Drawing.Point(147, 47);
            this.txbNombres.MaxLength = 25;
            this.txbNombres.Name = "txbNombres";
            this.txbNombres.Size = new System.Drawing.Size(171, 20);
            this.txbNombres.TabIndex = 2;
            this.txbNombres.Enter += new System.EventHandler(this.txbNombres_Enter);
            this.txbNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNombres_KeyPress);
            this.txbNombres.Leave += new System.EventHandler(this.txbNombres_Leave);
            this.txbNombres.MouseLeave += new System.EventHandler(this.txbNombres_MouseLeave);
            this.txbNombres.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txbNombres_MouseMove);
            // 
            // txbNombrer
            // 
            this.txbNombrer.Location = new System.Drawing.Point(147, 100);
            this.txbNombrer.Multiline = true;
            this.txbNombrer.Name = "txbNombrer";
            this.txbNombrer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbNombrer.Size = new System.Drawing.Size(171, 20);
            this.txbNombrer.TabIndex = 3;
            this.txbNombrer.Leave += new System.EventHandler(this.txbNombrer_Leave);
            // 
            // FrmPratica2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbNombrer);
            this.Controls.Add(this.txbNombres);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.btnRun);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPratica2";
            this.Text = "Practica 2";
            this.Load += new System.EventHandler(this.FrmPratica2_Load);
            this.Click += new System.EventHandler(this.FrmPratica2_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txbNombres;
        private System.Windows.Forms.TextBox txbNombrer;
    }
}

