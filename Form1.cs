using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedConsoleApplicationV
{
	public partial class Form1 : Form
	{
        #region Fields
        // Monitoring for Cancellation
        CancellationTokenSource m_TokenSource = null;
        #endregion Fields

        #region Constructors
        public Form1()
		{
			InitializeComponent();
		}
        #endregion Constructors

        #region Methods
        /// <summary>
        /// Update the pi output text box
        /// update a value on the UI thread from within our task
        /// </summary>
        /// <param name="pi">New value for pi</param>
        private void UpdatePiTextBlock(string pi)
		{
            // check if cross-thread synchronization is required
            // check the specific control’s InvokeRequired property
            // So, if UpdatePiTextBlock is called from our task, the 
            // test for InvokeRequired required will return
            // true.This will then asynchronously call UpdatePiTextBlock 
            // recursively. This time, however, since it was invoked upon 
            // the UI thread, InvokeRequired will be false so the else 
            // portion of the function executes, updating the TextBox.
            if (piTextBox.InvokeRequired)
            {
                // If this condition is true, then we need to recursively 
                // invoke this method on the UI thread
                piTextBox.BeginInvoke(new Action<string>(UpdatePiTextBlock), pi);
            } // end of if

            // simply update the piTextBox with the pi value given in the method
            else
            {
                piTextBox.Text = pi;
            } // end of else

        } // end of method

        /// <summary>
        /// Task to calculate an ever-growing number of digits in pi (up to 1,000,000)
        /// task that will calculate the digits of pi by calling MathStuff.Calculate()
        /// </summary>
        private void CalculatePiTask()
        {          
            try
            {
                for (int i = 2; i < 1000000; i++)
                {
                    // Call ThrowIfCancellationRequested periodically to test for cancellation request 
                    // At every iteration we will check to see if cancellation was requested
                    // if (m_TokenSource.Token.IsCancellationRequested) throw new OperationCanceledException();
                    m_TokenSource.Token.ThrowIfCancellationRequested();

                    // Start Time the Calculation
                    DateTime start = DateTime.Now;

                    // Calculate PI at a particular digit
                    string pi = MathStuff.Calculate(i);

                    // Update the UI
                    UpdatePiTextBlock(pi);

                    // End Time for Calculation
                    DateTime end = DateTime.Now;

                    // Total Time for the Calculation in Milliseconds
                    double totalMs = end.Subtract(start).TotalMilliseconds;

                    if (totalMs < 500)
                    {
                        // Slow down the task for visual purposes only 
                        Thread.Sleep(500 - (int)totalMs);
                    } // end of if

                } // end of for

            } // end of try

            // when the user cancels the Task
            catch (OperationCanceledException)
            {
                Console.WriteLine("Cancelled.");
                throw;
            } // end of catch

        } // end of method
		#endregion Methods

		#region Event Handlers
		/// <summary>
		/// Demonstrates Parallel.ForEach
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">Event Arguments</param>
		private void parallelGoButton_Click(object sender, EventArgs e)
		{
            // Query to Filter out ProgressBar Controls
            var query = from Control child in parallelGroup.Controls
                        where child is ProgressBar
                        select child as ProgressBar;

            // anonymous method that will update an individual ProgressBar
            // execute the ProgressBar updates on the thread that created the controls
            // If we try to update the controls from a separate thread without the 
            // synchronization exceptions would result.
            Action<ProgressBar, int> updateProgressBarValue = delegate (ProgressBar pb, int value) 
            {
                pb.Value = value;
            }; // end of anonymous method

            // iterate through the ProgressBar controls returned from “query” in a parallel manner
            // lambda expression is executed once per item from “query”
            // The TPL decides how to allocate threads for each iteration
            
            Parallel.ForEach(query, progressBar => 
            {
                for (int i = 0; i < progressBar.Maximum; i++)
                {
                    if (i % 100 == 0)
                    {
                        // we use the BeginInvoke method of the ProgressBar to execute 
                        // the anonymous method stored in updateProgressBarValue
                        // This executes updateProgressBarValue on the thread that the ProgressBar was created on
                        // Because we are using a UI control’s BeginInvoke method, 
                        // we are not required to call EndInvoke to complete the call
                        // using BeginInvoke instead of Invoke to avoid blocking on the call
                        // Delegate.Invoke: Executes synchronously, on the same thread.
                        // Delegate.BeginInvoke: Executes asynchronously, on a threadpool thread.
                        // Control.Invoke: Executes on the UI thread, but calling thread 
                        // waits for completion before continuing.
                        // Control.BeginInvoke: Executes on the UI thread, and calling 
                        // thread doesn't wait for completion.
                        progressBar.BeginInvoke(updateProgressBarValue, progressBar, i);
                    } // end of if
                } // end of for
            }); // End of Parallel ForEach 

        } // end of method, event handler for button click
               
		/// <summary>
		/// Start the pi calculation task
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">Event arguments</param>
		private void taskGoButton_Click(object sender, EventArgs e)
		{
            // set the buttons into the appropriate state
            taskGoButton.Enabled = false;
            taskCancelButton.Enabled = true;

            // set the CancelationTokenSource object to a new instance
            m_TokenSource = new CancellationTokenSource();

            // When Tasks complete, TPL provides a mechanism to automatically 
            // continue execution on a WinForm or WPF UI thread.To do this 
            // we need a handle to the UI thread which we’ll use later
            var ui = TaskScheduler.FromCurrentSynchronizationContext();

            // start the Task, passing it the name of the method that 
            // will be the entry point for the Task and the token used for cancellation:
            Task calculatePiTask = Task.Factory.StartNew(CalculatePiTask, m_TokenSource.Token);

            // first continuation call will execute only when the Task completes successfully
            // notifies the user by showing a message box then resetting the buttons to their 
            // default configuration. Notice that the last parameter to ContinueWith is “ui”. 
            // This tells ContinueWith to execute the lambda statements to execute within 
            // the context of the UI thread.No Invoke / BeginInvoke needed here.
            var resultOK = calculatePiTask.ContinueWith(resultTask => 
            {
                MessageBox.Show("Calculation fininshed", "Task Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                taskCancelButton.Enabled = false; taskGoButton.Enabled = true;
            }, 
            CancellationToken.None, 
            TaskContinuationOptions.OnlyOnRanToCompletion, 
            ui);

            // second continuation call only executes if the task is  cancelled
            var resultCancel = calculatePiTask.ContinueWith(resultTask => 
            {
                MessageBox.Show("Calculation stopped by user", "Task Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                taskCancelButton.Enabled = false; taskGoButton.Enabled = true;
            }, CancellationToken.None, TaskContinuationOptions.OnlyOnCanceled, ui);

        } // end of method

        /// <summary>
        /// Cancel the Task of Calculating PI
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">Event arguments</param>
        private void taskCancelButton_Click(object sender, EventArgs e)
		{
            // if a valid token source is available then signal 
            // to any listeners that the Task has been cancelled
            if (m_TokenSource != null)
            {
                m_TokenSource.Cancel();
            } // end of if
        } // end of method

        #endregion Event Handlers

    } // end of class
} // end of namespace
