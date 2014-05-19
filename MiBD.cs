using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;

namespace Registro
{
    public class MiBD
    {
        public static SqlConnection Conexion()
        {
            SqlConnection Enchufe = new SqlConnection();
            Enchufe.ConnectionString = "Data Source=BCLPT05;Initial Catalog=Cuentas;User ID=sa;Password=entrada";

            Enchufe.Open();

            return Enchufe;
        }
    }
}
//Data Source=BCLPT05;Initial Catalog=Cuentas;User ID=sa;Password=entrada