using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharpDemo
{
    public partial class Form1 : Form
    {
        private byte[] _comport = new byte[1024];
        private byte[] _usbport = new byte[1024];
        private byte[] _lptport = new byte[1024];
        private byte[] _prnport = new byte[1024];
        private int handle;

        private void initopen()
        {
            this.radiocom.Enabled = false;
            this.radiousb.Enabled = false;
            this.radiolpt.Enabled = false;
            this.radionet.Enabled = false;
            this.radioprn.Enabled = false;
            this.comport.Enabled = false;
            this.combaud.Enabled = false;
            this.comflow.Enabled = false;
            this.usbport.Enabled = false;
            this.lptport.Enabled = false;
            this.prnport.Enabled = false;
            this.netip.Enabled = false;
            this.netport.Enabled = false;
            this.openport.Enabled = false;
            this.closeport.Enabled = true;
            this.printtext.Enabled = true;
            this.printhex.Enabled = true;
            this.printimage.Enabled = true;
            this.printNVLogo.Enabled = true;
            this.downloadNVLogo.Enabled = true;
            if (this.radiolpt.Checked || this.radioprn.Checked)
            {
                this.querystatus.Enabled = false;
            }
            else
            {
                this.querystatus.Enabled = true;
            }

        }
        private void initclose()
        {
            this.radiocom.Enabled = true;
            this.radiousb.Enabled = true;
            this.radiolpt.Enabled = true;
            this.radionet.Enabled = true;
            this.radioprn.Enabled = true;
            this.comport.Enabled = true;
            this.combaud.Enabled = true;
            this.comflow.Enabled = true;
            this.usbport.Enabled = true;
            this.lptport.Enabled = true;
            this.prnport.Enabled = true;
            this.netip.Enabled = true;
            this.netport.Enabled = true;
            this.openport.Enabled = true;
            this.closeport.Enabled = false;
            this.printtext.Enabled = false;
            this.printhex.Enabled = false;
            this.printimage.Enabled = false;
            this.querystatus.Enabled = false;

            this.printNVLogo.Enabled = false;
            this.downloadNVLogo.Enabled = false;
        }

        private uint EnumCOM()
        {
            this.comport.Items.Clear();

            for (int i = 0; i < 1024; i++)
            {
                _comport[i] = 0;
            }

            uint comsun = CsnPrinterLibs.CsnPrinterLibs.Port_EnumCOM(_comport, _comport.Length);
            String coms = System.Text.Encoding.Default.GetString(_comport);
            String[] comss = coms.Split(new char[] { '\0' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < comsun; i++)
            {
                this.comport.Items.Add(comss[i]);
            }
            return comsun;
        }

        private uint EnumUSB()
        {
            this.usbport.Items.Clear();

            for (int i = 0; i < 1024; i++)
            {
                _usbport[i] = 0;
            }

            uint usbsun = CsnPrinterLibs.CsnPrinterLibs.Port_EnumUSB(_usbport, _usbport.Length);
            String usbs = System.Text.Encoding.Default.GetString(_usbport);
            String[] usbss = usbs.Split(new char[] { '\0' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < usbsun; i++)
            {
                this.usbport.Items.Add(usbss[i]);
            }
            return usbsun;
        }
        private uint EnumLPT()
        {
            this.lptport.Items.Clear();

            for (int i = 0; i < 1024; i++)
            {
                _lptport[i] = 0;
            }

            uint lptsun = CsnPrinterLibs.CsnPrinterLibs.Port_EnumLPT(_lptport, _lptport.Length);
            String lpts = System.Text.Encoding.Default.GetString(_lptport);
            String[] lptss = lpts.Split(new char[] { '\0' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lptsun; i++)
            {
                this.lptport.Items.Add(lptss[i]);
            }
            return lptsun;
        }
        private uint EnumPRN()
        {
            this.prnport.Items.Clear();

            for (int i = 0; i < 1024; i++)
            {
                _prnport[i] = 0;
            }


            uint prnsun = CsnPrinterLibs.CsnPrinterLibs.Port_EnumPRN(_prnport, _prnport.Length);
            String prns = System.Text.Encoding.Default.GetString(_prnport);
            String[] prnss = prns.Split(new char[] { '\0' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < prnsun; i++)
            {
                this.prnport.Items.Add(prnss[i]);
            }
            return prnsun;
        }

        private void initForm()
        {
            this.comport.Items.Add("com3");

            this.combaud.Items.Add("9600");
            this.combaud.Items.Add("19200");
            this.combaud.Items.Add("38400");
            this.combaud.Items.Add("57600");
            this.combaud.Items.Add("115200");
            this.combaud.SelectedIndex = 0;

            this.comflow.Items.Add("NONE");
            this.comflow.Items.Add("DsrDtr");
            this.comflow.Items.Add("CtsRts");
            this.comflow.Items.Add("Xon/Xoff");
            this.comflow.SelectedIndex = 0;

            if (EnumCOM() > 0)
            {
                this.comport.SelectedIndex = 0;
            }
            if (EnumUSB() > 0)
            {
                this.usbport.SelectedIndex = 0;
            }
            if (EnumLPT() > 0)
            {
                this.lptport.SelectedIndex = 0;
            }
            if (EnumPRN() > 0)
            {
                this.prnport.SelectedIndex = 0;
            }



            this.netip.Text = "192.168.0.87";
            this.netport.Text = "9100";

            this.radiocom.Checked = true;
        }


        public Form1()
        {
            InitializeComponent();
            initForm();
        }

        private void openport_Click(object sender, EventArgs e)
        {
            if (radiocom.Checked == true)
            {
                handle = CsnPrinterLibs.CsnPrinterLibs.Port_OpenCOMIO(this.comport.Text, int.Parse(this.combaud.Text), this.comflow.SelectedIndex,0,8,0);

                if (handle != 0)
                {
                    CsnPrinterLibs.CsnPrinterLibs.Port_SetPort(handle);
                    initopen();
                    return;
                }
                else
                {
                    MessageBox.Show("Open failed, Please confirm if the port is occupied");
                    return;
                }
            }
            if (radiousb.Checked == true)
            {
                handle = CsnPrinterLibs.CsnPrinterLibs.Port_OpenUSBIO(this.usbport.Text);

                if (handle != 0)
                {
                    CsnPrinterLibs.CsnPrinterLibs.Port_SetPort(handle);
                    initopen();
                    return;
                }
                else
                {
                    MessageBox.Show("Open failed, Please confirm if the port is occupied");
                    return;

                }
            }
            if (radiolpt.Checked == true)
            {
                handle = CsnPrinterLibs.CsnPrinterLibs.Port_OpenLPTIO(this.lptport.Text);

                if (handle != 0)
                {
                    CsnPrinterLibs.CsnPrinterLibs.Port_SetPort(handle);
                    initopen();
                    return;
                }
                else
                {
                    MessageBox.Show("Open failed, Please confirm if the port is occupied");
                }
            }
            if (radioprn.Checked == true)
            {
                handle = CsnPrinterLibs.CsnPrinterLibs.Port_OpenPRNIO(this.prnport.Text);

                if (handle != 0)
                {
                    CsnPrinterLibs.CsnPrinterLibs.Port_SetPort(handle);
                    initopen();
                    return;
                }
                else
                {
                    MessageBox.Show("Open failed, Please confirm if the port is occupied");
                    return;
                }
            }
            if (radionet.Checked == true)
            {
                handle = CsnPrinterLibs.CsnPrinterLibs.Port_OpenTCPIO(this.netip.Text, int.Parse(this.netport.Text));

                if (handle != 0)
                {
                    CsnPrinterLibs.CsnPrinterLibs.Port_SetPort(handle);
                    initopen();
                    return;
                }
                else
                {
                    MessageBox.Show("Open failed, Please confirm if the port is occupied");
                    return;
                }
            }
        }

        private void closeport_Click(object sender, EventArgs e)
        {
            CsnPrinterLibs.CsnPrinterLibs.Port_ClosePort(handle);
            initclose();
            this.openport.Enabled = true;
        }

        private void printtext_Click(object sender, EventArgs e)
        {
            CsnPrinterLibs.CsnPrinterLibs.Pos_Reset();
            CsnPrinterLibs.CsnPrinterLibs.Pos_Text(System.Text.Encoding.Unicode.GetBytes("Self Test\n"), 1, -2, 1, 1, 0, 0);
            CsnPrinterLibs.CsnPrinterLibs.Pos_Text(System.Text.Encoding.Unicode.GetBytes("测试小票\n"), 0, -2, 1, 1, 0, 0);
            CsnPrinterLibs.CsnPrinterLibs.Pos_Text(System.Text.Encoding.Unicode.GetBytes("測試小票\n"), 3, -2, 1, 1, 0, 0);
            CsnPrinterLibs.CsnPrinterLibs.Pos_Text(System.Text.Encoding.Unicode.GetBytes("テストシート\n"), 4, -2, 1, 1, 0, 0);
            CsnPrinterLibs.CsnPrinterLibs.Pos_Text(System.Text.Encoding.Unicode.GetBytes("팁을 재다\n"), 5, -2, 1, 1, 0, 0);
            CsnPrinterLibs.CsnPrinterLibs.Pos_Text(System.Text.Encoding.Unicode.GetBytes("welcome to use\n"), 1, -1, 0, 0, 0, 0x80 | 0x08);
            CsnPrinterLibs.CsnPrinterLibs.Pos_Text(System.Text.Encoding.Unicode.GetBytes("欢迎使用我司打印机\n"), 0, -2, 0, 0, 0, 0x100);
            CsnPrinterLibs.CsnPrinterLibs.Pos_Text(System.Text.Encoding.Unicode.GetBytes("歡迎使用印表機\n"), 3, -3, 0, 0, 0, 0x100);
            CsnPrinterLibs.CsnPrinterLibs.Pos_Text(System.Text.Encoding.Unicode.GetBytes("ご利用を歓迎する\n"), 4, -2, 0, 0, 0, 0x100);
            CsnPrinterLibs.CsnPrinterLibs.Pos_Text(System.Text.Encoding.Unicode.GetBytes("사용을 환영합니다\n"), 5, -1, 0, 0, 0, 0x100);
            CsnPrinterLibs.CsnPrinterLibs.Pos_FeedLine();
            CsnPrinterLibs.CsnPrinterLibs.Pos_Text(System.Text.Encoding.Unicode.GetBytes("Test BarCode\n"), 1, -2, 0, 0, 0, 0);
            CsnPrinterLibs.CsnPrinterLibs.Pos_Barcode("123456", 0x45, -2, 3, 96, 0, 2);
            CsnPrinterLibs.CsnPrinterLibs.Pos_FeedLine();
            CsnPrinterLibs.CsnPrinterLibs.Pos_Text(System.Text.Encoding.Unicode.GetBytes("Test QrCode\n"), 1, -2, 0, 0, 0, 0);
            CsnPrinterLibs.CsnPrinterLibs.Pos_Reset();
            CsnPrinterLibs.CsnPrinterLibs.Pos_Align(1);
            CsnPrinterLibs.CsnPrinterLibs.Pos_Qrcode(System.Text.Encoding.Unicode.GetBytes("welcome to use\n"), 1, 9,4);
            CsnPrinterLibs.CsnPrinterLibs.Pos_FeedLine();
            CsnPrinterLibs.CsnPrinterLibs.Pos_Text(System.Text.Encoding.Unicode.GetBytes("Test Test Double QrCode\n"), 1, -2, 0, 0, 0, 0);
            CsnPrinterLibs.CsnPrinterLibs.Pos_DoubleQrcode(System.Text.Encoding.Unicode.GetBytes("Self Test"), 0, 9, 3, System.Text.Encoding.Unicode.GetBytes("测试小票"), 192, 9, 3, 3);
            CsnPrinterLibs.CsnPrinterLibs.Pos_Feed_N_Line(8);
            CsnPrinterLibs.CsnPrinterLibs.Pos_FullCutPaper();
        }

        private void printimage_Click(object sender, EventArgs e)
        {
            CsnPrinterLibs.CsnPrinterLibs.Pos_Reset();
            CsnPrinterLibs.CsnPrinterLibs.Pos_Text(System.Text.Encoding.Unicode.GetBytes("Test Image\n"), 1, -2, 0, 0, 0, 0);
            CsnPrinterLibs.CsnPrinterLibs.Pos_ImagePrint(System.Text.Encoding.Unicode.GetBytes(".\\time2.jpg"), 384,0);
            CsnPrinterLibs.CsnPrinterLibs.Pos_Reset();
            CsnPrinterLibs.CsnPrinterLibs.Pos_Feed_N_Line(7);
            CsnPrinterLibs.CsnPrinterLibs.Pos_Text(System.Text.Encoding.Unicode.GetBytes("Test Text Image\n"), 1, -2, 0, 0, 0, 0);
            CsnPrinterLibs.CsnPrinterLibs.Pos_ImagePrint(System.Text.Encoding.Unicode.GetBytes(".\\time3.jpg"), 384,0);
            CsnPrinterLibs.CsnPrinterLibs.Pos_Feed_N_Line(5);
            CsnPrinterLibs.CsnPrinterLibs.Pos_FullCutPaper();
        }

        
        private void downloadNVLogo_Click(object sender, EventArgs e)
        {
            CsnPrinterLibs.CsnPrinterLibs.Pos_Reset();
            CsnPrinterLibs.CsnPrinterLibs.Pos_Text(System.Text.Encoding.Unicode.GetBytes("Test Down load NV Logo\n"), 1, -2, 0, 0, 0, 0);

            byte[] nvlogoFileName = System.Text.Encoding.Unicode.GetBytes(".\\1.bmp#.\\2.bmp#.\\3.bmp#.\\4.bmp");
            CsnPrinterLibs.CsnPrinterLibs.Pos_DownLoadNVLogo(nvlogoFileName, 0);

            CsnPrinterLibs.CsnPrinterLibs.Pos_Text(System.Text.Encoding.Unicode.GetBytes("Down load NV Logo Done\n"), 1, -2, 0, 0, 0, 0);
            CsnPrinterLibs.CsnPrinterLibs.Pos_Feed_N_Line(8);
            CsnPrinterLibs.CsnPrinterLibs.Pos_FullCutPaper();
            

        }

        private void printNVLogo_Click(object sender, EventArgs e)
        {
            CsnPrinterLibs.CsnPrinterLibs.Pos_Reset();
            CsnPrinterLibs.CsnPrinterLibs.Pos_Text(System.Text.Encoding.Unicode.GetBytes("Test Print NV logo\n"), 1, -2, 0, 0, 0, 0);

            CsnPrinterLibs.CsnPrinterLibs.Pos_PrintNVLogoByNumber(1, 0);
            CsnPrinterLibs.CsnPrinterLibs.Pos_PrintNVLogoByNumber(2, 1);
            CsnPrinterLibs.CsnPrinterLibs.Pos_PrintNVLogoByNumber(3, 2);
            CsnPrinterLibs.CsnPrinterLibs.Pos_PrintNVLogoByNumber(4, 3);
           

            CsnPrinterLibs.CsnPrinterLibs.Pos_Text(System.Text.Encoding.Unicode.GetBytes("Test Print NV logo Done\n"), 1, -2, 0, 0, 0, 0);
            CsnPrinterLibs.CsnPrinterLibs.Pos_Feed_N_Line(8);
            CsnPrinterLibs.CsnPrinterLibs.Pos_FullCutPaper();

        }

        private void combaud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comflow_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.radiocom.Checked = true;
        }

        private void lptport_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.radiolpt.Checked = true;
            EnumLPT();
        }

        private void netport_TextChanged(object sender, EventArgs e)
        {
            this.radionet.Checked = true;
        }

        private void querystatus_Click(object sender, EventArgs e)
        {
            int err = CsnPrinterLibs.CsnPrinterLibs.Pos_QueryPrinterErr(3000);
            switch (err)
            {
                case -1:
                    MessageBox.Show("off-line");
                    break;
                case -2:
                    MessageBox.Show("Open Cover");
                    break;
                case -3:
                    MessageBox.Show("Paper out");
                    break;
                case -4:
                    MessageBox.Show("Cut error");
                    break;
                case -5:
                    MessageBox.Show("Printer hyperpyrexia");
                    break;
                case -6:
                    MessageBox.Show("Query failed");
                    break;
                default:
                    MessageBox.Show("No exception, please print");
                    break;
            }

            byte []status = new byte[1];
            bool bRet = CsnPrinterLibs.CsnPrinterLibs.Pos_QueryStstus(status, 0x01, 3 * 1000);
            if (false == bRet)
	        {
		        MessageBox.Show("Pos_QueryStstus failed");
	        }
	        else
	        {
		        MessageBox.Show("Pos_QueryStstus 0x01 Success");
	        }
            bRet = CsnPrinterLibs.CsnPrinterLibs.Pos_QueryStstus(status, 0x02, 3 * 1000);
            if (false == bRet)
	        {
		        MessageBox.Show("Pos_QueryStstus failed");
	        }
	        else
	        {
		        MessageBox.Show("Pos_QueryStstus 0x02 Success");
	        }
            bRet = CsnPrinterLibs.CsnPrinterLibs.Pos_QueryStstus(status, 0x03, 3 * 1000);
            if (false == bRet)
	        {
		        MessageBox.Show("Pos_QueryStstus failed");
	        }
	        else
	        {
		        MessageBox.Show("Pos_QueryStstus 0x03 Success");
	        }
            bRet = CsnPrinterLibs.CsnPrinterLibs.Pos_QueryStstus(status, 0x04, 3 * 1000);
	        if(false == bRet)
	        {
		        MessageBox.Show("Pos_QueryStstus failed");
	        }
	        else
	        {
		        MessageBox.Show("Pos_QueryStstus 0x04 Success");
	        }
        }

        private void usbport_Click(object sender, EventArgs e)
        {
            this.radiousb.Checked = true;
            EnumUSB();
        }

        private void comport_Click(object sender, EventArgs e)
        {
            this.radiocom.Checked = true;
            EnumCOM();
        }

        private void lptport_Click(object sender, EventArgs e)
        {
            this.radiolpt.Checked = true;
            EnumLPT();
        }

        private void prnport_Click(object sender, EventArgs e)
        {
            this.radioprn.Checked = true;
            EnumPRN();
        }

        private void netip_Click(object sender, EventArgs e)
        {
            this.radionet.Checked = true;
        }

        private void netport_Click(object sender, EventArgs e)
        {
            this.radionet.Checked = true;
        }

        private void printhex_Click(object sender, EventArgs e)
        {
            byte []hexCmd = new byte[16];
            hexCmd[0] = 0x1B;
            hexCmd[1] = 0x40;
            hexCmd[2] = 0x31;
            hexCmd[3] = 0x31;
            hexCmd[4] = 0x31;
            hexCmd[5] = 0x31;
            hexCmd[6] = 0x31;
            hexCmd[7] = 0x31;
            hexCmd[8] = 0x0D;
            hexCmd[9] = 0x0A;
            CsnPrinterLibs.CsnPrinterLibs.Pos_Cmd(hexCmd,10);

        }
    }
}
