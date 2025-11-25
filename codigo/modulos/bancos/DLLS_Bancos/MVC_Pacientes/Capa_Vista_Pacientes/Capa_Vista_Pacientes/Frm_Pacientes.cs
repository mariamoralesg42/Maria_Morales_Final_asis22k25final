using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Navegador;
using Capa_Vista_Navegador;

namespace Capa_Vista_Pacientes
{
    public partial class Frm_Pacientes : Form
    {
        public Frm_Pacientes()
        {
            InitializeComponent();
            Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView config = new Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView
            {
                Ancho = 1100,
                Alto = 200,
                PosX = 10,
                PosY = 300,
                ColorFondo = Color.AliceBlue,
                TipoScrollBars = ScrollBars.Both,
                Nombre = "dgv_Bancos"
            };

            string[] columnas = {
                "tbl_paciente",
                "pk_idPaciente",
                "nombrePaciente" ,
                "apellidoPaciente",
                "fechaNacimientoPaciente",
                "sexoPaciente",
                "direccionPaciente",
                "telefonoPaciente",
                "estadoPaciente"
            };

            string[] sEtiquetas = {
                "Código Paciente",
                "Nombre",
                "Apellido",
                "Fecha Nacimiento",
                "Dirección",
                "Teléfono",
                "Estado"
            };
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                const string subRutaAyuda = @"ayuda\modulos\bancos\Ayudas_Ordenes\Ayuda_Autorizaciones\AyudaOrdenes.chm";

                string rutaEncontrada = null;
                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(Application.StartupPath);

                for (int i = 0; i < 10 && dir != null; i++, dir = dir.Parent)
                {
                    string candidata = System.IO.Path.Combine(dir.FullName, subRutaAyuda);
                    if (System.IO.File.Exists(candidata))
                    {
                        rutaEncontrada = candidata;
                        break;
                    }
                }

                string rutaAbsolutaRespaldo =
                    @"C:\Users\rober\OneDrive\Escritorio\EXAMEN FINAL\Maria_Morales_Final_asis22k25final\ayuda\modulos\bancos\Ayudas_Ordenes\Ayuda_Autorizaciones\AyudaOrdenes.chm";

                if (rutaEncontrada == null && System.IO.File.Exists(rutaAbsolutaRespaldo))
                    rutaEncontrada = rutaAbsolutaRespaldo;

                if (rutaEncontrada != null)
                {

                    Help.ShowHelp(this, rutaEncontrada, HelpNavigator.Topic, "ayuda_auto.html");
                }
                else
                {
                    string intento = System.IO.Path.Combine(Application.StartupPath, subRutaAyuda);
                    MessageBox.Show(
                        "No se encontró el archivo de ayuda.\n\nProbé desde:\n" + intento +
                        "\n\nVerifica que exista esta ruta relativa dentro del proyecto:\n" + subRutaAyuda,
                        "Archivo de ayuda no encontrado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(

                    "Error al abrir la ayuda:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

            }

        }
    }
}
