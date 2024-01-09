using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class cStringManager
{

    public static int getNumWords(string pString, string pSeparator)
    {
        int index = 0;
        bool skip = false;
        bool last_skip = false;
        for (Int32 r = 0; r < pString.Length; r++)
        {
            char ca = pString[r];
            for (int s = 0; s < pSeparator.Length; s++)
            {
                if (ca == pSeparator[s])
                {
                    if (!last_skip && r != 0)
                        index++;
                    skip = true;
                    break;
                }
            }
            last_skip = skip;
            skip = false;
        }
        return index;
    }

    public static string getWord(int pIndex,string pString,string pSeparator)
    {
     int index = 0;
     string result = "";
     bool skip = false;
     bool last_skip = false;
     for(Int32 r=0;r<pString.Length;r++)
     {
      char ca = pString[r];
      for(int s=0;s<pSeparator.Length;s++)
      {
       if(ca == pSeparator[s])
       {
        if (!last_skip && r != 0)
        index++;
        skip = true;
        break;
       }
      }
      if (pIndex == index && !skip)
      {
          result += ca;
      }
      last_skip = skip;
      skip = false;
     }
     return result;
    }

    public static string remove(string _src,string _chars)
    {
        string result = "";
        for(int r=0;r<_src.Length;r++)
        {
            char ca = _src[r];
            bool del = false;
            for (int s = 0; s < _chars.Length; s++)
            {
                if(ca == _chars[s])
                {
                    del = true;
                    break;
                }
            }
            if (!del)
            {
                result += ca;
            }
        }
        return result;
    }

    public static string removeLast(string _src, int _num)
    {
        string result = "";
        for (int r = 0; r < _src.Length - _num; r++)
        {
            result += _src[r];
        }
        return result;
    }

    public static string replaceFirst(string _src, char _ca)
    {
        string result = "";
        result += _ca;
        for (int r=1;r<_src.Length;r++)
        {
            result += _src[r];
        }
        return result;
    }

    public static string readTo(string _src, char _char)
    {
        string result = "";
        for (int r = 0; r < _src.Length; r++)
        {
            char ca = _src[r];
            if(ca == _char) { return result; }
            result += ca;
        }
        return result;
    }

    public static string readFrom(string _src, int _num)
    {
        string result = "";
        for (int r = _num; r < _src.Length; r++)
        {
            char ca = _src[r];
            result += ca;
        }
        return result;
    }

	public static string Filter(string input,string regexFilter = "[^a-zA-Z0-9]")
    {
        var regex = new Regex(regexFilter);
        return regex.Replace(input, "");
    }

	public static string FilterNonNumeric(string input,string regexFilter = "[^0-9]")
    {
        var regex = new Regex(regexFilter);
        return regex.Replace(input, "");
    }

}
