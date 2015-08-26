using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vocab.model;
using vocab.model.Interfaces;

namespace vocab.datamodel.sql
{
    public class WordRepo : IWordRepo
    {
        VocabContext _context;

        public WordRepo()
        {
            _context = new VocabContext();
        }

        public void AddWord(string text)
        {
            Word word = new Word()
            {
                Id = 0, // auto number
                Text = text
            };

            _context.Words.Add(word);
            _context.SaveChanges();
        }

        public IEnumerable<model.Word> GetWords()
        {
            var dbWords = _context.Words.Select(w => w);

            foreach(var w in dbWords)
            {
                yield return new Word() { Id = w.Id, Text = w.Text };
            }
        }
    }
}
