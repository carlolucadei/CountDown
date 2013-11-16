/*
 * Created by SharpDevelop.
 * User: Crick
 * Date: 19/04/2012
 * Time: 18.26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

using RadioIncredibile.CountDown.Entity;
using RadioIncredibile.CountDown.View;

namespace RadioIncredibile.CountDown.Presenter
{
	/// <summary>
	/// Description of CountDownPresenter.
	/// </summary>
	public class CountDownPresenter
	{
		protected ICountDownView view;
		protected TimeSpan elapsedTime;
		protected TimeSpan currentElapsedTime;
		protected Duration talkDuration;
		protected TimeSpan timerCountDown;
		protected TimeSpan defaultDuration;
		protected Timer timer;
		protected LinkedList<TimeSpan> historyElapsedTime;
		AvailableStatus status;
		
		public CountDownPresenter(ICountDownView view)
		{
			this.defaultDuration = new TimeSpan(0,5, 30);
			currentElapsedTime = elapsedTime = new TimeSpan(0,0,0);
			historyElapsedTime = new LinkedList<TimeSpan>();
			timerCountDown = this.defaultDuration;
			talkDuration = new Duration(timerCountDown);
			timer = new Timer(1000);
			timer.Enabled = false;
			timer.Elapsed += new ElapsedEventHandler(TimeElapsed);
			status = AvailableStatus.Idle;
			this.view = view;
			this.view.CountDownCaption = "Timer";
			this.view.EnableRemoveLastEntry = false;
			this.view.EnablePlay = true;
			this.view.EnablePause = false;
			this.view.EnableStop = false;
		}
		
		public void Reset()
		{
			currentElapsedTime = elapsedTime = new TimeSpan(0,0,0);
			timerCountDown = this.defaultDuration;
			talkDuration = new Duration(timerCountDown);
			status = AvailableStatus.Idle;
			historyElapsedTime = new LinkedList<TimeSpan>();
			this.view.CountDown = talkDuration;
			this.view.ElapsedTime = new Duration(elapsedTime);
			this.view.ProgressBarMax = 0;
			this.view.ProgressBarMin = 0;
			this.view.ProgressBarValue = 0;
			this.view.EnableRemoveLastEntry = false;
			this.view.EnablePlay = true;
			this.view.EnablePause = false;
			this.view.EnableStop = false;
		}
		public void ResetElapsedTime()
		{
			elapsedTime = new TimeSpan(0,0,0);
			historyElapsedTime = new LinkedList<TimeSpan>();
			this.view.ElapsedTime = new Duration(elapsedTime);
			this.view.EnableRemoveLastEntry = false;
		}
		protected void TimeElapsed(object sender, ElapsedEventArgs e)
	    {
			TimeSpan onesecond = new TimeSpan(0,0,1);
			timerCountDown = timerCountDown.Subtract(onesecond);
			currentElapsedTime = currentElapsedTime.Add(onesecond);
			elapsedTime = elapsedTime.Add(onesecond);
			if ( timerCountDown.TotalSeconds == 0 )
				timer.Enabled = false;
			this.view.CountDown = new Duration(timerCountDown);
			this.view.ElapsedTime = new Duration(elapsedTime);
			this.view.ProgressBarValue += 1;
			if ( timerCountDown.TotalSeconds == 0 )
			{
				this.view.ShowError("Tempo scaduto");
				this.Stop();
			}
	    }
		
		public void Play()
		{
			this.view.EnableInput = false;
			if (status != AvailableStatus.Pause)
            {
				Duration t = this.view.CountDown;
                timerCountDown = new TimeSpan(0, t.Minute, t.Second);
                this.view.ProgressBarMin = 0;
                this.view.ProgressBarValue = 0;                
                this.view.ProgressBarMax = (int)timerCountDown.TotalSeconds;
            }
			timer.Enabled = true;
            status = AvailableStatus.Play;
            this.view.EnableRemoveLastEntry = false;
			this.view.EnablePlay = false;
			this.view.EnablePause = true;
			this.view.EnableStop = true;
		}
		
		public void Pause()
		{
			status = AvailableStatus.Pause;
			timer.Enabled = false;
			timer.Stop();
			this.view.EnableInput = false;
			this.view.EnableRemoveLastEntry = false;
			this.view.EnablePlay = true;
			this.view.EnablePause = false;
			this.view.EnableStop = true;
		}
		
		public void Stop()
		{
			if ( currentElapsedTime.TotalSeconds > 0 )
				historyElapsedTime.AddLast(currentElapsedTime);
			currentElapsedTime = new TimeSpan(0,0,0);
			timerCountDown = this.defaultDuration;
			talkDuration = new Duration(timerCountDown);
			timer.Enabled = false;
			timer.Stop();
			status = AvailableStatus.Stop;
			this.view.CountDown = talkDuration;
			this.view.ProgressBarMax = 0;
			this.view.ProgressBarMin = 0;
			this.view.ProgressBarValue = 0;
			this.view.EnableInput = true;
			this.view.EnableRemoveLastEntry = ( historyElapsedTime.Count > 0 ? true : false);
			this.view.EnablePlay = true;
			this.view.EnablePause = false;
			this.view.EnableStop = false;
		}
		public TimeSpan DefaultTalkDuration
		{
			get {return defaultDuration; }
			set {defaultDuration = value; }
		}
		public void RemoveLastElapsedEntry()
		{
			if ( historyElapsedTime.Count > 0 )
			{
				historyElapsedTime.RemoveLast();
				/*
				 * Re-calculate elapsed time
				 */ 
				elapsedTime = new TimeSpan(historyElapsedTime.ToList().Sum(t => t.Ticks));
				this.view.ElapsedTime = new Duration(elapsedTime);
			}
			this.view.EnableRemoveLastEntry = ( historyElapsedTime.Count > 0 ? true : false);
		}
		enum AvailableStatus
	    {
	        Pause,
	        Stop,
	        Play,
	        Idle
	    }
	}
}
