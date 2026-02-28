using ASC.BC;
using ASC.BC.Interfaces;
using ASC.Models.DB;
using ASC.UI.Helpers;
using System.ComponentModel;
using System.Windows.Input;

namespace ASC.UI.ViewModels.UtilForms
{
    public class RaceLoadViewModel : NotifiableViewModel
    {
        private IRaceBC _raceBC;

        private Race _race;

        private string _log;
        public string Name
        {
            get => _race.Name;
            set
            {
                if (_race.Name != value)
                {
                    _race.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public string Desc
        {
            get => _race.Description;
            set
            {
                if (_race.Description != value)
                {
                    _race.Description = value;
                    OnPropertyChanged(nameof(Desc));
                }
            }
        }

        public string Log
        {
            get => _log;
            set => SetField(ref _log, value);
        }

        public BindingList<Race> Races;

        public ICommand SaveCommand { get; set; }

        public RaceLoadViewModel(IRaceBC raceBC)
        {
            _raceBC = raceBC;
            _race = new Race();

            SaveCommand = new RelayCommand(Save);

            Races = new BindingList<Race>(_raceBC.GetCollection().OrderByDescending(r => r.Id).ToList());
        }

        private void Save()
        {
            int result = _raceBC.Create(_race);
            Log = $"{Name} was created with a result of {result}";
            Races.Insert(0, _race);

            _race = new Race();
            OnPropertyChanged(nameof(Name));
            OnPropertyChanged(nameof(Desc));
        }

        public void OnRowDelete(object sender, DataGridViewRowCancelEventArgs e)
        {
            Race race = e.Row.DataBoundItem as Race;
            if (race != null)
            {
                _raceBC.Delete(race);
            }
        }
    }
}
