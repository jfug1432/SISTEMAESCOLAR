using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SISTEMAESCOLAR.FORMULARIOS
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }


        private string mReturnValue;
        internal string ReturnValue
        {
            get
            {
                return mReturnValue;
            }
        }
       

        internal int mColNumber;
        internal DataSet mDS;




        private void SearchForm_Load(object sender, EventArgs e)
        {
            try
            {
                dg.DataSource = mDS;
                dg.DataMember = "Table";
              //  dg.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dg.Refresh();
            }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString ());
                }
            

            //DataColumn dc;
            foreach (DataColumn dc in mDS.Tables[0].Columns)
            {
                cmbLookIn.Items.Add(dc.ColumnName );
            }

            DataGridTableStyle ts1 = new DataGridTableStyle();
            ts1.MappingName = "table";
            cmbLookIn.SelectedIndex = 0;
            cmbMatch.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if ((mDS.Tables[0].Columns[cmbLookIn.SelectedIndex]
                    .DataType.ToString()) == "System.String")
                {
                    DataView dv = new DataView(mDS.Tables[0]);
                    switch (cmbMatch.SelectedIndex)
                    {
                        case 0: //Any Part of the Field
                            dv.RowFilter = cmbLookIn.Text + " LIKE '%" + txtFindWhat.Text + "%'";
                            break;
                        case 1: //Whole Field
                            dv.RowFilter = cmbLookIn.Text + "='" + txtFindWhat.Text + "'";
                            break;
                        case 2: // Start of the Field
                            dv.RowFilter = cmbLookIn.Text + " LIKE '" + txtFindWhat.Text + "%'";
                            break;
                    }
                    dg.DataSource = dv;
                }
                else if
                   ((mDS.Tables[0].Columns[cmbLookIn.SelectedIndex].DataType.ToString()) == "System.DateTime")
                {
                    DataView dv = new DataView(mDS.Tables[0]);
                    dv.RowFilter = cmbLookIn.Text + "=#" + txtFindWhat.Text + "#";
                    dg.DataSource = dv;
                }
                else
                {
                    DataView dv = new DataView(mDS.Tables[0]);
                    dv.RowFilter = cmbLookIn.Text + "=" + txtFindWhat.Text;
                    dg.DataSource = dv;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if(dg.Rows.Count>1)
              //  if (dg.RowCount > 1)
                {
                    int x = dg.CurrentCell.RowIndex;
                    mReturnValue = (dg.Rows[x].Cells[0].Value.ToString());
                }
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            dg.DataSource = mDS.Tables[0];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtFindWhat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((mDS.Tables[0].Columns[cmbLookIn.SelectedIndex].DataType.ToString()) == "System.String")
                {
                    DataView dv = new DataView(mDS.Tables[0]);
                    switch (cmbMatch.SelectedIndex)
                    {
                        case 0: //Cualquier parte del campo
                            dv.RowFilter = cmbLookIn.Text + " LIKE '%" + txtFindWhat.Text + "%'";
                            break;
                        case 1: //Total del campo
                            dv.RowFilter = cmbLookIn.Text + "='" + txtFindWhat.Text + "'";
                            break;
                        case 2: // Inicio del campo
                            dv.RowFilter = cmbLookIn.Text + " LIKE '" + txtFindWhat.Text + "%'";
                            break;
                    }
                    dg.DataSource = dv;
                }
                else if ((mDS.Tables[0].Columns[cmbLookIn.SelectedIndex].DataType.ToString()) == "System.DateTime")
                {
                    DataView dv = new DataView(mDS.Tables[0]);
                    dv.RowFilter = cmbLookIn.Text + "=#" + txtFindWhat.Text + "#";
                    dg.DataSource = dv;
                }
                else
                {
                    DataView dv = new DataView(mDS.Tables[0]);
                    dv.RowFilter = cmbLookIn.Text + "=" + txtFindWhat.Text;
                    dg.DataSource = dv;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmbLookIn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
