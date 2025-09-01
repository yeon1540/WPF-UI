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
    }
}
