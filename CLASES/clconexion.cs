using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SISTEMAESCOLAR.CLASES
{
    class clconexion
    {
           private string sentencia1;

            // estas se derivan de la clase System.Data.SqlClient
            private SqlConnection conn = new SqlConnection();
            private SqlCommand cmd;

            public clconexion()
            {
            }
            public clconexion(string sentencia)
            {
                sentencia1 = sentencia;
            }
            // este método servirá para grabar, borrar y modificar
            public string EJECUTAR()
            {
                //   try
                {
                    // conn = new SqlConnection(CLASES.globales.miconexion);
                    conn.ConnectionString = CLASES.clglobal.miconexion;
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Close();
                        conn.Open();
                    }
                    cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = sentencia1;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return "Operación exitosa";
                }
                //    catch (Exception ex)
                {

                    /*         globales.err_mensaje = ex.Message;
                             globales.err_linea = ex.StackTrace;
                             int l = globales.err_linea.Length;
                             if (l > 50)
                             {
                                 l = l - 50;
                                 globales.err_linea = globales.err_linea.Substring(l, 50);
                             }
                             globales.err_origen = ex.Source;
                             globales.grabaerror();
                             MessageBox.Show("Error " + ex.Message + "\n Aplicación :" + ex.Source + "\n  Linea :" + ex.StackTrace, "Buscando", MessageBoxButtons.OK, MessageBoxIcon.Error);
                             return "Operación exitosa";*/
                }

            }
            public DataSet consultar()
            {
                DataSet datos = new DataSet();
                try
                {// esta atenta

                    conn = new SqlConnection(CLASES.clglobal.miconexion);
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Close();
                        conn.Open();
                    }
                    // conn.Open();
                    SqlDataAdapter resp = new SqlDataAdapter(sentencia1, conn);
                    resp.Fill(datos, "Tabla");
                    conn.Close();
                    return datos;
                }
                catch (Exception ex)
                {

                    //globales.err_mensaje = ex.Message;
                    //globales.err_linea = ex.StackTrace;
                    //int l = globales.err_linea.Length;
                    //if (l > 50)
                    //{
                    //    l = l - 50;
                    //    globales.err_linea = globales.err_linea.Substring(l, 50);
                    //}
                    //globales.err_origen = ex.Source;
                    //globales.grabaerror();
                    //MessageBox.Show("Error " + ex.Message + "\n Aplicación :" + ex.Source + "\n  Linea :" + ex.StackTrace, "Buscando", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                return datos;
            }
            
                    private string mFieldValue;
                    internal string FieldValue
                    {
                        get { return mFieldValue; }
                    }
          internal bool Execute(string SQL, int ColumnNumberToRetrive)
                    {
                        DataSet ds = new DataSet();
                        SqlDataAdapter da = new SqlDataAdapter(SQL, CLASES.clglobal.miconexion);
                        da.Fill(ds, "Table");

                        FORMULARIOS.SearchForm frmSearchForm = new FORMULARIOS.SearchForm();
                        frmSearchForm.mColNumber = ColumnNumberToRetrive;
                        frmSearchForm.mDS = ds;
                        ds = null;
                        frmSearchForm.ShowDialog();
                        if (frmSearchForm.DialogResult == System.Windows.Forms.DialogResult.OK)
                        {
                            mFieldValue = frmSearchForm.ReturnValue;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                 }

            internal DataSet ExecuteC(string SQL)
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(SQL, CLASES.clglobal.miconexion);
                da.Fill(ds, "Table");
                return ds;
            }
            internal DataSet ExecuteT(string SQL)
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(SQL, CLASES.clglobal.miconexion);
                da.Fill(ds, "Table");
                return ds;
            }
        } }
        
    

