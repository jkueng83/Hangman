
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
        private HangmanLogicController _hangmanLogicController;
        private string _wordActualResult;
        private string _gameStatus;
        private string _selectedCharacters;

        public Form1()
        {
            InitializeComponent();

            _hangmanLogicController = new HangmanLogicController(ref pictureBox1, 
                ref _wordActualResult, ref _gameStatus, ref _selectedCharacters);
           
            UpdateForm();
        }

        private void UpdateForm()
        {
            lbWord.Text = _wordActualResult;
            lbGameStatus.Text = _gameStatus;
            lbSelectedCharacters.Text = _selectedCharacters;          
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
          _hangmanLogicController.PlayGame(true, ' ', ref pictureBox1,
                ref _wordActualResult, ref _gameStatus, ref _selectedCharacters);

            UpdateForm();
        }

        private void tBoxCharacter_Click(object sender, EventArgs e)
        {
            tBoxCharacter.Text = "";
        }

        private void tBoxCharacter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MakeAChoise();
            }
        }

        private void btGuess_Click(object sender, EventArgs e)
        {
            MakeAChoise();
        }

        private void MakeAChoise()
        {
            if (tBoxCharacter.Text.Length == 1)
            {
                _hangmanLogicController.PlayGame(false, tBoxCharacter.Text.ElementAt(0), ref pictureBox1,
                    ref _wordActualResult, ref _gameStatus, ref _selectedCharacters);
            }

            tBoxCharacter.Text = "";
            UpdateForm();
        }
    }
}
