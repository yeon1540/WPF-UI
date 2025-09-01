using System.ComponentModel.DataAnnotations;

namespace TeamManager.Data.Entity
{
    public class ItemCategory
    {
        [Key]
        public string Category { get; set; }
    }
}
