namespace AdvancedConsoleApplicationV
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.parallelGroup = new System.Windows.Forms.GroupBox();
			this.progressBar6 = new System.Windows.Forms.ProgressBar();
			this.progressBar7 = new System.Windows.Forms.ProgressBar();
			this.progressBar8 = new System.Windows.Forms.ProgressBar();
			this.parallelGoButton = new System.Windows.Forms.Button();
			this.progressBar5 = new System.Windows.Forms.ProgressBar();
			this.progressBar4 = new System.Windows.Forms.ProgressBar();
			this.progressBar3 = new System.Windows.Forms.ProgressBar();
			this.progressBar2 = new System.Windows.Forms.ProgressBar();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.taskGroup = new System.Windows.Forms.GroupBox();
			this.taskCancelButton = new System.Windows.Forms.Button();
			this.taskGoButton = new System.Windows.Forms.Button();
			this.piTextBox = new System.Windows.Forms.TextBox();
			this.parallelGroup.SuspendLayout();
			this.taskGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// parallelGroup
			// 
			this.parallelGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.parallelGroup.Controls.Add(this.progressBar6);
			this.parallelGroup.Controls.Add(this.progressBar7);
			this.parallelGroup.Controls.Add(this.progressBar8);
			this.parallelGroup.Controls.Add(this.parallelGoButton);
			this.parallelGroup.Controls.Add(this.progressBar5);
			this.parallelGroup.Controls.Add(this.progressBar4);
			this.parallelGroup.Controls.Add(this.progressBar3);
			this.parallelGroup.Controls.Add(this.progressBar2);
			this.parallelGroup.Controls.Add(this.progressBar1);
			this.parallelGroup.Location = new System.Drawing.Point(12, 12);
			this.parallelGroup.Name = "parallelGroup";
			this.parallelGroup.Size = new System.Drawing.Size(600, 208);
			this.parallelGroup.TabIndex = 0;
			this.parallelGroup.TabStop = false;
			this.parallelGroup.Text = "Parallel ForEach";
			// 
			// progressBar6
			// 
			this.progressBar6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar6.Location = new System.Drawing.Point(6, 159);
			this.progressBar6.Maximum = 100000;
			this.progressBar6.Name = "progressBar6";
			this.progressBar6.Size = new System.Drawing.Size(588, 12);
			this.progressBar6.TabIndex = 8;
			// 
			// progressBar7
			// 
			this.progressBar7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar7.Location = new System.Drawing.Point(6, 139);
			this.progressBar7.Maximum = 100000;
			this.progressBar7.Name = "progressBar7";
			this.progressBar7.Size = new System.Drawing.Size(588, 12);
			this.progressBar7.TabIndex = 7;
			// 
			// progressBar8
			// 
			this.progressBar8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar8.Location = new System.Drawing.Point(6, 119);
			this.progressBar8.Maximum = 100000;
			this.progressBar8.Name = "progressBar8";
			this.progressBar8.Size = new System.Drawing.Size(588, 12);
			this.progressBar8.TabIndex = 6;
			// 
			// parallelGoButton
			// 
			this.parallelGoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.parallelGoButton.Location = new System.Drawing.Point(502, 178);
			this.parallelGoButton.Name = "parallelGoButton";
			this.parallelGoButton.Size = new System.Drawing.Size(92, 24);
			this.parallelGoButton.TabIndex = 5;
			this.parallelGoButton.Text = "Go";
			this.parallelGoButton.UseVisualStyleBackColor = true;
			this.parallelGoButton.Click += new System.EventHandler(this.parallelGoButton_Click);
			// 
			// progressBar5
			// 
			this.progressBar5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar5.Location = new System.Drawing.Point(6, 99);
			this.progressBar5.Maximum = 100000;
			this.progressBar5.Name = "progressBar5";
			this.progressBar5.Size = new System.Drawing.Size(588, 12);
			this.progressBar5.TabIndex = 4;
			// 
			// progressBar4
			// 
			this.progressBar4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar4.Location = new System.Drawing.Point(6, 79);
			this.progressBar4.Maximum = 100000;
			this.progressBar4.Name = "progressBar4";
			this.progressBar4.Size = new System.Drawing.Size(588, 12);
			this.progressBar4.TabIndex = 3;
			// 
			// progressBar3
			// 
			this.progressBar3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar3.Location = new System.Drawing.Point(6, 59);
			this.progressBar3.Maximum = 100000;
			this.progressBar3.Name = "progressBar3";
			this.progressBar3.Size = new System.Drawing.Size(588, 12);
			this.progressBar3.TabIndex = 2;
			// 
			// progressBar2
			// 
			this.progressBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar2.Location = new System.Drawing.Point(6, 39);
			this.progressBar2.Maximum = 100000;
			this.progressBar2.Name = "progressBar2";
			this.progressBar2.Size = new System.Drawing.Size(588, 12);
			this.progressBar2.TabIndex = 1;
			// 
			// progressBar1
			// 
			this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar1.Location = new System.Drawing.Point(6, 19);
			this.progressBar1.Maximum = 100000;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(588, 12);
			this.progressBar1.TabIndex = 0;
			// 
			// taskGroup
			// 
			this.taskGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.taskGroup.Controls.Add(this.taskCancelButton);
			this.taskGroup.Controls.Add(this.taskGoButton);
			this.taskGroup.Controls.Add(this.piTextBox);
			this.taskGroup.Location = new System.Drawing.Point(12, 226);
			this.taskGroup.Name = "taskGroup";
			this.taskGroup.Size = new System.Drawing.Size(600, 293);
			this.taskGroup.TabIndex = 1;
			this.taskGroup.TabStop = false;
			this.taskGroup.Text = "Task";
			// 
			// taskCancelButton
			// 
			this.taskCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.taskCancelButton.Location = new System.Drawing.Point(403, 261);
			this.taskCancelButton.Name = "taskCancelButton";
			this.taskCancelButton.Size = new System.Drawing.Size(92, 24);
			this.taskCancelButton.TabIndex = 7;
			this.taskCancelButton.Text = "Cancel";
			this.taskCancelButton.UseVisualStyleBackColor = true;
			this.taskCancelButton.Click += new System.EventHandler(this.taskCancelButton_Click);
			// 
			// taskGoButton
			// 
			this.taskGoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.taskGoButton.Location = new System.Drawing.Point(501, 261);
			this.taskGoButton.Name = "taskGoButton";
			this.taskGoButton.Size = new System.Drawing.Size(92, 24);
			this.taskGoButton.TabIndex = 6;
			this.taskGoButton.Text = "Go";
			this.taskGoButton.UseVisualStyleBackColor = true;
			this.taskGoButton.Click += new System.EventHandler(this.taskGoButton_Click);
			// 
			// piTextBox
			// 
			this.piTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.piTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.piTextBox.Location = new System.Drawing.Point(10, 21);
			this.piTextBox.Multiline = true;
			this.piTextBox.Name = "piTextBox";
			this.piTextBox.Size = new System.Drawing.Size(583, 234);
			this.piTextBox.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 531);
			this.Controls.Add(this.taskGroup);
			this.Controls.Add(this.parallelGroup);
			this.MinimumSize = new System.Drawing.Size(640, 480);
			this.Name = "Form1";
			this.Text = "Lab 4";
			this.parallelGroup.ResumeLayout(false);
			this.taskGroup.ResumeLayout(false);
			this.taskGroup.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox parallelGroup;
		private System.Windows.Forms.Button parallelGoButton;
		private System.Windows.Forms.ProgressBar progressBar5;
		private System.Windows.Forms.ProgressBar progressBar4;
		private System.Windows.Forms.ProgressBar progressBar3;
		private System.Windows.Forms.ProgressBar progressBar2;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.ProgressBar progressBar6;
		private System.Windows.Forms.ProgressBar progressBar7;
		private System.Windows.Forms.ProgressBar progressBar8;
		private System.Windows.Forms.GroupBox taskGroup;
		private System.Windows.Forms.Button taskCancelButton;
		private System.Windows.Forms.Button taskGoButton;
		private System.Windows.Forms.TextBox piTextBox;
	}
}

