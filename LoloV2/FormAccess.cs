using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoloV2
{
    public partial class FormAccess : Form
    {
        public FormAccess()
        {
            InitializeComponent();
        }

        private void mitablaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mitablaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mibaseDataSet);

        }

        private void mitablaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.mitablaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mibaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mibaseDataSet.mitabla' Puede moverla o quitarla según sea necesario.
            this.mitablaTableAdapter.Fill(this.mibaseDataSet.mitabla);
            //lblHora.Text = DateTime.Now.ToString("H:mm:ss");
            //lblFecha.Text = DateTime.Now.ToString("d/MM/yyyy");
            horayfecha.Enabled = true;
            panel1.Visible = false;
            mitablaDataGridView.Visible = false;
            claveTextBox.Visible = false;
            nombreTextBox.Visible = false;
            edadTextBox.Visible = false;
            mitablaBindingNavigator.Visible = false;

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Close();
            FormInicio formInicio = new FormInicio();
            formInicio.ShowDialog();
        }

        private void horayfecha_Tick(object sender, EventArgs e)
        {
            lblfechayhora.Text = DateTime.Now.ToString() + " || " + DateTime.Now.ToLongTimeString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbUsuario.Text == "admin" && txbContraseña.Text == "pass")
            {
                lblnombre.Text = "Bienvenido " + txbUsuario.Text;
                panel1.Visible = true;
                mitablaDataGridView.Visible = true;
                claveTextBox.Visible = true;
                nombreTextBox.Visible = true;
                edadTextBox.Visible = true;


                mitablaBindingNavigator.Visible = true;

            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta:");
            }
        }

        private void mitablaBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
        int cont = 0;
        private void btn_Alta_Click(object sender, EventArgs e)
        {
            // creando y cargando coneccion y command
            //OleDbConnection CANAL;
            //OleDbCommand ORDEN;
            //// abriendo la coneccion o enlace
            //CANAL = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\\datos\\mibase.mdb");
            //// creando y cargando un objeto OLEDBCOMMAND
            //// instruccionsqlinsertintomitabla(listacampos) values(listadatos)
            //// @variable es una variable de tipo parametro
            //string q = "insertintomitabla(nombre,edad) values(@NOMBRE, @EDAD)";
            //ORDEN = new OleDbCommand(q, CANAL);
            //ORDEN.Parameters.Add(new OleDbParameter("@NOMBRE", OleDbType.VarWChar, 20));
            //ORDEN.Parameters["@NOMBRE"].Value = nombreTextBox.Text;
            //ORDEN.Parameters.Add(new OleDbParameter("@EDAD", OleDbType.Integer));
            //ORDEN.Parameters["@EDAD"].Value = edadTextBox.Text;
            //ORDEN.Connection.Open();
            //ORDEN.ExecuteNonQuery();
            //ORDEN.Connection.Close();
            //// limpiando TEXTBOXS para otra inserccion
            //nombreTextBox.Text = " ";
            //edadTextBox.Text = " ";
            //// avisandoinserccion
            //cont = cont + 1;
            //lblresultado.Text = "REGISTRO no: " + cont.ToString() + " Insertado";

        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            //OleDbConnection CANAL;
            //OleDbCommand ORDEN;
            //CANAL = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\\datos\\mibase.mdb");
            //// Instruccionsql UPDATE
            //string q = "Updatemitabla set nombre=@nombre, edad=@EDAD where clave=" + claveTextBox.Text;
            //ORDEN = new OleDbCommand(q, CANAL);
            //ORDEN.Parameters.Add(new OleDbParameter("@NOMBRE", OleDbType.VarWChar, 20));
            //ORDEN.Parameters["@NOMBRE"].Value = nombreTextBox.Text;
            //ORDEN.Parameters.Add(new OleDbParameter("@EDAD", OleDbType.Integer));
            //ORDEN.Parameters["@EDAD"].Value = edadTextBox.Text;
            //ORDEN.Connection.Open();
            //ORDEN.ExecuteNonQuery();
            //ORDEN.Connection.Close();
            //// Limpiando TEXTBOXS para otra edicion
            //nombreTextBox.Text = " ";
            //edadTextBox.Text = " ";
            //// Avisando edicion
            //lblresultado.Text = "REGISTRO EDITADO";

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            {
                //// Objetos OLEDB que se ocupan
                //OleDbConnection CANAL;
                //OleDbCommand ORDEN;
                //CANAL = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\\datos\\mibase.mdb");
                //// Instruccionsql DELETE FROM TABLA WHERE CLAVE=DATO
                //string q = "deletefrommitablawhere clave=@CLAVE";
                //ORDEN = new OleDbCommand(q, CANAL);
                //ORDEN.Parameters.Add(new OleDbParameter("@CLAVE", OleDbType.Integer));
                //ORDEN.Parameters["@CLAVE"].Value = claveTextBox.Text;
                //ORDEN.Connection.Open();
                //ORDEN.ExecuteNonQuery();
                //ORDEN.Connection.Close();
                //// Avisando
                //lblresultado.Text = " REGISTRO ELIMINADO";

            }
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInicio formInicio = new FormInicio();
            formInicio.ShowDialog();
        }

      
    }
}

