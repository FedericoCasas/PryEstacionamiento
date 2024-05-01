
namespace PryEstacionamiento
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPatente = new System.Windows.Forms.TextBox();
            this.LstTipo = new System.Windows.Forms.ComboBox();
            this.NudHoras = new System.Windows.Forms.NumericUpDown();
            this.MrcPiso = new System.Windows.Forms.GroupBox();
            this.OptSegundoPiso = new System.Windows.Forms.RadioButton();
            this.OptCuartoPiso = new System.Windows.Forms.RadioButton();
            this.OptTercerPiso = new System.Windows.Forms.RadioButton();
            this.OptPlantaBaja = new System.Windows.Forms.RadioButton();
            this.MrcTurno = new System.Windows.Forms.GroupBox();
            this.ChkTarde = new System.Windows.Forms.CheckBox();
            this.ChkNoche = new System.Windows.Forms.CheckBox();
            this.ChkMañana = new System.Windows.Forms.CheckBox();
            this.LblPagar = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NudHoras)).BeginInit();
            this.MrcPiso.SuspendLayout();
            this.MrcTurno.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(48, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(112, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "El Garage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese Patente ";
            // 
            // TxtPatente
            // 
            this.TxtPatente.Location = new System.Drawing.Point(138, 105);
            this.TxtPatente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtPatente.Name = "TxtPatente";
            this.TxtPatente.Size = new System.Drawing.Size(76, 20);
            this.TxtPatente.TabIndex = 2;
            // 
            // LstTipo
            // 
            this.LstTipo.FormattingEnabled = true;
            this.LstTipo.Items.AddRange(new object[] {
            "Auto",
            "Moto",
            "Camioneta",
            "Utilitarios"});
            this.LstTipo.Location = new System.Drawing.Point(228, 105);
            this.LstTipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LstTipo.Name = "LstTipo";
            this.LstTipo.Size = new System.Drawing.Size(88, 21);
            this.LstTipo.TabIndex = 3;
            // 
            // NudHoras
            // 
            this.NudHoras.Location = new System.Drawing.Point(335, 105);
            this.NudHoras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NudHoras.Name = "NudHoras";
            this.NudHoras.Size = new System.Drawing.Size(93, 20);
            this.NudHoras.TabIndex = 4;
            // 
            // MrcPiso
            // 
            this.MrcPiso.Controls.Add(this.OptSegundoPiso);
            this.MrcPiso.Controls.Add(this.OptCuartoPiso);
            this.MrcPiso.Controls.Add(this.OptTercerPiso);
            this.MrcPiso.Controls.Add(this.OptPlantaBaja);
            this.MrcPiso.Location = new System.Drawing.Point(29, 195);
            this.MrcPiso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MrcPiso.Name = "MrcPiso";
            this.MrcPiso.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MrcPiso.Size = new System.Drawing.Size(224, 114);
            this.MrcPiso.TabIndex = 5;
            this.MrcPiso.TabStop = false;
            this.MrcPiso.Text = "Piso";
            // 
            // OptSegundoPiso
            // 
            this.OptSegundoPiso.AutoSize = true;
            this.OptSegundoPiso.Location = new System.Drawing.Point(131, 33);
            this.OptSegundoPiso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OptSegundoPiso.Name = "OptSegundoPiso";
            this.OptSegundoPiso.Size = new System.Drawing.Size(91, 17);
            this.OptSegundoPiso.TabIndex = 3;
            this.OptSegundoPiso.TabStop = true;
            this.OptSegundoPiso.Text = "Segundo Piso";
            this.OptSegundoPiso.UseVisualStyleBackColor = true;
            this.OptSegundoPiso.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // OptCuartoPiso
            // 
            this.OptCuartoPiso.AutoSize = true;
            this.OptCuartoPiso.Location = new System.Drawing.Point(131, 70);
            this.OptCuartoPiso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OptCuartoPiso.Name = "OptCuartoPiso";
            this.OptCuartoPiso.Size = new System.Drawing.Size(79, 17);
            this.OptCuartoPiso.TabIndex = 2;
            this.OptCuartoPiso.TabStop = true;
            this.OptCuartoPiso.Text = "Cuarto Piso";
            this.OptCuartoPiso.UseVisualStyleBackColor = true;
            // 
            // OptTercerPiso
            // 
            this.OptTercerPiso.AutoSize = true;
            this.OptTercerPiso.Location = new System.Drawing.Point(22, 71);
            this.OptTercerPiso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OptTercerPiso.Name = "OptTercerPiso";
            this.OptTercerPiso.Size = new System.Drawing.Size(79, 17);
            this.OptTercerPiso.TabIndex = 1;
            this.OptTercerPiso.TabStop = true;
            this.OptTercerPiso.Text = "Tercer Piso";
            this.OptTercerPiso.UseVisualStyleBackColor = true;
            // 
            // OptPlantaBaja
            // 
            this.OptPlantaBaja.AutoSize = true;
            this.OptPlantaBaja.Location = new System.Drawing.Point(22, 33);
            this.OptPlantaBaja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OptPlantaBaja.Name = "OptPlantaBaja";
            this.OptPlantaBaja.Size = new System.Drawing.Size(79, 17);
            this.OptPlantaBaja.TabIndex = 0;
            this.OptPlantaBaja.TabStop = true;
            this.OptPlantaBaja.Text = "Planta Baja";
            this.OptPlantaBaja.UseVisualStyleBackColor = true;
            // 
            // MrcTurno
            // 
            this.MrcTurno.Controls.Add(this.ChkTarde);
            this.MrcTurno.Controls.Add(this.ChkNoche);
            this.MrcTurno.Controls.Add(this.ChkMañana);
            this.MrcTurno.Location = new System.Drawing.Point(269, 202);
            this.MrcTurno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MrcTurno.Name = "MrcTurno";
            this.MrcTurno.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MrcTurno.Size = new System.Drawing.Size(175, 106);
            this.MrcTurno.TabIndex = 6;
            this.MrcTurno.TabStop = false;
            this.MrcTurno.Text = "Turno";
            // 
            // ChkTarde
            // 
            this.ChkTarde.AutoSize = true;
            this.ChkTarde.Location = new System.Drawing.Point(97, 27);
            this.ChkTarde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChkTarde.Name = "ChkTarde";
            this.ChkTarde.Size = new System.Drawing.Size(54, 17);
            this.ChkTarde.TabIndex = 9;
            this.ChkTarde.Text = "Tarde";
            this.ChkTarde.UseVisualStyleBackColor = true;
            // 
            // ChkNoche
            // 
            this.ChkNoche.AutoSize = true;
            this.ChkNoche.Location = new System.Drawing.Point(4, 63);
            this.ChkNoche.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChkNoche.Name = "ChkNoche";
            this.ChkNoche.Size = new System.Drawing.Size(58, 17);
            this.ChkNoche.TabIndex = 8;
            this.ChkNoche.Text = "Noche";
            this.ChkNoche.UseVisualStyleBackColor = true;
            // 
            // ChkMañana
            // 
            this.ChkMañana.AutoSize = true;
            this.ChkMañana.Location = new System.Drawing.Point(4, 27);
            this.ChkMañana.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChkMañana.Name = "ChkMañana";
            this.ChkMañana.Size = new System.Drawing.Size(65, 17);
            this.ChkMañana.TabIndex = 7;
            this.ChkMañana.Text = "Mañana";
            this.ChkMañana.UseVisualStyleBackColor = true;
            // 
            // LblPagar
            // 
            this.LblPagar.AutoSize = true;
            this.LblPagar.Location = new System.Drawing.Point(158, 343);
            this.LblPagar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPagar.Name = "LblPagar";
            this.LblPagar.Size = new System.Drawing.Size(72, 13);
            this.LblPagar.TabIndex = 7;
            this.LblPagar.Text = "Usted Pagara";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblTotal.Location = new System.Drawing.Point(242, 343);
            this.LblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(34, 13);
            this.LblTotal.TabIndex = 8;
            this.LblTotal.Text = ".........";
            this.LblTotal.Click += new System.EventHandler(this.LblTotal_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(160, 387);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "SALIDA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(494, 497);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblPagar);
            this.Controls.Add(this.MrcTurno);
            this.Controls.Add(this.MrcPiso);
            this.Controls.Add(this.NudHoras);
            this.Controls.Add(this.LstTipo);
            this.Controls.Add(this.TxtPatente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "PLAYA Estacionamiento (Talleres)";
            ((System.ComponentModel.ISupportInitialize)(this.NudHoras)).EndInit();
            this.MrcPiso.ResumeLayout(false);
            this.MrcPiso.PerformLayout();
            this.MrcTurno.ResumeLayout(false);
            this.MrcTurno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPatente;
        private System.Windows.Forms.ComboBox LstTipo;
        private System.Windows.Forms.NumericUpDown NudHoras;
        private System.Windows.Forms.GroupBox MrcPiso;
        private System.Windows.Forms.RadioButton OptSegundoPiso;
        private System.Windows.Forms.RadioButton OptCuartoPiso;
        private System.Windows.Forms.RadioButton OptTercerPiso;
        private System.Windows.Forms.RadioButton OptPlantaBaja;
        private System.Windows.Forms.GroupBox MrcTurno;
        private System.Windows.Forms.CheckBox ChkTarde;
        private System.Windows.Forms.CheckBox ChkNoche;
        private System.Windows.Forms.CheckBox ChkMañana;
        private System.Windows.Forms.Label LblPagar;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Button button1;
    }
}

