using HangmanData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanController
{
    public class HangmanController
    {

        private List<Word> _words;
        private HangmanEntities _hangmanEntities;

        public HangmanController()
        {
            _words = new List<Word>();
            _hangmanEntities = new HangmanEntities();

            LoadAllWordsFromDatabase();
        }

        private void LoadAllWordsFromDatabase()
        {
            _words = _hangmanEntities.Word.Select(x => x).ToList();
        }

        

    }
}
