using System;
using System.Windows.Forms;
using System.Data;

namespace SISTEMAESCOLAR.FORMULARIOS
{
    public partial class FRMMATERIAS : Form
    {
        public FRMMATERIAS()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtid.Text) > 0 && int.Parse(txtid.Text) < 255)
            {
                DataSet ds = new DataSet();

                CLASES.CLMATERIAS consultar = new CLASES.CLMATERIAS(byte.Parse(txtid.Text));
                CLASES.clconexion conexion = new CLASES.clconexion(consultar.CONSULTARI());
                ds = conexion.consultar();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // MODIFICAR
                    // txtnombre.Text = ds.Tables["Tabla"].Rows[0]["NOMBRE"].ToString();
                    CLASES.CLMATERIAS MODIFICARCARRERA = new CLASES.CLMATERIAS(Convert.ToByte(txtid.Text), txtnombre.Text, true);
                    conexion = new CLASES.clconexion(MODIFICARCARRERA.modificar());
                    conexion.EJECUTAR();
                }
                else
                {
                    //  MessageBox.Show("Lo siento, dato no encontrado");
                    CLASES.CLMATERIAS GRABARCARRERA = new CLASES.CLMATERIAS(Convert.ToByte(txtid.Text), txtnombre.Text, true);
                    conexion = new CLASES.clconexion(GRABARCARRERA.GRABAR());
                    conexion.EJECUTAR();
                }
            }
            else
            {
                MessageBox.Show("Valores permitidos entre 0-255");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            consultar();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            busca();
        }
        private void busca()
        {
            try
            {
                CLASES.CLMATERIAS G = new CLASES.CLMATERIAS();
                CLASES.clconexion con = new CLASES.clconexion();
                if (con.Execute(G.consultageneral(), 0) == true)
                {
                    if (con.FieldValue != "")
                    {
                        txtid.Text = con.FieldValue;
                        consultar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }
        private void consultar()
        {
            DataSet ds = new DataSet();

            CLASES.CLMATERIAS consultar = new CLASES.CLMATERIAS(byte.Parse(txtid.Text));
            CLASES.clconexion conexion = new CLASES.clconexion(consultar.CONSULTARI());
            ds = conexion.consultar();
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtnombre.Text = ds.Tables["Tabla"].Rows[0]["NOMBRE"].ToString();
            }
            else
                MessageBox.Show("Lo siento, dato no encontrado");
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            CLASES.CLMATERIAS consultar = new CLASES.CLMATERIAS(byte.Parse(txtid.Text));
            CLASES.clconexion conexion = new CLASES.clconexion(consultar.CONSULTARI());
            ds = conexion.consultar();
            if (ds.Tables[0].Rows.Count > 0)
            {
                // DAR DE BAJA
                // txtnombre.Text = ds.Tables["Tabla"].Rows[0]["NOMBRE"].ToString();
                CLASES.CLMATERIAS borrarCARRERA = new CLASES.CLMATERIAS(Convert.ToByte(txtid.Text), txtnombre.Text, true);
                conexion = new CLASES.clconexion(borrarCARRERA.ELIMINAR());
                conexion.EJECUTAR();
            }
            else
            {
                  MessageBox.Show("Lo siento, dato no encontrado");
               
            }
        }
    }
}
