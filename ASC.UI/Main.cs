using ASC.UI.Helpers;
using ASC.UI.ViewModels;

namespace ASC.UI
{
    public partial class Main : Form
    {
        public MainViewModel ViewModel { get; set; }

        public Main()
        {
            ViewModel = new MainViewModel();
            InitializeComponent();
            ApplyBindings();
        }

        private void ApplyBindings()
        {
            CharacterBtn.Bind(ViewModel, v => v.CharacterFormCommand);

            AttributeBtn.Bind(ViewModel, v => v.AttributeLoadCommand);
            ClassBtn.Bind(ViewModel, v => v.ClassLoadCommand);
            RaceBtn.Bind(ViewModel, v => v.RaceLoadCommand);
            SkillBtn.Bind(ViewModel, v => v.SkillLoadCommand);
        }
    }
}
