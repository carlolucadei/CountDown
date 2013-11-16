/*
 * Creato da SharpDevelop.
 * Utente: Crick
 * Data: 08/03/2011
 * Ora: 19.58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using RadioIncredibile.CountDown.Entity;

namespace RadioIncredibile.CountDown.FileController
{
	/// <summary>
	/// Description of PlayListItem.
	/// </summary>
	public partial class PlayListItem : UserControl
	{
		protected AudioFile _item;		
		public PlayListItem()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		public PlayListItem(AudioFile item) : this()
		{
			_item = item;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.lRealDuration.Text = _item.Duration.ToString();
			this.lRealFileName.Text = _item.FileName;
		}
		public PlayListItem(Duration total) : this()
		{
			_item = new TotalAudioFile(total);
			this.lFileName.Visible = false;
			this.lRealFileName.Text = _item.FileName;
			this.lDuration.Visible = false;
			this.lRealDuration.Text = _item.Duration.ToString();
		}
		public string FileName { get { return _item.FileName; } }
		public Duration Duration {get { return _item.Duration;} }
	}
	
	
	public class TotalAudioFile : AudioFile
	{
		public TotalAudioFile(Duration duration) :
			base("Total", duration)
		{
		}
	}
}
