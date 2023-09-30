using System.Text.RegularExpressions;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            Regex validacion = new Regex("^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)(?=.*\\W).+$");

            //Validar que los campos no est�n vac�os.
            if (string.IsNullOrEmpty(txtContrasenaUno.Text) && string.IsNullOrEmpty(txtContrasenaDos.Text))
            {
                MessageBox.Show("Los campos est�n vac�os.");
                return;
            }

            //Validar si ambos textos no son iguales.
            if (!txtContrasenaUno.Text.Equals(txtContrasenaDos.Text))
            {
                MessageBox.Show("Las contrase�as no son iguales. Corrija e intente de nuevo.");
                return;
            }

            //Validamos el REGEX
            if (validacion.IsMatch(txtContrasenaUno.Text))
            {
                MessageBox.Show("La contrase�a es v�lida.");
                return;
            }
            else
            {
                MessageBox.Show("La contrase�a no es v�lida.");
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}