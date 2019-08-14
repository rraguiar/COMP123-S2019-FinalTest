using COMP123_S2019_FinalTest.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

/*
 * STUDENT NAME: RAFAEL RODRIGUES DE AGUIAR
 * STUDENT ID: 301041266
 * DESCRIPTION: This is the Hero Generator Form
 * 
 */
namespace COMP123_S2019_FinalTest.Views
{
    public partial class HeroGenerator : COMP123_S2019_FinalTest.Views.MasterForm
    {
        public HeroGenerator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the BackButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex != 0)
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
            if (MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }

        /// <summary>
        /// This is the event Handler for the GenerateName button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            //call the Load Names function
            LoadNames();
        }

        private void LoadNames()
        {
            List<string> loadedFirstNames = new List<string>();
            List<string> loadedLastNames = new List<string>();
            int indexFName = 0, indexLName = 0;

            // open the file firstName.txt to read
            using (StreamReader inputFNameString = new StreamReader(
                File.Open("..\\..\\Data\\firstNames.txt", FileMode.Open)))
            {
                string firstName;

                //read each line and add to an array of strings.

                while (inputFNameString.Peek() != -1)
                {
                    firstName = inputFNameString.ReadLine();
                    loadedFirstNames.Add(firstName);
                }

                //cleanup
                inputFNameString.Close();
                inputFNameString.Dispose();
            }

            // open the file lastName.txt to read
            using (StreamReader inputLNameString = new StreamReader(
                File.Open("..\\..\\Data\\lastNames.txt", FileMode.Open)))
            {
                string lastName;

                //read each line and add to an array of strings.
                while (inputLNameString.Peek() != -1)
                {
                    lastName = inputLNameString.ReadLine();
                    loadedLastNames.Add(lastName);
                }

                //cleanup
                inputLNameString.Close();
                inputLNameString.Dispose();
            }

            //Randomly assign First and Last names from the arrays of strings
            Random random = new Random();
            indexFName = loadedFirstNames.Count - 1;
            indexLName = loadedLastNames.Count - 1;
            int fNameRandomIndex = random.Next(0, indexFName);
            int lNameRandomIndex = random.Next(0, indexLName);

            //load first and last names to the corresponding labels
            FirstNameDataLabel.Text = loadedFirstNames[fNameRandomIndex];
            LastNameDataLabel.Text = loadedLastNames[lNameRandomIndex];

            //load names to the Hero Class
            Program.Character.FirstName = FirstNameDataLabel.Text;
            Program.Character.LastName = LastNameDataLabel.Text;
            Program.Character.HeroName = HeroNameTextBox.Text;
        }
    }
}
