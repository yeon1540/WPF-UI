using Prism.Commands;

namespace TeamManager.Models
{
    public class MenuItems
    {
        public string Icon { get; set; }
        public string Text { get; set; }
        public DelegateCommand Command { get; set; }
    }
}
