using System;
using System.Collections;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using TekVISANet;

namespace SnimanjeVUV
{
    public partial class SnimanjeDC : Form
    {
        private VISA tekVISA; // testirati da li ovakva deklaracija radi
        private ArrayList resources;
        private FolderBrowserDialog folderBrowserDialog1;
        private string[] oscports;
        private bool oscon;
        private int brReš;
        private int brMikrostep;
        private int kanal;
        private double počPol;
        private double počTald;
        private double krPol;
        private double krTald;
        private double korak;
        private string path;


        public SnimanjeDC()
        {
            InitializeComponent();

            tekVISA = new VISA();
            resources = new ArrayList();
            gbOsciloskop.Enabled = true;
            cbOsciloskop.Enabled = false;
            btnOsveziPortove.Enabled = true;
            btnKonektujSe.Enabled = false;
            cbKanal.Enabled = false;
            oscon = false;

            DisableButtons();
            DisableMid();
            EnableUpper();
            btnPromeniPod.Enabled = false;
            rbReš3.Checked = true;
            cbMikrostep.SelectedIndex = 0;
            rbBrzo.Checked = true;

            tbStatus.Text = "Unesite podešavanja i povežite osciloskop..." + Environment.NewLine + Environment.NewLine;
        }

        public void setSerialPort(SerialPort port)
        {
            spArd = port;
        }

        private void DisableButtons()
        {
            btnPokreni.Enabled = false;
            btnZaustavi.Enabled = false;
            btnNastavi.Enabled = false;
        }
       
        private void DisableUpper()
        {
            gbRešetke.Enabled = false;
            cbMikrostep.Enabled = false;
            btnZapamtiPod.Enabled = false;
            btnPromeniPod.Enabled = false;
        }

        private void EnableUpper()
        {
            gbRešetke.Enabled = true;
            cbMikrostep.Enabled = true;
            btnZapamtiPod.Enabled = true;
            btnPromeniPod.Enabled = true;
        }

        private void DisableMid()
        {
            tbPočPoložaj.Enabled = false;
            tbPočTalDužina.Enabled = false;
            tbKrajPoložaj.Enabled = false;
            tbKrajTalDužina.Enabled = false;
            tbKorak.Enabled = false;
            gbBrzina.Enabled = false;
            tbPath.Enabled = false;
            btnSpremi.Enabled = false;
            btnProračunaj.Enabled = false;
            btnNađi.Enabled = false;
        }

        private void EnableMid()
        {
            tbPočPoložaj.Enabled = true;
            tbPočTalDužina.Enabled = true;
            tbKrajPoložaj.Enabled = true;
            tbKrajTalDužina.Enabled = true;
            tbKorak.Enabled = true;
            gbBrzina.Enabled = true;
            tbPath.Enabled = true;
            btnSpremi.Enabled = false;
            btnProračunaj.Enabled = true;
            btnNađi.Enabled = true;
        }

        private void onOscRefresh()
        {
            try
            {
                resources.Clear();
                tekVISA.FindResources("?*", out resources);
                if (resources.Count > 0)
                {
                    cbOsciloskop.Items.Clear();
                    oscports = (string[])resources.ToArray(typeof(string));
                    cbOsciloskop.Items.AddRange(oscports);
                    cbOsciloskop.SelectedIndex = 0;
                    cbKanal.SelectedIndex = 0;

                    cbOsciloskop.Enabled = true;
                    btnOsveziPortove.Enabled = true;
                    btnKonektujSe.Enabled = true;
                    cbKanal.Enabled = true;
                }
                else
                {
                    cbOsciloskop.Enabled = false;
                    btnOsveziPortove.Enabled = true;
                    btnKonektujSe.Enabled = false;
                    cbKanal.Enabled = false;
                    
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ne postoje dostupni osciloskopi!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            }
        }

        private void btnOsveziPortove_Click(object sender, EventArgs e)
        {
            onOscRefresh();
        }

        private void btnKonektujSe_Click(object sender, EventArgs e)
        {
            try
            {
                tekVISA.Open(cbOsciloskop.SelectedItem.ToString());
                oscon = true;
                kanal = cbKanal.SelectedIndex + 1;

                cbOsciloskop.Enabled = false;
                btnOsveziPortove.Enabled = false;
                btnKonektujSe.Enabled = false;
                cbKanal.Enabled = false;

                tbStatus.Text += "Konektovan osciloskop " + cbOsciloskop.SelectedItem.ToString() + Environment.NewLine  + "Odabran kanal CH" + cbKanal.SelectedItem + Environment.NewLine + Environment.NewLine;
            }
            catch (Exception)
            {
                cbOsciloskop.Enabled = false;
                btnOsveziPortove.Enabled = false;
                btnKonektujSe.Enabled = false;
                cbKanal.Enabled = false;

                MessageBox.Show("Neuspešno konektovanje sa osciloskopom!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnZapamtiPod_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbReš1.Checked)
                {
                    brReš = 1;
                }
                else if (rbReš2.Checked)
                {
                    brReš = 2;
                }
                else
                {
                    brReš = 3;
                }
                brMikrostep = Convert.ToInt32(cbMikrostep.SelectedItem.ToString());

                EnableMid();
                DisableUpper();
                btnPromeniPod.Enabled = true;
                
                tbStatus.Text += "Postavljena podešavanja" + Environment.NewLine + "Unesite parametre snimanja i putanju za čuvanje snimaka..." + Environment.NewLine + Environment.NewLine;
            }
            catch (Exception)
            {
                MessageBox.Show("Zadat je neadekvatan broj stepova po obrtaju!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPromeniPod_Click(object sender, EventArgs e)
        {
            tbKrajPoložaj.Clear();
            tbKrajTalDužina.Clear();
            tbPočPoložaj.Clear();
            tbPočTalDužina.Clear();
            tbKorak.Clear();
            tbPath.Clear();

            EnableUpper();
            DisableMid();
            btnPromeniPod.Enabled = false;

            tbStatus.Text += "Očišćena podešavanja" + Environment.NewLine + "Unesite nova podešavanja..." + Environment.NewLine + Environment.NewLine;
        }

        private void btnProračunaj_Click(object sender, EventArgs e)
        {
            bool uspešno = false;
            bool dobrareš = false;
            bool redosled = false;

            try
            {
                počPol = Convert.ToDouble(tbPočPoložaj.Text.ToString());
                krTald = Convert.ToDouble(tbKrajTalDužina.Text.ToString());

                if (brReš == 3)
                {
                    počTald = 0.2 * počPol;
                    krPol = krTald / 0.2;
                    dobrareš = true;
                    if ((krPol > 100) && (krPol < 3500))
                    {
                        uspešno = true;
                    }
                }
                else
                {
                    throw new Exception();
                }

                if (uspešno)
                {
                    tbPočTalDužina.Text = Math.Round(počTald, 2).ToString();
                    tbKrajPoložaj.Text = Math.Round(krPol, 1).ToString();

                    if (počPol < krPol)
                    {
                        redosled = true;
                    }
                    else
                    {
                        throw new Exception();
                    }

                    btnSpremi.Enabled = true;
                    btnSpremi.Focus();

                    tbStatus.Text += "Unesite ostale podatke i spremite instrukcije za snimanje..." + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                if (!dobrareš)
                {
                    tbStatus.Text += "Izabrana je nekalibrisana rešetka, promenite podešavanje..." + Environment.NewLine + Environment.NewLine;
                    MessageBox.Show("Izabrali ste nekalibrisanu rešetku!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnPromeniPod.Focus();
                }
                else if (!uspešno)
                {
                    MessageBox.Show("Tražena talasna dužina je van dozvoljenog opsega!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbKrajPoložaj.Clear();
                    tbPočTalDužina.Clear();
                    tbKrajTalDužina.Clear();
                    tbKrajTalDužina.Focus();
                }
                else if (!redosled)
                {
                    MessageBox.Show("Skeniranje ka nižim talasnim dužinama nije podržano!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbKrajPoložaj.Clear();
                    tbPočTalDužina.Clear();
                    tbKrajTalDužina.Clear();
                    tbPočPoložaj.Clear();
                    tbPočPoložaj.Focus();
                }
                else
                {
                    MessageBox.Show("Niste uneli validne vrednosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbKrajPoložaj.Clear();
                    tbPočTalDužina.Clear();
                    tbKrajTalDužina.Clear();
                    tbPočPoložaj.Clear();
                    tbPočPoložaj.Focus();
                }
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            bool uspešno1 = false;
            bool dobrareš = false;
            bool uspešno2 = false;

            try
            {
                počPol = Convert.ToDouble(tbPočPoložaj.Text.ToString());
                krTald = Convert.ToDouble(tbKrajTalDužina.Text.ToString());

                if (brReš == 3)
                {
                    počTald = 0.2 * počPol;
                    krPol = krTald / 0.2;
                    dobrareš = true;
                    if ((krPol > 100) && (krPol < 3500))
                    {
                        uspešno1 = true;
                    }
                }
                else
                {
                    tbStatus.Text += "Izabrana je nekalibrisana rešetka, promenite podešavanje..." + Environment.NewLine + Environment.NewLine;
                    MessageBox.Show("Izabrali ste nekalibrisanu rešetku!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (uspešno1)
                {
                    tbPočTalDužina.Text = Math.Round(počTald, 2).ToString();
                    tbKrajPoložaj.Text = Math.Round(krPol, 1).ToString();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                if (dobrareš)
                {
                    MessageBox.Show("Tražena talasna dužina je van dozvoljenog opsega!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbKrajPoložaj.Clear();
                    tbPočTalDužina.Clear();
                    tbKrajTalDužina.Clear();
                    tbKrajTalDužina.Focus();
                }
                else
                {
                    MessageBox.Show("Niste uneli validne vrednosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbKrajPoložaj.Clear();
                    tbPočTalDužina.Clear();
                    tbKrajTalDužina.Clear();
                    tbPočPoložaj.Clear();
                    tbPočPoložaj.Focus();
                }
            }

            if (uspešno1 && dobrareš) 
            {
                try
                {
                    path = tbPath.Text;
                    StreamWriter talDFile = new StreamWriter(path + @"\TalD.txt");
                    StreamWriter indeks = new StreamWriter(path + @"\Index.txt");
                    uspešno2 = true;

                    korak = Convert.ToDouble(tbKorak.Text.ToString());

                    indeks.WriteLine("0");
                    indeks.Close();

                    double trenutni = Math.Round(počTald, 2);
                    while (trenutni <= krTald)
                    {
                        talDFile.WriteLine(trenutni.ToString());
                        trenutni = Math.Round(trenutni + korak, 2);
                    }
                    talDFile.Close();

                    tbStatus.Text += "Merenje spremno!" + Environment.NewLine + "Odaberite brzinu skeniranja i započnite merenje..." + Environment.NewLine + Environment.NewLine;
                    DisableButtons();
                    btnPokreni.Enabled = true;
                    btnPokreni.Focus();
                }
                catch
                {
                    if (uspešno2)
                    {
                        MessageBox.Show("Niste uneli validan korak!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbKorak.Clear();
                        tbKorak.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Ne postoji zadata putanja za čuvanje snimka!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbPath.Clear();
                        tbPath.Focus();
                    }
                }
            }
        }

        private void btnNađi_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog1.Description = 
                "Odaberite direktorijum za čuvanje podataka.";
            this.folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbPath.Text = folderBrowserDialog1.SelectedPath;
            }
            btnNastavi.Enabled = true;
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            int dir = 0;
            int count = 0;
            int step = 0;
            int busy;
            int j;
            double trPol, prPol;
            double trTald;
            double prTald = 0;
            string brz;
            string odgovor;
            byte[] rawwave;
            float avg;
            float ymult, yzero, yoff, xincr;
            string response;
            StreamReader talDFile = new StreamReader(path + @"\TalD.txt");
            StreamWriter indeks = new StreamWriter(path + @"\Index.txt");
            StreamWriter rezFile = new StreamWriter(path + @"\Rezultat.csv");

            try
            {
                if (!oscon)
                {
                    throw new Exception();
                }

                tbStatus.Clear();
                tbStatus.Text += "Započeto merenje od " + počTald.ToString() + " do " + 
                    krTald.ToString() + " nm" +
                    Environment.NewLine + Environment.NewLine;

                DisableButtons();
                DisableMid();
                DisableUpper();
                btnZaustavi.Enabled = true;

                if (rbBrzo.Checked)
                {
                    brz = "Brzo";
                }
                else if (rbSrednje.Checked)
                {
                    brz = "Srednje";
                }
                else
                {
                    brz = "Sporo";
                }

                indeks.WriteLine(count.ToString());

                tekVISA.Write("DATA:SOU CH" + kanal.ToString());
                tekVISA.Write("DATA:WIDTH 1");
                tekVISA.Write("DATA:ENC RPB");

                tekVISA.Write("ACQ:MOD AVE");
                tekVISA.Write("ACQ:NUMAV 4");

                prTald = Convert.ToDouble(talDFile.ReadLine());
                trTald = Convert.ToDouble(talDFile.ReadLine());
                prPol = prTald * 5;

                while (prTald < krTald)
                {
                    tbStatus.Text += "Merenje na talasnoj dužini " + prTald.ToString() + " nm" + 
                        Environment.NewLine;
                    tbStatus.Text += "Tačka broj " + (count + 1).ToString() +
                        Environment.NewLine;

                    busy = 1;
                    while (busy != 0)
                    {
                        tekVISA.Query("BUSY?", out busy);
                    }
                    
                    tekVISA.Write("ACQ:STOPA SEQ");
                    tekVISA.Write("ACQ:STATE RUN");
                    //wait(1000);
                    busy = 1;
                    while (busy != 0)
                    {
                        tekVISA.Query("BUSY?", out busy);
                    }


                    tekVISA.Query("WFMPRE:YMULT?", out response);
                    ymult = float.Parse(response);
                    tekVISA.Query("WFMPRE:YZERO?", out response);
                    yzero = float.Parse(response);
                    tekVISA.Query("WFMPRE:YOFF?", out response);
                    yoff = float.Parse(response);
                    tekVISA.Query("WFMPRE:XINCR?", out response);
                    xincr = float.Parse(response);

                    tekVISA.Write("CURVE?");
                    tekVISA.ReadBinary(out rawwave);
                    avg = 0;
                    for (j = 0; j < rawwave.Length; j++)
                    {
                        avg += (rawwave[j] - yoff) * ymult + yzero;
                    }
                    avg = avg / rawwave.Length;

                    rezFile.WriteLine(prTald.ToString() + "," + avg.ToString());

                    tbStatus.Text += "Zapisan signal " + avg.ToString() + " V" +
                        Environment.NewLine;

                    if (prTald < krTald)
                    {
                        tbStatus.Text += "Pokretanje rešetke do " + trTald.ToString() + " nm..." +
                            Environment.NewLine;
                        trPol = trTald * 5;
                        step = (int)Math.Round(brMikrostep * (Math.Abs(trPol - prPol) / 20));
                        spArd.WriteLine(brz + ", " + dir.ToString() + ", " + step.ToString());
                        odgovor = spArd.ReadLine();
                        odgovor = spArd.ReadLine();

                        if (odgovor == "Done!\r")
                        {
                            count++;
                        }
                        else
                        {
                            throw new Exception();
                        }
                        indeks.WriteLine(count.ToString());

                        tbStatus.Text += "Rešetka uspešno pomerena" +
                        Environment.NewLine + Environment.NewLine;

                        prTald = trTald;
                        prPol = trPol;
                        trTald = Convert.ToDouble(talDFile.ReadLine());
                        wait(3000);
                    }
                    else
                    {
                        prTald = krTald;
                    }
                }

                talDFile.Close();
                indeks.Close();
                rezFile.Close();

                tbStatus.Text += "Snimanje uspešno završeno!" +
                        Environment.NewLine + Environment.NewLine;

                MessageBox.Show("Snimanje uspešno završeno!", "Kraj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisableButtons();
                EnableMid();
                tbPočPoložaj.Focus();
                btnPromeniPod.Enabled = true;
            }
            catch
            {
                if (!oscon)
                {
                    MessageBox.Show("Osciloskop nije konektovan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    talDFile.Close();
                    indeks.Close();
                    rezFile.Close();
                    btnOsveziPortove.Focus();
                }
                else
                {
                    tbStatus.Text += "Komunikacija sa aparaturom prekinuta!" + Environment.NewLine +
                        "Poslednja snimljena tačka:" + Environment.NewLine +
                        "Talasna dužina: " + prTald.ToString() + " nm" + Environment.NewLine +
                        "Broj merenja: " + count.ToString() +
                        Environment.NewLine + Environment.NewLine;

                    MessageBox.Show("Komunikacija sa aparaturom prekinuta! Pokrenite program ponovo...", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    talDFile.Close();
                    indeks.Close();
                    rezFile.Close();
                    DisableButtons();
                }
            }
        }

        public void wait(int milliseconds)
        {
            var timer1 = new Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
    }
}
