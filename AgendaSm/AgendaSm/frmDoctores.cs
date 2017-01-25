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
    public partial class frmDoctores : Form
    {
        doctore ctx = new doctore();
        frmDoctores frmDoctore;
        public frmDoctores()
        {
            InitializeComponent();
            dgvDoctores.AutoGenerateColumns = false;
        }

        public frmDoctores( frmDoctores fDoctores)
        {
            InitializeComponent();
            this.frmDoctore = fDoctores;
        }
        public void LlenarCuadricula()
        {
            var datos = ctx.getAll(cbActivos.Checked);
            dgvDoctores.DataSource = datos;

            DateTime fecha = ctx.dtFecnac;



        }
        private void btnMenu_MouseHover(object sender, EventArgs e)
        {
            ttMensaje.IsBalloon = true;
            ttMensaje.SetToolTip(btnMenu, "Menú Principal");
            ttMensaje.SetToolTip(btnBuscar, "Buscar");
            ttMensaje.SetToolTip(btnNuevo, "Agregar Doctor");
            ttMensaje.SetToolTip(txtBusqueda, "Busqueda por Apellido Paterno o Nombre");
            ttMensaje.SetToolTip(dtpFecNac, "Se puede agregar manualmente la fecha. Ejemplo : 10/03/2000 'Viernes 10 de Marzo del 2000.'");
           
            ttMensaje.SetToolTip(btnGuardar, "Guardar nuevo Doctor");
            ttMensaje.SetToolTip(btnEditar, "Editar datos del Doctor");
            ttMensaje.SetToolTip(btnEliminar, "Borrar Doctor");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            gpDatos.Visible = true;
            gpHerramientas.Visible = true;

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gpHerramientas_Enter(object sender, EventArgs e)
        {

        }

        private void frmDoctores_Load(object sender, EventArgs e)
        {
            LlenarCuadricula();
            HorasEntradasYSalidas();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            ctx.sApaterno = txtApaterno.Text.Trim();
            ctx.sAmaterno = txtAmaterno.Text.Trim();
            ctx.sNombre = txtNombre.Text.Trim();
            ctx.sCurp = txtCurp.Text.Trim();
            ctx.sTelefono = txtTelefono.Text.Trim();
            ctx.sTelefono = txtTelefono.Text.Trim();
            ctx.sCedula = txtCedula.Text.Trim();
            //ctx.tHentrada = Convert.ToDouble(cbEntrada.Text);
            //ctx.tHsalida = Convert.ToDouble(cbSalida.Text);

            ctx.bStatus = true;

            if (rbMasculino.Checked == true)
            {
                ctx.sSexo = "M";
            }
            else
            {
                ctx.sSexo = "F";
            }

            ctx.dtFecnac = Convert.ToDateTime(dtpFecNac.Text);
            ctx.Guardar(ctx);

            LlenarCuadricula();
            LimpiarCampos();
        }

        private void HorasEntradasYSalidas()
        {

            cbEntrada.Items.Clear();
            cbSalida.Items.Clear();

            for (int minutes = 0; minutes < 1440; minutes += 30)
            {
                string hour = new DateTime().AddMinutes(minutes).ToString("HH:mm");
                cbEntrada.Items.Add(hour);
                cbSalida.Items.Add(hour);
            }
            cbEntrada.Text = "07:00";
            cbSalida.Text = "14:00";
        }
        public void LimpiarCampos()
        {
            txtApaterno.Clear();
            txtAmaterno.Clear();
            txtNombre.Clear();
            dtpFecNac.ResetText();
            txtCurp.Clear();
            rbFemenino.ResetText();
            rbMasculino.ResetText();
            txtTelefono.Clear();
            txtCedula.Clear();
            
        }
    }
}
