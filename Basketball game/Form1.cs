using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    break;
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    break;
                case 21:
                    break;
                case 22:
                    break;
                case 23:
                    break;
                case 24:
                    break;
                case 25:
                    break;
                case 26:
                    break;
                case 27:
                    break;
                case 28:
                    break;
                default:
                    break;
            }
        }

        
    }
}
