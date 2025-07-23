// CPlusPlusDemoDlg.h : ͷ�ļ�
//

#pragma once


// CCPlusPlusDemoDlg �Ի���
class CCPlusPlusDemoDlg : public CDialog
{
// ����
public:
	CCPlusPlusDemoDlg(CWnd* pParent = NULL);	// ��׼���캯��
private:
	void openinit();
	void closeinit();
	void EnumCOM();
	void EnumUSB();
	void EnumLPT();
	void EnumPRN();

// �Ի�������
	enum { IDD = IDD_CPLUSPLUSDEMO_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV ֧��


// ʵ��
protected:
	HICON m_hIcon;

	// ���ɵ���Ϣӳ�亯��
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:
	// ���ڶ˿�����	// ���ڶ˿�����
	CComboBox comname;
	afx_msg void OnBnClickedButtonopen();
	// ö��USB�˿�
	CComboBox usbname;
	// ö��lpt�˿�
	CComboBox lptname;
	// ö��prn�˿�
	CComboBox prnname;
	// ���ڲ�����
	CComboBox combaud;
	// ��������
	CComboBox comflow;
	// ѡ�񴮿�
	CButton comtype;
	// ѡ��USB
	CButton usbtype;
	// ѡ��LPT
	CButton lpttype;
	// ѡ��PRN
	CButton prntype;
	// ѡ������
	CButton nettype;

	virtual void OnOK();

	CString netip;
	CString netport;

	void *handle;
	// �򿪶˿�
	CButton _openport;
	// �رն˿�
	CButton _closeport;
	// ��ӡ�ı�
	CButton _printtext;
	// ��ӡHEX����
	CButton _printhexCmd;
	// ��ӡͼƬ
	CButton _printimage;
	// Down load NV logo
	CButton _downloadNVLogo;
	// Print NV logo
	CButton _printNVLogo;
	// ��ѯ
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
