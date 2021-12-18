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
    public partial class FormBitacora : Form
    {
        Logica.Bitacora MiBitacora { get; set; }
        public DataTable DtLista { get; set; }
        public FormBitacora()
        {
            InitializeComponent();
            MiBitacora = new Logica.Bitacora();
            DtLista = new DataTable();
        }

        private void LlenarListaBitacora()
        {
            DtLista = new DataTable();
            DtLista = MiBitacora.Listar();
            DgvBitacora.DataSource = DtLista;
        }

        private void FormBitacora_Load(object sender, EventArgs e)
        {
            LlenarListaBitacora();
        }
    }
}
