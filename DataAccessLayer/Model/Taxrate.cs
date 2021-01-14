using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Model
{
    [Table("Taxrate")]
    public class Taxrate
    {
        public Taxrate() { }

        public Taxrate(int taxPercent, string description)
        {
            TaxPercent = taxPercent;
            Description = description;
        }

        [Column("id")] 
        public int Id { get; set; }

        [Column("tax_percent")]
        public int TaxPercent { get; set; }
                
        [Column("description")]
        public string Description { get; set; }

        [Column("archive")]
        public bool IsArchive { get; set; }
    } 
}
