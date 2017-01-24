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
    public partial class frmDoctores : Form
    {
        public frmDoctores()
        {
            InitializeComponent();
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
    }
}
