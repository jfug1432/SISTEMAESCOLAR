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
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}
