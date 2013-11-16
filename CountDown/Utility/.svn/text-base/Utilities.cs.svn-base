/*
 * Created by SharpDevelop.
 * User: Crick
 * Date: 18/04/2012
 * Time: 12.21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;

using RadioIncredibile.CountDown.Entity;
using TagLib;

namespace RadioIncredibile.CountDown.Utility
{
	/// <summary>
	/// Description of Utilities.
	/// </summary>
	public static class Utilities
	{
		public static ICollection<AudioFile> Purge(string []files)
		{
			List<AudioFile> audioFiles = new List<AudioFile>();
			List<File> tFiles = new List<File>();
			var availableFiles = files.ToList();
			/*
			 * mp3
			 */ 
			tFiles.AddRange(availableFiles
				.Where(file => file.Contains(".mp3"))
				.ToList().ConvertAll(file => new TagLib.Mpeg.AudioFile(file)).ToArray());
			/*
			 * wav
			 */ 
			tFiles.AddRange(availableFiles
				.Where(file => file.Contains(".wav"))
				.ToList().ConvertAll(file => new TagLib.Riff.File(file)).ToArray());

			audioFiles = tFiles.ConvertAll(f => new AudioFile(f.Name, new Duration(f.Properties.Duration)));
			
			return audioFiles;
		}
	}
}
