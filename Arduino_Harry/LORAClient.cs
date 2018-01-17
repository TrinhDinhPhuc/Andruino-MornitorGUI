using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;


//EXTRA LIB
using System.IO.Ports;


namespace Arduino_Harry
{
    public partial class LORAClient : DevExpress.XtraEditors.XtraForm
    {
        string sendWith;
        string dataOUT;
        public bool _continue;
        public SerialPort _serialPort;
        string DataIn;
        public LORAClient()
        {
            InitializeComponent();
        }

        private void LORAClient_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxCOMPORT.Items.AddRange(ports);
            chBoxDTREnable.Checked = false;
            serialPort1.DtrEnable = false;

            btnOPEN.Enabled = true;
            btnCLOSE.Enabled = false;

            chBoxRTSEnable.Checked = false;
            serialPort1.RtsEnable = false;
            chBoxWriteLine.Checked = false;
            chBoxWrite.Checked = false;
            sendWith = "Write"; // for initial condition is using write

            chBoxAddToOldData.Checked = true;
            chBoxAlwaysUpdate.Checked = false;
        }

        private void btnOPEN_Click(object sender, EventArgs e)
        {
            try //COM PORT parameters
            {
                serialPort1.PortName = cBoxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse((typeof(StopBits)), cBoxStopBit.Text);
                serialPort1.Parity = (Parity)Enum.Parse((typeof(Parity)), cBoxParityBit.Text);

                serialPort1.Open();
                progressBarControl1.EditValue = 100;
                btnOPEN.Enabled = false;
                btnCLOSE.Enabled = true;
                lblStatusCom.Text = "ON";
                lblStatusCom.ForeColor = System.Drawing.Color.Green;
            }
            
             catch(Exception err)
            {
                MessageBox.Show(err.Message,"ERRORRRR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnOPEN.Enabled = true;
                btnCLOSE.Enabled = false;
                lblStatusCom.Text = "OFF";
                lblStatusCom.ForeColor = System.Drawing.Color.Black;

            }
        }

        private void btnCLOSE_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBarControl1.EditValue = 0;
                btnOPEN.Enabled = true;
                btnCLOSE.Enabled = false;
                lblStatusCom.Text = "OFF";
                lblStatusCom.ForeColor = System.Drawing.Color.Black;

            }
        }


        private void chBoxDTREnable_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxDTREnable.Checked)
            {
                serialPort1.DtrEnable = true;
                MessageBox.Show("DTR Enable", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                serialPort1.DtrEnable = false;
            }
        }

        private void chBoxRTSEnable_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxRTSEnable.Checked)
            {
                serialPort1.RtsEnable = true;
                MessageBox.Show("DRT Enable","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                serialPort1.RtsEnable = false;

            }
        }

        private void btnCleanDATA_Click(object sender, EventArgs e)
        {
            if(tBoxDataOUT.Text != "")
            {
                tBoxDataOUT.Text = "";
            }
        }


        private void lblDataOUTLength_TextChanged(object sender, EventArgs e)
        {


            int dataOUTLength = dataOUT.Length; //lấy độ dài
            
            lblDataOUTLength.Text = string.Format("{0:00}", dataOUTLength); //gán 

        }

        private void chBoxWriteLine_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxWriteLine.Checked)
            {
                sendWith = "WriteLine";
                chBoxWrite.Checked = false;
                chBoxWriteLine.Checked = true;

            }

           
        }

        private void chBoxWrite_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxWrite.Checked)
            {
                sendWith = "Write";
                chBoxWrite.Checked = true;
                chBoxWriteLine.Checked = false;

            }
        }

        private void bntSENDDATA_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = tBoxDataOUT.Text;

                if (sendWith == "WriteLine")
                {
                    serialPort1.WriteLine(dataOUT);
                }
                else if (sendWith == "Write")
                {
                    serialPort1.Write(dataOUT);
                }

            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            DataIn = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            int DAtaInlength = DataIn.Length;
            lblDataInLength.Text = string.Format("{0:00}", DAtaInlength);
            if(chBoxAlwaysUpdate.Checked)
            {
                tBoxDataIN.Text = DataIn;

            }
            else if (chBoxAddToOldData.Checked)
            {
                tBoxDataIN.Text += DataIn;

            }
        }

        private void chBoxAlwaysUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxAlwaysUpdate.Checked)
            {
                chBoxAlwaysUpdate.Checked = true;
                chBoxAddToOldData.Checked = false;

            }
            else
            {
                chBoxAddToOldData.Checked = true;

            }
        }

        private void chBoxAddToOldData_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxAddToOldData.Checked)
            {
                chBoxAlwaysUpdate.Checked = false;
                chBoxAddToOldData.Checked = true;
            }
            else
            {
                chBoxAlwaysUpdate.Checked = true;

            }
        }

        private void btnClearDataIN_Click(object sender, EventArgs e)
        {
            if(tBoxDataIN.Text != "")
            {
                tBoxDataIN.Text = "";
            }
        }

        private void btnRESET_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxCOMPORT.Items.AddRange(ports);
            chBoxDTREnable.Checked = false;
            serialPort1.DtrEnable = false;

            btnOPEN.Enabled = true;
            btnCLOSE.Enabled = false;

            chBoxRTSEnable.Checked = false;
            serialPort1.RtsEnable = false;
            chBoxWriteLine.Checked = false;
            chBoxWrite.Checked = false;
            sendWith = "Write"; // for initial condition is using write

            chBoxAddToOldData.Checked = true;
            chBoxAlwaysUpdate.Checked = false;
        }
    }
}