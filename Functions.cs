using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* CEIS 209
 * Devry University
 * Keith S
 * 11/5/2021
*/

namespace Swoger_CourseProject_Part1
{
    public partial class VideoManager
    {
        //***********************************************************************************************************
        //*************************************************FUNCTIONS*************************************************
        //***********************************************************************************************************
        //*******************************
        //*******Song List Function******
        //*******************************
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
                MB("The Title can't be blank!", "Error!", MessageBoxIcon.Error); //Message Box Pass Through Title
                titleText.Focus();
                isValid = false;
            }
            else if (string.IsNullOrEmpty(artistText.Text)) //Check Artist
            {
                MB("The Artist can't be blank!", "Error!", MessageBoxIcon.Error); //Message Box Pass Through Artist
                artistText.Focus();
                isValid = false;
            }
            else if (string.IsNullOrEmpty(genreText.Text)) //Check Genre
            {
                MB("The Genre can't be blank!", "Error!", MessageBoxIcon.Error); //Message Box Pass Through Genre
                genreText.Focus();
                isValid = false;
            }
            else if (string.IsNullOrEmpty(yearText.Text)) //Check Year
            {
                MB("The Year can't be blank!", "Error!", MessageBoxIcon.Error); //Message Box Pass Through Year
                yearText.Focus();
                isValid = false;
            }
            else if (string.IsNullOrEmpty(urlText.Text)) //Check URL
            {
                MB("The URL can't be blank!", "Error!", MessageBoxIcon.Error); //Message Box Pass Through URl
                urlText.Focus();
                isValid = false;
            }
            return isValid;
        }
        //*******************************
        //*********Clear Function********
        //*******************************
        private void clear() //Method to clear all text box's
        {
            //Clears Text
            titleText.Text = String.Empty;
            artistText.Text = String.Empty;
            genreText.Text = String.Empty;
            yearText.Text = String.Empty;
            urlText.Text = String.Empty;

            //Sets Focus
            _ = titleText.Focus();
        }
        //*******************************
        //******Message Box Function*****
        //*******************************
        private void MB(string Text, String Title, MessageBoxIcon ICON)
        {
            MessageBox.Show(Text, Title, MessageBoxButtons.OKCancel, ICON);
        }
    }
}
//***********************************************************************************************************
//**************************************BUTTONS CAN BE FOUND IN FORM.CS**************************************
//***********************************************************************************************************
