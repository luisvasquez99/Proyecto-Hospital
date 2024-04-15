using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Hospital1;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.IO;

namespace Gestion_Hospital1
{
    class Program
    {
        static void Main()
        {
            // Creamos una lista de Usuarios
            List<Usuarios> usuarios = new List<Usuarios>
            {
                new Usuarios { Username = "cpleitez", Password = "password" },
                new Usuarios { Username = "lvazquez", Password = "password" },
                new Usuarios { Username = "sgodoy", Password = "password" },
                new Usuarios { Username = "rguinea", Password = "password" },
                new Usuarios { Username = "lmunguia", Password = "password" },
                new Usuarios { Username = "esandoval", Password = "password" },
                // Agrega más usuarios si es necesario
            };

            // Convertimos la lista de Usuarios a formato JSON
            string jsonData = JsonConvert.SerializeObject(usuarios);

            // Escribimos el JSON en un archivo
            File.WriteAllText("usuarios.json", jsonData);

            // Iniciamos la aplicación
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    // Clase para manejar la escritura y lectura del archivo JSON
    public class Json
    {
        // Método para escribir datos en el archivo JSON
        public static void WriteJSON(string filename, object data)
        {
            string jsonData = JsonConvert.SerializeObject(data);
            File.WriteAllText(filename, jsonData);
        }

        // Método para leer datos del archivo JSON como un arreglo de Usuarios
        public static List<Usuarios> ReadJSON(string filename)
        {
            string jsonData = File.ReadAllText(filename);
            return JsonConvert.DeserializeObject<List<Usuarios>>(jsonData);
        }
    }
}

