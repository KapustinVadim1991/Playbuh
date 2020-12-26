using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    [Table("Subitem")]
    public partial class Subitem
    {
        public Subitem(string subitemName, int itemId, string description = null)
        {
            SubitemName = subitemName;
            Description = description;
            ItemId = itemId;
        }

        [Column("id")]
        public int Id { get; set; }

        [Column("id_item")]
        public int ItemId { get; set; }

        [Column("subitem_name")]
        public string SubitemName { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("archive")]
        public bool IsArchive { get; set; }
    }    
}
