namespace TrackerUI
{
    partial class TournamentViewrForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerLabel = new System.Windows.Forms.Label();
            this.TournamentName = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.teamOneName = new System.Windows.Forms.Label();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneScore = new System.Windows.Forms.Label();
            this.teamOneScoreVaue = new System.Windows.Forms.Label();
            this.teamTwoScoreValue = new System.Windows.Forms.Label();
            this.teamTwoNameScore = new System.Windows.Forms.Label();
            this.teamTwoName = new System.Windows.Forms.Label();
            this.versus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Location = new System.Drawing.Point(45, 32);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(171, 38);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Tournament:";
            this.headerLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TournamentName
            // 
            this.TournamentName.AutoSize = true;
            this.TournamentName.Location = new System.Drawing.Point(208, 32);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(118, 38);
            this.TournamentName.TabIndex = 1;
            this.TournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.roundLabel.Location = new System.Drawing.Point(45, 106);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(97, 38);
            this.roundLabel.TabIndex = 2;
            this.roundLabel.Text = "Round";
            this.roundLabel.Click += new System.EventHandler(this.roundLabel_Click);
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(148, 103);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(178, 45);
            this.roundDropDown.TabIndex = 3;
            // 
            // unplayedOnlyCheckbox
            // 
            this.unplayedOnlyCheckbox.AutoSize = true;
            this.unplayedOnlyCheckbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unplayedOnlyCheckbox.Location = new System.Drawing.Point(148, 178);
            this.unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            this.unplayedOnlyCheckbox.Size = new System.Drawing.Size(164, 32);
            this.unplayedOnlyCheckbox.TabIndex = 4;
            this.unplayedOnlyCheckbox.Text = "Unplayed Only";
            this.unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            this.unplayedOnlyCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // teamOneName
            // 
            this.teamOneName.AutoSize = true;
            this.teamOneName.ForeColor = System.Drawing.Color.SteelBlue;
            this.teamOneName.Location = new System.Drawing.Point(473, 222);
            this.teamOneName.Name = "teamOneName";
            this.teamOneName.Size = new System.Drawing.Size(172, 38);
            this.teamOneName.TabIndex = 5;
            this.teamOneName.Text = "<team one>";
            // 
            // matchupListBox
            // 
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 37;
            this.matchupListBox.Location = new System.Drawing.Point(45, 233);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(281, 263);
            this.matchupListBox.TabIndex = 6;
            this.matchupListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // teamOneScore
            // 
            this.teamOneScore.AutoSize = true;
            this.teamOneScore.ForeColor = System.Drawing.Color.SteelBlue;
            this.teamOneScore.Location = new System.Drawing.Point(473, 277);
            this.teamOneScore.Name = "teamOneScore";
            this.teamOneScore.Size = new System.Drawing.Size(86, 38);
            this.teamOneScore.TabIndex = 7;
            this.teamOneScore.Text = "Score";
            // 
            // teamOneScoreVaue
            // 
            this.teamOneScoreVaue.AutoSize = true;
            this.teamOneScoreVaue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamOneScoreVaue.ForeColor = System.Drawing.Color.SteelBlue;
            this.teamOneScoreVaue.Location = new System.Drawing.Point(570, 275);
            this.teamOneScoreVaue.Name = "teamOneScoreVaue";
            this.teamOneScoreVaue.Size = new System.Drawing.Size(75, 40);
            this.teamOneScoreVaue.TabIndex = 9;
            this.teamOneScoreVaue.Text = "       ";
            this.teamOneScoreVaue.Click += new System.EventHandler(this.teamOneScoreVaue1_Click);
            // 
            // teamTwoScoreValue
            // 
            this.teamTwoScoreValue.AutoSize = true;
            this.teamTwoScoreValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamTwoScoreValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.teamTwoScoreValue.Location = new System.Drawing.Point(570, 412);
            this.teamTwoScoreValue.Name = "teamTwoScoreValue";
            this.teamTwoScoreValue.Size = new System.Drawing.Size(75, 40);
            this.teamTwoScoreValue.TabIndex = 12;
            this.teamTwoScoreValue.Text = "       ";
            // 
            // teamTwoNameScore
            // 
            this.teamTwoNameScore.AutoSize = true;
            this.teamTwoNameScore.ForeColor = System.Drawing.Color.SteelBlue;
            this.teamTwoNameScore.Location = new System.Drawing.Point(473, 414);
            this.teamTwoNameScore.Name = "teamTwoNameScore";
            this.teamTwoNameScore.Size = new System.Drawing.Size(86, 38);
            this.teamTwoNameScore.TabIndex = 11;
            this.teamTwoNameScore.Text = "Score";
            // 
            // teamTwoName
            // 
            this.teamTwoName.AutoSize = true;
            this.teamTwoName.ForeColor = System.Drawing.Color.SteelBlue;
            this.teamTwoName.Location = new System.Drawing.Point(473, 359);
            this.teamTwoName.Name = "teamTwoName";
            this.teamTwoName.Size = new System.Drawing.Size(170, 38);
            this.teamTwoName.TabIndex = 10;
            this.teamTwoName.Text = "<team two>";
            // 
            // versus
            // 
            this.versus.AutoSize = true;
            this.versus.ForeColor = System.Drawing.Color.SteelBlue;
            this.versus.Location = new System.Drawing.Point(530, 321);
            this.versus.Name = "versus";
            this.versus.Size = new System.Drawing.Size(64, 38);
            this.versus.TabIndex = 13;
            this.versus.Text = "-vs-";
            // 
            // TournamentViewrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 548);
            this.Controls.Add(this.versus);
            this.Controls.Add(this.teamTwoScoreValue);
            this.Controls.Add(this.teamTwoNameScore);
            this.Controls.Add(this.teamTwoName);
            this.Controls.Add(this.teamOneScoreVaue);
            this.Controls.Add(this.teamOneScore);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.unplayedOnlyCheckbox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TournamentViewrForm";
            this.Text = "TournamentViewr";
            this.Load += new System.EventHandler(this.TournamentViewrForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private Label TournamentName;
        private Label roundLabel;
        private ComboBox roundDropDown;
        private CheckBox unplayedOnlyCheckbox;
        private Label teamOneName;
        private ListBox matchupListBox;
        private Label teamOneScore;
        private Label teamOneScoreVaue;
        private Label teamTwoScoreValue;
        private Label teamTwoNameScore;
        private Label teamTwoName;
        private Label versus;
    }
}