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
    public partial class FormFoto : Form
    {
        public FormFoto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection CANAL;
            DataSet TABLA;
            OleDbDataAdapter ORDEN;
            CANAL = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\\datos\\mibase.mdb");
            string q = "select * from mitabla2 where ID_PDO = @ID_PDO";
            ORDEN = new OleDbDataAdapter(q, CANAL);
            ORDEN.SelectCommand.Parameters.Add(new OleDbParameter("@ID_PDO", OleDbType.Integer));
            ORDEN.SelectCommand.Parameters["@ID_PDO"].Value = iD_PDOTextBox.Text;
            // Creando el dataset y cargandolo
            TABLA = new DataSet();
            ORDEN.Fill(TABLA, "mitabla2");
            // Cargando el datagridVIEW
            mitabla2DataGridView.DataSource = TABLA;
            mitabla2DataGridView.DataMember = "mitabla2";
            // Cargando la imagen
           //string temp = TABLA.Tables["mitabla2"].Rows[0][3].ToString();
            pictureBox1.Image = Image.FromFile("c:\\datos\\" + "imagen.jpg");
           // Image image2 = Image.FromFile("c:\\datos\\pato.jpg");

        }

        private void mitabla2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mitabla2BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mibaseDataSet2);

        }

        private void mitabla2BindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.mitabla2BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mibaseDataSet2);

        }

        private void FormFoto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mibaseDataSet2.mitabla2' Puede moverla o quitarla según sea necesario.
            this.mitabla2TableAdapter.Fill(this.mibaseDataSet2.mitabla2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection CANAL;
            OleDbCommand ORDEN;
            CANAL = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\\datos\\mibase.mdb");
            // Instruccionsql UPDATE
            string q = "Update mitabla2 set NOMBRE=@NOMBRE, COLOR=@COLOR, PRECIO=@PRECIO, GRAFICO=@GRAFICO   where ID_PDO=" + iD_PDOTextBox.Text;
            ORDEN = new OleDbCommand(q, CANAL);
            ORDEN.Parameters.Add(new OleDbParameter("@NOMBRE", OleDbType.VarWChar, 20));
            ORDEN.Parameters["@NOMBRE"].Value = nOMBRETextBox.Text;
            ORDEN.Parameters.Add(new OleDbParameter("@COLOR", OleDbType.VarWChar));
            ORDEN.Parameters["@COLOR"].Value = cOLORTextBox.Text;

            ORDEN.Parameters.Add(new OleDbParameter("@PRECIO", OleDbType.VarWChar));
            ORDEN.Parameters["@PRECIO"].Value = pRECIOTextBox.Text;

            ORDEN.Parameters.Add(new OleDbParameter("@GRAFICO", OleDbType.VarWChar));
            ORDEN.Parameters["@GRAFICO"].Value = gRAFICOTextBox.Text;

            ORDEN.Connection.Open();
            ORDEN.ExecuteNonQuery();
            ORDEN.Connection.Close();
            // Limpiando TEXTBOXS para otra edicion
            nOMBRETextBox.Text = " ";
            cOLORTextBox.Text = " ";
            pRECIOTextBox.Text = " ";
            gRAFICOTextBox.Text = " ";
//            iD_PDOTextBox.Text = " ";
            // Avisando edicion
            MessageBox.Show("mensaje editado");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
