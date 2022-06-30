
namespace SnimanjeVUV
{
    partial class SnimanjeDC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnimanjeDC));
            this.spArd = new System.IO.Ports.SerialPort(this.components);
            this.btnPromeniPod = new System.Windows.Forms.Button();
            this.btnZapamtiPod = new System.Windows.Forms.Button();
            this.cbMikrostep = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbRešetke = new System.Windows.Forms.GroupBox();
            this.rbReš3 = new System.Windows.Forms.RadioButton();
            this.rbReš2 = new System.Windows.Forms.RadioButton();
            this.rbReš1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbBrzina = new System.Windows.Forms.GroupBox();
            this.rbBrzo = new System.Windows.Forms.RadioButton();
            this.rbSrednje = new System.Windows.Forms.RadioButton();
            this.rbSporo = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tbKrajTalDužina = new System.Windows.Forms.TextBox();
            this.tbPočTalDužina = new System.Windows.Forms.TextBox();
            this.tbKrajPoložaj = new System.Windows.Forms.TextBox();
            this.tbPočPoložaj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbKorak = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbOsciloskop = new System.Windows.Forms.GroupBox();
            this.cbKanal = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnOsveziPortove = new System.Windows.Forms.Button();
            this.btnKonektujSe = new System.Windows.Forms.Button();
            this.cbOsciloskop = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnPokreni = new System.Windows.Forms.Button();
            this.btnNastavi = new System.Windows.Forms.Button();
            this.btnZaustavi = new System.Windows.Forms.Button();
            this.btnProračunaj = new System.Windows.Forms.Button();
            this.btnNađi = new System.Windows.Forms.Button();
            this.gbRešetke.SuspendLayout();
            this.gbBrzina.SuspendLayout();
            this.gbOsciloskop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPromeniPod
            // 
            this.btnPromeniPod.Location = new System.Drawing.Point(255, 105);
            this.btnPromeniPod.Name = "btnPromeniPod";
            this.btnPromeniPod.Size = new System.Drawing.Size(176, 38);
            this.btnPromeniPod.TabIndex = 29;
            this.btnPromeniPod.Text = "Promeni podešavanje";
            this.btnPromeniPod.UseVisualStyleBackColor = true;
            this.btnPromeniPod.Click += new System.EventHandler(this.btnPromeniPod_Click);
            // 
            // btnZapamtiPod
            // 
            this.btnZapamtiPod.Location = new System.Drawing.Point(469, 105);
            this.btnZapamtiPod.Name = "btnZapamtiPod";
            this.btnZapamtiPod.Size = new System.Drawing.Size(176, 38);
            this.btnZapamtiPod.TabIndex = 28;
            this.btnZapamtiPod.Text = "Zapamti podešavanje";
            this.btnZapamtiPod.UseVisualStyleBackColor = true;
            this.btnZapamtiPod.Click += new System.EventHandler(this.btnZapamtiPod_Click);
            // 
            // cbMikrostep
            // 
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
            this.cbMikrostep.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Broj stepova po obrtaju:";
            // 
            // gbRešetke
            // 
            this.gbRešetke.Controls.Add(this.rbReš3);
            this.gbRešetke.Controls.Add(this.rbReš2);
            this.gbRešetke.Controls.Add(this.rbReš1);
            this.gbRešetke.Location = new System.Drawing.Point(201, 12);
            this.gbRešetke.Name = "gbRešetke";
            this.gbRešetke.Size = new System.Drawing.Size(368, 41);
            this.gbRešetke.TabIndex = 25;
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
            this.rbReš1.Location = new System.Drawing.Point(6, 13);
            this.rbReš1.Name = "rbReš1";
            this.rbReš1.Size = new System.Drawing.Size(97, 21);
            this.rbReš1.TabIndex = 0;
            this.rbReš1.TabStop = true;
            this.rbReš1.Text = "10 - 50 nm";
            this.rbReš1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ugrađena rešetka:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(664, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 17);
            this.label9.TabIndex = 41;
            this.label9.Text = "nm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(664, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "nm";
            // 
            // gbBrzina
            // 
            this.gbBrzina.Controls.Add(this.rbBrzo);
            this.gbBrzina.Controls.Add(this.rbSrednje);
            this.gbBrzina.Controls.Add(this.rbSporo);
            this.gbBrzina.Location = new System.Drawing.Point(214, 296);
            this.gbBrzina.Name = "gbBrzina";
            this.gbBrzina.Size = new System.Drawing.Size(290, 41);
            this.gbBrzina.TabIndex = 39;
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
            this.label7.Location = new System.Drawing.Point(12, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Željena brzina skeniranja:";
            // 
            // tbKrajTalDužina
            // 
            this.tbKrajTalDužina.Location = new System.Drawing.Point(558, 222);
            this.tbKrajTalDužina.Name = "tbKrajTalDužina";
            this.tbKrajTalDužina.Size = new System.Drawing.Size(100, 22);
            this.tbKrajTalDužina.TabIndex = 37;
            // 
            // tbPočTalDužina
            // 
            this.tbPočTalDužina.Location = new System.Drawing.Point(558, 185);
            this.tbPočTalDužina.Name = "tbPočTalDužina";
            this.tbPočTalDužina.ReadOnly = true;
            this.tbPočTalDužina.Size = new System.Drawing.Size(100, 22);
            this.tbPočTalDužina.TabIndex = 36;
            // 
            // tbKrajPoložaj
            // 
            this.tbKrajPoložaj.Location = new System.Drawing.Point(214, 222);
            this.tbKrajPoložaj.Name = "tbKrajPoložaj";
            this.tbKrajPoložaj.ReadOnly = true;
            this.tbKrajPoložaj.Size = new System.Drawing.Size(100, 22);
            this.tbKrajPoložaj.TabIndex = 35;
            // 
            // tbPočPoložaj
            // 
            this.tbPočPoložaj.Location = new System.Drawing.Point(214, 185);
            this.tbPočPoložaj.Name = "tbPočPoložaj";
            this.tbPočPoložaj.Size = new System.Drawing.Size(100, 22);
            this.tbPočPoložaj.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Krajnja talasna dužina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Početna talasna dužina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Krajnji položaj rešetke:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Početni položaj rešetke:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(320, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 17);
            this.label10.TabIndex = 44;
            this.label10.Text = "nm";
            // 
            // tbKorak
            // 
            this.tbKorak.Location = new System.Drawing.Point(214, 268);
            this.tbKorak.Name = "tbKorak";
            this.tbKorak.Size = new System.Drawing.Size(100, 22);
            this.tbKorak.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 17);
            this.label11.TabIndex = 42;
            this.label11.Text = "Ekvidistantni korak:";
            // 
            // gbOsciloskop
            // 
            this.gbOsciloskop.Controls.Add(this.cbKanal);
            this.gbOsciloskop.Controls.Add(this.label15);
            this.gbOsciloskop.Controls.Add(this.btnOsveziPortove);
            this.gbOsciloskop.Controls.Add(this.btnKonektujSe);
            this.gbOsciloskop.Controls.Add(this.cbOsciloskop);
            this.gbOsciloskop.Controls.Add(this.label12);
            this.gbOsciloskop.Location = new System.Drawing.Point(715, 12);
            this.gbOsciloskop.Name = "gbOsciloskop";
            this.gbOsciloskop.Size = new System.Drawing.Size(309, 158);
            this.gbOsciloskop.TabIndex = 45;
            this.gbOsciloskop.TabStop = false;
            this.gbOsciloskop.Text = "Konekcija sa osciloskopom";
            // 
            // cbKanal
            // 
            this.cbKanal.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbKanal.FormattingEnabled = true;
            this.cbKanal.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbKanal.Location = new System.Drawing.Point(168, 68);
            this.cbKanal.Name = "cbKanal";
            this.cbKanal.Size = new System.Drawing.Size(121, 24);
            this.cbKanal.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 17);
            this.label15.TabIndex = 9;
            this.label15.Text = "Signal na kanalu:";
            // 
            // btnOsveziPortove
            // 
            this.btnOsveziPortove.Location = new System.Drawing.Point(18, 108);
            this.btnOsveziPortove.Name = "btnOsveziPortove";
            this.btnOsveziPortove.Size = new System.Drawing.Size(119, 30);
            this.btnOsveziPortove.TabIndex = 8;
            this.btnOsveziPortove.Text = "Osveži portove";
            this.btnOsveziPortove.UseVisualStyleBackColor = true;
            this.btnOsveziPortove.Click += new System.EventHandler(this.btnOsveziPortove_Click);
            // 
            // btnKonektujSe
            // 
            this.btnKonektujSe.Location = new System.Drawing.Point(170, 108);
            this.btnKonektujSe.Name = "btnKonektujSe";
            this.btnKonektujSe.Size = new System.Drawing.Size(119, 30);
            this.btnKonektujSe.TabIndex = 7;
            this.btnKonektujSe.Text = "Konektuj se";
            this.btnKonektujSe.UseVisualStyleBackColor = true;
            this.btnKonektujSe.Click += new System.EventHandler(this.btnKonektujSe_Click);
            // 
            // cbOsciloskop
            // 
            this.cbOsciloskop.FormattingEnabled = true;
            this.cbOsciloskop.Location = new System.Drawing.Point(168, 33);
            this.cbOsciloskop.Name = "cbOsciloskop";
            this.cbOsciloskop.Size = new System.Drawing.Size(121, 24);
            this.cbOsciloskop.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Port za osciloskop:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 356);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(188, 17);
            this.label13.TabIndex = 46;
            this.label13.Text = "Putanja za čuvanje snimaka:";
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(214, 353);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(377, 22);
            this.tbPath.TabIndex = 47;
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(715, 206);
            this.tbStatus.Multiline = true;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ReadOnly = true;
            this.tbStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbStatus.Size = new System.Drawing.Size(309, 346);
            this.tbStatus.TabIndex = 48;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(712, 186);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 17);
            this.label14.TabIndex = 49;
            this.label14.Text = "Status:";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(469, 400);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(176, 38);
            this.btnSpremi.TabIndex = 51;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnPokreni
            // 
            this.btnPokreni.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnPokreni.FlatAppearance.BorderSize = 10;
            this.btnPokreni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnPokreni.ForeColor = System.Drawing.Color.Green;
            this.btnPokreni.Location = new System.Drawing.Point(43, 470);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(176, 68);
            this.btnPokreni.TabIndex = 50;
            this.btnPokreni.Text = "POKRENI MERENJE";
            this.btnPokreni.UseVisualStyleBackColor = true;
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click);
            // 
            // btnNastavi
            // 
            this.btnNastavi.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnNastavi.FlatAppearance.BorderSize = 10;
            this.btnNastavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnNastavi.ForeColor = System.Drawing.Color.Orange;
            this.btnNastavi.Location = new System.Drawing.Point(255, 470);
            this.btnNastavi.Name = "btnNastavi";
            this.btnNastavi.Size = new System.Drawing.Size(176, 68);
            this.btnNastavi.TabIndex = 52;
            this.btnNastavi.Text = "NASTAVI MERENJE";
            this.btnNastavi.UseVisualStyleBackColor = true;
            // 
            // btnZaustavi
            // 
            this.btnZaustavi.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnZaustavi.FlatAppearance.BorderSize = 10;
            this.btnZaustavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnZaustavi.ForeColor = System.Drawing.Color.Red;
            this.btnZaustavi.Location = new System.Drawing.Point(470, 470);
            this.btnZaustavi.Name = "btnZaustavi";
            this.btnZaustavi.Size = new System.Drawing.Size(176, 68);
            this.btnZaustavi.TabIndex = 53;
            this.btnZaustavi.Text = "ZAUSTAVI MERENJE";
            this.btnZaustavi.UseVisualStyleBackColor = true;
            // 
            // btnProračunaj
            // 
            this.btnProračunaj.Location = new System.Drawing.Point(255, 400);
            this.btnProračunaj.Name = "btnProračunaj";
            this.btnProračunaj.Size = new System.Drawing.Size(176, 38);
            this.btnProračunaj.TabIndex = 54;
            this.btnProračunaj.Text = "Proračunaj";
            this.btnProračunaj.UseVisualStyleBackColor = true;
            this.btnProračunaj.Click += new System.EventHandler(this.btnProračunaj_Click);
            // 
            // btnNađi
            // 
            this.btnNađi.Location = new System.Drawing.Point(601, 349);
            this.btnNađi.Name = "btnNađi";
            this.btnNađi.Size = new System.Drawing.Size(90, 30);
            this.btnNađi.TabIndex = 55;
            this.btnNađi.Text = "Nađi...";
            this.btnNađi.UseVisualStyleBackColor = true;
            this.btnNađi.Click += new System.EventHandler(this.btnNađi_Click);
            // 
            // SnimanjeDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 564);
            this.Controls.Add(this.btnNađi);
            this.Controls.Add(this.btnProračunaj);
            this.Controls.Add(this.btnZaustavi);
            this.Controls.Add(this.btnNastavi);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnPokreni);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.gbOsciloskop);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbKorak);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbBrzina);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbKrajTalDužina);
            this.Controls.Add(this.tbPočTalDužina);
            this.Controls.Add(this.tbKrajPoložaj);
            this.Controls.Add(this.tbPočPoložaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPromeniPod);
            this.Controls.Add(this.btnZapamtiPod);
            this.Controls.Add(this.cbMikrostep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbRešetke);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SnimanjeDC";
            this.Text = "Snimanje - kontinualno";
            this.gbRešetke.ResumeLayout(false);
            this.gbRešetke.PerformLayout();
            this.gbBrzina.ResumeLayout(false);
            this.gbBrzina.PerformLayout();
            this.gbOsciloskop.ResumeLayout(false);
            this.gbOsciloskop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort spArd;
        private System.Windows.Forms.Button btnPromeniPod;
        private System.Windows.Forms.Button btnZapamtiPod;
        private System.Windows.Forms.ComboBox cbMikrostep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbRešetke;
        private System.Windows.Forms.RadioButton rbReš3;
        private System.Windows.Forms.RadioButton rbReš2;
        private System.Windows.Forms.RadioButton rbReš1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbBrzina;
        private System.Windows.Forms.RadioButton rbBrzo;
        private System.Windows.Forms.RadioButton rbSrednje;
        private System.Windows.Forms.RadioButton rbSporo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbKrajTalDužina;
        private System.Windows.Forms.TextBox tbPočTalDužina;
        private System.Windows.Forms.TextBox tbKrajPoložaj;
        private System.Windows.Forms.TextBox tbPočPoložaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbKorak;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbOsciloskop;
        private System.Windows.Forms.Button btnOsveziPortove;
        private System.Windows.Forms.Button btnKonektujSe;
        private System.Windows.Forms.ComboBox cbOsciloskop;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnPokreni;
        private System.Windows.Forms.Button btnNastavi;
        private System.Windows.Forms.Button btnZaustavi;
        private System.Windows.Forms.Button btnProračunaj;
        private System.Windows.Forms.ComboBox cbKanal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnNađi;
    }
}