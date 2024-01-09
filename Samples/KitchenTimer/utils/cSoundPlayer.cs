using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

public class cSoundPlayer
{
	public static void PlaySound(string filePath)
	{
		try
		{
			Process.Start("aplay", filePath);
		}
		catch (Exception ex)
		{
			Console.WriteLine($"aplay no found Error playing sound: {ex.Message}");
		}
	}
}