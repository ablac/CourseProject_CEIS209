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

//***********************************************************************************************************
//*************************************************FUNCTIONS*************************************************
//***********************************************************************************************************

namespace Swoger_CourseProject
{
    public partial class VideoManager
    {
        //*******************************
        //*******Song List Function******
        //*******************************
        private bool SongInList(string SongTitle)
        {
            bool inList = false;
            foreach (string currentSong in songList.Items)
            {
                if (SongTitle == currentSong)
                {
                    inList = true;
                    //Break out of loop
                    break;
                }
            }
            //Return Result
            return inList;
        }
        //*******************************
        //*****Verify Input Function*****
        //*******************************
        private bool ValidInput()
        {
            bool isValid = true;
            //Check Title
            if (string.IsNullOrEmpty(titleText.Text))
            {
                //Message Box Pass Through Title
                MB("The Title can't be blank!", "Error!", MessageBoxIcon.Error);
                titleText.Focus();
                isValid = false;
            }
            //Check Artist
            else if (string.IsNullOrEmpty(artistText.Text))
            {
                //Message Box Pass Through Artist
                MB("The Artist can't be blank!", "Error!", MessageBoxIcon.Error);
                artistText.Focus();
                isValid = false;
            }
            //Check Genre
            else if (string.IsNullOrEmpty(genreText.Text))
            {
                //Message Box Pass Through Genre
                MB("The Genre can't be blank!", "Error!", MessageBoxIcon.Error);
                genreText.Focus();
                isValid = false;
            }
            //Check Year
            else if (string.IsNullOrEmpty(yearText.Text))
            {
                //Message Box Pass Through Year
                MB("The Year can't be blank!", "Error!", MessageBoxIcon.Error);
                yearText.Focus();
                isValid = false;
            }
            //Check URL
            else if (string.IsNullOrEmpty(urlText.Text))
            {
                //Message Box Pass Through URl
                MB("The URL can't be blank!", "Error!", MessageBoxIcon.Error);
                urlText.Focus();
                isValid = false;
            }
            return isValid;
        }
        //*******************************
        //*********Clear Function********
        //*******************************
        private void clear()
        {
            //Clears Text
            titleText.Clear();
            artistText.Clear();
            genreText.SelectedIndex = -1;
            yearText.Clear();
            urlText.Clear();

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
