using System;
using System.Windows.Forms;

namespace LCSF_Editor.CustomControls
{
	public class TextInput : Label
	{
		public TextInput()
		{
			inputType = "Text";
			Multiline = false;
		}
		public string inputType = "Text";
		public bool   Multiline = false;
	}
}