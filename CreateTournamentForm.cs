using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public CreateTournamentForm()
        {
            InitializeComponent();
            InitialzeLists();
        }
        private void InitialzeLists()
        {
            selectTeamDropdown.DataSource = availableTeams;
            selectTeamDropdown.DisplayMember = "TeamName";

            tournamentPlayersListBox.DataSource = selectedPrizes;
            tournamentPlayersListBox.DisplayMember = "TeamName";

            prizeListBox.DataSource = selectedPrizes;
            prizeListBox.DisplayMember = "";
        }

        private void CreateTournamentForm_Load(object sender, EventArgs e)
        {

        }

        private void tournamentNameValue_Click(object sender, EventArgs e)
        {

        }

        private void teamOneScoreVaue_Click(object sender, EventArgs e)
        {

        }

        private void roundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void scoreButton_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void roundLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
