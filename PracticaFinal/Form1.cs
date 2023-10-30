using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaFinal
{
    public partial class PracticaFianl : Form
    {
        public PracticaFianl()
        {
            InitializeComponent();
        }

        private void txbApellido_Enter(object sender, EventArgs e)
        {
            txbApellido.BackColor = Color.Cyan;
           
        }

        private void txbApellido_Leave(object sender, EventArgs e)
        {
            if (txbApellido.Text == "")
                txbApellido.Focus();
            txbApellido.BackColor = System.Drawing.SystemColors.Control;
        }

        private void txbNombre_Enter(object sender, EventArgs e)
        {
            txbNombre.BackColor = Color.Cyan;
        }

        private void txbNombre_Leave(object sender, EventArgs e)
        {
            if (txbNombre.Text == "")
                txbNombre.Focus();
            txbNombre.BackColor = System.Drawing.SystemColors.Control;
        }

        private void txbEdad_Enter(object sender, EventArgs e)
        {
            txbEdad.BackColor = Color.Cyan;
        }

        private void txbEdad_Leave(object sender, EventArgs e)
        {
            if (txbEdad.Text == "")
                txbEdad.Focus();
            txbEdad.BackColor = System.Drawing.SystemColors.Control;
        }

        private void txbDireccion_Enter(object sender, EventArgs e)
        {
            txbDireccion.BackColor = Color.Cyan;
        }

        private void txbDireccion_Leave(object sender, EventArgs e)
        {
            if (txbDireccion.Text == "")
                txbDireccion.Focus();
            txbDireccion.BackColor = System.Drawing.SystemColors.Control;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //String datospersonales = txbApellido.Text + " " + txbNombre.Text + " " + txbEdad.Text + txbDireccion.Text;       + " " +  txbDireccion.Text;
            
            lwDatosPersonales.Items.Add(txbApellido.Text);
            lwDatosPersonales.Items.Add(txbNombre.Text);
            lwDatosPersonales.Items.Add(txbEdad.Text);
            lwDatosPersonales.Items.Add(txbDireccion.Text);
            txbApellido.Text = string.Empty;
            txbEdad.Text = string.Empty;
            txbNombre.Text = string.Empty;
            txbDireccion.Text = string.Empty;
            txbApellido.Focus();

        }

        private void txbEdad_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txbEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txbApellido.Text = string.Empty;
            txbEdad.Text = string.Empty;
            txbNombre.Text = string.Empty;
            txbDireccion.Text = string.Empty;
            txbApellido.Focus();
                
        }
    }
}
