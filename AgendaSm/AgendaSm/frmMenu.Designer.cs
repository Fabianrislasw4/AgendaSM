namespace AgendaSm
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnDoctores = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDoctores
            // 
            this.btnDoctores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDoctores.BackColor = System.Drawing.Color.Transparent;
            this.btnDoctores.BackgroundImage = global::AgendaSm.Properties.Resources.doctor;
            this.btnDoctores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDoctores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoctores.FlatAppearance.BorderSize = 0;
            this.btnDoctores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctores.Location = new System.Drawing.Point(418, 140);
            this.btnDoctores.Name = "btnDoctores";
            this.btnDoctores.Size = new System.Drawing.Size(160, 140);
            this.btnDoctores.TabIndex = 1;
            this.btnDoctores.UseVisualStyleBackColor = false;
            this.btnDoctores.Click += new System.EventHandler(this.btnDoctores_Click);
            this.btnDoctores.MouseHover += new System.EventHandler(this.frmMenu_MouseHover);
            // 
            // btnPaciente
            // 
            this.btnPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPaciente.BackColor = System.Drawing.Color.Transparent;
            this.btnPaciente.BackgroundImage = global::AgendaSm.Properties.Resources.historial;
            this.btnPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaciente.FlatAppearance.BorderSize = 0;
            this.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaciente.Location = new System.Drawing.Point(220, 140);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(160, 140);
            this.btnPaciente.TabIndex = 2;
            this.btnPaciente.UseVisualStyleBackColor = false;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            this.btnPaciente.MouseHover += new System.EventHandler(this.frmMenu_MouseHover);
            // 
            // btnAgenda
            // 
            this.btnAgenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgenda.BackColor = System.Drawing.Color.Transparent;
            this.btnAgenda.BackgroundImage = global::AgendaSm.Properties.Resources.agenda;
            this.btnAgenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgenda.FlatAppearance.BorderSize = 0;
            this.btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgenda.Location = new System.Drawing.Point(22, 140);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(160, 140);
            this.btnAgenda.TabIndex = 3;
            this.btnAgenda.UseVisualStyleBackColor = false;
            this.btnAgenda.MouseHover += new System.EventHandler(this.frmMenu_MouseHover);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Prueba Editar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 421);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDoctores);
            this.Controls.Add(this.btnPaciente);
            this.Controls.Add(this.btnAgenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.Text = "Salud Mental - Menú";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseHover += new System.EventHandler(this.frmMenu_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDoctores;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.Button button1;
    }
}