using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaSm.Models;

namespace AgendaSm
{
    public partial class frmPacientes : Form
    {
        paciente conte = new paciente();
        frmPacientes frmPaciente;

        public void LlenarCuadricula()
        {
            var datos = conte.getAll(cbActivos.Checked);
            dgvDatos.DataSource = datos;

            DateTime fecha = conte.dtFecnac;
        }
        public frmPacientes()
        {
            InitializeComponent();
            dgvDatos.AutoGenerateColumns = false;
        }
        public frmPacientes(frmPacientes fPaciente)
        {
            InitializeComponent();
            this.frmPaciente = fPaciente;
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            LlenarCuadricula();  
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gpDatos.Visible = true;
            gpHerramientas.Visible = true;
        }

        private void dtpFecNac_MouseHover(object sender, EventArgs e)
        {
            ttMensaje.IsBalloon = true;
            ttMensaje.SetToolTip(btnMenu, "Menú Principal");
            ttMensaje.SetToolTip(btnBuscar, "Buscar");
            ttMensaje.SetToolTip(btnNuevo, "Agregar Paciente");
            ttMensaje.SetToolTip(txtBusqueda, "Busqueda por Apellido Paterno o Nombre");
            ttMensaje.SetToolTip(btnGuardar, "Guardar nuevo Paciente");
            ttMensaje.SetToolTip(btnEditar, "Editar datos del Paciente");
            ttMensaje.SetToolTip(btnHistorial, "Historial Medico");
            ttMensaje.SetToolTip(btnEliminar, "Borrar Paciente");
            ttMensaje.SetToolTip(dtpFecNac, "Se puede agregar manualmente la fecha. Ejemplo : 10/03/2000 'Viernes 10 de Marzo del 2000.'");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conte.sApaterno = txtApaterno.Text.Trim();
            conte.sAmaterno = txtAmaterno.Text.Trim();
            conte.sNombre = txtNombre.Text.Trim();
            conte.sCurp = txtCurp.Text.Trim();
            conte.sTelefono = txtTelefono.Text.Trim();
            conte.sTelEmergencia = txtTelEmergencia.Text.Trim();
            conte.sNexpediente = txtNexpediente.Text.Trim();
            conte.sDerechohabiente = cbDerechohabiente.Text.Trim();
            conte.bActivo = true;

            if (rbMasculino.Checked == true)
            {
                conte.sSexo = "M";
            }
            else
            {
                conte.sSexo = "F";
            }

            conte.dtFecnac = Convert.ToDateTime(dtpFecNac.Text);
            conte.Guardar(conte);

            LlenarCuadricula();
            LimpiarCampos();
        }

        private void dgvDatos_DataSourceChanged(object sender, EventArgs e)
        {
            lblTotalRegistros.Text = "Total Pacientes: " + dgvDatos.Rows.Count.ToString();
        }

        public void LimpiarCampos(){
            txtApaterno.Clear();
            txtAmaterno.Clear();
            txtNombre.Clear();
            dtpFecNac.ResetText();
            txtCurp.Clear();
            txtTelefono.Clear();
            txtTelEmergencia.Clear();
            txtNexpediente.Clear();
            cbDerechohabiente.ResetText();
        }
      
    }
}
