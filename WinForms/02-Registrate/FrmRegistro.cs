using biblioteca_de_clases;
using System.ComponentModel;

namespace _02_Registrate
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = this.lblNombre.Text;
            string direccion = this.lblDireccion.Text;
            int edad = (int)this.nmdDireccion.Value;
            string genero = VerificarCheckedGenero();
            List<string> cursos = new List<string>();
            VerificarCheckedCursos(cursos);
            string pais = this.lstPais.Text;

            Ingresante ingresante = new Ingresante(cursos,direccion,edad,genero,nombre,pais);

            MessageBox.Show(ingresante.Mostrar());
           
        }

        private string VerificarCheckedGenero()
        {
            string genero = "";
            if (this.radGeneroMasculino.Checked)
            {
                genero = this.radGeneroMasculino.Text;
            }
            else if (this.radGeneroFemenino.Checked)
            {
                genero = this.radGeneroFemenino.Text;
            }
            else if (this.radGeneroNoBinario.Checked)
            {
                genero = this.radGeneroNoBinario.Text;
            }

            return genero;
        }

        private void VerificarCheckedCursos(List<string>cursos)
        {
            if (this.chkCursoC.Checked)
            {
                cursos.Add(this.chkCursoC.Text);
            }
            if (this.chkCursoCplus.Checked)
            {
                cursos.Add(this.chkCursoCplus.Text);
            }
            if (this.chkCursoJS.Checked)
            {
                cursos.Add(this.chkCursoJS.Text);
            }
        }
    }
}