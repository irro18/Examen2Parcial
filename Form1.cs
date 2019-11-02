using Examen2Parcial.Services;
using Examen2Parcial.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2Parcial
{
    public partial class Form1 : Form
    {
        private static UsuarioService _service;
        public Form1()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ToString();
            _service = new UsuarioService(connectionString);
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            usuario.nombre = addNombre.Text;
            usuario.correo = addCorreo.Text;
            usuario.ciudad = addCiudad.Text;
            usuario.contraseña = addContraseña.Text;

            try
            {
                ///ignore
            }
            catch
            {
                MessageBox.Show("Error en los datos.");
            }

            var result = _service.AddUsuario(usuario);
            addNombre.Text = "";
            addCorreo.Text = "";
            addCiudad.Text = "";
            addContraseña.Text = "";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var id = 0;
            try
            {
                id = Convert.ToInt32(deleteID.Text);
            }
            catch
            {
                //ignor
            }

            var result = _service.DeleteUsuario(id);
            MessageBox.Show(result);
            deleteID.Text = "";
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            var list = _service.GetUsuarios();
            dataGridView1.DataSource = list;
        }
    }
}
