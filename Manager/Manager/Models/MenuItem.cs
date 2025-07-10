using Prism.Commands;

namespace Manager.Models
{
    public class MenuItem
    {
        public string Icon { get; set; }
        public string Text { get; set; }
        public DelegateCommand Command { get; set; }
    }
}
