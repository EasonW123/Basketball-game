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

namespace Basketball_game
{
    public partial class Form1 : Form
    {
        int scene = 1;
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
            else if (e.KeyCode == Keys.N)
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
                
                case 1:
                    outputLabel.Text = "What do you want to be?";
                    redLabel.Text = "Lebron James";
                    blueLabel.Text = "Kyrie Ivring";
                    yellowLabel.Text = "";
                    break;
                case 2:
                    outputLabel.Text = "Who do you want to play against?";
                    redLabel.Text = "Chris Paul";
                    blueLabel.Text = "Luka Doncic";
                    break;
                case 3:
                    outputLabel.Text = "Who do you want to play against?";
                    redLabel.Text = "Chris Paul";
                    blueLabel.Text = "Luka Doncic";
                    break;
                case 4:
                    outputLabel.Text = "Game to 1, you start with the ball. What do you want to do?";
                    redLabel.Text = "Shoot it in his face";
                    blueLabel.Text = "Dribble";
                    break;
                case 5:
                    outputLabel.Text = "Game to 1, you start with the ball. What do you want to do?";
                    redLabel.Text = "Shoot";
                    blueLabel.Text = "Pump fake";
                    break;
                case 6:
                    outputLabel.Text = "Game to 1, you start with the ball. What do you want to do?";
                    redLabel.Text = "Drive";
                    blueLabel.Text = "Pass";
                    break;
                case 7:
                    outputLabel.Text = "Game to 1, you start with the ball. What do you want to do?";
                    redLabel.Text = "Post up";
                    blueLabel.Text = "Dribble";
                    yellowLabel.Text = "Pass";
                    break;
                case 8:
                    outputLabel.Text = "You fake left and then crossover to the right. Doncic stays in front of you. What do you do next?";
                    redLabel.Text = "Hesi spin";
                    blueLabel.Text = "Step back three";
                    break;
                case 9:
                    outputLabel.Text = "Doncic is taller than you and blocks you. He grabs the ball and splashes a three.";
                    yellowLabel.Text = "continue.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 10:
                    outputLabel.Text = "Chris Paul bit the pump fake and there is a open lane do you take it?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    break;
                case 11:
                    outputLabel.Text = "you took the shot";
                    redLabel.Text = "Continue";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 12:
                    outputLabel.Text = "You're playing 1 on 1! There isn't an open man! You throw the ball out of bounds and Luka get the ball.";
                    yellowLabel.Text = "continue";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 13:
                    outputLabel.Text = "You blow by Luka with your speed and have an open lane. What do you do next?";
                    redLabel.Text = "Dunk";
                    blueLabel.Text = "Layup";
                    break;
                case 14:
                    outputLabel.Text = "You dribbled around the 3 point line and you can't find an opening what do you do?";
                    redLabel.Text = "Shoot";
                    blueLabel.Text = "Drive";
                    break;
                case 15:
                    outputLabel.Text = "You passed to a teammate watching the game but you are playing 1v1.";
                    yellowLabel.Text = "Continue";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 16:
                    outputLabel.Text = "You post up Chris Paul and found an opening for a shot, do you take it?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    break;
                case 17:
                    outputLabel.Text = "You get the shot off. It bounces off the front of the rim and rolls out. Luka quickly grabs the board and makes a shot from the 3 point line";
                    yellowLabel.Text = "Continue";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 18:
                    outputLabel.Text = "Luka stumbles forwards and drive past for an easy layup.";
                    yellowLabel.Text = "Continue";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 19:
                    outputLabel.Text = "You took the lane and you got in-front of Chris Paul, do you go for a layup or stop and go for a jump shot?";
                    redLabel.Text = "Shoot";
                    blueLabel.Text = "Layup";
                    break;
                case 20:
                    outputLabel.Text = "You didn't took the lane and Chris Paul recovered from the pump fake and he stole the ball from you.";
                    yellowLabel.Text = "Continue";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 21:
                    outputLabel.Text = "You missed the shot and Chris Paul got the robound and splashed a 3";
                    yellowLabel.Text = "Continue";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 22:
                    outputLabel.Text = "Luka chases you down and swats the lame layup off the backboard. Then he shoots an open mid range shot.";
                    yellowLabel.Text = "Continue";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 23:
                    outputLabel.Text = "Luka tries to block you but you throw down the huge dunk on him.";
                    yellowLabel.Text = "Continue";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 24:
                    outputLabel.Text = "You got through his defense. What do you want to do now?";
                    redLabel.Text = "Layup";
                    blueLabel.Text = "Dunk";
                    break;
                case 25:
                    outputLabel.Text = "You made the shot";
                    yellowLabel.Text = "Continue";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 26:
                    break;
                case 27:
                    outputLabel.Text = "You missed your shot.";
                    yellowLabel.Text = "Continue";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 28:
                    outputLabel.Text = "You made the shot";
                    yellowLabel.Text = "Continue";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 29:
                    outputLabel.Text = "You kept posting up Chris Paul and found an opening. what do you do?";
                    redLabel.Text = "Dunk";
                    blueLabel.Text = "Put up";
                    break;
                case 30:
                    outputLabel.Text = "You missed the shot and Chris Paul got the rebound";
                    yellowLabel.Text = "Continue";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 31:
                    outputLabel.Text = "You missed the shot and Chris Paul got the rebound";
                    yellowLabel.Text = "Continue";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 32:
                    outputLabel.Text = "You dunked on Chris Paul";
                    yellowLabel.Text = "Continue";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 33:
                    outputLabel.Text = "You missed the layup";
                    yellowLabel.Text = "Continue";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 34:
                    outputLabel.Text = "You made the layup";
                    yellowLabel.Text = "continue";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 35:
                    outputLabel.Text = "You got blocked";
                    yellowLabel.Text = "Continue";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 36:
                    outputLabel.Text = "You're shot went in";
                    yellowLabel.Text = "Continue";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 37:
                    outputLabel.Text = "You got blocked";
                    yellowLabel.Text = "Continue";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 38:
                    outputLabel.Text = "You dunked on Chris Paul";
                    yellowLabel.Text = "Continue";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                case 98:
                    outputLabel.Text = "The other player scored. Game Over! Choose wiser next time.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    yellowLabel.Text = "";
                    break;
                case 99:
                    outputLabel.Text = "You scored! you won the game";
                    Refresh();
                    Thread.Sleep(3000);
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        
    }
}
