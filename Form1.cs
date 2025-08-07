using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaContactosWinForms
{
    public partial class Form1 : Form
    {
        private ListaEnlazadaAgenda agenda = new ListaEnlazadaAgenda();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var contacto = new Contacto(txtNombre.Text, txtTelefono.Text, txtCorreo.Text);
            agenda.AgregarContacto(contacto);
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool eliminado = agenda.EliminarContacto(txtNombre.Text);
            MessageBox.Show(eliminado ? "Contacto eliminado." : "Contacto no encontrado.");
            LimpiarCampos();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lstContactos.Items.Clear();
            var contactos = agenda.ObtenerContactos();
            foreach (var c in contactos)
            {
                lstContactos.Items.Add(c.ToString());
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
        }
    }
}
