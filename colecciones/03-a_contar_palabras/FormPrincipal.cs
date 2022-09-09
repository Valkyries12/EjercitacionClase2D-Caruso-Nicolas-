using System.Text;

namespace _03_a_contar_palabras
{
    public partial class FormPrincipal : Form
    {
        private Dictionary<string, int> palabrasDic;
        public FormPrincipal()
        {
            palabrasDic = new Dictionary<string, int>();
            InitializeComponent();
        }



        private void btnCalcular_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string[] textoEscrito = this.rtbPizarra.Text.Split(" ");
            foreach (string palabra in textoEscrito)
            {
                if (!palabrasDic.ContainsKey(palabra))
                {
                    palabrasDic.Add(palabra, 1);
                }
                else
                {
                    foreach (KeyValuePair<string, int> item in palabrasDic)
                    {
                        if (item.Key.Contains(palabra))
                        {
                            palabrasDic[palabra] += 1;
                        }
                    }
                }
            }

            List<KeyValuePair<string, int>> mappings = palabrasDic.ToList();
            mappings.Sort((x, y) => x.Value.CompareTo(y.Value));
            mappings.Reverse();

            for (int i = 0; i < 3; i++)
            {
                sb.AppendLine($"La palabra \"{mappings[i].Key}\" aparece \"{mappings[i].Value}\" veces");

            }

            


            MessageBox.Show(sb.ToString());
            this.palabrasDic.Clear();
        }
    }
}