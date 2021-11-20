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
//*********************************************FORM BUTTONS**************************************************
//***********************************************************************************************************

namespace Swoger_CourseProject
{
    public partial class VideoManager : Form
    {
        public VideoManager()
        {
            InitializeComponent();
        }
        //*******************************
        //********Add Song Button********
        //*******************************
        private void addButton_Click(object sender, EventArgs e)
        {
            if (songCount == titleArray.Length)
                MB("Song List Full", "Error!", MessageBoxIcon.Error);
            else if (ValidInput())
            {
                //Build String
                StringBuilder sb = new StringBuilder(String.Empty);
                string nl = "\r\n";

                //Add title to songlist/Add data to arrays
                songList.Items.Add(titleText.Text);
                titleArray[songCount] = titleText.Text;
                artistArray[songCount] = artistText.Text;
                genreArray[songCount] = genreCombo.SelectedItem.ToString();
                yearArray[songCount] = int.Parse(yearText.Text);
                urlArray[songCount] = urlText.Text;

                //Increment the song counter
                songCount++;

                //Build the output Text
                sb.Append(titleText.Text);
                sb.Append(nl);
                sb.Append(artistText.Text);
                sb.Append(nl);
                sb.Append(genreCombo.Text);
                sb.Append(nl);
                sb.Append(yearText.Text);
                sb.Append(nl);
                sb.Append(urlText.Text);
                sb.Append(nl);

                //Output built text
                outputText.Text = sb.ToString();
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
            //Create messagebox is song is found/not found.
            if (SongInList(titleText.Text))
            {
                int songIndex = GetSongIndex(titleText.Text);

                StringBuilder sb = new StringBuilder(String.Empty);
                string nl = "\r\n";

                //Build the output Text
                sb.Append(titleArray[songIndex]);
                sb.Append(nl);
                sb.Append(artistArray[songIndex]);
                sb.Append(nl);
                sb.Append(genreArray[songIndex]);
                sb.Append(nl);
                sb.Append(yearArray[songIndex]);
                sb.Append(nl);
                sb.Append(urlArray[songIndex]);
                sb.Append(nl);

                //Output built text
                outputText.Text = sb.ToString();
            }
            else
            {
                MB($"Song {titleText.Text} not found", "Error!", MessageBoxIcon.Error);
            }
        }
        //*******************************
        //**********Play Button**********
        //*******************************
        private void playButton_Click(object sender, EventArgs e)
        {
            int songIndex = songList.SelectedIndex;
            string url = urlArray[songIndex];
            webBrowserDisplay.Navigate(url);
        }
        //*******************************
        //**********Clear Button*********
        //*******************************
        private void clearSong_Click(object sender, EventArgs e)
        {
            clear();
        }
        //*******************************
        //**********Save Button**********
        //*******************************
        private void saveButton_Click(object sender, EventArgs e)
        {
            //Open the file
            StreamWriter fileWriter = new StreamWriter(FILENAME);

            //Write to file
            for (int i = 0; i < titleArray.Length; i++)
            {
                //Break out when empty
                if (string.IsNullOrEmpty(titleArray[i]))
                {
                    break;
                }
                //Write the fileds in CSV
                fileWriter.WriteLine(titleArray[i]+","+artistArray[i]+","+genreArray[i]+","+yearArray[i].ToString()+","+ urlArray[i]);
            }
            //Close file
            MB($"Saved to {FILENAME}", "Saved Successful!", MessageBoxIcon.Information);
            fileWriter.Close();
        }
        //*******************************
        //**********Load Button**********
        //*******************************
        private void loadButton_Click(object sender, EventArgs e)
        {
            StreamReader fileReader = new StreamReader(FILENAME);
            int count = 0;
            
            //Read Records till we run out
            while(fileReader.Peek() > -1)
            {
                //Read entire line
                string line = fileReader.ReadLine();
                string[] parts = line.Split(',');
                titleArray[count] = parts[0];
                artistArray[count] = parts[1];
                genreArray[count] = parts[2];
                yearArray[count] = int.Parse(parts[3]);
                urlArray[count] = parts[4];

                //Increment counter and Song Counter
                count++;
                songCount++;
            }
            //Close file
            MB($"Loaded from {FILENAME}", "Load Successful!", MessageBoxIcon.Information);
            fileReader.Close();

            //Load songs in listbox
            songList.Items.Clear();

            for (int i = 0;i < titleArray.Length;i++)
                if (string.IsNullOrEmpty(titleArray[i]))
                    break;
            else
                songList.Items.Add(titleArray[i]);
        }
    }//End Class
}//End NameSpace
 //***********************************************************************************************************
 //***********************************FUNCTIONS CAN BE FOUND IN FUNCTIONS.CS**********************************
 //***********************************************************************************************************