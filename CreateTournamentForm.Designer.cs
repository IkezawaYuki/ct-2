namespace TrackerUI
{
    partial class createTournamentForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentNameValue = new System.Windows.Forms.Label();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.teamOneScoreVaue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.selectTeamDropdown = new System.Windows.Forms.ComboBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.playersLabel = new System.Windows.Forms.Label();
            this.deleteSelectedPlayersButton = new System.Windows.Forms.Button();
            this.deleteSelectedPrizeButton = new System.Windows.Forms.Button();
            this.prizeLabel = new System.Windows.Forms.Label();
            this.prizeListBox = new System.Windows.Forms.ListBox();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Location = new System.Drawing.Point(55, 37);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(259, 38);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Create Tournament:";
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.AutoSize = true;
            this.tournamentNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentNameValue.ForeColor = System.Drawing.Color.SteelBlue;
            this.tournamentNameValue.Location = new System.Drawing.Point(55, 141);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(75, 40);
            this.tournamentNameValue.TabIndex = 11;
            this.tournamentNameValue.Text = "       ";
            this.tournamentNameValue.Click += new System.EventHandler(this.tournamentNameValue_Click);
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.tournamentNameLabel.Location = new System.Drawing.Point(55, 93);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tournamentNameLabel.Size = new System.Drawing.Size(239, 38);
            this.tournamentNameLabel.TabIndex = 10;
            this.tournamentNameLabel.Text = "TournamentName";
            // 
            // teamOneScoreVaue
            // 
            this.teamOneScoreVaue.AutoSize = true;
            this.teamOneScoreVaue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamOneScoreVaue.ForeColor = System.Drawing.Color.SteelBlue;
            this.teamOneScoreVaue.Location = new System.Drawing.Point(205, 193);
            this.teamOneScoreVaue.Name = "teamOneScoreVaue";
            this.teamOneScoreVaue.Size = new System.Drawing.Size(34, 40);
            this.teamOneScoreVaue.TabIndex = 13;
            this.teamOneScoreVaue.Text = "0";
            this.teamOneScoreVaue.Click += new System.EventHandler(this.teamOneScoreVaue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(55, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "Entry Fee";
            // 
            // selectTeamDropdown
            // 
            this.selectTeamDropdown.FormattingEnabled = true;
            this.selectTeamDropdown.Location = new System.Drawing.Point(64, 289);
            this.selectTeamDropdown.Name = "selectTeamDropdown";
            this.selectTeamDropdown.Size = new System.Drawing.Size(351, 45);
            this.selectTeamDropdown.TabIndex = 15;
            this.selectTeamDropdown.SelectedIndexChanged += new System.EventHandler(this.roundDropDown_SelectedIndexChanged);
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.selectTeamLabel.Location = new System.Drawing.Point(55, 248);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(164, 38);
            this.selectTeamLabel.TabIndex = 14;
            this.selectTeamLabel.Text = "Select Team";
            this.selectTeamLabel.Click += new System.EventHandler(this.roundLabel_Click);
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.Location = new System.Drawing.Point(254, 248);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(152, 38);
            this.createNewTeamLink.TabIndex = 16;
            this.createNewTeamLink.TabStop = true;
            this.createNewTeamLink.Text = "create new";
            // 
            // addTeamButton
            // 
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addTeamButton.Location = new System.Drawing.Point(64, 353);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(197, 48);
            this.addTeamButton.TabIndex = 17;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(64, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 48);
            this.button1.TabIndex = 18;
            this.button1.Text = "Create Prize";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersListBox
            // 
            this.tournamentPlayersListBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentPlayersListBox.FormattingEnabled = true;
            this.tournamentPlayersListBox.ItemHeight = 31;
            this.tournamentPlayersListBox.Location = new System.Drawing.Point(433, 134);
            this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            this.tournamentPlayersListBox.Size = new System.Drawing.Size(281, 128);
            this.tournamentPlayersListBox.TabIndex = 19;
            // 
            // playersLabel
            // 
            this.playersLabel.AutoSize = true;
            this.playersLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.playersLabel.Location = new System.Drawing.Point(433, 93);
            this.playersLabel.Name = "playersLabel";
            this.playersLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playersLabel.Size = new System.Drawing.Size(209, 38);
            this.playersLabel.TabIndex = 20;
            this.playersLabel.Text = "Teams / Players";
            // 
            // deleteSelectedPlayersButton
            // 
            this.deleteSelectedPlayersButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteSelectedPlayersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedPlayersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedPlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPlayersButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteSelectedPlayersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteSelectedPlayersButton.Location = new System.Drawing.Point(749, 155);
            this.deleteSelectedPlayersButton.Name = "deleteSelectedPlayersButton";
            this.deleteSelectedPlayersButton.Size = new System.Drawing.Size(116, 88);
            this.deleteSelectedPlayersButton.TabIndex = 21;
            this.deleteSelectedPlayersButton.Text = "Delete Selected";
            this.deleteSelectedPlayersButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizeButton
            // 
            this.deleteSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteSelectedPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteSelectedPrizeButton.Location = new System.Drawing.Point(749, 348);
            this.deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            this.deleteSelectedPrizeButton.Size = new System.Drawing.Size(116, 83);
            this.deleteSelectedPrizeButton.TabIndex = 24;
            this.deleteSelectedPrizeButton.Text = "Delete Selected";
            this.deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // prizeLabel
            // 
            this.prizeLabel.AutoSize = true;
            this.prizeLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.prizeLabel.Location = new System.Drawing.Point(433, 272);
            this.prizeLabel.Name = "prizeLabel";
            this.prizeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.prizeLabel.Size = new System.Drawing.Size(209, 38);
            this.prizeLabel.TabIndex = 23;
            this.prizeLabel.Text = "Teams / Players";
            // 
            // prizeListBox
            // 
            this.prizeListBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizeListBox.FormattingEnabled = true;
            this.prizeListBox.ItemHeight = 31;
            this.prizeListBox.Location = new System.Drawing.Point(433, 313);
            this.prizeListBox.Name = "prizeListBox";
            this.prizeListBox.Size = new System.Drawing.Size(281, 159);
            this.prizeListBox.TabIndex = 22;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTournamentButton.Location = new System.Drawing.Point(362, 496);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(252, 48);
            this.createTournamentButton.TabIndex = 25;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            this.createTournamentButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // createTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 556);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deleteSelectedPrizeButton);
            this.Controls.Add(this.prizeLabel);
            this.Controls.Add(this.prizeListBox);
            this.Controls.Add(this.deleteSelectedPlayersButton);
            this.Controls.Add(this.playersLabel);
            this.Controls.Add(this.tournamentPlayersListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.selectTeamDropdown);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.teamOneScoreVaue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "createTournamentForm";
            this.Text = "CreateTournament";
            this.Load += new System.EventHandler(this.CreateTournamentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private Label tournamentNameValue;
        private Label tournamentNameLabel;
        private Label teamOneScoreVaue;
        private Label label1;
        private ComboBox selectTeamDropdown;
        private Label selectTeamLabel;
        private LinkLabel createNewTeamLink;
        private Button addTeamButton;
        private Button button1;
        private ListBox tournamentPlayersListBox;
        private Label playersLabel;
        private Button deleteSelectedPlayersButton;
        private Button deleteSelectedPrizeButton;
        private Label prizeLabel;
        private ListBox prizeListBox;
        private Button createTournamentButton;
    }
}