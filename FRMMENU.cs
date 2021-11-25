using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMAESCOLAR
{
    public partial class FRMMENU : Form
    {
        public FRMMENU()
        {
            InitializeComponent();
        }

        private void cARRERASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FRMCARRERAS X = new FORMULARIOS.FRMCARRERAS();
            X.Show();
        }

        private void mATERIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FRMMATERIAS X = new FORMULARIOS.FRMMATERIAS();
            X.Show();
        }

        private void gRUPOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FRMGRUPOS X = new FORMULARIOS.FRMGRUPOS();
            X.Show();
        }

        private void aLUMNOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FRMALUMNOS X = new FORMULARIOS.FRMALUMNOS();
            X.Show();
        }
    }
}
