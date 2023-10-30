using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class PrimeraApp : Form
    {
        public PrimeraApp()
        {
            InitializeComponent();
        }

        private void PrimeraApp_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C# ");

        }

       
        private void PrimeraApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Chau Chau ....");
        }
    }

}
