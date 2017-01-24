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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            frmPacientes fPacientes = new frmPacientes();
            fPacientes.ShowDialog();
        }

        private void frmMenu_MouseHover(object sender, EventArgs e)
        {
            ttMensaje.IsBalloon = true;
            ttMensaje.SetToolTip(btnAgenda, "Agendar Cita");
            ttMensaje.SetToolTip(btnPaciente, "Lista de Pacientes");
            ttMensaje.SetToolTip(btnDoctores, "Lista de Doctores");
        }

        private void btnDoctores_Click(object sender, EventArgs e)
        {
            frmDoctores fDoctores = new frmDoctores();
            fDoctores.ShowDialog();
        }
    }
}
