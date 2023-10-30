namespace Practica1
{
    partial class PrimeraApp
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
            this.SuspendLayout();
            // 
            // PrimeraApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(744, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(579, 489);
            this.Name = "PrimeraApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practica 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrimeraApp_FormClosing);
            this.Load += new System.EventHandler(this.PrimeraApp_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

