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
        private string _gameStatusString;
        private string _selectedCharacters;
        private int _hangmanCounter;
        private Image _myImage;
        private Graphics _graphics;
        enum GameStatus { GameIsActive, GameOver, YouWinTheGame };
        private GameStatus _gameStatus;

        public HangmanLogicController(ref PictureBox pBox , ref string wordResult , ref string gameStatus , ref string selectedCharacters  )
        {
            _words = new List<Word>();
            _hangmanEntities = new HangmanEntities();

            LoadAllWordsFromDatabase();

            PlayGame(true, ' ',ref pBox, ref wordResult, ref gameStatus, ref selectedCharacters);

            pBox.Image = _myImage ;
            wordResult = _wordActualResult;
            gameStatus = _gameStatusString;
            selectedCharacters = _selectedCharacters;
        }


        public void PlayGame(bool startNewGame, char selectedCharacter, ref PictureBox pBox, ref string wordResult, ref string gameStatus, ref string selectedCharacters)
        {
            if (startNewGame)
            {
                RestartHangmanAndLoadHangmanBackground();
            }
            else if (_gameStatus == GameStatus.GameIsActive)
            {
                _selectedCharacters += selectedCharacter + " ";

                if (IsCharacterInWord(selectedCharacter))
                {
                    PutCharacterIntoTheWord();
                }
                else
                {
                    DrawHangman();
                }
            }            

            UpdateGameStatus();

            pBox.Image = _myImage;
            wordResult = _wordActualResult;
            gameStatus = _gameStatusString;
            selectedCharacters = _selectedCharacters;
        }

        private void RestartHangmanAndLoadHangmanBackground()
        {
            LoadAllWordsFromDatabase();
            GetNewRandamWord();

            _gameStatus = GameStatus.GameIsActive;

            _selectedCharacters = "";
            _hangmanCounter = 0;
            _myImage = Image.FromFile("hangman0.jpg");
            _graphics = Graphics.FromImage(_myImage);
           
            PutCharacterIntoTheWord();
            UpdateGameStatus();
        }

        private void UpdateGameStatus()
        {
            if (_wordActualResult.Count(character => character == '_') == 0)
            {
                _gameStatus = GameStatus.YouWinTheGame;
            }   

            switch (_gameStatus)
            {
                case GameStatus.GameIsActive:
                    _gameStatusString = "Game is running";
                    break;
                case GameStatus.YouWinTheGame:
                    _gameStatusString = "You won the Game";
                    break;
                case GameStatus.GameOver:
                    _gameStatusString = "Game Over!! - " + _guessWord;
                    break;
                default:
                    _gameStatusString = "Not defined Game Status"; 
                    break;
            }
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

            if (_guessWord.ToUpper().Contains(c.ToString().ToUpper()))
            {                
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

                _wordActualResult += " ";
            }
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
                    _gameStatus = GameStatus.GameOver;
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
