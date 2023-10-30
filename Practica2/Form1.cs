using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2
{
    public partial class FrmPratica2 : Form
    {
        public FrmPratica2()
        {
            InitializeComponent();
        }

        private void FrmPratica2_Load(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se disparo el evento Click");
            this.BackColor = Color.Red;

        }

        private void FrmPratica2_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            // if (click.Button == MouseButtons.Left)

            //   MessageBox.Show("Presiono el boton izquierdo");

            //  else if (click.Button == MouseButtons.Right)

            //    MessageBox.Show("Presiono el boton derecho");
            //else if (click.Button == MouseButtons.Middle)

            //  MessageBox.Show("Presiono el boton del medio");


            if (txbNombres.Text == "")
                txbNombres.BackColor = Color.Red;
            else
                txbNombres.BackColor= System.Drawing.SystemColors.Control;







        }

        private void lblNombres_MouseMove(object sender, MouseEventArgs e)
        {
            lblNombres.BackColor = Color.Cyan;
            lblNombres.Cursor = Cursors.Hand;

        }

        private void lblNombres_MouseLeave(object sender, EventArgs e)
        {
            lblNombres.BackColor= System.Drawing.SystemColors.Window;
            lblNombres.Cursor = Cursors.Arrow;

        }

        private void txbNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;

        }

        private void txbNombrer_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txbNombrer.Text.Length + " Caracteres");

        }

        private void txbNombres_MouseMove(object sender, MouseEventArgs e)
        {
            txbNombres.BackColor = Color.Cyan;
        }

        private void txbNombres_MouseLeave(object sender, EventArgs e)
        {
            txbNombres.BackColor = System.Drawing.SystemColors.Control;
        }

        private void txbNombres_Enter(object sender, EventArgs e)
        {
            txbNombres.BackColor = Color.Cyan;
        }

        private void txbNombres_Leave(object sender, EventArgs e)
        {
            txbNombres.BackColor = System.Drawing.SystemColors.Control;
        }
    }
}
