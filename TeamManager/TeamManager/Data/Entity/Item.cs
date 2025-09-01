using System.ComponentModel.DataAnnotations;

namespace TeamManager.Data.Entity
{
    public class Item
    {
        [Key]
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemMaker { get; set; }
    }
}
