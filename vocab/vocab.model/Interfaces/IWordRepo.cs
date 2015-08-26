using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vocab.model.Interfaces
{
    public interface IWordRepo
    {
        void AddWord(string text);
        IEnumerable<Word> GetWords();
    }
}
