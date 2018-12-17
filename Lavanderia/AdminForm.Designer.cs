namespace Lavanderia
{
    partial class AdminForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFecha_dia = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnElimNota = new System.Windows.Forms.Button();
            this.bntRegresar = new System.Windows.Forms.Button();
            this.bntVerNotas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnEliminarRegistro = new System.Windows.Forms.Button();
            this.bntBuscarRegistro = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(105)))), ((int)(((byte)(116)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblFecha_dia);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Location = new System.Drawing.Point(-21, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 104);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(130, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 39);
            this.label1.TabIndex = 16;
            this.label1.Text = "CONTROL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lblFecha_dia
            // 
            this.lblFecha_dia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha_dia.AutoSize = true;
            this.lblFecha_dia.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha_dia.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFecha_dia.Location = new System.Drawing.Point(437, 72);
            this.lblFecha_dia.Name = "lblFecha_dia";
            this.lblFecha_dia.Size = new System.Drawing.Size(287, 22);
            this.lblFecha_dia.TabIndex = 14;
            this.lblFecha_dia.Text = "Miércoles, 13 de Septiembre de 2018";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Open Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHora.Location = new System.Drawing.Point(430, 10);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(328, 65);
            this.lblHora.TabIndex = 13;
            this.lblHora.Text = "00:00:00 p.m.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(214)))), ((int)(((byte)(205)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnElimNota);
            this.panel2.Controls.Add(this.bntRegresar);
            this.panel2.Controls.Add(this.bntVerNotas);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.btnEliminarRegistro);
            this.panel2.Controls.Add(this.bntBuscarRegistro);
            this.panel2.Location = new System.Drawing.Point(-4, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(951, 444);
            this.panel2.TabIndex = 1;
            // 
            // btnElimNota
            // 
            this.btnElimNota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnElimNota.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnElimNota.Location = new System.Drawing.Point(298, 377);
            this.btnElimNota.Name = "btnElimNota";
            this.btnElimNota.Size = new System.Drawing.Size(125, 45);
            this.btnElimNota.TabIndex = 10;
            this.btnElimNota.Text = "ELIMINAR NOTA";
            this.btnElimNota.UseVisualStyleBackColor = false;
            this.btnElimNota.Click += new System.EventHandler(this.btnElimNota_Click);
            // 
            // bntRegresar
            // 
            this.bntRegresar.BackColor = System.Drawing.Color.Red;
            this.bntRegresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.bntRegresar.FlatAppearance.BorderSize = 0;
            this.bntRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntRegresar.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntRegresar.Location = new System.Drawing.Point(626, 31);
            this.bntRegresar.Name = "bntRegresar";
            this.bntRegresar.Size = new System.Drawing.Size(125, 29);
            this.bntRegresar.TabIndex = 8;
            this.bntRegresar.Text = "REGRESAR";
            this.bntRegresar.UseVisualStyleBackColor = false;
            this.bntRegresar.Click += new System.EventHandler(this.bntRegresar_Click);
            // 
            // bntVerNotas
            // 
            this.bntVerNotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(84)))), ((int)(((byte)(125)))));
            this.bntVerNotas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.bntVerNotas.FlatAppearance.BorderSize = 0;
            this.bntVerNotas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntVerNotas.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntVerNotas.Location = new System.Drawing.Point(460, 31);
            this.bntVerNotas.Name = "bntVerNotas";
            this.bntVerNotas.Size = new System.Drawing.Size(125, 29);
            this.bntVerNotas.TabIndex = 7;
            this.bntVerNotas.Text = "VER NOTAS";
            this.bntVerNotas.UseVisualStyleBackColor = false;
            this.bntVerNotas.Click += new System.EventHandler(this.bntVerNotas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Elija la fecha";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(214)))), ((int)(((byte)(205)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(46, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(769, 254);
            this.dataGridView1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(46, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(202, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // btnEliminarRegistro
            // 
            this.btnEliminarRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnEliminarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarRegistro.Location = new System.Drawing.Point(469, 377);
            this.btnEliminarRegistro.Name = "btnEliminarRegistro";
            this.btnEliminarRegistro.Size = new System.Drawing.Size(125, 45);
            this.btnEliminarRegistro.TabIndex = 3;
            this.btnEliminarRegistro.Text = "ELIMINAR REGISTRO";
            this.btnEliminarRegistro.UseVisualStyleBackColor = false;
            this.btnEliminarRegistro.Click += new System.EventHandler(this.btnEliminarRegistro_Click);
            // 
            // bntBuscarRegistro
            // 
            this.bntBuscarRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(189)))), ((int)(((byte)(141)))));
            this.bntBuscarRegistro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.bntBuscarRegistro.FlatAppearance.BorderSize = 0;
            this.bntBuscarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntBuscarRegistro.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntBuscarRegistro.Location = new System.Drawing.Point(301, 31);
            this.bntBuscarRegistro.Name = "bntBuscarRegistro";
            this.bntBuscarRegistro.Size = new System.Drawing.Size(122, 29);
            this.bntBuscarRegistro.TabIndex = 2;
            this.bntBuscarRegistro.Text = "VER REGISTROS";
            this.bntBuscarRegistro.UseVisualStyleBackColor = false;
            this.bntBuscarRegistro.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(580, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "*Recuerda seleccionar la fecha y presionar los botones según lo que quieras visua" +
    "lizar";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(842, 537);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFecha_dia;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarRegistro;
        private System.Windows.Forms.Button bntBuscarRegistro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button bntVerNotas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bntRegresar;
        private System.Windows.Forms.Button btnElimNota;
        private System.Windows.Forms.Label label7;
    }
}

