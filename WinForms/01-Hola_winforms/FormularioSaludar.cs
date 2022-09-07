using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Hola_winforms
{
    public partial class frmSaludar : Form
    {
        public frmSaludar(string titulo, string mensaje)
        {
            InitializeComponent();
            StringBuilder sb = new StringBuilder($"{titulo}\n\n");
            this.lblTitulo.Text = sb.ToString();
            sb.Clear();
            sb.Append(mensaje);
            this.lblMensaje.Text = sb.ToString();
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
