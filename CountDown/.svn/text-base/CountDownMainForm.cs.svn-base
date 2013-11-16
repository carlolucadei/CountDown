using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using RadioIncredibile.CountDown.Entity;
using RadioIncredibile.CountDown.FileController;
using RadioIncredibile.CountDown.Presenter;
using RadioIncredibile.CountDown.Utility;
using RadioIncredibile.CountDown.View;

namespace RadioIncredibile.CountDown
{
    public partial class CountDownMainForm : Form, IOptionView, ICountDownView
    {
        protected TimeSpan _timer;
        protected TimeSpan _elapsedTime;
        protected TimeSpan _default;
        
        protected OptionPresenter optionPresenter;
        protected CountDownPresenter countDownPresenter;
        public CountDownMainForm()
        {
            InitializeComponent();
            TbMinutes.SelectionStart = 0;
            TbSeconds.SelectionStart = 0;
            _default = new TimeSpan(0, 5, 30);
            /*
             * Count Down Presenter
             */ 
            countDownPresenter = new CountDownPresenter(this);
            countDownPresenter.Reset();
            /*
             * Option Presenter
             */ 
            optionPresenter = new OptionPresenter(this);
            optionPresenter.Reset();
        }

        private void Play_Click(object sender, EventArgs e)
        {
        	countDownPresenter.Play();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
        	TimeSpan start = new TimeSpan(0, 
                              optionPresenter.Average.Minute,
                              optionPresenter.Average.Second);
        	countDownPresenter.Stop();
        }
        
		private void Pause_Click(object sender, EventArgs e)
        {
			countDownPresenter.Pause();
        }

        private void ResetElapsedTime_Click(object sender, EventArgs e)
        {
        	countDownPresenter.ResetElapsedTime();
        }
        void TbKeyPress(object sender, KeyPressEventArgs e)
        {
        	e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #region TextBox validating
        void TbValidateLeave(object sender, EventArgs e)
        {
        	int value = 0;
        	int.TryParse(((TextBox)sender).Text, out value);
        	((TextBox)sender).Text = value.ToString("00");
        }
        #endregion
        #region Exit
        void ExitTSMenuClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sei sicuro di voler uscire?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Dispose();
        }
        
        void CountDownMainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Sei sicuro di voler uscire?", this.Text,MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
                this.Dispose();
            }
            else
            	e.Cancel = true;
        }
        #endregion
        #region Drag&Drop files
        void PFilesDragDrop(object sender, DragEventArgs e)
        {
        	// make sure they're actually dropping files (not text or anything else)
			if( e.Data.GetDataPresent(DataFormats.FileDrop, false) == true )
			{
				optionPresenter.LoadAudioFiles((string[])e.Data.GetData(DataFormats.FileDrop));
			}
        }
        
        void PFilesDragEnter(object sender, DragEventArgs e)
        {
        	// make sure they're actually dropping files (not text or anything else)
			if( e.Data.GetDataPresent(DataFormats.FileDrop, false) == true )
			{
				// allow them to continue
				// (without this, the cursor stays a "NO" symbol
				// transfer the filenames to a string array
				// (yes, everything to the left of the "=" can be put in the 
				// foreach loop in place of "files", but this is easier to understand.)
				e.Effect = optionPresenter.GetDragDropEffects((string[])e.Data.GetData(DataFormats.FileDrop));
			}
        }
        #endregion
        #region Click Event
        void BtResetClick(object sender, System.EventArgs e)
        {
        	optionPresenter.Reset();
        }        
        
        void BtClearClick(object sender, EventArgs e)
        {
			optionPresenter.Reset();
        }
        
        void BtCalculateClick(object sender, EventArgs e)
        {
        	optionPresenter.TalkTrackDuration();
        	countDownPresenter.DefaultTalkDuration = new TimeSpan
        		(0,
        		 optionPresenter.Average.Minute,
        		 optionPresenter.Average.Second);
        }
        
        void PFilesDoubleClick(object sender, EventArgs e)
        {
        	oFDMp3.ShowDialog();
        	optionPresenter.LoadAudioFiles(oFDMp3.FileNames);
        }
        
        void RemoveLastElapsedEntryButtonClick(object sender, EventArgs e)
        {
        	countDownPresenter.RemoveLastElapsedEntry();
        }
        #endregion
        #region ICountDownView
        public string CountDownCaption
        {
        	set { tabControl.TabPages[0].Text = value; }
        }
		public int ProgressBarValue
		{
			get { return pBar.Value; }
			set { pBar.Value = value; }
		}
    	
		public int ProgressBarMax
		{
			get { return pBar.Maximum; }
			set { pBar.Maximum = value; }
		}
    	
		public int ProgressBarMin
		{
			get { return pBar.Minimum; }
			set { pBar.Minimum = value; }
		}
		public bool EnableInput
		{
			set
			{
				TbMinutes.Enabled = value;
				TbSeconds.Enabled = value;
			}
		}
		public bool EnablePlay
		{
			set
			{
				this.playTSMenu.Enabled = value;
				this.Play.Enabled = value;
			}
		}		
		public bool EnablePause
		{
			set
			{
				this.pauseTSMenu.Enabled = value;
				this.Pause.Enabled = value;
			}
		}
		public bool EnableStop
		{
			set
			{
				this.stopTSMenu.Enabled = value;
				this.Stop.Enabled = value;
			}
		}		
		public Duration CountDown
		{
			get
			{ 
				string minutes = "0";
				string seconds = "0";
				if ( !string.IsNullOrEmpty(TbMinutes.Text))
					minutes = TbMinutes.Text.Trim();
				if ( !string.IsNullOrEmpty(TbSeconds.Text))
					seconds = TbSeconds.Text.Trim();
				return new Duration(minutes, seconds);
			}
			set
			{ 
				TbMinutes.Text = value.Minute.ToString("00");
				TbSeconds.Text = value.Second.ToString("00");
			}
		}
		public Duration ElapsedTime
		{
			set { lElapsedTime.Text = value.ToString(); }
		}
		public bool EnableRemoveLastEntry
		{
			set
			{
				this.removeLastElapsedEntry.Enabled = value;
			}
		}
    	#endregion
    	#region IOptionView
    	public string OptionCaption
    	{
    		set {tabControl.TabPages[1].Text = value; }
    	}
    	
		public int PodcastDuration
		{
			get { return (int)this.nudMinute.Value; }
			set { this.nudMinute.Value = Convert.ToDecimal(value); }
		}
    	
		public string TrackDuration
		{
			get { return this.lAverageDurationVoice.Text; }
			set { this.lAverageDurationVoice.Text = value; }
		}
    	
		public bool EnableCleanUp
		{
			set 
			{
				this.btClear.Enabled = value;
				this.btReset.Enabled = value;
			}
		}
    	
		public bool EnableAverage
		{
			set { this.btCalculate.Enabled = value; }
		}
    	
		public void SetTracks(ICollection<AudioFile> files)
		{
			// Reset controls
			this.pFiles.Controls.Clear();
			// loop through the string array, adding each filename to the ListBox
			int index = 0;
			Duration total = new Duration();
			foreach( AudioFile file in files )
			{
				PlayListItem item = new PlayListItem(file);
				item.Location = new Point(10, (item.Height * index));
				pFiles.Controls.Add(item);
				total += file.Duration;
				index++;
			}
			if ( files.Count > 0 )
			{
				PlayListItem t = new PlayListItem(total);
				t.Location = new Point(10,(t.Height * index));
				pFiles.Controls.Add(t);
			}
		}
		public void ShowError(string message)
		{
			//MessageBox.Show("Attenzione la durata delle canzoni è maggiore della durata del podcast");
			MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		#endregion
    }
}