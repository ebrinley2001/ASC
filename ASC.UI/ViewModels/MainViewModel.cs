using ASC.UI.Helpers;
using ASC.UI.UtilForms;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Input;

namespace ASC.UI.ViewModels
{
    public class MainViewModel : NotifiableViewModel
    {
        private CharacterCreationForm _characterCreationForm;
        private AttributeLoad _attributeLoadForm;
        private ClassLoad _classLoadForm;
        private RaceLoad _raceLoadForm;
        private SkillLoad _skillLoadForm;

        public ICommand CharacterFormCommand { get; set; }
        public ICommand AttributeLoadCommand { get; set; }
        public ICommand ClassLoadCommand { get; set; }
        public ICommand RaceLoadCommand { get; set; }
        public ICommand SkillLoadCommand { get; set; }

        public MainViewModel()
        {
            CharacterFormCommand = new RelayCommand(ShowCharacterCreationForm);
            AttributeLoadCommand = new RelayCommand(ShowAttributeLoadForm);
            ClassLoadCommand = new RelayCommand(ShowClassLoadForm);
            RaceLoadCommand = new RelayCommand(ShowRaceLoadForm);
            SkillLoadCommand = new RelayCommand(ShowSkillLoadForm);
        }

        private void ShowCharacterCreationForm()
        {
            _characterCreationForm = Program.ServiceProvider.GetRequiredService<CharacterCreationForm>();
            _characterCreationForm.ShowDialog();
        }

        private void ShowAttributeLoadForm()
        {
            _attributeLoadForm = Program.ServiceProvider.GetRequiredService<AttributeLoad>();
            _attributeLoadForm.ShowDialog();
        }

        private void ShowClassLoadForm()
        {
            _classLoadForm = Program.ServiceProvider.GetRequiredService<ClassLoad>();
            _classLoadForm.ShowDialog();
        }

        private void ShowRaceLoadForm()
        {
            _raceLoadForm = Program.ServiceProvider.GetRequiredService<RaceLoad>();
            _raceLoadForm.ShowDialog();
        }

        private void ShowSkillLoadForm()
        {
            _skillLoadForm = Program.ServiceProvider.GetRequiredService<SkillLoad>();
            _skillLoadForm.ShowDialog();
        }
    }
}
