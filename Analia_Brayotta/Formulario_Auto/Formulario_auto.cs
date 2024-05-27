using Libreria_Auto;
namespace Formulario_Auto
{
    public partial class Formulario_auto : Form
    {
        List<Auto> misAutos;
        public Formulario_auto()
        {
            InitializeComponent();
        }
        private void Formulario_auto_load(object sender, EventArgs e)
        {
            this.misAutos = new List<Auto>();
            this.cmb_colores.Items.AddRange(Auto.ColoresValidos().ToArray());
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            string marca = this.txt_marca.Text;
            string combustible = this.txt_combustible.Text;
            string color = this.cmb_colores.Text;

            this.Limpiar();

        }
        private void Limpiar()
        {
            this.txt_marca.Text = string.Empty;
            this.txt_combustible.Text =string.Empty;
            this.cmb_colores.Text = string.Empty;
        }

        private void cbb_colores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Formulario_auto_Load(object sender, EventArgs e)
        {

        }
    }
}
