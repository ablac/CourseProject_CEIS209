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
        public VideoManager()
        {
            InitializeComponent();
        }

        //Add Song Button
        private void addButton_Click(object sender, EventArgs e)
        {
            //Error Checking/Not Blank
            if (string.IsNullOrEmpty(titleText.Text)) //Check Title
                MB("The Title can't be blank!", "Error!"); //Message Box Pass Through Title
            else if (string.IsNullOrEmpty(artistText.Text)) //Check Artist
                MB("The Artist can't be blank!", "Error!"); //Message Box Pass Through Artist
            else if (string.IsNullOrEmpty(genreText.Text)) //Check Genre
                MB("The Genre can't be blank!", "Error!"); //Message Box Pass Through Genre
            else if (string.IsNullOrEmpty(yearText.Text)) //Check Year
                MB("The Year can't be blank!", "Error!"); //Message Box Pass Through Year
            else if (string.IsNullOrEmpty(urlText.Text)) //Check URL
                MB("The URL can't be blank!", "Error!"); //Message Box Pass Through URL
            else
            {
                //Build the output text
                songList.Items.Add(titleText.Text);
                clear(); //Clear Textboxes and Set Focus to Title
            }
        }

        //View all songs button
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

        //Clear's all text from boxes, and moves focus to Title Box.
        private void clear() //Method to clear all text box's
        {
            //Clears Text
            //titleText.Text = String.Empty;
            //artistText.Text = String.Empty;
            //genreText.Text = String.Empty;
            //yearText.Text = String.Empty;
            //urlText.Text = String.Empty;

            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };
            func(Controls);

            //Sets Focus
            titleText.Focus();
        }

        //MessageBox Method, generates the message box
        private void MB(string Text, String Title)
        {
            MessageBox.Show(Text, Title,
                    System.Windows.Forms.MessageBoxButtons.OKCancel,
                    System.Windows.Forms.MessageBoxIcon.Error);
        }

        //Generates Easteregg when clicking Title
        private void titleLabel_Click(object sender, EventArgs e)
        {
            MB("This is an EasterEgg LOL!", "Easter Egg :D");
        }
    }
}

/* Build Output Text Saved Code.
            StringBuilder sb = new StringBuilder(string.Empty);

            //Shortcut for New Line
            string nl = "\r\n"; 

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
*/