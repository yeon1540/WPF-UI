using Prism.Commands;
using Prism.Mvvm;
using TeamManager.Data;
using TeamManager.Data.Entity;

namespace TeamManager.ViewModels
{
    public class ProductViewModel : BindableBase
    {
        SqlManager _sql = new SqlManager();

        Item items = new Item();

        public DelegateCommand ProductAddCommand { get; set; }

        public ProductViewModel()
        {
            ProductAddCommand = new DelegateCommand(() => ProductADD());
            CategoryAddCommand = new DelegateCommand(() => CategoryADD());
        }

        private void ProductADD()
        {
            //items.ItemCode = "1";
            //items.ItemMaker = "미쯔비시";
            //items.ItemName = "차단기";

            //_sql.ItemsRepo.Insert(items);

            _sql.ItemsRepo.GetDataA("1", "품묵이다1");
        }

        public DelegateCommand CategoryAddCommand { get; set; }
        public string Category { get; set; }

        private void CategoryADD()
        {
            var itemsCategorys = new ItemCategory
            {
                Category = Category
            };

            _sql.ItemCategorys.Add(itemsCategorys);
            _sql.SaveChanges();
        }
    }
}
