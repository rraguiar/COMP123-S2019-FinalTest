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

        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            string[] loadedFirstNames = new string[0];
            string[] loadedLastNames = new string[0];

            int indexFName = 0, indexLName = 0;

            // open the file firstName.txt to read
            using (StreamReader inputFNameString = new StreamReader(
                File.Open("firstNames.txt", FileMode.Open)))
            {
                string firstName;

                //read each line and add to an array of strings.
                while (inputFNameString.Peek() != -1)
                {
                    firstName = inputFNameString.ReadLine();
                    loadedFirstNames[indexFName] = firstName;
                    indexFName++;
                }

                //cleanup
                inputFNameString.Close();
                inputFNameString.Dispose();
            }

            // open the file lastName.txt to read
            using (StreamReader inputLNameString = new StreamReader(
                File.Open("lastNames.txt", FileMode.Open)))
            {
                string lastName;

                //read each line and add to an array of strings.
                while (inputLNameString.Peek() != -1)
                {
                    lastName = inputLNameString.ReadLine();
                    loadedFirstNames[indexLName] = lastName;
                    indexLName++;
                }

                //cleanup
                inputLNameString.Close();
                inputLNameString.Dispose();
            }

            //Randomly assign First and Last names from the arrays of strings



        }
    }
}
