using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Gestion_Hospital1;

namespace Proyecto
{
    public partial class Medicina : Form
    {
        public Medicina()
        {
            InitializeComponent();
        }

        private void btndescargar_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));



            //string PaginaHTML_Texto = "<table border=\"1\"><tr><td>HOLA MUNDO</td></tr></table>";
            string PaginaHTML_Text = Gestion_Hospital1.Properties.Resources.Plantilla.ToString();
            PaginaHTML_Text = PaginaHTML_Text.Replace("@PACIENTE", txtnombres.Text);
            PaginaHTML_Text = PaginaHTML_Text.Replace("@PADECIMIENTO", txtpadecimiento.Text);
            PaginaHTML_Text = PaginaHTML_Text.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;
            decimal total = 0;
            foreach (DataGridViewRow row in dgvproductos.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Medicina"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Indicacion"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioUnitario"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Importe"].Value.ToString() + "</td>";
                filas += "</tr>";
                total += decimal.Parse(row.Cells["PrecioUnitario"].Value.ToString());
            }
            PaginaHTML_Text = PaginaHTML_Text.Replace("@FILAS", filas);
            PaginaHTML_Text = PaginaHTML_Text.Replace("@TOTAL", total.ToString());



            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    //Agregamos la imagen del banner al documento
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Gestion_Hospital1.Properties.Resources.c0663a45731ebd3ab9df75b9735d2337, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    //img.SetAbsolutePosition(10,100);
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);


                    //pdfDoc.Add(new Phrase("Hola Mundo"));
                    using (StringReader sr = new StringReader(PaginaHTML_Text))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvproductos.Columns.Add("Medicina", "Medicina");
            dgvproductos.Columns.Add("Indicacion", "Indicacion");
            dgvproductos.Columns.Add("PrecioUnitario", "Precio Unitario");
            dgvproductos.Columns.Add("Importe", "Importe");
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            int indice_fila = dgvproductos.Rows.Add();
            DataGridViewRow row = dgvproductos.Rows[indice_fila];

            row.Cells["Medicina"].Value = txtmedicina.Text;
            row.Cells["Indicacion"].Value = txtindicacion.Text;
            row.Cells["PrecioUnitario"].Value = txtprecio.Text;
            //row.Cells["Importe"].Value = decimal.Parse(txtcantidad.Text) * decimal.Parse(txtprecio.Text);
            row.Cells["Importe"].Value = decimal.Parse(txtprecio.Text);

        }

        private void atras_Click(object sender, EventArgs e)
        {
            categoria form4 = new categoria();
            form4.Show();
            this.Hide();
        }
    }
}