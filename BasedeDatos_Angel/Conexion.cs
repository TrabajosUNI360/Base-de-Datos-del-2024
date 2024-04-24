using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasedeDatos_Angel
{
    public class BD_Conexion
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDM;Data Source=MALAJIM\\SQLEXPRESS01");
            conexion.Open();

            return conexion;
        }
    }
}