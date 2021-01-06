using System;
using System.Windows.Forms;

namespace StarportExcel
{
	public partial class CustomMessageBox : Form
	{
		public CustomMessageBox()
		{
			InitializeComponent();
			lb_message.Text = lb_msg;
		}

		internal static void Show(string s)
        {
			CustomMessageBox box = new CustomMessageBox();
			box.Show;
			lb_msg = s;
        }

	}//CustomMessageBox
}//namespace
