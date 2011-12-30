using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;
using System.Windows.Resources;

namespace App1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // The sounds to play
        private SoundEffect lionSound;
        private SoundEffect cowSound;
        private SoundEffect elephantSound;
        private SoundEffect catSound;
        private SoundEffect dogSound;
        private SoundEffect donkeySound;
        private SoundEffect horseSound;
        private SoundEffect duckSound;
        
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Prime the pump or we'll get an exception.
            FrameworkDispatcher.Update();

            // Create and load SoundEffect objects.
            LoadSound("Sounds/lionSound.wav", out lionSound);
            LoadSound("Sounds/cowSound.wav", out cowSound);
            LoadSound("Sounds/elephantSound.wav", out elephantSound);
            LoadSound("Sounds/catSound.wav", out catSound);
            LoadSound("Sounds/dogSound.wav", out dogSound);
            LoadSound("Sounds/donkeySound.wav", out donkeySound);
            LoadSound("Sounds/horseSound.wav", out horseSound);
            LoadSound("Sounds/duckSound.wav", out duckSound);
        }

        /// <summary>
        /// Loads a wav file into an XNA Framework SoundEffect.
        /// </summary>
        /// <param name="SoundFilePath">Relative path to the wav file.</param>
        /// <param name="Sound">The SoundEffect to load the audio into.</param>
        private void LoadSound(String SoundFilePath, out SoundEffect Sound)
        {
            // For error checking, assume we'll fail to load the file.
            Sound = null;

            try
            {
                //test
                Uri uri = new Uri(SoundFilePath, UriKind.Relative);

                // Holds informations about a file stream.
                StreamResourceInfo SoundFileInfo = App.GetResourceStream(uri);

                // Create the SoundEffect from the Stream
                Sound = SoundEffect.FromStream(SoundFileInfo.Stream);
            }
            catch (NullReferenceException)
            {
                // Display an error message
                MessageBox.Show("Couldn't load sound " + SoundFilePath);
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lionSound.Play();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Can't play, lionSound is null.");
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cowSound.Play();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Can't play, cowSound is null.");
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                elephantSound.Play();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Can't play, elephantSound is null.");
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                catSound.Play();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Can't play, catSound is null.");
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dogSound.Play();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Can't play, dogSound is null.");
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                donkeySound.Play();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Can't play, donkeySound is null.");
            }
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                horseSound.Play();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Can't play, horseSound is null.");
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                duckSound.Play();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Can't play, duckSound is null.");
            }
        }


    }
}