/*
 * Created by SharpDevelop.
 * User: Crick
 * Date: 19/04/2012
 * Time: 11.24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using RadioIncredibile.CountDown.Entity;
using RadioIncredibile.CountDown.Utility;
using RadioIncredibile.CountDown.View;

namespace RadioIncredibile.CountDown.Presenter
{
	/// <summary>
	/// Description of OptionPresenter.
	/// </summary>
	public class OptionPresenter
	{
		protected IOptionView view;
		protected List<AudioFile> tracks;
		protected Duration average;
		public OptionPresenter(IOptionView view)
		{
			this.view = view;
			this.tracks = new List<AudioFile>();
			this.view.OptionCaption = "Options";
			this.average = new Duration(5,30);
		}
		public void Reset()
		{
			this.average = new Duration(0,0);
			this.tracks = new List<AudioFile>();
			this.view.EnableAverage = false;
			this.view.EnableCleanUp = false;
			this.view.TrackDuration = average.ToString();
			this.view.PodcastDuration = 45;
			this.view.SetTracks(this.tracks);
		}
		public DragDropEffects GetDragDropEffects(string []files)
		{
			this.tracks = new List<AudioFile>(Utilities.Purge(files));
			if ( tracks.Count > 0 )
				return DragDropEffects.All;
			else
				return DragDropEffects.None;
		}
		
		public void LoadAudioFiles(string []files)
		{
			this.tracks = new List<AudioFile>(Utilities.Purge(files));
			this.view.SetTracks(this.tracks);
			bool enabled = tracks.Count > 0 ? true: false;
			this.view.EnableAverage = enabled;
			this.view.EnableCleanUp = enabled;
		}
		
		public void TalkTrackDuration()
		{
			Duration total = new Duration(0,0);
        	foreach (var track in this.tracks) {
        		total+=track.Duration;
        	}
			if( this.view.PodcastDuration < total.Minute )
				this.view.ShowError("Attenzione la durata delle canzoni è maggiore della durata del podcast");
			else if ( this.view.PodcastDuration * 0.75 < total.Minute)
				this.view.ShowError("Attenzione sei oltre il limite del rapporto musica parlato (75%:25%)");
			else
			{
				TimeSpan voiceDuration = (new TimeSpan(0,this.view.PodcastDuration, 0) - new TimeSpan(0, total.Minute, total.Second));
				average = new Duration(TimeSpan.FromSeconds(voiceDuration.TotalSeconds/this.tracks.Count));
				this.view.TrackDuration = average.ToString();
				this.view.EnableAverage = true;
				this.view.EnableCleanUp = true;
				this.view.CountDown = average;
			}
		}
		
		public Duration Average
		{
			get { return average; }
		}
	}
}
