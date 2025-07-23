namespace CSharpDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openport = new System.Windows.Forms.Button();
            this.comport = new System.Windows.Forms.ComboBox();
            this.radiocom = new System.Windows.Forms.RadioButton();
            this.radiousb = new System.Windows.Forms.RadioButton();
            this.radiolpt = new System.Windows.Forms.RadioButton();
            this.radioprn = new System.Windows.Forms.RadioButton();
            this.radionet = new System.Windows.Forms.RadioButton();
            this.combaud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comflow = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usbport = new System.Windows.Forms.ComboBox();
            this.lptport = new System.Windows.Forms.ComboBox();
            this.prnport = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.netip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.netport = new System.Windows.Forms.TextBox();
            this.closeport = new System.Windows.Forms.Button();
            this.printtext = new System.Windows.Forms.Button();
            this.printimage = new System.Windows.Forms.Button();
            this.querystatus = new System.Windows.Forms.Button();
            this.downloadNVLogo = new System.Windows.Forms.Button();
            this.printNVLogo = new System.Windows.Forms.Button();
            this.printhex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openport
            // 
            this.openport.Location = new System.Drawing.Point(28, 216);
            this.openport.Name = "openport";
            this.openport.Size = new System.Drawing.Size(408, 23);
            this.openport.TabIndex = 0;
            this.openport.Text = "Open Port";
            this.openport.UseVisualStyleBackColor = true;
            this.openport.Click += new System.EventHandler(this.openport_Click);
            // 
            // comport
            // 
            this.comport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comport.FormattingEnabled = true;
            this.comport.Location = new System.Drawing.Point(87, 38);
            this.comport.Name = "comport";
            this.comport.Size = new System.Drawing.Size(56, 20);
            this.comport.TabIndex = 1;
            this.comport.Click += new System.EventHandler(this.comport_Click);
            // 
            // radiocom
            // 
            this.radiocom.AutoSize = true;
            this.radiocom.Checked = true;
            this.radiocom.Location = new System.Drawing.Point(28, 40);
            this.radiocom.Name = "radiocom";
            this.radiocom.Size = new System.Drawing.Size(41, 16);
            this.radiocom.TabIndex = 2;
            this.radiocom.TabStop = true;
            this.radiocom.Text = "COM";
            this.radiocom.UseVisualStyleBackColor = true;
            // 
            // radiousb
            // 
            this.radiousb.AutoSize = true;
            this.radiousb.Location = new System.Drawing.Point(28, 75);
            this.radiousb.Name = "radiousb";
            this.radiousb.Size = new System.Drawing.Size(41, 16);
            this.radiousb.TabIndex = 2;
            this.radiousb.Text = "USB";
            this.radiousb.UseVisualStyleBackColor = true;
            // 
            // radiolpt
            // 
            this.radiolpt.AutoSize = true;
            this.radiolpt.Location = new System.Drawing.Point(28, 107);
            this.radiolpt.Name = "radiolpt";
            this.radiolpt.Size = new System.Drawing.Size(41, 16);
            this.radiolpt.TabIndex = 2;
            this.radiolpt.Text = "LPT";
            this.radiolpt.UseVisualStyleBackColor = true;
            // 
            // radioprn
            // 
            this.radioprn.AutoSize = true;
            this.radioprn.Location = new System.Drawing.Point(28, 139);
            this.radioprn.Name = "radioprn";
            this.radioprn.Size = new System.Drawing.Size(41, 16);
            this.radioprn.TabIndex = 2;
            this.radioprn.Text = "PRN";
            this.radioprn.UseVisualStyleBackColor = true;
            // 
            // radionet
            // 
            this.radionet.AutoSize = true;
            this.radionet.Location = new System.Drawing.Point(28, 172);
            this.radionet.Name = "radionet";
            this.radionet.Size = new System.Drawing.Size(41, 16);
            this.radionet.TabIndex = 2;
            this.radionet.Text = "NET";
            this.radionet.UseVisualStyleBackColor = true;
            // 
            // combaud
            // 
            this.combaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combaud.FormattingEnabled = true;
            this.combaud.Location = new System.Drawing.Point(206, 38);
            this.combaud.Name = "combaud";
            this.combaud.Size = new System.Drawing.Size(71, 20);
            this.combaud.TabIndex = 1;
            this.combaud.SelectedIndexChanged += new System.EventHandler(this.combaud_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud Rate";
            // 
            // comflow
            // 
            this.comflow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comflow.FormattingEnabled = true;
            this.comflow.Location = new System.Drawing.Point(363, 38);
            this.comflow.Name = "comflow";
            this.comflow.Size = new System.Drawing.Size(73, 20);
            this.comflow.TabIndex = 1;
            this.comflow.SelectedIndexChanged += new System.EventHandler(this.comflow_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Flow Control";
            // 
            // usbport
            // 
            this.usbport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usbport.FormattingEnabled = true;
            this.usbport.Location = new System.Drawing.Point(87, 73);
            this.usbport.Name = "usbport";
            this.usbport.Size = new System.Drawing.Size(349, 20);
            this.usbport.TabIndex = 1;
            this.usbport.Click += new System.EventHandler(this.usbport_Click);
            // 
            // lptport
            // 
            this.lptport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lptport.FormattingEnabled = true;
            this.lptport.Location = new System.Drawing.Point(87, 105);
            this.lptport.Name = "lptport";
            this.lptport.Size = new System.Drawing.Size(349, 20);
            this.lptport.TabIndex = 1;
            this.lptport.Click += new System.EventHandler(this.lptport_Click);
            // 
            // prnport
            // 
            this.prnport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prnport.FormattingEnabled = true;
            this.prnport.Location = new System.Drawing.Point(87, 137);
            this.prnport.Name = "prnport";
            this.prnport.Size = new System.Drawing.Size(349, 20);
            this.prnport.TabIndex = 1;
            this.prnport.Click += new System.EventHandler(this.prnport_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "IP";
            // 
            // netip
            // 
            this.netip.Location = new System.Drawing.Point(105, 170);
            this.netip.Name = "netip";
            this.netip.Size = new System.Drawing.Size(197, 21);
            this.netip.TabIndex = 4;
            this.netip.Click += new System.EventHandler(this.netip_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port";
            // 
            // netport
            // 
            this.netport.Location = new System.Drawing.Point(343, 170);
            this.netport.Name = "netport";
            this.netport.Size = new System.Drawing.Size(93, 21);
            this.netport.TabIndex = 4;
            this.netport.Click += new System.EventHandler(this.netport_Click);
            // 
            // closeport
            // 
            this.closeport.Enabled = false;
            this.closeport.Location = new System.Drawing.Point(28, 245);
            this.closeport.Name = "closeport";
            this.closeport.Size = new System.Drawing.Size(408, 23);
            this.closeport.TabIndex = 0;
            this.closeport.Text = "Close Port";
            this.closeport.UseVisualStyleBackColor = true;
            this.closeport.Click += new System.EventHandler(this.closeport_Click);
            // 
            // printtext
            // 
            this.printtext.Enabled = false;
            this.printtext.Location = new System.Drawing.Point(28, 274);
            this.printtext.Name = "printtext";
            this.printtext.Size = new System.Drawing.Size(408, 23);
            this.printtext.TabIndex = 0;
            this.printtext.Text = "Print Text";
            this.printtext.UseVisualStyleBackColor = true;
            this.printtext.Click += new System.EventHandler(this.printtext_Click);
            // 
            // printimage
            // 
            this.printimage.Enabled = false;
            this.printimage.Location = new System.Drawing.Point(28, 333);
            this.printimage.Name = "printimage";
            this.printimage.Size = new System.Drawing.Size(408, 23);
            this.printimage.TabIndex = 0;
            this.printimage.Text = "Print Image";
            this.printimage.UseVisualStyleBackColor = true;
            this.printimage.Click += new System.EventHandler(this.printimage_Click);
            // 
            // querystatus
            // 
            this.querystatus.Enabled = false;
            this.querystatus.Location = new System.Drawing.Point(28, 420);
            this.querystatus.Name = "querystatus";
            this.querystatus.Size = new System.Drawing.Size(408, 23);
            this.querystatus.TabIndex = 5;
            this.querystatus.Text = "Query Status";
            this.querystatus.UseVisualStyleBackColor = true;
            this.querystatus.Click += new System.EventHandler(this.querystatus_Click);
            // 
            // downloadNVLogo
            // 
            this.downloadNVLogo.Enabled = false;
            this.downloadNVLogo.Location = new System.Drawing.Point(28, 363);
            this.downloadNVLogo.Name = "downloadNVLogo";
            this.downloadNVLogo.Size = new System.Drawing.Size(408, 23);
            this.downloadNVLogo.TabIndex = 6;
            this.downloadNVLogo.Text = "Down Load NV Logo";
            this.downloadNVLogo.UseVisualStyleBackColor = true;
            this.downloadNVLogo.Click += new System.EventHandler(this.downloadNVLogo_Click);
            // 
            // printNVLogo
            // 
            this.printNVLogo.Enabled = false;
            this.printNVLogo.Location = new System.Drawing.Point(28, 391);
            this.printNVLogo.Name = "printNVLogo";
            this.printNVLogo.Size = new System.Drawing.Size(408, 23);
            this.printNVLogo.TabIndex = 7;
            this.printNVLogo.Text = "Print NV Logo";
            this.printNVLogo.UseVisualStyleBackColor = true;
            this.printNVLogo.Click += new System.EventHandler(this.printNVLogo_Click);
            // 
            // printhex
            // 
            this.printhex.Enabled = false;
            this.printhex.Location = new System.Drawing.Point(31, 303);
            this.printhex.Name = "printhex";
            this.printhex.Size = new System.Drawing.Size(408, 23);
            this.printhex.TabIndex = 8;
            this.printhex.Text = "Print Hex Command";
            this.printhex.UseVisualStyleBackColor = true;
            this.printhex.Click += new System.EventHandler(this.printhex_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 449);
            this.Controls.Add(this.printhex);
            this.Controls.Add(this.printNVLogo);
            this.Controls.Add(this.downloadNVLogo);
            this.Controls.Add(this.querystatus);
            this.Controls.Add(this.netport);
            this.Controls.Add(this.netip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radionet);
            this.Controls.Add(this.radioprn);
            this.Controls.Add(this.radiolpt);
            this.Controls.Add(this.radiousb);
            this.Controls.Add(this.radiocom);
            this.Controls.Add(this.comflow);
            this.Controls.Add(this.combaud);
            this.Controls.Add(this.prnport);
            this.Controls.Add(this.lptport);
            this.Controls.Add(this.usbport);
            this.Controls.Add(this.comport);
            this.Controls.Add(this.printimage);
            this.Controls.Add(this.printtext);
            this.Controls.Add(this.closeport);
            this.Controls.Add(this.openport);
            this.MaximumSize = new System.Drawing.Size(486, 488);
            this.MinimumSize = new System.Drawing.Size(486, 458);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KPOS Print";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openport;
        private System.Windows.Forms.ComboBox comport;
        private System.Windows.Forms.RadioButton radiocom;
        private System.Windows.Forms.RadioButton radiousb;
        private System.Windows.Forms.RadioButton radiolpt;
        private System.Windows.Forms.RadioButton radioprn;
        private System.Windows.Forms.RadioButton radionet;
        private System.Windows.Forms.ComboBox combaud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comflow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox usbport;
        private System.Windows.Forms.ComboBox lptport;
        private System.Windows.Forms.ComboBox prnport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox netip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox netport;
        private System.Windows.Forms.Button closeport;
        private System.Windows.Forms.Button printtext;
        private System.Windows.Forms.Button printimage;
        private System.Windows.Forms.Button querystatus;
        private System.Windows.Forms.Button downloadNVLogo;
        private System.Windows.Forms.Button printNVLogo;
        private System.Windows.Forms.Button printhex;
    }
}

