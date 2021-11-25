using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMAESCOLAR.CLASES
{
    internal class CLGRUPOS
    {
        private Byte id;
        private String nombre;
        private Boolean estatus;
        // Grabar y Modificar
        public CLGRUPOS(byte iD, string nombre, bool estatus)
        {
            id = iD;
            this.nombre = nombre;
            this.estatus = estatus;
        }
        // Consultar individualmente

        public CLGRUPOS(byte iDs)
        {
            id = iDs;
        }
        public CLGRUPOS()
        {

        }
        public string GRABAR()
        {
            return (" insert into TBLGRUPOS (ID,NOMBRE,ESTATUS) values ('" + this.id + "','" + this.nombre + "','" + 1 + "')");
        }
        public string CONSULTARI()
        {
            return (" SELECT * FROM  TBLGRUPOS WHERE ID= '" + this.id + "'");
        }
        public string ELIMINAR()
        {
            return (" delete from TBLGRUPOS WHERE id= '" + this.id + "'");
        }
        public string modificar()
        {
            return (" update TBLGRUPOS set  NOMBRE ='" + this.nombre + "' WHERE id= '" + this.id + "'");
        }
        public string consultageneral()
        {
            return (" SELECT id as CLAVE,NOMBRE as NOMBRE FROM  TBLGRUPOS");
        }

    }
}
