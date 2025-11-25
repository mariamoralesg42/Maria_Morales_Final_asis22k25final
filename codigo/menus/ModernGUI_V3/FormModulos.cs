using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Vista_Seguridad;
using Capa_Controlador_Seguridad;
using Capa_Controlador_Bancos;
using Capa_Vista_Bancos;

namespace Interfac_V3
{
    public partial class FormModulos : Form
    {
        public FormModulos()
        {
            InitializeComponent();
        }

        private void FormModulos_Load(object sender, EventArgs e)
        {

        }
        //Metodo para arrastrar el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelBarraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            using (var splash = new Capa_Vista_Seguridad.Frm_Slash())
            {
                splash.ShowDialog();
            }


            Capa_Vista_Seguridad.Frm_Login frm = new Capa_Vista_Seguridad.Frm_Login();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {            
            Application.Exit();
        }

        private void btnPropio_Click(object sender, EventArgs e)
        {
            using (var splash = new Capa_Vista_Bancos.Frm_Slash())
            {
                splash.ShowDialog();
            }


            Capa_Vista_Bancos.Frm_Login frm = new Capa_Vista_Bancos.Frm_Login();
            frm.FormClosed += (s, args) => this.Show();
            frm.Show();
            this.Hide();
        }
    }
}
