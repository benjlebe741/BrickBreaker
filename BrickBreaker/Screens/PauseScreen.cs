using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreaker.Screens
{
    public partial class PauseScreen : UserControl
    {
        GameScreen parentScreen;
        
        //Creates a new pause screen using the current percentage of blocks broken as your 'score'
        public PauseScreen(GameScreen _parentScreen, double score)
        {
            //The pause screen is created over top of the game screen (_parentScreen)
            parentScreen = _parentScreen;
            InitializeComponent();
            
            //Apply custom font
            Form1.SetLevelFonts(this);
            this.Focus();
            scoreLabel.Text = score + "%";
        }

        //Exit the game
        private void exitButton_Click(object sender, EventArgs e)
        {
            Form1.clickSound.Play();
            Application.Exit();
        }

        //Go to Level Screen
        private void levelButton_Click(object sender, EventArgs e)
        {
            Form1.clickSound.Play();

            LevelScreen ls = new LevelScreen();
            Form form = this.FindForm();


            form.Controls.Add(ls);
            //Remove both this pause screen and the game screen it was on
            form.Controls.Remove(parentScreen);
            form.Controls.Remove(this);

            ls.Location = new Point((form.Width - ls.Width) / 2, (form.Height - ls.Height) / 2);
        }

        #region Un-Pausing

        //Unpause with both continue button and key presses
        private void continueButton_Click(object sender, EventArgs e)
        {
            unPause();
        }
    
        private void PauseScreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Space || (Keys)e.KeyChar == Keys.Enter)
            {
                unPause();
            }
        }

        void unPause()
        {
            Form1.clickSound.Play();
            //Remove the pause screen, continue the game screen, the 'isPaused' variable stops you from opening more than one pause screen,
            //So we also communicate to the game screen that it can pause again here.
            parentScreen.gameTimer.Enabled = true;
            parentScreen.Controls.Remove(this);
            parentScreen.isPaused = false;
            parentScreen.Focus();
        }
        #endregion
    }
}
