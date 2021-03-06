﻿using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Model
{
    [Table("Item")]
    public partial class Item
    {
        public Item() { }

        public Item(string itemName, bool isRevenue, string description)
        {            
            ItemName = itemName;
            IsRevenue = isRevenue;
            Description = description;
        }

        [Column("Id")]
        public int Id { get; set; }

        [Column("item_name")]
        public string ItemName { get; set; }

        [Column("is_revenue")]
        public bool IsRevenue { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("archive")]
        public bool IsArchive { get; set; }
    }
}
