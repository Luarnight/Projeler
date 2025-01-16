/*
 * Created by SharpDevelop.
 * User: USER
 * Date: 5.12.2024
 * Time: 20:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace seriport
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnaç;
		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.Button btnKapat;
		private System.Windows.Forms.TextBox textcom;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label baudrate;
		private System.Windows.Forms.TextBox textBaudrate;
		private System.Windows.Forms.Label databits;
		private System.Windows.Forms.TextBox textDataBits;
		private System.Windows.Forms.Label gonder;
		private System.Windows.Forms.TextBox textSaatgönder;
		private System.Windows.Forms.Button btnSaatgonder;
		private System.Windows.Forms.Label lcdsaat;
		private System.Windows.Forms.TextBox textLcdsaat;
		private System.Windows.Forms.Label adcgöster;
		private System.Windows.Forms.TextBox textADC;
		private System.Windows.Forms.Label metin;
		private System.Windows.Forms.TextBox textMetingönder;
		private System.Windows.Forms.Button btnMetingonder;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btnaç = new System.Windows.Forms.Button();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.btnKapat = new System.Windows.Forms.Button();
			this.textcom = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.baudrate = new System.Windows.Forms.Label();
			this.textBaudrate = new System.Windows.Forms.TextBox();
			this.databits = new System.Windows.Forms.Label();
			this.textDataBits = new System.Windows.Forms.TextBox();
			this.gonder = new System.Windows.Forms.Label();
			this.textSaatgönder = new System.Windows.Forms.TextBox();
			this.btnSaatgonder = new System.Windows.Forms.Button();
			this.lcdsaat = new System.Windows.Forms.Label();
			this.textLcdsaat = new System.Windows.Forms.TextBox();
			this.adcgöster = new System.Windows.Forms.Label();
			this.textADC = new System.Windows.Forms.TextBox();
			this.metin = new System.Windows.Forms.Label();
			this.textMetingönder = new System.Windows.Forms.TextBox();
			this.btnMetingonder = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnaç
			// 
			this.btnaç.Location = new System.Drawing.Point(394, 12);
			this.btnaç.Name = "btnaç";
			this.btnaç.Size = new System.Drawing.Size(89, 52);
			this.btnaç.TabIndex = 0;
			this.btnaç.Text = "Aç";
			this.btnaç.UseVisualStyleBackColor = true;
			this.btnaç.Click += new System.EventHandler(this.Button1Click);
			// 
			// serialPort1
			// 
			this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1DataReceived);
			// 
			// btnKapat
			// 
			this.btnKapat.Location = new System.Drawing.Point(394, 80);
			this.btnKapat.Name = "btnKapat";
			this.btnKapat.Size = new System.Drawing.Size(88, 48);
			this.btnKapat.TabIndex = 1;
			this.btnKapat.Text = "Kapat";
			this.btnKapat.UseVisualStyleBackColor = true;
			this.btnKapat.Click += new System.EventHandler(this.Button2Click);
			// 
			// textcom
			// 
			this.textcom.Location = new System.Drawing.Point(199, 12);
			this.textcom.Name = "textcom";
			this.textcom.Size = new System.Drawing.Size(133, 26);
			this.textcom.TabIndex = 2;
			this.textcom.Text = "COM6";
			this.textcom.TextChanged += new System.EventHandler(this.TextcomTextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(44, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "COM No";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// baudrate
			// 
			this.baudrate.Location = new System.Drawing.Point(44, 56);
			this.baudrate.Name = "baudrate";
			this.baudrate.Size = new System.Drawing.Size(100, 23);
			this.baudrate.TabIndex = 4;
			this.baudrate.Text = "Baudrate";
			// 
			// textBaudrate
			// 
			this.textBaudrate.Location = new System.Drawing.Point(199, 53);
			this.textBaudrate.Name = "textBaudrate";
			this.textBaudrate.Size = new System.Drawing.Size(133, 26);
			this.textBaudrate.TabIndex = 5;
			this.textBaudrate.Text = "115200";
			// 
			// databits
			// 
			this.databits.Location = new System.Drawing.Point(46, 94);
			this.databits.Name = "databits";
			this.databits.Size = new System.Drawing.Size(98, 24);
			this.databits.TabIndex = 6;
			this.databits.Text = "Data Bits";
			this.databits.Click += new System.EventHandler(this.DatabitsClick);
			// 
			// textDataBits
			// 
			this.textDataBits.Location = new System.Drawing.Point(199, 91);
			this.textDataBits.Name = "textDataBits";
			this.textDataBits.Size = new System.Drawing.Size(133, 26);
			this.textDataBits.TabIndex = 7;
			this.textDataBits.Text = "8";
			// 
			// gonder
			// 
			this.gonder.Location = new System.Drawing.Point(44, 148);
			this.gonder.Name = "gonder";
			this.gonder.Size = new System.Drawing.Size(123, 33);
			this.gonder.TabIndex = 8;
			this.gonder.Text = "Saat Başlangıcı";
			// 
			// textSaatgönder
			// 
			this.textSaatgönder.Location = new System.Drawing.Point(199, 148);
			this.textSaatgönder.Multiline = true;
			this.textSaatgönder.Name = "textSaatgönder";
			this.textSaatgönder.Size = new System.Drawing.Size(133, 33);
			this.textSaatgönder.TabIndex = 9;
			this.textSaatgönder.TextChanged += new System.EventHandler(this.TextSaatgönderTextChanged);
			// 
			// btnSaatgonder
			// 
			this.btnSaatgonder.Location = new System.Drawing.Point(394, 148);
			this.btnSaatgonder.Name = "btnSaatgonder";
			this.btnSaatgonder.Size = new System.Drawing.Size(101, 33);
			this.btnSaatgonder.TabIndex = 10;
			this.btnSaatgonder.Text = "Başlat";
			this.btnSaatgonder.UseVisualStyleBackColor = true;
			this.btnSaatgonder.Click += new System.EventHandler(this.BtnGonderClick);
			// 
			// lcdsaat
			// 
			this.lcdsaat.Location = new System.Drawing.Point(46, 208);
			this.lcdsaat.Name = "lcdsaat";
			this.lcdsaat.Size = new System.Drawing.Size(100, 23);
			this.lcdsaat.TabIndex = 11;
			this.lcdsaat.Text = "LCD Saati";
			this.lcdsaat.Click += new System.EventHandler(this.GelenClick);
			// 
			// textLcdsaat
			// 
			this.textLcdsaat.BackColor = System.Drawing.SystemColors.HighlightText;
			this.textLcdsaat.ForeColor = System.Drawing.SystemColors.WindowText;
			this.textLcdsaat.Location = new System.Drawing.Point(199, 203);
			this.textLcdsaat.Multiline = true;
			this.textLcdsaat.Name = "textLcdsaat";
			this.textLcdsaat.Size = new System.Drawing.Size(218, 28);
			this.textLcdsaat.TabIndex = 12;
			this.textLcdsaat.TextChanged += new System.EventHandler(this.TextGelenveriTextChanged);
			// 
			// adcgöster
			// 
			this.adcgöster.Location = new System.Drawing.Point(44, 251);
			this.adcgöster.Name = "adcgöster";
			this.adcgöster.Size = new System.Drawing.Size(100, 23);
			this.adcgöster.TabIndex = 13;
			this.adcgöster.Text = "ADC Verisi";
			this.adcgöster.Click += new System.EventHandler(this.Label2Click);
			// 
			// textADC
			// 
			this.textADC.Location = new System.Drawing.Point(199, 248);
			this.textADC.Name = "textADC";
			this.textADC.Size = new System.Drawing.Size(133, 26);
			this.textADC.TabIndex = 14;
			this.textADC.TextChanged += new System.EventHandler(this.TextADCTextChanged);
			// 
			// metin
			// 
			this.metin.Location = new System.Drawing.Point(43, 310);
			this.metin.Name = "metin";
			this.metin.Size = new System.Drawing.Size(124, 40);
			this.metin.TabIndex = 15;
			this.metin.Text = "Gönderilecek Metin";
			this.metin.Click += new System.EventHandler(this.SaatbaşlatClick);
			// 
			// textMetingönder
			// 
			this.textMetingönder.Location = new System.Drawing.Point(199, 307);
			this.textMetingönder.Multiline = true;
			this.textMetingönder.Name = "textMetingönder";
			this.textMetingönder.Size = new System.Drawing.Size(218, 43);
			this.textMetingönder.TabIndex = 16;
			this.textMetingönder.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
			// 
			// btnMetingonder
			// 
			this.btnMetingonder.Location = new System.Drawing.Point(442, 310);
			this.btnMetingonder.Name = "btnMetingonder";
			this.btnMetingonder.Size = new System.Drawing.Size(97, 40);
			this.btnMetingonder.TabIndex = 17;
			this.btnMetingonder.Text = "Gönder";
			this.btnMetingonder.UseVisualStyleBackColor = true;
			this.btnMetingonder.Click += new System.EventHandler(this.BtnMetingonderClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(868, 548);
			this.Controls.Add(this.btnMetingonder);
			this.Controls.Add(this.textMetingönder);
			this.Controls.Add(this.metin);
			this.Controls.Add(this.textADC);
			this.Controls.Add(this.adcgöster);
			this.Controls.Add(this.textLcdsaat);
			this.Controls.Add(this.lcdsaat);
			this.Controls.Add(this.btnSaatgonder);
			this.Controls.Add(this.textSaatgönder);
			this.Controls.Add(this.gonder);
			this.Controls.Add(this.textDataBits);
			this.Controls.Add(this.databits);
			this.Controls.Add(this.textBaudrate);
			this.Controls.Add(this.baudrate);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textcom);
			this.Controls.Add(this.btnKapat);
			this.Controls.Add(this.btnaç);
			this.Name = "MainForm";
			this.Text = "seriport";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
