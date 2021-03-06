﻿namespace TestStepsEditor.Gui
{
	partial class QueryAndTestCasePicker
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
			this._instructionLabel = new System.Windows.Forms.Label();
			this._runQueryButton = new System.Windows.Forms.Button();
			this._closeButton = new System.Windows.Forms.Button();
			this._queryTreeView = new System.Windows.Forms.TreeView();
			this._testCaseListBox = new System.Windows.Forms.ListBox();
			this._loadSelectedTestCaseButton = new System.Windows.Forms.Button();
			this._switchToQuerySelectorButton = new System.Windows.Forms.Button();
			this._switchToTestCaseSelectorButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _instructionLabel
			// 
			this._instructionLabel.AutoSize = true;
			this._instructionLabel.Location = new System.Drawing.Point(13, 13);
			this._instructionLabel.Name = "_instructionLabel";
			this._instructionLabel.Size = new System.Drawing.Size(131, 13);
			this._instructionLabel.TabIndex = 1;
			this._instructionLabel.Text = "Select a query to execute:";
			// 
			// _runQueryButton
			// 
			this._runQueryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._runQueryButton.Location = new System.Drawing.Point(252, 332);
			this._runQueryButton.Name = "_runQueryButton";
			this._runQueryButton.Size = new System.Drawing.Size(132, 23);
			this._runQueryButton.TabIndex = 2;
			this._runQueryButton.Text = "Run Selected Query";
			this._runQueryButton.UseVisualStyleBackColor = true;
			this._runQueryButton.Click += new System.EventHandler(this.RunQueryButton_Click);
			// 
			// _closeButton
			// 
			this._closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._closeButton.Location = new System.Drawing.Point(10, 332);
			this._closeButton.Name = "_closeButton";
			this._closeButton.Size = new System.Drawing.Size(81, 23);
			this._closeButton.TabIndex = 3;
			this._closeButton.Text = "Hide Window";
			this._closeButton.UseVisualStyleBackColor = true;
			this._closeButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// _queryTreeView
			// 
			this._queryTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this._queryTreeView.Location = new System.Drawing.Point(13, 39);
			this._queryTreeView.Name = "_queryTreeView";
			this._queryTreeView.Size = new System.Drawing.Size(372, 290);
			this._queryTreeView.TabIndex = 5;
			// 
			// _testCaseListBox
			// 
			this._testCaseListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this._testCaseListBox.DisplayMember = "Name";
			this._testCaseListBox.FormattingEnabled = true;
			this._testCaseListBox.Location = new System.Drawing.Point(13, 39);
			this._testCaseListBox.Name = "_testCaseListBox";
			this._testCaseListBox.Size = new System.Drawing.Size(372, 290);
			this._testCaseListBox.TabIndex = 0;
			this._testCaseListBox.Visible = false;
			// 
			// _loadSelectedTestCaseButton
			// 
			this._loadSelectedTestCaseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._loadSelectedTestCaseButton.Location = new System.Drawing.Point(252, 332);
			this._loadSelectedTestCaseButton.Name = "_loadSelectedTestCaseButton";
			this._loadSelectedTestCaseButton.Size = new System.Drawing.Size(132, 23);
			this._loadSelectedTestCaseButton.TabIndex = 6;
			this._loadSelectedTestCaseButton.Text = "Load Selected Test Case";
			this._loadSelectedTestCaseButton.UseVisualStyleBackColor = true;
			this._loadSelectedTestCaseButton.Visible = false;
			this._loadSelectedTestCaseButton.Click += new System.EventHandler(this.LoadSelectedTestCaseButton_Click);
			// 
			// _switchToQuerySelectorButton
			// 
			this._switchToQuerySelectorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._switchToQuerySelectorButton.Location = new System.Drawing.Point(99, 332);
			this._switchToQuerySelectorButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this._switchToQuerySelectorButton.Name = "_switchToQuerySelectorButton";
			this._switchToQuerySelectorButton.Size = new System.Drawing.Size(148, 23);
			this._switchToQuerySelectorButton.TabIndex = 7;
			this._switchToQuerySelectorButton.Text = "Switch to Query Selector";
			this._switchToQuerySelectorButton.UseVisualStyleBackColor = true;
			this._switchToQuerySelectorButton.Visible = false;
			this._switchToQuerySelectorButton.Click += new System.EventHandler(this.SwitchToQuerySelectorButton_Click);
			// 
			// _switchToTestCaseSelectorButton
			// 
			this._switchToTestCaseSelectorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._switchToTestCaseSelectorButton.Location = new System.Drawing.Point(96, 332);
			this._switchToTestCaseSelectorButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this._switchToTestCaseSelectorButton.Name = "_switchToTestCaseSelectorButton";
			this._switchToTestCaseSelectorButton.Size = new System.Drawing.Size(151, 23);
			this._switchToTestCaseSelectorButton.TabIndex = 8;
			this._switchToTestCaseSelectorButton.Text = "Switch to Test Case Selector";
			this._switchToTestCaseSelectorButton.UseVisualStyleBackColor = true;
			this._switchToTestCaseSelectorButton.Visible = false;
			this._switchToTestCaseSelectorButton.Click += new System.EventHandler(this.SwitchToTestCaseSelectorButton_Click);
			// 
			// QueryAndTestCasePicker
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(398, 364);
			this.Controls.Add(this._switchToTestCaseSelectorButton);
			this.Controls.Add(this._switchToQuerySelectorButton);
			this.Controls.Add(this._loadSelectedTestCaseButton);
			this.Controls.Add(this._queryTreeView);
			this.Controls.Add(this._closeButton);
			this.Controls.Add(this._runQueryButton);
			this.Controls.Add(this._instructionLabel);
			this.Controls.Add(this._testCaseListBox);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(414, 402);
			this.Name = "QueryAndTestCasePicker";
			this.Text = "Query and Test Case Picker";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QueryAndTestCasePicker_FormClosing);
			this.Load += new System.EventHandler(this.QueryPicker_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label _instructionLabel;
		private System.Windows.Forms.Button _runQueryButton;
		private System.Windows.Forms.Button _closeButton;
		private System.Windows.Forms.TreeView _queryTreeView;
		private System.Windows.Forms.ListBox _testCaseListBox;
		private System.Windows.Forms.Button _loadSelectedTestCaseButton;
		private System.Windows.Forms.Button _switchToQuerySelectorButton;
		private System.Windows.Forms.Button _switchToTestCaseSelectorButton;
	}
}