using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vocab.model;

namespace vocab.datamodel.sql
{
    public class VocabContext:DbContext
    {
        public DbSet<Word> Words { get; set; }
    }
}
