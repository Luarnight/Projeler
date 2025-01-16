/*
 * Created by SharpDevelop.
 * User: USER
 * Date: 5.12.2024
 * Time: 20:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace seriport
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string gelenveri = string.Empty;
		
	
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();	
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			if(!serialPort1.IsOpen)
			{
				serialPort1.PortName = textcom.Text;
				serialPort1.BaudRate = Convert.ToInt32(textBaudrate.Text);
				serialPort1.DataBits = Convert.ToInt32(textDataBits.Text);
				serialPort1.Open();
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			if(serialPort1.IsOpen)
			{
				serialPort1.Close();
			}
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void TextcomTextChanged(object sender, EventArgs e)
		{
	
		}
		void BtnGonderClick(object sender, EventArgs e)
		{
			serialPort1.Write("%"+textSaatgönder.Text);
			
		}
		void SerialPort1DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
				gelenveri=serialPort1.ReadLine();
				this.Invoke(new EventHandler(DisplayText));
		}
		private void DisplayText(object sender, EventArgs e)
		{
			
			if(gelenveri[0]=='*')
			{
				textLcdsaat.Text=gelenveri.Substring(1,8);
			}
			else if (gelenveri[0]=='[')
			{
				textADC.Text=gelenveri.Substring(1,4);
			}
		}
		void DatabitsClick(object sender, EventArgs e)
		{
	
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void TextGelenveriTextChanged(object sender, EventArgs e)
		{
	
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		void GelenClick(object sender, EventArgs e)
		{
	
		}
		void TextBox2TextChanged(object sender, EventArgs e)
		{
	
		}
		void SaatbaşlatClick(object sender, EventArgs e)
		{
	
		}
		void TextSaatgönderTextChanged(object sender, EventArgs e)
		{
	
		}
		void BtnMetingonderClick(object sender, EventArgs e)
		{
			serialPort1.Write("{"+ textMetingönder.Text +"}");
		}
		void TextADCTextChanged(object sender, EventArgs e)
		{
	
		}
	}
}
