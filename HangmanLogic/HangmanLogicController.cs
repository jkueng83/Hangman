using HangmanData;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanLogic
{
    public class HangmanLogicController
    {

        private List<Word> _words;
        private HangmanEntities _hangmanEntities;
        private string _guessWord;
        private string _wordActualResult;
        private string _selectedCharacters;


        public HangmanLogicController()
        {
            _words = new List<Word>();
            _hangmanEntities = new HangmanEntities();

            LoadAllWordsFromDatabase();
        }

        private void LoadAllWordsFromDatabase()
        {
            _words = _hangmanEntities.Word.Select(x => x).ToList();
        }

        public string GetNewRandamWord()
        {
            _selectedCharacters = "";

            LoadAllWordsFromDatabase();

            Random random = new Random();
            int number = random.Next(_words.Count);

            _guessWord = _words.ElementAt(number).Word1;

            PutCharacterIntoTheWord();

            for (int i = 0; i < _guessWord.Length; i++) 
            {
                _wordActualResult += "_";
            }

            return _wordActualResult;
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
            if (_guessWord ==null)
            {
                GetNewRandamWord();
            }

            if (_guessWord.ToUpper().Contains(c.ToString().ToUpper()))
            {
                //_selectedCharacters.Insert(_selectedCharacters.Length, c.ToString());
                _selectedCharacters += c.ToString();
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
            
            foreach (var character in _selectedCharacters)
            {
                for (int i = 0; i < _guessWord.Length; i++)
                {
                    if (character.ToString().ToUpper().Equals(_guessWord.ElementAt(i).ToString().ToUpper()))
                    {

                        // hier weiter
                        _wordActualResult += _guessWord.ElementAt(i);
                    }
                    else
                    {
                        _wordActualResult += "_";
                    }
                }
            }



                
                        
        }

        public string GetWordResult()
        {
            PutCharacterIntoTheWord();
            return _wordActualResult;
        }
       


    }
}
