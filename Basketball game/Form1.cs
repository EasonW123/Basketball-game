using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
/// <summary>
/// Eason Wu, Erik Smith
/// Basketball decsion game
/// ICS3U
/// November 7,2019
/// </summary>
namespace Basketball_game
{
    public partial class Form1 : Form
    {
        //variables for the scene
        int scene = 1;
        // random number generator
        Random ranGen = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 1) { scene = 3; }
                else if (scene == 3) { scene = 7; }
                else if (scene == 7) { scene = 16; }
                else if (scene == 16) { scene = 29; }
                else if (scene == 6) { scene = 13; }
                else if (scene == 29)
                {
                    int randValue = ranGen.Next(1, 101);
                    if (randValue < 90) { scene = 38; }
                    else { scene = 37; }
                }
                else if (scene == 14) { scene = 25; }
                else if (scene == 24)
                {
                    int randValue = ranGen.Next(1, 101);
                    if (randValue < 70) { scene = 34; }
                    else { scene = 33; }
                }
                else if (scene == 8) { scene = 13; }
                else if (scene == 13) { scene = 23; }
                else if (scene == 2) { scene = 5; }
                else if (scene == 5) { scene = 11; }
                else if (scene == 11)
                {
                    int randValue = ranGen.Next(1, 101);

                    if (randValue < 80) { scene = 99; }
                    else { scene = 21; }
                }
                else if (scene == 10) { scene = 20; }
                else if (scene == 19) { scene = 98; }
                else if (scene == 4) { scene = 9; }
                else if (scene == 8) { scene = 18; }


            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 4; }
                else if (scene == 4) { scene = 8; }
                else if (scene == 8) { scene = 17; }
                else if (scene == 5) { scene = 10; }
                else if (scene == 10) { scene = 19; }
                else if (scene == 19) { scene = 99; }
                else if (scene == 3) { scene = 6; }
                else if (scene == 6) { scene = 12; }
                else if (scene == 13) { scene = 22; }
                else if (scene == 7) { scene = 14; }
                else if (scene == 14) { scene = 24; }
                else if (scene == 24) { scene = 32; }
                else if (scene == 16)
                {
                    int randValue = ranGen.Next(1, 101);

                    if (randValue < 75) { scene = 99; }
                    else { scene = 98; }
                }
                else if (scene == 29)
                {
                    int randValue = ranGen.Next(1, 101);

                    if (randValue < 40) { scene = 99; }
                    else { scene = 98; }
                }
            }
            else if (e.KeyCode == Keys.N) //yellow button
            {
                if (scene == 7) { scene = 15; }


                else if (scene == 17) { scene = 98; }
                else if (scene == 18) { scene = 99; }
                else if (scene == 9) { scene = 98; }
                else if (scene == 20) { scene = 98; }
                else if (scene == 21) { scene = 98; }
                else if (scene == 12) { scene = 98; }
                else if (scene == 22) { scene = 98; }
                else if (scene == 23) { scene = 99; }
                else if (scene == 32) { scene = 99; }
                else if (scene == 33) { scene = 98; }
                else if (scene == 34) { scene = 99; }
                else if (scene == 25) { scene = 99; }
                else if (scene == 15) { scene = 98; }
                else if (scene == 37) { scene = 98; }
                else if (scene == 38) { scene = 99; }
            }

            


            switch (scene)
            {
                // what each scene is doing
                case 1:
                    outLabel.Text = "What do you want to be?";
                    rLabel.Text = "Lebron James";
                    bLabel.Text = "Kyrie Ivring";
                    yLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.kyrie__lebron;
                    break;
                case 2:
                    outLabel.Text = "Who do you want to play against?";
                    rLabel.Text = "Chris Paul";
                    bLabel.Text = "Luka Doncic";
                    yLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.luka_chris;
                    break;
                case 3:
                    outLabel.Text = "Who do you want to play against?";
                    rLabel.Text = "Chris Paul";
                    bLabel.Text = "Luka Doncic";
                    yLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.luka_chris;
                    break;
                case 4:
                    outLabel.Text = "Game to 1, you start with the ball. What do you want to do?";
                    rLabel.Text = "Shoot it in his face";
                    bLabel.Text = "Dribble";
                    yLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.kyrie_w_ball;
                    break;
                case 5:
                    outLabel.Text = "Game to 1, you start with the ball. What do you want to do?";
                    rLabel.Text = "Shoot";
                    bLabel.Text = "Pump fake";
                    yLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.kyrie_w_ball;
                    break;
                case 6:
                    outLabel.Text = "Game to 1, you start with the ball. What do you want to do?";
                    rLabel.Text = "Drive";
                    bLabel.Text = "Pass";
                    yLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.lebron_against_luka;
                    break;
                case 7:
                    outLabel.Text = "Game to 1, you start with the ball. What do you want to do?";
                    rLabel.Text = "Post up";
                    bLabel.Text = "Dribble";
                    yLabel.Text = "Pass";
                    sceneImage.BackgroundImage = Properties.Resources.lb_against_cp;
                    break;
                case 8:
                    outLabel.Text = "You fake left and then crossover to the right. Doncic stays in front of you. What do you do next?";
                    rLabel.Text = "Hesi spin";
                    bLabel.Text = "Step back three";
                    yLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.Luka_guarding;
                    break;
                case 9:
                    outLabel.Text = "Doncic is taller than you and blocks you. He grabs the ball and splashes a three.";
                    yLabel.Text = "continue.";
                    rLabel.Text = "";
                    bLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.luka_block;
                    break;
                case 10:
                    outLabel.Text = "Chris Paul bit the pump fake and there is a open lane do you take it?";
                    rLabel.Text = "No";
                    bLabel.Text = "Yes";
                    yLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.kyrie_driving;
                    break;
                case 11:
                    outLabel.Text = "you took the shot";
                    rLabel.Text = "Continue";
                    rLabel.Text = "";
                    bLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.kyrie_driving;
                    break;
                case 12:
                    outLabel.Text = "You're playing 1 on 1! There isn't an open man! You throw the ball out of bounds and Luka get the ball.";
                    yLabel.Text = "continue";
                    rLabel.Text = "";
                    bLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.lbj_pass;
                    break;
                case 13:
                    outLabel.Text = "You blow by Luka with your speed and have an open lane. What do you do next?";
                    rLabel.Text = "Dunk";
                    bLabel.Text = "Layup";
                    yLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.lbj_drive_pass_luka;
                    break;
                case 14:
                    outLabel.Text = "You dribbled around the 3 point line and you can't find an opening what do you do?";
                    rLabel.Text = "Shoot";
                    bLabel.Text = "Drive";
                    yLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.lbj_dribble;
                    break;
                case 15:
                    outLabel.Text = "You passed to a teammate watching the game but you are playing 1v1.";
                    yLabel.Text = "Continue";
                    rLabel.Text = "";
                    bLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.lbj_pass;
                    break;
                case 16:
                    outLabel.Text = "You post up Chris Paul and found an opening for a shot, do you take it?";
                    rLabel.Text = "No";
                    bLabel.Text = "Yes";
                    yLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.lbj_postup_cp;
                    break;
                case 17:
                    outLabel.Text = "You get the shot off. It bounces off the front of the rim and rolls out. Luka quickly grabs the board and makes a shot from the 3 point line";
                    yLabel.Text = "Continue";
                    rLabel.Text = "";
                    bLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.rim;
                    SoundPlayer rimSound = new SoundPlayer(Properties.Resources.rim1);
                    rimSound.Play();
                    break;
                case 18:
                    outLabel.Text = "Luka stumbles forwards and drive past for an easy layup.";
                    yLabel.Text = "Continue";
                    rLabel.Text = "";
                    bLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.kyrie_layup;
                    break;
                case 19:
                    outLabel.Text = "You took the lane and you got in-front of Chris Paul, do you go for a layup or stop and go for a jump shot?";
                    rLabel.Text = "Shoot";
                    bLabel.Text = "Layup";
                    yLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.kyrie_driving;
                    break;
                case 20:
                    outLabel.Text = "You didn't took the lane and Chris Paul recovered from the pump fake and he stole the ball from you.";
                    yLabel.Text = "Continue";
                    rLabel.Text = "";
                    bLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.cp_steal;
                    break;
                case 21:
                    outLabel.Text = "You missed the shot and Chris Paul got the robound and splashed a 3";
                    yLabel.Text = "Continue";
                    rLabel.Text = "";
                    bLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.cp_shoot;
                    break;
                case 22:
                    outLabel.Text = "Luka chases you down and swats the lame layup off the backboard. Then he shoots an open mid range shot.";
                    yLabel.Text = "Continue";
                    rLabel.Text = "";
                    bLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.luka_block;
                    break;
                case 23:
                    outLabel.Text = "Luka tries to block you but you throw down the huge dunk on him.";
                    yLabel.Text = "Continue";
                    rLabel.Text = "";
                    bLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.lbj_dunk;
                    break;
                case 24:
                    outLabel.Text = "You got through his defense. What do you want to do now?";
                    rLabel.Text = "Layup";
                    bLabel.Text = "Dunk";
                    yLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.lbj_drive;
                    break;
                case 25:
                    outLabel.Text = "You made the shot";
                    yLabel.Text = "Continue";
                    rLabel.Text = "";
                    bLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.basketball;
                    break;
                case 26:
                    break;
                case 27:
                    outLabel.Text = "You missed your shot.";
                    yLabel.Text = "Continue";
                    rLabel.Text = "";
                    bLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.airball;
                    break;
                case 28:
                    outLabel.Text = "You made the shot";
                    yLabel.Text = "Continue";
                    rLabel.Text = "";
                    bLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.basketball;
                    break;
                case 29:
                    outLabel.Text = "You kept posting up Chris Paul and found an opening. what do you do?";
                    rLabel.Text = "Dunk";
                    bLabel.Text = "Put up";
                    yLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.lbj_postup_cp;
                    break;
                case 30:
                    outLabel.Text = "You missed the shot and Chris Paul got the rebound";
                    yLabel.Text = "Continue";
                    rLabel.Text = "";
                    bLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.cp_rebound;
                    break;
                case 31:
                    outLabel.Text = "You missed the shot and Chris Paul got the rebound";
                    yLabel.Text = "Continue";
                    rLabel.Text = "";
                    bLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.cp_rebound;
                    break;
                case 32:
                    outLabel.Text = "You dunked on Chris Paul";
                    yLabel.Text = "Continue";
                    rLabel.Text = "";
                    bLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.lbj_dunk;
                    break;
                case 33:
                    outLabel.Text = "You missed the layup";
                    yLabel.Text = "Continue";
                    rLabel.Text = "";
                    bLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.lbj_layup;
                    break;
                case 34:
                    outLabel.Text = "You made the layup";
                    yLabel.Text = "continue";
                    rLabel.Text = "";
                    bLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.lbj_layup;
                    break;
                case 35:
                    outLabel.Text = "You got blocked";
                    yLabel.Text = "Continue";
                    rLabel.Text = "";
                    bLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.cp_block_lbj;
                    break;
                case 36:
                    outLabel.Text = "You're shot went in";
                    yLabel.Text = "Continue";
                    rLabel.Text = "";
                    bLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.basketball;
                    break;
                case 37:
                    outLabel.Text = "You got blocked";
                    yLabel.Text = "Continue";
                    rLabel.Text = "";
                    bLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.cp_block_lbj;
                    break;
                case 38:
                    outLabel.Text = "You dunked on Chris Paul";
                    yLabel.Text = "Continue";
                    rLabel.Text = "";
                    bLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.lbj_dunk;
                    break;
                case 98:
                    outLabel.Text = "The other player scored. Game Over! Choose wiser next time.";
                    rLabel.Text = "";
                    bLabel.Text = "";
                    yLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.lose;
                    SoundPlayer booSound = new SoundPlayer(Properties.Resources.boo);
                    booSound.Play();
                    Refresh();
                    Thread.Sleep(4500);
                    this.Close();
                    break;
                case 99:
                    outLabel.Text = "You scored! you won the game";
                    rLabel.Text = "";
                    bLabel.Text = "";
                    yLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.win;
                    SoundPlayer fanSound = new SoundPlayer(Properties.Resources.fans);
                    fanSound.Play();
                    Refresh();
                    Thread.Sleep(4500);
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        
    }
}
