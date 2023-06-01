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
    public partial class FormAreas : Form
    {
        public FormAreas()
        {
            InitializeComponent();
        }
        private void FormAreas_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular1_Click(object sender, EventArgs e)
        {
            double base1 = double.Parse(textBox1.Text);
            double altura1 = double.Parse(textBox2.Text);
            double area1 = (base1 * altura1) / 2;
            textBox3.Text = area1.ToString();

        }

        private void btnCalcular2_Click(object sender, EventArgs e)
        {
            double base2 = double.Parse(textBox4.Text);
            double altura2 = double.Parse(textBox5.Text);
            double area2 = (base2 * altura2) / 2;
            textBox6.Text = area2.ToString();
        }

        private void btnCalcular3_Click(object sender, EventArgs e)
        {
            double baseMayor = double.Parse(textBox7.Text);
            double baseMenor = double.Parse(textBox8.Text);
            double altura3 = double.Parse(textBox9.Text);

            double area3 = ((baseMayor +baseMenor) / 2)*altura3;

            textBox10.Text = area3.ToString();
        }

      

        private void BtnSumar3Areas_Click(object sender, EventArgs e)
        {

            double Area1 = double.Parse(textBox3.Text);
            double Area2 = double.Parse(textBox6.Text);
            double Area3 = double.Parse(textBox10.Text);

            double suma = Area1 + Area2 + Area3;
            textBox14.Text = suma.ToString();
          

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox14.Text = "";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
