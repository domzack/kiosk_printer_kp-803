using System;
using System.Runtime.InteropServices;

namespace CsnPrinterLibs
{
    public class CsnPrinterLibs
    {
        // ¶Ë¿Ú
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint Port_EnumCOM(byte[] buffer, int length);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint Port_EnumUSB(byte[] buffer, int length);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint Port_EnumLPT(byte[] buffer, int length);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint Port_EnumPRN(byte[] buffer, int length);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Port_OpenCOMIO(String name, int baudrate, int flowcontrol, int parity, int databis, int stopbits);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Port_OpenUSBIO(String name);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Port_OpenLPTIO(String name);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Port_OpenPRNIO(String name);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Port_OpenTCPIO(String name, int port);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Port_SetPort(int handle);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Port_ClosePort(int handle);

        // ´òÓ¡¿ØÖÆ
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Pos_Reset();
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Pos_SelfTest();
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Pos_FeedLine();
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Pos_FeedHot(int n);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Pos_Feed_N_Line(int n);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Pos_FeedNextLable();
		[DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Pos_BlackMark();
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Pos_Align(int value);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Pos_SetLineHeight(int value);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Pos_Text(byte[] prnText, int nLan, int nOrgx, int nWidthTimes, int nHeightTimes, int FontType, int nFontStyle);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Pos_Cmd(byte[] cmd, int count);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Pos_Beep(byte nCount, byte nMillis);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Pos_KiskOutDrawer(int nId, int nHightTime, int nLowTime);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Pos_FullCutPaper();
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Pos_HalfCutPaper();
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Pos_Barcode(String BarcodeData, int nBarcodeType, int nOrgx, int nUnitWidth, int nUnitHeight, int nFontStyle, int FontPosition);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Pos_Qrcode(Byte[] QrcodeData, int nWidth, int nVersion, int nErrlevenl);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Pos_EscQrcode(byte[] QrcodeData, int nWidth, int nErrlevenl);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Pos_DoubleQrcode(byte[] QrcodeData1,int QR1Position,int QR1Version, int QR1Ecc, byte[] QrcodeData2, int QR2Position, int QR2Version, int QR2Ecc, int ModuleSize);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Pos_ImagePrint(byte[] FileName, int nWidth, int nBinaryAlgorithm);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Pos_DownLoadNVLogo(byte[] FileName, int nBinaryAlgorithm);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Pos_PrintNVLogoByNumber(int nNumber, int mMode);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Pos_PrintNVLogo(UInt16 nLogo, UInt16 nWidth);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int Pos_QueryPrinterErr(uint nTimeout);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Pos_QueryStstus(byte[] rBuffer, int type, UInt32 nTimeout);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Pos_SetPrinterBaudrate(int nBaudrate);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Pos_SetPrinterBasic(int nFontStyle, int nDensity, int nLine, int nBeep, int nCut);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Page_SelectPageMode();
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Page_PrintPage();
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Page_ExitPageMode();
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Page_SetVerticalAbsolutePrintPosition(UInt16 nPosition);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Page_SetHorizontalAbsolutePrintPosition(UInt16 nPosition);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Page_SetVerticalRelativePrintPosition(UInt16 nPosition);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Page_SetHorizontalRelativePrintPosition(UInt16 nPosition);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Page_SetPageArea(UInt16 x, UInt16 y, UInt16 w, UInt16 h);
		[DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Page_SetPageModeDrawDirection(UInt16 nPosition);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Page_Text(byte[] prnText, int nLan, int nOrgx, int nWidthTimes, int nHeightTimes, int FontType, int nFontStyle);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Page_Barcode(String BarcodeData, int nBarcodeType, int nOrgx, int nUnitWidth, int nUnitHeight, int nFontStyle, int FontPosition);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Page_Qrcode(byte[] QrcodeData, int nWidth, int nErrlevenl);
        [DllImport("CsnPrinterLibs.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Page_ImagePrint(byte[] FileName, int nWidth, int nBinaryAlgorithm);

    }
}