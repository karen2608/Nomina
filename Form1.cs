using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXamen
{
    public partial class Form1 : Form
    {
        Nomina MyNomina = new Nomina();
        Empleado  MyEmpleado = new Empleado();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGRE_Click(object sender, EventArgs e)
        {
            MyEmpleado.Nombre = txtNombre.Text;
            MyEmpleado.Cedula = Convert.ToInt32(txtID.Text);
            MyNomina.Diaslaborados = Convert.ToInt32(txtDL.Text);
            MyNomina.Valordia = Convert.ToInt32(txtVPD.Text);


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtVPD.Clear();
            txtD.Clear();
            txtID.Clear();
            txtDL.Clear();
            txtNombre.Clear();


        }

        private void bntCS_Click(object sender, EventArgs e)
        {
            txtD.Text = MyNomina.calularnomina(MyNomina.Diaslaborados,MyNomina.Valordia).ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
