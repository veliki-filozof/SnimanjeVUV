using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnimanjeVUV
{
    public partial class PomeranjeRešetke : Form
    {
        private int brReš;
        private int brMikrostep;
        private double počPol;
        private double počTald;
        private double krPol;
        private double krTald;

        public PomeranjeRešetke()
        {
            InitializeComponent();
            EnableUpper();

            rbReš3.Checked = true;
            rbBrzo.Checked = true;
            cbMikrostep.SelectedItem = "200";
        }

        public void setSerialPort(SerialPort port)
        {
            serialPort1 = port;
        }
     
        private void btnPodešavanje_Click(object sender, EventArgs e)
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

                EnableLower();
            }
            catch (Exception)
            {
                MessageBox.Show("Zadat je neadekvatan broj stepova po obrtaju!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProračunaj_Click(object sender, EventArgs e)
        {
            bool uspešno = false;
            bool dobrareš = false;

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
                    MessageBox.Show("Izabrali ste nekalibrisanu rešetku!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (uspešno)
                {
                    tbPočTalDužina.Text = Math.Round(počTald, 2).ToString();
                    tbKrajPoložaj.Text = Math.Round(krPol, 1).ToString();

                    btnPokreni.Enabled = true;
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
        }

        private void btnPromeni_Click(object sender, EventArgs e)
        {
            tbKrajPoložaj.Clear();
            tbKrajTalDužina.Clear();
            tbPočPoložaj.Clear();
            tbPočTalDužina.Clear();

            EnableUpper();
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            DisableAll();

            bool uspešno1 = true;
            bool uspešno2 = true;
            int dir = 0;
            int step;
            string brz;
            string odgovor;

            try
            {
                if (počPol > krPol)
                {
                    dir = 1;
                }
                
                step = (int)Math.Round(brMikrostep*(Math.Abs(počPol - krPol)/20));

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

                serialPort1.WriteLine(brz + ", " + dir.ToString() + ", " + step.ToString());
            }
            catch (Exception)
            {
                uspešno1 = false;
                MessageBox.Show("Arduino port nije konektovan ili ne radi!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (uspešno1)
            {
                try
                {
                    odgovor = serialPort1.ReadLine();
                    if (odgovor == "Processing...\r")
                    {
                        odgovor = serialPort1.ReadLine();
                        if (odgovor == "Done!\r")
                        {
                            MessageBox.Show("Uspešno izvršena komanda", "Uspešno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Neuspešno izvršenje komande! Proverite položaj rešetke.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    uspešno2 = false;
                }
            }

            if (uspešno1 && uspešno2)
            {
                tbPočPoložaj.Text = Math.Round(krPol, 1).ToString();
                tbPočTalDužina.Text = Math.Round(krTald, 2).ToString();
                tbKrajPoložaj.Clear();
                tbKrajTalDužina.Clear();
            }
            else if (uspešno1)
            {
                tbPočPoložaj.Clear();
                tbPočTalDužina.Clear();
                tbKrajPoložaj.Clear();
                tbKrajTalDužina.Clear();
            }
            else
            {
                tbPočPoložaj.Text = Math.Round(počPol, 1).ToString();
                tbPočTalDužina.Text = Math.Round(počTald, 2).ToString();
                tbKrajPoložaj.Clear();
                tbKrajTalDužina.Clear();
            }

            EnableLower();
        }

        private void EnableUpper()
        {
            gbRešetke.Enabled = true;
            cbMikrostep.Enabled = true;
            btnPodešavanje.Enabled = true;
            tbPočPoložaj.Enabled = false;
            tbPočTalDužina.Enabled = false;
            tbKrajPoložaj.Enabled = false;
            tbKrajTalDužina.Enabled = false;
            gbBrzina.Enabled = false;
            btnProračunaj.Enabled = false;
            btnPokreni.Enabled = false;
            btnPromeni.Enabled = false;
        }

        private void EnableLower()
        {
            gbRešetke.Enabled = false;
            cbMikrostep.Enabled = false;
            btnPodešavanje.Enabled = false;
            tbPočPoložaj.Enabled = true;
            tbPočTalDužina.Enabled = true;
            tbKrajPoložaj.Enabled = true;
            tbKrajTalDužina.Enabled = true;
            gbBrzina.Enabled = true;
            btnProračunaj.Enabled = true;
            btnPokreni.Enabled = false;
            btnPromeni.Enabled = true;
        }

        private void DisableAll()
        {
            gbRešetke.Enabled = false;
            cbMikrostep.Enabled = false;
            btnPodešavanje.Enabled = false;
            tbPočPoložaj.Enabled = false;
            tbPočTalDužina.Enabled = false;
            tbKrajPoložaj.Enabled = false;
            tbKrajTalDužina.Enabled = false;
            gbBrzina.Enabled = false;
            btnProračunaj.Enabled = false;
            btnPokreni.Enabled = false;
            btnPromeni.Enabled = false;
        }
    }
}
