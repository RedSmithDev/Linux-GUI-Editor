using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KitchenTimer;

namespace LSCFForms
{

	public partial class pnlMainForm : Form
	{

		private static cCounterHelper counter = new cCounterHelper();

		public pnlMainForm()

		{
			InitializeComponent();
			// Form Title can be chandeg from the editor
			Text = "KitchenTimer";
			// initialize the combobox with a variety of minutes to select
			cmbMinutes.Items.Add("00:05:00");
			cmbMinutes.Items.Add("00:10:00");
			cmbMinutes.Items.Add("00:15:00");
			cmbMinutes.Items.Add("00:30:00");
			cmbMinutes.Items.Add("00:45:00");
			cmbMinutes.Items.Add("01:00:00");
			// Initialize timer
			tht0.timer.Interval = 1000; // 1 second
			tht0.timer.Enabled = false;
			// Set options enabled by default
			chkPopUp.Checked = true;
			chkSound.Checked = true;
		}

		private void Controls_Click(Control sender, efrmMainControls ctlName, EventArgs e)
		{

			switch (ctlName)
			{
				case efrmMainControls.btnStart:
					tht0.timer.Enabled = true;
					counter.reset();
					break;
				case efrmMainControls.btnStop:
					tht0.timer.Enabled = false;
					counter.reset();
					lblElapsedTime.Text = "00:00:00";
					break;
			}
		}

		private void Controls_DoubleClick(Control sender, efrmMainControls ctlName, EventArgs e)
		{
			switch (ctlName)
			{
			}
		}

		private void Controls_KeyDown(Control sender, efrmMainControls ctlName, KeyEventArgs e)
		{
			switch (ctlName)
			{
			}
		}


		private void Controls_Tick(Control sender, efrmMainControls ctlName, EventArgs e)
		{
			switch (ctlName)
			{
				case efrmMainControls.tht0:
					string t = counter.get();
					lblElapsedTime.Text = t;
					bool finished = counter.isEqual(t, cmbMinutes.Text); // compare the string of timer counter with the time selected in the combobox
					if (finished)
					{
						tht0.timer.Enabled = false;
						if (chkSound.Enabled)
						{
							cSoundPlayer.PlaySound("../data/alarm.wav");
						}
						if (chkPopUp.Enabled)
						{
							MessageBox.Show("Elapsed " + t);
						}
						counter.reset();
					}
				 break;
			}
		}


	}
}
