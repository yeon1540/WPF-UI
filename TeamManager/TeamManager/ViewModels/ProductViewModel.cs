using Prism.Commands;
using Prism.Mvvm;
using TeamManager.Data;
using TeamManager.Data.Entity;

namespace TeamManager.ViewModels
{
    public class ProductViewModel : BindableBase
    {
        public DelegateCommand ProductAddCommand { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemMaker { get; set; }

        public ProductViewModel()
        {
            ProductAddCommand = new DelegateCommand(() => ProductADD());
        }

        private void ProductADD()
        {
            using (var db = new TeamManagerDbContext())
            {
                var items = new Item
                {
                    ItemId = 1,
                    ItemCode = ItemCode,
                    ItemName = ItemName,
                    ItemMaker = ItemMaker
                };

                db.Items.Add(items);
                db.SaveChanges();
            }
        }
    }
}
