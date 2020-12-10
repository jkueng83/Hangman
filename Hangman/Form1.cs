
using HangmanLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        private Graphics _g;
        private int _hangmanCounter;
        private Image _myImage;
       
        HangmanLogicController _hangmanLogicController;

        public Form1()
        {
            InitializeComponent();

             _myImage = Image.FromFile("hangman0.jpg");       
                        _g = Graphics.FromImage(_myImage);
            UpdateImage();

            _hangmanCounter = 0;

            _hangmanLogicController = new HangmanLogicController();
        }

        private void UpdateImage()
        {
            pictureBox1.Image = _myImage;
        }       

        private void DrawHangman() 
        {
            _hangmanCounter++;

            switch (_hangmanCounter)
            {
                case 1:
                    DrawLine(50, 50, 50, 330);
                    break;
                case 2:
                    DrawLine(48, 50, 153, 50);
                    break;
                case 3:
                    DrawLine(50, 100, 100, 50);
                    break;
                case 4:
                    DrawLine(150, 50, 150, 100);
                    break;
                case 5:
                    DrawCircle(125, 100, 50); // Head
                    DrawLine(150, 120, 150, 130); // nose
                    DrawCircle(140, 120, 1); // eye
                    DrawCircle(160, 120, 1); // eye
                    DrawCurve(140, 135, 150, 140, 160, 135); //mouth
                    break;
                case 6:
                    DrawLine(150, 150, 150, 233);//body
                    break;
                case 7:
                    DrawLine(150, 170, 180, 200); //left arm
                    break;
                case 8:
                    DrawLine(150, 170, 120, 200); // right arm
                    break;
                case 9:
                    DrawLine(150, 230, 180, 300); 
                    break;
                case 10:
                    DrawLine(150, 230, 120, 300);
                    break;
                default:
                    break;
            }

            UpdateImage();
        }


        private void DrawLine(int x1, int y1, int x2, int y2)
        {
           Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
           pen.Width = 5;           
            _g.DrawLine(pen, x1, y1, x2, y2);           
        }

        private void DrawCircle(float x, float y, float diameter)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            pen.Width = 5;
            _g.DrawEllipse(pen, x, y, diameter, diameter);
        }

        private void DrawCurve(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            pen.Width = 5;
            Point[] points = new Point[] { new Point(x1, y1), new Point(x2, y2), new Point(x3, y3) };
            _g.DrawCurve(pen, points);

        }
        
        private void btTest_Click(object sender, EventArgs e)
        {
          
            DrawHangman();
        }

        private void btAddNewWord_Click(object sender, EventArgs e)
        {
            _hangmanLogicController.AddNewWord(tBoxAddNewWord.Text);
            tBoxAddNewWord.Text = "Add new Word";
        }

        private void tBoxAddNewWord_Click(object sender, EventArgs e)
        {
            tBoxAddNewWord.Text = "";
        }

        private void btPlayNewGame_Click(object sender, EventArgs e)
        {
            lbWord.Text = _hangmanLogicController.GetNewRandamWord();
        }

        private void tBoxCharacter_Click(object sender, EventArgs e)
        {
            tBoxCharacter.Text = "";
        }

        private void tBoxCharacter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tBoxCharacter.Text.Length == 1)
                {
                    if (_hangmanLogicController.IsCharacterInWord(tBoxCharacter.Text.ElementAt(0)))
                    {
                        lbWord.Text = _hangmanLogicController.GetWordResult();
                    }
                    else
                    {
                        DrawHangman();
                    }
                }

                tBoxCharacter.Text = "";

                UpdateWindow();                
            }
        }

        private void UpdateWindow()
        {
            UpdateSelectedCharacters();
            UpdateGameStatus();
        }

        private void UpdateGameStatus()
        {
            lbGameStatus.Text = _hangmanLogicController.GetGameStatus();
        }

        private void UpdateSelectedCharacters()
        {
            lbSelectedCharacters.Text = _hangmanLogicController.GetSelectedCharacters();
        }

        

    }
}
