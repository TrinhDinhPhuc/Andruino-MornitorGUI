using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
// Thêm 3 em này vào là OK, để sài SerialPort

using System.IO;

using System.IO.Ports;

using System.Xml;
namespace Arduino_Harry
{
    public partial class GUI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string InputData = String.Empty; // Khai báo string buff dùng cho hiển thị dữ liệu sau này.

        delegate void SetTextCallback(string text); // Khai bao delegate SetTextCallBack voi tham so string
        public GUI()
        {
            InitializeComponent();

            // Khai báo hàm delegate bằng phương thức DataReceived của Object SerialPort;

            // Cái này khi có sự kiện nhận dữ liệu sẽ nhảy đến phương thức DataReceive

            // Nếu ko hiểu đoạn này bạn có thể tìm hiểu về Delegate, còn ko cứ COPY . Ko cần quan tâm

            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceive);

            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };

            comboBoxBaudRate.Properties.Items.AddRange(BaudRate);
           // comboBoxBaudRate.AddRange(BaudRate);  ở đây đối với DEV thì mình sẽ phải gọi hàm ITEMS thông qua properties 
        }

        private void DataReceive(object obj, SerialDataReceivedEventArgs e)

        {

            InputData = serialPort1.ReadExisting();

            if (InputData != String.Empty)

            {

                // textbox1 = InputData; // Ko dùng đc như thế này vì khác threads .

                SetText(InputData); // Chính vì vậy phải sử dụng ủy quyền tại đây. Gọi delegate đã khai báo trước đó.

            }

        }
        // Hàm của em nó là ở đây. Đừng hỏi vì sao lại thế.

        private void SetText(string text)

        {

            if (this.textbox1.InvokeRequired)

            {

                SetTextCallback d = new SetTextCallback(SetText); // khởi tạo 1 delegate mới gọi đến SetText

                this.Invoke(d, new object[] { text });

            }

            else this.textbox1.Text += text;

        }

        private void timer1_Tick(object sender, EventArgs e)

        {

            if (!serialPort1.IsOpen)

            {



                label5.Text = ("Chưa kết nối");

                label5.ForeColor = Color.Red;

            }

            else if (serialPort1.IsOpen)

            {



                label5.Text = ("Đã kết nối");

                label5.ForeColor = Color.Green;



            }

        }
        private void GUI_Load(object sender, EventArgs e)
        {
            gridLookUpEditCOM.Properties.DataSource = SerialPort.GetPortNames();// Quét các cổng COM đang hoạt động lên comboBox1
            //comboBoxCOM.EditValue = SerialPort.GetPortNames();// Quét các cổng COM đang hoạt động lên comboBox1
            //ở đây nên dùng gridlookupedit giống với combobox thường
            comboBoxBaudRate.SelectedIndex = 3;
            // Set tí chế độ mặc đình cho nó nguy hiểm tí!!!!
        }

        private void btnStopConnection_Click(object sender, EventArgs e)
        {
            serialPort1.Close();

        }

        private void btnConnection_Click(object sender, EventArgs e)
        {

            if (!serialPort1.IsOpen)

            {

                serialPort1.PortName = gridLookUpEditCOM.Text;

                serialPort1.BaudRate = Convert.ToInt32(comboBoxBaudRate.Text);

                serialPort1.Open();

            }
        }

        private void btnQuit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();

        }

        private void comboBoxCOM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}