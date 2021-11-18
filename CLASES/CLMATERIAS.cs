using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAESCOLAR.CLASES
{
    internal class CLMATERIAS
    {
        private Byte id;
        private String nombre;
        private Boolean estatus;
        // Grabar y Modificar
        public CLMATERIAS(byte iD, string nombre, bool estatus)
        {
            id = iD;
            this.nombre = nombre;
            this.estatus = estatus;
        }
        // Consultar individualmente

        public CLMATERIAS(byte iDs)
        {
            id = iDs;
        }
        public CLMATERIAS()
        {

        }
        public string GRABAR()
        {
            return (" insert into TBLMATERIAS (ID,NOMBRE) values ('" + this.id + "','" + this.nombre + "')");
        }
        public string CONSULTARI()
        {
            return (" SELECT * FROM  TBLMATERIAS WHERE ID= '" + this.id + "'");
        }
        public string ELIMINAR()
        {
            return (" delete from TBLMATERIAS WHERE id= '" + this.id + "'");
        }
        public string modificar()
        {
            return (" update TBLMATERIAS set  NOMBRE ='" + this.nombre + "' WHERE id= '" + this.id + "'");
        }
        public string consultageneral()
        {
            return (" SELECT id as CLAVE,NOMBRE as NOMBRE FROM  TBLMATERIAS");
        }

    }
}
