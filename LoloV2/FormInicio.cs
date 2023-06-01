using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoloV2
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void horayfecha_Tick(object sender, EventArgs e)
        {
            lblfechayhora.Text = DateTime.Now.ToString() + " || " + DateTime.Now.ToLongTimeString();

        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            horayfecha.Enabled = true;
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormAccess form1 = new FormAccess();
            form1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormMusica FormMusica = new FormMusica();
            FormMusica.ShowDialog();
        }

        private void btnAreas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAreas formAreas = new FormAreas();
            formAreas.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormFoto f = new FormFoto();
            f.Show();
        }
    }
}
