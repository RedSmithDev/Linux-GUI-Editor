using System;
using System.Drawing;
using System.Windows.Forms;
using LCSF_Editor.CustomControls;
using LCSF_Utils;

public class cConvert
{
    public static Color ColorFromRgbString(string rgbString)
    {
        try
        {
            string[] rgbValues = rgbString.Split(',');
            int r = int.Parse(rgbValues[0]);
            int g = int.Parse(rgbValues[1]);
            int b = int.Parse(rgbValues[2]);
    
            return Color.FromArgb(r, g, b);
        }
        catch (Exception _e)
        {
            cDebug.Dummy(_e);
            return Color.FromArgb(0, 0, 0);
        }
    }

    public static string ColorToRgbString(Color color)
    {
        return $"{color.R},{color.G},{color.B}";
    }

    public static Point ConvertStringToPoint(string pointString)
    {
        try
        {
            string[] xy = pointString.Split(',');
            int x = int.Parse(xy[0]);
            int y = int.Parse(xy[1]);

            return new Point(x, y);
        }
        catch (Exception _e)
        {
            cDebug.Dummy(_e.ToString());
            return new Point(0, 0);
        }
    }

    public static Size ConvertStringToSize(string pointString)
    {
        try
        {
            string[] xy = pointString.Split(',');
            int x = int.Parse(xy[0]);
            int y = int.Parse(xy[1]);

            return new Size(x, y);
        }
        catch (Exception _e)
        {
            cDebug.Dummy(_e.ToString());
            return new Size(100, 100);
        }
    }

    public static void changeName(Control ctl, string newName)
    {
        string oldName = ctl.Name;
        try
        {
            ctl.Name = newName;
        }
        catch (Exception _e)
        {
            cDebug.Dummy(_e.ToString());
            ctl.Name = oldName;
        }
    }

    public static int toInt(string value, int valueOnFail = 0)
    {
        try
        {
            return Convert.ToInt16(value);
        }
        catch (Exception _e)
        {
            cDebug.Dummy(_e.ToString());
        }
        return valueOnFail;
    }

    public static void changeFontSize(Control ctl, string size)
    {
        Font lastFont = ctl.Font;
        try
        {
            float fsize = Convert.ToSingle(size);
            ctl.Font = new Font(ctl.Font.FontFamily, fsize);
        }
        catch (Exception _e)
        {
            cDebug.Dummy(_e.ToString());
            ctl.Font = lastFont;
        }
    }

    public static void changeFontName(Control ctl, string fontName)
    {
        Font lastFont = ctl.Font;
        try
        {
            ctl.Font = new Font(fontName, ctl.Font.Size);
        }
        catch (Exception _e)
        {
            cDebug.Dummy(_e.ToString());
            ctl.Font = lastFont;
        }
    }

	public static void changeZPosition(Control ctl, string zposition)
	{
		try
		{
			if (zposition == "Front")
			{
				ctl.BringToFront();
			}
			if (zposition == "Default")
			{

			}
			if (zposition == "Back")
			{
				ctl.SendToBack();
			}
		}
		catch (Exception _e)
		{
			cDebug.Dummy(_e.ToString());
		}
	}
	
	public static string changeTextInputAligmentToString(ContentAlignment aligmentType)
	{
		string textAlign = "Left";
		if(aligmentType ==  ContentAlignment.MiddleCenter)
		{
			textAlign = "Center";
		}
		if(aligmentType == ContentAlignment.MiddleRight)
		{
			textAlign = "Right";
		}
		return textAlign;
	}

	public static void changeTextInputAligmentFromString(TextInput txt, string aligmentType)
	{
		txt.TextAlign = ContentAlignment.MiddleLeft;
		if(aligmentType == "Center")
		{
			txt.TextAlign = ContentAlignment.MiddleCenter;
		}
		if(aligmentType == "Right")
		{
			txt.TextAlign = ContentAlignment.MiddleRight;
		}
	}

	public static string changeLabelAligmentToString(ContentAlignment aligmentType)
	{
		string textAlign = "Left";
		if(aligmentType ==  ContentAlignment.MiddleCenter)
		{
			textAlign = "Center";
		}
		if(aligmentType == ContentAlignment.MiddleRight)
		{
			textAlign = "Right";
		}
		return textAlign;
	}

	public static void changeLabelAligmentFromString(Label lbl, string aligmentType)
	{
		lbl.TextAlign = ContentAlignment.MiddleLeft;
		if(aligmentType == "Center")
		{
			lbl.TextAlign = ContentAlignment.MiddleCenter;
		}
		if(aligmentType == "Right")
		{
			lbl.TextAlign = ContentAlignment.MiddleRight;
		}
	}

	public static void changeTextAligmentFromString(TextBox txt, string aligmentType)
	{
		txt.TextAlign = HorizontalAlignment.Left;
		if(aligmentType == "Center")
		{
			txt.TextAlign = HorizontalAlignment.Center;
		}
		if(aligmentType == "Right")
		{
			txt.TextAlign = HorizontalAlignment.Right;
		}
	}

	public static BorderStyle changeControlBorderStyleFromString(string sborderStyle)
	{
		BorderStyle borderStyle = BorderStyle.None;
		if(sborderStyle == "Outlined")
		{
			borderStyle = BorderStyle.FixedSingle;
		}
		return borderStyle;
	}
	
	public static string changeControlBorderStyleToString(BorderStyle borderStyle)
	{
		string sborderStyle = "None";
		if( borderStyle ==  BorderStyle.FixedSingle)
		{
			sborderStyle = "Outlined";
		}
		return sborderStyle;
	}

}

