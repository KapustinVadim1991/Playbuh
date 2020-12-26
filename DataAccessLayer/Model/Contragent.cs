using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Model
{
    [Table("Contragent")]
    public partial class Contragent
    {
        public Contragent() { }

        public Contragent(string title, string comment = null)
        {
            Title = title;
            Comment = comment;

        }

        [Column("id")]
        public int Id { get; set; }
        
        [Column("title")]
        public string Title { get; set; }

        [Column("comment")]
        public string Comment { get; set; }

        [Column("archive")]
        public bool IsArchive { get; set; }
    }
}
