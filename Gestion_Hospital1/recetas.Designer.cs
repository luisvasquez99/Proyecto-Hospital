namespace Proyecto
{
    partial class Medicina
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicina));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.txtmedicina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpadecimiento = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvproductos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtindicacion = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btndescargar = new System.Windows.Forms.Button();
            this.atras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 95;
            this.label1.Text = "Paciente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 98;
            this.label2.Text = "Padecimiento";
            // 
            // txtnombres
            // 
            this.txtnombres.Location = new System.Drawing.Point(70, 41);
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(144, 20);
            this.txtnombres.TabIndex = 96;
            // 
            // txtmedicina
            // 
            this.txtmedicina.Location = new System.Drawing.Point(68, 79);
            this.txtmedicina.Name = "txtmedicina";
            this.txtmedicina.Size = new System.Drawing.Size(144, 20);
            this.txtmedicina.TabIndex = 102;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 100;
            this.label4.Text = "Medicina";
            // 
            // txtpadecimiento
            // 
            this.txtpadecimiento.Location = new System.Drawing.Point(325, 41);
            this.txtpadecimiento.Name = "txtpadecimiento";
            this.txtpadecimiento.Size = new System.Drawing.Size(144, 20);
            this.txtpadecimiento.TabIndex = 97;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(325, 78);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(47, 20);
            this.txtprecio.TabIndex = 103;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 101;
            this.label5.Text = "Precio $:";
            // 
            // dgvproductos
            // 
            this.dgvproductos.AllowUserToAddRows = false;
            this.dgvproductos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvproductos.ColumnHeadersHeight = 30;
            this.dgvproductos.EnableHeadersVisualStyles = false;
            this.dgvproductos.GridColor = System.Drawing.Color.DimGray;
            this.dgvproductos.Location = new System.Drawing.Point(14, 167);
            this.dgvproductos.MultiSelect = false;
            this.dgvproductos.Name = "dgvproductos";
            this.dgvproductos.ReadOnly = true;
            this.dgvproductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvproductos.RowHeadersWidth = 51;
            this.dgvproductos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvproductos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvproductos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvproductos.RowTemplate.Height = 30;
            this.dgvproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvproductos.Size = new System.Drawing.Size(477, 248);
            this.dgvproductos.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 93;
            this.label3.Text = "Indicacion";
            // 
            // txtindicacion
            // 
            this.txtindicacion.Location = new System.Drawing.Point(70, 123);
            this.txtindicacion.Name = "txtindicacion";
            this.txtindicacion.Size = new System.Drawing.Size(139, 20);
            this.txtindicacion.TabIndex = 99;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnagregar.ForeColor = System.Drawing.Color.White;
            this.btnagregar.Location = new System.Drawing.Point(388, 423);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(101, 25);
            this.btnagregar.TabIndex = 105;
            this.btnagregar.Text = "Generar Receta";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btndescargar
            // 
            this.btndescargar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btndescargar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndescargar.ForeColor = System.Drawing.Color.White;
            this.btndescargar.Location = new System.Drawing.Point(192, 421);
            this.btndescargar.Name = "btndescargar";
            this.btndescargar.Size = new System.Drawing.Size(131, 27);
            this.btndescargar.TabIndex = 104;
            this.btndescargar.Text = "Terminar e Imprimir";
            this.btndescargar.UseVisualStyleBackColor = false;
            this.btndescargar.Click += new System.EventHandler(this.btndescargar_Click);
            // 
            // atras
            // 
            this.atras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("atras.BackgroundImage")));
            this.atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.atras.Location = new System.Drawing.Point(451, 3);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(38, 32);
            this.atras.TabIndex = 146;
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // Medicina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btndescargar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnombres);
            this.Controls.Add(this.txtmedicina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpadecimiento);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvproductos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtindicacion);
            this.Name = "Medicina";
            this.Text = "recetas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.TextBox txtmedicina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpadecimiento;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvproductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtindicacion;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btndescargar;
        private System.Windows.Forms.Button atras;
    }
}