namespace Lavanderia
{
    partial class Empleados
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFecha_dia = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bntRegresar = new System.Windows.Forms.Button();
            this.btnAgregarNota = new System.Windows.Forms.Button();
            this.btnGenerarRegisto = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.lblFecha_dia);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 99);
            this.panel1.TabIndex = 0;
            // 
            // lblFecha_dia
            // 
            this.lblFecha_dia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha_dia.AutoSize = true;
            this.lblFecha_dia.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha_dia.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFecha_dia.Location = new System.Drawing.Point(90, 65);
            this.lblFecha_dia.Name = "lblFecha_dia";
            this.lblFecha_dia.Size = new System.Drawing.Size(287, 22);
            this.lblFecha_dia.TabIndex = 15;
            this.lblFecha_dia.Text = "Miércoles, 13 de Septiembre de 2018";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Open Sans", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHora.Location = new System.Drawing.Point(83, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(328, 65);
            this.lblHora.TabIndex = 14;
            this.lblHora.Text = "00:00:00 p.m.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel2.Controls.Add(this.bntRegresar);
            this.panel2.Controls.Add(this.btnAgregarNota);
            this.panel2.Controls.Add(this.btnGenerarRegisto);
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 237);
            this.panel2.TabIndex = 1;
            // 
            // bntRegresar
            // 
            this.bntRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.bntRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntRegresar.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntRegresar.Location = new System.Drawing.Point(189, 186);
            this.bntRegresar.Name = "bntRegresar";
            this.bntRegresar.Size = new System.Drawing.Size(125, 39);
            this.bntRegresar.TabIndex = 2;
            this.bntRegresar.Text = "REGRESAR";
            this.bntRegresar.UseVisualStyleBackColor = false;
            this.bntRegresar.Click += new System.EventHandler(this.bntRegresar_Click);
            // 
            // btnAgregarNota
            // 
            this.btnAgregarNota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(147)))), ((int)(((byte)(176)))));
            this.btnAgregarNota.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarNota.Font = new System.Drawing.Font("Open Sans", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarNota.Location = new System.Drawing.Point(35, 57);
            this.btnAgregarNota.Name = "btnAgregarNota";
            this.btnAgregarNota.Size = new System.Drawing.Size(192, 89);
            this.btnAgregarNota.TabIndex = 1;
            this.btnAgregarNota.Text = "AGREGAR NOTA";
            this.btnAgregarNota.UseVisualStyleBackColor = false;
            this.btnAgregarNota.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGenerarRegisto
            // 
            this.btnGenerarRegisto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(146)))), ((int)(((byte)(26)))));
            this.btnGenerarRegisto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerarRegisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarRegisto.Location = new System.Drawing.Point(271, 57);
            this.btnGenerarRegisto.Name = "btnGenerarRegisto";
            this.btnGenerarRegisto.Size = new System.Drawing.Size(193, 89);
            this.btnGenerarRegisto.TabIndex = 0;
            this.btnGenerarRegisto.Text = "GENERAR REGISTRO";
            this.btnGenerarRegisto.UseVisualStyleBackColor = false;
            this.btnGenerarRegisto.Click += new System.EventHandler(this.btnGenerarRegisto_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 331);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha_dia;
        private System.Windows.Forms.Button btnAgregarNota;
        private System.Windows.Forms.Button btnGenerarRegisto;
        private System.Windows.Forms.Button bntRegresar;
        private System.Windows.Forms.Timer timer1;
    }
}