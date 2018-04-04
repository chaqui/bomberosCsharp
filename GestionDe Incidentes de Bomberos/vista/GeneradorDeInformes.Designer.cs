namespace GestionDe_Incidentes_de_Bomberos.vista
{
    partial class GeneradorDeInformes
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
            this.btGenerarInfome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoInforme = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaInicialGeneral = new System.Windows.Forms.MonthCalendar();
            this.fechaFinalGeneral = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.monthFechaFinalIncidente = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.monthFechaIncialIncidente = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTipoIncidente = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btGenerarInfome
            // 
            this.btGenerarInfome.Location = new System.Drawing.Point(615, 355);
            this.btGenerarInfome.Name = "btGenerarInfome";
            this.btGenerarInfome.Size = new System.Drawing.Size(134, 23);
            this.btGenerarInfome.TabIndex = 0;
            this.btGenerarInfome.Text = "Generar Informe ";
            this.btGenerarInfome.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo Informe";
            // 
            // cbTipoInforme
            // 
            this.cbTipoInforme.FormattingEnabled = true;
            this.cbTipoInforme.Location = new System.Drawing.Point(107, 41);
            this.cbTipoInforme.Name = "cbTipoInforme";
            this.cbTipoInforme.Size = new System.Drawing.Size(121, 21);
            this.cbTipoInforme.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fechaFinalGeneral);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fechaInicialGeneral);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(37, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 244);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha Inicial";
            // 
            // fechaInicialGeneral
            // 
            this.fechaInicialGeneral.Location = new System.Drawing.Point(90, 32);
            this.fechaInicialGeneral.Name = "fechaInicialGeneral";
            this.fechaInicialGeneral.TabIndex = 1;
            // 
            // fechaFinalGeneral
            // 
            this.fechaFinalGeneral.Location = new System.Drawing.Point(443, 32);
            this.fechaFinalGeneral.Name = "fechaFinalGeneral";
            this.fechaFinalGeneral.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Final";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTipoIncidente);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.monthFechaFinalIncidente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.monthFechaIncialIncidente);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(37, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(723, 244);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Incidente";
            // 
            // monthFechaFinalIncidente
            // 
            this.monthFechaFinalIncidente.Location = new System.Drawing.Point(443, 70);
            this.monthFechaFinalIncidente.Name = "monthFechaFinalIncidente";
            this.monthFechaFinalIncidente.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha Final";
            // 
            // monthFechaIncialIncidente
            // 
            this.monthFechaIncialIncidente.Location = new System.Drawing.Point(90, 70);
            this.monthFechaIncialIncidente.Name = "monthFechaIncialIncidente";
            this.monthFechaIncialIncidente.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fecha Inicial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tipo Incidente";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbTipoIncidente
            // 
            this.cbTipoIncidente.FormattingEnabled = true;
            this.cbTipoIncidente.Location = new System.Drawing.Point(111, 31);
            this.cbTipoIncidente.Name = "cbTipoIncidente";
            this.cbTipoIncidente.Size = new System.Drawing.Size(121, 21);
            this.cbTipoIncidente.TabIndex = 5;
            this.cbTipoIncidente.SelectedIndexChanged += new System.EventHandler(this.cbTipoIncidente_SelectedIndexChanged);
            // 
            // GeneradorDeInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 449);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbTipoInforme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btGenerarInfome);
            this.Name = "GeneradorDeInformes";
            this.Text = "GeneradorDeInformes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGenerarInfome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoInforme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar fechaFinalGeneral;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar fechaInicialGeneral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbTipoIncidente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MonthCalendar monthFechaFinalIncidente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar monthFechaIncialIncidente;
        private System.Windows.Forms.Label label5;
    }
}