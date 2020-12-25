using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Model
{
    [Table("Operation")]
    public class Operation
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("operation_date")]
        public DateTime OperationDate { get; set; }

        [Column("revenue")]
        public decimal Revenue { get; set; }

        [Column("earnings")]
        public decimal? Earnings { get; set; }

        [Column("create_date")]
        public DateTime? CreateDate { get; set; }

        [Column("id_contragent")]
        public int ContragentId { get; set; }

        [Column("id_employee")]
        public int EmployeeId { get; set; }

        [Column("id_subitem")]
        public int SubitemId { get; set; }

        [Column("id_tax_rate")]
        public int TaxrateId { get; set; }
    }
}
