using Logica.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Bitacora
    {
        public bool GuardarAccionEnBitacora(string descripcion, int user = 0)
        {
            bool R = false;
            Conexion MiCnnAdd = new Conexion();
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@descripcion", descripcion));
            MiCnnAdd.ListadoDeParametros.Add(new SqlParameter("@user", user));
            int resultado = MiCnnAdd.DMLUpdateDeleteInsert("SPBitacoraInsertar");
            if (resultado > 0)
            {
                R = true;
            }
            return R;
        }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            

            R = MiCnn.DMLSelect("SPBitacoraListar");

            return R;
        }

    }
        
}
