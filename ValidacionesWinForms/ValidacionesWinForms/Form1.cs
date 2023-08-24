using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ValidacionesWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnValidarPatente_Click(object sender, EventArgs e)
        {
            string patente = txtPatente.Text.ToUpper();

            if (EsPatenteValida(patente))
            {
                lblResultadoPatente.Text = "Patente válida";
            }
            else
            {
                lblResultadoPatente.Text = "Patente inválida";
            }
        }

        private bool EsPatenteValida(string patente)
        {
            Regex regex = new Regex(@"^[A-Z]{2}\d{3}[A-Z]{2}$|^[A-Z]{3}\d{3}$");

            return regex.IsMatch(patente);
        }

        private void btnSepararCUIT_Click(object sender, EventArgs e)
        {
            string cuitSinGuiones = txtCUIT.Text.Replace("-", "").Replace(".", "").Replace(" ", "");

            if (cuitSinGuiones.Length == 11 && long.TryParse(cuitSinGuiones, out _))
            {
                string cuitFormateado = FormatearCUIT(cuitSinGuiones);
                lblCUITFormateado.Text = cuitFormateado;

                string dni = cuitSinGuiones.Substring(2, 8);
                lblDNI.Text = dni;
            }
            else
            {
                lblCUITFormateado.Text = "CUIT inválido";
                lblDNI.Text = string.Empty;
            }
        }

        private string FormatearCUIT(string cuitSinGuiones)
        {
            return $"{cuitSinGuiones.Substring(0, 2)}-{cuitSinGuiones.Substring(2, 8)}-{cuitSinGuiones.Substring(10)}";
        }
    }
}
