/*
 * Created by SharpDevelop.
 * User: Crick
 * Date: 19/04/2012
 * Time: 18.01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using RadioIncredibile.CountDown.Entity;

namespace RadioIncredibile.CountDown.View
{
	/// <summary>
	/// Description of ICountDownView.
	/// </summary>
	public interface ICountDownView
	{
		int ProgressBarValue { get; set; }
		int ProgressBarMax { get; set; }
		int ProgressBarMin { get; set; }
		Duration CountDown { get; set; }
		Duration ElapsedTime { set; }
		string CountDownCaption { set; }
		void ShowError(string message);
		bool EnableInput { set; }
		bool EnableRemoveLastEntry { set; }
		bool EnablePlay { set; }
		bool EnablePause { set; }
		bool EnableStop { set; }
	}
}
