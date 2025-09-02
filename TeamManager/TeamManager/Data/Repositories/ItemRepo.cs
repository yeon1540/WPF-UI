using TeamManager.Data.Entity;

namespace TeamManager.Data.Repositories
{
    public class ItemRepo
    {
        private readonly sqlCMD _sqlcmd;

        public ItemRepo(SqlManager context)
        {
            _sqlcmd = new sqlCMD(context);
        }


        public bool Insert(Item item)
        {
            return _sqlcmd.Save(item);
        }

        public bool GetDataA(string pk, string data)
        {
            if (_sqlcmd.Get<Item>(pk) == null)
            {
                Item item = new Item();
                item.ItemCode = pk;
                item.ItemName = data;
                item.ItemMaker = "";

                return _sqlcmd.Save(item);
            }
            else return false;
        }
    }
}
