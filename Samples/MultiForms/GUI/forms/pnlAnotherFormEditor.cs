using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LCSF_Editor;
using LCSF_Editor.CustomControls;

// EDITOR GENERATED CODE THIS FILE IS OVERRIDED , CUSTOM CODE RELATED TO CONTROLS , PUT in the "GUI/pnlXXXXLogic.cs"

namespace LSCFForms
{

partial class pnlAnotherForm

    {

		public enum efrmMainControls
		{
			pnlAnotherForm,
			btnAddItems,
			lst0,
			btnCloseForm,
			btnClearItems,
			COUNT
		};


		Button btnClearItems = new Button();
		Button btnCloseForm = new Button();
		ListBox lst0 = new ListBox();
		Button btnAddItems = new Button();


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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlAnotherForm));


		memFormList.Add("[Panel]");
		memFormList.Add("Name:pnlAnotherForm");
		memFormList.Add("MaximizeBox:True");
		memFormList.Add("MinimizeBox:True");
		memFormList.Add("Size:328,270");
		memFormList.Add("FontName:DejaVu Sans");
		memFormList.Add("FontSize:9.75");
		memFormList.Add("BackColor:100,100,100");
		memFormList.Add("ForeColor:211,211,211");
		memFormList.Add("Text:AnotherForm");
		memFormList.Add("[Button]");
		memFormList.Add("Name:btnClearItems");
		memFormList.Add("Position:10,110");
		memFormList.Add("Size:99,30");
		memFormList.Add("FontName:DejaVu Sans");
		memFormList.Add("FontSize:9.75");
		memFormList.Add("BackColor:100,100,100");
		memFormList.Add("ForeColor:211,211,211");
		memFormList.Add("Text:Clear Items");
		memFormList.Add("FlatStyle:Flat");
		memFormList.Add("[Button]");
		memFormList.Add("Name:btnCloseForm");
		memFormList.Add("Position:10,170");
		memFormList.Add("Size:99,30");
		memFormList.Add("FontName:DejaVu Sans");
		memFormList.Add("FontSize:9.75");
		memFormList.Add("BackColor:100,100,100");
		memFormList.Add("ForeColor:211,211,211");
		memFormList.Add("Text:Close Form");
		memFormList.Add("FlatStyle:Flat");
		memFormList.Add("[ListBox]");
		memFormList.Add("Name:lst0");
		memFormList.Add("Position:150,30");
		memFormList.Add("Size:156,189");
		memFormList.Add("FontName:DejaVu Sans");
		memFormList.Add("FontSize:9.75");
		memFormList.Add("BackColor:100,100,100");
		memFormList.Add("ForeColor:211,211,211");
		memFormList.Add("Text:ListBox0");
		memFormList.Add("BorderStyle:FixedSingle");
		memFormList.Add("BorderStyle:Outlined");
		memFormList.Add("[Button]");
		memFormList.Add("Name:btnAddItems");
		memFormList.Add("Position:10,60");
		memFormList.Add("Size:99,30");
		memFormList.Add("FontName:DejaVu Sans");
		memFormList.Add("FontSize:9.75");
		memFormList.Add("BackColor:100,100,100");
		memFormList.Add("ForeColor:211,211,211");
		memFormList.Add("Text:AddItems");
		memFormList.Add("FlatStyle:Flat");

            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            // this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(Width, Height);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Name ="pnlAnotherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text ="AnotherForm";
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

			btnClearItems = (Button)getControl(efrmMainControls.btnClearItems);
			btnCloseForm = (Button)getControl(efrmMainControls.btnCloseForm);
			lst0 = (ListBox)getControl(efrmMainControls.lst0);
			btnAddItems = (Button)getControl(efrmMainControls.btnAddItems);


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
