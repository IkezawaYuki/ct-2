﻿using System;
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
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = new List<PersonModel>();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        public CreateTeamForm()
        {
            InitializeComponent();
            CreateSampleData();
            WireUpLists();
        }
        private void LoadListData()
        {
            availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        }
        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Sue", LastName = "Storm" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Jane", LastName = "Smith" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Bill", LastName = "Jones" });

        }
        private void WireUpLists()
        {
            selectTeamMemberDropdown.DataSource = null;

            selectTeamMemberDropdown.DataSource = availableTeamMembers;
            selectTeamMemberDropdown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;

            teamMembersListBox.DataSource = availableTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";

            selectTeamMemberDropdown.Refresh();
        }

        private void CreateTeamForm_Load(object sender, EventArgs e)
        {

        }

        private void teamOneScoreVaue_Click(object sender, EventArgs e)
        {

        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropdown.SelectedItem;

            availableTeamMembers.Remove(p);
            selectedTeamMembers.Add(p);

            WireUpLists();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private bool ValidateForm()
        {
            if (firstNameVaue.Text.Length == 0)
            {
                return false;
            }
            if (lastNameLabel.Text.Length == 0)
            {
                return false;
            }
            if (emailValue.Text.Length == 0)
            {
                return false;
            }
            if (cellphoneValue.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = firstNameVaue.Text;
                p.LastName = lastNameLabel.Text;
                p.EmailAddress = emailValue.Text;
                p.CellphoneNumber = cellphoneValue.Text;

                GlobalConfig.Connection.CreatePerson(p);

                firstNameVaue.Text = "";
                lastNameLabel.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";
            } 
            else
            {
                MessageBox.Show("You need to fill in all of the fields");
            }
        }

        private void deleteSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

            selectedTeamMembers.Remove(p);
            availableTeamMembers.Add(p);

            WireUpLists();
        }
    }
}
