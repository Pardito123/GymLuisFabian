using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTO_DE_VENTA_CODIGO369_CSHARP.CONEXION
{
    class CONEXIONMAESTRA
    {
        public static string conexion = "Data source=.;Initial Catalog=Gimnasio_Luis_Fabbian;Integrated Security=True";
        private SqlConnection Conexion = new SqlConnection(conexion);
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == System.Data.ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == System.Data.ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
