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
    public partial class MainMenu : Form
    {
        private string[] ports;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            btnNaProceduruMotor.Enabled = false;
            btnNaProceduruSnimanje.Enabled = false;
            btnKonektujSe.Enabled = false;
            cboPortovi.Enabled = false;
            rbImpulsni.Checked = true;
            rbImpulsni.Enabled = false;
            rbKontinualni.Enabled = false;
        }

        private void btnOsveziPortove_Click(object sender, EventArgs e)
        {
            try
            {
                int brport = SerialPort.GetPortNames().Length;
                if (brport>0)
                {
                    ports = SerialPort.GetPortNames();
                    cboPortovi.Items.Clear();
                    cboPortovi.Items.AddRange(ports);
                    btnKonektujSe.Enabled = true;
                    cboPortovi.Enabled = true;
                    cboPortovi.SelectedIndex = 0;
                }
                else
                {
                    cboPortovi.Items.Clear();
                    cboPortovi.Enabled = false;
                    btnKonektujSe.Enabled = false;
                    btnNaProceduruMotor.Enabled = false;
                    btnNaProceduruSnimanje.Enabled = false;
                    rbKontinualni.Enabled = false;
                    rbImpulsni.Enabled = false;
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ne postoje otvoreni serijski portovi!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKonektujSe_Click(object sender, EventArgs e)
        {

            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
                serialPort1.PortName = cboPortovi.Text;
                serialPort1.Open();
                btnNaProceduruMotor.Enabled = true;
                btnNaProceduruSnimanje.Enabled = true;
                btnKonektujSe.Enabled = false;
                cboPortovi.Enabled = false;
                rbImpulsni.Enabled = true;
                rbKontinualni.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Arduino port nije konektovan ili ne radi!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);         
            }
           
        }

        private void btnNaProceduruMotor_Click(object sender, EventArgs e)
        {
            PomeranjeRešetke frmPR = new PomeranjeRešetke();
            frmPR.setSerialPort(serialPort1);
            frmPR.Show();
            disableAll();

            frmPR.FormClosed += new FormClosedEventHandler(Form_Closed);
        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            enableLower();
        }

        private void btnNaProceduruSnimanje_Click(object sender, EventArgs e)
        {
            if (rbKontinualni.Checked)
            {
                SnimanjeDC frmDC = new SnimanjeDC();
                frmDC.setSerialPort(serialPort1);
                frmDC.Show();
                disableAll();

                frmDC.FormClosed += new FormClosedEventHandler(Form_Closed);
            }
            else // namestiti AC kad se napravi AC
            {
                SnimanjeDC frmAC = new SnimanjeDC();
                frmAC.setSerialPort(serialPort1);
                frmAC.Show();
                disableAll();

                frmAC.FormClosed += new FormClosedEventHandler(Form_Closed);
            }
        }

        private void disableAll()
        {
            btnNaProceduruMotor.Enabled = false;
            btnOsveziPortove.Enabled = false;
            btnNaProceduruSnimanje.Enabled = false;
            cboPortovi.Enabled = false;
            rbImpulsni.Enabled = false;
            rbKontinualni.Enabled = false;
        }

        private void enableLower()
        {
            btnNaProceduruMotor.Enabled = true;
            btnOsveziPortove.Enabled = true;
            btnNaProceduruSnimanje.Enabled = true;
            rbKontinualni.Enabled = true;
            rbImpulsni.Enabled = true;
        }
    }
}
