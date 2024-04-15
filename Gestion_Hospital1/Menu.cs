using Proyecto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Hospital1
{
    public partial class categoria : Form
    {
        public categoria()
        {
            InitializeComponent();
        }

        private void Citas_Click(object sender, EventArgs e)
        {
            citas form2 = new citas();
            form2.Show();
            this.Hide();
        }

        private void Recetas_Click(object sender, EventArgs e)
        {
            Medicina form3 = new Medicina();
            form3.Show();
            this.Hide();
        }
    }
}
