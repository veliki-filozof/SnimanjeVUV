
namespace SnimanjeVUV
{
    partial class PomeranjeRešetke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PomeranjeRešetke));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbRešetke = new System.Windows.Forms.GroupBox();
            this.rbReš3 = new System.Windows.Forms.RadioButton();
            this.rbReš2 = new System.Windows.Forms.RadioButton();
            this.rbReš1 = new System.Windows.Forms.RadioButton();
            this.tbPočPoložaj = new System.Windows.Forms.TextBox();
            this.tbKrajPoložaj = new System.Windows.Forms.TextBox();
            this.tbKrajTalDužina = new System.Windows.Forms.TextBox();
            this.tbPočTalDužina = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMikrostep = new System.Windows.Forms.ComboBox();
            this.btnPokreni = new System.Windows.Forms.Button();
            this.gbBrzina = new System.Windows.Forms.GroupBox();
            this.rbBrzo = new System.Windows.Forms.RadioButton();
            this.rbSrednje = new System.Windows.Forms.RadioButton();
            this.rbSporo = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPodešavanje = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnProračunaj = new System.Windows.Forms.Button();
            this.btnPromeni = new System.Windows.Forms.Button();
            this.gbRešetke.SuspendLayout();
            this.gbBrzina.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Početni položaj rešetke:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Krajnji položaj rešetke:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Početna talasna dužina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Krajnja talasna dužina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ugrađena rešetka:";
            // 
            // gbRešetke
            // 
            this.gbRešetke.Controls.Add(this.rbReš3);
            this.gbRešetke.Controls.Add(this.rbReš2);
            this.gbRešetke.Controls.Add(this.rbReš1);
            this.gbRešetke.Location = new System.Drawing.Point(201, 12);
            this.gbRešetke.Name = "gbRešetke";
            this.gbRešetke.Size = new System.Drawing.Size(368, 41);
            this.gbRešetke.TabIndex = 9;
            this.gbRešetke.TabStop = false;
            // 
            // rbReš3
            // 
            this.rbReš3.AutoSize = true;
            this.rbReš3.Location = new System.Drawing.Point(251, 13);
            this.rbReš3.Name = "rbReš3";
            this.rbReš3.Size = new System.Drawing.Size(105, 21);
            this.rbReš3.TabIndex = 2;
            this.rbReš3.TabStop = true;
            this.rbReš3.Text = "50 - 300 nm";
            this.rbReš3.UseVisualStyleBackColor = true;
            // 
            // rbReš2
            // 
            this.rbReš2.AutoSize = true;
            this.rbReš2.Location = new System.Drawing.Point(125, 13);
            this.rbReš2.Name = "rbReš2";
            this.rbReš2.Size = new System.Drawing.Size(105, 21);
            this.rbReš2.TabIndex = 1;
            this.rbReš2.TabStop = true;
            this.rbReš2.Text = "15 - 150 nm";
            this.rbReš2.UseVisualStyleBackColor = true;
            // 
            // rbReš1
            // 
            this.rbReš1.AutoSize = true;
            this.rbReš1.Location = new System.Drawing.Point(7, 13);
            this.rbReš1.Name = "rbReš1";
            this.rbReš1.Size = new System.Drawing.Size(97, 21);
            this.rbReš1.TabIndex = 0;
            this.rbReš1.TabStop = true;
            this.rbReš1.Text = "10 - 50 nm";
            this.rbReš1.UseVisualStyleBackColor = true;
            // 
            // tbPočPoložaj
            // 
            this.tbPočPoložaj.Location = new System.Drawing.Point(201, 186);
            this.tbPočPoložaj.Name = "tbPočPoložaj";
            this.tbPočPoložaj.Size = new System.Drawing.Size(100, 22);
            this.tbPočPoložaj.TabIndex = 10;
            // 
            // tbKrajPoložaj
            // 
            this.tbKrajPoložaj.Location = new System.Drawing.Point(201, 223);
            this.tbKrajPoložaj.Name = "tbKrajPoložaj";
            this.tbKrajPoložaj.ReadOnly = true;
            this.tbKrajPoložaj.Size = new System.Drawing.Size(100, 22);
            this.tbKrajPoložaj.TabIndex = 11;
            // 
            // tbKrajTalDužina
            // 
            this.tbKrajTalDužina.Location = new System.Drawing.Point(545, 223);
            this.tbKrajTalDužina.Name = "tbKrajTalDužina";
            this.tbKrajTalDužina.Size = new System.Drawing.Size(100, 22);
            this.tbKrajTalDužina.TabIndex = 13;
            // 
            // tbPočTalDužina
            // 
            this.tbPočTalDužina.Location = new System.Drawing.Point(545, 186);
            this.tbPočTalDužina.Name = "tbPočTalDužina";
            this.tbPočTalDužina.ReadOnly = true;
            this.tbPočTalDužina.Size = new System.Drawing.Size(100, 22);
            this.tbPočTalDužina.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Broj stepova po obrtaju:";
            // 
            // cbMikrostep
            // 
            this.cbMikrostep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbMikrostep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMikrostep.FormattingEnabled = true;
            this.cbMikrostep.Items.AddRange(new object[] {
            "200",
            "400",
            "800",
            "1600",
            "3200",
            "6400"});
            this.cbMikrostep.Location = new System.Drawing.Point(201, 65);
            this.cbMikrostep.Name = "cbMikrostep";
            this.cbMikrostep.Size = new System.Drawing.Size(121, 24);
            this.cbMikrostep.TabIndex = 15;
            // 
            // btnPokreni
            // 
            this.btnPokreni.Location = new System.Drawing.Point(469, 315);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(176, 38);
            this.btnPokreni.TabIndex = 16;
            this.btnPokreni.Text = "Pokreni motor";
            this.btnPokreni.UseVisualStyleBackColor = true;
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click);
            // 
            // gbBrzina
            // 
            this.gbBrzina.Controls.Add(this.rbBrzo);
            this.gbBrzina.Controls.Add(this.rbSrednje);
            this.gbBrzina.Controls.Add(this.rbSporo);
            this.gbBrzina.Location = new System.Drawing.Point(201, 256);
            this.gbBrzina.Name = "gbBrzina";
            this.gbBrzina.Size = new System.Drawing.Size(290, 41);
            this.gbBrzina.TabIndex = 18;
            this.gbBrzina.TabStop = false;
            // 
            // rbBrzo
            // 
            this.rbBrzo.AutoSize = true;
            this.rbBrzo.Location = new System.Drawing.Point(221, 13);
            this.rbBrzo.Name = "rbBrzo";
            this.rbBrzo.Size = new System.Drawing.Size(58, 21);
            this.rbBrzo.TabIndex = 2;
            this.rbBrzo.TabStop = true;
            this.rbBrzo.Text = "Brzo";
            this.rbBrzo.UseVisualStyleBackColor = true;
            // 
            // rbSrednje
            // 
            this.rbSrednje.AutoSize = true;
            this.rbSrednje.Location = new System.Drawing.Point(110, 13);
            this.rbSrednje.Name = "rbSrednje";
            this.rbSrednje.Size = new System.Drawing.Size(78, 21);
            this.rbSrednje.TabIndex = 1;
            this.rbSrednje.TabStop = true;
            this.rbSrednje.Text = "Srednje";
            this.rbSrednje.UseVisualStyleBackColor = true;
            // 
            // rbSporo
            // 
            this.rbSporo.AutoSize = true;
            this.rbSporo.Location = new System.Drawing.Point(7, 13);
            this.rbSporo.Name = "rbSporo";
            this.rbSporo.Size = new System.Drawing.Size(67, 21);
            this.rbSporo.TabIndex = 0;
            this.rbSporo.TabStop = true;
            this.rbSporo.Text = "Sporo";
            this.rbSporo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Željena brzina skeniranja:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(651, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "nm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(651, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "nm";
            // 
            // btnPodešavanje
            // 
            this.btnPodešavanje.Location = new System.Drawing.Point(469, 105);
            this.btnPodešavanje.Name = "btnPodešavanje";
            this.btnPodešavanje.Size = new System.Drawing.Size(176, 38);
            this.btnPodešavanje.TabIndex = 21;
            this.btnPodešavanje.Text = "Zapamti podešavanje";
            this.btnPodešavanje.UseVisualStyleBackColor = true;
            this.btnPodešavanje.Click += new System.EventHandler(this.btnPodešavanje_Click);
            // 
            // btnProračunaj
            // 
            this.btnProračunaj.Location = new System.Drawing.Point(255, 315);
            this.btnProračunaj.Name = "btnProračunaj";
            this.btnProračunaj.Size = new System.Drawing.Size(176, 38);
            this.btnProračunaj.TabIndex = 22;
            this.btnProračunaj.Text = "Proračunaj";
            this.btnProračunaj.UseVisualStyleBackColor = true;
            this.btnProračunaj.Click += new System.EventHandler(this.btnProračunaj_Click);
            // 
            // btnPromeni
            // 
            this.btnPromeni.Location = new System.Drawing.Point(255, 105);
            this.btnPromeni.Name = "btnPromeni";
            this.btnPromeni.Size = new System.Drawing.Size(176, 38);
            this.btnPromeni.TabIndex = 23;
            this.btnPromeni.Text = "Promeni podešavanje";
            this.btnPromeni.UseVisualStyleBackColor = true;
            this.btnPromeni.Click += new System.EventHandler(this.btnPromeni_Click);
            // 
            // PomeranjeRešetke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 370);
            this.Controls.Add(this.btnPromeni);
            this.Controls.Add(this.btnProračunaj);
            this.Controls.Add(this.btnPodešavanje);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbBrzina);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPokreni);
            this.Controls.Add(this.cbMikrostep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbKrajTalDužina);
            this.Controls.Add(this.tbPočTalDužina);
            this.Controls.Add(this.tbKrajPoložaj);
            this.Controls.Add(this.tbPočPoložaj);
            this.Controls.Add(this.gbRešetke);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PomeranjeRešetke";
            this.Text = "Pomeranje rešetke";
            this.gbRešetke.ResumeLayout(false);
            this.gbRešetke.PerformLayout();
            this.gbBrzina.ResumeLayout(false);
            this.gbBrzina.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbRešetke;
        private System.Windows.Forms.RadioButton rbReš3;
        private System.Windows.Forms.RadioButton rbReš2;
        private System.Windows.Forms.RadioButton rbReš1;
        private System.Windows.Forms.TextBox tbPočPoložaj;
        private System.Windows.Forms.TextBox tbKrajPoložaj;
        private System.Windows.Forms.TextBox tbKrajTalDužina;
        private System.Windows.Forms.TextBox tbPočTalDužina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMikrostep;
        private System.Windows.Forms.Button btnPokreni;
        private System.Windows.Forms.GroupBox gbBrzina;
        private System.Windows.Forms.RadioButton rbBrzo;
        private System.Windows.Forms.RadioButton rbSrednje;
        private System.Windows.Forms.RadioButton rbSporo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPodešavanje;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnProračunaj;
        private System.Windows.Forms.Button btnPromeni;
    }
}