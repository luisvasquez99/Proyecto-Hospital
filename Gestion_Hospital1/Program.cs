using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Hospital1;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Gestion_Hospital1
{
    class Program
    {
        static void Main()
        {
            Usuarios usuarios = new Usuarios
            {
                Username = "cpleitez",
                Password = "password",

            };


            string datos = JsonConvert.SerializeObject(usuarios);

            Console.WriteLine(datos);
            

           
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
