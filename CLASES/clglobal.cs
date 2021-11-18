using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAESCOLAR.CLASES
{
    class clglobal
    {
        static public string dbn = "BDESCOLAR";
        static public string server = "LAPTOP-348QMSO7";
        static public string UserID = "Administrador";
        static public string Password = "jfsys";
        static public string seguridad = "Integrated Security=True";
        
      //  static public string miconexion = @"Data Source = " + server + "; Initial Catalog = " + dbn + "; Persist Security Info = True; User ID = Administrador; Password = " + Password;
        static public string miconexion = @"Data Source = " + server + "; Initial Catalog = " + dbn + "; Persist Security Info = True; Integrated Security=True;";


    }
}
