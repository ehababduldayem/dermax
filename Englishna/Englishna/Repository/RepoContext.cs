using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Englishna.Models;
namespace Englishna.Repository
{
    public class RepoContext:DbContext
    {
        public DbSet<Tag> Tags{ get; set; }
        public DbSet<Word> Words { get; set; }
        public DbSet<Expression> Expreesions { get; set; }
        public DbSet<Sentence>Senetnces { get; set; }

    }
}