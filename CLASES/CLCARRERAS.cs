using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAESCOLAR.CLASES
{
    class CLCARRERAS
    {
        private Byte id;
        private String nombre;
        private Boolean estatus;
        // Grabar y Modificar
        public CLCARRERAS(byte iD, string nombre, bool estatus)
        {
            id = iD;
            this.nombre = nombre;
            this.estatus = estatus;
        }
        // Consultar individualmente

        public CLCARRERAS(byte iDs)
        {
            id = iDs;
        }
        public CLCARRERAS()
        {
           
        }
        public string GRABAR()
        {
            return (" insert into TBLCARRERAS (ID,NOMBRE) values ('" + this.id + "','" + this.nombre + "')");
        }
        public string CONSULTARI()
        {
            return (" SELECT * FROM  TBLCARRERAS WHERE ID= '" + this.id + "'");
        }
        public string modificar()
        {
            return (" update TBLCARRERAS set  NOMBRE ='" + this.nombre + "' WHERE id= '" + this.id + "'");
        }
        public string consultageneral()
        {
            return (" SELECT id as CLAVE,NOMBRE as NOMBRE FROM  TBLCARRERAS");
        }

    }
}
