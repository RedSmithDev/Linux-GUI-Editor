using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using LCSF_Editor.CustomControls;
using LCSF_Utils;

namespace LCSF_Editor
{
	public class cFormManager
	{

		public static int formTitleHeight = 30;

		public static void readForm(string filename, bool editor)
		{
			try
			{
				Form form = new Form();
				readForm(form, filename, editor);
				form.ShowDialog();
			}
			catch (Exception _e)
			{
				cDebug.Dummy(_e);
			}
		}

		public static void readForm(Form form, string filename, bool editor)
		{
			//try
			{
				readForm_s(form, filename, editor);
			}
			/*
            catch(Exception _e)
            {
                cDebug.Dummy(_e);
            }
            */
		}

		private static void readForm_s(Form form, string filename, bool editor)
		{
			readControls_s(form.Controls, form, filename, editor);
		}

		public static void readControlsToMem(string filename, List<string> list)
		{
			using (StreamReader reader = new StreamReader(filename))
			{
				while (!reader.EndOfStream)
				{
					string line = reader.ReadLine();
					list.Add(line);
				}
			}
		}

		public static void readControls_s(Control.ControlCollection controls, Form form, string filename, bool editor)
		{
			List<string> list = new List<string>();
			using (StreamReader reader = new StreamReader(filename))
			{
				while (!reader.EndOfStream)
				{
					string line = reader.ReadLine();
					list.Add(line);
				}
			}
			readControlsInMem_s(controls, form, list, editor);
		}

		public static void readControlsInMem_s(Control.ControlCollection controls, Form form, List<string> list, bool editor)
		{
			Size formSize = new Size(); // override at the end the form size, because sums "56" to the width from nohwere
			{
				bool isPanel = false;
				for (int r = 0; r < list.Count; r++)
				{
					string line = list[r];
					if (line.StartsWith("["))
					{
						isPanel = false;
						line = cStringManager.remove(line, "[]");
						Console.WriteLine(line);
						if (line == eCtlNames.Button)
						{
							Button ctl = new Button();
							ctl.FlatStyle = FlatStyle.Flat;
							controls.Add(ctl);
						}
						if (line == eCtlNames.Label)
						{
							Label ctl = new Label();
							ctl.FlatStyle = FlatStyle.Flat;
							ctl.TextAlign = ContentAlignment.MiddleLeft;
							if (editor)
							{
								ctl.BorderStyle = BorderStyle.FixedSingle;
							}
							controls.Add(ctl);
						}
						if (line == eCtlNames.TextInput || line == "TextBox")
						{
							if (editor)
							{
								TextInput ctl = new TextInput();
								ctl.BorderStyle = BorderStyle.FixedSingle;
								controls.Add(ctl);
							}
							else
							{
								TextBox ctl = new TextBox();
								ctl.BorderStyle = BorderStyle.FixedSingle;
								ctl.TextAlign = HorizontalAlignment.Left;
								controls.Add(ctl);
							}
						}
						if (line == eCtlNames.ComboBox)
						{
							ComboBox ctl = new ComboBox();
							ctl.FlatStyle = FlatStyle.Flat;
							controls.Add(ctl);
						}
						if (line == eCtlNames.ListBox)
						{
							ListBox ctl = new ListBox();
							ctl.BorderStyle = BorderStyle.FixedSingle;
							controls.Add(ctl);

						}
						if (line == eCtlNames.PictureBox)
						{
							PictureBox ctl = new PictureBox();
							ctl.BorderStyle = BorderStyle.FixedSingle;
							controls.Add(ctl);

						}
						if (line == eCtlNames.CheckBox)
						{
							CheckBox ctl = new CheckBox();
							ctl.FlatStyle = FlatStyle.Flat;
							controls.Add(ctl);

						}
						if (line == eCtlNames.RadioButton)
						{
							RadioButton ctl = new RadioButton();
							ctl.FlatStyle = FlatStyle.Flat;
							controls.Add(ctl);
						}
						if (line == eCtlNames.ProgressBar)
						{
							ProgressBar ctl = new ProgressBar();
							ctl.Style = ProgressBarStyle.Continuous;
							controls.Add(ctl);
						}
						if (line == eCtlNames.ThreadedTimer)
						{
							ThreadedTimer ctl = new ThreadedTimer();
							if (editor)
							{
								ctl.FlatStyle = FlatStyle.Flat;
							}
							controls.Add(ctl);
						}

						if (line == eCtlNames.Panel)
						{
							form.FormBorderStyle = FormBorderStyle.FixedSingle;
							isPanel = true;
						}
						continue;
					}

					int nw = cStringManager.getNumWords(line, ":");

					if (nw > 0)
					{
						string param = cStringManager.readTo(line, ':');
						string value = cStringManager.readFrom(line, param.Length + 1);
						Console.WriteLine("readForm -> name: " + param + " value: " + value);
						Control lastCtl;
						if (isPanel)
						{
							lastCtl = form;
							form.StartPosition = FormStartPosition.CenterScreen;
						}
						else
						{
							lastCtl = controls[controls.Count - 1];
						}
						if (param == ePropNames.Name)
						{
							lastCtl.Name = value;
						}
						if (param == ePropNames.Position)
						{
							lastCtl.Location = cConvert.ConvertStringToPoint(value);
						}
						if (param == ePropNames.Size)
						{
							if (isPanel)
							{
								lastCtl.Size = cConvert.ConvertStringToSize(value);
								formSize = lastCtl.Size;
							}
							else
							{
								lastCtl.Size = cConvert.ConvertStringToSize(value);
							}
						}

						if (param == ePropNames.Text)
						{
							lastCtl.Text = value;
							Console.WriteLine("Text -> " + lastCtl.Text + " " + param + " value: " + value);
						}
						if (param == ePropNames.BackColor)
						{
							lastCtl.BackColor = cConvert.ColorFromRgbString(value);
						}
						if (param == ePropNames.ForeColor)
						{
							lastCtl.ForeColor = cConvert.ColorFromRgbString(value);
						}
						if (param == ePropNames.FontName)
						{
							cConvert.changeFontName(lastCtl, value);
						}
						if (param == ePropNames.FontSize)
						{
							cConvert.changeFontSize(lastCtl, value);
						}
						if (param == ePropNames.MaximizeBox)
						{
							form.MaximizeBox = Convert.ToBoolean(value);
							if (form.MaximizeBox)
							{
								form.FormBorderStyle = FormBorderStyle.Sizable;
							}
						}
						if (param == ePropNames.MinimizeBox)
						{
							form.MinimizeBox = Convert.ToBoolean(value);
						}
						if (param == ePropNames.TextAlign)
						{
							if (lastCtl.GetType().Name == eCtlNames.Label)
							{
								Label ctl = (Label)lastCtl;
								cConvert.changeLabelAligmentFromString(ctl, value);
							}
							else
							{
								if (editor)
								{
									TextInput ctl = (TextInput)lastCtl;
									cConvert.changeTextInputAligmentFromString(ctl, value);
								}
								else
								{
									TextBox ctl = (TextBox)lastCtl;
									cConvert.changeTextAligmentFromString(ctl, value);
								}
							}
						}
						if (param == ePropNames.BorderStyle)
						{
							if (lastCtl.GetType().Name == eCtlNames.Label)
							{
								Label ctl = (Label)lastCtl;
								ctl.BorderStyle = cConvert.changeControlBorderStyleFromString(value);
							}
							if (lastCtl.GetType().Name == eCtlNames.TextInput || lastCtl.GetType().Name == "TextBox")
							{
								if (editor)
								{
									TextInput ctl = (TextInput)lastCtl;
									ctl.BorderStyle = cConvert.changeControlBorderStyleFromString(value);
								}
								else
								{
									TextBox ctl = (TextBox)lastCtl;
									ctl.BorderStyle = cConvert.changeControlBorderStyleFromString(value);
								}
							}
							if (lastCtl.GetType().Name == eCtlNames.ListBox)
							{
								ListBox ctl = (ListBox)lastCtl;
								ctl.BorderStyle = cConvert.changeControlBorderStyleFromString(value);
							}
							if (lastCtl.GetType().Name == eCtlNames.PictureBox)
							{
								PictureBox ctl = (PictureBox)lastCtl;
								ctl.BorderStyle = cConvert.changeControlBorderStyleFromString(value);
							}
						}
						if (param == ePropNames.TextType)
						{
							if(value == "Password")
							{
								if (editor)
								{
									TextInput ctl = (TextInput)lastCtl;
									ctl.inputType = value;
								}
								else
								{
									TextBox ctl = (TextBox)lastCtl;
									ctl.PasswordChar = '*';
								}
							}
						}
						if (param == ePropNames.Multiline)
						{
							if (editor)
							{
								TextInput ctl = (TextInput)lastCtl;
								ctl.Multiline = Convert.ToBoolean(value);
							}
							else
							{
								TextBox ctl = (TextBox)lastCtl;
								ctl.Multiline = Convert.ToBoolean(value);
							}
						}
						if (param == ePropNames.Value)
						{
							ProgressBar ctl = (ProgressBar)lastCtl;
							ctl.Value = Convert.ToInt16(value);
						}

					}
				}
			}
			form.Size = formSize;
		}


	}
}
