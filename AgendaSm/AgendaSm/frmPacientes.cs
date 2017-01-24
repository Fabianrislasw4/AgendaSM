using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaSm
{
    public partial class frmPacientes : Form
    {
        public frmPacientes()
        {
            InitializeComponent();
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
    }
}
