using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/* TeenCoder: Windows Programming
   
   Song Player Application

   Copyright 2013 CompuScholar, Inc.
*/

namespace SongPlayer
{
    public partial class SongPlayerForm : Form
    {
        LinkedList<Song> songs = new LinkedList<Song>();

        public SongPlayerForm()
        {
            InitializeComponent();

            // fill out songs array
            initializeSongs();

        }

        private void initializeSongs()
        {
            LinkedList<Song> SongList = new LinkedList<Song>();
            Song StarWars = new Song("Star Wars");
            Song HappyBday = new Song("Happy Birthday");
            Song CoffinDance = new Song("Astronomia");

            //Notes for Star wars
            StarWars.AddNote(300,800);
            StarWars.AddNote(300,800);
            StarWars.AddNote(300,800);
            StarWars.AddNote(250,800);
            StarWars.AddNote(350,400);
            StarWars.AddNote(300,800);
            StarWars.AddNote(250,800);
            StarWars.AddNote(350,400);
            StarWars.AddNote(300,800);

            //notes for Happy birthday
            HappyBday.AddNote(264, 200);
            HappyBday.AddNote(264, 200);
            HappyBday.AddNote(298, 800);
            HappyBday.AddNote(264, 800);
            HappyBday.AddNote(352, 800);
            HappyBday.AddNote(330, 1600);
            HappyBday.AddNote(264, 200);
            HappyBday.AddNote(264, 200);
            HappyBday.AddNote(298, 800);
            HappyBday.AddNote(264, 800);
            HappyBday.AddNote(396, 800);
            HappyBday.AddNote(352, 1600);

            //Notes for Astronomia
            CoffinDance.AddNote(370, 400);
            CoffinDance.AddNote(370, 400);
            CoffinDance.AddNote(370, 400);
            CoffinDance.AddNote(370, 400);
            CoffinDance.AddNote(466, 400);
            CoffinDance.AddNote(466, 400);
            CoffinDance.AddNote(466, 400);
            CoffinDance.AddNote(466, 400);
            CoffinDance.AddNote(415, 400);
            CoffinDance.AddNote(414, 400);
            CoffinDance.AddNote(414, 400);
            CoffinDance.AddNote(414, 400);
            CoffinDance.AddNote(554, 400);
            CoffinDance.AddNote(554, 400);
            CoffinDance.AddNote(554, 400);
            CoffinDance.AddNote(554, 400);
            CoffinDance.AddNote(622, 400);
            CoffinDance.AddNote(622, 400);
            CoffinDance.AddNote(622, 400);
            CoffinDance.AddNote(622, 400);
            CoffinDance.AddNote(622, 400);
            CoffinDance.AddNote(622, 400);
            CoffinDance.AddNote(622, 400);
            CoffinDance.AddNote(622, 400);
            CoffinDance.AddNote(622, 400);
            CoffinDance.AddNote(622, 400);
            CoffinDance.AddNote(622, 400);
            CoffinDance.AddNote(622, 400);
            CoffinDance.AddNote(466, 400);
            CoffinDance.AddNote(414, 400);
            CoffinDance.AddNote(370, 400);
            CoffinDance.AddNote(262, 400);

            songs.AddLast(StarWars);
            songs.AddLast(HappyBday);
            songs.AddLast(CoffinDance);
            SongListBox.Items.Add("Star Wars");
            SongListBox.Items.Add("Happy Birthday");
            SongListBox.Items.Add("Astronomia/Coffin Dance");
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            // get the current selection index
            int selection = SongListBox.SelectedIndex;
            if (selection >= 0)
            {
                // get the selected song from the list
                Song s = songs.ElementAt(selection);

                // play the song
                s.Play();
            }

        }
    }
}
