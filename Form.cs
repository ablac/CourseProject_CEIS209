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
    public partial class VideoManager : Form
    {
        //***********************************************************************************************************
        //**************************************************BUTTONS**************************************************
        //***********************************************************************************************************
        public VideoManager()
        {
            InitializeComponent();
        }
        //*******************************
        //********Add Song Button********
        //*******************************
        private void addButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(outputText.Text);
            string nl = "\r\n";

            if (ValidInput())
            {
                //Build the output Text
                sb.Append(titleText.Text);
                sb.Append(nl);
                sb.Append(artistText.Text);
                sb.Append(nl);
                sb.Append(genreText.Text);
                sb.Append(nl);
                sb.Append(yearText.Text);
                sb.Append(nl);
                sb.Append(urlText.Text);
                sb.Append(nl);

                //Output built text
                outputText.Text = sb.ToString();
                songList.Items.Add(titleText.Text);
                clear();
            }
        }
        //*******************************
        //*****View all songs button*****
        //*******************************
        private void allSongsButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(string.Empty);

            //Shortcut for New Line
            string nl = "\r\n";

            //Build the Output Text
            foreach (var item in songList.Items)
            {
                sb.Append(item.ToString());
                sb.Append(nl);
            }
            //Put the output text into the output box
            outputText.Text = sb.ToString();
        }
        //*******************************
        //********Find Song Button*******
        //*******************************
        private void findButton_Click(object sender, EventArgs e)
        {
            if (SongInList(titleText.Text))
            {
                MB($"Song {titleText.Text} Found", "Found Song!", 4);
            }
            else
                MB($"Song {titleText.Text} not found", "Error!", 1);
        }
        //*******************************
        //**********Clear Button*********
        //*******************************
        private void clearSong_Click(object sender, EventArgs e)
        {
            clear();
        }
        //*******************************
        //*******Easter Egg Button*******
        //*******************************
        private void titleLabel_Click(object sender, EventArgs e)
        {
            MB("This is an EasterEgg LOL!", "Easter Egg :D", 3);
        }
    }
}
//***********************************************************************************************************
//***********************************FUNCTIONS CAN BE FOUND IN FUNCTIONS.CS**********************************
//***********************************************************************************************************