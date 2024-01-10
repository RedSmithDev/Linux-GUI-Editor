using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LCSF_Editor;
using LCSF_Editor.CustomControls;

// EDITOR GENERATED CODE THIS FILE IS OVERRIDED , CUSTOM CODE RELATED TO CONTROLS , PUT in the "GUI/pnlXXXXLogic.cs"

namespace LSCFForms
{

partial class pnlMainForm

    {

		public enum efrmMainControls
		{
			pnlMainForm,
			tht0,
			btnOoenForm,
			COUNT
		};


		Button btnOoenForm = new Button();
		ThreadedTimer tht0 = new ThreadedTimer();


		public List<string> memFormList = new List<string>();

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private Dictionary<string, efrmMainControls> dCtlName = new Dictionary<string, efrmMainControls>();
        private Dictionary<string, Control> dCtls = new Dictionary<string, Control>();

        private void InitializeComponent()
        {
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlMainForm));


		memFormList.Add("[Panel]");
		memFormList.Add("Name:pnlMainForm");
		memFormList.Add("MaximizeBox:True");
		memFormList.Add("MinimizeBox:True");
		memFormList.Add("Size:292,150");
		memFormList.Add("FontName:DejaVu Sans");
		memFormList.Add("FontSize:12");
		memFormList.Add("BackColor:100,100,100");
		memFormList.Add("ForeColor:211,211,211");
		memFormList.Add("Text:MultiForms");
		memFormList.Add("[Button]");
		memFormList.Add("Name:btnOoenForm");
		memFormList.Add("Position:60,40");
		memFormList.Add("Size:171,42");
		memFormList.Add("FontName:DejaVu Sans");
		memFormList.Add("FontSize:11");
		memFormList.Add("BackColor:100,100,100");
		memFormList.Add("ForeColor:211,211,211");
		memFormList.Add("Text:OoenForm");
		memFormList.Add("FlatStyle:Flat");
		memFormList.Add("[ThreadedTimer]");
		memFormList.Add("Name:tht0");
		memFormList.Add("Position:20,130");
		memFormList.Add("Size:140,23");
		memFormList.Add("FontName:DejaVu Sans");
		memFormList.Add("FontSize:11");
		memFormList.Add("BackColor:100,100,100");
		memFormList.Add("ForeColor:211,211,211");
		memFormList.Add("Text:ThreadedTimer0");

            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            // this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(Width, Height);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Name ="pnlMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text ="MultiForms";
            this.ResumeLayout(false);
            this.PerformLayout();

		cFormManager.readControlsInMem_s(Controls, this, memFormList,false);


            Console.WriteLine("Main form loaded");

            this.Click += new System.EventHandler(this.Controls_Click);
            this.DoubleClick += new System.EventHandler(this.Controls_DoubleClick);

            for (int r=0;r<Controls.Count;r++)
            {
                Controls[r].Click       += new System.EventHandler(this.Controls_Click);
                Controls[r].DoubleClick += new System.EventHandler(this.Controls_DoubleClick);
                Controls[r].KeyDown 	+= new KeyEventHandler(this.Controls_KeyDown);
                try{dCtls.Add(Controls[r].Name,Controls[r]);}catch(Exception _e){}
            }

            for (int r = 0; r < (int)efrmMainControls.COUNT; r++)
            {
                string ctlName = Enum.GetName(typeof(efrmMainControls), r);
                dCtlName.Add(ctlName, (efrmMainControls)r);
            }

			btnOoenForm = (Button)getControl(efrmMainControls.btnOoenForm);
			tht0 = (ThreadedTimer)getControl(efrmMainControls.tht0);
			tht0.Visible = false;
			tht0.timer.Tick += (sender, e) => Controls_Tick(sender, e, tht0);
			tht0.timer.Enabled = true;
			tht0.timer.Interval = 100;


        }

		public Control getControl(efrmMainControls control)
		{
			string ctlName = Enum.GetName(typeof(efrmMainControls), control);
			return dCtls[ctlName];
		}

        private efrmMainControls checkDCtlName(string ctlName)
        {
            efrmMainControls result = efrmMainControls.COUNT;

            try
            {
                result = dCtlName[ctlName];
            }
            catch(Exception _e)
            {
                result = efrmMainControls.COUNT;
            }
            return result;
        }

        private void Controls_Click(object sender, EventArgs e)
        {
            Control ctl = (Control)sender;
            Controls_Click(ctl, checkDCtlName(ctl.Name), e);
        }

        private void Controls_DoubleClick(object sender, EventArgs e)
        {
            Control ctl = (Control)sender;
            Controls_DoubleClick(ctl, checkDCtlName(ctl.Name), e);
        }
 
        private void Controls_KeyDown(object sender, KeyEventArgs e)
        {
            Control ctl = (Control)sender;
            Controls_KeyDown(ctl, checkDCtlName(ctl.Name), e);
		}

        private void Controls_Tick(object sender, EventArgs e,Control ctl)
        {
            Controls_Tick(ctl, checkDCtlName(ctl.Name), e);
        }

        #endregion

    }
}
