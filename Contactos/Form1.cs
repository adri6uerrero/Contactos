using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contactos
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> contactos = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAnadirContacto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string numero = txtNumero.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(numero))
            {
                MessageBox.Show("Por favor, ingresa el nombre y el número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (contactos.ContainsKey(nombre))
            {
                MessageBox.Show("El contacto ya existe. Usa el botón 'Actualizar' si deseas modificarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            contactos.Add(nombre, numero);
            ActualizarListaContactos();
            MessageBox.Show("Contacto añadido exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnActualizarContacto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string numero = txtNumero.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(numero))
            {
                MessageBox.Show("Por favor, ingresa el nombre y el nuevo número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (contactos.ContainsKey(nombre))
            {
                contactos[nombre] = numero;
                ActualizarListaContactos();
                MessageBox.Show($"El número de {nombre} ha sido actualizado a {numero}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El contacto no existe. Por favor, añádelo primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarContacto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor, ingresa el nombre del contacto a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (contactos.Remove(nombre))
            {
                ActualizarListaContactos();
                MessageBox.Show($"El contacto {nombre} ha sido eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El contacto no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarContacto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor, ingresa el nombre del contacto a buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (contactos.TryGetValue(nombre, out string numero))
            {
                MessageBox.Show($"Número de {nombre}: {numero}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El contacto no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarListaContactos()
        {
            lstContactos.Items.Clear();
            foreach (var contacto in contactos)
            {
                lstContactos.Items.Add($"{contacto.Key}: {contacto.Value}");
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
