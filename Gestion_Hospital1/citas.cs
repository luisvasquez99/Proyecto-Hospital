using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
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
    public partial class citas : Form
    {
        public citas()
        {
            InitializeComponent();
        }
        private void btndescargar3_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));



            //string PaginaHTML_Texto = "<table border=\"1\"><tr><td>HOLA MUNDO</td></tr></table>";
            string PaginaHTML_Texto1 = Properties.Resources.Plantilla2.ToString();
            PaginaHTML_Texto1 = PaginaHTML_Texto1.Replace("@MEDICO", txtnombremedico.Text);
            PaginaHTML_Texto1 = PaginaHTML_Texto1.Replace("@CLINICA", txtclinica.Text);
            PaginaHTML_Texto1 = PaginaHTML_Texto1.Replace("@FECHA1", DateTime.Now.ToString("dd/MM/yyyy"));
            PaginaHTML_Texto1 = PaginaHTML_Texto1.Replace("@REF", textrefe.Text);
            PaginaHTML_Texto1 = PaginaHTML_Texto1.Replace("@FECHAR", txtrecep.Text);
            PaginaHTML_Texto1 = PaginaHTML_Texto1.Replace("@PAC", txtnombrepas.Text);
            PaginaHTML_Texto1 = PaginaHTML_Texto1.Replace("@EDAD", txtedad.Text);
            PaginaHTML_Texto1 = PaginaHTML_Texto1.Replace("@IND", txtindicacion.Text);
            PaginaHTML_Texto1 = PaginaHTML_Texto1.Replace("@TEL", txtel.Text);


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
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.c0663a45731ebd3ab9df75b9735d2337, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    //img.SetAbsolutePosition(10,100);
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);


                    //pdfDoc.Add(new Phrase("Hola Mundo"));
                    using (StringReader sr = new StringReader(PaginaHTML_Texto1))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }






            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           categoria form4 = new categoria();
            form4.Show();
            this.Hide();
        }
    }
}
    