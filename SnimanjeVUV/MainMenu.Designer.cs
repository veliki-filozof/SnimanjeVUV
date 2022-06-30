
namespace SnimanjeVUV
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.lblOdabirPorta = new System.Windows.Forms.Label();
            this.cboPortovi = new System.Windows.Forms.ComboBox();
            this.btnKonektujSe = new System.Windows.Forms.Button();
            this.btnNaProceduruMotor = new System.Windows.Forms.Button();
            this.btnNaProceduruSnimanje = new System.Windows.Forms.Button();
            this.lblOdaberiProceduru = new System.Windows.Forms.Label();
            this.btnOsveziPortove = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lblTip = new System.Windows.Forms.Label();
            this.rbImpulsni = new System.Windows.Forms.RadioButton();
            this.rbKontinualni = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblOdabirPorta
            // 
            this.lblOdabirPorta.AutoSize = true;
            this.lblOdabirPorta.Location = new System.Drawing.Point(12, 33);
            this.lblOdabirPorta.Name = "lblOdabirPorta";
            this.lblOdabirPorta.Size = new System.Drawing.Size(291, 17);
            this.lblOdabirPorta.TabIndex = 0;
            this.lblOdabirPorta.Text = "Odaberite port za komunikaciju sa Arduinom:";
            // 
            // cboPortovi
            // 
            this.cboPortovi.FormattingEnabled = true;
            this.cboPortovi.Location = new System.Drawing.Point(323, 26);
            this.cboPortovi.Name = "cboPortovi";
            this.cboPortovi.Size = new System.Drawing.Size(139, 24);
            this.cboPortovi.TabIndex = 1;
            // 
            // btnKonektujSe
            // 
            this.btnKonektujSe.Location = new System.Drawing.Point(323, 92);
            this.btnKonektujSe.Name = "btnKonektujSe";
            this.btnKonektujSe.Size = new System.Drawing.Size(139, 30);
            this.btnKonektujSe.TabIndex = 2;
            this.btnKonektujSe.Text = "Konektuj se";
            this.btnKonektujSe.UseVisualStyleBackColor = true;
            this.btnKonektujSe.Click += new System.EventHandler(this.btnKonektujSe_Click);
            // 
            // btnNaProceduruMotor
            // 
            this.btnNaProceduruMotor.Location = new System.Drawing.Point(15, 209);
            this.btnNaProceduruMotor.Name = "btnNaProceduruMotor";
            this.btnNaProceduruMotor.Size = new System.Drawing.Size(159, 38);
            this.btnNaProceduruMotor.TabIndex = 3;
            this.btnNaProceduruMotor.Text = "Podešavanje položaja";
            this.btnNaProceduruMotor.UseVisualStyleBackColor = true;
            this.btnNaProceduruMotor.Click += new System.EventHandler(this.btnNaProceduruMotor_Click);
            // 
            // btnNaProceduruSnimanje
            // 
            this.btnNaProceduruSnimanje.Location = new System.Drawing.Point(303, 209);
            this.btnNaProceduruSnimanje.Name = "btnNaProceduruSnimanje";
            this.btnNaProceduruSnimanje.Size = new System.Drawing.Size(159, 38);
            this.btnNaProceduruSnimanje.TabIndex = 4;
            this.btnNaProceduruSnimanje.Text = "Snimanje";
            this.btnNaProceduruSnimanje.UseVisualStyleBackColor = true;
            this.btnNaProceduruSnimanje.Click += new System.EventHandler(this.btnNaProceduruSnimanje_Click);
            // 
            // lblOdaberiProceduru
            // 
            this.lblOdaberiProceduru.AutoSize = true;
            this.lblOdaberiProceduru.Location = new System.Drawing.Point(12, 174);
            this.lblOdaberiProceduru.Name = "lblOdaberiProceduru";
            this.lblOdaberiProceduru.Size = new System.Drawing.Size(193, 17);
            this.lblOdaberiProceduru.TabIndex = 5;
            this.lblOdaberiProceduru.Text = "Odaberite željenu proceduru:";
            // 
            // btnOsveziPortove
            // 
            this.btnOsveziPortove.Location = new System.Drawing.Point(323, 56);
            this.btnOsveziPortove.Name = "btnOsveziPortove";
            this.btnOsveziPortove.Size = new System.Drawing.Size(139, 30);
            this.btnOsveziPortove.TabIndex = 6;
            this.btnOsveziPortove.Text = "Osveži portove";
            this.btnOsveziPortove.UseVisualStyleBackColor = true;
            this.btnOsveziPortove.Click += new System.EventHandler(this.btnOsveziPortove_Click);
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(12, 140);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(74, 17);
            this.lblTip.TabIndex = 7;
            this.lblTip.Text = "Tip izvora:";
            // 
            // rbImpulsni
            // 
            this.rbImpulsni.AutoSize = true;
            this.rbImpulsni.Location = new System.Drawing.Point(111, 138);
            this.rbImpulsni.Name = "rbImpulsni";
            this.rbImpulsni.Size = new System.Drawing.Size(80, 21);
            this.rbImpulsni.TabIndex = 8;
            this.rbImpulsni.TabStop = true;
            this.rbImpulsni.Text = "Impulsni";
            this.rbImpulsni.UseVisualStyleBackColor = true;
            // 
            // rbKontinualni
            // 
            this.rbKontinualni.AutoSize = true;
            this.rbKontinualni.Location = new System.Drawing.Point(209, 138);
            this.rbKontinualni.Name = "rbKontinualni";
            this.rbKontinualni.Size = new System.Drawing.Size(99, 21);
            this.rbKontinualni.TabIndex = 9;
            this.rbKontinualni.TabStop = true;
            this.rbKontinualni.Text = "Kontinualni";
            this.rbKontinualni.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 268);
            this.Controls.Add(this.rbKontinualni);
            this.Controls.Add(this.rbImpulsni);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.btnOsveziPortove);
            this.Controls.Add(this.lblOdaberiProceduru);
            this.Controls.Add(this.btnNaProceduruSnimanje);
            this.Controls.Add(this.btnNaProceduruMotor);
            this.Controls.Add(this.btnKonektujSe);
            this.Controls.Add(this.cboPortovi);
            this.Controls.Add(this.lblOdabirPorta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Snimanje VUV";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOdabirPorta;
        private System.Windows.Forms.ComboBox cboPortovi;
        private System.Windows.Forms.Button btnKonektujSe;
        private System.Windows.Forms.Button btnNaProceduruMotor;
        private System.Windows.Forms.Button btnNaProceduruSnimanje;
        private System.Windows.Forms.Label lblOdaberiProceduru;
        private System.Windows.Forms.Button btnOsveziPortove;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.RadioButton rbImpulsni;
        private System.Windows.Forms.RadioButton rbKontinualni;
    }
}

