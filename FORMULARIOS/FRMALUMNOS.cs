using System;
using System.Windows.Forms;
using System.Data;

namespace SISTEMAESCOLAR.FORMULARIOS
{
    public partial class FRMALUMNOS : Form
    {
        public FRMALUMNOS()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            CLASES.CLGRUPOS consultar = new CLASES.CLGRUPOS(byte.Parse(txtid.Text));
            CLASES.clconexion conexion = new CLASES.clconexion(consultar.CONSULTARI());
            ds = conexion.consultar();
            if (ds.Tables[0].Rows.Count > 0)
            {
                // MODIFICAR
                // txtnombre.Text = ds.Tables["Tabla"].Rows[0]["NOMBRE"].ToString();
                CLASES.CLGRUPOS MODIFICAR = new CLASES.CLGRUPOS(Convert.ToByte(txtid.Text), txtnombre.Text, true);
                conexion = new CLASES.clconexion(MODIFICAR.modificar());
                conexion.EJECUTAR();
            }
            else
            {
                //  MessageBox.Show("Lo siento, dato no encontrado");
                CLASES.CLGRUPOS GRABAR = new CLASES.CLGRUPOS(Convert.ToByte(txtid.Text), txtnombre.Text, true);
                conexion = new CLASES.clconexion(GRABAR.GRABAR());
                conexion.EJECUTAR();
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
                CLASES.CLGRUPOS G = new CLASES.CLGRUPOS();
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

            CLASES.CLGRUPOS consultar = new CLASES.CLGRUPOS(byte.Parse(txtid.Text));
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

            CLASES.CLGRUPOS consultar = new CLASES.CLGRUPOS(byte.Parse(txtid.Text));
            CLASES.clconexion conexion = new CLASES.clconexion(consultar.CONSULTARI());
            ds = conexion.consultar();
            if (ds.Tables[0].Rows.Count > 0)
            {
                // DAR DE BAJA
                // txtnombre.Text = ds.Tables["Tabla"].Rows[0]["NOMBRE"].ToString();
                CLASES.CLGRUPOS borrarCARRERA = new CLASES.CLGRUPOS(Convert.ToByte(txtid.Text), txtnombre.Text, true);
                conexion = new CLASES.clconexion(borrarCARRERA.ELIMINAR());
                conexion.EJECUTAR();
            }
            else
            {
                  MessageBox.Show("Lo siento, dato no encontrado");
               
            }
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            //   &&   (e.KeyChar != '.') solo cuando sean números con posiciones decimales
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }

            // only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        private void txtid_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtid.Text))
            {
                if (!(int.Parse(txtid.Text) > 0 && int.Parse(txtid.Text) <= 255) || txtid.Text == "")
                {
                    MessageBox.Show("Valores entre 0-255");
                    txtid.Clear();
                    txtid.Focus();
                }
            }
        }

        private void txtnombre_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtnombre.Text))
            {
                MessageBox.Show("Introduzca valor");
            }
        }

        private void FRMALUMNOS_Load(object sender, EventArgs e)
        {
            carga_carreras();
        }
        private void carga_carreras()
        {
                DataSet ds = new DataSet();

                CLASES.CLCARRERAS s = new CLASES.CLCARRERAS();
                CLASES.clconexion c = new CLASES.clconexion(s.consultageneral());
                ds = c.consultar();
                cmbcarreras.DataSource = ds.Tables[0];
                cmbcarreras.DisplayMember = ds.Tables[0].Columns["nombre"].ToString();
                cmbcarreras.ValueMember = ds.Tables[0].Columns["CLAVE"].ToString();
            
        }
    }
}
