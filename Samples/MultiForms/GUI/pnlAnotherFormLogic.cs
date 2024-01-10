using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSCFForms
{

    public partial class pnlAnotherForm : Form
    {

		public pnlAnotherForm()
        {
            InitializeComponent();
        }
		
		private void Controls_Click(Control sender, efrmMainControls ctlName, EventArgs e)
		{
			switch(ctlName)
			{
				case efrmMainControls.btnCloseForm:
					Close();
				break;
				case efrmMainControls.btnAddItems:
					lst0.Items.Add("Item " + lst0.Items.Count);
				break;
				case efrmMainControls.btnClearItems:
					lst0.Items.Clear();
				break;				
			}
		}


		private void Controls_DoubleClick(Control sender, efrmMainControls ctlName, EventArgs e)
		{
			switch(ctlName)
			{
			}
		}


		private void Controls_KeyDown(Control sender, efrmMainControls ctlName, KeyEventArgs e)
		{
			switch(ctlName)
			{
			}
		}


		private void Controls_Tick(Control sender, efrmMainControls ctlName, EventArgs e)
		{
			switch(ctlName)
			{
			}
		}


    }
}
