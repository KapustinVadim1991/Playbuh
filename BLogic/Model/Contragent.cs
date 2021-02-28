using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BLogic.Model
{
    [Table("Contragent")]
    public partial class Contragent
    {
        public Contragent() { }

        public Contragent(DataAccessLayer.Model.Contragent contragent)
        {
            Id = contragent.Id;
            Title = contragent.Title;
            Comment = contragent.Comment;
            IsArchive = contragent.IsArchive;
        }

        [Display(AutoGenerateField = false)]
        public int Id { get; set; }

        [Display(Name = "Описание")]
        public string Title { get; set; }

        [Display(Name = "Комментарий")]
        public string Comment { get; set; }

        [Display(AutoGenerateField = false)]
        public bool IsArchive { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}