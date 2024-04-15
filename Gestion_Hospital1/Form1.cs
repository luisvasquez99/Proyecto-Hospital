using Gestion_Hospital1.Gestion_Hospital1;
using Newtonsoft.Json;
using Proyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Hospital1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if(txtuser.Text == "USUARIO")
            {
                txtuser.Text = "" ;
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.Black;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
               
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            // Obtener el nombre de usuario y la contraseña ingresados por el usuario
            string username = txtuser.Text;
            string password = txtpass.Text;

            // Leer los datos de usuario del archivo JSON
            List<Usuarios> usuarios = Json.ReadJSON<List<Usuarios>>("usuarios.json");

            // Verificar si el nombre de usuario y la contraseña coinciden con los datos del archivo JSON
            foreach (Usuarios usuario in usuarios)
            {
                if (usuario.Username == username && usuario.Password == password)
                {
                    MessageBox.Show("Inicio de sesión exitoso");
                   citas form2 = new citas();
                    form2.Show();
                    this.Hide();
                    return;
                }
            }

            // Si no se encuentra una coincidencia, mostrar un mensaje de error
            MessageBox.Show("Inicio de sesión fallido. Usuario o contraseña incorrectos.");

        }
        public static class Json
        {
            // Método para leer datos del archivo JSON
            public static T ReadJSON<T>(string filename)
            {
                string jsonData = File.ReadAllText(filename);
                return JsonConvert.DeserializeObject<T>(jsonData);
            }
        }

    }
}
