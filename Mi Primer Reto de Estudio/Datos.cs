using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Mi_Primer_Reto_de_Estudio
{
    class Datos
    {
        public static SqlConnection OpenDB() 
        {
            SqlConnection cn = new SqlConnection("SERVER=LAPTOP-ACV7CIRP;DATABASE=Almacen;" +
                "INTEGRATED SECURITY=true");
            cn.Open();
            return cn;
        }
    }
}
