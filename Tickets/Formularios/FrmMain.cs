using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tickets.Formularios
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            TmrHora.Enabled = true;

            LblUsuarioLogueado.Text = Commons.ObjetosGlobales.MiUsuarioDeSistema.Email;
        }

        private void TmrHora_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //TODO: analizar si queremos hacer un logout cuando cerramos el principal 
            Bitacora MiBitacora = new Bitacora();
            MiBitacora.GuardarAccionEnBitacora("Cierre del Programa dentro de Main");
            Application.Exit();

        }

        private void gestiónDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mostramos el formulario global de gestión de usuarios 

            Commons.ObjetosGlobales.FormularioGestionDeUsuarios = new FrmUsuarioGestion();

            Commons.ObjetosGlobales.FormularioGestionDeUsuarios.Show();

        }

        private void creaciónDeTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Commons.ObjetosGlobales.FormCrearTiket = new FrmTicketCrear();
            Commons.ObjetosGlobales.FormCrearTiket.Show();
        }

        private void soluciónDeTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Commons.ObjetosGlobales.FormAtencion = new FrmAtencionDeTickets();
            Commons.ObjetosGlobales.FormAtencion.Show();
        }

        private void bitácoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Commons.ObjetosGlobales.FormBitacora = new FormBitacora();
            Commons.ObjetosGlobales.FormBitacora.Show();

        }
    }
}
