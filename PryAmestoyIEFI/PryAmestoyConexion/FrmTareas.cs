using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryAmestoyConexion
{
    public partial class FrmTareas : Form
    {
        public FrmTareas()
        {
            InitializeComponent();
        }

        private void pictureExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void pictureMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureMax.Visible = false;
            pictureRes.Visible = true;
        }

        private void pictureRes_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Normal;
            pictureRes.Visible = false;
            pictureMax.Visible = true;
        }

        private void pictureMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmTareas_Load(object sender, EventArgs e)
        {
            cmbLugares.Items.Clear();
            cmbLugares.Items.Add("Empresa");
            cmbLugares.Items.Add("Servicio");
            cmbLugares.Items.Add("Oficina");
            cmbLugares.Items.Add("subsuelo");
            cmbLugares.Items.Add("Mantenimiento");


            cmbTareas.Items.Clear();
            cmbTareas.Items.Add("Auditoria");
            cmbTareas.Items.Add("Reclamos");
            cmbTareas.Items.Add("Inspección");
            cmbTareas.Items.Add("Consulta");
            cmbTareas.Items.Add("Visita");
            cmbTareas.Items.Add("Control Stock");


        }

    }
}
