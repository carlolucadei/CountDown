/*
 * Creato da SharpDevelop.
 * Utente: Crick
 * Data: 18/04/2012
 * Ora: 10.45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
namespace RadioIncredibile.CountDown.Entity
{
	/// <summary>
	/// Description of AudioFile.
	/// </summary>
	public class AudioFile
	{
		protected Duration _duration;
		protected string _fileName;
		public AudioFile(string fileName, Duration duration)
		{
			if(string.IsNullOrEmpty(fileName))
				throw new ArgumentException("Cannot build AudioFile", "fileName");
			_fileName = Path.GetFileName(fileName);
			_duration = duration;
		}
		
		public Duration Duration
		{
			get { return _duration; }
			set { _duration = value; }
		}
		public string FileName
		{
			get { return _fileName; }
			private set { _fileName = value; }
		}
	}
	
	public class Duration
	{
		protected TimeSpan _duration;
	
		public Duration(int minute, int second)
		{
			_duration = new TimeSpan(0, minute, second);
		}
		
		public Duration(string minute, string second)
		{
			_duration = new TimeSpan(0, int.Parse(minute), int.Parse(second));
		}
		public Duration(TimeSpan time)
		{
			_duration = time;
		}
		public Duration()
		{
			_duration = new TimeSpan(0, 0, 0);
		}
		public int Minute { get { return _duration.Minutes + _duration.Hours * 60; } }
		public int Second { get { return _duration.Seconds; } }
		public override string ToString()
		{
			return Minute.ToString("00")+ ":" + Second.ToString("00");
		}
		public static Duration operator +(Duration x, Duration y)
		{
			return new Duration(x._duration.Add(new TimeSpan(0, y.Minute, y.Second)));
		}
	}
}
