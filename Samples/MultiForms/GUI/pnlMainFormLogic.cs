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

    public partial class pnlMainForm : Form
    {


	public pnlMainForm()

        {
            InitializeComponent();
        }

	private void Controls_Click(Control sender, efrmMainControls ctlName, EventArgs e)
	{
		switch(ctlName)
		{
			case efrmMainControls.btnOoenForm:
				pnlAnotherForm frmAnotherForm = new pnlAnotherForm();
				frmAnotherForm.ShowDialog();
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
		case efrmMainControls.tht0:
		{
		}
		break;
		}
	}


    }
}
