using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

/*
 * STUDENT NAME: Muhammad Shiblee
 * STUDENT ID: 301064587
 * DESCRIPTION: This is the Character Generator  Form - the main form of the application
 */

namespace COMP123_S2019_FinalTestB.Views
{
    public partial class CharacterGeneratorForm : MasterForm
    {
        Random random = new Random();
        string[] FirstNameList;
        string[] LastNameList;
        string[] InventoryItemsList;
        public CharacterGeneratorForm()
        {
            InitializeComponent();
            Program.characterForm = new CharacterGeneratorForm();
        }

        /// <summary>
        /// This is the event handler for the BackButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadNames()
        {
            string firstNamePath = File.ReadAllLines("..\\..\\Data\\firstNames.txt");
            string lastNamePath = File.ReadAllLines("..\\..\\Data\\lastNames.txt");
        } 

        private void GenerateNames()
        {
            Program.character.FirstName = FirstNameList[random.Next(FirstNameList.Length)];
            Program.character.LastName = LastNameList[random.Next(LastNameList.Length)];

            FirstNameDataLabel.Text = Program.character.FirstName;
            LastNameDataLabel.Text = Program.character.LastName;
        }

        private void LoadSkill()
        {

        }
        private void GenerateRandomSkill()
        {

        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }

        /// <summary>
        /// This is the event handler for the NextButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }
    }
}
