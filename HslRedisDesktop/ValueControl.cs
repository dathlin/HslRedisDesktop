using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Linq;
using HslCommunication.BasicFramework;

namespace HslRedisDesktop
{
	public partial class ValueControl : UserControl
	{
		public ValueControl( )
		{
			InitializeComponent( );
		}

		public void SetValue(string value )
		{
			this.value = value;
			ShowValue( );
		}

		private void ShowValue( )
		{
			try
			{
				int size = Encoding.UTF8.GetBytes( value ).Length;
				label2.Text = "大小: " + SoftBasic.GetSizeDescription( size );

				if (radioButton1.Checked)
				{
					textBox1.Text = value;
				}
				else if (radioButton2.Checked)
				{
					textBox1.Text = JsonConvert.DeserializeObject( value ).ToString( );
				}
				else if (radioButton3.Checked)
				{
					textBox1.Text = XElement.Parse( value ).ToString( );
				}
			}
			catch
			{
				textBox1.Text = value;
			}
		}

		

		private void ValueControl_Load( object sender, EventArgs e )
		{
			radioButton1.CheckedChanged += RadioButton_CheckedChanged;
			radioButton2.CheckedChanged += RadioButton_CheckedChanged;
			radioButton3.CheckedChanged += RadioButton_CheckedChanged;
		}

		private void RadioButton_CheckedChanged( object sender, EventArgs e )
		{
			ShowValue( );
		}

		/// <summary>
		/// 获取到键的原始值，没有被修改之后的。
		/// </summary>
		/// <returns>原始值信息</returns>
		public string KeySourceValue( ) => value;

		private string value = string.Empty;

    }

}
