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
        }
}
