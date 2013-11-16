/*
 * Created by SharpDevelop.
 * User: Crick
 * Date: 18/04/2012
 * Time: 21.33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using RadioIncredibile.CountDown.Entity;

namespace RadioIncredibile.CountDown.View
{
	/// <summary>
	/// Description of IOptionView.
	/// </summary>
	public interface IOptionView
	{
		int PodcastDuration { get; set;}
		string TrackDuration {get; set;}
		string OptionCaption {set;}
		void SetTracks(ICollection<AudioFile> files);
		bool EnableCleanUp {set;}
		bool EnableAverage {set;}
		Duration CountDown {get; set;}
		void ShowError(string message);
	}
}
