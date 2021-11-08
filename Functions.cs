using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swoger_CourseProject_Part1
{
    partial class VideoManager
    {
        //***********************************************************************************************************
        //*************************************************FUNCTIONS*************************************************
        //***********************************************************************************************************
        //****************************
        //*****Song List Function*****
        //****************************
        private bool SongInList(string SongTitle)
        {
            bool inList = false;
            foreach (var item in songList.Items)
            {
                string currentSong = item as string;
                if (SongTitle == currentSong)
                {
                    inList = true;
                }
            }
            return inList;
        }
        //*******************************
        //*****Verify Input Function*****
        //*******************************
        private bool ValidInput()
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(titleText.Text)) //Check Title
            {
                MB("The Title can't be blank!", "Error!", 1); //Message Box Pass Through Title
                isValid = false;
            }
            else if (string.IsNullOrEmpty(artistText.Text)) //Check Artist
            {
                MB("The Artist can't be blank!", "Error!", 1); //Message Box Pass Through Artist
                isValid = false;
            }
            else if (string.IsNullOrEmpty(genreText.Text)) //Check Genre
            {
                MB("The Genre can't be blank!", "Error!", 1); //Message Box Pass Through Genre
                isValid = false;
            }
            else if (string.IsNullOrEmpty(yearText.Text)) //Check Year
            {
                MB("The Year can't be blank!", "Error!", 1); //Message Box Pass Through Year
                isValid = false;
            }
            else if (string.IsNullOrEmpty(urlText.Text)) //Check URL
            {
                MB("The URL can't be blank!", "Error!", 1); //Message Box Pass Through URl
                isValid = false;
            }
            return isValid;
        }
        //************************
        //*****Clear Function*****
        //************************
        private void clear() //Method to clear all text box's
        {
            //Clears Text
            titleText.Text = String.Empty;
            artistText.Text = String.Empty;
            genreText.Text = String.Empty;
            yearText.Text = String.Empty;
            urlText.Text = String.Empty;

            //Sets Focus
            titleText.Focus();
        }
        //******************************
        //*****Message Box Function*****
        //******************************
        private void MB(string Text, String Title, int Icon)
        {
            if (Icon == 1) //ERROR
                MessageBox.Show(Text, Title, System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Error);
            else if (Icon == 2) //QUESTION
                MessageBox.Show(Text, Title, System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Question);
            else if (Icon == 3) //Exclamation
                MessageBox.Show(Text, Title, System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Exclamation);
            else if (Icon == 4) //Information
                MessageBox.Show(Text, Title, System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Information);
        }
    }
}
//***********************************************************************************************************
//**************************************BUTTONS CAN BE FOUND IN FORM.CS**************************************
//***********************************************************************************************************
