using HangmanData;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanLogic
{
    public class HangmanLogicController
    {

        private List<Word> _words;
        private HangmanEntities _hangmanEntities;
        private string _guessWord;
        private string _wordActualResult;
        private string _gameStatus;
        private string _selectedCharacters;
        private int _hangmanCounter;
        private Image _myImage;
        private Graphics _graphics;


        public HangmanLogicController(ref PictureBox pBox , ref string wordResult , ref string gameStatus , ref string selectedCharacters  )
        {
            _words = new List<Word>();
            _hangmanEntities = new HangmanEntities();
         //   _myImage = pBox.Image;

            LoadAllWordsFromDatabase();

            RestartHangmanAndLoadHangmanBackground();

            pBox.Image = _myImage ;

            wordResult = _wordActualResult;
            gameStatus = _gameStatus;
            selectedCharacters = _selectedCharacters;


        }


        public void PlayGame(bool startNewGame, string selectedCharacter, ref PictureBox pBox, ref string wordResult, ref string gameStatus, ref string selectedCharacters)
        {

            if (startNewGame)
            {
                RestartHangmanAndLoadHangmanBackground();
            }
            else
            {
                if (selectedCharacter.Length == 1)
                {
                    _selectedCharacters += selectedCharacter;

                }
            }

           
            

            pBox.Image = _myImage;

            wordResult = _wordActualResult;
            gameStatus = _gameStatus;
            selectedCharacters = _selectedCharacters;


        }

        private void RestartHangmanAndLoadHangmanBackground()
        {
            LoadAllWordsFromDatabase();
            GetNewRandamWord();

            _gameStatus = "lala"; // TODO status überall ergänzen


            _selectedCharacters = "";
            _hangmanCounter = 0;
            _myImage = Image.FromFile("hangman0.jpg");
            _graphics = Graphics.FromImage(_myImage);

            PutCharacterIntoTheWord();

        }

     

        private void LoadAllWordsFromDatabase()
        {
            _words = _hangmanEntities.Word.Select(x => x).ToList();
        }

        private void GetNewRandamWord()
        {
            _selectedCharacters = "";

            LoadAllWordsFromDatabase();

            Random random = new Random();
            int number = random.Next(_words.Count);

            _guessWord = _words.ElementAt(number).Word1;

            
        }

        public void AddNewWord(string word)
        {
            Word w = new Word()
            {
                Word1 = word,                
            };

            _hangmanEntities.Word.Add(w);
            _hangmanEntities.SaveChanges();
        }

        public bool IsCharacterInWord(char c)
        {
            if (_guessWord == null)
            {
                GetNewRandamWord();
            }

            _selectedCharacters += c.ToString();

            if (_guessWord.ToUpper().Contains(c.ToString().ToUpper()))
            {
                //_selectedCharacters.Insert(_selectedCharacters.Length, c.ToString());
                
                PutCharacterIntoTheWord();
                return true;
            }
            else
            {
                return false;
            }

        }

        private void PutCharacterIntoTheWord()
        {
            _wordActualResult = "";

            foreach (var guessCharacter in _guessWord)
            {
                bool isCharacterCorrect = false;
                foreach (var selectedCharacter in _selectedCharacters)
                {
                    if (selectedCharacter.ToString().ToUpper().Equals(guessCharacter.ToString().ToUpper()))
                    {
                        isCharacterCorrect = true;
                        break;
                    }
                }

                if (isCharacterCorrect)
                {                 
                    _wordActualResult += guessCharacter;
                }
                else
                {                
                    _wordActualResult += "_";
                }
            }
        }

        public string GetSelectedCharacters()
        {
            return _selectedCharacters;
        }

        public string GetWordResult()
        {
            PutCharacterIntoTheWord();
            return _wordActualResult;
        }

        public string GetGameStatus()
        {
            return "Game status";
        }
       
        public void Paint( ref Graphics graphics)
        {
            Pen pen = new Pen(Color.BlueViolet);
            pen.Width = 5;
            graphics.DrawLine(pen, 70, 70, 170, 170);

            DrawHangman();
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
            
        }

        private void DrawLine(int x1, int y1, int x2, int y2)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            pen.Width = 5;
            _graphics.DrawLine(pen, x1, y1, x2, y2);
        }

        private void DrawCircle(float x, float y, float diameter)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            pen.Width = 5;
            _graphics.DrawEllipse(pen, x, y, diameter, diameter);
        }

        private void DrawCurve(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            pen.Width = 5;
            Point[] points = new Point[] { new Point(x1, y1), new Point(x2, y2), new Point(x3, y3) };
            _graphics.DrawCurve(pen, points);
        }


    }
}
