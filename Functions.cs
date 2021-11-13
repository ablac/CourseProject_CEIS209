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
            Dictionary<string, TextBox> textBoxes = new Dictionary<string, TextBox>
            {
                { "Title", titleText },
                { "Artist", artistText },
                { "Year" , yearText},
                { "URL", urlText }
            };
            foreach (var item in textBoxes)
            {
                var name = item.Key;
                var textbox = item.Value;

                if (string.IsNullOrEmpty(textbox.Text))
                {
                    MB($"The {name} can't be blank!", "Error!", MessageBoxIcon.Error);
                    textbox.Focus();
                    return false;
                }
            }
            //Check Genre
            if (string.IsNullOrEmpty(genreCombo.Text))
            {
                //Message Box Pass Through Genre
                MB("The Genre can't be blank!", "Error!", MessageBoxIcon.Error);
                genreCombo.Focus();
                return false;
            }
            return true;
        }
        //*******************************
        //*********Clear Function********
        //*******************************
        private void clear()
        {
            //Clears Text
            titleText.Clear();
            artistText.Clear();
            genreCombo.SelectedIndex = -1;
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
