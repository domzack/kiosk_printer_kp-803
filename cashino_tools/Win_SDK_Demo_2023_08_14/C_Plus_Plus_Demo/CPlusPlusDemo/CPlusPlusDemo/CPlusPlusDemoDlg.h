// CPlusPlusDemoDlg.h : 头文件
//

#pragma once


// CCPlusPlusDemoDlg 对话框
class CCPlusPlusDemoDlg : public CDialog
{
// 构造
public:
	CCPlusPlusDemoDlg(CWnd* pParent = NULL);	// 标准构造函数
private:
	void openinit();
	void closeinit();
	void EnumCOM();
	void EnumUSB();
	void EnumLPT();
	void EnumPRN();

// 对话框数据
	enum { IDD = IDD_CPLUSPLUSDEMO_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV 支持


// 实现
protected:
	HICON m_hIcon;

	// 生成的消息映射函数
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:
	// 串口端口名称	// 串口端口名称
	CComboBox comname;
	afx_msg void OnBnClickedButtonopen();
	// 枚举USB端口
	CComboBox usbname;
	// 枚举lpt端口
	CComboBox lptname;
	// 枚举prn端口
	CComboBox prnname;
	// 串口波特率
	CComboBox combaud;
	// 串口流控
	CComboBox comflow;
	// 选择串口
	CButton comtype;
	// 选择USB
	CButton usbtype;
	// 选择LPT
	CButton lpttype;
	// 选择PRN
	CButton prntype;
	// 选择网口
	CButton nettype;

	virtual void OnOK();

	CString netip;
	CString netport;

	void *handle;
	// 打开端口
	CButton _openport;
	// 关闭端口
	CButton _closeport;
	// 打印文本
	CButton _printtext;
	// 打印HEX命令
	CButton _printhexCmd;
	// 打印图片
	CButton _printimage;
	// Down load NV logo
	CButton _downloadNVLogo;
	// Print NV logo
	CButton _printNVLogo;
	// 查询
	CButton _querystatus;
//	afx_msg void OnCbnSetfocusCombousbport();
//	afx_msg void OnCbnSetfocusCombolptport();
//	afx_msg void OnCbnSetfocusComboprnport();
	afx_msg void OnEnSetfocusEditnetip();
	afx_msg void OnEnSetfocusEditnetport();
//	afx_msg void OnCbnSetfocusCombocomport();
	afx_msg void OnCbnSetfocusCombocombaud();
	afx_msg void OnCbnSetfocusCombocomflow();
	afx_msg void OnBnClickedButtonclose();
	afx_msg void OnBnClickedButtontext();
	afx_msg void OnBnClickedButtonimage();
	afx_msg void OnBnClickedButtonstatus();
	afx_msg void OnEnKillfocusEditnetip();
	afx_msg void OnEnKillfocusEditnetport();
//	afx_msg void OnCbnSelchangeCombousbport();
	afx_msg void OnCbnDropdownCombousbport();
	afx_msg void OnCbnDropdownCombolptport();
	afx_msg void OnCbnDropdownComboprnport();
	afx_msg void OnCbnDropdownCombocomport();
	afx_msg void OnBnClickedButtonDownLogo();
	afx_msg void OnBnClickedButtonPrintLogo();
	afx_msg void OnBnClickedButtonHex();
};
