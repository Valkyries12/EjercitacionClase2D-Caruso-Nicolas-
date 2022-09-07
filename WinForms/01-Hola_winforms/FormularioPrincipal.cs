using System.Text;

namespace _01_Hola_winforms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.cboMaterias.SelectedIndex = 0;
            
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {

            string nombre = this.txtNombre.Text;
            string apellido = this.txtApellido.Text;

            if (String.IsNullOrWhiteSpace(nombre) || String.IsNullOrWhiteSpace(apellido))
            {
                StringBuilder sbMensaje = new StringBuilder("Se deben completas los siguientes campos:\n");
                
                if (String.IsNullOrWhiteSpace(nombre) && String.IsNullOrWhiteSpace(apellido))
                {
                    sbMensaje.Append("Nombre\nApellido");
                }
                else if (String.IsNullOrWhiteSpace(nombre))
                {
                    sbMensaje.Append("Nombre");
                }
                else
                {
                    sbMensaje.Append("Apellido");
                }

                MessageBox.Show(sbMensaje.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string materiaFavorita = this.cboMaterias.Text;
            frmSaludar formularioSaludar = new frmSaludar("¡Hola, Windows Forms!", $"Soy {nombre} {apellido} y mi materia favorita es {materiaFavorita}");
            formularioSaludar.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}