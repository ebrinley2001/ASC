using ASC.BC;
using ASC.BC.Interfaces;
using ASC.Models;
using ASC.Models.DB;
using ASC.UI.Helpers;
using System.ComponentModel;
using System.Windows.Input;

namespace ASC.UI.ViewModels.UtilForms
{
    public class BonusLoadViewModel : NotfiableObject
    {
        private IBonusBC _bonusBC;
        private Bonus _bonus;
        private string _log;

        public int Amount
        {
            get => _bonus.Amount;
            set
            {
                if (_bonus.Amount != value)
                {
                    _bonus.Amount = value;
                    OnPropertyChanged(nameof(Amount));
                }
            }
        }

        public Class SelectedClass
        {
            get => _bonus.Class;
            set
            {
                if (_bonus.Class != value)
                {
                    _bonus.Class = value;
                    OnPropertyChanged(nameof(SelectedClass));
                }
            }
        }

        public Race SelectedRace
        {
            get => _bonus.Race;
            set
            {
                if (_bonus.Race != value)
                {
                    _bonus.Race = value;
                    OnPropertyChanged(nameof(SelectedRace));
                }
            }
        }

        public Level SelectedLevel
        {
            get => _bonus.Level;
            set
            {
                if (_bonus.Level != value)
                {
                    _bonus.Level = value;
                    OnPropertyChanged(nameof(SelectedLevel));
                }
            }
        }

        public string Log
        {
            get => _log;
            set => SetField(ref _log, value);
        }

        public BindingList<Class> Classes;
        public BindingList<Race> Races;
        public BindingList<Level> Levels;

        public BindingList<Bonus> Bonuses;

        public ICommand SaveCommand { get; set; }

        public BonusLoadViewModel(IBonusBC bonusBC, IRaceBC raceBC, ILevelBC levelBC, IClassBC classBC)
        {
            _bonusBC = bonusBC;
            _bonus = new Bonus();

            SaveCommand = new RelayCommand(Save);

            Bonuses = new BindingList<Bonus>(bonusBC.GetCollection().OrderByDescending(s => s.Id).ToList());

            Classes = new BindingList<Class>(classBC.GetCollection());
            Races = new BindingList<Race>(raceBC.GetCollection());
            Levels = new BindingList<Level>(levelBC.GetCollection());

            Classes.Insert(0, new Class() { Id = -1, Name = "Select a Class" });
            Races.Insert(0, new Race() { Id = -1, Name = "Select a Race" });
            Levels.Insert(0, new Level() { Id = -1 });
        }

        private void Save()
        {
            int result = _bonusBC.Create(_bonus);
            Log = $"Bonus was created with a result of {result}";
            Bonuses.Insert(0, _bonus);

            _bonus = new Bonus();

            SelectedClass = Classes[0];
            SelectedRace = Races[0];
            SelectedLevel = Levels[0];

            OnPropertyChanged(nameof(Amount));
            OnPropertyChanged(nameof(SelectedClass));
            OnPropertyChanged(nameof(SelectedRace));
            OnPropertyChanged(nameof(SelectedLevel));
        }

        public void OnRowDelete(object sender, DataGridViewRowCancelEventArgs e)
        {
            Bonus bonus = e.Row.DataBoundItem as Bonus;
            if (bonus != null)
            {
                _bonusBC.Delete(bonus);
            }
        }
    }
}
